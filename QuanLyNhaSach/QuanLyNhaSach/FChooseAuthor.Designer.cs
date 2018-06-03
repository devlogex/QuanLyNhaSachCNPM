namespace QuanLyNhaSach
{
    partial class FChooseAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChooseAuthor));
            this.dtgvAuthor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbRemoveAuthor = new System.Windows.Forms.PictureBox();
            this.pbAddAuthor = new System.Windows.Forms.PictureBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddAuthor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvAuthor
            // 
            this.dtgvAuthor.AllowUserToAddRows = false;
            this.dtgvAuthor.AllowUserToDeleteRows = false;
            this.dtgvAuthor.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dtgvAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAuthor.Location = new System.Drawing.Point(0, 0);
            this.dtgvAuthor.Name = "dtgvAuthor";
            this.dtgvAuthor.ReadOnly = true;
            this.dtgvAuthor.RowHeadersVisible = false;
            this.dtgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAuthor.Size = new System.Drawing.Size(115, 150);
            this.dtgvAuthor.TabIndex = 48;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tác giả";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // pbRemoveAuthor
            // 
            this.pbRemoveAuthor.Image = ((System.Drawing.Image)(resources.GetObject("pbRemoveAuthor.Image")));
            this.pbRemoveAuthor.Location = new System.Drawing.Point(152, 98);
            this.pbRemoveAuthor.Name = "pbRemoveAuthor";
            this.pbRemoveAuthor.Size = new System.Drawing.Size(42, 40);
            this.pbRemoveAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRemoveAuthor.TabIndex = 46;
            this.pbRemoveAuthor.TabStop = false;
            this.pbRemoveAuthor.Click += new System.EventHandler(this.pbRemoveAuthor_Click);
            // 
            // pbAddAuthor
            // 
            this.pbAddAuthor.Image = ((System.Drawing.Image)(resources.GetObject("pbAddAuthor.Image")));
            this.pbAddAuthor.Location = new System.Drawing.Point(152, 42);
            this.pbAddAuthor.Name = "pbAddAuthor";
            this.pbAddAuthor.Size = new System.Drawing.Size(42, 40);
            this.pbAddAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddAuthor.TabIndex = 47;
            this.pbAddAuthor.TabStop = false;
            this.pbAddAuthor.Click += new System.EventHandler(this.pbAddAuthor_Click);
            // 
            // cbAuthor
            // 
            this.cbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbAuthor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(26, 15);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(120, 150);
            this.cbAuthor.TabIndex = 45;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(155, 175);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 35);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "Hoàn tất";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvAuthor);
            this.panel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(200, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 150);
            this.panel1.TabIndex = 50;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(246, 175);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 35);
            this.btnExit.TabIndex = 51;
            this.btnExit.Text = "Trở lại";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FChooseAuthor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(343, 223);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbRemoveAuthor);
            this.Controls.Add(this.pbAddAuthor);
            this.Controls.Add(this.cbAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FChooseAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn tác giả";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddAuthor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAuthor;
        private System.Windows.Forms.PictureBox pbRemoveAuthor;
        private System.Windows.Forms.PictureBox pbAddAuthor;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
    }
}