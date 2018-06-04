namespace QuanLyNhaSach
{
    partial class FListBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListBill));
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvListBill = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dtgvListBillInfo = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.STT2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBill)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBillInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 188);
            this.panel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(25, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvListBill);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 159);
            this.panel2.TabIndex = 0;
            // 
            // dtgvListBill
            // 
            this.dtgvListBill.AllowUserToAddRows = false;
            this.dtgvListBill.AllowUserToDeleteRows = false;
            this.dtgvListBill.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvListBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.idBill,
            this.idCustomer,
            this.nameCustomer,
            this.date,
            this.value});
            this.dtgvListBill.Location = new System.Drawing.Point(9, 7);
            this.dtgvListBill.Name = "dtgvListBill";
            this.dtgvListBill.ReadOnly = true;
            this.dtgvListBill.RowHeadersVisible = false;
            this.dtgvListBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListBill.Size = new System.Drawing.Size(733, 145);
            this.dtgvListBill.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(807, 493);
            this.panel4.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(705, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 37);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(354, 449);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 37);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtgvListBillInfo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(3, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(777, 183);
            this.panel5.TabIndex = 0;
            // 
            // dtgvListBillInfo
            // 
            this.dtgvListBillInfo.AllowUserToAddRows = false;
            this.dtgvListBillInfo.AllowUserToDeleteRows = false;
            this.dtgvListBillInfo.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvListBillInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListBillInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT2,
            this.id,
            this.idBookTitle,
            this.name,
            this.category,
            this.author,
            this.publishing,
            this.count,
            this.priceOut});
            this.dtgvListBillInfo.Location = new System.Drawing.Point(10, 8);
            this.dtgvListBillInfo.Name = "dtgvListBillInfo";
            this.dtgvListBillInfo.ReadOnly = true;
            this.dtgvListBillInfo.RowHeadersVisible = false;
            this.dtgvListBillInfo.Size = new System.Drawing.Size(753, 167);
            this.dtgvListBillInfo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(352, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 70);
            this.panel1.TabIndex = 10;
            // 
            // STT2
            // 
            this.STT2.FillWeight = 23.13222F;
            this.STT2.HeaderText = "STT";
            this.STT2.Name = "STT2";
            this.STT2.ReadOnly = true;
            this.STT2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STT2.Width = 40;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 406.0914F;
            this.id.HeaderText = "Mã sách";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idBookTitle
            // 
            this.idBookTitle.DataPropertyName = "idBookTitle";
            this.idBookTitle.HeaderText = "Mã đầu sách";
            this.idBookTitle.Name = "idBookTitle";
            this.idBookTitle.ReadOnly = true;
            this.idBookTitle.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 61.79606F;
            this.name.HeaderText = "Tên sách";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // category
            // 
            this.category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.category.DataPropertyName = "category";
            this.category.FillWeight = 61.79606F;
            this.category.HeaderText = "Thể loại";
            this.category.Name = "category";
            this.category.ReadOnly = true;
            // 
            // author
            // 
            this.author.DataPropertyName = "author";
            this.author.HeaderText = "Tác giả";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // publishing
            // 
            this.publishing.DataPropertyName = "publishing";
            this.publishing.HeaderText = "Nhà  XB/Năm XB";
            this.publishing.Name = "publishing";
            this.publishing.ReadOnly = true;
            // 
            // count
            // 
            this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.count.DataPropertyName = "count";
            this.count.FillWeight = 61.79606F;
            this.count.HeaderText = "Số lượng";
            this.count.Name = "count";
            this.count.ReadOnly = true;
            // 
            // priceOut
            // 
            this.priceOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceOut.DataPropertyName = "priceOut";
            this.priceOut.FillWeight = 61.79606F;
            this.priceOut.HeaderText = "Đơn giá bán";
            this.priceOut.Name = "priceOut";
            this.priceOut.ReadOnly = true;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 40;
            // 
            // idBill
            // 
            this.idBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idBill.DataPropertyName = "idBill";
            this.idBill.HeaderText = "Số hóa đơn";
            this.idBill.Name = "idBill";
            this.idBill.ReadOnly = true;
            // 
            // idCustomer
            // 
            this.idCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCustomer.DataPropertyName = "idCustomer";
            this.idCustomer.HeaderText = "Mã khách hàng";
            this.idCustomer.Name = "idCustomer";
            this.idCustomer.ReadOnly = true;
            // 
            // nameCustomer
            // 
            this.nameCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameCustomer.DataPropertyName = "nameCustomer";
            this.nameCustomer.HeaderText = "Tên khách hàng";
            this.nameCustomer.Name = "nameCustomer";
            this.nameCustomer.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Ngày lập";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // value
            // 
            this.value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.value.DataPropertyName = "value";
            this.value.HeaderText = "Tổng tiền";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            // 
            // FListBill
            // 
            this.AcceptButton = this.btnPrint;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(807, 563);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FListBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn";
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBill)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBillInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvListBill;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvListBillInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishing;
        private System.Windows.Forms.DataGridViewTextBoxColumn count;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOut;
    }
}