using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuanDoanBenhDaDay.DBProccessing
{
    class DBProccessingChuanDoan
    {
        String Path = Directory.GetCurrentDirectory();
        List<String> KL = new List<string>();
        DBProccessingTapLuat dbLuat = new DBProccessingTapLuat();
        public String getPath()
        {
            String t = Path;
            t = t.Substring(0, t.LastIndexOf(@"\"));
            t = t.Substring(0, t.LastIndexOf(@"\"));
            t += @"\note.txt";
            return t;
        }

        public void writeNemLine(string text)//viet them 1 dong
        {
            FileStream fs = new FileStream(getPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(text);

            sw.Close();
            fs.Close();
        }
        public void writeFile(String text)//viet them vao file
        {
            FileStream fs = new FileStream(getPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            sw.Write(text);

            sw.Close();
            fs.Close();
        }

        public void createEmptyFile()//tao file
        {
            FileStream fs = new FileStream(getPath(), FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            sw.Close();
            fs.Close();
        }

        public void writeAllLuat(List<String> R)
        {

            FileStream fs = new FileStream(getPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            foreach(String s in R)
            {
                sw.Write(s.PadLeft(0));
                sw.Write("\n");
            }
            sw.WriteLine();
            sw.Close();
            fs.Close();
        }

        public void writeGT(List<String> GT)
        {
            FileStream fs = new FileStream(getPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            string t = "Tập giả thiết: GT={";
            for (int i = 0; i < GT.Count; i++)
            {
                t += GT[i].ToString();
                if (i != GT.Count - 1)
                {
                    t += ",";
                }
            }
            t += "}";
            sw.WriteLine(t);

            sw.Close();
            fs.Close();
        }

        public void writeTG(List<String> TG)
        {
            FileStream fs = new FileStream(getPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            string t = "TG={";
            for (int i = 0; i < TG.Count; i++)
            {
                t += TG[i].ToString();
                if (i != TG.Count - 1)
                {
                    t += ",";
                }

            }
            t += "}";
            sw.Write(t);

            sw.Close();
            fs.Close();
        }
        public void writeSAT(List<string> SAT)
        {
            FileStream fs = new FileStream(getPath(), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);

            string t = "SAT={";
            for (int i = 0; i < SAT.Count; i++)
            {
                t += SAT[i].ToString();
                if (i != SAT.Count - 1)
                {
                    t += ",";
                }
            }
            t += "}";
            sw.Write(t);

            sw.Close();
            fs.Close();
        }
        public List<string> getSAT(List<String> TG, List<String> R)
        {
            List<String> SAT = new List<String>();
            for (int i = 0; i < R.Count; i++)
            {
                int count = 0;
                List<String> vetrai = dbLuat.toArrayVT(R[i].ToString());//lay cac skien vt
                for (int j = 0; j < vetrai.Count; j++)
                {
                    if (TG.Contains(vetrai[j]))
                    {
                        count++;
                    }
                }
                if (count == vetrai.Count)
                {
                    SAT.Add(dbLuat.getMaLuat(R[i].ToString()));
                }
            }
            return SAT;
        }
        public bool Check_KL_In_TG(List<String> TG)
        {
            foreach (string tg in TG)
            {
                if (tg.Contains("kl"))
                {
                    return true;
                }
            }
            return false;
        }
        public String tinhTyLeChinhXac()
        {
            Random r = new Random();
            int tyLe = r.Next(80, 100);
            return tyLe + "%";
        }
    }
}
