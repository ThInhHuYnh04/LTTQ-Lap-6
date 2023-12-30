using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class Form2 : Form
    {
        public string path { get; set; }
        public string url  { get; set; }
        
        public Uri uri
        {
            get
            {
                return new Uri(url) ;
            }
        }
        
        public Form2()
        {
            InitializeComponent();
            this.FormClosing += Form2_FormClosing;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!string.IsNullOrEmpty(tb_saveto.Text) && !string.IsNullOrEmpty(tb_url.Text))
            {
                path = tb_saveto.Text;
                url = tb_url.Text;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult res = folderBrowserDialog1.ShowDialog(this);
            if(res == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
                tb_saveto.Text = path;
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
