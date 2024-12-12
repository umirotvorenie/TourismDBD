using System;
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
            Form1.GoForm1(this);
        }

        private void buttonAddClients_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxPassportNumber.Text == "" || textBoxEmail.Text == "")
            {
                MessageBox.Show($"Не удалось добавить пользователя. Введите обязательные поля для ввода: Имя, Фамилия, Почта, Пасспорт");
            }
            else
            {
                Form1.ExecuteQuery($"INSERT INTO Clients(FirstName, LastName, DateOfBirth, Email, PhoneNumber, Address, PassportNumber) " +
                $"VALUES ('{textBoxFirstName.Text}', '{textBoxLastName.Text}', '{textBoxDateOfBirth.Text}', '{textBoxEmail.Text}', '{textBoxPhoneNumber.Text}', '{textBoxAddress.Text}', '{textBoxPassportNumber.Text}')");
                MessageBox.Show("Клиент успешно добавлен");
                ClearFields();
            }
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
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void AddClientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}