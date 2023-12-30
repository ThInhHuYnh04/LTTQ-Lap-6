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

namespace Bai_1
{
    public partial class Form1 : Form
    {
        
        Form2 form2;
        List<WebClient> webClientList;
        public Form1()
        {
            InitializeComponent();
            webClientList = new List<WebClient>();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            DialogResult res = form2.ShowDialog();
            WebClient client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            string FileName = Path.GetFileName(form2.uri.AbsolutePath);
            client.DownloadFileAsync(form2.uri, form2.path+"/"+FileName,form2.uri.ToString());
            ListViewItem item = new ListViewItem(form2.path);
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "0" }); 
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "0%" }); 
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Downloading" });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = form2.uri.ToString() });
            lv_download.Items.Add(item);
            webClientList.Add(client);
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            var s = sender as WebClient;
            if (lv_download.Items.Count > 0)
            {
                foreach (ListViewItem item in lv_download.Items)
                {
                    if (item.SubItems[4].Text == e.UserState.ToString())
                    {
                        lv_download.Invoke((MethodInvoker)delegate {
                            item.SubItems[1].Text = e.BytesReceived.ToString() + "/" + e.TotalBytesToReceive;
                            item.SubItems[2].Text = e.ProgressPercentage.ToString() + "%";
                        });
                    }    
                }
            }

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            ListViewItem item = lv_download.SelectedItems[0];
            int index = lv_download.SelectedItems.IndexOf(item);
            if(index < webClientList.Count)
            {
                webClientList[index].CancelAsync();
                MessageBox.Show("Hủy thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Chọn một để hủy", "Lưu ý", MessageBoxButtons.OK);
            }
        }
    }
}
