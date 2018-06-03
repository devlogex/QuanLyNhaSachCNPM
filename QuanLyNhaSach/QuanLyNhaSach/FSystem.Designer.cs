namespace QuanLyNhaSach
{
    partial class FSystem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbPercentPrice = new System.Windows.Forms.TextBox();
            this.btnUpdateSystem = new System.Windows.Forms.Button();
            this.cbQD4 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nmUD4 = new System.Windows.Forms.NumericUpDown();
            this.nmUD3 = new System.Windows.Forms.NumericUpDown();
            this.nmUD2 = new System.Windows.Forms.NumericUpDown();
            this.nmUD1 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 482);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.txbPercentPrice);
            this.groupBox1.Controls.Add(this.btnUpdateSystem);
            this.groupBox1.Controls.Add(this.cbQD4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nmUD4);
            this.groupBox1.Controls.Add(this.nmUD3);
            this.groupBox1.Controls.Add(this.nmUD2);
            this.groupBox1.Controls.Add(this.nmUD1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 387);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // txbPercentPrice
            // 
            this.txbPercentPrice.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPercentPrice.ForeColor = System.Drawing.Color.Black;
            this.txbPercentPrice.Location = new System.Drawing.Point(418, 218);
            this.txbPercentPrice.Name = "txbPercentPrice";
            this.txbPercentPrice.Size = new System.Drawing.Size(187, 26);
            this.txbPercentPrice.TabIndex = 4;
            this.txbPercentPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPercentPrice_KeyPress);
            // 
            // btnUpdateSystem
            // 
            this.btnUpdateSystem.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdateSystem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSystem.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateSystem.Location = new System.Drawing.Point(292, 317);
            this.btnUpdateSystem.Name = "btnUpdateSystem";
            this.btnUpdateSystem.Size = new System.Drawing.Size(155, 50);
            this.btnUpdateSystem.TabIndex = 6;
            this.btnUpdateSystem.Text = "Cập nhật";
            this.btnUpdateSystem.UseVisualStyleBackColor = false;
            this.btnUpdateSystem.Click += new System.EventHandler(this.btnUpdateSystem_Click);
            // 
            // cbQD4
            // 
            this.cbQD4.AutoSize = true;
            this.cbQD4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQD4.ForeColor = System.Drawing.Color.Black;
            this.cbQD4.Location = new System.Drawing.Point(14, 258);
            this.cbQD4.Name = "cbQD4";
            this.cbQD4.Size = new System.Drawing.Size(410, 23);
            this.cbQD4.TabIndex = 5;
            this.cbQD4.Text = "Số tiền thu không vượt quá số tiền khách hàng đang nợ";
            this.cbQD4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "Phần trăm đơn giá bán so với đơn giá nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "Lượng tồn tối thiểu của sách sau khi bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Số tiền nợ tối đa của khách hàng sau khi bán sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "Lượng tồn tối thiểu của sách khi nhập sách phải nhỏ hơn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 19);
            this.label6.TabIndex = 43;
            this.label6.Text = "Số lượng sách tối thiểu khi  nhập sách";
            // 
            // nmUD4
            // 
            this.nmUD4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmUD4.ForeColor = System.Drawing.Color.Black;
            this.nmUD4.Location = new System.Drawing.Point(418, 184);
            this.nmUD4.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmUD4.Name = "nmUD4";
            this.nmUD4.Size = new System.Drawing.Size(187, 26);
            this.nmUD4.TabIndex = 3;
            // 
            // nmUD3
            // 
            this.nmUD3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmUD3.ForeColor = System.Drawing.Color.Black;
            this.nmUD3.Location = new System.Drawing.Point(419, 147);
            this.nmUD3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmUD3.Name = "nmUD3";
            this.nmUD3.Size = new System.Drawing.Size(186, 26);
            this.nmUD3.TabIndex = 2;
            // 
            // nmUD2
            // 
            this.nmUD2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmUD2.ForeColor = System.Drawing.Color.Black;
            this.nmUD2.Location = new System.Drawing.Point(420, 110);
            this.nmUD2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmUD2.Name = "nmUD2";
            this.nmUD2.Size = new System.Drawing.Size(185, 26);
            this.nmUD2.TabIndex = 1;
            // 
            // nmUD1
            // 
            this.nmUD1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmUD1.ForeColor = System.Drawing.Color.Black;
            this.nmUD1.Location = new System.Drawing.Point(421, 74);
            this.nmUD1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmUD1.Name = "nmUD1";
            this.nmUD1.Size = new System.Drawing.Size(184, 26);
            this.nmUD1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 72);
            this.panel2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(133, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 47);
            this.label3.TabIndex = 1;
            this.label3.Text = "THAY ĐỔI QUY ĐINH";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(469, 317);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 50);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FSystem
            // 
            this.AcceptButton = this.btnUpdateSystem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(687, 482);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi quy định";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmUD1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbPercentPrice;
        private System.Windows.Forms.Button btnUpdateSystem;
        private System.Windows.Forms.CheckBox cbQD4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmUD4;
        private System.Windows.Forms.NumericUpDown nmUD3;
        private System.Windows.Forms.NumericUpDown nmUD2;
        private System.Windows.Forms.NumericUpDown nmUD1;
        private System.Windows.Forms.Button btnExit;
    }
}