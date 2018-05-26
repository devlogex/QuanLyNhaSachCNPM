namespace QuanLyNhaSach
{
    partial class FImportBook
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddBookTitle = new System.Windows.Forms.Button();
            this.btnHistoryImport = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintImport = new System.Windows.Forms.Button();
            this.btnAddImport = new System.Windows.Forms.Button();
            this.btnSaveImport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.txbIDImportBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpk = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvImportBook = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImportBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 72);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(263, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(442, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "LẬP PHIẾU NHẬP SÁCH";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 480);
            this.panel2.TabIndex = 5;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(20, 403);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(427, 13);
            this.lb.TabIndex = 8;
            this.lb.Text = "*Chỉ nhập các sách có số lượng tồn nhỏ hơn 300. Số lượng nhập lớn hơn hoặc bằng 1" +
    "50";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddBookTitle);
            this.groupBox4.Controls.Add(this.btnHistoryImport);
            this.groupBox4.Location = new System.Drawing.Point(616, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 112);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btnAddBookTitle
            // 
            this.btnAddBookTitle.Location = new System.Drawing.Point(6, 26);
            this.btnAddBookTitle.Name = "btnAddBookTitle";
            this.btnAddBookTitle.Size = new System.Drawing.Size(309, 36);
            this.btnAddBookTitle.TabIndex = 0;
            this.btnAddBookTitle.Text = "Thêm đầu sách mới";
            this.btnAddBookTitle.UseVisualStyleBackColor = true;
            // 
            // btnHistoryImport
            // 
            this.btnHistoryImport.Location = new System.Drawing.Point(6, 68);
            this.btnHistoryImport.Name = "btnHistoryImport";
            this.btnHistoryImport.Size = new System.Drawing.Size(309, 35);
            this.btnHistoryImport.TabIndex = 0;
            this.btnHistoryImport.Text = "Danh sách phiếu nhập";
            this.btnHistoryImport.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnPrintImport);
            this.groupBox3.Controls.Add(this.btnAddImport);
            this.groupBox3.Controls.Add(this.btnSaveImport);
            this.groupBox3.Location = new System.Drawing.Point(15, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(946, 49);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(824, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintImport
            // 
            this.btnPrintImport.Location = new System.Drawing.Point(256, 14);
            this.btnPrintImport.Name = "btnPrintImport";
            this.btnPrintImport.Size = new System.Drawing.Size(106, 35);
            this.btnPrintImport.TabIndex = 0;
            this.btnPrintImport.Text = "In";
            this.btnPrintImport.UseVisualStyleBackColor = true;
            // 
            // btnAddImport
            // 
            this.btnAddImport.Location = new System.Drawing.Point(6, 14);
            this.btnAddImport.Name = "btnAddImport";
            this.btnAddImport.Size = new System.Drawing.Size(106, 35);
            this.btnAddImport.TabIndex = 0;
            this.btnAddImport.Text = "Tạo mới";
            this.btnAddImport.UseVisualStyleBackColor = true;
            this.btnAddImport.Click += new System.EventHandler(this.btnAddImport_Click);
            // 
            // btnSaveImport
            // 
            this.btnSaveImport.Location = new System.Drawing.Point(130, 14);
            this.btnSaveImport.Name = "btnSaveImport";
            this.btnSaveImport.Size = new System.Drawing.Size(106, 35);
            this.btnSaveImport.TabIndex = 0;
            this.btnSaveImport.Text = "Lưu";
            this.btnSaveImport.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbTotalPrice);
            this.groupBox2.Controls.Add(this.txbIDImportBook);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpk);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 108);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu nhập";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(188, 78);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(191, 20);
            this.txbTotalPrice.TabIndex = 4;
            // 
            // txbIDImportBook
            // 
            this.txbIDImportBook.Location = new System.Drawing.Point(188, 22);
            this.txbIDImportBook.Name = "txbIDImportBook";
            this.txbIDImportBook.ReadOnly = true;
            this.txbIDImportBook.Size = new System.Drawing.Size(191, 20);
            this.txbIDImportBook.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số phiếu nhập";
            // 
            // dtpk
            // 
            this.dtpk.Location = new System.Drawing.Point(188, 48);
            this.dtpk.Name = "dtpk";
            this.dtpk.Size = new System.Drawing.Size(191, 20);
            this.dtpk.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvImportBook);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 277);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu nhập sách";
            // 
            // dtgvImportBook
            // 
            this.dtgvImportBook.AllowUserToOrderColumns = true;
            this.dtgvImportBook.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvImportBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvImportBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.id,
            this.name,
            this.category,
            this.author,
            this.publishing,
            this.count,
            this.priceIn,
            this.totalPrice});
            this.dtgvImportBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvImportBook.Location = new System.Drawing.Point(3, 21);
            this.dtgvImportBook.Name = "dtgvImportBook";
            this.dtgvImportBook.Size = new System.Drawing.Size(952, 253);
            this.dtgvImportBook.TabIndex = 0;
            this.dtgvImportBook.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvImportBook_CellEndEdit);
            this.dtgvImportBook.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtgvImportBook_EditingControlShowing);
            this.dtgvImportBook.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgvImportBook_RowsAdded);
            this.dtgvImportBook.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvImportBook_RowsRemoved);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.FillWeight = 28.88556F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.FillWeight = 283.2487F;
            this.id.HeaderText = "Mã đầu sách";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 77.1657F;
            this.name.HeaderText = "Tên đầu sách";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "category";
            this.category.FillWeight = 77.1657F;
            this.category.HeaderText = "Thể loại";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.author.DataPropertyName = "author";
            this.author.FillWeight = 77.1657F;
            this.author.HeaderText = "Tác giả";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // publishing
            // 
            this.publishing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.publishing.DataPropertyName = "publishing";
            this.publishing.FillWeight = 124.8715F;
            this.publishing.HeaderText = "Nhà XB/Năm XB";
            this.publishing.Name = "publishing";
            this.publishing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count.DataPropertyName = "count";
            this.count.FillWeight = 77.1657F;
            this.count.HeaderText = "Số lượng";
            this.count.Name = "count";
            // 
            // priceIn
            // 
            this.priceIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceIn.DataPropertyName = "priceIn";
            this.priceIn.FillWeight = 77.1657F;
            this.priceIn.HeaderText = "Đơn giá nhập";
            this.priceIn.Name = "priceIn";
            // 
            // totalPrice
            // 
            this.totalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPrice.DataPropertyName = "totalPrice";
            this.totalPrice.FillWeight = 77.1657F;
            this.totalPrice.HeaderText = "Thành tiền";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // FImportBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FImportBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu nhập sách";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImportBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.TextBox txbIDImportBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvImportBook;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddBookTitle;
        private System.Windows.Forms.Button btnHistoryImport;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintImport;
        private System.Windows.Forms.Button btnAddImport;
        private System.Windows.Forms.Button btnSaveImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishing;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
    }
}