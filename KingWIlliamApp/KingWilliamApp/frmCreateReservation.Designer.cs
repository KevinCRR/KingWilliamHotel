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
            this.lblPageName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlColumn1 = new System.Windows.Forms.Panel();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nudGuests = new System.Windows.Forms.NumericUpDown();
            this.pnlColumn2 = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlColumn1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).BeginInit();
            this.pnlColumn2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Location = new System.Drawing.Point(0, 495);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(592, 52);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Create";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblPageName
            // 
            this.lblPageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageName.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPageName.Location = new System.Drawing.Point(0, 0);
            this.lblPageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(592, 82);
            this.lblPageName.TabIndex = 23;
            this.lblPageName.Text = "Create Reservation";
            this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Maroon;
            this.btnClose.Location = new System.Drawing.Point(9, 21);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 32);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(18, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "End Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(18, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(24, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Notes";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(21, 124);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(157, 20);
            this.dateEnd.TabIndex = 42;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(27, 124);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(157, 100);
            this.txtNotes.TabIndex = 43;
            this.txtNotes.Text = "";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pnlExit);
            this.pnlHeader.Controls.Add(this.lblPageName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(592, 82);
            this.pnlHeader.TabIndex = 46;
            // 
            // pnlExit
            // 
            this.pnlExit.Controls.Add(this.btnClose);
            this.pnlExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlExit.Location = new System.Drawing.Point(0, 0);
            this.pnlExit.Margin = new System.Windows.Forms.Padding(2);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(89, 82);
            this.pnlExit.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlColumn2);
            this.panel2.Controls.Add(this.pnlColumn1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 413);
            this.panel2.TabIndex = 49;
            // 
            // pnlColumn1
            // 
            this.pnlColumn1.Controls.Add(this.cbxRoom);
            this.pnlColumn1.Controls.Add(this.label1);
            this.pnlColumn1.Controls.Add(this.lblLabel);
            this.pnlColumn1.Controls.Add(this.dateEnd);
            this.pnlColumn1.Controls.Add(this.label2);
            this.pnlColumn1.Controls.Add(this.dateStart);
            this.pnlColumn1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColumn1.Location = new System.Drawing.Point(0, 0);
            this.pnlColumn1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlColumn1.Name = "pnlColumn1";
            this.pnlColumn1.Size = new System.Drawing.Size(300, 413);
            this.pnlColumn1.TabIndex = 49;
            // 
            // cbxRoom
            // 
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(21, 194);
            this.cbxRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(157, 21);
            this.cbxRoom.TabIndex = 44;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblLabel.Location = new System.Drawing.Point(18, 35);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(80, 19);
            this.lblLabel.TabIndex = 10;
            this.lblLabel.Text = "Start Date";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(21, 56);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(157, 20);
            this.dateStart.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(23, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Number Of Guests";
            // 
            // nudGuests
            // 
            this.nudGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGuests.Location = new System.Drawing.Point(26, 56);
            this.nudGuests.Margin = new System.Windows.Forms.Padding(2);
            this.nudGuests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGuests.Name = "nudGuests";
            this.nudGuests.Size = new System.Drawing.Size(148, 23);
            this.nudGuests.TabIndex = 40;
            this.nudGuests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pnlColumn2
            // 
            this.pnlColumn2.Controls.Add(this.nudGuests);
            this.pnlColumn2.Controls.Add(this.label4);
            this.pnlColumn2.Controls.Add(this.txtNotes);
            this.pnlColumn2.Controls.Add(this.label3);
            this.pnlColumn2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColumn2.Location = new System.Drawing.Point(300, 0);
            this.pnlColumn2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlColumn2.Name = "pnlColumn2";
            this.pnlColumn2.Size = new System.Drawing.Size(292, 413);
            this.pnlColumn2.TabIndex = 50;
            // 
            // frmEditReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEditReservation";
            this.Text = "Create Reservation";
            this.Load += new System.EventHandler(this.frmCreateReservation_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlExit.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlColumn1.ResumeLayout(false);
            this.pnlColumn1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).EndInit();
            this.pnlColumn2.ResumeLayout(false);
            this.pnlColumn2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlColumn1;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Panel pnlColumn2;
        private System.Windows.Forms.NumericUpDown nudGuests;
        private System.Windows.Forms.Label label4;
    }
}