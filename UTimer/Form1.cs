using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTimer
{
    public partial class MainForm : Form
    {
        List<String> TaskList = null;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        // 自己添加的函数start
        /**
         * 初始化变量
         **/
        private void Init()
        {
            TaskList = new List<string>();
        }
        /**
         * 向用户发送消息
         **/
        private void SendMessage(String sTitle, String sMsg)
        {
            this.ntficon.ShowBalloonTip(1, sTitle, sMsg, ToolTipIcon.Info);
        }
        // 自己添加的函数end

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ntficon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
            {
                this.Visible = false;
            }
            else
            {
                this.Visible = true;
                this.WindowState = FormWindowState.Normal; // 需要设置WindowState，因为最小化的时候已经将窗口设置为Minimized
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /**
         * 窗口大小改变时
         * 主要用于最小化时让窗口隐藏到后台
         **/
        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm();
            addTaskForm.ShowDialog();
            if (addTaskForm.DialogResult == DialogResult.OK)
            {
                TaskList.Add(addTaskForm.taskName);
                lbTask.Items.Add(addTaskForm.taskName);
                addTaskForm.Close();
            }
        }
    }
}
