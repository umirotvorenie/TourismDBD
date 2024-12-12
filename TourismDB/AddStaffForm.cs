using System;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxHireDate.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show($"Не удалось добавить пользователя. Введите обязательные поля для ввода: Имя, Фамилия, Дата приема на работу, Пасспорт");
            }
            else
            {
                Form1.ExecuteQuery($"INSERT INTO Staff(FirstName, LastName, Position, Email, PhoneNumber, HireDate, Salary) " +
                $"VALUES ('{textBoxFirstName.Text}', '{textBoxLastName.Text}', '{textBoxPosition.Text}', '{textBoxEmail.Text}', '{textBoxPhoneNumber.Text}', '{textBoxHireDate.Text}', '{textBoxSalary.Text}')");
                MessageBox.Show("Клиент успешно добавлен");
                ClearFields();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
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
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1.GoForm1(this);
        }

        private void AddStaffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}