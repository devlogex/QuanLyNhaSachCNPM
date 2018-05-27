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
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvAuthor
            // 
            this.dtgvAuthor.AllowUserToAddRows = false;
            this.dtgvAuthor.AllowUserToDeleteRows = false;
            this.dtgvAuthor.BackgroundColor = System.Drawing.Color.White;
            this.dtgvAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAuthor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dtgvAuthor.Location = new System.Drawing.Point(273, 12);
            this.dtgvAuthor.Name = "dtgvAuthor";
            this.dtgvAuthor.ReadOnly = true;
            this.dtgvAuthor.RowHeadersVisible = false;
            this.dtgvAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAuthor.Size = new System.Drawing.Size(124, 150);
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
            this.name.HeaderText = "Danh sách tác giả";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // pbRemoveAuthor
            // 
            this.pbRemoveAuthor.Image = ((System.Drawing.Image)(resources.GetObject("pbRemoveAuthor.Image")));
            this.pbRemoveAuthor.Location = new System.Drawing.Point(225, 95);
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
            this.pbAddAuthor.Location = new System.Drawing.Point(225, 39);
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
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(99, 12);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(120, 150);
            this.cbAuthor.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tác giả";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(312, 174);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 23);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "Hoàn tất";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FChooseAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 209);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtgvAuthor);
            this.Controls.Add(this.pbRemoveAuthor);
            this.Controls.Add(this.pbAddAuthor);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FChooseAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn tác giả";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRemoveAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.PictureBox pbRemoveAuthor;
        private System.Windows.Forms.PictureBox pbAddAuthor;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
    }
}