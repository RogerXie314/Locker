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

namespace Locker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void file_Browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog();
            filename.InitialDirectory = Application.StartupPath;
            filename.Filter = "All files(*.*)|*.*";
            filename.FilterIndex = 2;
            filename.RestoreDirectory = true;

            if (filename.ShowDialog() == DialogResult.OK)
            { textBox.Text = filename.FileName.ToString(); }
        }

        private void share_read_Click(object sender, EventArgs e)
        {
            String filenameRead = textBox.Text;
            
            if (File.Exists(filenameRead))
            {try
                { FileStream s1 = new FileStream(filenameRead, FileMode.Open, FileAccess.Read, FileShare.Read);
                    //s1.Close();
                    share_write.Enabled = false;
                    Share_rw.Enabled = false;
                    Lock.Enabled = false;

                }
             catch(Exception)
                {
                   //WriteErrLog("error",error);
                    return; }
             
            }
        }

        private void share_write_Click(object sender, EventArgs e)
        {
            String filenameWrite = textBox.Text;
            if (File.Exists(filenameWrite))
            {
                try
                { FileStream s2 = new FileStream(filenameWrite, FileMode.Open, FileAccess.Read, FileShare.Write);
                    share_read.Enabled = false;
                    Share_rw.Enabled = false;
                    Lock.Enabled = false;
                }
                catch (Exception
                )
                {
                    //WriteErrLog("error", error);
                    return; }
            }
            
        }


        private void Share_rw_Click(object sender, EventArgs e)
        {
            String filerw = textBox.Text;
            if (File.Exists(filerw))
            {
                try
                {
                    FileStream sp = new FileStream(filerw, FileMode.Open,FileAccess.Read,FileShare.ReadWrite);
                    share_read.Enabled = false;
                    share_write.Enabled = false;
                    Lock.Enabled = false;

                }
                catch (Exception)
                {
                    //WriteErrLog("error", error);
                    return;
                }
            }

        }

        public static void WriteErrLog(string errTitle, Exception ex)
        {
            string path = System.Windows.Forms.Application.StartupPath + "\\错误日志.txt";

            if (!File.Exists(path))
            {
                try { File.Create(path).Close(); }
                //File.Create(path).Close();
                catch (Exception)
                { return; }
            }

            StringBuilder strBuilderErrorMessage = new StringBuilder();

            strBuilderErrorMessage.Append("________________________________________________________________________________________________________________\r\n");
            strBuilderErrorMessage.Append("日期:" + System.DateTime.Now.ToString() + "\r\n");
            strBuilderErrorMessage.Append("错误标题:" + errTitle + "\r\n");
            strBuilderErrorMessage.Append("错误信息:" + ex.Message + "\r\n");
            strBuilderErrorMessage.Append("错误内容:" + ex.StackTrace + "\r\n");
            strBuilderErrorMessage.Append("________________________________________________________________________________________________________________\r\n");
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(strBuilderErrorMessage);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception)
            { return; }
        }

        private void Lock_Click(object sender, EventArgs e)
        {
            String Lockfile = textBox.Text;
            if (File.Exists(Lockfile))
            {
                try
                {
                    FileStream sp = new FileStream(Lockfile, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                    share_read.Enabled = false;
                    share_write.Enabled = false;
                    Share_rw.Enabled = false;
                }
                catch (Exception error)
                {
                    WriteErrLog("error", error);
                    return;
                }
            }

        }
    }
}
