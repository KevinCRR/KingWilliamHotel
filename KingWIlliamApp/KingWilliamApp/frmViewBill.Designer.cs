namespace KingWilliamApp
{
    partial class frmViewBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageName = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblBillAmount = new System.Windows.Forms.Label();
            this.txtBillAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentType = new System.Windows.Forms.Label();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.lblAmountOwing = new System.Windows.Forms.Label();
            this.txtAmountOwing = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.reservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlList = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlHeader.Controls.Add(this.lblPageName);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1169, 82);
            this.pnlHeader.TabIndex = 60;
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
            this.lblPageName.Size = new System.Drawing.Size(1169, 82);
            this.lblPageName.TabIndex = 24;
            this.lblPageName.Text = "Bill";
            this.lblPageName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlBody.Controls.Add(this.btnPrint);
            this.pnlBody.Controls.Add(this.btnNew);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Controls.Add(this.lblMessage);
            this.pnlBody.Controls.Add(this.lblBillAmount);
            this.pnlBody.Controls.Add(this.txtBillAmount);
            this.pnlBody.Controls.Add(this.lblPaymentType);
            this.pnlBody.Controls.Add(this.txtPaymentType);
            this.pnlBody.Controls.Add(this.lblAmountOwing);
            this.pnlBody.Controls.Add(this.txtAmountOwing);
            this.pnlBody.Location = new System.Drawing.Point(235, 84);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBody.MaximumSize = new System.Drawing.Size(622, 451);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(622, 112);
            this.pnlBody.TabIndex = 61;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.DimGray;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(454, 77);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(133, 27);
            this.btnPrint.TabIndex = 89;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DimGray;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(38, 77);
            this.btnNew.Margin = new System.Windows.Forms.Padding(0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(133, 27);
            this.btnNew.TabIndex = 88;
            this.btnNew.Text = "New Transaction";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(208, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 21);
            this.label2.TabIndex = 86;
            this.label2.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 21);
            this.label1.TabIndex = 85;
            this.label1.Text = "$";
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(210, 77);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(186, 27);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBillAmount
            // 
            this.lblBillAmount.AutoSize = true;
            this.lblBillAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillAmount.ForeColor = System.Drawing.Color.Black;
            this.lblBillAmount.Location = new System.Drawing.Point(33, 7);
            this.lblBillAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBillAmount.Name = "lblBillAmount";
            this.lblBillAmount.Size = new System.Drawing.Size(91, 21);
            this.lblBillAmount.TabIndex = 82;
            this.lblBillAmount.Text = "Bill Amount";
            // 
            // txtBillAmount
            // 
            this.txtBillAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBillAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillAmount.Location = new System.Drawing.Point(37, 30);
            this.txtBillAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtBillAmount.Name = "txtBillAmount";
            this.txtBillAmount.ReadOnly = true;
            this.txtBillAmount.Size = new System.Drawing.Size(136, 25);
            this.txtBillAmount.TabIndex = 0;
            // 
            // lblPaymentType
            // 
            this.lblPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentType.AutoSize = true;
            this.lblPaymentType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentType.ForeColor = System.Drawing.Color.Black;
            this.lblPaymentType.Location = new System.Drawing.Point(423, 9);
            this.lblPaymentType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaymentType.Name = "lblPaymentType";
            this.lblPaymentType.Size = new System.Drawing.Size(106, 21);
            this.lblPaymentType.TabIndex = 83;
            this.lblPaymentType.Text = "Payment Type";
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPaymentType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPaymentType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentType.Location = new System.Drawing.Point(427, 32);
            this.txtPaymentType.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(160, 25);
            this.txtPaymentType.TabIndex = 1;
            // 
            // lblAmountOwing
            // 
            this.lblAmountOwing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblAmountOwing.AutoSize = true;
            this.lblAmountOwing.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOwing.ForeColor = System.Drawing.Color.Black;
            this.lblAmountOwing.Location = new System.Drawing.Point(227, 7);
            this.lblAmountOwing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountOwing.Name = "lblAmountOwing";
            this.lblAmountOwing.Size = new System.Drawing.Size(116, 21);
            this.lblAmountOwing.TabIndex = 84;
            this.lblAmountOwing.Text = "Amount Owing";
            // 
            // txtAmountOwing
            // 
            this.txtAmountOwing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtAmountOwing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmountOwing.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountOwing.Location = new System.Drawing.Point(231, 32);
            this.txtAmountOwing.Margin = new System.Windows.Forms.Padding(2);
            this.txtAmountOwing.Name = "txtAmountOwing";
            this.txtAmountOwing.Size = new System.Drawing.Size(136, 25);
            this.txtAmountOwing.TabIndex = 2;
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
            this.btnSubmit.Size = new System.Drawing.Size(1169, 52);
            this.btnSubmit.TabIndex = 59;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationID,
            this.itemName,
            this.itemDescription,
            this.itemPrice,
            this.amountOfItems,
            this.date,
            this.delete});
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTransactions.Location = new System.Drawing.Point(0, 0);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactions.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTransactions.RowTemplate.Height = 28;
            this.dgvTransactions.Size = new System.Drawing.Size(1095, 294);
            this.dgvTransactions.TabIndex = 0;
            this.dgvTransactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellClick);
            this.dgvTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellContentClick);
            // 
            // reservationID
            // 
            this.reservationID.FillWeight = 30F;
            this.reservationID.HeaderText = "ID";
            this.reservationID.Name = "reservationID";
            this.reservationID.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // itemDescription
            // 
            this.itemDescription.HeaderText = "Item Description";
            this.itemDescription.Name = "itemDescription";
            this.itemDescription.ReadOnly = true;
            // 
            // itemPrice
            // 
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.itemPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.itemPrice.HeaderText = "Item Price";
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.ReadOnly = true;
            // 
            // amountOfItems
            // 
            this.amountOfItems.HeaderText = "Amount of Items";
            this.amountOfItems.Name = "amountOfItems";
            this.amountOfItems.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // delete
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.delete.DefaultCellStyle = dataGridViewCellStyle8;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.BackColor = System.Drawing.Color.White;
            this.pnlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlList.Controls.Add(this.dgvTransactions);
            this.pnlList.Location = new System.Drawing.Point(37, 198);
            this.pnlList.Margin = new System.Windows.Forms.Padding(2);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1097, 296);
            this.pnlList.TabIndex = 87;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmViewBill
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 585);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmViewBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Bill";
            this.Load += new System.EventHandler(this.frmViewBill_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.pnlList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblBillAmount;
        private System.Windows.Forms.TextBox txtBillAmount;
        private System.Windows.Forms.Label lblPaymentType;
        private System.Windows.Forms.TextBox txtPaymentType;
        private System.Windows.Forms.Label lblAmountOwing;
        private System.Windows.Forms.TextBox txtAmountOwing;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOfItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}