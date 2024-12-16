using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class FormUpdateClients : Form
    {
        public List<TextBox> textClient = new List<TextBox>();

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
            LoadClientIDs();
            Form1.SetReadOnly(textClient, true);
        }

        private void buttonAddClients_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "")
            {
                MessageBox.Show("Обязательные поля не могут быть пустыми: Имя, Фамилия.");
                return;
            }
            string clientId = comboBoxClientID.Text;
            Form1.ExecuteQuery($"UPDATE Clients SET FirstName = '{textBoxFirstName.Text}', LastName = '{textBoxLastName.Text}', DateOfBirth = '{textBoxDateOfBirth.Text}', " +
            $"Email = '{textBoxEmail.Text}', PhoneNumber = '{textBoxPhoneNumber.Text}', Address = '{textBoxAddress.Text}', " +
            $"PassportNumber = '{textBoxPassportNumber.Text}' WHERE ClientID = {clientId}");
            MessageBox.Show("Операция прошла успешно");
            ClearFields();
        }

        private void LoadDataClient_Click(object sender, EventArgs e)
        {
            Form1.ExecuteQuery($"SELECT FirstName, LastName, DateOfBirth, Email, PhoneNumber, Address, PassportNumber FROM Clients WHERE ClientID = {comboBoxClientID.Text}");
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