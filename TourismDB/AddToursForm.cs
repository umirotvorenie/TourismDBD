using System;
using System.Windows.Forms;

namespace TourismDB
{
    public partial class AddToursForm : Form
    {
        public AddToursForm()
        {
            InitializeComponent();
        }

        private void buttonAddClients_Click(object sender, EventArgs e)
        {
            if (textBoxTourName.Text == "" || textBoxStartDate.Text == "" || textBoxEndDate.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show($"Не удалось добавить пользователя. Введите обязательные поля для ввода: Название тура, Дата начала, Дата окончания, Цена");
            }
            else
            {
                Form1.ExecuteQuery($"INSERT INTO Tours(TourName, Description, StartDate, EndDate, Price, Destination, AvailableSeats) " +
                $"VALUES ('{textBoxTourName.Text}', '{textBoxDescription.Text}', '{textBoxStartDate.Text}', '{textBoxEndDate.Text}', " +
                $"'{textBoxPrice.Text}', '{textBoxDestination.Text}', '{textBoxAvailableSeats.Text}')");
                MessageBox.Show("Клиент успешно добавлен");
                ClearFields();
            }
        }

        private void ClearFields()
        {
            textBoxTourName.Text = "";
            textBoxDescription.Text = "";
            textBoxStartDate.Text = "";
            textBoxEndDate.Text = "";
            textBoxPrice.Text = "";
            textBoxDestination.Text = "";
            textBoxAvailableSeats.Text = "";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.GoForm1(this);
        }

        private void AddToursForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}