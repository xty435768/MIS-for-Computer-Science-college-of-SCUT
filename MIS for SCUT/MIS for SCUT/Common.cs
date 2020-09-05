using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_for_SCUT
{
    public class Common
    {
        public enum UserType
        {
            STUDENT = 0,
            TEACHER = 1,
            ADMIN = 2,
        };

        public static void ShowError(string title,string text)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInfo(string title,string text)
        {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowChoice(string title,string text, MessageBoxIcon mbi = MessageBoxIcon.Question, MessageBoxButtons mbb = MessageBoxButtons.YesNo)
        {
            return MessageBox.Show(text, title, mbb, mbi);
        }

        public static string GetSaveFilePath(string filter)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = filter;
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                return sfd.FileName.ToString();
            }
            return null;
        }

        public static string GetOpenFilePath(string filter)
        {
            OpenFileDialog sfd = new OpenFileDialog();
            sfd.Filter = filter;
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                return sfd.FileName.ToString();
            }
            return null;
        }

        public static DataTable ReadCSV(string path)
        {
            try
            {
                int intColCount = 0;
                bool blnFlag = true;
                DataColumn mydc;
                DataRow mydr;
                DataTable dt = new DataTable();
                string strline;
                string[] aryline;
                StreamReader mysr = new StreamReader(path, Encoding.Default);

                while ((strline = mysr.ReadLine()) != null)
                {
                    aryline = strline.Split(new char[] { ',' });
                    if (blnFlag)
                    {
                        blnFlag = false;
                        intColCount = aryline.Length;
                        int col = 0;
                        for (int i = 0; i < aryline.Length; i++)
                        {
                            col = i + 1;
                            mydc = new DataColumn(col.ToString());
                            dt.Columns.Add(mydc);
                        }
                    }
                    mydr = dt.NewRow();
                    for (int i = 0; i < intColCount; i++)
                    {
                        mydr[i] = aryline[i];
                    }
                    dt.Rows.Add(mydr);
                }
                mysr.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Common.ShowError("Read CSV Failed!", "Read CSV Failed!\n" + ex.Message);
                
                return null;
            }

        }

        public static Color GetColor(string s)
        {
            switch (s)
            {
                case "Ready":
                    return Color.Goldenrod;
                case "Failed":
                    return Color.Crimson;
                case "Done":
                    return Color.Green;
                default:
                    return Color.Black;
            }
        }

        public static string ShowInput(string prompt,string head,string second_prompt = "")
        {
            using (InputDialog id = new InputDialog(head, prompt,second_prompt))
            {
                return id.ShowDialog() == DialogResult.OK ? id.result : null;
            }
        }

    }
}
