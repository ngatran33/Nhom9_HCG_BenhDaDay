using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuanDoanBenhDaDay.DBProccessing;

namespace ChuanDoanBenhDaDay
{
    public partial class ChuanDoan : Form
    {
        DBProccessingSuKien dbSuKien = new DBProccessingSuKien();
        List<String> GT = new List<string>();
        List<String> TG = new List<string>();
        List<String> SAT = new List<string>();
        List<String> R = new List<string>();
        DBProccessingTapLuat dbLuat = new DBProccessingTapLuat();
        DBProccessingChuanDoan dbChuanDoan = new DBProccessingChuanDoan();
        int rows_dgvallsk;
        int rows_dgvSKChon;

        public ChuanDoan()
        {
            InitializeComponent();
        }

        private void dgvAllSK_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            rows_dgvallsk = e.RowIndex;
        }

        private void dgvSkChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rows_dgvSKChon = e.RowIndex;
        }

        private void ChuanDoan_Load(object sender, EventArgs e)
        {
            dgvAllSuKien.DataSource = dbSuKien.showSukien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (rows_dgvallsk >= 0 && dgvAllSuKien.Rows.Count > 0)
                {
                    string maSK = dgvAllSuKien.Rows[rows_dgvallsk].Cells[0].Value.ToString();
                    string moTa = dgvAllSuKien.Rows[rows_dgvallsk].Cells[1].Value.ToString();

                    if (GT.Contains(maSK) == false)
                    {
                        dgvSkChon.Rows.Add(maSK, moTa);
                        GT.Add(maSK);

                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sự kiện này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bạn chưa chọn triệu chứng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Xóa listKetQua và picturebox khi xóa đi sự kiện
            listKetqua.Items.Clear();

            if (rows_dgvSKChon >= 0 && rows_dgvSKChon < dgvSkChon.Rows.Count)
            {
                //Loại sự kiện khỏi tập GT
                for (int i = 0; i < GT.Count; i++)
                {
                    string maSK = dgvSkChon.Rows[rows_dgvSKChon].Cells[0].Value.ToString();
                    if (GT[i].ToString().Contains(maSK))
                    {
                        GT.RemoveAt(i);
                        break;
                    }
                }

                dgvSkChon.Rows.RemoveAt(rows_dgvSKChon);

                //gán row_dgv_XacNhanSuKien = -1 để sau khi xóa sự kiện đã chọn thì phải chọn tiếp mới xóa được
                rows_dgvSKChon = -1;
            }
            //btn_Refresh_Click(sender, e);
        }

        private void txtTim_textchanged(object sender, EventArgs e)
        {
            dgvAllSuKien.DataSource = dbSuKien.GetDataForDgv_SuKien2(txtTim.Text);
        }

        private void btnXoaTim_Click(object sender, EventArgs e)
        {
            txtTim.Text = "";
            txtTim.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ChuanDoan_Load(sender, e);
            dgvSkChon.Rows.Clear();
            listKetqua.Items.Clear();

            GT.Clear();
            TG.Clear();
        }

        private void btnChuanDoan_Click(object sender, EventArgs e)
        {
            if (dgvSkChon.Rows.Count > 0)
            {
                listKetqua.Items.Clear();
                R = dbLuat.getAllLuat();

                dbChuanDoan.createEmptyFile();//tao file
                dbChuanDoan.writeNemLine("Tập Luật: ");
                dbChuanDoan.writeAllLuat(R);//in luat
                dbChuanDoan.writeGT(GT);
                dbChuanDoan.writeNemLine("Bước 1: ");

                TG.Clear();
                foreach (String s in GT)
                {
                    TG.Add(s);
                }

                dbChuanDoan.writeNemLine("Tập trung gian: ");
                dbChuanDoan.writeTG(TG);

                SAT = dbChuanDoan.getSAT(TG, R);
                dbChuanDoan.writeNemLine("");
                dbChuanDoan.writeSAT(SAT);
                dbChuanDoan.writeNemLine("");

                int n = 0;
                while (!dbChuanDoan.Check_KL_In_TG(TG) && SAT.Count > 0)
                {
                    n++;
                    dbChuanDoan.writeNemLine("-------Lần lặp " + n + "-------");
                    dbChuanDoan.writeNemLine("Bước 2: ");
                    dbChuanDoan.writeNemLine("Lấy luật " + SAT[0].ToString() + " Trong tập SAT: " + dbLuat.getLuatbyMaLuat(SAT[0].ToString()));
                    dbChuanDoan.writeNemLine("Ta có: ");
                    TG.Add(dbLuat.getVPbyML(SAT[0].ToString()));//them sk vao tap TG
                    dbChuanDoan.writeFile("+ Thêm vế phải của luật " + SAT[0].ToString() + " Vào tập TG");
                    dbChuanDoan.writeTG(TG);
                    dbChuanDoan.writeNemLine("");

                    //Xoa luat vua xet khoi R
                    for (int i = 0; i < R.Count; i++)
                    {
                        if (dbLuat.getMaLuat(R[i].ToString()) == SAT[0].ToString())
                        {
                            R.RemoveAt(i);
                        }
                    }

                    dbChuanDoan.writeNemLine("+ Loại luật " + SAT[0].ToString() + @" ra khỏi tập R= R\{" + SAT[0].ToString() + "}");

                    SAT = dbChuanDoan.getSAT(TG, R);//Loc lai tap SAT
                    dbChuanDoan.writeFile("Lọc lại tập SAT từ tập TG và R: ");
                    dbChuanDoan.writeSAT(SAT);
                    dbChuanDoan.writeNemLine("");

                    //buoc 3:
                    dbChuanDoan.writeNemLine("Bước 3: ");
                    if (dbChuanDoan.Check_KL_In_TG(TG))
                    {
                        dbChuanDoan.writeFile("Trong tập TG có kết luận, Dừng lặp: ");
                        dbChuanDoan.writeTG(TG);
                        dbChuanDoan.writeNemLine("");
                    }
                    else if (!dbChuanDoan.Check_KL_In_TG(TG))
                    {
                        dbChuanDoan.writeFile("Trong tập TG không có kết luận: ");
                        dbChuanDoan.writeTG(TG);
                        dbChuanDoan.writeNemLine("");
                    }
                    else if (SAT.Count == 0)
                    {
                        dbChuanDoan.writeNemLine("Tập SAT rỗng, Dừng lăp: ");
                    }
                    else
                    {
                        dbChuanDoan.writeFile("Tập SAT vẫn con luật: ");
                        dbChuanDoan.writeSAT(SAT);
                        dbChuanDoan.writeNemLine("");
                    }
                }
                if (dbChuanDoan.Check_KL_In_TG(TG))
                {
                    String kq = "";
                    foreach (String s in TG)
                    {
                        if (s.Contains("kl"))
                        {
                            String maSk = s.Trim();
                            kq = dbSuKien.GetMoTaByMaSuKien(maSk);
                            listKetqua.Items.Add("-------KẾT QUẢ------");
                            listKetqua.Items.Add("Mắc bệnh: " + kq);
                            listKetqua.Items.Add("Tỷ lệ chính xác: " + dbChuanDoan.tinhTyLeChinhXac());
                            listKetqua.Items.Add("----------------------------------------------------------");
                            break;
                        }
                    }
                    dbChuanDoan.writeNemLine("------------------------------------------------------------------------------");
                    dbChuanDoan.writeNemLine("-----Các sự kiện đã chọn-----");
                    for (int i = 0; i < dgvSkChon.Rows.Count; i++)
                    {
                        dbChuanDoan.writeNemLine(dgvSkChon.Rows[i].Cells[1].Value.ToString());
                    }
                    dbChuanDoan.writeNemLine("-----Kết quả-----");
                    dbChuanDoan.writeNemLine("=====>" + kq);

                    TG.Clear();
                }
                else
                {
                    listKetqua.Items.Add("===> Chưa thể suy diễn.");
                    listKetqua.Items.Add("Hãy chọn thêm triệu chứng.");
                    dbChuanDoan.writeNemLine("------------------------------------------------------------------------------");
                    dbChuanDoan.writeNemLine("-----Các sự kiện đã chọn-----");
                    for (int i = 0; i < dgvSkChon.Rows.Count; i++)
                    {
                        dbChuanDoan.writeNemLine(dgvSkChon.Rows[i].Cells[1].Value.ToString());
                    }
                    dbChuanDoan.writeNemLine("-----Kết quả-----");
                    dbChuanDoan.writeNemLine("===> Chưa thể suy diễn, hãy chọn thêm triệu chứng");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sự kiện", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
