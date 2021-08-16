using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ChuanDoanBenhDaDay
{
    public partial class SuKien : Form
    {
        DBProccessing.DBProccessingSuKien data = new DBProccessing.DBProccessingSuKien();
        public SuKien()
        {
            InitializeComponent();
        }

        private void SuKien_Load(object sender, EventArgs e)
        {
            dgvSuKien.DataSource = data.showSukien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaSK.Text == "")
                {
                    MessageBox.Show("Mã sự kiện không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtMoTa.Text == "")
                {
                    MessageBox.Show("Mô tả không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                data.InsertSuKien(txtMaSK.Text, txtMoTa.Text);
                SuKien_Load(sender, e);
                ClearTextBox();
            }
            catch(Exception ex)
            {
                if(ex.Message.Contains("duplicate key"))
                {
                    MessageBox.Show("Mã sự kiện trùng nhau", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSK.Text == "")
                {
                    MessageBox.Show("Mã sự kiện không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (data.CheckMaSuKien(txtMaSK.Text))
                {
                    if (data.check(txtMaSK.Text))
                    {
                        data.DeleteSuKien(txtMaSK.Text);
                        SuKien_Load(sender, e);
                        ClearTextBox();
                    }
                    else
                    {
                        MessageBox.Show("Sự kiện đã tồn tại ở tập luật không được xoá", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Mã sự kiện không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }        
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSK.Text == "")
                {
                    MessageBox.Show("Mã sự kiện không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtMoTa.Text == "")
                {
                    MessageBox.Show("Mô tả không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (data.CheckMaSuKien(txtMaSK.Text))
                {
                    
                        data.UpdateSuKien(txtMaSK.Text, txtMoTa.Text);
                        SuKien_Load(sender, e);
                        ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Mã sự kiện không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTrangTextBox_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            txtMaSK.Clear();
            txtMoTa.Clear();
            ActiveControl = txtMaSK;
        }

        private void dgvSuKien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                txtMaSK.Text = dgvSuKien.Rows[row].Cells[0].Value.ToString();
                txtMoTa.Text = dgvSuKien.Rows[row].Cells[1].Value.ToString();
            }
        }
    }
}
