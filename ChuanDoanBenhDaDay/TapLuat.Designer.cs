namespace ChuanDoanBenhDaDay
{
    partial class TapLuat
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
            this.btnSuaLuat = new System.Windows.Forms.Button();
            this.btnXoaLuat = new System.Windows.Forms.Button();
            this.btnThemLuat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnVeTrai = new System.Windows.Forms.Button();
            this.btnVephai = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvLuat = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtVeTrai = new System.Windows.Forms.TextBox();
            this.txtVePhai = new System.Windows.Forms.TextBox();
            this.txtMaLuat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSuKien = new System.Windows.Forms.DataGridView();
            this.MaSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VeTrai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuKien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSuaLuat);
            this.panel1.Controls.Add(this.btnXoaLuat);
            this.panel1.Controls.Add(this.btnThemLuat);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnVeTrai);
            this.panel1.Controls.Add(this.btnVephai);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 690);
            this.panel1.TabIndex = 2;
            // 
            // btnSuaLuat
            // 
            this.btnSuaLuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLuat.Location = new System.Drawing.Point(749, 297);
            this.btnSuaLuat.Name = "btnSuaLuat";
            this.btnSuaLuat.Size = new System.Drawing.Size(113, 41);
            this.btnSuaLuat.TabIndex = 8;
            this.btnSuaLuat.Text = "Sửa luật";
            this.btnSuaLuat.UseVisualStyleBackColor = true;
            this.btnSuaLuat.Click += new System.EventHandler(this.btnSuaLuat_Click);
            // 
            // btnXoaLuat
            // 
            this.btnXoaLuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLuat.Location = new System.Drawing.Point(909, 297);
            this.btnXoaLuat.Name = "btnXoaLuat";
            this.btnXoaLuat.Size = new System.Drawing.Size(113, 41);
            this.btnXoaLuat.TabIndex = 7;
            this.btnXoaLuat.Text = "Xóa luật";
            this.btnXoaLuat.UseVisualStyleBackColor = true;
            this.btnXoaLuat.Click += new System.EventHandler(this.btnXoaLuat_Click);
            // 
            // btnThemLuat
            // 
            this.btnThemLuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLuat.Location = new System.Drawing.Point(589, 297);
            this.btnThemLuat.Name = "btnThemLuat";
            this.btnThemLuat.Size = new System.Drawing.Size(113, 41);
            this.btnThemLuat.TabIndex = 6;
            this.btnThemLuat.Text = "Thêm luật";
            this.btnThemLuat.UseVisualStyleBackColor = true;
            this.btnThemLuat.Click += new System.EventHandler(this.btnThemLuat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(461, 187);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(157, 49);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnVeTrai
            // 
            this.btnVeTrai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVeTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeTrai.Location = new System.Drawing.Point(461, 114);
            this.btnVeTrai.Name = "btnVeTrai";
            this.btnVeTrai.Size = new System.Drawing.Size(157, 49);
            this.btnVeTrai.TabIndex = 4;
            this.btnVeTrai.Text = "Thêm vế trái";
            this.btnVeTrai.UseVisualStyleBackColor = true;
            this.btnVeTrai.Click += new System.EventHandler(this.btnVeTrai_Click);
            // 
            // btnVephai
            // 
            this.btnVephai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVephai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVephai.Location = new System.Drawing.Point(461, 39);
            this.btnVephai.Name = "btnVephai";
            this.btnVephai.Size = new System.Drawing.Size(157, 49);
            this.btnVephai.TabIndex = 3;
            this.btnVephai.Text = "Thêm vế phải";
            this.btnVephai.UseVisualStyleBackColor = true;
            this.btnVephai.Click += new System.EventHandler(this.btnVephai_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.dgvLuat);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(461, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 316);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách tập luật";
            // 
            // dgvLuat
            // 
            this.dgvLuat.AllowUserToDeleteRows = false;
            this.dgvLuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuat,
            this.VeTrai,
            this.Column5});
            this.dgvLuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLuat.Location = new System.Drawing.Point(3, 23);
            this.dgvLuat.Name = "dgvLuat";
            this.dgvLuat.RowTemplate.Height = 24;
            this.dgvLuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuat.Size = new System.Drawing.Size(555, 290);
            this.dgvLuat.TabIndex = 0;
            this.dgvLuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuat_cellclick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txtVeTrai);
            this.groupBox2.Controls.Add(this.txtVePhai);
            this.groupBox2.Controls.Add(this.txtMaLuat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(653, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 215);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tập luật";
            // 
            // txtVeTrai
            // 
            this.txtVeTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVeTrai.Location = new System.Drawing.Point(120, 166);
            this.txtVeTrai.Name = "txtVeTrai";
            this.txtVeTrai.Size = new System.Drawing.Size(226, 27);
            this.txtVeTrai.TabIndex = 5;
            // 
            // txtVePhai
            // 
            this.txtVePhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVePhai.Location = new System.Drawing.Point(120, 104);
            this.txtVePhai.Name = "txtVePhai";
            this.txtVePhai.Size = new System.Drawing.Size(226, 27);
            this.txtVePhai.TabIndex = 4;
            // 
            // txtMaLuat
            // 
            this.txtMaLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLuat.Location = new System.Drawing.Point(120, 42);
            this.txtMaLuat.Name = "txtMaLuat";
            this.txtMaLuat.Size = new System.Drawing.Size(226, 27);
            this.txtMaLuat.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vế trái:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vế phải:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã luật:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.dgvSuKien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 657);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Triệu chứng";
            // 
            // dgvSuKien
            // 
            this.dgvSuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSK,
            this.MoTa});
            this.dgvSuKien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuKien.Location = new System.Drawing.Point(3, 23);
            this.dgvSuKien.Name = "dgvSuKien";
            this.dgvSuKien.RowTemplate.Height = 24;
            this.dgvSuKien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuKien.Size = new System.Drawing.Size(389, 631);
            this.dgvSuKien.TabIndex = 0;
            this.dgvSuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuKien_cellclick);
            // 
            // MaSK
            // 
            this.MaSK.DataPropertyName = "MaSK";
            this.MaSK.HeaderText = "Mã sự kiện";
            this.MaSK.Name = "MaSK";
            this.MaSK.Width = 70;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 200;
            // 
            // MaLuat
            // 
            this.MaLuat.DataPropertyName = "MaLuat";
            this.MaLuat.HeaderText = "Mã Luật";
            this.MaLuat.Name = "MaLuat";
            this.MaLuat.Width = 70;
            // 
            // VeTrai
            // 
            this.VeTrai.DataPropertyName = "VeTrai";
            this.VeTrai.HeaderText = "Vế trái";
            this.VeTrai.Name = "VeTrai";
            this.VeTrai.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "VePhai";
            this.Column5.HeaderText = "Vế phải";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // TapLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 690);
            this.Controls.Add(this.panel1);
            this.Name = "TapLuat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TapLuat";
            this.Load += new System.EventHandler(this.TapLuat_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuKien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSuaLuat;
        private System.Windows.Forms.Button btnXoaLuat;
        private System.Windows.Forms.Button btnThemLuat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnVeTrai;
        private System.Windows.Forms.Button btnVephai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvLuat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVeTrai;
        private System.Windows.Forms.TextBox txtVePhai;
        private System.Windows.Forms.TextBox txtMaLuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn VeTrai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}