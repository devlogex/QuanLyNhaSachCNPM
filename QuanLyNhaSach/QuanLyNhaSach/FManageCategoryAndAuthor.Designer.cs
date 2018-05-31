namespace QuanLyNhaSach
{
    partial class FManageCategoryAndAuthor
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
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemoveAuthor = new System.Windows.Forms.Button();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvManageCategory = new System.Windows.Forms.DataGridView();
            this.STTCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvManageAuthor = new System.Windows.Forms.DataGridView();
            this.STTAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageCategory)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 72);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(185, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(571, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "QUẢN LÝ THỂ LOẠI VÀ TÁC GIẢ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddAuthor);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnRemoveAuthor);
            this.groupBox1.Controls.Add(this.btnUpdateAuthor);
            this.groupBox1.Controls.Add(this.btnRemoveCategory);
            this.groupBox1.Controls.Add(this.btnUpdateCategory);
            this.groupBox1.Controls.Add(this.btnAddCategory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 498);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(964, 54);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.Location = new System.Drawing.Point(524, 14);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(89, 34);
            this.btnAddAuthor.TabIndex = 3;
            this.btnAddAuthor.Text = "Thêm";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(863, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemoveAuthor
            // 
            this.btnRemoveAuthor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAuthor.Location = new System.Drawing.Point(717, 14);
            this.btnRemoveAuthor.Name = "btnRemoveAuthor";
            this.btnRemoveAuthor.Size = new System.Drawing.Size(89, 34);
            this.btnRemoveAuthor.TabIndex = 5;
            this.btnRemoveAuthor.Text = "Xóa";
            this.btnRemoveAuthor.UseVisualStyleBackColor = true;
            this.btnRemoveAuthor.Click += new System.EventHandler(this.btnRemoveAuthor_Click);
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAuthor.Location = new System.Drawing.Point(622, 14);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(89, 34);
            this.btnUpdateAuthor.TabIndex = 4;
            this.btnUpdateAuthor.Text = "Cập nhật";
            this.btnUpdateAuthor.UseVisualStyleBackColor = true;
            this.btnUpdateAuthor.Click += new System.EventHandler(this.btnUpdateAuthor_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveCategory.Location = new System.Drawing.Point(220, 14);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(91, 34);
            this.btnRemoveCategory.TabIndex = 2;
            this.btnRemoveCategory.Text = "Xóa";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCategory.Location = new System.Drawing.Point(125, 14);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Size = new System.Drawing.Size(89, 34);
            this.btnUpdateCategory.TabIndex = 1;
            this.btnUpdateCategory.Text = "Cập nhật";
            this.btnUpdateCategory.UseVisualStyleBackColor = true;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(28, 14);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(89, 34);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvManageCategory);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 426);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thể loại";
            // 
            // dtgvManageCategory
            // 
            this.dtgvManageCategory.AllowUserToAddRows = false;
            this.dtgvManageCategory.AllowUserToDeleteRows = false;
            this.dtgvManageCategory.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvManageCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTCategory,
            this.idCategory,
            this.nameCategory});
            this.dtgvManageCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvManageCategory.Location = new System.Drawing.Point(3, 22);
            this.dtgvManageCategory.Name = "dtgvManageCategory";
            this.dtgvManageCategory.ReadOnly = true;
            this.dtgvManageCategory.RowHeadersVisible = false;
            this.dtgvManageCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvManageCategory.Size = new System.Drawing.Size(486, 401);
            this.dtgvManageCategory.TabIndex = 2;
            // 
            // STTCategory
            // 
            this.STTCategory.HeaderText = "STT";
            this.STTCategory.Name = "STTCategory";
            this.STTCategory.ReadOnly = true;
            // 
            // idCategory
            // 
            this.idCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCategory.DataPropertyName = "id";
            this.idCategory.HeaderText = "Mã thể loại";
            this.idCategory.Name = "idCategory";
            this.idCategory.ReadOnly = true;
            // 
            // nameCategory
            // 
            this.nameCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCategory.DataPropertyName = "name";
            this.nameCategory.HeaderText = "Tên thể loại";
            this.nameCategory.Name = "nameCategory";
            this.nameCategory.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvManageAuthor);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(498, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 426);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác giả";
            // 
            // dtgvManageAuthor
            // 
            this.dtgvManageAuthor.AllowUserToAddRows = false;
            this.dtgvManageAuthor.AllowUserToDeleteRows = false;
            this.dtgvManageAuthor.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvManageAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STTAuthor,
            this.idAuthor,
            this.nameAuthor});
            this.dtgvManageAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvManageAuthor.Location = new System.Drawing.Point(3, 22);
            this.dtgvManageAuthor.Name = "dtgvManageAuthor";
            this.dtgvManageAuthor.ReadOnly = true;
            this.dtgvManageAuthor.RowHeadersVisible = false;
            this.dtgvManageAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvManageAuthor.Size = new System.Drawing.Size(460, 401);
            this.dtgvManageAuthor.TabIndex = 2;
            // 
            // STTAuthor
            // 
            this.STTAuthor.HeaderText = "STT";
            this.STTAuthor.Name = "STTAuthor";
            this.STTAuthor.ReadOnly = true;
            // 
            // idAuthor
            // 
            this.idAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idAuthor.DataPropertyName = "id";
            this.idAuthor.HeaderText = "Mã tác giả";
            this.idAuthor.Name = "idAuthor";
            this.idAuthor.ReadOnly = true;
            // 
            // nameAuthor
            // 
            this.nameAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameAuthor.DataPropertyName = "name";
            this.nameAuthor.HeaderText = "Tên tác giả";
            this.nameAuthor.Name = "nameAuthor";
            this.nameAuthor.ReadOnly = true;
            // 
            // FManageCategoryAndAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(964, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FManageCategoryAndAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thể loại và tác giả";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageCategory)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveAuthor;
        private System.Windows.Forms.Button btnUpdateAuthor;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvManageCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvManageAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAuthor;
    }
}