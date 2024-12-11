using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class AddReservationsForm : Form
    {
        public string status = "";
        public AddReservationsForm()
        {
            InitializeComponent();
        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            if (textBoxClientID.Text == "" || textBoxTourID.Text == "" || textBoxReservationDate.Text == "" || textBoxSeatsReserved.Text == "")
            {
                MessageBox.Show("Не удалось добавить бронирование. Заполните обязательные поля: ID Клиента, ID Тура, Дата бронирования, Мест забронировано.");
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
            switch (comboBoxStatus.Text)
            {
                case "Выполняется":
                    status = "Pending";
                    break;
                case "Подтвержден":
                    status = "Confirmed";
                    break;
            }
            try
            {
                Form1.ExecuteQuery($"INSERT INTO Reservation (ClientID, TourID, ReservationDate, SeatsReserved, Status) VALUES (" +
                $"{textBoxClientID.Text}, {textBoxTourID.Text}, '{textBoxReservationDate.Text}', {seatsReserved.ToString()}, '{status}')");
                Form1.ExecuteQuery($"UPDATE Tours SET AvailableSeats = AvailableSeats - {seatsReserved} WHERE TourID = {textBoxTourID.Text}");
                MessageBox.Show("Бронирование успешно добавлено.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении бронирования: {ex.Message}");
            }
        }
        private void ClearFields()
        {
            textBoxClientID.Text = "";
            textBoxTourID.Text = "";
            textBoxReservationDate.Text = "";
            textBoxSeatsReserved.Text = "";
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
