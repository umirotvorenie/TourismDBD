using System;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class AddPaymentsForm : Form
    {
        public AddPaymentsForm()
        {
            InitializeComponent();
        }

        private void buttonAddPayments_Click(object sender, EventArgs e)
        {
            if (textBoxReservationID.Text == "" || textBoxPaymentDate.Text == "" || textBoxAmount.Text == "" || comboBoxPaymentMethod.Text == "")
            {
                MessageBox.Show($"Не удалось добавить пользователя. Введите обязательные поля для ввода: ID Бронирования, Дата оплаты, Сумма, Способ оплаты");
            }
            else
            {
                Form1.ExecuteQuery($"SELECT 1 FROM Reservation WHERE ReservationID = {textBoxReservationID.Text}", null);
                if (Form1.currentDataTable.Rows.Count == 0)
                {
                    MessageBox.Show($"Бронь с ID {textBoxReservationID.Text} не найдена.");
                    return;
                }
                Form1.ExecuteQuery($"INSERT INTO Payments(ReservationID, PaymentDate, Amount, PaymentMethod, PaymentStatus) " +
                $"VALUES ('{textBoxReservationID.Text}', '{textBoxPaymentDate.Text}', '{textBoxAmount.Text}', '{comboBoxPaymentMethod.Text}', '{comboBoxPaymentStatus.Text}')");
                MessageBox.Show("Платеж успешно добавлен");
                ClearFields();
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
            textBoxReservationID.Text = "";
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