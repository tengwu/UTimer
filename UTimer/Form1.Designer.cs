namespace UTimer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ntficon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntficon
            // 
            this.ntficon.ContextMenuStrip = this.cmenustrip;
            this.ntficon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntficon.Icon")));
            this.ntficon.Text = "notifyIcon1";
            this.ntficon.Visible = true;
            this.ntficon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntficon_MouseDoubleClick);
            // 
            // cmenustrip
            // 
            this.cmenustrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.cmenustrip.Name = "cmenustrip";
            this.cmenustrip.Size = new System.Drawing.Size(109, 28);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 399);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.cmenustrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ntficon;
        private System.Windows.Forms.ContextMenuStrip cmenustrip;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

