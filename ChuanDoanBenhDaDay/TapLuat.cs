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
    public partial class TapLuat : Form
    {
        int rowSK = -1;
        DBProccessing.DBProccessingTapLuat obj = new DBProccessing.DBProccessingTapLuat();
        public TapLuat()
        {
            InitializeComponent();
        }

        private void TapLuat_Load(object sender, EventArgs e)
        {
            dgvLuat.DataSource = obj.showLuat();
            dgvSuKien.DataSource = obj.showSuKien();
        }

        private void dgvSuKien_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            rowSK = e.RowIndex;
        }

        private void btnVephai_Click(object sender, EventArgs e)
        {
            if (rowSK == -1)
            {
                MessageBox.Show("Cần chọn mã sự kiện", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String sk = dgvSuKien.Rows[rowSK].Cells[0].Value.ToString();
                String vp = txtVePhai.Text;
                if (vp.Equals(""))
                {
                    txtVePhai.Text = sk;
                }
                else
                {
                    if(MessageBox.Show("Bạn muốn thay đổi vế phải?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtVePhai.Text = sk;
                    }
                }
                rowSK = -1;
            }
            
        }

        private void btnVeTrai_Click(object sender, EventArgs e)
        {
            if (rowSK == -1)
            {
                MessageBox.Show("Cần chọn mã sự kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                String sk = dgvSuKien.Rows[rowSK].Cells[0].Value.ToString();
                String vt = txtVeTrai.Text;
                if (vt.Contains(sk))
                {
                    MessageBox.Show("Sự kiện này đã có, Không thể thêm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (vt.Equals(""))
                        vt = sk;
                    else
                        vt = vt + "^" + sk;
                    txtVeTrai.Text = vt;
                }
                rowSK = -1;
            }
        }

        private void dgvLuat_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaLuat.Text = dgvLuat.Rows[index].Cells[0].Value.ToString();
                txtVeTrai.Text = dgvLuat.Rows[index].Cells[1].Value.ToString();
                txtVePhai.Text = dgvLuat.Rows[index].Cells[2].Value.ToString();
            }
           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearTxt();
        }
        private void clearTxt()
        {
            txtVeTrai.Clear();
            txtVePhai.Clear();
            txtMaLuat.Clear();
        }
        private void btnThemLuat_Click(object sender, EventArgs e)
        {
            if(txtMaLuat.Text.Equals("")||txtVePhai.Text.Equals("")|| txtVeTrai.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(obj.check(txtVeTrai.Text, txtVePhai.Text))
                {
                    try
                    {
                        obj.addLuat(txtMaLuat.Text, txtVeTrai.Text, txtVePhai.Text);
                        TapLuat_Load(sender, e);
                        clearTxt();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("PRIMARY KEY"))
                        {
                            MessageBox.Show("Không thêm được mã luật trùng nhau", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thêm được. Luật này đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuaLuat_Click(object sender, EventArgs e)
        {
            if (txtMaLuat.Text.Equals("") || txtVePhai.Text.Equals("") || txtVeTrai.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (obj.checkMaLuat(txtMaLuat.Text))
                {
                    if(obj.check(txtVeTrai.Text, txtVePhai.Text))
                    {
                        obj.updateLuat(txtMaLuat.Text, txtVeTrai.Text, txtVePhai.Text);
                        TapLuat_Load(sender, e);
                        clearTxt();
                    }
                    else
                    {
                        MessageBox.Show("Không sửa được. Luật này đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã luật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoaLuat_Click(object sender, EventArgs e)
        {
            if (txtMaLuat.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống mã luật", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (obj.checkMaLuat(txtMaLuat.Text))
                {
                    if(MessageBox.Show("Bạn có chắc chắn muốn xóa luật có mã: "+ txtMaLuat.Text,"Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        obj.deleteLuat(txtMaLuat.Text);
                        TapLuat_Load(sender, e);
                        clearTxt();
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã luật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
