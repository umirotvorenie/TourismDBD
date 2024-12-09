﻿using System;
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
    public partial class AddClientsForm : Form
    {
        public AddClientsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void buttonAddClients_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "") 
            {
                MessageBox.Show($"Не удалось добавить пользователя, строки не могут быть пустыми");
            }
            else
            {
                Form1.ExecuteQuery($"INSERT INTO Clients(FirstName, LastName, DateOfBirth, Email, PhoneNumber, Address, PassportNumber) " +
                $"VALUES ('{textBoxFirstName.Text}', '{textBoxLastName.Text}', '{textBoxDateOfBirth.Text}', '{textBoxEmail.Text}', '{textBoxPhoneNumber.Text}', '{textBoxAddress.Text}', '{textBoxPassportNumber.Text}')");
            }
        }
    }
}
