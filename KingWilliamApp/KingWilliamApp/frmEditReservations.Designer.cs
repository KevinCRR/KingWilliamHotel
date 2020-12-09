namespace KingWilliamApp
{
    partial class frmEditReservations
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageName = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.nudGuests = new System.Windows.Forms.NumericUpDown();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cbxRoom = new System.Windows.Forms.ComboBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblNumberOfGuests = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(0, 533);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(622, 52);
            this.btnSubmit.TabIndex = 57;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlHeader.Controls.Add(this.lblPageName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(622, 82);
            this.pnlHeader.TabIndex = 55;
            // 
            // lblPageName
            // 
            this.lblPageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPageName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageName.ForeColor = System.Drawing.Color.White;
            this.lblPageName.Location = new System.Drawing.Point(0, 0);
            this.lblPageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblPageName.Size = new System.Drawing.Size(622, 82);
            this.lblPageName.TabIndex = 24;
            this.lblPageName.Text = "Edit Reservation";
            this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateEnd
            // 
            this.dateEnd.CalendarFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(49, 182);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(216, 25);
            this.dateEnd.TabIndex = 88;
            this.dateEnd.Value = new System.DateTime(2020, 12, 7, 14, 41, 59, 0);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(49, 309);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(503, 102);
            this.lblMessage.TabIndex = 87;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(338, 182);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(214, 94);
            this.txtNotes.TabIndex = 43;
            this.txtNotes.Text = "";
            // 
            // nudGuests
            // 
            this.nudGuests.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGuests.Location = new System.Drawing.Point(338, 115);
            this.nudGuests.Margin = new System.Windows.Forms.Padding(2);
            this.nudGuests.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudGuests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGuests.Name = "nudGuests";
            this.nudGuests.Size = new System.Drawing.Size(214, 25);
            this.nudGuests.TabIndex = 40;
            this.nudGuests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(45, 92);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(78, 21);
            this.lblStartDate.TabIndex = 82;
            this.lblStartDate.Text = "Start Date";
            // 
            // cbxRoom
            // 
            this.cbxRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRoom.FormattingEnabled = true;
            this.cbxRoom.Location = new System.Drawing.Point(49, 251);
            this.cbxRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.Size = new System.Drawing.Size(216, 25);
            this.cbxRoom.TabIndex = 44;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.Black;
            this.lblEndDate.Location = new System.Drawing.Point(47, 159);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(72, 21);
            this.lblEndDate.TabIndex = 83;
            this.lblEndDate.Text = "End Date";
            // 
            // lblRoom
            // 
            this.lblRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.ForeColor = System.Drawing.Color.Black;
            this.lblRoom.Location = new System.Drawing.Point(45, 229);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(114, 21);
            this.lblRoom.TabIndex = 84;
            this.lblRoom.Text = "Room Number";
            // 
            // dateStart
            // 
            this.dateStart.CalendarFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Location = new System.Drawing.Point(49, 115);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(216, 25);
            this.dateStart.TabIndex = 41;
            // 
            // lblNotes
            // 
            this.lblNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.Black;
            this.lblNotes.Location = new System.Drawing.Point(334, 159);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(51, 21);
            this.lblNotes.TabIndex = 71;
            this.lblNotes.Text = "Notes";
            // 
            // lblNumberOfGuests
            // 
            this.lblNumberOfGuests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNumberOfGuests.AutoSize = true;
            this.lblNumberOfGuests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGuests.ForeColor = System.Drawing.Color.Black;
            this.lblNumberOfGuests.Location = new System.Drawing.Point(334, 92);
            this.lblNumberOfGuests.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfGuests.Name = "lblNumberOfGuests";
            this.lblNumberOfGuests.Size = new System.Drawing.Size(137, 21);
            this.lblNumberOfGuests.TabIndex = 70;
            this.lblNumberOfGuests.Text = "Number of Guests";
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBody.Controls.Add(this.dateEnd);
            this.pnlBody.Controls.Add(this.lblMessage);
            this.pnlBody.Controls.Add(this.txtNotes);
            this.pnlBody.Controls.Add(this.nudGuests);
            this.pnlBody.Controls.Add(this.lblStartDate);
            this.pnlBody.Controls.Add(this.cbxRoom);
            this.pnlBody.Controls.Add(this.lblEndDate);
            this.pnlBody.Controls.Add(this.lblRoom);
            this.pnlBody.Controls.Add(this.dateStart);
            this.pnlBody.Controls.Add(this.lblNotes);
            this.pnlBody.Controls.Add(this.lblNumberOfGuests);
            this.pnlBody.Location = new System.Drawing.Point(0, 82);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBody.MaximumSize = new System.Drawing.Size(622, 451);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(622, 451);
            this.pnlBody.TabIndex = 56;
            // 
            // frmEditReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(622, 585);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEditReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Reservations";
            this.Load += new System.EventHandler(this.frmEditReservations_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.NumericUpDown nudGuests;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.ComboBox cbxRoom;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblNumberOfGuests;
        private System.Windows.Forms.Panel pnlBody;
    }
}