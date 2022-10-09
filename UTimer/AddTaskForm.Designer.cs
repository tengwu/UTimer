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
            this.tbTaskContent = new System.Windows.Forms.TextBox();
            this.tbTaskTime = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTaskContent
            // 
            this.tbTaskContent.Location = new System.Drawing.Point(9, 10);
            this.tbTaskContent.Margin = new System.Windows.Forms.Padding(2);
            this.tbTaskContent.Name = "tbTaskContent";
            this.tbTaskContent.Size = new System.Drawing.Size(216, 21);
            this.tbTaskContent.TabIndex = 0;
            // 
            // tbTaskTime
            // 
            this.tbTaskTime.Location = new System.Drawing.Point(235, 10);
            this.tbTaskTime.Name = "tbTaskTime";
            this.tbTaskTime.Size = new System.Drawing.Size(48, 21);
            this.tbTaskTime.TabIndex = 1;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(235, 39);
            this.btnYes.Margin = new System.Windows.Forms.Padding(2);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(49, 21);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "确定";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 68);
            this.Controls.Add(this.tbTaskTime);
            this.Controls.Add(this.tbTaskContent);
            this.Controls.Add(this.btnYes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTaskContent;
        private System.Windows.Forms.TextBox tbTaskTime;
        private System.Windows.Forms.Button btnYes;
    }
}