namespace QuanLyNhaSach
{
    partial class FUpdateAuthor
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
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbManangeBook = new System.Windows.Forms.Label();
            this.btnUpdateAuthor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbAuthor
            // 
            this.txbAuthor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAuthor.Location = new System.Drawing.Point(78, 51);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(247, 26);
            this.txbAuthor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tác giả";
            // 
            // lbManangeBook
            // 
            this.lbManangeBook.AutoSize = true;
            this.lbManangeBook.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManangeBook.ForeColor = System.Drawing.Color.Black;
            this.lbManangeBook.Location = new System.Drawing.Point(82, 9);
            this.lbManangeBook.Name = "lbManangeBook";
            this.lbManangeBook.Size = new System.Drawing.Size(184, 28);
            this.lbManangeBook.TabIndex = 42;
            this.lbManangeBook.Text = "Cập nhật tác giả";
            // 
            // btnUpdateAuthor
            // 
            this.btnUpdateAuthor.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAuthor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAuthor.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateAuthor.Location = new System.Drawing.Point(123, 99);
            this.btnUpdateAuthor.Name = "btnUpdateAuthor";
            this.btnUpdateAuthor.Size = new System.Drawing.Size(91, 37);
            this.btnUpdateAuthor.TabIndex = 44;
            this.btnUpdateAuthor.Text = "Cập nhật";
            this.btnUpdateAuthor.UseVisualStyleBackColor = false;
            this.btnUpdateAuthor.Click += new System.EventHandler(this.btnUpdateAuthor_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(220, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 37);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Trở lại";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FUpdateAuthor
            // 
            this.AcceptButton = this.btnUpdateAuthor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(337, 148);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateAuthor);
            this.Controls.Add(this.lbManangeBook);
            this.Controls.Add(this.txbAuthor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FUpdateAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManageCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbManangeBook;
        public System.Windows.Forms.Button btnUpdateAuthor;
        public System.Windows.Forms.Button btnExit;
    }
}