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
    public partial class FormUpdateClients : Form
    {
        public FormUpdateClients()
        {
            InitializeComponent();
        }

        private void buttonAddClients_Click(object sender, EventArgs e)
        {
            if (textBoxIDClient.Text == "")
            {
                MessageBox.Show("Введите ID клиента");
                return;
            }
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "")
            {
                MessageBox.Show("Поля Имя и Фамилия не могут быть пустыми.");
                return;
            }
            string clientId = textBoxIDClient.Text;
            Form1.ExecuteQuery($"UPDATE Clients SET FirstName = '{textBoxFirstName.Text}', LastName = '{textBoxLastName.Text}', DateOfBirth = '{textBoxDateOfBirth.Text}', " +
            $"Email = '{textBoxEmail.Text}', PhoneNumber = '{textBoxPhoneNumber.Text}', Address = '{textBoxAddress.Text}', " +
            $"PassportNumber = '{textBoxPassportNumber.Text}' WHERE ClientID = {clientId}");
        }
        private void LoadDataClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIDClient.Text))
            {
                MessageBox.Show("Введите ID клиента.");
                return;
            }
            if (!int.TryParse(textBoxIDClient.Text, out int clientId))
            {
                MessageBox.Show("ID клиента должен быть числом.");
                ClearFields();
                return;
            }
            Form1.ExecuteQuery($"SELECT FirstName, LastName, DateOfBirth, Email, PhoneNumber, Address, PassportNumber FROM Clients WHERE ClientID = {clientId}");
            if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
            {
                DataRow row = Form1.currentDataTable.Rows[0];
                textBoxFirstName.Text = row["FirstName"].ToString();
                textBoxLastName.Text = row["LastName"].ToString();
                textBoxDateOfBirth.Text = row["DateOfBirth"].ToString();
                textBoxEmail.Text = row["Email"].ToString();
                textBoxPhoneNumber.Text = row["PhoneNumber"].ToString();
                textBoxAddress.Text = row["Address"].ToString();
                textBoxPassportNumber.Text = row["PassportNumber"].ToString();
            }
            else
            {
                MessageBox.Show("Клиент с таким ID не найден.");
                ClearFields();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            textBoxIDClient.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxDateOfBirth.Text = "";
            textBoxEmail.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxAddress.Text = "";
            textBoxPassportNumber.Text = "";
        }
    }
}
