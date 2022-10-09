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
    public partial class AddTaskForm : Form
    {
        public String taskName = "";
        public int taskTime = 10;

        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.taskName = this.tbTaskContent.Text;
            String time = this.tbTaskTime.Text;
            if(time != "")
            {
                this.taskTime = int.Parse(this.tbTaskTime.Text);
            }
        }
    }
}
