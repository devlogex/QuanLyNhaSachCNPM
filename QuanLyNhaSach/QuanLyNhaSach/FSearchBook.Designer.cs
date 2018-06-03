namespace QuanLyNhaSach
{
    partial class FSearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSearchBook));
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvManageBookTitle = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbIDBookTitle = new System.Windows.Forms.CheckBox();
            this.ckbAuthor = new System.Windows.Forms.CheckBox();
            this.ckbCount = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ckbCategory = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbNameBookTitle = new System.Windows.Forms.TextBox();
            this.ckbNameBookTitle = new System.Windows.Forms.CheckBox();
            this.cbIDBookTitle = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nmCountTo = new System.Windows.Forms.NumericUpDown();
            this.nmCountFrom = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageBookTitle)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(282, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "TRA CỨU ĐẦU SÁCH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 72);
            this.panel1.TabIndex = 15;
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
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdateBookTitle_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(834, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 35);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(0, 479);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 73);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 189);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sách";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvManageBookTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 160);
            this.panel2.TabIndex = 0;
            // 
            // dtgvManageBookTitle
            // 
            this.dtgvManageBookTitle.AllowUserToAddRows = false;
            this.dtgvManageBookTitle.AllowUserToDeleteRows = false;
            this.dtgvManageBookTitle.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvManageBookTitle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvManageBookTitle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.id,
            this.name,
            this.category,
            this.author,
            this.countVersion,
            this.totalCount});
            this.dtgvManageBookTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvManageBookTitle.Location = new System.Drawing.Point(0, 0);
            this.dtgvManageBookTitle.Name = "dtgvManageBookTitle";
            this.dtgvManageBookTitle.ReadOnly = true;
            this.dtgvManageBookTitle.RowHeadersVisible = false;
            this.dtgvManageBookTitle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvManageBookTitle.Size = new System.Drawing.Size(910, 160);
            this.dtgvManageBookTitle.TabIndex = 5;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Mã đầu sách";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên đầu sách";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "category";
            this.category.HeaderText = "Thể loại sách";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "Tác giả";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // countVersion
            // 
            this.countVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countVersion.DataPropertyName = "countVersion";
            this.countVersion.HeaderText = "Số phiên bản";
            this.countVersion.Name = "countVersion";
            this.countVersion.ReadOnly = true;
            this.countVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // totalCount
            // 
            this.totalCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalCount.DataPropertyName = "totalCount";
            this.totalCount.HeaderText = "Tổng lượng tồn";
            this.totalCount.Name = "totalCount";
            this.totalCount.ReadOnly = true;
            this.totalCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ckbIDBookTitle
            // 
            this.ckbIDBookTitle.AutoSize = true;
            this.ckbIDBookTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIDBookTitle.Location = new System.Drawing.Point(34, 45);
            this.ckbIDBookTitle.Margin = new System.Windows.Forms.Padding(2);
            this.ckbIDBookTitle.Name = "ckbIDBookTitle";
            this.ckbIDBookTitle.Size = new System.Drawing.Size(114, 23);
            this.ckbIDBookTitle.TabIndex = 0;
            this.ckbIDBookTitle.Text = "Mã đầu sách";
            this.ckbIDBookTitle.UseVisualStyleBackColor = true;
            this.ckbIDBookTitle.CheckedChanged += new System.EventHandler(this.ckbIDBookTitle_CheckedChanged);
            // 
            // ckbAuthor
            // 
            this.ckbAuthor.AutoSize = true;
            this.ckbAuthor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAuthor.Location = new System.Drawing.Point(479, 45);
            this.ckbAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.ckbAuthor.Name = "ckbAuthor";
            this.ckbAuthor.Size = new System.Drawing.Size(75, 23);
            this.ckbAuthor.TabIndex = 6;
            this.ckbAuthor.Text = "Tác giả";
            this.ckbAuthor.UseVisualStyleBackColor = true;
            this.ckbAuthor.CheckedChanged += new System.EventHandler(this.ckbAuthor_CheckedChanged);
            // 
            // ckbCount
            // 
            this.ckbCount.AutoSize = true;
            this.ckbCount.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCount.Location = new System.Drawing.Point(479, 91);
            this.ckbCount.Margin = new System.Windows.Forms.Padding(2);
            this.ckbCount.Name = "ckbCount";
            this.ckbCount.Size = new System.Drawing.Size(90, 23);
            this.ckbCount.TabIndex = 8;
            this.ckbCount.Text = "Số lượng";
            this.ckbCount.UseVisualStyleBackColor = true;
            this.ckbCount.CheckedChanged += new System.EventHandler(this.ckbCount_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(764, 139);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 35);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Tra cứu";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ckbCategory
            // 
            this.ckbCategory.AutoSize = true;
            this.ckbCategory.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCategory.Location = new System.Drawing.Point(34, 128);
            this.ckbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.ckbCategory.Name = "ckbCategory";
            this.ckbCategory.Size = new System.Drawing.Size(83, 23);
            this.ckbCategory.TabIndex = 4;
            this.ckbCategory.Text = "Thể loại";
            this.ckbCategory.UseVisualStyleBackColor = true;
            this.ckbCategory.CheckedChanged += new System.EventHandler(this.ckbCategory_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbNameBookTitle);
            this.groupBox3.Controls.Add(this.ckbNameBookTitle);
            this.groupBox3.Controls.Add(this.cbIDBookTitle);
            this.groupBox3.Controls.Add(this.cbCategory);
            this.groupBox3.Controls.Add(this.cbAuthor);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.nmCountTo);
            this.groupBox3.Controls.Add(this.nmCountFrom);
            this.groupBox3.Controls.Add(this.ckbCategory);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.ckbCount);
            this.groupBox3.Controls.Add(this.ckbAuthor);
            this.groupBox3.Controls.Add(this.ckbIDBookTitle);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(27, 89);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(910, 188);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các tiêu chuẩn tra cứu";
            // 
            // txbNameBookTitle
            // 
            this.txbNameBookTitle.Location = new System.Drawing.Point(204, 86);
            this.txbNameBookTitle.Name = "txbNameBookTitle";
            this.txbNameBookTitle.Size = new System.Drawing.Size(212, 26);
            this.txbNameBookTitle.TabIndex = 3;
            // 
            // ckbNameBookTitle
            // 
            this.ckbNameBookTitle.AutoSize = true;
            this.ckbNameBookTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNameBookTitle.Location = new System.Drawing.Point(34, 89);
            this.ckbNameBookTitle.Name = "ckbNameBookTitle";
            this.ckbNameBookTitle.Size = new System.Drawing.Size(118, 23);
            this.ckbNameBookTitle.TabIndex = 2;
            this.ckbNameBookTitle.Text = "Tên đầu sách";
            this.ckbNameBookTitle.UseVisualStyleBackColor = true;
            this.ckbNameBookTitle.CheckedChanged += new System.EventHandler(this.ckbNameBookTitle_CheckedChanged);
            // 
            // cbIDBookTitle
            // 
            this.cbIDBookTitle.FormattingEnabled = true;
            this.cbIDBookTitle.Location = new System.Drawing.Point(204, 46);
            this.cbIDBookTitle.Name = "cbIDBookTitle";
            this.cbIDBookTitle.Size = new System.Drawing.Size(212, 27);
            this.cbIDBookTitle.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(204, 128);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(212, 27);
            this.cbCategory.TabIndex = 5;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(658, 41);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(212, 27);
            this.cbAuthor.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(748, 94);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // nmCountTo
            // 
            this.nmCountTo.Enabled = false;
            this.nmCountTo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.nmCountTo.ForeColor = System.Drawing.Color.Black;
            this.nmCountTo.Location = new System.Drawing.Point(786, 89);
            this.nmCountTo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmCountTo.Name = "nmCountTo";
            this.nmCountTo.Size = new System.Drawing.Size(84, 26);
            this.nmCountTo.TabIndex = 10;
            // 
            // nmCountFrom
            // 
            this.nmCountFrom.Enabled = false;
            this.nmCountFrom.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.nmCountFrom.ForeColor = System.Drawing.Color.Black;
            this.nmCountFrom.Location = new System.Drawing.Point(658, 89);
            this.nmCountFrom.Name = "nmCountFrom";
            this.nmCountFrom.Size = new System.Drawing.Size(84, 26);
            this.nmCountFrom.TabIndex = 9;
            // 
            // FSearchBook
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(964, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FSearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu sách";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvManageBookTitle)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCountFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbIDBookTitle;
        private System.Windows.Forms.CheckBox ckbAuthor;
        private System.Windows.Forms.CheckBox ckbCount;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox ckbCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nmCountTo;
        private System.Windows.Forms.NumericUpDown nmCountFrom;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.ComboBox cbIDBookTitle;
        private System.Windows.Forms.TextBox txbNameBookTitle;
        private System.Windows.Forms.CheckBox ckbNameBookTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvManageBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn countVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCount;
    }
}