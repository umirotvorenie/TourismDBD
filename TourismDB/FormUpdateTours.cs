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
    public partial class FormUpdateTours : Form
    {
        public List<System.Windows.Forms.TextBox> textTour = new List<System.Windows.Forms.TextBox>();

        public FormUpdateTours()
        {
            InitializeComponent();
            textTour.Add(textBoxTourName);
            textTour.Add(textBoxDescription);
            textTour.Add(textBoxStartDate);
            textTour.Add(textBoxEndDate);
            textTour.Add(textBoxPrice);
            textTour.Add(textBoxDestination);
            textTour.Add(textBoxAvailableSeats);
            Form1.SetReadOnly(textTour, true);
        }

        private void LoadDataClient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxIDTour.Text))
            {
                MessageBox.Show("Введите ID тура.");
                return;
            }
            if (!int.TryParse(textBoxIDTour.Text, out int tourId))
            {
                MessageBox.Show("ID клиента должен быть числом.");
                ClearFields();
                return;
            }
            Form1.ExecuteQuery($"SELECT TourName, Description, StartDate, EndDate, Price, Destination, AvailableSeats FROM Tours WHERE TourID = {tourId}");
            if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0)
            {
                DataRow row = Form1.currentDataTable.Rows[0];
                textBoxTourName.Text = row["TourName"].ToString();
                textBoxDescription.Text = row["Description"].ToString();
                textBoxStartDate.Text = row["StartDate"].ToString();
                textBoxEndDate.Text = row["EndDate"].ToString();
                textBoxPrice.Text = row["Price"].ToString();
                textBoxDestination.Text = row["Destination"].ToString();
                textBoxAvailableSeats.Text = row["AvailableSeats"].ToString();
                Form1.SetReadOnly(textTour, false);
            }
            else
            {
                MessageBox.Show("Тур с таким ID не найден.");
                ClearFields();
            }
        }

        private void ClearFields()
        {
            textBoxIDTour.Text = "";
            textBoxTourName.Text = "";
            textBoxDescription.Text = "";
            textBoxStartDate.Text = "";
            textBoxEndDate.Text = "";
            textBoxPrice.Text = "";
            textBoxDestination.Text = "";
            textBoxAvailableSeats.Text = "";
            Form1.SetReadOnly(textTour, true);
        }

        private void buttonAddTours_Click(object sender, EventArgs e)
        {
            if (textBoxIDTour.Text == "")
            {
                MessageBox.Show("Введите ID тура");
                return;
            }
            if (textBoxTourName.Text == "" || textBoxStartDate.Text == "" || textBoxEndDate.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show("Обязательные не поля не могут быть пустыми : Название тура, Дата начала, Дата окончания, Цена");
                return;
            }
            string clientId = textBoxIDTour.Text;
            Form1.ExecuteQuery($"UPDATE Tours SET TourName = '{textBoxTourName.Text}', Description = '{textBoxDescription.Text}', StartDate = '{textBoxStartDate.Text}', " +
            $"EndDate = '{textBoxEndDate.Text}', Price = '{textBoxPrice.Text}', Destination = '{textBoxDestination.Text}', " +
            $"AvailableSeats = '{textBoxAvailableSeats.Text}' WHERE TourID = {clientId}");
            MessageBox.Show("Операция прошла успешно");
            ClearFields();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1.GoForm1(this);
        }
    }
}