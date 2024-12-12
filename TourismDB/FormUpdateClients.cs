using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class FormUpdateClients : Form
    {
        public List<System.Windows.Forms.TextBox> textClient = new List<System.Windows.Forms.TextBox>();

        public FormUpdateClients()
        {
            InitializeComponent();
            textClient.Add(textBoxFirstName);
            textClient.Add(textBoxLastName);
            textClient.Add(textBoxDateOfBirth);
            textClient.Add(textBoxEmail);
            textClient.Add(textBoxPhoneNumber);
            textClient.Add(textBoxAddress);
            textClient.Add(textBoxPassportNumber);
            Form1.SetReadOnly(textClient, true);
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
            MessageBox.Show("Операция прошла успешно");
            ClearFields();
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
                Form1.SetReadOnly(textClient, false);
            }
            else
            {
                MessageBox.Show("Клиент с таким ID не найден.");
                ClearFields();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1.GoForm1(this);
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
            Form1.SetReadOnly(textClient, true);
        }

        private void FormUpdateClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}