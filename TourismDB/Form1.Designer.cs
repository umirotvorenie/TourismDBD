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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearchClients = new System.Windows.Forms.TextBox();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Обновить данные клиента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить новую запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tabPage2.Controls.Add(this.textBoxSearchTours);
            this.tabPage2.Controls.Add(this.dataGridViewTours);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(780, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Туры";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchTours
            // 
            this.textBoxSearchTours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchTours.Location = new System.Drawing.Point(34, 59);
            this.textBoxSearchTours.Name = "textBoxSearchTours";
            this.textBoxSearchTours.Size = new System.Drawing.Size(716, 30);
            this.textBoxSearchTours.TabIndex = 2;
            this.textBoxSearchTours.TextChanged += new System.EventHandler(this.textBoxSearchTours_TextChanged);
            // 
            // dataGridViewTours
            // 
            this.dataGridViewTours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTours.Location = new System.Drawing.Point(34, 94);
            this.dataGridViewTours.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTours.Name = "dataGridViewTours";
            this.dataGridViewTours.RowHeadersWidth = 51;
            this.dataGridViewTours.RowTemplate.Height = 24;
            this.dataGridViewTours.Size = new System.Drawing.Size(716, 307);
            this.dataGridViewTours.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxSearchReservations);
            this.tabPage3.Controls.Add(this.dataGridViewReservations);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(780, 535);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Бронирования";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchReservations
            // 
            this.textBoxSearchReservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchReservations.Location = new System.Drawing.Point(34, 59);
            this.textBoxSearchReservations.Name = "textBoxSearchReservations";
            this.textBoxSearchReservations.Size = new System.Drawing.Size(716, 30);
            this.textBoxSearchReservations.TabIndex = 3;
            this.textBoxSearchReservations.TextChanged += new System.EventHandler(this.textBoxSearchReservations_TextChanged);
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(34, 94);
            this.dataGridViewReservations.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.RowTemplate.Height = 24;
            this.dataGridViewReservations.Size = new System.Drawing.Size(716, 307);
            this.dataGridViewReservations.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBoxSearchPayments);
            this.tabPage4.Controls.Add(this.dataGridViewPayments);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(780, 535);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Платежи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchPayments
            // 
            this.textBoxSearchPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchPayments.Location = new System.Drawing.Point(34, 59);
            this.textBoxSearchPayments.Name = "textBoxSearchPayments";
            this.textBoxSearchPayments.Size = new System.Drawing.Size(716, 30);
            this.textBoxSearchPayments.TabIndex = 4;
            this.textBoxSearchPayments.TextChanged += new System.EventHandler(this.textBoxSearchPayments_TextChanged);
            // 
            // dataGridViewPayments
            // 
            this.dataGridViewPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPayments.Location = new System.Drawing.Point(34, 94);
            this.dataGridViewPayments.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPayments.Name = "dataGridViewPayments";
            this.dataGridViewPayments.RowHeadersWidth = 51;
            this.dataGridViewPayments.RowTemplate.Height = 24;
            this.dataGridViewPayments.Size = new System.Drawing.Size(716, 307);
            this.dataGridViewPayments.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBoxSearchStaff);
            this.tabPage5.Controls.Add(this.dataGridViewStaff);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(780, 535);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Сотрудники";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchStaff
            // 
            this.textBoxSearchStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearchStaff.Location = new System.Drawing.Point(34, 59);
            this.textBoxSearchStaff.Name = "textBoxSearchStaff";
            this.textBoxSearchStaff.Size = new System.Drawing.Size(716, 30);
            this.textBoxSearchStaff.TabIndex = 5;
            this.textBoxSearchStaff.TextChanged += new System.EventHandler(this.textBoxSearchStaff_TextChanged);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(34, 94);
            this.dataGridViewStaff.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 51;
            this.dataGridViewStaff.RowTemplate.Height = 24;
            this.dataGridViewStaff.Size = new System.Drawing.Size(716, 307);
            this.dataGridViewStaff.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(255, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить клиента";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(417, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 46);
            this.button4.TabIndex = 4;
            this.button4.Text = "Вывести в Word";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(529, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = "Вывести в Excel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(641, 393);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(106, 46);
            this.button6.TabIndex = 6;
            this.button6.Text = "Вывести в PDF";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Поиск";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 502);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
    }
}

