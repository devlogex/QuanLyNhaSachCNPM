namespace QuanLyNhaSach
{
    partial class FSearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSearchCustomer));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHistoryBill = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvManageCustomer = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNameCustomer = new System.Windows.Forms.TextBox();
            this.ckbIDCustomer = new System.Windows.Forms.CheckBox();
            this.ckbPhoneNumber = new System.Windows.Forms.CheckBox();
            this.ckbNameCustomer = new System.Windows.Forms.CheckBox();
            this.ckbEmail = new System.Windows.Forms.CheckBox();
            this.ckbMoneyOwe = new System.Windows.Forms.CheckBox();
            this.nmOweFrom = new System.Windows.Forms.NumericUpDown();
            this.nmOweTo = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbIDCustomer = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmOweFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOweTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHistoryBill);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(0, 479);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 73);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // btnHistoryBill
            // 
            this.btnHistoryBill.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoryBill.Location = new System.Drawing.Point(155, 19);
            this.btnHistoryBill.Name = "btnHistoryBill";
            this.btnHistoryBill.Size = new System.Drawing.Size(162, 35);
            this.btnHistoryBill.TabIndex = 13;
            this.btnHistoryBill.Text = "Lịch sử mua hàng";
            this.btnHistoryBill.UseVisualStyleBackColor = true;
            this.btnHistoryBill.Click += new System.EventHandler(this.btnHistoryBill_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(834, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 35);
            this.button4.TabIndex = 14;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(27, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 35);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvManageCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 189);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // dtgvManageCustomer
            // 
            this.dtgvManageCustomer.AllowUserToAddRows = false;
            this.dtgvManageCustomer.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvManageCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.id,
            this.name,
            this.address,
            this.phonenumber,
            this.email,
            this.owe});
            this.dtgvManageCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvManageCustomer.Location = new System.Drawing.Point(3, 22);
            this.dtgvManageCustomer.Name = "dtgvManageCustomer";
            this.dtgvManageCustomer.ReadOnly = true;
            this.dtgvManageCustomer.RowHeadersVisible = false;
            this.dtgvManageCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvManageCustomer.Size = new System.Drawing.Size(910, 164);
            this.dtgvManageCustomer.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã khách hàng";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên khách hàng";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Địa chỉ";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phonenumber
            // 
            this.phonenumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phonenumber.DataPropertyName = "phonenumber";
            this.phonenumber.HeaderText = "Số điện thoại";
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // owe
            // 
            this.owe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.owe.DataPropertyName = "owe";
            this.owe.HeaderText = "Số tiền nợ";
            this.owe.Name = "owe";
            this.owe.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(255, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(449, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "TRA CỨU KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 72);
            this.panel1.TabIndex = 11;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(201, 120);
            this.txbPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(212, 26);
            this.txbPhoneNumber.TabIndex = 5;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(644, 35);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(212, 26);
            this.txbEmail.TabIndex = 7;
            // 
            // txbNameCustomer
            // 
            this.txbNameCustomer.Location = new System.Drawing.Point(201, 78);
            this.txbNameCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.txbNameCustomer.Name = "txbNameCustomer";
            this.txbNameCustomer.Size = new System.Drawing.Size(212, 26);
            this.txbNameCustomer.TabIndex = 3;
            // 
            // ckbIDCustomer
            // 
            this.ckbIDCustomer.AutoSize = true;
            this.ckbIDCustomer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIDCustomer.Location = new System.Drawing.Point(31, 35);
            this.ckbIDCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.ckbIDCustomer.Name = "ckbIDCustomer";
            this.ckbIDCustomer.Size = new System.Drawing.Size(132, 23);
            this.ckbIDCustomer.TabIndex = 0;
            this.ckbIDCustomer.Text = "Mã khách hàng";
            this.ckbIDCustomer.UseVisualStyleBackColor = true;
            this.ckbIDCustomer.CheckedChanged += new System.EventHandler(this.ckbIDCustomer_CheckedChanged);
            // 
            // ckbPhoneNumber
            // 
            this.ckbPhoneNumber.AutoSize = true;
            this.ckbPhoneNumber.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPhoneNumber.Location = new System.Drawing.Point(31, 123);
            this.ckbPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.ckbPhoneNumber.Name = "ckbPhoneNumber";
            this.ckbPhoneNumber.Size = new System.Drawing.Size(56, 23);
            this.ckbPhoneNumber.TabIndex = 4;
            this.ckbPhoneNumber.Text = "SĐT";
            this.ckbPhoneNumber.UseVisualStyleBackColor = true;
            this.ckbPhoneNumber.CheckedChanged += new System.EventHandler(this.ckbPhoneNumber_CheckedChanged);
            // 
            // ckbNameCustomer
            // 
            this.ckbNameCustomer.AutoSize = true;
            this.ckbNameCustomer.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNameCustomer.Location = new System.Drawing.Point(31, 78);
            this.ckbNameCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.ckbNameCustomer.Name = "ckbNameCustomer";
            this.ckbNameCustomer.Size = new System.Drawing.Size(74, 23);
            this.ckbNameCustomer.TabIndex = 2;
            this.ckbNameCustomer.Text = "Họ tên";
            this.ckbNameCustomer.UseVisualStyleBackColor = true;
            this.ckbNameCustomer.CheckedChanged += new System.EventHandler(this.ckbNameCustomer_CheckedChanged);
            // 
            // ckbEmail
            // 
            this.ckbEmail.AutoSize = true;
            this.ckbEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEmail.Location = new System.Drawing.Point(465, 35);
            this.ckbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.ckbEmail.Name = "ckbEmail";
            this.ckbEmail.Size = new System.Drawing.Size(66, 23);
            this.ckbEmail.TabIndex = 6;
            this.ckbEmail.Text = "Email";
            this.ckbEmail.UseVisualStyleBackColor = true;
            this.ckbEmail.CheckedChanged += new System.EventHandler(this.ckbEmail_CheckedChanged);
            // 
            // ckbMoneyOwe
            // 
            this.ckbMoneyOwe.AutoSize = true;
            this.ckbMoneyOwe.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMoneyOwe.Location = new System.Drawing.Point(465, 75);
            this.ckbMoneyOwe.Margin = new System.Windows.Forms.Padding(2);
            this.ckbMoneyOwe.Name = "ckbMoneyOwe";
            this.ckbMoneyOwe.Size = new System.Drawing.Size(98, 23);
            this.ckbMoneyOwe.TabIndex = 8;
            this.ckbMoneyOwe.Text = "Số tiền nợ";
            this.ckbMoneyOwe.UseVisualStyleBackColor = true;
            this.ckbMoneyOwe.CheckedChanged += new System.EventHandler(this.ckbMoneyOwe_CheckedChanged);
            // 
            // nmOweFrom
            // 
            this.nmOweFrom.Enabled = false;
            this.nmOweFrom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.nmOweFrom.ForeColor = System.Drawing.Color.Black;
            this.nmOweFrom.Location = new System.Drawing.Point(644, 72);
            this.nmOweFrom.Name = "nmOweFrom";
            this.nmOweFrom.Size = new System.Drawing.Size(84, 26);
            this.nmOweFrom.TabIndex = 9;
            // 
            // nmOweTo
            // 
            this.nmOweTo.Enabled = false;
            this.nmOweTo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.nmOweTo.ForeColor = System.Drawing.Color.Black;
            this.nmOweTo.Location = new System.Drawing.Point(772, 72);
            this.nmOweTo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmOweTo.Name = "nmOweTo";
            this.nmOweTo.Size = new System.Drawing.Size(84, 26);
            this.nmOweTo.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(734, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(750, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 35);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbIDCustomer);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.nmOweTo);
            this.groupBox3.Controls.Add(this.nmOweFrom);
            this.groupBox3.Controls.Add(this.ckbMoneyOwe);
            this.groupBox3.Controls.Add(this.ckbEmail);
            this.groupBox3.Controls.Add(this.ckbNameCustomer);
            this.groupBox3.Controls.Add(this.ckbPhoneNumber);
            this.groupBox3.Controls.Add(this.ckbIDCustomer);
            this.groupBox3.Controls.Add(this.txbNameCustomer);
            this.groupBox3.Controls.Add(this.txbEmail);
            this.groupBox3.Controls.Add(this.txbPhoneNumber);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 89);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(910, 189);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các tiêu chuẩn tra cứu";
            // 
            // cbIDCustomer
            // 
            this.cbIDCustomer.FormattingEnabled = true;
            this.cbIDCustomer.Location = new System.Drawing.Point(201, 36);
            this.cbIDCustomer.Name = "cbIDCustomer";
            this.cbIDCustomer.Size = new System.Drawing.Size(212, 27);
            this.cbIDCustomer.TabIndex = 1;
            // 
            // FSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 566);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FSearchCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu khách hàng";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmOweFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmOweTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHistoryBill;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvManageCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn owe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbNameCustomer;
        private System.Windows.Forms.CheckBox ckbIDCustomer;
        private System.Windows.Forms.CheckBox ckbPhoneNumber;
        private System.Windows.Forms.CheckBox ckbNameCustomer;
        private System.Windows.Forms.CheckBox ckbEmail;
        private System.Windows.Forms.CheckBox ckbMoneyOwe;
        private System.Windows.Forms.NumericUpDown nmOweFrom;
        private System.Windows.Forms.NumericUpDown nmOweTo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbIDCustomer;
    }
}