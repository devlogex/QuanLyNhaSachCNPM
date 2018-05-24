namespace QuanLyNhaSach
{
    partial class FReportDebt
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReportOwe = new System.Windows.Forms.Button();
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.nmMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvReportOwe = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstOwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addOwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastOwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportOwe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 72);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(245, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "LẬP BÁO CÁO CÔNG NỢ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReportOwe);
            this.panel2.Controls.Add(this.nmYear);
            this.panel2.Controls.Add(this.nmMonth);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 480);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvReportOwe);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 404);
            this.panel3.TabIndex = 0;
            // 
            // btnReportOwe
            // 
            this.btnReportOwe.BackColor = System.Drawing.Color.DarkGray;
            this.btnReportOwe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportOwe.ForeColor = System.Drawing.Color.Blue;
            this.btnReportOwe.Location = new System.Drawing.Point(436, 20);
            this.btnReportOwe.Name = "btnReportOwe";
            this.btnReportOwe.Size = new System.Drawing.Size(102, 38);
            this.btnReportOwe.TabIndex = 15;
            this.btnReportOwe.Text = "Thống kê";
            this.btnReportOwe.UseVisualStyleBackColor = false;
            // 
            // nmYear
            // 
            this.nmYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmYear.Location = new System.Drawing.Point(196, 20);
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
            this.nmYear.Size = new System.Drawing.Size(59, 26);
            this.nmYear.TabIndex = 13;
            this.nmYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // nmMonth
            // 
            this.nmMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMonth.Location = new System.Drawing.Point(131, 20);
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
            this.nmMonth.Size = new System.Drawing.Size(59, 26);
            this.nmMonth.TabIndex = 14;
            this.nmMonth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tháng/Năm :";
            // 
            // dtgvReportOwe
            // 
            this.dtgvReportOwe.AllowUserToAddRows = false;
            this.dtgvReportOwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReportOwe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.customerName,
            this.firstOwe,
            this.addOwe,
            this.lastOwe});
            this.dtgvReportOwe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvReportOwe.Location = new System.Drawing.Point(0, 0);
            this.dtgvReportOwe.Name = "dtgvReportOwe";
            this.dtgvReportOwe.ReadOnly = true;
            this.dtgvReportOwe.RowHeadersVisible = false;
            this.dtgvReportOwe.Size = new System.Drawing.Size(964, 404);
            this.dtgvReportOwe.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "Khách hàng";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // firstOwe
            // 
            this.firstOwe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstOwe.DataPropertyName = "firstOwe";
            this.firstOwe.HeaderText = "Nợ đầu";
            this.firstOwe.Name = "firstOwe";
            this.firstOwe.ReadOnly = true;
            // 
            // addOwe
            // 
            this.addOwe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addOwe.DataPropertyName = "addOwe";
            this.addOwe.HeaderText = "Phát sinh";
            this.addOwe.Name = "addOwe";
            this.addOwe.ReadOnly = true;
            // 
            // lastOwe
            // 
            this.lastOwe.DataPropertyName = "lastOwe";
            this.lastOwe.HeaderText = "Nợ cuối";
            this.lastOwe.Name = "lastOwe";
            this.lastOwe.ReadOnly = true;
            // 
            // FReportDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FReportDebt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo công nợ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportOwe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReportOwe;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.NumericUpDown nmMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvReportOwe;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstOwe;
        private System.Windows.Forms.DataGridViewTextBoxColumn addOwe;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastOwe;
    }
}