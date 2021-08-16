using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanDoanBenhDaDay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TrangChu fm = new TrangChu();
            AddForm(fm);
        }
        private void AddForm(Form f)
        {
            pnlTrangChu.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            pnlTrangChu.Controls.Add(f);
            f.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            TrangChu fm = new TrangChu();
            AddForm(fm);
        }

        private void btnTapLuat_Click(object sender, EventArgs e)
        {
            TapLuat fm = new TapLuat();
            AddForm(fm);
        }

        private void btnSuKien_Click(object sender, EventArgs e)
        {
            SuKien fm = new SuKien();
            AddForm(fm);
        }

        private void btnChuanDoan_Click(object sender, EventArgs e)
        {
            ChuanDoan fm = new ChuanDoan();
            AddForm(fm);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát","Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void mnTrangchu_Click(object sender, EventArgs e)
        {
            TrangChu fm = new TrangChu();
            AddForm(fm);
        }

        private void mnTapLuat_Click(object sender, EventArgs e)
        {
            TapLuat fm = new TapLuat();
            AddForm(fm);
        }

        private void mnSuKien_Click(object sender, EventArgs e)
        {
            SuKien fm = new SuKien();
            AddForm(fm);
        }

        private void MnChuanDoan_Click(object sender, EventArgs e)
        {
            ChuanDoan fm = new ChuanDoan();
            AddForm(fm);
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSuyDien_Click(object sender, EventArgs e)
        {
            SuyDien fm = new SuyDien();
            fm.Show();
        }

        private void suyDiễnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuyDien fm = new SuyDien();
            fm.Show();
        }
    }
}
