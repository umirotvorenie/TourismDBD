using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class FormUpdateStaff : Form
    {
        public List<System.Windows.Forms.TextBox> textStaff = new List<System.Windows.Forms.TextBox>();

        public FormUpdateStaff()
        {
            InitializeComponent();
            textStaff.Add(textBoxFirstName);
            textStaff.Add(textBoxLastName);
            textStaff.Add(textBoxPosition);
            textStaff.Add(textBoxEmail);
            textStaff.Add(textBoxPhoneNumber);
            textStaff.Add(textBoxHireDate);
            textStaff.Add(textBoxSalary);
            Form1.SetReadOnly(textStaff, true);
        }

        private void LoadDataStaff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIDStaff.Text))
            {
                MessageBox.Show("Введите ID сотрудника.");
                return;
            }
            if (!int.TryParse(textBoxIDStaff.Text, out int staffId))
            {
                MessageBox.Show("ID сотрудника должен быть числом.");
                ClearFields();
                return;
            }
            Form1.ExecuteQuery($"SELECT FirstName, LastName, Position, Email, PhoneNumber, HireDate, Salary FROM Staff WHERE StaffID = {staffId}");
            if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
            {
                DataRow row = Form1.currentDataTable.Rows[0];
                textBoxFirstName.Text = row["FirstName"].ToString();
                textBoxLastName.Text = row["LastName"].ToString();
                textBoxPosition.Text = row["Position"].ToString();
                textBoxEmail.Text = row["Email"].ToString();
                textBoxPhoneNumber.Text = row["PhoneNumber"].ToString();
                textBoxHireDate.Text = row["HireDate"].ToString();
                textBoxSalary.Text = row["Salary"].ToString();
                Form1.SetReadOnly(textStaff, false);
            }
            else
            {
                MessageBox.Show("Клиент с таким ID не найден.");
                ClearFields();
            }
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            if (textBoxIDStaff.Text == "")
            {
                MessageBox.Show("Введите ID сотрудника");
                return;
            }
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxHireDate.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Обязательные поля не могут быть пустыми: Имя, Фамилия, Дата приема на работу, Почта");
                return;
            }
            string clientId = textBoxIDStaff.Text;
            Form1.ExecuteQuery($"UPDATE Staff SET FirstName = '{textBoxFirstName.Text}', LastName = '{textBoxLastName.Text}', Position = '{textBoxPosition.Text}', " +
            $"Email = '{textBoxEmail.Text}', PhoneNumber = '{textBoxPhoneNumber.Text}', HireDate = '{textBoxHireDate.Text}', " +
            $"Salary = '{textBoxSalary.Text}' WHERE StaffID = {clientId}");
            MessageBox.Show("Операция прошла успешно");
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxIDStaff.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPosition.Text = "";
            textBoxEmail.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxHireDate.Text = "";
            textBoxSalary.Text = "";
            Form1.SetReadOnly(textStaff, true);
        }

        private void buttonCLear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1.GoForm1(this);
        }

        private void FormUpdateStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}