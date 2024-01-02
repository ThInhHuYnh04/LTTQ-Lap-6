using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        string currentPath;
        ImageList imageList;
        public Form1()
        {
            InitializeComponent();
            imageList = new ImageList();
            imageList.ImageSize = new System.Drawing.Size(32, 32);
            lv_menu.LargeImageList = imageList;
            currentPath = "C:\\";
            tb_path.Text = currentPath;
            PopulateListView("C:\\");
        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv_menu.View = View.Details;
        }

        private void iconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lv_menu.View = View.LargeIcon;
        }
        private void PopulateListView(string path)
        {
            try
            {
                lv_menu.Items.Clear();
                imageList.Images.Clear();

                if (path != Path.GetPathRoot(path))
                {
                    DirectoryInfo parentDir = Directory.GetParent(path);
                    ListViewItem parentItem = new ListViewItem(new string[]
                    {
                        "..",
                        "<DIR>",
                        "",
                        parentDir.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")
                    });
                    parentItem.Tag = parentDir.FullName;
                    lv_menu.Items.Add(parentItem);
                }

                foreach (string directory in Directory.GetDirectories(path))
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(directory);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        dirInfo.Name,
                        "<DIR>",
                        "",
                        dirInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss")
                    });
                    item.Tag = directory;
                    lv_menu.Items.Add(item);
                }

                foreach (string file in Directory.GetFiles(path))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    ListViewItem item = new ListViewItem()
                    {
                        Text = fileInfo.Name,
                    };
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = fileInfo.Extension });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = FormatSize(fileInfo.Length).ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = fileInfo.LastWriteTime.ToString("yyyy-MM-dd HH:mm:ss") });
                    item.Tag = file;
                    lv_menu.Items.Add(item);
                    imageList.Images.Add(Icon.ExtractAssociatedIcon(file).ToBitmap());
                }

                // Cập nhật biến đường dẫn thư mục hiện tại
                currentPath = path;
                tb_path.Text = currentPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string FormatSize(long size)
        {
            string[] suffixes = { "B", "KB", "MB", "GB", "TB" };
            int suffixIndex = 0;
            double formattedSize = size;

            while (formattedSize >= 1024 && suffixIndex < suffixes.Length - 1)
            {
                formattedSize /= 1024;
                suffixIndex++;
            }

            return $"{formattedSize:0.##} {suffixes[suffixIndex]}";
        }

        private void lv_menu_DoubleClick(object sender, EventArgs e)
        {
            if (lv_menu.SelectedItems.Count > 0)
            {
                string selectedPath = (string)lv_menu.SelectedItems[0].Tag;
                string type = lv_menu.SelectedItems[0].SubItems[1].Text;
              
                if (type == "<DIR>")
                {
                    PopulateListView(selectedPath);
                }
                else
                {
                    Process.Start(selectedPath);
                }
            }
        }

        private void up_btn_Click(object sender, EventArgs e)
        {
            if (currentPath != Path.GetPathRoot(currentPath))
            {
                string parentPath = Directory.GetParent(currentPath).FullName;
                tb_path.Text = currentPath;
                PopulateListView(parentPath);
            }
        }

        private void opt_D_Click(object sender, EventArgs e)
        {
            currentPath = "D:\\";
            btn_opt.Text = "D:\\";
            PopulateListView(currentPath);
        }

        private void opt_C_Click(object sender, EventArgs e)
        {
            currentPath = "C:\\";
            btn_opt.Text = "C:\\";
            PopulateListView(currentPath);
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
