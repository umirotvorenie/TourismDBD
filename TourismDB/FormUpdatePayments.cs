using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class FormUpdatePayments : Form
    {
        public List<System.Windows.Forms.TextBox> textPayment = new List<System.Windows.Forms.TextBox>();
        private string method = "", status = "";

        public FormUpdatePayments()
        {
            InitializeComponent();
            comboBoxPaymentMethod.SelectedIndex = 0;
            comboBoxPaymentStatus.SelectedIndex = 0;
            textPayment.Add(textBoxReservationID);
            textPayment.Add(textBoxPaymentDate);
            textPayment.Add(textBoxAmount);
            Form1.SetReadOnly(textPayment, true);
            comboBoxPaymentMethod.Enabled = false;
            comboBoxPaymentStatus.Enabled = false;
        }

        private void LoadDataPayments_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPaymentID.Text))
            {
                MessageBox.Show("Введите ID брони.");
                return;
            }
            Form1.ExecuteQuery($"SELECT ReservationID, PaymentDate, Amount, PaymentMethod, PaymentStatus FROM Payments WHERE PaymentID = {textBoxPaymentID.Text}");
            if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
            {
                DataRow row = Form1.currentDataTable.Rows[0];
                textBoxReservationID.Text = row["ReservationID"].ToString();
                textBoxPaymentDate.Text = row["PaymentDate"].ToString();
                textBoxAmount.Text = row["Amount"].ToString();
                comboBoxPaymentMethod.Text = row["PaymentMethod"].ToString();
                comboBoxPaymentStatus.Text = row["PaymentStatus"].ToString();
                Form1.SetReadOnly(textPayment, false);
                comboBoxPaymentMethod.Enabled = true;
                comboBoxPaymentStatus.Enabled = true;
            }
            else
            {
                MessageBox.Show("Бронь с таким ID не найден.");
                ClearFields();
            }
        }

        private void buttonAddPayments_Click(object sender, EventArgs e)
        {
            if (textBoxReservationID.Text == "" || textBoxPaymentDate.Text == "" || textBoxAmount.Text == "" || comboBoxPaymentMethod.Text == "")
            {
                MessageBox.Show("Обязательные поля не могут быть пустыми: ID Бронирования, Дата оплаты, Сумма, Способ оплаты.");
                return;
            }
            Form1.ExecuteQuery($"SELECT 1 FROM Reservation WHERE ReservationID = {textBoxReservationID.Text}", null);
            if (Form1.currentDataTable.Rows.Count == 0)
            {
                MessageBox.Show($"Бронь с ID {textBoxReservationID.Text} не найдена.");
                return;
            }
            string paymentId = textBoxPaymentID.Text;
            Form1.ExecuteQuery($"UPDATE Payments SET ReservationID = '{textBoxReservationID.Text}', PaymentDate = '{textBoxPaymentDate.Text}', Amount = '{textBoxAmount.Text}', " +
            $"PaymentMethod = '{comboBoxPaymentMethod.Text}', PaymentStatus = '{comboBoxPaymentStatus.Text}'  WHERE PaymentID = {paymentId}");
            MessageBox.Show("Операция прошла успешно");
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxPaymentID.Text = "";
            textBoxReservationID.Text = "";
            textBoxPaymentDate.Text = "";
            textBoxAmount.Text = "";
            Form1.SetReadOnly(textPayment, true);
            comboBoxPaymentMethod.Enabled = false;
            comboBoxPaymentStatus.Enabled = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void FormUpdatePayments_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1.GoForm1(this);
        }
    }
}