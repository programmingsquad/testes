using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private static void Upload(string ftpServer, string userName, string password, string filename)
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                client.Credentials = new System.Net.NetworkCredential(userName, password);
                client.DownloadFile(@"ftp://ftp.thecybersheep.com/s.txt", @"C:\Users\Utilizador\Desktop\as\s.txt");
            }
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            Upload("ftp://ftp.thecybersheep.com/", "admin@thecybersheep.com", "admin", @"C:\Users\Utilizador\Desktop\s.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
