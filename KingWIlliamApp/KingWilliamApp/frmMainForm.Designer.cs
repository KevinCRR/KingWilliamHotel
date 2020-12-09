﻿namespace KingWilliamApp
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlMenuButtons = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserCreate = new System.Windows.Forms.Button();
            this.btnUserView = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.pnlEmploymentPositions = new System.Windows.Forms.Panel();
            this.btnEmploymentPositionEdit = new System.Windows.Forms.Button();
            this.btnEmploymentPositionCreate = new System.Windows.Forms.Button();
            this.btnEmploymentPositionView = new System.Windows.Forms.Button();
            this.btnEmploymentPositions = new System.Windows.Forms.Button();
            this.pnlStaff = new System.Windows.Forms.Panel();
            this.btnStaffEdit = new System.Windows.Forms.Button();
            this.btnStaffCreate = new System.Windows.Forms.Button();
            this.btnStaffView = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.pnlClients = new System.Windows.Forms.Panel();
            this.btnCustomerEdit = new System.Windows.Forms.Button();
            this.btnCustomerCreate = new System.Windows.Forms.Button();
            this.btnCustomerView = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.pnlRoomTypes = new System.Windows.Forms.Panel();
            this.btnRoomTypeEdit = new System.Windows.Forms.Button();
            this.btnRoomTypeCreate = new System.Windows.Forms.Button();
            this.btnRoomTypeView = new System.Windows.Forms.Button();
            this.btnRoomTypes = new System.Windows.Forms.Button();
            this.pnlRooms = new System.Windows.Forms.Panel();
            this.btnRoomEdit = new System.Windows.Forms.Button();
            this.btnRoomView = new System.Windows.Forms.Button();
            this.btnRooms = new System.Windows.Forms.Button();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.btnTransactionEdit = new System.Windows.Forms.Button();
            this.btnTransactionCreate = new System.Windows.Forms.Button();
            this.btnTransactionsView = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.pnlChargeableItems = new System.Windows.Forms.Panel();
            this.btnChargeableItemEdit = new System.Windows.Forms.Button();
            this.btnChargeableItemCreate = new System.Windows.Forms.Button();
            this.btnChargeableItemView = new System.Windows.Forms.Button();
            this.btnChargeableItems = new System.Windows.Forms.Button();
            this.pnlBills = new System.Windows.Forms.Panel();
            this.btnBillEdit = new System.Windows.Forms.Button();
            this.btnBillView = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.pnlReservations = new System.Windows.Forms.Panel();
            this.btnReservationEdit = new System.Windows.Forms.Button();
            this.btnReservationCreate = new System.Windows.Forms.Button();
            this.btnReservationView = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.pnlActiveUser = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.lblKingWilliam = new System.Windows.Forms.Label();
            this.pbxKingWilliam = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlMenuButtons.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            this.pnlEmploymentPositions.SuspendLayout();
            this.pnlStaff.SuspendLayout();
            this.pnlClients.SuspendLayout();
            this.pnlRoomTypes.SuspendLayout();
            this.pnlRooms.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlChargeableItems.SuspendLayout();
            this.pnlBills.SuspendLayout();
            this.pnlReservations.SuspendLayout();
            this.pnlActiveUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKingWilliam)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenu.Controls.Add(this.pnlMenuButtons);
            this.pnlMenu.Controls.Add(this.pnlActiveUser);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(233, 553);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlMenuButtons
            // 
            this.pnlMenuButtons.AutoScroll = true;
            this.pnlMenuButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuButtons.Controls.Add(this.btnSignOut);
            this.pnlMenuButtons.Controls.Add(this.pnlUsers);
            this.pnlMenuButtons.Controls.Add(this.btnUsers);
            this.pnlMenuButtons.Controls.Add(this.pnlEmploymentPositions);
            this.pnlMenuButtons.Controls.Add(this.btnEmploymentPositions);
            this.pnlMenuButtons.Controls.Add(this.pnlStaff);
            this.pnlMenuButtons.Controls.Add(this.btnStaff);
            this.pnlMenuButtons.Controls.Add(this.pnlClients);
            this.pnlMenuButtons.Controls.Add(this.btnCustomers);
            this.pnlMenuButtons.Controls.Add(this.pnlRoomTypes);
            this.pnlMenuButtons.Controls.Add(this.btnRoomTypes);
            this.pnlMenuButtons.Controls.Add(this.pnlRooms);
            this.pnlMenuButtons.Controls.Add(this.btnRooms);
            this.pnlMenuButtons.Controls.Add(this.pnlTransactions);
            this.pnlMenuButtons.Controls.Add(this.btnTransactions);
            this.pnlMenuButtons.Controls.Add(this.pnlChargeableItems);
            this.pnlMenuButtons.Controls.Add(this.btnChargeableItems);
            this.pnlMenuButtons.Controls.Add(this.pnlBills);
            this.pnlMenuButtons.Controls.Add(this.btnBills);
            this.pnlMenuButtons.Controls.Add(this.pnlReservations);
            this.pnlMenuButtons.Controls.Add(this.btnReservations);
            this.pnlMenuButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuButtons.Location = new System.Drawing.Point(0, 111);
            this.pnlMenuButtons.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlMenuButtons.Name = "pnlMenuButtons";
            this.pnlMenuButtons.Size = new System.Drawing.Size(231, 440);
            this.pnlMenuButtons.TabIndex = 4;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.Black;
            this.btnSignOut.Location = new System.Drawing.Point(0, 1397);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.btnSignOut.Size = new System.Drawing.Size(214, 49);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // pnlUsers
            // 
            this.pnlUsers.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsers.Controls.Add(this.btnUserDelete);
            this.pnlUsers.Controls.Add(this.btnUserCreate);
            this.pnlUsers.Controls.Add(this.btnUserView);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsers.Location = new System.Drawing.Point(0, 1299);
            this.pnlUsers.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(214, 98);
            this.pnlUsers.TabIndex = 17;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserDelete.FlatAppearance.BorderSize = 0;
            this.btnUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserDelete.ForeColor = System.Drawing.Color.Black;
            this.btnUserDelete.Location = new System.Drawing.Point(0, 64);
            this.btnUserDelete.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnUserDelete.Size = new System.Drawing.Size(214, 32);
            this.btnUserDelete.TabIndex = 2;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserDelete.UseVisualStyleBackColor = false;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserCreate
            // 
            this.btnUserCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserCreate.FlatAppearance.BorderSize = 0;
            this.btnUserCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserCreate.ForeColor = System.Drawing.Color.Black;
            this.btnUserCreate.Location = new System.Drawing.Point(0, 32);
            this.btnUserCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUserCreate.Name = "btnUserCreate";
            this.btnUserCreate.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnUserCreate.Size = new System.Drawing.Size(214, 32);
            this.btnUserCreate.TabIndex = 1;
            this.btnUserCreate.Text = "Create";
            this.btnUserCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserCreate.UseVisualStyleBackColor = false;
            this.btnUserCreate.Click += new System.EventHandler(this.btnUserCreate_Click);
            // 
            // btnUserView
            // 
            this.btnUserView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserView.FlatAppearance.BorderSize = 0;
            this.btnUserView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserView.ForeColor = System.Drawing.Color.Black;
            this.btnUserView.Location = new System.Drawing.Point(0, 0);
            this.btnUserView.Margin = new System.Windows.Forms.Padding(0);
            this.btnUserView.Name = "btnUserView";
            this.btnUserView.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnUserView.Size = new System.Drawing.Size(214, 32);
            this.btnUserView.TabIndex = 0;
            this.btnUserView.Text = "View";
            this.btnUserView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserView.UseVisualStyleBackColor = false;
            this.btnUserView.Click += new System.EventHandler(this.btnUserView_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Location = new System.Drawing.Point(0, 1250);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(214, 49);
            this.btnUsers.TabIndex = 16;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // pnlEmploymentPositions
            // 
            this.pnlEmploymentPositions.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmploymentPositions.Controls.Add(this.btnEmploymentPositionEdit);
            this.pnlEmploymentPositions.Controls.Add(this.btnEmploymentPositionCreate);
            this.pnlEmploymentPositions.Controls.Add(this.btnEmploymentPositionView);
            this.pnlEmploymentPositions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEmploymentPositions.Location = new System.Drawing.Point(0, 1153);
            this.pnlEmploymentPositions.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlEmploymentPositions.Name = "pnlEmploymentPositions";
            this.pnlEmploymentPositions.Size = new System.Drawing.Size(214, 97);
            this.pnlEmploymentPositions.TabIndex = 19;
            // 
            // btnEmploymentPositionEdit
            // 
            this.btnEmploymentPositionEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmploymentPositionEdit.FlatAppearance.BorderSize = 0;
            this.btnEmploymentPositionEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploymentPositionEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEmploymentPositionEdit.Location = new System.Drawing.Point(0, 64);
            this.btnEmploymentPositionEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEmploymentPositionEdit.Name = "btnEmploymentPositionEdit";
            this.btnEmploymentPositionEdit.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnEmploymentPositionEdit.Size = new System.Drawing.Size(214, 32);
            this.btnEmploymentPositionEdit.TabIndex = 2;
            this.btnEmploymentPositionEdit.Text = "Edit";
            this.btnEmploymentPositionEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploymentPositionEdit.UseVisualStyleBackColor = false;
            this.btnEmploymentPositionEdit.Click += new System.EventHandler(this.btnEmploymentPositionEdit_Click);
            // 
            // btnEmploymentPositionCreate
            // 
            this.btnEmploymentPositionCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmploymentPositionCreate.FlatAppearance.BorderSize = 0;
            this.btnEmploymentPositionCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploymentPositionCreate.ForeColor = System.Drawing.Color.Black;
            this.btnEmploymentPositionCreate.Location = new System.Drawing.Point(0, 32);
            this.btnEmploymentPositionCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEmploymentPositionCreate.Name = "btnEmploymentPositionCreate";
            this.btnEmploymentPositionCreate.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnEmploymentPositionCreate.Size = new System.Drawing.Size(214, 32);
            this.btnEmploymentPositionCreate.TabIndex = 1;
            this.btnEmploymentPositionCreate.Text = "Create";
            this.btnEmploymentPositionCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploymentPositionCreate.UseVisualStyleBackColor = false;
            this.btnEmploymentPositionCreate.Click += new System.EventHandler(this.btnEmploymentPositionCreate_Click);
            // 
            // btnEmploymentPositionView
            // 
            this.btnEmploymentPositionView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmploymentPositionView.FlatAppearance.BorderSize = 0;
            this.btnEmploymentPositionView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploymentPositionView.ForeColor = System.Drawing.Color.Black;
            this.btnEmploymentPositionView.Location = new System.Drawing.Point(0, 0);
            this.btnEmploymentPositionView.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmploymentPositionView.Name = "btnEmploymentPositionView";
            this.btnEmploymentPositionView.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnEmploymentPositionView.Size = new System.Drawing.Size(214, 32);
            this.btnEmploymentPositionView.TabIndex = 0;
            this.btnEmploymentPositionView.Text = "View";
            this.btnEmploymentPositionView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploymentPositionView.UseVisualStyleBackColor = false;
            this.btnEmploymentPositionView.Click += new System.EventHandler(this.btnEmploymentPositionView_Click);
            // 
            // btnEmploymentPositions
            // 
            this.btnEmploymentPositions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmploymentPositions.FlatAppearance.BorderSize = 0;
            this.btnEmploymentPositions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploymentPositions.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploymentPositions.ForeColor = System.Drawing.Color.Black;
            this.btnEmploymentPositions.Location = new System.Drawing.Point(0, 1104);
            this.btnEmploymentPositions.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEmploymentPositions.Name = "btnEmploymentPositions";
            this.btnEmploymentPositions.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnEmploymentPositions.Size = new System.Drawing.Size(214, 49);
            this.btnEmploymentPositions.TabIndex = 18;
            this.btnEmploymentPositions.Text = "Employment Positions";
            this.btnEmploymentPositions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmploymentPositions.UseVisualStyleBackColor = false;
            this.btnEmploymentPositions.Click += new System.EventHandler(this.btnEmploymentPositions_Click);
            // 
            // pnlStaff
            // 
            this.pnlStaff.BackColor = System.Drawing.Color.Transparent;
            this.pnlStaff.Controls.Add(this.btnStaffEdit);
            this.pnlStaff.Controls.Add(this.btnStaffCreate);
            this.pnlStaff.Controls.Add(this.btnStaffView);
            this.pnlStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStaff.Location = new System.Drawing.Point(0, 1005);
            this.pnlStaff.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Size = new System.Drawing.Size(214, 99);
            this.pnlStaff.TabIndex = 11;
            // 
            // btnStaffEdit
            // 
            this.btnStaffEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffEdit.FlatAppearance.BorderSize = 0;
            this.btnStaffEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffEdit.ForeColor = System.Drawing.Color.Black;
            this.btnStaffEdit.Location = new System.Drawing.Point(0, 64);
            this.btnStaffEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnStaffEdit.Name = "btnStaffEdit";
            this.btnStaffEdit.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnStaffEdit.Size = new System.Drawing.Size(214, 32);
            this.btnStaffEdit.TabIndex = 2;
            this.btnStaffEdit.Text = "Edit";
            this.btnStaffEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffEdit.UseVisualStyleBackColor = false;
            this.btnStaffEdit.Click += new System.EventHandler(this.btnStaffEdit_Click);
            // 
            // btnStaffCreate
            // 
            this.btnStaffCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffCreate.FlatAppearance.BorderSize = 0;
            this.btnStaffCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffCreate.ForeColor = System.Drawing.Color.Black;
            this.btnStaffCreate.Location = new System.Drawing.Point(0, 32);
            this.btnStaffCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnStaffCreate.Name = "btnStaffCreate";
            this.btnStaffCreate.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnStaffCreate.Size = new System.Drawing.Size(214, 32);
            this.btnStaffCreate.TabIndex = 1;
            this.btnStaffCreate.Text = "Create";
            this.btnStaffCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffCreate.UseVisualStyleBackColor = false;
            this.btnStaffCreate.Click += new System.EventHandler(this.btnStaffCreate_Click);
            // 
            // btnStaffView
            // 
            this.btnStaffView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffView.FlatAppearance.BorderSize = 0;
            this.btnStaffView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffView.ForeColor = System.Drawing.Color.Black;
            this.btnStaffView.Location = new System.Drawing.Point(0, 0);
            this.btnStaffView.Margin = new System.Windows.Forms.Padding(0);
            this.btnStaffView.Name = "btnStaffView";
            this.btnStaffView.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnStaffView.Size = new System.Drawing.Size(214, 32);
            this.btnStaffView.TabIndex = 0;
            this.btnStaffView.Text = "View";
            this.btnStaffView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffView.UseVisualStyleBackColor = false;
            this.btnStaffView.Click += new System.EventHandler(this.btnStaffView_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Black;
            this.btnStaff.Location = new System.Drawing.Point(0, 956);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(214, 49);
            this.btnStaff.TabIndex = 10;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // pnlClients
            // 
            this.pnlClients.BackColor = System.Drawing.Color.Transparent;
            this.pnlClients.Controls.Add(this.btnCustomerEdit);
            this.pnlClients.Controls.Add(this.btnCustomerCreate);
            this.pnlClients.Controls.Add(this.btnCustomerView);
            this.pnlClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClients.Location = new System.Drawing.Point(0, 857);
            this.pnlClients.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlClients.Name = "pnlClients";
            this.pnlClients.Size = new System.Drawing.Size(214, 99);
            this.pnlClients.TabIndex = 9;
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerEdit.FlatAppearance.BorderSize = 0;
            this.btnCustomerEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerEdit.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerEdit.Location = new System.Drawing.Point(0, 64);
            this.btnCustomerEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnCustomerEdit.Size = new System.Drawing.Size(214, 35);
            this.btnCustomerEdit.TabIndex = 2;
            this.btnCustomerEdit.Text = "Edit";
            this.btnCustomerEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerEdit.UseVisualStyleBackColor = false;
            this.btnCustomerEdit.Click += new System.EventHandler(this.btnCustomerEdit_Click);
            // 
            // btnCustomerCreate
            // 
            this.btnCustomerCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerCreate.FlatAppearance.BorderSize = 0;
            this.btnCustomerCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerCreate.Location = new System.Drawing.Point(0, 32);
            this.btnCustomerCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCustomerCreate.Name = "btnCustomerCreate";
            this.btnCustomerCreate.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnCustomerCreate.Size = new System.Drawing.Size(214, 32);
            this.btnCustomerCreate.TabIndex = 1;
            this.btnCustomerCreate.Text = "Create";
            this.btnCustomerCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerCreate.UseVisualStyleBackColor = false;
            this.btnCustomerCreate.Click += new System.EventHandler(this.btnCustomerCreate_Click);
            // 
            // btnCustomerView
            // 
            this.btnCustomerView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerView.FlatAppearance.BorderSize = 0;
            this.btnCustomerView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerView.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerView.Location = new System.Drawing.Point(0, 0);
            this.btnCustomerView.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustomerView.Name = "btnCustomerView";
            this.btnCustomerView.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnCustomerView.Size = new System.Drawing.Size(214, 32);
            this.btnCustomerView.TabIndex = 0;
            this.btnCustomerView.Text = "View";
            this.btnCustomerView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerView.UseVisualStyleBackColor = false;
            this.btnCustomerView.Click += new System.EventHandler(this.btnCustomerView_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Location = new System.Drawing.Point(0, 808);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnCustomers.Size = new System.Drawing.Size(214, 49);
            this.btnCustomers.TabIndex = 8;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlRoomTypes
            // 
            this.pnlRoomTypes.BackColor = System.Drawing.Color.Transparent;
            this.pnlRoomTypes.Controls.Add(this.btnRoomTypeEdit);
            this.pnlRoomTypes.Controls.Add(this.btnRoomTypeCreate);
            this.pnlRoomTypes.Controls.Add(this.btnRoomTypeView);
            this.pnlRoomTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRoomTypes.Location = new System.Drawing.Point(0, 712);
            this.pnlRoomTypes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlRoomTypes.Name = "pnlRoomTypes";
            this.pnlRoomTypes.Size = new System.Drawing.Size(214, 96);
            this.pnlRoomTypes.TabIndex = 15;
            // 
            // btnRoomTypeEdit
            // 
            this.btnRoomTypeEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomTypeEdit.FlatAppearance.BorderSize = 0;
            this.btnRoomTypeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomTypeEdit.ForeColor = System.Drawing.Color.Black;
            this.btnRoomTypeEdit.Location = new System.Drawing.Point(0, 64);
            this.btnRoomTypeEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRoomTypeEdit.Name = "btnRoomTypeEdit";
            this.btnRoomTypeEdit.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnRoomTypeEdit.Size = new System.Drawing.Size(214, 32);
            this.btnRoomTypeEdit.TabIndex = 2;
            this.btnRoomTypeEdit.Text = "Edit";
            this.btnRoomTypeEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomTypeEdit.UseVisualStyleBackColor = false;
            this.btnRoomTypeEdit.Click += new System.EventHandler(this.btnRoomTypeEdit_Click);
            // 
            // btnRoomTypeCreate
            // 
            this.btnRoomTypeCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomTypeCreate.FlatAppearance.BorderSize = 0;
            this.btnRoomTypeCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomTypeCreate.ForeColor = System.Drawing.Color.Black;
            this.btnRoomTypeCreate.Location = new System.Drawing.Point(0, 32);
            this.btnRoomTypeCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRoomTypeCreate.Name = "btnRoomTypeCreate";
            this.btnRoomTypeCreate.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnRoomTypeCreate.Size = new System.Drawing.Size(214, 32);
            this.btnRoomTypeCreate.TabIndex = 1;
            this.btnRoomTypeCreate.Text = "Create";
            this.btnRoomTypeCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomTypeCreate.UseVisualStyleBackColor = false;
            this.btnRoomTypeCreate.Click += new System.EventHandler(this.btnRoomTypeCreate_Click);
            // 
            // btnRoomTypeView
            // 
            this.btnRoomTypeView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomTypeView.FlatAppearance.BorderSize = 0;
            this.btnRoomTypeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomTypeView.ForeColor = System.Drawing.Color.Black;
            this.btnRoomTypeView.Location = new System.Drawing.Point(0, 0);
            this.btnRoomTypeView.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomTypeView.Name = "btnRoomTypeView";
            this.btnRoomTypeView.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnRoomTypeView.Size = new System.Drawing.Size(214, 32);
            this.btnRoomTypeView.TabIndex = 0;
            this.btnRoomTypeView.Text = "View";
            this.btnRoomTypeView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomTypeView.UseVisualStyleBackColor = false;
            this.btnRoomTypeView.Click += new System.EventHandler(this.btnRoomTypeView_Click);
            // 
            // btnRoomTypes
            // 
            this.btnRoomTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomTypes.FlatAppearance.BorderSize = 0;
            this.btnRoomTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomTypes.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomTypes.ForeColor = System.Drawing.Color.Black;
            this.btnRoomTypes.Location = new System.Drawing.Point(0, 663);
            this.btnRoomTypes.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRoomTypes.Name = "btnRoomTypes";
            this.btnRoomTypes.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRoomTypes.Size = new System.Drawing.Size(214, 49);
            this.btnRoomTypes.TabIndex = 14;
            this.btnRoomTypes.Text = "Room Types";
            this.btnRoomTypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomTypes.UseVisualStyleBackColor = false;
            this.btnRoomTypes.Click += new System.EventHandler(this.btnRoomTypes_Click);
            // 
            // pnlRooms
            // 
            this.pnlRooms.BackColor = System.Drawing.Color.Transparent;
            this.pnlRooms.Controls.Add(this.btnRoomEdit);
            this.pnlRooms.Controls.Add(this.btnRoomView);
            this.pnlRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRooms.Location = new System.Drawing.Point(0, 599);
            this.pnlRooms.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlRooms.Name = "pnlRooms";
            this.pnlRooms.Size = new System.Drawing.Size(214, 64);
            this.pnlRooms.TabIndex = 7;
            // 
            // btnRoomEdit
            // 
            this.btnRoomEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomEdit.FlatAppearance.BorderSize = 0;
            this.btnRoomEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomEdit.ForeColor = System.Drawing.Color.Black;
            this.btnRoomEdit.Location = new System.Drawing.Point(0, 32);
            this.btnRoomEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRoomEdit.Name = "btnRoomEdit";
            this.btnRoomEdit.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnRoomEdit.Size = new System.Drawing.Size(214, 32);
            this.btnRoomEdit.TabIndex = 2;
            this.btnRoomEdit.Text = "Edit";
            this.btnRoomEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomEdit.UseVisualStyleBackColor = false;
            this.btnRoomEdit.Click += new System.EventHandler(this.btnRoomEdit_Click);
            // 
            // btnRoomView
            // 
            this.btnRoomView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoomView.FlatAppearance.BorderSize = 0;
            this.btnRoomView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomView.ForeColor = System.Drawing.Color.Black;
            this.btnRoomView.Location = new System.Drawing.Point(0, 0);
            this.btnRoomView.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoomView.Name = "btnRoomView";
            this.btnRoomView.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnRoomView.Size = new System.Drawing.Size(214, 32);
            this.btnRoomView.TabIndex = 0;
            this.btnRoomView.Text = "View";
            this.btnRoomView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomView.UseVisualStyleBackColor = false;
            this.btnRoomView.Click += new System.EventHandler(this.btnRoomView_Click);
            // 
            // btnRooms
            // 
            this.btnRooms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRooms.FlatAppearance.BorderSize = 0;
            this.btnRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRooms.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRooms.ForeColor = System.Drawing.Color.Black;
            this.btnRooms.Location = new System.Drawing.Point(0, 550);
            this.btnRooms.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnRooms.Size = new System.Drawing.Size(214, 49);
            this.btnRooms.TabIndex = 6;
            this.btnRooms.Text = "Rooms";
            this.btnRooms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRooms.UseVisualStyleBackColor = false;
            this.btnRooms.Click += new System.EventHandler(this.btnRooms_Click);
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.BackColor = System.Drawing.Color.Transparent;
            this.pnlTransactions.Controls.Add(this.btnTransactionEdit);
            this.pnlTransactions.Controls.Add(this.btnTransactionCreate);
            this.pnlTransactions.Controls.Add(this.btnTransactionsView);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTransactions.Location = new System.Drawing.Point(0, 455);
            this.pnlTransactions.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(214, 95);
            this.pnlTransactions.TabIndex = 13;
            // 
            // btnTransactionEdit
            // 
            this.btnTransactionEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionEdit.FlatAppearance.BorderSize = 0;
            this.btnTransactionEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionEdit.ForeColor = System.Drawing.Color.Black;
            this.btnTransactionEdit.Location = new System.Drawing.Point(0, 64);
            this.btnTransactionEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTransactionEdit.Name = "btnTransactionEdit";
            this.btnTransactionEdit.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnTransactionEdit.Size = new System.Drawing.Size(214, 32);
            this.btnTransactionEdit.TabIndex = 2;
            this.btnTransactionEdit.Text = "Edit";
            this.btnTransactionEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionEdit.UseVisualStyleBackColor = false;
            this.btnTransactionEdit.Click += new System.EventHandler(this.btnTransactionEdit_Click);
            // 
            // btnTransactionCreate
            // 
            this.btnTransactionCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionCreate.FlatAppearance.BorderSize = 0;
            this.btnTransactionCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionCreate.ForeColor = System.Drawing.Color.Black;
            this.btnTransactionCreate.Location = new System.Drawing.Point(0, 32);
            this.btnTransactionCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTransactionCreate.Name = "btnTransactionCreate";
            this.btnTransactionCreate.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnTransactionCreate.Size = new System.Drawing.Size(214, 32);
            this.btnTransactionCreate.TabIndex = 1;
            this.btnTransactionCreate.Text = "Create";
            this.btnTransactionCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionCreate.UseVisualStyleBackColor = false;
            this.btnTransactionCreate.Click += new System.EventHandler(this.btnTransactionCreate_Click);
            // 
            // btnTransactionsView
            // 
            this.btnTransactionsView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactionsView.FlatAppearance.BorderSize = 0;
            this.btnTransactionsView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionsView.ForeColor = System.Drawing.Color.Black;
            this.btnTransactionsView.Location = new System.Drawing.Point(0, 0);
            this.btnTransactionsView.Margin = new System.Windows.Forms.Padding(0);
            this.btnTransactionsView.Name = "btnTransactionsView";
            this.btnTransactionsView.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnTransactionsView.Size = new System.Drawing.Size(214, 32);
            this.btnTransactionsView.TabIndex = 0;
            this.btnTransactionsView.Text = "View";
            this.btnTransactionsView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionsView.UseVisualStyleBackColor = false;
            this.btnTransactionsView.Click += new System.EventHandler(this.btnTransactionsView_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactions.FlatAppearance.BorderSize = 0;
            this.btnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.Black;
            this.btnTransactions.Location = new System.Drawing.Point(0, 406);
            this.btnTransactions.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnTransactions.Size = new System.Drawing.Size(214, 49);
            this.btnTransactions.TabIndex = 12;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactions.UseVisualStyleBackColor = false;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // pnlChargeableItems
            // 
            this.pnlChargeableItems.BackColor = System.Drawing.Color.Transparent;
            this.pnlChargeableItems.Controls.Add(this.btnChargeableItemEdit);
            this.pnlChargeableItems.Controls.Add(this.btnChargeableItemCreate);
            this.pnlChargeableItems.Controls.Add(this.btnChargeableItemView);
            this.pnlChargeableItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChargeableItems.Location = new System.Drawing.Point(0, 311);
            this.pnlChargeableItems.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlChargeableItems.Name = "pnlChargeableItems";
            this.pnlChargeableItems.Size = new System.Drawing.Size(214, 95);
            this.pnlChargeableItems.TabIndex = 5;
            // 
            // btnChargeableItemEdit
            // 
            this.btnChargeableItemEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChargeableItemEdit.FlatAppearance.BorderSize = 0;
            this.btnChargeableItemEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChargeableItemEdit.ForeColor = System.Drawing.Color.Black;
            this.btnChargeableItemEdit.Location = new System.Drawing.Point(0, 64);
            this.btnChargeableItemEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnChargeableItemEdit.Name = "btnChargeableItemEdit";
            this.btnChargeableItemEdit.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnChargeableItemEdit.Size = new System.Drawing.Size(214, 32);
            this.btnChargeableItemEdit.TabIndex = 2;
            this.btnChargeableItemEdit.Text = "Edit";
            this.btnChargeableItemEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChargeableItemEdit.UseVisualStyleBackColor = false;
            this.btnChargeableItemEdit.Click += new System.EventHandler(this.btnChargeableItemEdit_Click);
            // 
            // btnChargeableItemCreate
            // 
            this.btnChargeableItemCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChargeableItemCreate.FlatAppearance.BorderSize = 0;
            this.btnChargeableItemCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChargeableItemCreate.ForeColor = System.Drawing.Color.Black;
            this.btnChargeableItemCreate.Location = new System.Drawing.Point(0, 32);
            this.btnChargeableItemCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnChargeableItemCreate.Name = "btnChargeableItemCreate";
            this.btnChargeableItemCreate.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnChargeableItemCreate.Size = new System.Drawing.Size(214, 32);
            this.btnChargeableItemCreate.TabIndex = 1;
            this.btnChargeableItemCreate.Text = "Create";
            this.btnChargeableItemCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChargeableItemCreate.UseVisualStyleBackColor = false;
            this.btnChargeableItemCreate.Click += new System.EventHandler(this.btnChargeableItemCreate_Click);
            // 
            // btnChargeableItemView
            // 
            this.btnChargeableItemView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChargeableItemView.FlatAppearance.BorderSize = 0;
            this.btnChargeableItemView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChargeableItemView.ForeColor = System.Drawing.Color.Black;
            this.btnChargeableItemView.Location = new System.Drawing.Point(0, 0);
            this.btnChargeableItemView.Margin = new System.Windows.Forms.Padding(0);
            this.btnChargeableItemView.Name = "btnChargeableItemView";
            this.btnChargeableItemView.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnChargeableItemView.Size = new System.Drawing.Size(214, 32);
            this.btnChargeableItemView.TabIndex = 0;
            this.btnChargeableItemView.Text = "View";
            this.btnChargeableItemView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChargeableItemView.UseVisualStyleBackColor = false;
            this.btnChargeableItemView.Click += new System.EventHandler(this.btnChargeableItemView_Click);
            // 
            // btnChargeableItems
            // 
            this.btnChargeableItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChargeableItems.FlatAppearance.BorderSize = 0;
            this.btnChargeableItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChargeableItems.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChargeableItems.ForeColor = System.Drawing.Color.Black;
            this.btnChargeableItems.Location = new System.Drawing.Point(0, 262);
            this.btnChargeableItems.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnChargeableItems.Name = "btnChargeableItems";
            this.btnChargeableItems.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnChargeableItems.Size = new System.Drawing.Size(214, 49);
            this.btnChargeableItems.TabIndex = 4;
            this.btnChargeableItems.Text = "Chargeable Items";
            this.btnChargeableItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChargeableItems.UseVisualStyleBackColor = false;
            this.btnChargeableItems.Click += new System.EventHandler(this.btnChargeableItems_Click);
            // 
            // pnlBills
            // 
            this.pnlBills.BackColor = System.Drawing.Color.Transparent;
            this.pnlBills.Controls.Add(this.btnBillEdit);
            this.pnlBills.Controls.Add(this.btnBillView);
            this.pnlBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBills.Location = new System.Drawing.Point(0, 196);
            this.pnlBills.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlBills.Name = "pnlBills";
            this.pnlBills.Size = new System.Drawing.Size(214, 66);
            this.pnlBills.TabIndex = 3;
            // 
            // btnBillEdit
            // 
            this.btnBillEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBillEdit.FlatAppearance.BorderSize = 0;
            this.btnBillEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillEdit.ForeColor = System.Drawing.Color.Black;
            this.btnBillEdit.Location = new System.Drawing.Point(0, 32);
            this.btnBillEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBillEdit.Name = "btnBillEdit";
            this.btnBillEdit.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnBillEdit.Size = new System.Drawing.Size(214, 32);
            this.btnBillEdit.TabIndex = 2;
            this.btnBillEdit.Text = "Edit";
            this.btnBillEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillEdit.UseVisualStyleBackColor = false;
            this.btnBillEdit.Click += new System.EventHandler(this.btnBillEdit_Click);
            // 
            // btnBillView
            // 
            this.btnBillView.BackColor = System.Drawing.Color.Transparent;
            this.btnBillView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBillView.FlatAppearance.BorderSize = 0;
            this.btnBillView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillView.ForeColor = System.Drawing.Color.Black;
            this.btnBillView.Location = new System.Drawing.Point(0, 0);
            this.btnBillView.Margin = new System.Windows.Forms.Padding(0);
            this.btnBillView.Name = "btnBillView";
            this.btnBillView.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnBillView.Size = new System.Drawing.Size(214, 32);
            this.btnBillView.TabIndex = 0;
            this.btnBillView.Text = "View";
            this.btnBillView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillView.UseVisualStyleBackColor = false;
            this.btnBillView.Click += new System.EventHandler(this.btnBillView_Click);
            // 
            // btnBills
            // 
            this.btnBills.BackColor = System.Drawing.Color.Transparent;
            this.btnBills.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBills.FlatAppearance.BorderSize = 0;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.ForeColor = System.Drawing.Color.Black;
            this.btnBills.Location = new System.Drawing.Point(0, 147);
            this.btnBills.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBills.Name = "btnBills";
            this.btnBills.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnBills.Size = new System.Drawing.Size(214, 49);
            this.btnBills.TabIndex = 2;
            this.btnBills.Text = "Bills";
            this.btnBills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // pnlReservations
            // 
            this.pnlReservations.BackColor = System.Drawing.Color.Transparent;
            this.pnlReservations.Controls.Add(this.btnReservationEdit);
            this.pnlReservations.Controls.Add(this.btnReservationCreate);
            this.pnlReservations.Controls.Add(this.btnReservationView);
            this.pnlReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReservations.Location = new System.Drawing.Point(0, 49);
            this.pnlReservations.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlReservations.Name = "pnlReservations";
            this.pnlReservations.Size = new System.Drawing.Size(214, 98);
            this.pnlReservations.TabIndex = 1;
            // 
            // btnReservationEdit
            // 
            this.btnReservationEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnReservationEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservationEdit.FlatAppearance.BorderSize = 0;
            this.btnReservationEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationEdit.ForeColor = System.Drawing.Color.Black;
            this.btnReservationEdit.Location = new System.Drawing.Point(0, 64);
            this.btnReservationEdit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReservationEdit.Name = "btnReservationEdit";
            this.btnReservationEdit.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnReservationEdit.Size = new System.Drawing.Size(214, 32);
            this.btnReservationEdit.TabIndex = 2;
            this.btnReservationEdit.Text = "Edit";
            this.btnReservationEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationEdit.UseVisualStyleBackColor = false;
            this.btnReservationEdit.Click += new System.EventHandler(this.btnReservationEdit_Click);
            // 
            // btnReservationCreate
            // 
            this.btnReservationCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnReservationCreate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservationCreate.FlatAppearance.BorderSize = 0;
            this.btnReservationCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationCreate.ForeColor = System.Drawing.Color.Black;
            this.btnReservationCreate.Location = new System.Drawing.Point(0, 32);
            this.btnReservationCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReservationCreate.Name = "btnReservationCreate";
            this.btnReservationCreate.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnReservationCreate.Size = new System.Drawing.Size(214, 32);
            this.btnReservationCreate.TabIndex = 1;
            this.btnReservationCreate.Text = "Create";
            this.btnReservationCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationCreate.UseVisualStyleBackColor = false;
            this.btnReservationCreate.Click += new System.EventHandler(this.btnReservationCreate_Click);
            // 
            // btnReservationView
            // 
            this.btnReservationView.BackColor = System.Drawing.Color.Transparent;
            this.btnReservationView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservationView.FlatAppearance.BorderSize = 0;
            this.btnReservationView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationView.ForeColor = System.Drawing.Color.Black;
            this.btnReservationView.Location = new System.Drawing.Point(0, 0);
            this.btnReservationView.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservationView.Name = "btnReservationView";
            this.btnReservationView.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.btnReservationView.Size = new System.Drawing.Size(214, 32);
            this.btnReservationView.TabIndex = 0;
            this.btnReservationView.Text = "View";
            this.btnReservationView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservationView.UseVisualStyleBackColor = false;
            this.btnReservationView.Click += new System.EventHandler(this.btnReservationView_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.BackColor = System.Drawing.Color.Transparent;
            this.btnReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservations.FlatAppearance.BorderSize = 0;
            this.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservations.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservations.ForeColor = System.Drawing.Color.Black;
            this.btnReservations.Location = new System.Drawing.Point(0, 0);
            this.btnReservations.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnReservations.Size = new System.Drawing.Size(214, 49);
            this.btnReservations.TabIndex = 0;
            this.btnReservations.Text = "Reservations";
            this.btnReservations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservations.UseVisualStyleBackColor = false;
            this.btnReservations.Click += new System.EventHandler(this.btnReservations_Click);
            // 
            // pnlActiveUser
            // 
            this.pnlActiveUser.BackColor = System.Drawing.Color.Transparent;
            this.pnlActiveUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlActiveUser.Controls.Add(this.pictureBox1);
            this.pnlActiveUser.Controls.Add(this.lblUserRole);
            this.pnlActiveUser.Controls.Add(this.lblUserName);
            this.pnlActiveUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActiveUser.Location = new System.Drawing.Point(0, 0);
            this.pnlActiveUser.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlActiveUser.Name = "pnlActiveUser";
            this.pnlActiveUser.Size = new System.Drawing.Size(231, 111);
            this.pnlActiveUser.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::KingWilliamApp.Properties.Resources.rsz_default_profile;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(21, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserRole
            // 
            this.lblUserRole.AutoSize = true;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.Color.Gray;
            this.lblUserRole.Location = new System.Drawing.Point(72, 61);
            this.lblUserRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(83, 13);
            this.lblUserRole.TabIndex = 2;
            this.lblUserRole.Text = "Administrator";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Black;
            this.lblUserName.Location = new System.Drawing.Point(70, 38);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 19);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Basil Cleese";
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.White;
            this.pnlChildForm.Controls.Add(this.lblKingWilliam);
            this.pnlChildForm.Controls.Add(this.pbxKingWilliam);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(233, 0);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(565, 553);
            this.pnlChildForm.TabIndex = 1;
            // 
            // lblKingWilliam
            // 
            this.lblKingWilliam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKingWilliam.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKingWilliam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.lblKingWilliam.Location = new System.Drawing.Point(210, 207);
            this.lblKingWilliam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKingWilliam.Name = "lblKingWilliam";
            this.lblKingWilliam.Size = new System.Drawing.Size(299, 116);
            this.lblKingWilliam.TabIndex = 1;
            this.lblKingWilliam.Text = "The King William Hotel";
            // 
            // pbxKingWilliam
            // 
            this.pbxKingWilliam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxKingWilliam.BackColor = System.Drawing.Color.White;
            this.pbxKingWilliam.BackgroundImage = global::KingWilliamApp.Properties.Resources.kw_logo;
            this.pbxKingWilliam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxKingWilliam.Location = new System.Drawing.Point(91, 207);
            this.pbxKingWilliam.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pbxKingWilliam.Name = "pbxKingWilliam";
            this.pbxKingWilliam.Size = new System.Drawing.Size(105, 114);
            this.pbxKingWilliam.TabIndex = 0;
            this.pbxKingWilliam.TabStop = false;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(798, 553);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MinimumSize = new System.Drawing.Size(813, 591);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The King William Hotel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenuButtons.ResumeLayout(false);
            this.pnlUsers.ResumeLayout(false);
            this.pnlEmploymentPositions.ResumeLayout(false);
            this.pnlStaff.ResumeLayout(false);
            this.pnlClients.ResumeLayout(false);
            this.pnlRoomTypes.ResumeLayout(false);
            this.pnlRooms.ResumeLayout(false);
            this.pnlTransactions.ResumeLayout(false);
            this.pnlChargeableItems.ResumeLayout(false);
            this.pnlBills.ResumeLayout(false);
            this.pnlReservations.ResumeLayout(false);
            this.pnlActiveUser.ResumeLayout(false);
            this.pnlActiveUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxKingWilliam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlMenuButtons;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.Panel pnlActiveUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserRole;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Label lblKingWilliam;
        private System.Windows.Forms.PictureBox pbxKingWilliam;
        private System.Windows.Forms.Panel pnlReservations;
        private System.Windows.Forms.Button btnReservationView;
        private System.Windows.Forms.Button btnReservationEdit;
        private System.Windows.Forms.Button btnReservationCreate;
        private System.Windows.Forms.Panel pnlBills;
        private System.Windows.Forms.Button btnBillEdit;
        private System.Windows.Forms.Button btnBillView;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnChargeableItems;
        private System.Windows.Forms.Panel pnlClients;
        private System.Windows.Forms.Button btnCustomerEdit;
        private System.Windows.Forms.Button btnCustomerCreate;
        private System.Windows.Forms.Button btnCustomerView;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Panel pnlRooms;
        private System.Windows.Forms.Button btnRoomEdit;
        private System.Windows.Forms.Button btnRoomView;
        private System.Windows.Forms.Button btnRooms;
        private System.Windows.Forms.Panel pnlChargeableItems;
        private System.Windows.Forms.Button btnChargeableItemEdit;
        private System.Windows.Forms.Button btnChargeableItemCreate;
        private System.Windows.Forms.Button btnChargeableItemView;
        private System.Windows.Forms.Panel pnlStaff;
        private System.Windows.Forms.Button btnStaffEdit;
        private System.Windows.Forms.Button btnStaffCreate;
        private System.Windows.Forms.Button btnStaffView;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Panel pnlEmploymentPositions;
        private System.Windows.Forms.Button btnEmploymentPositionEdit;
        private System.Windows.Forms.Button btnEmploymentPositionCreate;
        private System.Windows.Forms.Button btnEmploymentPositionView;
        private System.Windows.Forms.Button btnEmploymentPositions;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserCreate;
        private System.Windows.Forms.Button btnUserView;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel pnlRoomTypes;
        private System.Windows.Forms.Button btnRoomTypeEdit;
        private System.Windows.Forms.Button btnRoomTypeCreate;
        private System.Windows.Forms.Button btnRoomTypeView;
        private System.Windows.Forms.Button btnRoomTypes;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Button btnTransactionEdit;
        private System.Windows.Forms.Button btnTransactionCreate;
        private System.Windows.Forms.Button btnTransactionsView;
        private System.Windows.Forms.Button btnTransactions;
    }
}

