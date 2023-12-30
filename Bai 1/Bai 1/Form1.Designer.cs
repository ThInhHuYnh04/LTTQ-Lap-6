namespace Bai_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_download = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_stop = new System.Windows.Forms.ToolStripButton();
            this.lv_download = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_download,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.btn_stop});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(988, 85);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_download
            // 
            this.btn_download.Image = ((System.Drawing.Image)(resources.GetObject("btn_download.Image")));
            this.btn_download.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_download.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(146, 82);
            this.btn_download.Text = "Add new downLoad";
            this.btn_download.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 82);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 85);
            // 
            // btn_stop
            // 
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(115, 82);
            this.btn_stop.Text = "Stop download";
            this.btn_stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lv_download
            // 
            this.lv_download.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.size,
            this.progress,
            this.status,
            this.url});
            this.lv_download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_download.FullRowSelect = true;
            this.lv_download.GridLines = true;
            this.lv_download.HideSelection = false;
            this.lv_download.Location = new System.Drawing.Point(0, 85);
            this.lv_download.Name = "lv_download";
            this.lv_download.Size = new System.Drawing.Size(988, 418);
            this.lv_download.TabIndex = 1;
            this.lv_download.UseCompatibleStateImageBehavior = false;
            this.lv_download.View = System.Windows.Forms.View.Details;
            // 
            // fileName
            // 
            this.fileName.Text = "FIle name";
            this.fileName.Width = 170;
            // 
            // size
            // 
            this.size.Text = "Size";
            this.size.Width = 150;
            // 
            // progress
            // 
            this.progress.Text = "Progress";
            this.progress.Width = 80;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 100;
            // 
            // url
            // 
            this.url.Text = "URL";
            this.url.Width = 300;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 503);
            this.Controls.Add(this.lv_download);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader progress;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader url;
        public System.Windows.Forms.ListView lv_download;
        private System.Windows.Forms.ToolStripButton btn_download;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_stop;
    }
}

