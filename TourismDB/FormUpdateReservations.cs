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
            textReserv.Add(textBoxReservationDate);
            textReserv.Add(textBoxSeatsReserved);
            LoadClientIDs();
            LoadReservationIDs();
            LoadToursIDs();
            comboBoxClientID.Enabled = false;
            comboBoxTourID.Enabled = false;
            comboBoxStatus.Enabled = false;
            Form1.SetReadOnly(textReserv, true);
        }

        private void LoadDataReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxIDReservation.Text))
            {
                MessageBox.Show("Введите ID брони.");
                return;
            }
            Form1.ExecuteQuery($"SELECT ClientID, TourID, ReservationDate, SeatsReserved, Status FROM Reservation WHERE ReservationID = {comboBoxIDReservation.Text}");
            if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
            {
                DataRow row = Form1.currentDataTable.Rows[0];
                comboBoxClientID.Text = row["ClientID"].ToString();
                comboBoxTourID.Text = row["TourID"].ToString();
                textBoxReservationDate.Text = row["ReservationDate"].ToString();
                textBoxSeatsReserved.Text = row["SeatsReserved"].ToString();
                comboBoxStatus.Text = row["Status"].ToString();
                Form1.SetReadOnly(textReserv, false);
                comboBoxStatus.Enabled = true;
                comboBoxClientID.Enabled = true;
                comboBoxTourID.Enabled = true;
            }
            else
            {
                MessageBox.Show("Бронь с таким ID не найден.");
                ClearFields();
            }
        }

        private void LoadClientIDs()
        {
            try
            {
                Form1.ExecuteQuery("SELECT ClientID FROM Clients ORDER BY ClientID");

                if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
                {
                    comboBoxClientID.Items.Clear();

                    foreach (DataRow row in Form1.currentDataTable.Rows)
                    {
                        comboBoxClientID.Items.Add(row["ClientID"].ToString());
                    }

                    if (comboBoxClientID.Items.Count > 0)
                    {
                        comboBoxClientID.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось загрузить ID клиентов.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке ID клиентов: {ex.Message}");
            }
        }

        private void LoadReservationIDs()
        {
            try
            {
                Form1.ExecuteQuery("SELECT ReservationID FROM Reservation ORDER BY ReservationID");

                if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
                {
                    comboBoxIDReservation.Items.Clear();

                    foreach (DataRow row in Form1.currentDataTable.Rows)
                    {
                        comboBoxIDReservation.Items.Add(row["ReservationID"].ToString());
                    }

                    if (comboBoxIDReservation.Items.Count > 0)
                    {
                        comboBoxIDReservation.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось загрузить ID клиентов.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке ID клиентов: {ex.Message}");
            }
        }

        private void LoadToursIDs()
        {
            try
            {
                Form1.ExecuteQuery("SELECT TourID FROM Tours ORDER BY TourID");

                if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
                {
                    comboBoxTourID.Items.Clear();

                    foreach (DataRow row in Form1.currentDataTable.Rows)
                    {
                        comboBoxTourID.Items.Add(row["TourID"].ToString());
                    }

                    if (comboBoxTourID.Items.Count > 0)
                    {
                        comboBoxTourID.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось загрузить ID клиентов.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке ID клиентов: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            comboBoxClientID.Enabled = false;
            comboBoxTourID.Enabled = false;
            textBoxReservationDate.Text = "";
            textBoxSeatsReserved.Text = "";
            Form1.SetReadOnly(textReserv, true);
            comboBoxStatus.Enabled = false;
        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            if (comboBoxClientID.Text == "" || comboBoxTourID.Text == "" || textBoxReservationDate.Text == "" || textBoxSeatsReserved.Text == "")
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
            Form1.ExecuteQuery($"SELECT 1 FROM Clients WHERE ClientID = {comboBoxClientID.Text}", null);
            if (Form1.currentDataTable.Rows.Count == 0)
            {
                MessageBox.Show($"Клиент с ID {comboBoxClientID.Text} не найден.");
                return;
            }
            Form1.ExecuteQuery($"SELECT 1 FROM Tours WHERE TourID = {comboBoxTourID.Text}", null);
            if (Form1.currentDataTable.Rows.Count == 0)
            {
                MessageBox.Show($"Тур с ID {comboBoxTourID.Text} не найден.");
                return;
            }
            Form1.ExecuteQuery($"SELECT AvailableSeats FROM Tours WHERE TourID = {comboBoxTourID.Text}", null);
            int availableSeats = Convert.ToInt32(Form1.currentDataTable.Rows[0]["AvailableSeats"]);
            if (availableSeats < seatsReserved)
            {
                MessageBox.Show("Недостаточно доступных мест для бронирования.");
                return;
            }
            string reservId = comboBoxIDReservation.Text;
            Form1.ExecuteQuery($"UPDATE Reservation SET ClientID = '{comboBoxClientID.Text}', TourID = '{comboBoxTourID.Text}', ReservationDate = '{textBoxReservationDate.Text}', " +
            $"SeatsReserved = '{textBoxSeatsReserved.Text}', Status = '{comboBoxStatus.Text}' WHERE ReservationID = '{comboBoxIDReservation.Text}'");
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