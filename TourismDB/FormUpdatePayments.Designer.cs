﻿namespace TourismDB
{
    partial class FormUpdatePayments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClear = new System.Windows.Forms.Button();
            this.LoadDataPayments = new System.Windows.Forms.Button();
            this.buttonAddPayments = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxPaymentStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxPaymentDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPaymentID = new System.Windows.Forms.ComboBox();
            this.comboBoxIDReservation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(92)))));
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(605, 202);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(172, 35);
            this.buttonClear.TabIndex = 65;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // LoadDataPayments
            // 
            this.LoadDataPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(92)))));
            this.LoadDataPayments.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoadDataPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadDataPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoadDataPayments.ForeColor = System.Drawing.Color.White;
            this.LoadDataPayments.Location = new System.Drawing.Point(605, 161);
            this.LoadDataPayments.Name = "LoadDataPayments";
            this.LoadDataPayments.Size = new System.Drawing.Size(172, 35);
            this.LoadDataPayments.TabIndex = 57;
            this.LoadDataPayments.Text = "Загрузить данные";
            this.LoadDataPayments.UseVisualStyleBackColor = false;
            this.LoadDataPayments.Click += new System.EventHandler(this.LoadDataPayments_Click);
            // 
            // buttonAddPayments
            // 
            this.buttonAddPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(92)))));
            this.buttonAddPayments.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddPayments.ForeColor = System.Drawing.Color.White;
            this.buttonAddPayments.Location = new System.Drawing.Point(309, 243);
            this.buttonAddPayments.Name = "buttonAddPayments";
            this.buttonAddPayments.Size = new System.Drawing.Size(172, 35);
            this.buttonAddPayments.TabIndex = 56;
            this.buttonAddPayments.Text = "Изменить данные";
            this.buttonAddPayments.UseVisualStyleBackColor = false;
            this.buttonAddPayments.Click += new System.EventHandler(this.buttonAddPayments_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(92)))));
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(605, 243);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(172, 35);
            this.buttonBack.TabIndex = 55;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxPaymentStatus
            // 
            this.comboBoxPaymentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.comboBoxPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaymentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPaymentStatus.ForeColor = System.Drawing.Color.White;
            this.comboBoxPaymentStatus.FormattingEnabled = true;
            this.comboBoxPaymentStatus.Items.AddRange(new object[] {
            "Выполняется",
            "Подтвержден"});
            this.comboBoxPaymentStatus.Location = new System.Drawing.Point(186, 190);
            this.comboBoxPaymentStatus.Name = "comboBoxPaymentStatus";
            this.comboBoxPaymentStatus.Size = new System.Drawing.Size(159, 32);
            this.comboBoxPaymentStatus.TabIndex = 75;
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "Кредитная карта",
            "Банковский перевод",
            "Наличные"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(186, 152);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(222, 32);
            this.comboBoxPaymentMethod.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(102, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 73;
            this.label6.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "Способ оплаты";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 71;
            this.label4.Text = "Сумма";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Дата оплаты";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "ID Бронирования";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxAmount.ForeColor = System.Drawing.Color.White;
            this.textBoxAmount.Location = new System.Drawing.Point(186, 116);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(397, 30);
            this.textBoxAmount.TabIndex = 68;
            // 
            // textBoxPaymentDate
            // 
            this.textBoxPaymentDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBoxPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxPaymentDate.ForeColor = System.Drawing.Color.White;
            this.textBoxPaymentDate.Location = new System.Drawing.Point(186, 50);
            this.textBoxPaymentDate.Name = "textBoxPaymentDate";
            this.textBoxPaymentDate.Size = new System.Drawing.Size(397, 30);
            this.textBoxPaymentDate.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "ID Платежа";
            // 
            // comboBoxPaymentID
            // 
            this.comboBoxPaymentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.comboBoxPaymentID.DropDownHeight = 50;
            this.comboBoxPaymentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaymentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxPaymentID.ForeColor = System.Drawing.Color.White;
            this.comboBoxPaymentID.FormattingEnabled = true;
            this.comboBoxPaymentID.IntegralHeight = false;
            this.comboBoxPaymentID.Location = new System.Drawing.Point(309, 20);
            this.comboBoxPaymentID.Name = "comboBoxPaymentID";
            this.comboBoxPaymentID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPaymentID.TabIndex = 78;
            // 
            // comboBoxIDReservation
            // 
            this.comboBoxIDReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.comboBoxIDReservation.DropDownHeight = 50;
            this.comboBoxIDReservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIDReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxIDReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxIDReservation.ForeColor = System.Drawing.Color.White;
            this.comboBoxIDReservation.FormattingEnabled = true;
            this.comboBoxIDReservation.IntegralHeight = false;
            this.comboBoxIDReservation.Location = new System.Drawing.Point(186, 86);
            this.comboBoxIDReservation.Name = "comboBoxIDReservation";
            this.comboBoxIDReservation.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIDReservation.TabIndex = 79;
            // 
            // FormUpdatePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(789, 294);
            this.Controls.Add(this.comboBoxIDReservation);
            this.Controls.Add(this.comboBoxPaymentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPaymentStatus);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxPaymentDate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.LoadDataPayments);
            this.Controls.Add(this.buttonAddPayments);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormUpdatePayments";
            this.Text = "Обновление данных о платеже";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUpdatePayments_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button LoadDataPayments;
        private System.Windows.Forms.Button buttonAddPayments;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxPaymentStatus;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxPaymentDate;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPaymentID;
        private System.Windows.Forms.ComboBox comboBoxIDReservation;
    }
}