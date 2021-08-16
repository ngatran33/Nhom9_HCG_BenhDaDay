namespace ChuanDoanBenhDaDay
{
    partial class ChuanDoan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAllSuKien = new System.Windows.Forms.DataGridView();
            this.MaSK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSkChon = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChuanDoan = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnXoaTim = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listKetqua = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSuKien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkChon)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAllSuKien);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 601);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sự kiện";
            // 
            // dgvAllSuKien
            // 
            this.dgvAllSuKien.AllowUserToAddRows = false;
            this.dgvAllSuKien.AllowUserToDeleteRows = false;
            this.dgvAllSuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSK,
            this.MoTa});
            this.dgvAllSuKien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllSuKien.Location = new System.Drawing.Point(3, 23);
            this.dgvAllSuKien.Name = "dgvAllSuKien";
            this.dgvAllSuKien.ReadOnly = true;
            this.dgvAllSuKien.RowHeadersWidth = 62;
            this.dgvAllSuKien.RowTemplate.Height = 24;
            this.dgvAllSuKien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllSuKien.Size = new System.Drawing.Size(401, 575);
            this.dgvAllSuKien.TabIndex = 0;
            this.dgvAllSuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllSK_cellclick);
            // 
            // MaSK
            // 
            this.MaSK.DataPropertyName = "MaSK";
            this.MaSK.HeaderText = "Mã sự kiện";
            this.MaSK.MinimumWidth = 8;
            this.MaSK.Name = "MaSK";
            this.MaSK.ReadOnly = true;
            this.MaSK.Width = 60;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 8;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSkChon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(626, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 477);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sự kiện đã chọn";
            // 
            // dgvSkChon
            // 
            this.dgvSkChon.AllowUserToAddRows = false;
            this.dgvSkChon.AllowUserToDeleteRows = false;
            this.dgvSkChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgvSkChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSkChon.Location = new System.Drawing.Point(3, 23);
            this.dgvSkChon.Name = "dgvSkChon";
            this.dgvSkChon.ReadOnly = true;
            this.dgvSkChon.RowHeadersWidth = 62;
            this.dgvSkChon.RowTemplate.Height = 24;
            this.dgvSkChon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkChon.Size = new System.Drawing.Size(403, 451);
            this.dgvSkChon.TabIndex = 0;
            this.dgvSkChon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSkChon_CellClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã sự kiện";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mô tả";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(460, 108);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 38);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(460, 176);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(142, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChuanDoan
            // 
            this.btnChuanDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuanDoan.Location = new System.Drawing.Point(460, 244);
            this.btnChuanDoan.Name = "btnChuanDoan";
            this.btnChuanDoan.Size = new System.Drawing.Size(142, 38);
            this.btnChuanDoan.TabIndex = 3;
            this.btnChuanDoan.Text = "Chuẩn đoán";
            this.btnChuanDoan.UseVisualStyleBackColor = true;
            this.btnChuanDoan.Click += new System.EventHandler(this.btnChuanDoan_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(460, 312);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 38);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(135, 653);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(166, 27);
            this.txtTim.TabIndex = 6;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_textchanged);
            // 
            // btnXoaTim
            // 
            this.btnXoaTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTim.Location = new System.Drawing.Point(356, 647);
            this.btnXoaTim.Name = "btnXoaTim";
            this.btnXoaTim.Size = new System.Drawing.Size(91, 38);
            this.btnXoaTim.TabIndex = 7;
            this.btnXoaTim.Text = "xóa";
            this.btnXoaTim.UseVisualStyleBackColor = true;
            this.btnXoaTim.Click += new System.EventHandler(this.btnXoaTim_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listKetqua);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(626, 529);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 167);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // listKetqua
            // 
            this.listKetqua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listKetqua.FormattingEnabled = true;
            this.listKetqua.ItemHeight = 20;
            this.listKetqua.Location = new System.Drawing.Point(3, 23);
            this.listKetqua.Name = "listKetqua";
            this.listKetqua.Size = new System.Drawing.Size(400, 141);
            this.listKetqua.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 656);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tìm sự kiện";
            // 
            // ChuanDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 725);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnXoaTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnChuanDoan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ChuanDoan";
            this.Text = "ChuanDoan";
            this.Load += new System.EventHandler(this.ChuanDoan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSuKien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkChon)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAllSuKien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSkChon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChuanDoan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnXoaTim;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listKetqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}