namespace Bai_3
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
            this.cb_view = new System.Windows.Forms.ToolStripDropDownButton();
            this.detailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_about = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_exit = new System.Windows.Forms.ToolStripButton();
            this.btn_opt = new System.Windows.Forms.ToolStripDropDownButton();
            this.opt_C = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_D = new System.Windows.Forms.ToolStripMenuItem();
            this.up_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tb_path = new System.Windows.Forms.ToolStripTextBox();
            this.lv_menu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cb_view,
            this.toolStripSeparator1,
            this.btn_about,
            this.toolStripSeparator2,
            this.btn_exit,
            this.btn_opt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(724, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cb_view
            // 
            this.cb_view.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailToolStripMenuItem,
            this.iconToolStripMenuItem});
            this.cb_view.Name = "cb_view";
            this.cb_view.Size = new System.Drawing.Size(55, 24);
            this.cb_view.Text = "View";
            // 
            // detailToolStripMenuItem
            // 
            this.detailToolStripMenuItem.Name = "detailToolStripMenuItem";
            this.detailToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.detailToolStripMenuItem.Text = "Detail";
            this.detailToolStripMenuItem.Click += new System.EventHandler(this.detailToolStripMenuItem_Click);
            // 
            // iconToolStripMenuItem
            // 
            this.iconToolStripMenuItem.Name = "iconToolStripMenuItem";
            this.iconToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.iconToolStripMenuItem.Text = "Icon";
            this.iconToolStripMenuItem.Click += new System.EventHandler(this.iconToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_about
            // 
            this.btn_about.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_about.Image = ((System.Drawing.Image)(resources.GetObject("btn_about.Image")));
            this.btn_about.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(54, 24);
            this.btn_about.Text = "About";
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_exit
            // 
            this.btn_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(37, 24);
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_opt
            // 
            this.btn_opt.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_opt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_opt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opt_C,
            this.opt_D});
            this.btn_opt.Image = ((System.Drawing.Image)(resources.GetObject("btn_opt.Image")));
            this.btn_opt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_opt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_opt.Name = "btn_opt";
            this.btn_opt.Size = new System.Drawing.Size(41, 24);
            this.btn_opt.Text = "C:\\";
            // 
            // opt_C
            // 
            this.opt_C.AutoToolTip = true;
            this.opt_C.Name = "opt_C";
            this.opt_C.Size = new System.Drawing.Size(112, 26);
            this.opt_C.Text = "C:\\";
            this.opt_C.Click += new System.EventHandler(this.opt_C_Click);
            // 
            // opt_D
            // 
            this.opt_D.Name = "opt_D";
            this.opt_D.Size = new System.Drawing.Size(112, 26);
            this.opt_D.Text = "D:\\";
            this.opt_D.Click += new System.EventHandler(this.opt_D_Click);
            // 
            // up_btn
            // 
            this.up_btn.Image = ((System.Drawing.Image)(resources.GetObject("up_btn.Image")));
            this.up_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.up_btn.Name = "up_btn";
            this.up_btn.Size = new System.Drawing.Size(52, 24);
            this.up_btn.Text = "Up";
            this.up_btn.Click += new System.EventHandler(this.up_btn_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.up_btn,
            this.tb_path});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(724, 27);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tb_path
            // 
            this.tb_path.AutoSize = false;
            this.tb_path.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(400, 27);
            // 
            // lv_menu
            // 
            this.lv_menu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_menu.FullRowSelect = true;
            this.lv_menu.GridLines = true;
            this.lv_menu.HideSelection = false;
            this.lv_menu.Location = new System.Drawing.Point(0, 54);
            this.lv_menu.Name = "lv_menu";
            this.lv_menu.Size = new System.Drawing.Size(724, 438);
            this.lv_menu.TabIndex = 2;
            this.lv_menu.UseCompatibleStateImageBehavior = false;
            this.lv_menu.View = System.Windows.Forms.View.Details;
            this.lv_menu.DoubleClick += new System.EventHandler(this.lv_menu_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filename";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Last modified";
            this.columnHeader4.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 492);
            this.Controls.Add(this.lv_menu);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_about;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_exit;
        private System.Windows.Forms.ToolStripDropDownButton cb_view;
        private System.Windows.Forms.ToolStripMenuItem detailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iconToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton up_btn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ListView lv_menu;
        private System.Windows.Forms.ToolStripDropDownButton btn_opt;
        private System.Windows.Forms.ToolStripMenuItem opt_C;
        private System.Windows.Forms.ToolStripMenuItem opt_D;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripTextBox tb_path;
    }
}

