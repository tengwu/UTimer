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
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.lbCountDown = new System.Windows.Forms.Label();
            this.lbTask = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.cmenustrip.Size = new System.Drawing.Size(117, 34);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(116, 30);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(9, 10);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(61, 27);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "添加事件";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(74, 10);
            this.btnDeleteTask.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(61, 27);
            this.btnDeleteTask.TabIndex = 2;
            this.btnDeleteTask.Text = "删除事件";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCountDown
            // 
            this.lbCountDown.AutoSize = true;
            this.lbCountDown.Font = new System.Drawing.Font("宋体", 22F);
            this.lbCountDown.Location = new System.Drawing.Point(330, 10);
            this.lbCountDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(0, 44);
            this.lbCountDown.TabIndex = 3;
            // 
            // lbTask
            // 
            this.lbTask.FormattingEnabled = true;
            this.lbTask.ItemHeight = 12;
            this.lbTask.Location = new System.Drawing.Point(9, 42);
            this.lbTask.Margin = new System.Windows.Forms.Padding(2);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(357, 364);
            this.lbTask.TabIndex = 4;
            this.lbTask.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 422);
            this.Controls.Add(this.lbTask);
            this.Controls.Add(this.lbCountDown);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnAddTask);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "UTimer";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.cmenustrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ntficon;
        private System.Windows.Forms.ContextMenuStrip cmenustrip;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.ListBox lbTask;
        private System.Windows.Forms.Timer timer1;
    }
}

