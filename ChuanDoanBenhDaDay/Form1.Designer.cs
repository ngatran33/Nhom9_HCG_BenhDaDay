namespace ChuanDoanBenhDaDay
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnTrangchu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTapLuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSuKien = new System.Windows.Forms.ToolStripMenuItem();
            this.MnChuanDoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTrangChu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSuyDien = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTapLuat = new System.Windows.Forms.Button();
            this.btnChuanDoan = new System.Windows.Forms.Button();
            this.btnSuKien = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.suyDiễnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnTrangchu,
            this.mnTapLuat,
            this.mnSuKien,
            this.MnChuanDoan,
            this.suyDiễnToolStripMenuItem,
            this.mnThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnTrangchu
            // 
            this.mnTrangchu.Name = "mnTrangchu";
            this.mnTrangchu.Size = new System.Drawing.Size(85, 24);
            this.mnTrangchu.Text = "Trang chủ";
            this.mnTrangchu.Click += new System.EventHandler(this.mnTrangchu_Click);
            // 
            // mnTapLuat
            // 
            this.mnTapLuat.Name = "mnTapLuat";
            this.mnTapLuat.Size = new System.Drawing.Size(78, 24);
            this.mnTapLuat.Text = "Tập Luật";
            this.mnTapLuat.Click += new System.EventHandler(this.mnTapLuat_Click);
            // 
            // mnSuKien
            // 
            this.mnSuKien.Name = "mnSuKien";
            this.mnSuKien.Size = new System.Drawing.Size(69, 24);
            this.mnSuKien.Text = "Sự kiện";
            this.mnSuKien.Click += new System.EventHandler(this.mnSuKien_Click);
            // 
            // MnChuanDoan
            // 
            this.MnChuanDoan.Name = "MnChuanDoan";
            this.MnChuanDoan.Size = new System.Drawing.Size(100, 24);
            this.MnChuanDoan.Text = "Chuẩn đoán";
            this.MnChuanDoan.Click += new System.EventHandler(this.MnChuanDoan_Click);
            // 
            // mnThoat
            // 
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(59, 24);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.pnlTrangChu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 903);
            this.panel1.TabIndex = 1;
            // 
            // pnlTrangChu
            // 
            this.pnlTrangChu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlTrangChu.BackColor = System.Drawing.Color.BlueViolet;
            this.pnlTrangChu.Location = new System.Drawing.Point(225, 60);
            this.pnlTrangChu.Name = "pnlTrangChu";
            this.pnlTrangChu.Size = new System.Drawing.Size(1067, 801);
            this.pnlTrangChu.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnSuyDien);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnTrangChu);
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnTapLuat);
            this.panel2.Controls.Add(this.btnChuanDoan);
            this.panel2.Controls.Add(this.btnSuKien);
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 801);
            this.panel2.TabIndex = 5;
            // 
            // btnSuyDien
            // 
            this.btnSuyDien.BackColor = System.Drawing.Color.Blue;
            this.btnSuyDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuyDien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuyDien.Location = new System.Drawing.Point(23, 560);
            this.btnSuyDien.Name = "btnSuyDien";
            this.btnSuyDien.Size = new System.Drawing.Size(181, 36);
            this.btnSuyDien.TabIndex = 6;
            this.btnSuyDien.Text = "Suy Diễn";
            this.btnSuyDien.UseVisualStyleBackColor = false;
            this.btnSuyDien.Click += new System.EventHandler(this.btnSuyDien_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::ChuanDoanBenhDaDay.Properties.Resources.doc_icon_4x;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTrangChu.BackColor = System.Drawing.Color.Blue;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrangChu.Location = new System.Drawing.Point(23, 233);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(181, 37);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.BackColor = System.Drawing.Color.Blue;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.Location = new System.Drawing.Point(23, 644);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(181, 37);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTapLuat
            // 
            this.btnTapLuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTapLuat.BackColor = System.Drawing.Color.Blue;
            this.btnTapLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTapLuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTapLuat.Location = new System.Drawing.Point(23, 315);
            this.btnTapLuat.Name = "btnTapLuat";
            this.btnTapLuat.Size = new System.Drawing.Size(181, 37);
            this.btnTapLuat.TabIndex = 2;
            this.btnTapLuat.Text = "Tập luật";
            this.btnTapLuat.UseVisualStyleBackColor = false;
            this.btnTapLuat.Click += new System.EventHandler(this.btnTapLuat_Click);
            // 
            // btnChuanDoan
            // 
            this.btnChuanDoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChuanDoan.BackColor = System.Drawing.Color.Blue;
            this.btnChuanDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuanDoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChuanDoan.Location = new System.Drawing.Point(23, 479);
            this.btnChuanDoan.Name = "btnChuanDoan";
            this.btnChuanDoan.Size = new System.Drawing.Size(181, 37);
            this.btnChuanDoan.TabIndex = 3;
            this.btnChuanDoan.Text = "Chuẩn Đoán";
            this.btnChuanDoan.UseVisualStyleBackColor = false;
            this.btnChuanDoan.Click += new System.EventHandler(this.btnChuanDoan_Click);
            // 
            // btnSuKien
            // 
            this.btnSuKien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuKien.BackColor = System.Drawing.Color.Blue;
            this.btnSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuKien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuKien.Location = new System.Drawing.Point(23, 397);
            this.btnSuKien.Name = "btnSuKien";
            this.btnSuKien.Size = new System.Drawing.Size(181, 37);
            this.btnSuKien.TabIndex = 3;
            this.btnSuKien.Text = "Sự kiện";
            this.btnSuKien.UseVisualStyleBackColor = false;
            this.btnSuKien.Click += new System.EventHandler(this.btnSuKien_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(431, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phần mềm chuẩn đoán bệnh về dạ dày";
            // 
            // suyDiễnToolStripMenuItem
            // 
            this.suyDiễnToolStripMenuItem.Name = "suyDiễnToolStripMenuItem";
            this.suyDiễnToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.suyDiễnToolStripMenuItem.Text = "Suy diễn";
            this.suyDiễnToolStripMenuItem.Click += new System.EventHandler(this.suyDiễnToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1292, 903);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuẩn đoán bệnh về dạ dày";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnTrangchu;
        private System.Windows.Forms.ToolStripMenuItem mnTapLuat;
        private System.Windows.Forms.ToolStripMenuItem mnSuKien;
        private System.Windows.Forms.ToolStripMenuItem MnChuanDoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTrangChu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTapLuat;
        private System.Windows.Forms.Button btnSuKien;
        private System.Windows.Forms.Button btnChuanDoan;
        private System.Windows.Forms.Button btnSuyDien;
        private System.Windows.Forms.ToolStripMenuItem suyDiễnToolStripMenuItem;
    }
}

