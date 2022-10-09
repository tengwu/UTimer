namespace UTimer
{
    partial class AddTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskForm));
            this.tbTaskContent = new System.Windows.Forms.TextBox();
            this.tbTaskTime = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTaskContent
            // 
            resources.ApplyResources(this.tbTaskContent, "tbTaskContent");
            this.tbTaskContent.Name = "tbTaskContent";
            // 
            // tbTaskTime
            // 
            resources.ApplyResources(this.tbTaskTime, "tbTaskTime");
            this.tbTaskTime.Name = "tbTaskTime";
            // 
            // btnYes
            // 
            resources.ApplyResources(this.btnYes, "btnYes");
            this.btnYes.Name = "btnYes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // AddTaskForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbTaskTime);
            this.Controls.Add(this.tbTaskContent);
            this.Controls.Add(this.btnYes);
            this.Name = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTaskContent;
        private System.Windows.Forms.TextBox tbTaskTime;
        private System.Windows.Forms.Button btnYes;
    }
}