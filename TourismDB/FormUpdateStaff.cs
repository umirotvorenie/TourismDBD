using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class FormUpdateStaff : Form
    {
        public List<TextBox> textStaff = new List<TextBox>();

        public FormUpdateStaff()
        {
            InitializeComponent();
            LoadStaffIDs();
            textStaff.Add(textBoxFirstName);
            textStaff.Add(textBoxLastName);
            textStaff.Add(textBoxPosition);
            textStaff.Add(textBoxEmail);
            textStaff.Add(textBoxPhoneNumber);
            textStaff.Add(textBoxHireDate);
            textStaff.Add(textBoxSalary);
            Form1.SetReadOnly(textStaff, true);
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxHireDate.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show("Обязательные поля не могут быть пустыми: Имя, Фамилия, Дата приема на работу, Почта");
                return;
            }
            string clientId = comboBoxIDStaff.Text;
            Form1.ExecuteQuery($"UPDATE Staff SET FirstName = '{textBoxFirstName.Text}', LastName = '{textBoxLastName.Text}', Position = '{textBoxPosition.Text}', " +
            $"Email = '{textBoxEmail.Text}', PhoneNumber = '{textBoxPhoneNumber.Text}', HireDate = '{textBoxHireDate.Text}', " +
            $"Salary = '{textBoxSalary.Text}' WHERE StaffID = {clientId}");
            MessageBox.Show("Операция прошла успешно");
            ClearFields();
        }

        private void LoadDataStaff_Click(object sender, EventArgs e)
        {
            Form1.ExecuteQuery($"SELECT FirstName, LastName, Position, Email, PhoneNumber, HireDate, Salary FROM Staff WHERE StaffID = {comboBoxIDStaff.Text}");
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

        private void LoadStaffIDs()
        {
            try
            {
                Form1.ExecuteQuery("SELECT StaffID FROM Staff ORDER BY StaffID");

                if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
                {
                    comboBoxIDStaff.Items.Clear();

                    foreach (DataRow row in Form1.currentDataTable.Rows)
                    {
                        comboBoxIDStaff.Items.Add(row["StaffID"].ToString());
                    }

                    if (comboBoxIDStaff.Items.Count > 0)
                    {
                        comboBoxIDStaff.SelectedIndex = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось загрузить ID сотрудников.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке ID сотрудников: {ex.Message}");
            }
        }

        private void ClearFields()
        {
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