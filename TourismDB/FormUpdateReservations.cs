using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class FormUpdateReservations : Form
    {
        public List<System.Windows.Forms.TextBox> textReserv = new List<System.Windows.Forms.TextBox>();

        public FormUpdateReservations()
        {
            InitializeComponent();
            comboBoxStatus.SelectedIndex = 0;
            textReserv.Add(textBoxClientID);
            textReserv.Add(textBoxTourID);
            textReserv.Add(textBoxReservationDate);
            textReserv.Add(textBoxSeatsReserved);
            comboBoxStatus.Enabled = false;
            Form1.SetReadOnly(textReserv, true);
        }

        private void LoadDataReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIDReservation.Text))
            {
                MessageBox.Show("Введите ID брони.");
                return;
            }
            Form1.ExecuteQuery($"SELECT ClientID, TourID, ReservationDate, SeatsReserved, Status FROM Reservation WHERE ReservationID = {textBoxIDReservation.Text}");
            if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
            {
                DataRow row = Form1.currentDataTable.Rows[0];
                textBoxClientID.Text = row["ClientID"].ToString();
                textBoxTourID.Text = row["TourID"].ToString();
                textBoxReservationDate.Text = row["ReservationDate"].ToString();
                textBoxSeatsReserved.Text = row["SeatsReserved"].ToString();
                comboBoxStatus.Text = row["Status"].ToString();
                Form1.SetReadOnly(textReserv, false);
                comboBoxStatus.Enabled = true;
            }
            else
            {
                MessageBox.Show("Бронь с таким ID не найден.");
                ClearFields();
            }
        }

        private void ClearFields()
        {
            textBoxIDReservation.Text = "";
            textBoxClientID.Text = "";
            textBoxTourID.Text = "";
            textBoxReservationDate.Text = "";
            textBoxSeatsReserved.Text = "";
            Form1.SetReadOnly(textReserv, true);
            comboBoxStatus.Enabled = false;
        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            if (textBoxClientID.Text == "" || textBoxTourID.Text == "" || textBoxReservationDate.Text == "" || textBoxSeatsReserved.Text == "")
            {
                MessageBox.Show("Обязательные поля не могут быть пустыми: ID Клиента, ID Тура, Дата бронирования, Мест забронировано.");
                return;
            }
            int seatsReserved;
            if (!int.TryParse(textBoxSeatsReserved.Text, out seatsReserved))
            {
                MessageBox.Show("SeatsReserved должен быть числом.");
                return;
            }
            Form1.ExecuteQuery($"SELECT 1 FROM Clients WHERE ClientID = {textBoxClientID.Text}", null);
            if (Form1.currentDataTable.Rows.Count == 0)
            {
                MessageBox.Show($"Клиент с ID {textBoxClientID.Text} не найден.");
                return;
            }
            Form1.ExecuteQuery($"SELECT 1 FROM Tours WHERE TourID = {textBoxTourID.Text}", null);
            if (Form1.currentDataTable.Rows.Count == 0)
            {
                MessageBox.Show($"Тур с ID {textBoxTourID.Text} не найден.");
                return;
            }
            Form1.ExecuteQuery($"SELECT AvailableSeats FROM Tours WHERE TourID = {textBoxTourID.Text}", null);
            int availableSeats = Convert.ToInt32(Form1.currentDataTable.Rows[0]["AvailableSeats"]);
            if (availableSeats < seatsReserved)
            {
                MessageBox.Show("Недостаточно доступных мест для бронирования.");
                return;
            }
            string reservId = textBoxIDReservation.Text;
            Form1.ExecuteQuery($"UPDATE Reservation SET ClientID = '{textBoxClientID.Text}', TourID = '{textBoxTourID.Text}', ReservationDate = '{textBoxReservationDate.Text}', " +
            $"SeatsReserved = '{textBoxSeatsReserved.Text}', Status = '{comboBoxStatus.Text}' WHERE ReservationID = '{textBoxIDReservation.Text}'");
            MessageBox.Show("Операция прошла успешно");
            ClearFields();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1.GoForm1(this);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void FormUpdateReservations_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}