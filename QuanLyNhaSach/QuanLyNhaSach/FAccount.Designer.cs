namespace QuanLyNhaSach
{
    partial class FAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 72);
            this.panel1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(193, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 306);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvAccount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 277);
            this.panel2.TabIndex = 0;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AllowUserToAddRows = false;
            this.dtgvAccount.AllowUserToDeleteRows = false;
            this.dtgvAccount.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.userName,
            this.passWord,
            this.displayName,
            this.type});
            this.dtgvAccount.Location = new System.Drawing.Point(20, 10);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.ReadOnly = true;
            this.dtgvAccount.RowHeadersVisible = false;
            this.dtgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAccount.Size = new System.Drawing.Size(754, 264);
            this.dtgvAccount.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnRemoveAccount);
            this.groupBox2.Controls.Add(this.btnUpdateAccount);
            this.groupBox2.Controls.Add(this.btnAddAccount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 66);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(703, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.Location = new System.Drawing.Point(214, 17);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(85, 37);
            this.btnRemoveAccount.TabIndex = 2;
            this.btnRemoveAccount.Text = "Xóa";
            this.btnRemoveAccount.UseVisualStyleBackColor = true;
            this.btnRemoveAccount.Click += new System.EventHandler(this.btnRemoveAccount_Click);
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(110, 17);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(85, 37);
            this.btnUpdateAccount.TabIndex = 1;
            this.btnUpdateAccount.Text = "Cập nhật";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            this.btnUpdateAccount.Click += new System.EventHandler(this.btnUpdateAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(12, 17);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(79, 37);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // userName
            // 
            this.userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "Tên đăng nhập";
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // passWord
            // 
            this.passWord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passWord.DataPropertyName = "passWord";
            this.passWord.HeaderText = "Mật khẩu";
            this.passWord.Name = "passWord";
            this.passWord.ReadOnly = true;
            // 
            // displayName
            // 
            this.displayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.displayName.DataPropertyName = "displayName";
            this.displayName.HeaderText = "Tên hiển thị";
            this.displayName.Name = "displayName";
            this.displayName.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Loại tài khoản";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // FAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}