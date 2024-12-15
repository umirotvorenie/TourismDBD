using System;
using System.Data;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class AddReservationsForm : Form
    {
        public AddReservationsForm()
        {
            InitializeComponent();
            LoadClientIDs();
            LoadToursIDs();
        }

        private void buttonAddReservation_Click(object sender, EventArgs e)
        {
            if (comboBoxClientID.Text == "" || comboBoxTourID.Text == "" || textBoxReservationDate.Text == "" || textBoxSeatsReserved.Text == "")
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
            try
            {
                Form1.ExecuteQuery($"INSERT INTO Reservation (ClientID, TourID, ReservationDate, SeatsReserved, Status) VALUES (" +
                $"{comboBoxClientID.Text}, {comboBoxTourID.Text}, '{textBoxReservationDate.Text}', {seatsReserved.ToString()}, '{comboBoxStatus.Text}')");
                Form1.ExecuteQuery($"UPDATE Tours SET AvailableSeats = AvailableSeats - {seatsReserved} WHERE TourID = {comboBoxTourID.Text}");
                MessageBox.Show("Бронирование успешно добавлено.");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении бронирования: {ex.Message}");
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
            textBoxReservationDate.Text = "";
            textBoxSeatsReserved.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1.GoForm1(this);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void AddReservationsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}