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
            this.components = new System.ComponentModel.Container();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txbNameBookTitle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.txbIDImportBook = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpk = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.ttAdd = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddBookTitle = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrintImport = new System.Windows.Forms.Button();
            this.btnSaveImport = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txbPublishYear = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbBookTitle = new System.Windows.Forms.ComboBox();
            this.txbIDBook = new System.Windows.Forms.TextBox();
            this.txbPublishCompany = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.txbIDBookTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImportBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(128, 78);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(103, 27);
            this.cbCategory.TabIndex = 5;
            // 
            // txbNameBookTitle
            // 
            this.txbNameBookTitle.Location = new System.Drawing.Point(128, 50);
            this.txbNameBookTitle.Name = "txbNameBookTitle";
            this.txbNameBookTitle.Size = new System.Drawing.Size(103, 26);
            this.txbNameBookTitle.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbTotalPrice);
            this.groupBox2.Controls.Add(this.txbIDImportBook);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpk);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 108);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu nhập";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(140, 78);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(111, 26);
            this.txbTotalPrice.TabIndex = 2;
            // 
            // txbIDImportBook
            // 
            this.txbIDImportBook.Location = new System.Drawing.Point(140, 22);
            this.txbIDImportBook.Name = "txbIDImportBook";
            this.txbIDImportBook.ReadOnly = true;
            this.txbIDImportBook.Size = new System.Drawing.Size(111, 26);
            this.txbIDImportBook.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ngày lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số phiếu nhập";
            // 
            // dtpk
            // 
            this.dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk.Location = new System.Drawing.Point(140, 50);
            this.dtpk.Name = "dtpk";
            this.dtpk.Size = new System.Drawing.Size(111, 26);
            this.dtpk.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(22, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Tác giả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 237);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết phiếu nhập sách";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvImportBook);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 208);
            this.panel3.TabIndex = 0;
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
            this.dtgvImportBook.Location = new System.Drawing.Point(16, 8);
            this.dtgvImportBook.Name = "dtgvImportBook";
            this.dtgvImportBook.Size = new System.Drawing.Size(920, 197);
            this.dtgvImportBook.TabIndex = 1;
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
            this.id.HeaderText = "Mã sách";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id.Width = 90;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 77.1657F;
            this.name.HeaderText = "Tên sách";
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
            this.publishing.HeaderText = "NXB/Năm XB";
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
            // btnAddBookTitle
            // 
            this.btnAddBookTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBookTitle.Location = new System.Drawing.Point(248, 94);
            this.btnAddBookTitle.Name = "btnAddBookTitle";
            this.btnAddBookTitle.Size = new System.Drawing.Size(72, 35);
            this.btnAddBookTitle.TabIndex = 7;
            this.btnAddBookTitle.Text = "Thêm";
            this.ttAdd.SetToolTip(this.btnAddBookTitle, "Thêm đầu sách");
            this.btnAddBookTitle.UseVisualStyleBackColor = true;
            this.btnAddBookTitle.Click += new System.EventHandler(this.btnAddBookTitle_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(235, 96);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(72, 35);
            this.btnAddBook.TabIndex = 12;
            this.btnAddBook.Text = "Thêm";
            this.ttAdd.SetToolTip(this.btnAddBook, "Thêm sách");
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 480);
            this.panel2.TabIndex = 7;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.Red;
            this.lb.Location = new System.Drawing.Point(12, 404);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(544, 17);
            this.lb.TabIndex = 15;
            this.lb.Text = "*Chỉ nhập các sách có số lượng tồn nhỏ hơn 300. Số lượng nhập lớn hơn hoặc bằng 1" +
    "50";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnPrintImport);
            this.groupBox3.Controls.Add(this.btnSaveImport);
            this.groupBox3.Location = new System.Drawing.Point(7, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(946, 49);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(824, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintImport
            // 
            this.btnPrintImport.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintImport.Location = new System.Drawing.Point(146, 10);
            this.btnPrintImport.Name = "btnPrintImport";
            this.btnPrintImport.Size = new System.Drawing.Size(106, 35);
            this.btnPrintImport.TabIndex = 14;
            this.btnPrintImport.Text = "In";
            this.btnPrintImport.UseVisualStyleBackColor = true;
            this.btnPrintImport.Click += new System.EventHandler(this.btnPrintImport_Click);
            // 
            // btnSaveImport
            // 
            this.btnSaveImport.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImport.Location = new System.Drawing.Point(8, 10);
            this.btnSaveImport.Name = "btnSaveImport";
            this.btnSaveImport.Size = new System.Drawing.Size(106, 35);
            this.btnSaveImport.TabIndex = 13;
            this.btnSaveImport.Text = "Lưu";
            this.btnSaveImport.UseVisualStyleBackColor = true;
            this.btnSaveImport.Click += new System.EventHandler(this.btnSaveImport_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txbPublishYear);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnAddBook);
            this.groupBox4.Controls.Add(this.cbBookTitle);
            this.groupBox4.Controls.Add(this.txbIDBook);
            this.groupBox4.Controls.Add(this.txbPublishCompany);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(629, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 143);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thêm sách mới";
            // 
            // txbPublishYear
            // 
            this.txbPublishYear.Location = new System.Drawing.Point(115, 107);
            this.txbPublishYear.Name = "txbPublishYear";
            this.txbPublishYear.Size = new System.Drawing.Size(104, 26);
            this.txbPublishYear.TabIndex = 11;
            this.txbPublishYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPublishYear_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 19);
            this.label13.TabIndex = 7;
            this.label13.Text = "Năm xuất bản";
            // 
            // cbBookTitle
            // 
            this.cbBookTitle.FormattingEnabled = true;
            this.cbBookTitle.Location = new System.Drawing.Point(115, 22);
            this.cbBookTitle.Margin = new System.Windows.Forms.Padding(2);
            this.cbBookTitle.Name = "cbBookTitle";
            this.cbBookTitle.Size = new System.Drawing.Size(103, 27);
            this.cbBookTitle.TabIndex = 8;
            // 
            // txbIDBook
            // 
            this.txbIDBook.Location = new System.Drawing.Point(115, 50);
            this.txbIDBook.Name = "txbIDBook";
            this.txbIDBook.ReadOnly = true;
            this.txbIDBook.Size = new System.Drawing.Size(103, 26);
            this.txbIDBook.TabIndex = 9;
            // 
            // txbPublishCompany
            // 
            this.txbPublishCompany.Location = new System.Drawing.Point(115, 80);
            this.txbPublishCompany.Name = "txbPublishCompany";
            this.txbPublishCompany.Size = new System.Drawing.Size(104, 26);
            this.txbPublishCompany.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nhà xuất bản";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Mã sách";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Mã đầu sách";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbAuthor);
            this.groupBox5.Controls.Add(this.cbCategory);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txbNameBookTitle);
            this.groupBox5.Controls.Add(this.btnAddBookTitle);
            this.groupBox5.Controls.Add(this.txbIDBookTitle);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(281, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 143);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thêm đầu sách mới";
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(128, 107);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(103, 27);
            this.cbAuthor.TabIndex = 6;
            // 
            // txbIDBookTitle
            // 
            this.txbIDBookTitle.Location = new System.Drawing.Point(128, 22);
            this.txbIDBookTitle.Name = "txbIDBookTitle";
            this.txbIDBookTitle.ReadOnly = true;
            this.txbIDBookTitle.Size = new System.Drawing.Size(103, 26);
            this.txbIDBookTitle.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thể loại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tên đầu sách";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã đầu sách";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 72);
            this.panel1.TabIndex = 6;
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
            // FImportBook
            // 
            this.AcceptButton = this.btnSaveImport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(964, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FImportBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu nhập sách";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImportBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txbNameBookTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.TextBox txbIDImportBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpk;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip ttAdd;
        private System.Windows.Forms.Button btnAddBookTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrintImport;
        private System.Windows.Forms.Button btnSaveImport;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txbPublishYear;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbBookTitle;
        private System.Windows.Forms.TextBox txbIDBook;
        private System.Windows.Forms.TextBox txbPublishCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.TextBox txbIDBookTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvImportBook;
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