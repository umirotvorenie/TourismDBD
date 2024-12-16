using System;
using System.Data;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class AddPaymentsForm : Form
    {
        public AddPaymentsForm()
        {
            InitializeComponent();
            LoadReservationIDs();
        }

        private void buttonAddPayments_Click(object sender, EventArgs e)
        {
            if (comboBoxIDReservation.Text == "" || textBoxPaymentDate.Text == "" || textBoxAmount.Text == "" || comboBoxPaymentMethod.Text == "")
            {
                MessageBox.Show($"Не удалось добавить платеж. Заполните обязательные поля: ID Бронирования, Дата оплаты, Сумма, Способ оплаты");
            }
            else
            {
                Form1.ExecuteQuery($"SELECT 1 FROM Reservation WHERE ReservationID = {comboBoxIDReservation.Text}", null);
                if (Form1.currentDataTable.Rows.Count == 0)
                {
                    MessageBox.Show($"Бронь с ID {comboBoxIDReservation.Text} не найдена.");
                    return;
                }
                Form1.ExecuteQuery($"INSERT INTO Payments(ReservationID, PaymentDate, Amount, PaymentMethod, PaymentStatus) " +
                $"VALUES ('{comboBoxIDReservation.Text}', '{textBoxPaymentDate.Text}', '{textBoxAmount.Text}', '{comboBoxPaymentMethod.Text}', '{comboBoxPaymentStatus.Text}')");
                MessageBox.Show("Платеж успешно добавлен");
                ClearFields();
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
                    MessageBox.Show("Не удалось загрузить ID бронирований.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке ID бронирований: {ex.Message}");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1.GoForm1(this);
        }

        private void ClearFields()
        {
            textBoxPaymentDate.Text = "";
            textBoxAmount.Text = "";
            comboBoxPaymentMethod.Text = "";
            comboBoxPaymentStatus.Text = "";
        }

        private void AddPaymentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}