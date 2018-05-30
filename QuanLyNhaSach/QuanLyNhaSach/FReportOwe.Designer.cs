namespace QuanLyNhaSach
{
    partial class FReportOwe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvReportDebt = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstOwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addOwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastOwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReportOwe = new System.Windows.Forms.Button();
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.nmMonth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportDebt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 89);
            this.panel1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(215, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(559, 59);
            this.label3.TabIndex = 0;
            this.label3.Text = "LẬP BÁO CÁO CÔNG NỢ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDown5);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(53, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 90);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời gian";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown6.Location = new System.Drawing.Point(157, 28);
            this.numericUpDown6.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(79, 29);
            this.numericUpDown6.TabIndex = 18;
            this.numericUpDown6.Value = new decimal(new int[] {
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
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tháng/Năm :";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown5.Location = new System.Drawing.Point(243, 28);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(79, 29);
            this.numericUpDown5.TabIndex = 17;
            this.numericUpDown5.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(703, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(25, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 43);
            this.button4.TabIndex = 11;
            this.button4.Text = "In";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(53, 556);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(918, 88);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnReportOwe);
            this.panel2.Controls.Add(this.nmYear);
            this.panel2.Controls.Add(this.nmMonth);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 679);
            this.panel2.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox3);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 679);
            this.panel4.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvReportDebt);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(53, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 345);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng thống kê công nợ";
            // 
            // dtgvReportDebt
            // 
            this.dtgvReportDebt.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvReportDebt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvReportDebt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReportDebt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.customerName,
            this.firstOwe,
            this.addOwe,
            this.lastOwe});
            this.dtgvReportDebt.Location = new System.Drawing.Point(18, 31);
            this.dtgvReportDebt.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvReportDebt.Name = "dtgvReportDebt";
            this.dtgvReportDebt.ReadOnly = true;
            this.dtgvReportDebt.RowHeadersVisible = false;
            this.dtgvReportDebt.Size = new System.Drawing.Size(870, 300);
            this.dtgvReportDebt.TabIndex = 3;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerName.DataPropertyName = "customerName";
            this.customerName.HeaderText = "Mã khách hàng";
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
            this.lastOwe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastOwe.DataPropertyName = "lastOwe";
            this.lastOwe.HeaderText = "Nợ cuối";
            this.lastOwe.Name = "lastOwe";
            this.lastOwe.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(482, 137);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 47);
            this.button3.TabIndex = 19;
            this.button3.Text = "Thống kê";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnReportOwe
            // 
            this.btnReportOwe.BackColor = System.Drawing.Color.DarkGray;
            this.btnReportOwe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportOwe.ForeColor = System.Drawing.Color.Blue;
            this.btnReportOwe.Location = new System.Drawing.Point(581, 25);
            this.btnReportOwe.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportOwe.Name = "btnReportOwe";
            this.btnReportOwe.Size = new System.Drawing.Size(136, 47);
            this.btnReportOwe.TabIndex = 15;
            this.btnReportOwe.Text = "Thống kê";
            this.btnReportOwe.UseVisualStyleBackColor = false;
            // 
            // nmYear
            // 
            this.nmYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmYear.Location = new System.Drawing.Point(261, 25);
            this.nmYear.Margin = new System.Windows.Forms.Padding(4);
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
            this.nmYear.Size = new System.Drawing.Size(79, 30);
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
            this.nmMonth.Location = new System.Drawing.Point(175, 25);
            this.nmMonth.Margin = new System.Windows.Forms.Padding(4);
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
            this.nmMonth.Size = new System.Drawing.Size(79, 30);
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
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tháng/Năm :";
            // 
            // FReportOwe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 679);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FReportOwe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo công nợ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReportDebt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvReportDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstOwe;
        private System.Windows.Forms.DataGridViewTextBoxColumn addOwe;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastOwe;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReportOwe;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.NumericUpDown nmMonth;
        private System.Windows.Forms.Label label1;
    }
}