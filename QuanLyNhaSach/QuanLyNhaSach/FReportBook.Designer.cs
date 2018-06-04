namespace QuanLyNhaSach
{
    partial class FReportBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nmMonth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvReportBook = new System.Windows.Forms.DataGridView();
            this.btnReportBook = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.btnReportBook);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(742, 552);
            this.panel4.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Location = new System.Drawing.Point(30, 464);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(688, 72);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(527, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(106, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(19, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(106, 35);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 72);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(158, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(461, 47);
            this.label3.TabIndex = 1;
            this.label3.Text = "LẬP BÁO CÁO TỒN SÁCH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nmMonth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nmYear);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 88);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(272, 73);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian";
            // 
            // nmMonth
            // 
            this.nmMonth.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMonth.Location = new System.Drawing.Point(118, 28);
            this.nmMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMonth.Name = "nmMonth";
            this.nmMonth.Size = new System.Drawing.Size(59, 24);
            this.nmMonth.TabIndex = 0;
            this.nmMonth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tháng/Năm :";
            // 
            // nmYear
            // 
            this.nmYear.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmYear.Location = new System.Drawing.Point(182, 28);
            this.nmYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.nmYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmYear.Name = "nmYear";
            this.nmYear.Size = new System.Drawing.Size(59, 24);
            this.nmYear.TabIndex = 1;
            this.nmYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(688, 280);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng thống kê sách tồn";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvReportBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(2, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 253);
            this.panel2.TabIndex = 0;
            // 
            // dtgvReportBook
            // 
            this.dtgvReportBook.AllowUserToAddRows = false;
            this.dtgvReportBook.AllowUserToDeleteRows = false;
            this.dtgvReportBook.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvReportBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvReportBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReportBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.idBook,
            this.firstCount,
            this.addCount,
            this.lastCount});
            this.dtgvReportBook.Location = new System.Drawing.Point(16, 6);
            this.dtgvReportBook.Name = "dtgvReportBook";
            this.dtgvReportBook.ReadOnly = true;
            this.dtgvReportBook.RowHeadersVisible = false;
            this.dtgvReportBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvReportBook.Size = new System.Drawing.Size(652, 240);
            this.dtgvReportBook.TabIndex = 4;
            // 
            // btnReportBook
            // 
            this.btnReportBook.BackColor = System.Drawing.SystemColors.Control;
            this.btnReportBook.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportBook.ForeColor = System.Drawing.Color.Black;
            this.btnReportBook.Location = new System.Drawing.Point(327, 106);
            this.btnReportBook.Name = "btnReportBook";
            this.btnReportBook.Size = new System.Drawing.Size(102, 38);
            this.btnReportBook.TabIndex = 2;
            this.btnReportBook.Text = "Thống kê";
            this.btnReportBook.UseVisualStyleBackColor = false;
            this.btnReportBook.Click += new System.EventHandler(this.btnReportBook_Click);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.STT.Width = 50;
            // 
            // idBook
            // 
            this.idBook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idBook.DataPropertyName = "idBook";
            this.idBook.HeaderText = "Mã sách";
            this.idBook.Name = "idBook";
            this.idBook.ReadOnly = true;
            this.idBook.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // firstCount
            // 
            this.firstCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstCount.DataPropertyName = "firstCount";
            this.firstCount.HeaderText = "Tồn đầu";
            this.firstCount.Name = "firstCount";
            this.firstCount.ReadOnly = true;
            this.firstCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // addCount
            // 
            this.addCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addCount.DataPropertyName = "addCount";
            this.addCount.HeaderText = "Phát sinh";
            this.addCount.Name = "addCount";
            this.addCount.ReadOnly = true;
            this.addCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lastCount
            // 
            this.lastCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastCount.DataPropertyName = "lastCount";
            this.lastCount.HeaderText = "Tồn cuối";
            this.lastCount.Name = "lastCount";
            this.lastCount.ReadOnly = true;
            this.lastCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FReportBook
            // 
            this.AcceptButton = this.btnReportBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(742, 552);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FReportBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tồn";
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nmMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReportBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvReportBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn addCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCount;
    }
}