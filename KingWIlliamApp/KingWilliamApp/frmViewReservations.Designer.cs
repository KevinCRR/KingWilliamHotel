namespace KingWilliamApp
{
    partial class frmViewReservations
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
            this.lblPageName = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlColumn1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblLabel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pnlColumn2 = new System.Windows.Forms.Panel();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.nudGuests = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlExit.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlColumn1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlColumn2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPageName
            // 
            this.lblPageName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageName.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPageName.Location = new System.Drawing.Point(0, 0);
            this.lblPageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(609, 82);
            this.lblPageName.TabIndex = 23;
            this.lblPageName.Text = "View Reservation";
            this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlExit.Controls.Add(this.btnClose);
            this.pnlExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlExit.Location = new System.Drawing.Point(0, 0);
            this.pnlExit.Margin = new System.Windows.Forms.Padding(2);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(89, 82);
            this.pnlExit.TabIndex = 24;
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
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pnlExit);
            this.pnlHeader.Controls.Add(this.lblPageName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(609, 82);
            this.pnlHeader.TabIndex = 54;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Location = new System.Drawing.Point(0, 495);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(609, 52);
            this.btnSubmit.TabIndex = 53;
            this.btnSubmit.Text = "Save Changes";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlColumn1
            // 
            this.pnlColumn1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlColumn1.Controls.Add(this.lblMessage);
            this.pnlColumn1.Controls.Add(this.pnlSearch);
            this.pnlColumn1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColumn1.Location = new System.Drawing.Point(0, 0);
            this.pnlColumn1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlColumn1.Name = "pnlColumn1";
            this.pnlColumn1.Size = new System.Drawing.Size(296, 495);
            this.pnlColumn1.TabIndex = 49;
            this.pnlColumn1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlColumn1_Paint);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessage.Location = new System.Drawing.Point(58, 433);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(187, 41);
            this.lblMessage.TabIndex = 53;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSearch.Controls.Add(this.lblLabel);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.dateStart);
            this.pnlSearch.Controls.Add(this.txtLastName);
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Controls.Add(this.label6);
            this.pnlSearch.Controls.Add(this.txtFirstName);
            this.pnlSearch.Location = new System.Drawing.Point(61, 124);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(188, 301);
            this.pnlSearch.TabIndex = 52;
            this.pnlSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearch_Paint);
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabel.ForeColor = System.Drawing.Color.Gray;
            this.lblLabel.Location = new System.Drawing.Point(11, 11);
            this.lblLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(80, 19);
            this.lblLabel.TabIndex = 10;
            this.lblLabel.Text = "Start Date";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.Location = new System.Drawing.Point(14, 236);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 46);
            this.btnSearch.TabIndex = 51;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(14, 32);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(157, 20);
            this.dateStart.TabIndex = 41;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(14, 171);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(156, 25);
            this.txtLastName.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(11, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(11, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(14, 100);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 25);
            this.txtFirstName.TabIndex = 45;
            // 
            // pnlColumn2
            // 
            this.pnlColumn2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlColumn2.Controls.Add(this.cbxRoom);
            this.pnlColumn2.Controls.Add(this.nudGuests);
            this.pnlColumn2.Controls.Add(this.label1);
            this.pnlColumn2.Controls.Add(this.label4);
            this.pnlColumn2.Controls.Add(this.dateEnd);
            this.pnlColumn2.Controls.Add(this.label2);
            this.pnlColumn2.Controls.Add(this.txtNotes);
            this.pnlColumn2.Controls.Add(this.label3);
            this.pnlColumn2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColumn2.Location = new System.Drawing.Point(296, 0);
            this.pnlColumn2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlColumn2.Name = "pnlColumn2";
            this.pnlColumn2.Size = new System.Drawing.Size(296, 495);
            this.pnlColumn2.TabIndex = 50;
            this.pnlColumn2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlColumn2_Paint);
            // 
            // cbxRoom
            // 
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(59, 267);
            this.cbxRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(149, 21);
            this.cbxRoom.TabIndex = 44;
            this.cbxRoom.SelectedIndexChanged += new System.EventHandler(this.cbxRoom_SelectedIndexChanged);
            // 
            // nudGuests
            // 
            this.nudGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGuests.Location = new System.Drawing.Point(59, 129);
            this.nudGuests.Margin = new System.Windows.Forms.Padding(2);
            this.nudGuests.Name = "nudGuests";
            this.nudGuests.Size = new System.Drawing.Size(148, 23);
            this.nudGuests.TabIndex = 40;
            this.nudGuests.ValueChanged += new System.EventHandler(this.nudGuests_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(56, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "End Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(56, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Number Of Guests";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(59, 197);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(149, 20);
            this.dateEnd.TabIndex = 42;
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(56, 245);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Room Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(59, 332);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(149, 100);
            this.txtNotes.TabIndex = 43;
            this.txtNotes.Text = "";
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(56, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Notes";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.pnlColumn2);
            this.panel2.Controls.Add(this.pnlColumn1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(609, 495);
            this.panel2.TabIndex = 55;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // frmViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 547);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewReservations";
            this.Text = "frmReservations";
            this.pnlExit.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlColumn1.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlColumn2.ResumeLayout(false);
            this.pnlColumn2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlColumn1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Panel pnlColumn2;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.NumericUpDown nudGuests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}