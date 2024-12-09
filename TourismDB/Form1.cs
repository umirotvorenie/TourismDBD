using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TourismDB
{
    public partial class Form1 : Form
    {
        private static string connectionString = @"Data Source=TourismDB.db;Version=3;";
        private static DataTable currentDataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            ExecuteQuery("SELECT * FROM Clients", dataGridViewClients);
        }

        public static void ExecuteQuery(string query, DataGridView dataGridView = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        if (query.TrimStart().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                        {
                            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            if (dataGridView != null)
                            {
                                dataGridView.DataSource = dataTable;
                                SetColumnHeaders(dataGridView);
                            }
                            currentDataTable = dataTable;
                        }
                        else
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                            MessageBox.Show($"Запрос выполнен. Затронуто строк: {rowsAffected}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllDataGrids();
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    ExecuteQuery("SELECT * FROM Clients", dataGridViewClients);
                    dataGridViewClients.Visible = true;
                    break;
                case 1:
                    ExecuteQuery("SELECT * FROM Tours", dataGridViewTours);
                    dataGridViewTours.Visible = true;
                    break;
                case 2:
                    ExecuteQuery("SELECT * FROM Reservation", dataGridViewReservations);
                    dataGridViewReservations.Visible = true;
                    break;
                case 3:
                    ExecuteQuery("SELECT * FROM Payments", dataGridViewPayments);
                    dataGridViewPayments.Visible = true;
                    break;
                case 4:
                    ExecuteQuery("SELECT * FROM Staff", dataGridViewStaff);
                    dataGridViewStaff.Visible = true;
                    break;
            }
        }
        private void HideAllDataGrids()
        {
            dataGridViewClients.Visible = false;
            dataGridViewTours.Visible = false;
            dataGridViewReservations.Visible = false;
            dataGridViewPayments.Visible = false;
            dataGridViewStaff.Visible = false;
        }
        private void FilterData(string filterText, DataGridView dataGridView)
        {             
            try
            {
                var filteredRows = currentDataTable.AsEnumerable().Where(row => currentDataTable.Columns.Cast<DataColumn>().Any(col => row[col.ColumnName].ToString().IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0));
                DataTable filteredTable = filteredRows.Any() ? filteredRows.CopyToDataTable() : currentDataTable.Clone();
                dataGridView.DataSource = filteredTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при фильтрации данных: {ex.Message}");
            }
        }

        private static void SetColumnHeaders(DataGridView dataGridView)
        {
            if (dataGridView.Columns.Count > 0)
            {
                switch (dataGridView.Name)
                {
                    case "dataGridViewClients":
                        dataGridView.Columns["ClientID"].HeaderText = "ID Клиента";
                        dataGridView.Columns["FirstName"].HeaderText = "Имя";
                        dataGridView.Columns["LastName"].HeaderText = "Фамилия";
                        dataGridView.Columns["DateOfBirth"].HeaderText = "Дата рождения";
                        dataGridView.Columns["Email"].HeaderText = "Почта";
                        dataGridView.Columns["PhoneNumber"].HeaderText = "Номер телефона";
                        dataGridView.Columns["Address"].HeaderText = "Адрес";
                        dataGridView.Columns["PassportNumber"].HeaderText = "Пасспорт";
                        break;
                    case "dataGridViewPayments":
                        dataGridView.Columns["PaymentID"].HeaderText = "ID Платежа";
                        dataGridView.Columns["ReservationID"].HeaderText = "ID Бронирования";
                        dataGridView.Columns["PaymentDate"].HeaderText = "Дата оплаты";
                        dataGridView.Columns["Amount"].HeaderText = "Количество";
                        dataGridView.Columns["PaymentMethod"].HeaderText = "Способ оплаты";
                        dataGridView.Columns["PaymentStatus"].HeaderText = "Статус оплаты";
                        break;
                    case "dataGridViewReservations":
                        dataGridView.Columns["ReservationID"].HeaderText = "ID Бронирования";
                        dataGridView.Columns["ClientID"].HeaderText = "ID Клиента";
                        dataGridView.Columns["TourID"].HeaderText = "ID Тура";
                        dataGridView.Columns["ReservationDate"].HeaderText = "Дата бронирования";
                        dataGridView.Columns["SeatsReserved"].HeaderText = "Мест забронировано";
                        dataGridView.Columns["Status"].HeaderText = "Статус";
                        break;
                    case "dataGridViewStaff":
                        dataGridView.Columns["StaffID"].HeaderText = "ID Сотрудника";
                        dataGridView.Columns["FirstName"].HeaderText = "Имя";
                        dataGridView.Columns["LastName"].HeaderText = "Фамилия";
                        dataGridView.Columns["Position"].HeaderText = "Должность";
                        dataGridView.Columns["Email"].HeaderText = "Почта";
                        dataGridView.Columns["PhoneNumber"].HeaderText = "Номер телефона";
                        dataGridView.Columns["HireDate"].HeaderText = "Дата приема на работу";
                        dataGridView.Columns["Salary"].HeaderText = "Зарплата";
                        break;
                    case "dataGridViewTours":
                        dataGridView.Columns["TourID"].HeaderText = "ID Тура";
                        dataGridView.Columns["TourName"].HeaderText = "Название тура";
                        dataGridView.Columns["Description"].HeaderText = "Описание";
                        dataGridView.Columns["StartDate"].HeaderText = "Дата начала";
                        dataGridView.Columns["EndDate"].HeaderText = "Дата конца";
                        dataGridView.Columns["Price"].HeaderText = "Стоимость";
                        dataGridView.Columns["Destination"].HeaderText = "Место назначения";
                        dataGridView.Columns["AvailableSeats"].HeaderText = "Количество свободных мест";
                        break;
                }
            }
        }
        private void textBoxSearchClients_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData(textBoxSearchClients.Text, dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось выполнить поиск: {ex}");
            }
        }

        private void textBoxSearchTours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData(textBoxSearchTours.Text, dataGridViewTours);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось выполнить поиск: {ex}");
            }
        }

        private void textBoxSearchReservations_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData(textBoxSearchReservations.Text, dataGridViewReservations);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось выполнить поиск: {ex}");
            }
        }

        private void textBoxSearchPayments_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData(textBoxSearchPayments.Text, dataGridViewPayments);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось выполнить поиск: {ex}");
            }
        }

        private void textBoxSearchStaff_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData(textBoxSearchStaff.Text, dataGridViewStaff);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось выполнить поиск: {ex}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClientsForm form = new AddClientsForm();
            this.Hide();
            form.Show();
        }
    }
}
