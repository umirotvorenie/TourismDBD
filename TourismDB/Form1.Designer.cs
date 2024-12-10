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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonDeleteClients = new System.Windows.Forms.Button();
            this.buttonUpdateClients = new System.Windows.Forms.Button();
            this.buttonAddClients = new System.Windows.Forms.Button();
            this.textBoxSearchClients = new System.Windows.Forms.TextBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.buttonDeleteTours = new System.Windows.Forms.Button();
            this.buttonUpdateTours = new System.Windows.Forms.Button();
            this.buttonAddTours = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearchTours = new System.Windows.Forms.TextBox();
            this.dataGridViewTours = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxSearchReservations = new System.Windows.Forms.TextBox();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBoxSearchPayments = new System.Windows.Forms.TextBox();
            this.dataGridViewPayments = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 602);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.buttonDeleteClients);
            this.tabPage1.Controls.Add(this.buttonUpdateClients);
            this.tabPage1.Controls.Add(this.buttonAddClients);
            this.tabPage1.Controls.Add(this.textBoxSearchClients);
            this.tabPage1.Controls.Add(this.dataGridViewClients);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1043, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(82, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поиск";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(855, 484);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 57);
            this.button6.TabIndex = 6;
            this.button6.Text = "Вывести в PDF";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(705, 484);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 57);
            this.button5.TabIndex = 5;
            this.button5.Text = "Вывести в Excel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(556, 484);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 57);
            this.button4.TabIndex = 4;
            this.button4.Text = "Вывести в Word";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteClients
            // 
            this.buttonDeleteClients.Location = new System.Drawing.Point(340, 484);
            this.buttonDeleteClients.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteClients.Name = "buttonDeleteClients";
            this.buttonDeleteClients.Size = new System.Drawing.Size(141, 57);
            this.buttonDeleteClients.TabIndex = 3;
            this.buttonDeleteClients.Text = "Удалить запись";
            this.buttonDeleteClients.UseVisualStyleBackColor = true;
            this.buttonDeleteClients.Click += new System.EventHandler(this.buttonDeleteClients_Click);
            // 
            // buttonUpdateClients
            // 
            this.buttonUpdateClients.Location = new System.Drawing.Point(191, 484);
            this.buttonUpdateClients.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateClients.Name = "buttonUpdateClients";
            this.buttonUpdateClients.Size = new System.Drawing.Size(141, 57);
            this.buttonUpdateClients.TabIndex = 2;
            this.buttonUpdateClients.Text = "Обновить данные";
            this.buttonUpdateClients.UseVisualStyleBackColor = true;
            this.buttonUpdateClients.Click += new System.EventHandler(this.buttonUpdateClients_Click);
            // 
            // buttonAddClients
            // 
            this.buttonAddClients.Location = new System.Drawing.Point(41, 484);
            this.buttonAddClients.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddClients.Name = "buttonAddClients";
            this.buttonAddClients.Size = new System.Drawing.Size(141, 57);
            this.buttonAddClients.TabIndex = 1;
            this.buttonAddClients.Text = "Добавить новую запись";
            this.buttonAddClients.UseVisualStyleBackColor = true;
            this.buttonAddClients.Click += new System.EventHandler(this.buttonAddClients_Click);
            // 
            // textBoxSearchClients
            // 
            this.textBoxSearchClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchClients.Location = new System.Drawing.Point(175, 38);
            this.textBoxSearchClients.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchClients.Name = "textBoxSearchClients";
            this.textBoxSearchClients.Size = new System.Drawing.Size(773, 36);
            this.textBoxSearchClients.TabIndex = 1;
            this.textBoxSearchClients.TextChanged += new System.EventHandler(this.textBoxSearchClients_TextChanged);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(41, 81);
            this.dataGridViewClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.RowHeadersWidth = 51;
            this.dataGridViewClients.RowTemplate.Height = 24;
            this.dataGridViewClients.Size = new System.Drawing.Size(955, 378);
            this.dataGridViewClients.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.buttonDeleteTours);
            this.tabPage2.Controls.Add(this.buttonUpdateTours);
            this.tabPage2.Controls.Add(this.buttonAddTours);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxSearchTours);
            this.tabPage2.Controls.Add(this.dataGridViewTours);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1043, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Туры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(705, 484);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(141, 57);
            this.button12.TabIndex = 14;
            this.button12.Text = "Вывести в Excel";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(855, 484);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(141, 57);
            this.button11.TabIndex = 13;
            this.button11.Text = "Вывести в PDF";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(556, 484);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(141, 57);
            this.button10.TabIndex = 12;
            this.button10.Text = "Вывести в Word";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteTours
            // 
            this.buttonDeleteTours.Location = new System.Drawing.Point(339, 484);
            this.buttonDeleteTours.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteTours.Name = "buttonDeleteTours";
            this.buttonDeleteTours.Size = new System.Drawing.Size(141, 57);
            this.buttonDeleteTours.TabIndex = 11;
            this.buttonDeleteTours.Text = "Удалить запись";
            this.buttonDeleteTours.UseVisualStyleBackColor = true;
            this.buttonDeleteTours.Click += new System.EventHandler(this.buttonDeleteTours_Click);
            // 
            // buttonUpdateTours
            // 
            this.buttonUpdateTours.Location = new System.Drawing.Point(190, 484);
            this.buttonUpdateTours.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateTours.Name = "buttonUpdateTours";
            this.buttonUpdateTours.Size = new System.Drawing.Size(141, 57);
            this.buttonUpdateTours.TabIndex = 10;
            this.buttonUpdateTours.Text = "Обновить данные";
            this.buttonUpdateTours.UseVisualStyleBackColor = true;
            this.buttonUpdateTours.Click += new System.EventHandler(this.buttonUpdateTours_Click);
            // 
            // buttonAddTours
            // 
            this.buttonAddTours.Location = new System.Drawing.Point(41, 484);
            this.buttonAddTours.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddTours.Name = "buttonAddTours";
            this.buttonAddTours.Size = new System.Drawing.Size(141, 57);
            this.buttonAddTours.TabIndex = 9;
            this.buttonAddTours.Text = "Добавить новую запись";
            this.buttonAddTours.UseVisualStyleBackColor = true;
            this.buttonAddTours.Click += new System.EventHandler(this.buttonAddTours_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(82, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Поиск";
            // 
            // textBoxSearchTours
            // 
            this.textBoxSearchTours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchTours.Location = new System.Drawing.Point(175, 38);
            this.textBoxSearchTours.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchTours.Name = "textBoxSearchTours";
            this.textBoxSearchTours.Size = new System.Drawing.Size(773, 36);
            this.textBoxSearchTours.TabIndex = 2;
            this.textBoxSearchTours.TextChanged += new System.EventHandler(this.textBoxSearchTours_TextChanged);
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Location = new System.Drawing.Point(41, 81);
            this.dataGridViewTours.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.RowHeadersWidth = 51;
            this.dataGridViewTours.RowTemplate.Height = 24;
            this.dataGridViewTours.Size = new System.Drawing.Size(955, 378);
            this.dataGridViewTours.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxSearchReservations);
            this.tabPage3.Controls.Add(this.dataGridViewReservations);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1043, 569);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Бронирования";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchReservations
            // 
            this.textBoxSearchReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchReservations.Location = new System.Drawing.Point(45, 73);
            this.textBoxSearchReservations.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchReservations.Name = "textBoxSearchReservations";
            this.textBoxSearchReservations.Size = new System.Drawing.Size(953, 36);
            this.textBoxSearchReservations.TabIndex = 3;
            this.textBoxSearchReservations.TextChanged += new System.EventHandler(this.textBoxSearchReservations_TextChanged);
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(45, 116);
            this.dataGridViewReservations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.RowTemplate.Height = 24;
            this.dataGridViewReservations.Size = new System.Drawing.Size(955, 378);
            this.dataGridViewReservations.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxSearchPayments);
            this.tabPage4.Controls.Add(this.dataGridViewPayments);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1043, 569);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Платежи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchPayments
            // 
            this.textBoxSearchPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchPayments.Location = new System.Drawing.Point(45, 73);
            this.textBoxSearchPayments.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchPayments.Name = "textBoxSearchPayments";
            this.textBoxSearchPayments.Size = new System.Drawing.Size(953, 36);
            this.textBoxSearchPayments.TabIndex = 4;
            this.textBoxSearchPayments.TextChanged += new System.EventHandler(this.textBoxSearchPayments_TextChanged);
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(45, 116);
            this.dataGridViewPayments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.RowHeadersWidth = 51;
            this.dataGridViewPayments.RowTemplate.Height = 24;
            this.dataGridViewPayments.Size = new System.Drawing.Size(955, 378);
            this.dataGridViewPayments.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBoxSearchStaff);
            this.tabPage5.Controls.Add(this.dataGridViewStaff);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1043, 569);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Сотрудники";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchStaff
            // 
            this.textBoxSearchStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchStaff.Location = new System.Drawing.Point(45, 73);
            this.textBoxSearchStaff.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchStaff.Name = "textBoxSearchStaff";
            this.textBoxSearchStaff.Size = new System.Drawing.Size(953, 36);
            this.textBoxSearchStaff.TabIndex = 5;
            this.textBoxSearchStaff.TextChanged += new System.EventHandler(this.textBoxSearchStaff_TextChanged);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(45, 116);
            this.dataGridViewStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(955, 378);
            this.dataGridViewStaff.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 618);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonDeleteTours;
        private System.Windows.Forms.Button buttonUpdateTours;
        private System.Windows.Forms.Button buttonAddTours;
        private System.Windows.Forms.Label label2;
    }
}

