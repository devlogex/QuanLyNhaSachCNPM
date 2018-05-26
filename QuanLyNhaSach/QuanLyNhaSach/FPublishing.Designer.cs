namespace QuanLyNhaSach
{
    partial class FPublishing
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddPublishing = new System.Windows.Forms.Button();
            this.txbPublishCompany = new System.Windows.Forms.TextBox();
            this.txbPublishYear = new System.Windows.Forms.TextBox();
            this.cbPublishing = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà xuất bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khác :";
            // 
            // btnAddPublishing
            // 
            this.btnAddPublishing.Location = new System.Drawing.Point(302, 168);
            this.btnAddPublishing.Name = "btnAddPublishing";
            this.btnAddPublishing.Size = new System.Drawing.Size(75, 23);
            this.btnAddPublishing.TabIndex = 1;
            this.btnAddPublishing.Text = "Thêm";
            this.btnAddPublishing.UseVisualStyleBackColor = true;
            this.btnAddPublishing.Click += new System.EventHandler(this.btnAddPublishing_Click);
            // 
            // txbPublishCompany
            // 
            this.txbPublishCompany.Location = new System.Drawing.Point(164, 109);
            this.txbPublishCompany.Name = "txbPublishCompany";
            this.txbPublishCompany.Size = new System.Drawing.Size(213, 20);
            this.txbPublishCompany.TabIndex = 2;
            // 
            // txbPublishYear
            // 
            this.txbPublishYear.Location = new System.Drawing.Point(164, 142);
            this.txbPublishYear.Name = "txbPublishYear";
            this.txbPublishYear.Size = new System.Drawing.Size(213, 20);
            this.txbPublishYear.TabIndex = 2;
            this.txbPublishYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPublishYear_KeyPress);
            // 
            // cbPublishing
            // 
            this.cbPublishing.FormattingEnabled = true;
            this.cbPublishing.Location = new System.Drawing.Point(164, 12);
            this.cbPublishing.Name = "cbPublishing";
            this.cbPublishing.Size = new System.Drawing.Size(213, 21);
            this.cbPublishing.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà XB/Năm XB";
            // 
            // btnChose
            // 
            this.btnChose.Location = new System.Drawing.Point(302, 42);
            this.btnChose.Name = "btnChose";
            this.btnChose.Size = new System.Drawing.Size(75, 23);
            this.btnChose.TabIndex = 4;
            this.btnChose.Text = "Chọn";
            this.btnChose.UseVisualStyleBackColor = true;
            this.btnChose.Click += new System.EventHandler(this.btnChose_Click);
            // 
            // FPublishing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 202);
            this.Controls.Add(this.btnChose);
            this.Controls.Add(this.cbPublishing);
            this.Controls.Add(this.txbPublishYear);
            this.Controls.Add(this.txbPublishCompany);
            this.Controls.Add(this.btnAddPublishing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FPublishing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà xuất bản & năm xuất bản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddPublishing;
        private System.Windows.Forms.TextBox txbPublishCompany;
        private System.Windows.Forms.TextBox txbPublishYear;
        private System.Windows.Forms.ComboBox cbPublishing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChose;
    }
}