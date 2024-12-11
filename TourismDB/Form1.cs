using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.IO;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.IO.Font;
using System.Diagnostics;



namespace TourismDB
{
    public partial class Form1 : Form
    {
        public static string connectionString = @"Data Source=TourismDB.db;Version=3;";
        public static DataTable currentDataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
            ExecuteQuery("SELECT * FROM Clients", dataGridViewClients);

        }

        public void ExportToPdf(DataGridView dataGridView, string filePath)
        {
            try
            {
                var pdfWriter = new PdfWriter(filePath);
                var pdfDocument = new PdfDocument(pdfWriter);
                var pdfDoc = new iText.Layout.Document(pdfDocument);
                PdfFont timesFont = PdfFontFactory.CreateFont("c:/windows/fonts/times.ttf", PdfEncodings.IDENTITY_H, true);
                iText.Layout.Element.Table table = new iText.Layout.Element.Table(dataGridView.Columns.Count - 1);
                table.UseAllAvailableWidth();
                var columnsList = dataGridView.Columns.Cast<DataGridViewColumn>().ToList();
                foreach (DataGridViewColumn column in columnsList.Take(dataGridView.Columns.Count - 1))
                {
                    iText.Layout.Element.Cell headerCell = new iText.Layout.Element.Cell().Add(new iText.Layout.Element.Paragraph(column.HeaderText).SetFont(timesFont));
                    table.AddHeaderCell(headerCell);
                }
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells.Cast<DataGridViewCell>().Take(dataGridView.Columns.Count - 1))
                    {
                        table.AddCell(new iText.Layout.Element.Cell().Add(new iText.Layout.Element.Paragraph(cell.Value.ToString()).SetFont(timesFont)));
                    }
                }
                pdfDoc.Add(table);
                pdfDoc.Close();
                MessageBox.Show("PDF успешно экспортирован.");               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ExportDataGridViewToWord(DataGridView dataGridView, string filePath)
        {
            if (dataGridView == null || dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста или не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Add();
                int rows = dataGridView.Rows.Count;
                int columns = dataGridView.Columns.Count;
                Microsoft.Office.Interop.Word.Table wordTable = doc.Tables.Add(doc.Content, rows + 1, columns);
                wordTable.Borders.Enable = 1;
                wordTable.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                for (int col = 0; col < columns; col++)
                {
                    wordTable.Cell(1, col + 1).Range.Text = dataGridView.Columns[col].HeaderText;
                    wordTable.Cell(1, col + 1).Range.Bold = 1;
                    wordTable.Cell(1, col + 1).Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                }
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        object value = dataGridView.Rows[row].Cells[col].Value;
                        wordTable.Cell(row + 2, col + 1).Range.Text = value != null ? value.ToString() : "";
                    }
                }
                doc.SaveAs2(filePath);
                wordApp.Visible = true;
                MessageBox.Show("Данные успешно экспортированы в Word!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void ExportDataGridViewToExcel(DataGridView dataGridView, string filePath)
        {
            if (dataGridView == null || dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста или не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Microsoft.Office.Interop.Excel.Application excelApp = null;
            Workbook workbook = null;

            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                workbook = excelApp.Workbooks.Add();
                Worksheet worksheet = workbook.ActiveSheet;
                for (int col = 0; col < dataGridView.Columns.Count; col++)
                {
                    worksheet.Cells[1, col + 1] = dataGridView.Columns[col].HeaderText;
                    Microsoft.Office.Interop.Excel.Range headerCell = worksheet.Cells[1, col + 1];
                    headerCell.Font.Bold = true;
                    headerCell.Interior.Color = Microsoft.Office.Interop.Excel.XlRgbColor.rgbLightGray;
                    headerCell.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                }
                for (int row = 0; row < dataGridView.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView.Columns.Count; col++)
                    {
                        object value = dataGridView.Rows[row].Cells[col].Value;
                        worksheet.Cells[row + 2, col + 1] = value != null ? value.ToString() : "";
                    }
                }
                worksheet.Columns.AutoFit();
                workbook.SaveAs(filePath, XlFileFormat.xlWorkbookDefault);
                excelApp.Visible = true;
                MessageBox.Show("Данные успешно экспортированы в Excel!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void ExecuteQuery(string query, DataGridView dataGridView = null)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        if (query.TrimStart().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                        {
                            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            if (dataGridView != null)
                            {
                                dataGridView.DataSource = dataTable;
                                SetColumnHeaders(dataGridView);
                            }
                            currentDataTable = dataTable;
                        }
                        else
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка выполнения запроса: {ex.Message}");
                }
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideAllDataGrids();
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    ExecuteQuery("SELECT * FROM Clients", dataGridViewClients);
                    dataGridViewClients.Visible = true;
                    break;
                case 1:
                    ExecuteQuery("SELECT * FROM Tours", dataGridViewTours);
                    dataGridViewTours.Visible = true;
                    break;
                case 2:
                    ExecuteQuery("SELECT * FROM Reservation", dataGridViewReservations);
                    dataGridViewReservations.Visible = true;
                    break;
                case 3:
                    ExecuteQuery("SELECT * FROM Payments", dataGridViewPayments);
                    dataGridViewPayments.Visible = true;
                    break;
                case 4:
                    ExecuteQuery("SELECT * FROM Staff", dataGridViewStaff);
                    dataGridViewStaff.Visible = true;
                    break;
            }
        }
        private void HideAllDataGrids()
        {
            dataGridViewClients.Visible = false;
            dataGridViewTours.Visible = false;
            dataGridViewReservations.Visible = false;
            dataGridViewPayments.Visible = false;
            dataGridViewStaff.Visible = false;
        }
        private void FilterData(string filterText, DataGridView dataGridView)
        {             
            try
            {
                var filteredRows = currentDataTable.AsEnumerable().Where(row => currentDataTable.Columns.Cast<DataColumn>().Any(col => row[col.ColumnName].ToString().IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0));
                DataTable filteredTable = filteredRows.Any() ? filteredRows.CopyToDataTable() : currentDataTable.Clone();
                dataGridView.DataSource = filteredTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при фильтрации данных: {ex.Message}");
            }
        }
        private static void SetColumnHeaders(DataGridView dataGridView)
        {
            if (dataGridView.Columns.Count > 0)
            {
                switch (dataGridView.Name)
                {
                    case "dataGridViewClients":
                        dataGridView.Columns["ClientID"].HeaderText = "ID Клиента";
                        dataGridView.Columns["FirstName"].HeaderText = "Имя";
                        dataGridView.Columns["LastName"].HeaderText = "Фамилия";
                        dataGridView.Columns["DateOfBirth"].HeaderText = "Дата рождения";
                        dataGridView.Columns["Email"].HeaderText = "Почта";
                        dataGridView.Columns["PhoneNumber"].HeaderText = "Номер телефона";
                        dataGridView.Columns["Address"].HeaderText = "Адрес";
                        dataGridView.Columns["PassportNumber"].HeaderText = "Пасспорт";
                        break;
                    case "dataGridViewPayments":
                        dataGridView.Columns["PaymentID"].HeaderText = "ID Платежа";
                        dataGridView.Columns["ReservationID"].HeaderText = "ID Бронирования";
                        dataGridView.Columns["PaymentDate"].HeaderText = "Дата оплаты";
                        dataGridView.Columns["Amount"].HeaderText = "Количество";
                        dataGridView.Columns["PaymentMethod"].HeaderText = "Способ оплаты";
                        dataGridView.Columns["PaymentStatus"].HeaderText = "Статус оплаты";
                        break;
                    case "dataGridViewReservations":
                        dataGridView.Columns["ReservationID"].HeaderText = "ID Бронирования";
                        dataGridView.Columns["ClientID"].HeaderText = "ID Клиента";
                        dataGridView.Columns["TourID"].HeaderText = "ID Тура";
                        dataGridView.Columns["ReservationDate"].HeaderText = "Дата бронирования";
                        dataGridView.Columns["SeatsReserved"].HeaderText = "Мест забронировано";
                        dataGridView.Columns["Status"].HeaderText = "Статус";
                        break;
                    case "dataGridViewStaff":
                        dataGridView.Columns["StaffID"].HeaderText = "ID Сотрудника";
                        dataGridView.Columns["FirstName"].HeaderText = "Имя";
                        dataGridView.Columns["LastName"].HeaderText = "Фамилия";
                        dataGridView.Columns["Position"].HeaderText = "Должность";
                        dataGridView.Columns["Email"].HeaderText = "Почта";
                        dataGridView.Columns["PhoneNumber"].HeaderText = "Номер телефона";
                        dataGridView.Columns["HireDate"].HeaderText = "Дата приема на работу";
                        dataGridView.Columns["Salary"].HeaderText = "Зарплата";
                        break;
                    case "dataGridViewTours":
                        dataGridView.Columns["TourID"].HeaderText = "ID Тура";
                        dataGridView.Columns["TourName"].HeaderText = "Название тура";
                        dataGridView.Columns["Description"].HeaderText = "Описание";
                        dataGridView.Columns["StartDate"].HeaderText = "Дата начала";
                        dataGridView.Columns["EndDate"].HeaderText = "Дата конца";
                        dataGridView.Columns["Price"].HeaderText = "Стоимость";
                        dataGridView.Columns["Destination"].HeaderText = "Место назначения";
                        dataGridView.Columns["AvailableSeats"].HeaderText = "Количество свободных мест";
                        break;
                }
            }
        }
        private void textBoxSearchClients_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData(textBoxSearchClients.Text, dataGridViewClients);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось выполнить поиск: {ex}");
            }
        }

        private void textBoxSearchTours_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData(textBoxSearchTours.Text, dataGridViewTours);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось выполнить поиск: {ex}");
            }
        }

        private void textBoxSearchReservations_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData(textBoxSearchReservations.Text, dataGridViewReservations);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось выполнить поиск: {ex}");
            }
        }

        private void textBoxSearchPayments_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData(textBoxSearchPayments.Text, dataGridViewPayments);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось выполнить поиск: {ex}");
            }
        }

        private void textBoxSearchStaff_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterData(textBoxSearchStaff.Text, dataGridViewStaff);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось выполнить поиск: {ex}");
            }
        }

        private void buttonAddClients_Click(object sender, EventArgs e)
        {
            GoForm(new AddClientsForm());
        }
        private void buttonUpdateClients_Click(object sender, EventArgs e)
        {
            GoForm(new FormUpdateClients());
        }

        private void buttonDeleteClients_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите клиента для удаления.");
                return;
            }
            DataGridViewRow selectedRow = dataGridViewClients.SelectedRows[0];
            if (selectedRow.Cells["ClientID"].Value == null || !int.TryParse(selectedRow.Cells["ClientID"].Value.ToString(), out int clientId))
            {
                MessageBox.Show("Не удалось определить ID клиента.");
                return;
            }
            ExecuteQuery($"SELECT COUNT(*) AS ReservationCount FROM Reservation WHERE ClientID = {clientId}");
            if (currentDataTable != null && currentDataTable.Rows.Count > 0 && int.TryParse(currentDataTable.Rows[0]["ReservationCount"].ToString(), out int reservationCount) && reservationCount > 0)
            {
                MessageBox.Show("Невозможно удалить клиента, так как на него существуют бронирования.");
                return;
            }
            var result = MessageBox.Show($"Вы уверены, что хотите удалить клиента с ID {clientId}?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ExecuteQuery($"DELETE FROM Clients WHERE ClientID = {clientId}");
                MessageBox.Show("Клиент успешно удалён.");
            }
            ExecuteQuery("SELECT * FROM Clients", dataGridViewClients);
        }

        private void buttonAddTours_Click(object sender, EventArgs e)
        {
            GoForm(new AddToursForm());       
        }
        private void GoForm(Form form)
        {
            this.Hide();
            form.Show();
        }

        private void buttonDeleteTours_Click(object sender, EventArgs e)
        {
            if (dataGridViewTours.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите тур для удаления.");
                return;
            }
            DataGridViewRow selectedRow = dataGridViewTours.SelectedRows[0];
            if (selectedRow.Cells["TourID"].Value == null || !int.TryParse(selectedRow.Cells["TourID"].Value.ToString(), out int tourId))
            {
                MessageBox.Show("Не удалось определить ID тура.");
                return;
            }
            ExecuteQuery($"SELECT COUNT(*) AS ReservationCount FROM Reservation WHERE TourID = {tourId}");
            if (Form1.currentDataTable != null && Form1.currentDataTable.Rows.Count > 0 && int.TryParse(Form1.currentDataTable.Rows[0]["ReservationCount"].ToString(), out int reservationCount) && reservationCount > 0)
            {
                MessageBox.Show("Невозможно удалить тур, так как на него существуют бронирования.");
                return;
            }
            var result = MessageBox.Show($"Вы уверены, что хотите удалить тур с ID {tourId}?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {             
                ExecuteQuery($"DELETE FROM Tours WHERE TourID = {tourId}");
                MessageBox.Show("Тур успешно удалён.");
            }
            ExecuteQuery("SELECT * FROM Tours", dataGridViewTours);
        }
        private void buttonDeleteReservations_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите бронь для удаления.");
                return;
            }
            DataGridViewRow selectedRow = dataGridViewReservations.SelectedRows[0];
            if (selectedRow.Cells["ReservationID"].Value == null || !int.TryParse(selectedRow.Cells["ReservationID"].Value.ToString(), out int reservId))
            {
                MessageBox.Show("Не удалось определить ID брони.");
                return;
            }
            var result = MessageBox.Show($"Вы уверены, что хотите удалить бронь с ID {reservId}?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ExecuteQuery($"DELETE FROM Reservation WHERE ReservationID = {reservId}");
                MessageBox.Show("Бронь успешно удалена.");
            }
            ExecuteQuery("SELECT * FROM Reservation", dataGridViewReservations);
        }

        private void buttonUpdateTours_Click(object sender, EventArgs e)
        {
            GoForm(new FormUpdateTours());
        }
        //Word
        private void buttonWordClients_Click(object sender, EventArgs e)
        {
            string path = "Clients.docx";
            ExportDataGridViewToWord(dataGridViewClients, path);
        }
        private void buttonWordTours_Click(object sender, EventArgs e)
        {
            string path = "Tours.docx";
            ExportDataGridViewToWord(dataGridViewTours, path);
        }
        private void buttonWordReservations_Click(object sender, EventArgs e)
        {
            string path = "Reservations.docx";
            ExportDataGridViewToWord(dataGridViewReservations, path);
        }
        //Excel
        private void buttonExcelClients_Click(object sender, EventArgs e)
        {
            string path = "Clients.xlsx";
            ExportDataGridViewToExcel(dataGridViewClients, path);
        }
        private void buttonExcelTours_Click(object sender, EventArgs e)
        {
            string path = "Tours.xlsx";
            ExportDataGridViewToExcel(dataGridViewTours, path);
        }
        private void buttonExcelReservations_Click(object sender, EventArgs e)
        {
            string path = "Reservations.xlsx";
            ExportDataGridViewToExcel(dataGridViewReservations, path);
        }
        //pdf
        private void buttonPDFClients_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Clients.pdf");
            ExportToPdf(dataGridViewClients, path);
        }
        private void buttonPDFTours_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Tours.pdf");
            ExportToPdf(dataGridViewTours, path);
        }
        private void buttonPDFRevervations_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reservations.pdf");
            ExportToPdf(dataGridViewReservations, path);
        }

        private void buttonAddReservations_Click(object sender, EventArgs e)
        {
            GoForm(new AddReservationsForm());
        }

        private void buttonUpdateReservations_Click(object sender, EventArgs e)
        {
            GoForm(new FormUpdateReservations());
        }


    }
}
