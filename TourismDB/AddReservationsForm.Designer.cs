﻿namespace TourismDB
{
    partial class AddReservationsForm
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
            this.textBoxSeatsReserved = new System.Windows.Forms.TextBox();
            this.textBoxReservationDate = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddReservation = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxClientID = new System.Windows.Forms.ComboBox();
            this.comboBoxTourID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxSeatsReserved
            // 
            this.textBoxSeatsReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSeatsReserved.Location = new System.Drawing.Point(231, 319);
            this.textBoxSeatsReserved.Name = "textBoxSeatsReserved";
            this.textBoxSeatsReserved.Size = new System.Drawing.Size(397, 30);
            this.textBoxSeatsReserved.TabIndex = 10;
            // 
            // textBoxReservationDate
            // 
            this.textBoxReservationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxReservationDate.Location = new System.Drawing.Point(231, 283);
            this.textBoxReservationDate.Name = "textBoxReservationDate";
            this.textBoxReservationDate.Size = new System.Drawing.Size(397, 30);
            this.textBoxReservationDate.TabIndex = 9;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(650, 277);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(142, 48);
            this.buttonClear.TabIndex = 33;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAddReservation
            // 
            this.buttonAddReservation.Location = new System.Drawing.Point(650, 217);
            this.buttonAddReservation.Name = "buttonAddReservation";
            this.buttonAddReservation.Size = new System.Drawing.Size(142, 48);
            this.buttonAddReservation.TabIndex = 32;
            this.buttonAddReservation.Text = "Добавить";
            this.buttonAddReservation.UseVisualStyleBackColor = true;
            this.buttonAddReservation.Click += new System.EventHandler(this.buttonAddReservation_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(650, 337);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(142, 48);
            this.buttonBack.TabIndex = 31;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(147, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Статус";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(19, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Мест забронировано";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(29, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Дата бронирования";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(147, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "ID Тура";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(110, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "ID Клиента";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Выполняется",
            "Подтвержден"});
            this.comboBoxStatus.Location = new System.Drawing.Point(231, 355);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(162, 32);
            this.comboBoxStatus.TabIndex = 39;
            // 
            // comboBoxClientID
            // 
            this.comboBoxClientID.DropDownHeight = 50;
            this.comboBoxClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxClientID.FormattingEnabled = true;
            this.comboBoxClientID.IntegralHeight = false;
            this.comboBoxClientID.Location = new System.Drawing.Point(231, 80);
            this.comboBoxClientID.Name = "comboBoxClientID";
            this.comboBoxClientID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClientID.TabIndex = 40;
            // 
            // comboBoxTourID
            // 
            this.comboBoxTourID.DropDownHeight = 50;
            this.comboBoxTourID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxTourID.FormattingEnabled = true;
            this.comboBoxTourID.IntegralHeight = false;
            this.comboBoxTourID.Location = new System.Drawing.Point(231, 176);
            this.comboBoxTourID.Name = "comboBoxTourID";
            this.comboBoxTourID.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTourID.TabIndex = 41;
            // 
            // AddReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 453);
            this.Controls.Add(this.comboBoxTourID);
            this.Controls.Add(this.comboBoxClientID);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAddReservation);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxSeatsReserved);
            this.Controls.Add(this.textBoxReservationDate);
            this.Name = "AddReservationsForm";
            this.Text = "Добавление нового бронирования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddReservationsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxSeatsReserved;
        private System.Windows.Forms.TextBox textBoxReservationDate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAddReservation;
        private System.Windows.Forms.Button buttonBack;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxClientID;
        private System.Windows.Forms.ComboBox comboBoxTourID;
    }
}