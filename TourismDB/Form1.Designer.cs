namespace TourismDB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPDFClients = new System.Windows.Forms.Button();
            this.buttonExcelClients = new System.Windows.Forms.Button();
            this.buttonWordClients = new System.Windows.Forms.Button();
            this.buttonDeleteClients = new System.Windows.Forms.Button();
            this.buttonUpdateClients = new System.Windows.Forms.Button();
            this.buttonAddClients = new System.Windows.Forms.Button();
            this.textBoxSearchClients = new System.Windows.Forms.TextBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExcelTours = new System.Windows.Forms.Button();
            this.buttonPDFTours = new System.Windows.Forms.Button();
            this.buttonWordTours = new System.Windows.Forms.Button();
            this.buttonDeleteTours = new System.Windows.Forms.Button();
            this.buttonUpdateTours = new System.Windows.Forms.Button();
            this.buttonAddTours = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchTours = new System.Windows.Forms.TextBox();
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonExcelReservations = new System.Windows.Forms.Button();
            this.buttonPDFRevervations = new System.Windows.Forms.Button();
            this.buttonWordReservations = new System.Windows.Forms.Button();
            this.buttonDeleteReservations = new System.Windows.Forms.Button();
            this.buttonUpdateReservations = new System.Windows.Forms.Button();
            this.buttonAddReservations = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSearchReservations = new System.Windows.Forms.TextBox();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonExcelPayments = new System.Windows.Forms.Button();
            this.buttonPDFPayments = new System.Windows.Forms.Button();
            this.buttonWordPayments = new System.Windows.Forms.Button();
            this.buttonSeletePayments = new System.Windows.Forms.Button();
            this.buttonUpdatePayments = new System.Windows.Forms.Button();
            this.buttonAddPayments = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearchPayments = new System.Windows.Forms.TextBox();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonExcelStaff = new System.Windows.Forms.Button();
            this.buttonPDFStaff = new System.Windows.Forms.Button();
            this.buttonWordStaff = new System.Windows.Forms.Button();
            this.buttonDeleteStaff = new System.Windows.Forms.Button();
            this.buttonUpdateStaff = new System.Windows.Forms.Button();
            this.buttonAddStaff = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSearchStaff = new System.Windows.Forms.TextBox();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(9, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 489);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonPDFClients);
            this.tabPage1.Controls.Add(this.buttonExcelClients);
            this.tabPage1.Controls.Add(this.buttonWordClients);
            this.tabPage1.Controls.Add(this.buttonDeleteClients);
            this.tabPage1.Controls.Add(this.buttonUpdateClients);
            this.tabPage1.Controls.Add(this.buttonAddClients);
            this.tabPage1.Controls.Add(this.textBoxSearchClients);
            this.tabPage1.Controls.Add(this.dataGridViewClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(780, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(62, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поиск";
            // 
            // buttonPDFClients
            // 
            this.buttonPDFClients.Location = new System.Drawing.Point(641, 393);
            this.buttonPDFClients.Name = "buttonPDFClients";
            this.buttonPDFClients.Size = new System.Drawing.Size(106, 46);
            this.buttonPDFClients.TabIndex = 6;
            this.buttonPDFClients.Text = "Вывести в PDF";
            this.buttonPDFClients.UseVisualStyleBackColor = true;
            this.buttonPDFClients.Click += new System.EventHandler(this.buttonPDFClients_Click);
            // 
            // buttonExcelClients
            // 
            this.buttonExcelClients.Location = new System.Drawing.Point(529, 393);
            this.buttonExcelClients.Name = "buttonExcelClients";
            this.buttonExcelClients.Size = new System.Drawing.Size(106, 46);
            this.buttonExcelClients.TabIndex = 5;
            this.buttonExcelClients.Text = "Вывести в Excel";
            this.buttonExcelClients.UseVisualStyleBackColor = true;
            this.buttonExcelClients.Click += new System.EventHandler(this.buttonExcelClients_Click);
            // 
            // buttonWordClients
            // 
            this.buttonWordClients.Location = new System.Drawing.Point(417, 393);
            this.buttonWordClients.Name = "buttonWordClients";
            this.buttonWordClients.Size = new System.Drawing.Size(106, 46);
            this.buttonWordClients.TabIndex = 4;
            this.buttonWordClients.Text = "Вывести в Word";
            this.buttonWordClients.UseVisualStyleBackColor = true;
            this.buttonWordClients.Click += new System.EventHandler(this.buttonWordClients_Click);
            // 
            // buttonDeleteClients
            // 
            this.buttonDeleteClients.Location = new System.Drawing.Point(255, 393);
            this.buttonDeleteClients.Name = "buttonDeleteClients";
            this.buttonDeleteClients.Size = new System.Drawing.Size(106, 46);
            this.buttonDeleteClients.TabIndex = 3;
            this.buttonDeleteClients.Text = "Удалить запись";
            this.buttonDeleteClients.UseVisualStyleBackColor = true;
            this.buttonDeleteClients.Click += new System.EventHandler(this.buttonDeleteClients_Click);
            // 
            // buttonUpdateClients
            // 
            this.buttonUpdateClients.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonUpdateClients.Location = new System.Drawing.Point(143, 393);
            this.buttonUpdateClients.Name = "buttonUpdateClients";
            this.buttonUpdateClients.Size = new System.Drawing.Size(106, 46);
            this.buttonUpdateClients.TabIndex = 2;
            this.buttonUpdateClients.Text = "Обновить данные";
            this.buttonUpdateClients.UseVisualStyleBackColor = true;
            this.buttonUpdateClients.Click += new System.EventHandler(this.buttonUpdateClients_Click);
            // 
            // buttonAddClients
            // 
            this.buttonAddClients.Location = new System.Drawing.Point(31, 393);
            this.buttonAddClients.Name = "buttonAddClients";
            this.buttonAddClients.Size = new System.Drawing.Size(106, 46);
            this.buttonAddClients.TabIndex = 1;
            this.buttonAddClients.Text = "Добавить новую запись";
            this.buttonAddClients.UseVisualStyleBackColor = true;
            this.buttonAddClients.Click += new System.EventHandler(this.buttonAddClients_Click);
            // 
            // textBoxSearchClients
            // 
            this.textBoxSearchClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchClients.Location = new System.Drawing.Point(131, 31);
            this.textBoxSearchClients.Name = "textBoxSearchClients";
            this.textBoxSearchClients.Size = new System.Drawing.Size(581, 30);
            this.textBoxSearchClients.TabIndex = 1;
            this.textBoxSearchClients.TextChanged += new System.EventHandler(this.textBoxSearchClients_TextChanged);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(31, 66);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.Size = new System.Drawing.Size(716, 307);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExcelTours);
            this.tabPage2.Controls.Add(this.buttonPDFTours);
            this.tabPage2.Controls.Add(this.buttonWordTours);
            this.tabPage2.Controls.Add(this.buttonDeleteTours);
            this.tabPage2.Controls.Add(this.buttonUpdateTours);
            this.tabPage2.Controls.Add(this.buttonAddTours);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxSearchTours);
            this.tabPage2.Controls.Add(this.dataGridViewTours);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(780, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Туры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExcelTours
            // 
            this.buttonExcelTours.Location = new System.Drawing.Point(529, 393);
            this.buttonExcelTours.Name = "buttonExcelTours";
            this.buttonExcelTours.Size = new System.Drawing.Size(106, 46);
            this.buttonExcelTours.TabIndex = 14;
            this.buttonExcelTours.Text = "Вывести в Excel";
            this.buttonExcelTours.UseVisualStyleBackColor = true;
            this.buttonExcelTours.Click += new System.EventHandler(this.buttonExcelTours_Click);
            // 
            // buttonPDFTours
            // 
            this.buttonPDFTours.Location = new System.Drawing.Point(641, 393);
            this.buttonPDFTours.Name = "buttonPDFTours";
            this.buttonPDFTours.Size = new System.Drawing.Size(106, 46);
            this.buttonPDFTours.TabIndex = 13;
            this.buttonPDFTours.Text = "Вывести в PDF";
            this.buttonPDFTours.UseVisualStyleBackColor = true;
            this.buttonPDFTours.Click += new System.EventHandler(this.buttonPDFTours_Click);
            // 
            // buttonWordTours
            // 
            this.buttonWordTours.Location = new System.Drawing.Point(417, 393);
            this.buttonWordTours.Name = "buttonWordTours";
            this.buttonWordTours.Size = new System.Drawing.Size(106, 46);
            this.buttonWordTours.TabIndex = 12;
            this.buttonWordTours.Text = "Вывести в Word";
            this.buttonWordTours.UseVisualStyleBackColor = true;
            this.buttonWordTours.Click += new System.EventHandler(this.buttonWordTours_Click);
            // 
            // buttonDeleteTours
            // 
            this.buttonDeleteTours.Location = new System.Drawing.Point(255, 393);
            this.buttonDeleteTours.Name = "buttonDeleteTours";
            this.buttonDeleteTours.Size = new System.Drawing.Size(106, 46);
            this.buttonDeleteTours.TabIndex = 11;
            this.buttonDeleteTours.Text = "Удалить запись";
            this.buttonDeleteTours.UseVisualStyleBackColor = true;
            this.buttonDeleteTours.Click += new System.EventHandler(this.buttonDeleteTours_Click);
            // 
            // buttonUpdateTours
            // 
            this.buttonUpdateTours.Location = new System.Drawing.Point(143, 393);
            this.buttonUpdateTours.Name = "buttonUpdateTours";
            this.buttonUpdateTours.Size = new System.Drawing.Size(106, 46);
            this.buttonUpdateTours.TabIndex = 10;
            this.buttonUpdateTours.Text = "Обновить данные";
            this.buttonUpdateTours.UseVisualStyleBackColor = true;
            this.buttonUpdateTours.Click += new System.EventHandler(this.buttonUpdateTours_Click);
            // 
            // buttonAddTours
            // 
            this.buttonAddTours.Location = new System.Drawing.Point(31, 393);
            this.buttonAddTours.Name = "buttonAddTours";
            this.buttonAddTours.Size = new System.Drawing.Size(106, 46);
            this.buttonAddTours.TabIndex = 9;
            this.buttonAddTours.Text = "Добавить новую запись";
            this.buttonAddTours.UseVisualStyleBackColor = true;
            this.buttonAddTours.Click += new System.EventHandler(this.buttonAddTours_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(62, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Поиск";
            // 
            // textBoxSearchTours
            // 
            this.textBoxSearchTours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchTours.Location = new System.Drawing.Point(131, 31);
            this.textBoxSearchTours.Name = "textBoxSearchTours";
            this.textBoxSearchTours.Size = new System.Drawing.Size(581, 30);
            this.textBoxSearchTours.TabIndex = 2;
            this.textBoxSearchTours.TextChanged += new System.EventHandler(this.textBoxSearchTours_TextChanged);
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.AllowUserToAddRows = false;
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Location = new System.Drawing.Point(31, 66);
            this.dataGridViewTours.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.RowHeadersWidth = 51;
            this.dataGridViewTours.RowTemplate.Height = 24;
            this.dataGridViewTours.Size = new System.Drawing.Size(716, 307);
            this.dataGridViewTours.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonExcelReservations);
            this.tabPage3.Controls.Add(this.buttonPDFRevervations);
            this.tabPage3.Controls.Add(this.buttonWordReservations);
            this.tabPage3.Controls.Add(this.buttonDeleteReservations);
            this.tabPage3.Controls.Add(this.buttonUpdateReservations);
            this.tabPage3.Controls.Add(this.buttonAddReservations);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxSearchReservations);
            this.tabPage3.Controls.Add(this.dataGridViewReservations);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(780, 460);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Бронирования";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonExcelReservations
            // 
            this.buttonExcelReservations.Location = new System.Drawing.Point(529, 393);
            this.buttonExcelReservations.Name = "buttonExcelReservations";
            this.buttonExcelReservations.Size = new System.Drawing.Size(106, 46);
            this.buttonExcelReservations.TabIndex = 19;
            this.buttonExcelReservations.Text = "Вывести в Excel";
            this.buttonExcelReservations.UseVisualStyleBackColor = true;
            this.buttonExcelReservations.Click += new System.EventHandler(this.buttonExcelReservations_Click);
            // 
            // buttonPDFRevervations
            // 
            this.buttonPDFRevervations.Location = new System.Drawing.Point(641, 393);
            this.buttonPDFRevervations.Name = "buttonPDFRevervations";
            this.buttonPDFRevervations.Size = new System.Drawing.Size(106, 46);
            this.buttonPDFRevervations.TabIndex = 18;
            this.buttonPDFRevervations.Text = "Вывести в PDF";
            this.buttonPDFRevervations.UseVisualStyleBackColor = true;
            this.buttonPDFRevervations.Click += new System.EventHandler(this.buttonPDFRevervations_Click);
            // 
            // buttonWordReservations
            // 
            this.buttonWordReservations.Location = new System.Drawing.Point(417, 393);
            this.buttonWordReservations.Name = "buttonWordReservations";
            this.buttonWordReservations.Size = new System.Drawing.Size(106, 46);
            this.buttonWordReservations.TabIndex = 17;
            this.buttonWordReservations.Text = "Вывести в Word";
            this.buttonWordReservations.UseVisualStyleBackColor = true;
            this.buttonWordReservations.Click += new System.EventHandler(this.buttonWordReservations_Click);
            // 
            // buttonDeleteReservations
            // 
            this.buttonDeleteReservations.Location = new System.Drawing.Point(255, 393);
            this.buttonDeleteReservations.Name = "buttonDeleteReservations";
            this.buttonDeleteReservations.Size = new System.Drawing.Size(106, 46);
            this.buttonDeleteReservations.TabIndex = 16;
            this.buttonDeleteReservations.Text = "Удалить запись";
            this.buttonDeleteReservations.UseVisualStyleBackColor = true;
            this.buttonDeleteReservations.Click += new System.EventHandler(this.buttonDeleteReservations_Click);
            // 
            // buttonUpdateReservations
            // 
            this.buttonUpdateReservations.Location = new System.Drawing.Point(143, 393);
            this.buttonUpdateReservations.Name = "buttonUpdateReservations";
            this.buttonUpdateReservations.Size = new System.Drawing.Size(106, 46);
            this.buttonUpdateReservations.TabIndex = 15;
            this.buttonUpdateReservations.Text = "Обновить данные";
            this.buttonUpdateReservations.UseVisualStyleBackColor = true;
            this.buttonUpdateReservations.Click += new System.EventHandler(this.buttonUpdateReservations_Click);
            // 
            // buttonAddReservations
            // 
            this.buttonAddReservations.Location = new System.Drawing.Point(31, 393);
            this.buttonAddReservations.Name = "buttonAddReservations";
            this.buttonAddReservations.Size = new System.Drawing.Size(106, 46);
            this.buttonAddReservations.TabIndex = 10;
            this.buttonAddReservations.Text = "Добавить новую запись";
            this.buttonAddReservations.UseVisualStyleBackColor = true;
            this.buttonAddReservations.Click += new System.EventHandler(this.buttonAddReservations_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(62, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Поиск";
            // 
            // textBoxSearchReservations
            // 
            this.textBoxSearchReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchReservations.Location = new System.Drawing.Point(131, 31);
            this.textBoxSearchReservations.Name = "textBoxSearchReservations";
            this.textBoxSearchReservations.Size = new System.Drawing.Size(581, 30);
            this.textBoxSearchReservations.TabIndex = 3;
            this.textBoxSearchReservations.TextChanged += new System.EventHandler(this.textBoxSearchReservations_TextChanged);
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.AllowUserToAddRows = false;
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(31, 66);
            this.dataGridViewReservations.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.RowTemplate.Height = 24;
            this.dataGridViewReservations.Size = new System.Drawing.Size(716, 307);
            this.dataGridViewReservations.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonExcelPayments);
            this.tabPage4.Controls.Add(this.buttonPDFPayments);
            this.tabPage4.Controls.Add(this.buttonWordPayments);
            this.tabPage4.Controls.Add(this.buttonSeletePayments);
            this.tabPage4.Controls.Add(this.buttonUpdatePayments);
            this.tabPage4.Controls.Add(this.buttonAddPayments);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBoxSearchPayments);
            this.tabPage4.Controls.Add(this.dataGridViewPayments);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(780, 460);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Платежи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonExcelPayments
            // 
            this.buttonExcelPayments.Location = new System.Drawing.Point(529, 393);
            this.buttonExcelPayments.Name = "buttonExcelPayments";
            this.buttonExcelPayments.Size = new System.Drawing.Size(106, 46);
            this.buttonExcelPayments.TabIndex = 25;
            this.buttonExcelPayments.Text = "Вывести в Excel";
            this.buttonExcelPayments.UseVisualStyleBackColor = true;
            this.buttonExcelPayments.Click += new System.EventHandler(this.buttonExcelPayments_Click);
            // 
            // buttonPDFPayments
            // 
            this.buttonPDFPayments.Location = new System.Drawing.Point(641, 393);
            this.buttonPDFPayments.Name = "buttonPDFPayments";
            this.buttonPDFPayments.Size = new System.Drawing.Size(106, 46);
            this.buttonPDFPayments.TabIndex = 24;
            this.buttonPDFPayments.Text = "Вывести в PDF";
            this.buttonPDFPayments.UseVisualStyleBackColor = true;
            this.buttonPDFPayments.Click += new System.EventHandler(this.buttonPDFPayments_Click);
            // 
            // buttonWordPayments
            // 
            this.buttonWordPayments.Location = new System.Drawing.Point(417, 393);
            this.buttonWordPayments.Name = "buttonWordPayments";
            this.buttonWordPayments.Size = new System.Drawing.Size(106, 46);
            this.buttonWordPayments.TabIndex = 23;
            this.buttonWordPayments.Text = "Вывести в Word";
            this.buttonWordPayments.UseVisualStyleBackColor = true;
            this.buttonWordPayments.Click += new System.EventHandler(this.buttonWordPayments_Click);
            // 
            // buttonSeletePayments
            // 
            this.buttonSeletePayments.Location = new System.Drawing.Point(255, 393);
            this.buttonSeletePayments.Name = "buttonSeletePayments";
            this.buttonSeletePayments.Size = new System.Drawing.Size(106, 46);
            this.buttonSeletePayments.TabIndex = 22;
            this.buttonSeletePayments.Text = "Удалить запись";
            this.buttonSeletePayments.UseVisualStyleBackColor = true;
            this.buttonSeletePayments.Click += new System.EventHandler(this.buttonSeletePayments_Click);
            // 
            // buttonUpdatePayments
            // 
            this.buttonUpdatePayments.Location = new System.Drawing.Point(143, 393);
            this.buttonUpdatePayments.Name = "buttonUpdatePayments";
            this.buttonUpdatePayments.Size = new System.Drawing.Size(106, 46);
            this.buttonUpdatePayments.TabIndex = 21;
            this.buttonUpdatePayments.Text = "Обновить данные";
            this.buttonUpdatePayments.UseVisualStyleBackColor = true;
            this.buttonUpdatePayments.Click += new System.EventHandler(this.buttonUpdatePayments_Click);
            // 
            // buttonAddPayments
            // 
            this.buttonAddPayments.Location = new System.Drawing.Point(31, 393);
            this.buttonAddPayments.Name = "buttonAddPayments";
            this.buttonAddPayments.Size = new System.Drawing.Size(106, 46);
            this.buttonAddPayments.TabIndex = 20;
            this.buttonAddPayments.Text = "Добавить новую запись";
            this.buttonAddPayments.UseVisualStyleBackColor = true;
            this.buttonAddPayments.Click += new System.EventHandler(this.buttonAddPayments_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(62, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Поиск";
            // 
            // textBoxSearchPayments
            // 
            this.textBoxSearchPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchPayments.Location = new System.Drawing.Point(131, 31);
            this.textBoxSearchPayments.Name = "textBoxSearchPayments";
            this.textBoxSearchPayments.Size = new System.Drawing.Size(581, 30);
            this.textBoxSearchPayments.TabIndex = 4;
            this.textBoxSearchPayments.TextChanged += new System.EventHandler(this.textBoxSearchPayments_TextChanged);
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.AllowUserToAddRows = false;
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(31, 66);
            this.dataGridViewPayments.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.RowHeadersWidth = 51;
            this.dataGridViewPayments.RowTemplate.Height = 24;
            this.dataGridViewPayments.Size = new System.Drawing.Size(716, 307);
            this.dataGridViewPayments.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonExcelStaff);
            this.tabPage5.Controls.Add(this.buttonPDFStaff);
            this.tabPage5.Controls.Add(this.buttonWordStaff);
            this.tabPage5.Controls.Add(this.buttonDeleteStaff);
            this.tabPage5.Controls.Add(this.buttonUpdateStaff);
            this.tabPage5.Controls.Add(this.buttonAddStaff);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.textBoxSearchStaff);
            this.tabPage5.Controls.Add(this.dataGridViewStaff);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(780, 460);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Сотрудники";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonExcelStaff
            // 
            this.buttonExcelStaff.Location = new System.Drawing.Point(529, 393);
            this.buttonExcelStaff.Name = "buttonExcelStaff";
            this.buttonExcelStaff.Size = new System.Drawing.Size(106, 46);
            this.buttonExcelStaff.TabIndex = 31;
            this.buttonExcelStaff.Text = "Вывести в Excel";
            this.buttonExcelStaff.UseVisualStyleBackColor = true;
            this.buttonExcelStaff.Click += new System.EventHandler(this.buttonExcelStaff_Click);
            // 
            // buttonPDFStaff
            // 
            this.buttonPDFStaff.Location = new System.Drawing.Point(641, 393);
            this.buttonPDFStaff.Name = "buttonPDFStaff";
            this.buttonPDFStaff.Size = new System.Drawing.Size(106, 46);
            this.buttonPDFStaff.TabIndex = 30;
            this.buttonPDFStaff.Text = "Вывести в PDF";
            this.buttonPDFStaff.UseVisualStyleBackColor = true;
            this.buttonPDFStaff.Click += new System.EventHandler(this.buttonPDFStaff_Click);
            // 
            // buttonWordStaff
            // 
            this.buttonWordStaff.Location = new System.Drawing.Point(417, 393);
            this.buttonWordStaff.Name = "buttonWordStaff";
            this.buttonWordStaff.Size = new System.Drawing.Size(106, 46);
            this.buttonWordStaff.TabIndex = 29;
            this.buttonWordStaff.Text = "Вывести в Word";
            this.buttonWordStaff.UseVisualStyleBackColor = true;
            this.buttonWordStaff.Click += new System.EventHandler(this.buttonWordStaff_Click);
            // 
            // buttonDeleteStaff
            // 
            this.buttonDeleteStaff.Location = new System.Drawing.Point(255, 393);
            this.buttonDeleteStaff.Name = "buttonDeleteStaff";
            this.buttonDeleteStaff.Size = new System.Drawing.Size(106, 46);
            this.buttonDeleteStaff.TabIndex = 28;
            this.buttonDeleteStaff.Text = "Удалить запись";
            this.buttonDeleteStaff.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateStaff
            // 
            this.buttonUpdateStaff.Location = new System.Drawing.Point(143, 393);
            this.buttonUpdateStaff.Name = "buttonUpdateStaff";
            this.buttonUpdateStaff.Size = new System.Drawing.Size(106, 46);
            this.buttonUpdateStaff.TabIndex = 27;
            this.buttonUpdateStaff.Text = "Обновить данные";
            this.buttonUpdateStaff.UseVisualStyleBackColor = true;
            this.buttonUpdateStaff.Click += new System.EventHandler(this.buttonUpdateStaff_Click);
            // 
            // buttonAddStaff
            // 
            this.buttonAddStaff.Location = new System.Drawing.Point(31, 393);
            this.buttonAddStaff.Name = "buttonAddStaff";
            this.buttonAddStaff.Size = new System.Drawing.Size(106, 46);
            this.buttonAddStaff.TabIndex = 26;
            this.buttonAddStaff.Text = "Добавить новую запись";
            this.buttonAddStaff.UseVisualStyleBackColor = true;
            this.buttonAddStaff.Click += new System.EventHandler(this.buttonAddStaff_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(62, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Поиск";
            // 
            // textBoxSearchStaff
            // 
            this.textBoxSearchStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchStaff.Location = new System.Drawing.Point(131, 31);
            this.textBoxSearchStaff.Name = "textBoxSearchStaff";
            this.textBoxSearchStaff.Size = new System.Drawing.Size(581, 30);
            this.textBoxSearchStaff.TabIndex = 5;
            this.textBoxSearchStaff.TextChanged += new System.EventHandler(this.textBoxSearchStaff_TextChanged);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.AllowUserToAddRows = false;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(31, 66);
            this.dataGridViewStaff.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(716, 307);
            this.dataGridViewStaff.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 502);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Туристическое бюро";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTours)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPayments)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewTours;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewPayments;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.TextBox textBoxSearchClients;
        private System.Windows.Forms.TextBox textBoxSearchTours;
        private System.Windows.Forms.TextBox textBoxSearchReservations;
        private System.Windows.Forms.TextBox textBoxSearchPayments;
        private System.Windows.Forms.TextBox textBoxSearchStaff;
        private System.Windows.Forms.Button buttonAddClients;
        private System.Windows.Forms.Button buttonUpdateClients;
        private System.Windows.Forms.Button buttonDeleteClients;
        private System.Windows.Forms.Button buttonPDFClients;
        private System.Windows.Forms.Button buttonExcelClients;
        private System.Windows.Forms.Button buttonWordClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExcelTours;
        private System.Windows.Forms.Button buttonPDFTours;
        private System.Windows.Forms.Button buttonWordTours;
        private System.Windows.Forms.Button buttonDeleteTours;
        private System.Windows.Forms.Button buttonUpdateTours;
        private System.Windows.Forms.Button buttonAddTours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExcelReservations;
        private System.Windows.Forms.Button buttonPDFRevervations;
        private System.Windows.Forms.Button buttonWordReservations;
        private System.Windows.Forms.Button buttonDeleteReservations;
        private System.Windows.Forms.Button buttonUpdateReservations;
        private System.Windows.Forms.Button buttonAddReservations;
        private System.Windows.Forms.Button buttonExcelPayments;
        private System.Windows.Forms.Button buttonPDFPayments;
        private System.Windows.Forms.Button buttonWordPayments;
        private System.Windows.Forms.Button buttonSeletePayments;
        private System.Windows.Forms.Button buttonUpdatePayments;
        private System.Windows.Forms.Button buttonAddPayments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExcelStaff;
        private System.Windows.Forms.Button buttonPDFStaff;
        private System.Windows.Forms.Button buttonWordStaff;
        private System.Windows.Forms.Button buttonDeleteStaff;
        private System.Windows.Forms.Button buttonUpdateStaff;
        private System.Windows.Forms.Button buttonAddStaff;
    }
}

