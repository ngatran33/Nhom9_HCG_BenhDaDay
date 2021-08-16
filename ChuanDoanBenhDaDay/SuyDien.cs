using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanDoanBenhDaDay
{
    public partial class SuyDien : Form
    {
        public SuyDien()
        {
            InitializeComponent();
        }

        private void SuyDien_Load(object sender, EventArgs e)
        {
            StreamReader doc_file = new StreamReader("../../note.txt");
            rtb_cacbuoc.Text = doc_file.ReadToEnd();
            doc_file.Close();
        }
    }
}
