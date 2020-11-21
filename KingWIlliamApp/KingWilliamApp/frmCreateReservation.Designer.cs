namespace KingWilliamApp
{
    partial class frmEditReservation
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.lblPageName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudGuests = new System.Windows.Forms.NumericUpDown();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlColumn3 = new System.Windows.Forms.Panel();
            this.cbxProvince = new System.Windows.Forms.ComboBox();
            this.pnlColumn2 = new System.Windows.Forms.Panel();
            this.pnlColumn1 = new System.Windows.Forms.Panel();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlColumn3.SuspendLayout();
            this.pnlColumn2.SuspendLayout();
            this.pnlColumn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Location = new System.Drawing.Point(0, 609);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(789, 64);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Create";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(35, 324);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(197, 30);
            this.txtPhone.TabIndex = 11;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblLabel.Location = new System.Drawing.Point(24, 43);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(96, 23);
            this.lblLabel.TabIndex = 10;
            this.lblLabel.Text = "Start Date";
            // 
            // lblPageName
            // 
            this.lblPageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageName.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPageName.Location = new System.Drawing.Point(0, 0);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(789, 101);
            this.lblPageName.TabIndex = 23;
            this.lblPageName.Text = "Create Reservation";
            this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(12, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 39);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(35, 239);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(197, 30);
            this.txtLastName.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(24, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(24, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Room Number";
            // 
            // txtCountry
            // 
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(35, 416);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(197, 30);
            this.txtCountry.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(24, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(31, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Number Of Guests";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(31, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(31, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(31, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(31, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 34;
            this.label8.Text = "Address Line 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(31, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "Address Line 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(31, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(31, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 37;
            this.label11.Text = "Country";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(31, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 23);
            this.label12.TabIndex = 38;
            this.label12.Text = "Postal Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(31, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 23);
            this.label13.TabIndex = 39;
            this.label13.Text = "Province";
            // 
            // nudGuests
            // 
            this.nudGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGuests.Location = new System.Drawing.Point(35, 69);
            this.nudGuests.Name = "nudGuests";
            this.nudGuests.Size = new System.Drawing.Size(197, 26);
            this.nudGuests.TabIndex = 40;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostalCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(35, 416);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(197, 30);
            this.txtPostalCode.TabIndex = 27;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(28, 69);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(208, 22);
            this.dateStart.TabIndex = 41;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(28, 152);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(208, 22);
            this.dateEnd.TabIndex = 42;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(28, 324);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(208, 122);
            this.txtNotes.TabIndex = 43;
            this.txtNotes.Text = "";
            // 
            // txtAddress1
            // 
            this.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(35, 69);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(197, 30);
            this.txtAddress1.TabIndex = 44;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(35, 152);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(197, 30);
            this.txtFirstName.TabIndex = 45;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pnlExit);
            this.pnlHeader.Controls.Add(this.lblPageName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(789, 101);
            this.pnlHeader.TabIndex = 46;
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.btnClose);
            this.pnlExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlExit.Location = new System.Drawing.Point(0, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(119, 101);
            this.pnlExit.TabIndex = 24;
            // 
            // txtAddress2
            // 
            this.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(35, 152);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(197, 30);
            this.txtAddress2.TabIndex = 47;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(35, 239);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(197, 30);
            this.txtCity.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlColumn3);
            this.panel2.Controls.Add(this.pnlColumn2);
            this.panel2.Controls.Add(this.pnlColumn1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 508);
            this.panel2.TabIndex = 49;
            // 
            // pnlColumn3
            // 
            this.pnlColumn3.Controls.Add(this.cbxProvince);
            this.pnlColumn3.Controls.Add(this.label9);
            this.pnlColumn3.Controls.Add(this.txtAddress2);
            this.pnlColumn3.Controls.Add(this.label11);
            this.pnlColumn3.Controls.Add(this.txtCountry);
            this.pnlColumn3.Controls.Add(this.label13);
            this.pnlColumn3.Controls.Add(this.label10);
            this.pnlColumn3.Controls.Add(this.txtCity);
            this.pnlColumn3.Controls.Add(this.label8);
            this.pnlColumn3.Controls.Add(this.txtAddress1);
            this.pnlColumn3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColumn3.Location = new System.Drawing.Point(526, 0);
            this.pnlColumn3.Name = "pnlColumn3";
            this.pnlColumn3.Size = new System.Drawing.Size(263, 508);
            this.pnlColumn3.TabIndex = 51;
            // 
            // cbxProvince
            // 
            this.cbxProvince.FormattingEnabled = true;
            this.cbxProvince.Location = new System.Drawing.Point(35, 324);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Size = new System.Drawing.Size(197, 24);
            this.cbxProvince.TabIndex = 49;
            // 
            // pnlColumn2
            // 
            this.pnlColumn2.Controls.Add(this.nudGuests);
            this.pnlColumn2.Controls.Add(this.label4);
            this.pnlColumn2.Controls.Add(this.label12);
            this.pnlColumn2.Controls.Add(this.label5);
            this.pnlColumn2.Controls.Add(this.txtFirstName);
            this.pnlColumn2.Controls.Add(this.label6);
            this.pnlColumn2.Controls.Add(this.txtLastName);
            this.pnlColumn2.Controls.Add(this.txtPostalCode);
            this.pnlColumn2.Controls.Add(this.label7);
            this.pnlColumn2.Controls.Add(this.txtPhone);
            this.pnlColumn2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColumn2.Location = new System.Drawing.Point(263, 0);
            this.pnlColumn2.Name = "pnlColumn2";
            this.pnlColumn2.Size = new System.Drawing.Size(263, 508);
            this.pnlColumn2.TabIndex = 50;
            // 
            // pnlColumn1
            // 
            this.pnlColumn1.Controls.Add(this.cbxRoom);
            this.pnlColumn1.Controls.Add(this.label1);
            this.pnlColumn1.Controls.Add(this.lblLabel);
            this.pnlColumn1.Controls.Add(this.dateEnd);
            this.pnlColumn1.Controls.Add(this.label2);
            this.pnlColumn1.Controls.Add(this.dateStart);
            this.pnlColumn1.Controls.Add(this.txtNotes);
            this.pnlColumn1.Controls.Add(this.label3);
            this.pnlColumn1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColumn1.Location = new System.Drawing.Point(0, 0);
            this.pnlColumn1.Name = "pnlColumn1";
            this.pnlColumn1.Size = new System.Drawing.Size(263, 508);
            this.pnlColumn1.TabIndex = 49;
            // 
            // cbxRoom
            // 
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(28, 239);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(208, 24);
            this.cbxRoom.TabIndex = 44;
            // 
            // frmEditReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 673);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditReservation";
            this.Text = "Create Reservation";
            this.Load += new System.EventHandler(this.frmCreateReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlColumn3.ResumeLayout(false);
            this.pnlColumn3.PerformLayout();
            this.pnlColumn2.ResumeLayout(false);
            this.pnlColumn2.PerformLayout();
            this.pnlColumn1.ResumeLayout(false);
            this.pnlColumn1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudGuests;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlColumn3;
        private System.Windows.Forms.Panel pnlColumn2;
        private System.Windows.Forms.Panel pnlColumn1;
        private System.Windows.Forms.ComboBox cbxProvince;
        private System.Windows.Forms.ComboBox cbxRoom;
    }
}