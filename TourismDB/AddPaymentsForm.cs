using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TourismDB
{
    public partial class AddPaymentsForm : Form
    {
        private string method = "", status = "";

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
                switch (comboBoxPaymentMethod.Text)
                {
                    case "Кредитная карта":
                        method = "Credit Card";
                        break;
                    case "Банковский перевод":
                        method = "Bank Transfer";
                        break;
                    case "Наличные":
                        method = "Cash";
                        break;
                }
                switch (comboBoxPaymentStatus.Text)
                {
                    case "Выполняется":
                        status = "Pending";
                        break;
                    case "Подтвержден":
                        status = "Confirmed";
                        break;
                }
                Form1.ExecuteQuery($"INSERT INTO Payments(ReservationID, PaymentDate, Amount, PaymentMethod, PaymentStatus) " +
                $"VALUES ('{textBoxReservationID.Text}', '{textBoxPaymentDate.Text}', '{textBoxAmount.Text}', '{method}', '{status}')");
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
    }
}
