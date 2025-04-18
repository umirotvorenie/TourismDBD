﻿namespace TourismDB
{
    partial class FormUpdateReservations
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadDataReservation = new System.Windows.Forms.Button();
            this.buttonAddReservation = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxSeatsReserved = new System.Windows.Forms.TextBox();
            this.textBoxReservationDate = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxIDReservation = new System.Windows.Forms.ComboBox();
            this.comboBoxClientID = new System.Windows.Forms.ComboBox();
            this.comboBoxTourID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(92)))));
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(639, 192);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(172, 35);
            this.buttonClear.TabIndex = 49;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(141, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Мест забронировано";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Дата бронирования";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(141, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "ID Тура";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "ID Клиента";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID Бронирования";
            // 
            // LoadDataReservation
            // 
            this.LoadDataReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(92)))));
            this.LoadDataReservation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoadDataReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadDataReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LoadDataReservation.ForeColor = System.Drawing.Color.White;
            this.LoadDataReservation.Location = new System.Drawing.Point(639, 151);
            this.LoadDataReservation.Name = "LoadDataReservation";
            this.LoadDataReservation.Size = new System.Drawing.Size(172, 35);
            this.LoadDataReservation.TabIndex = 39;
            this.LoadDataReservation.Text = "Загрузить данные ";
            this.LoadDataReservation.UseVisualStyleBackColor = false;
            this.LoadDataReservation.Click += new System.EventHandler(this.LoadDataReservation_Click);
            // 
            // buttonAddReservation
            // 
            this.buttonAddReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(92)))));
            this.buttonAddReservation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAddReservation.ForeColor = System.Drawing.Color.White;
            this.buttonAddReservation.Location = new System.Drawing.Point(343, 233);
            this.buttonAddReservation.Name = "buttonAddReservation";
            this.buttonAddReservation.Size = new System.Drawing.Size(172, 35);
            this.buttonAddReservation.TabIndex = 38;
            this.buttonAddReservation.Text = "Изменить данные";
            this.buttonAddReservation.UseVisualStyleBackColor = false;
            this.buttonAddReservation.Click += new System.EventHandler(this.buttonAddReservation_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(92)))));
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(639, 233);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(172, 35);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxSeatsReserved
            // 
            this.textBoxSeatsReserved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBoxSeatsReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSeatsReserved.ForeColor = System.Drawing.Color.White;
            this.textBoxSeatsReserved.Location = new System.Drawing.Point(225, 146);
            this.textBoxSeatsReserved.Name = "textBoxSeatsReserved";
            this.textBoxSeatsReserved.Size = new System.Drawing.Size(397, 30);
            this.textBoxSeatsReserved.TabIndex = 33;
            // 
            // textBoxReservationDate
            // 
            this.textBoxReservationDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBoxReservationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxReservationDate.ForeColor = System.Drawing.Color.White;
            this.textBoxReservationDate.Location = new System.Drawing.Point(225, 49);
            this.textBoxReservationDate.Name = "textBoxReservationDate";
            this.textBoxReservationDate.Size = new System.Drawing.Size(397, 30);
            this.textBoxReservationDate.TabIndex = 32;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxStatus.ForeColor = System.Drawing.Color.White;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Выполняется",
            "Подтвержден"});
            this.comboBoxStatus.Location = new System.Drawing.Point(225, 182);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(166, 32);
            this.comboBoxStatus.TabIndex = 50;
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
            this.comboBoxIDReservation.Location = new System.Drawing.Point(394, 19);
            this.comboBoxIDReservation.Name = "comboBoxIDReservation";
            this.comboBoxIDReservation.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIDReservation.TabIndex = 51;
            // 
            // comboBoxClientID
            // 
            this.comboBoxClientID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.comboBoxClientID.DropDownHeight = 50;
            this.comboBoxClientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxClientID.ForeColor = System.Drawing.Color.White;
            this.comboBoxClientID.FormattingEnabled = true;
            this.comboBoxClientID.IntegralHeight = false;
            this.comboBoxClientID.Location = new System.Drawing.Point(225, 86);
            this.comboBoxClientID.Name = "comboBoxClientID";
            this.comboBoxClientID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClientID.TabIndex = 52;
            // 
            // comboBoxTourID
            // 
            this.comboBoxTourID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.comboBoxTourID.DropDownHeight = 50;
            this.comboBoxTourID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTourID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTourID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxTourID.ForeColor = System.Drawing.Color.White;
            this.comboBoxTourID.FormattingEnabled = true;
            this.comboBoxTourID.IntegralHeight = false;
            this.comboBoxTourID.Location = new System.Drawing.Point(225, 116);
            this.comboBoxTourID.Name = "comboBoxTourID";
            this.comboBoxTourID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTourID.TabIndex = 53;
            // 
            // FormUpdateReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(830, 289);
            this.Controls.Add(this.comboBoxTourID);
            this.Controls.Add(this.comboBoxClientID);
            this.Controls.Add(this.comboBoxIDReservation);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadDataReservation);
            this.Controls.Add(this.buttonAddReservation);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxSeatsReserved);
            this.Controls.Add(this.textBoxReservationDate);
            this.Name = "FormUpdateReservations";
            this.Text = "Обновление данных о бронировании";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUpdateReservations_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadDataReservation;
        private System.Windows.Forms.Button buttonAddReservation;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxSeatsReserved;
        private System.Windows.Forms.TextBox textBoxReservationDate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxIDReservation;
        private System.Windows.Forms.ComboBox comboBoxClientID;
        private System.Windows.Forms.ComboBox comboBoxTourID;
    }
}