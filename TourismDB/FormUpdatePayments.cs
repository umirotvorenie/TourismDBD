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
            textPayment.Add(textBoxPaymentDate);
            textPayment.Add(textBoxAmount);
            LoadPaymentsIDs();
            LoadReservationIDs();
            Form1.SetReadOnly(textPayment, true);
            comboBoxPaymentMethod.Enabled = false;
            comboBoxPaymentStatus.Enabled = false;
            comboBoxIDReservation.Enabled = false;
        }

        private void LoadDataPayments_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxPaymentID.Text))
            {
                MessageBox.Show("Введите ID брони.");
                return;
            }
            Form1.ExecuteQuery($"SELECT ReservationID, PaymentDate, Amount, PaymentMethod, PaymentStatus FROM Payments WHERE PaymentID = {comboBoxPaymentID.Text}");
            if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
            {
                DataRow row = Form1.currentDataTable.Rows[0];
                comboBoxIDReservation.Text = row["ReservationID"].ToString();
                textBoxPaymentDate.Text = row["PaymentDate"].ToString();
                textBoxAmount.Text = row["Amount"].ToString();
                comboBoxPaymentMethod.Text = row["PaymentMethod"].ToString();
                comboBoxPaymentStatus.Text = row["PaymentStatus"].ToString();
                Form1.SetReadOnly(textPayment, false);
                comboBoxPaymentMethod.Enabled = true;
                comboBoxPaymentStatus.Enabled = true;
                comboBoxIDReservation.Enabled = true;
            }
            else
            {
                MessageBox.Show("Бронь с таким ID не найден.");
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
                    MessageBox.Show("Не удалось загрузить ID клиентов.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке ID клиентов: {ex.Message}");
            }
        }

        private void LoadPaymentsIDs()
        {
            try
            {
                Form1.ExecuteQuery("SELECT PaymentID FROM Payments ORDER BY PaymentID");

                if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
                {
                    comboBoxPaymentID.Items.Clear();

                    foreach (DataRow row in Form1.currentDataTable.Rows)
                    {
                        comboBoxPaymentID.Items.Add(row["PaymentID"].ToString());
                    }

                    if (comboBoxPaymentID.Items.Count > 0)
                    {
                        comboBoxPaymentID.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось загрузить ID платежей.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке ID платежей: {ex.Message}");
            }
        }

        private void buttonAddPayments_Click(object sender, EventArgs e)
        {
            if (comboBoxIDReservation.Text == "" || textBoxPaymentDate.Text == "" || textBoxAmount.Text == "" || comboBoxPaymentMethod.Text == "")
            {
                MessageBox.Show("Обязательные поля не могут быть пустыми: ID Бронирования, Дата оплаты, Сумма, Способ оплаты.");
                return;
            }
            Form1.ExecuteQuery($"SELECT 1 FROM Reservation WHERE ReservationID = {comboBoxIDReservation.Text}", null);
            if (Form1.currentDataTable.Rows.Count == 0)
            {
                MessageBox.Show($"Бронь с ID {comboBoxIDReservation.Text} не найдена.");
                return;
            }
            string paymentId = comboBoxPaymentID.Text;
            Form1.ExecuteQuery($"UPDATE Payments SET ReservationID = '{comboBoxIDReservation.Text}', PaymentDate = '{textBoxPaymentDate.Text}', Amount = '{textBoxAmount.Text}', " +
            $"PaymentMethod = '{comboBoxPaymentMethod.Text}', PaymentStatus = '{comboBoxPaymentStatus.Text}'  WHERE PaymentID = {paymentId}");
            MessageBox.Show("Операция прошла успешно");
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxPaymentDate.Text = "";
            textBoxAmount.Text = "";
            Form1.SetReadOnly(textPayment, true);
            comboBoxPaymentMethod.Enabled = false;
            comboBoxPaymentStatus.Enabled = false;
            comboBoxIDReservation.Enabled = false;
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