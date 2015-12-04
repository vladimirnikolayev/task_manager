namespace TaskManager.Windows
{
    partial class AddChangeProcess
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
            this.textBoxNameOfProcess = new System.Windows.Forms.TextBox();
            this.labelNameOfProcess = new System.Windows.Forms.Label();
            this.textBoxNameOfUser = new System.Windows.Forms.TextBox();
            this.labelNameOfUser = new System.Windows.Forms.Label();
            this.textBoxPriorityOfProcess = new System.Windows.Forms.TextBox();
            this.labelPriority = new System.Windows.Forms.Label();
            this.textBoxMemoryOfProcess = new System.Windows.Forms.TextBox();
            this.labelPcRam = new System.Windows.Forms.Label();
            this.textBoxCPUOfProcess = new System.Windows.Forms.TextBox();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.DiscardNewProcess = new System.Windows.Forms.Button();
            this.ApplyNewProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNameOfProcess
            // 
            this.textBoxNameOfProcess.Location = new System.Drawing.Point(12, 26);
            this.textBoxNameOfProcess.Name = "textBoxNameOfProcess";
            this.textBoxNameOfProcess.Size = new System.Drawing.Size(159, 20);
            this.textBoxNameOfProcess.TabIndex = 3;
            // 
            // labelNameOfProcess
            // 
            this.labelNameOfProcess.AutoSize = true;
            this.labelNameOfProcess.Location = new System.Drawing.Point(12, 9);
            this.labelNameOfProcess.Name = "labelNameOfProcess";
            this.labelNameOfProcess.Size = new System.Drawing.Size(76, 13);
            this.labelNameOfProcess.TabIndex = 2;
            this.labelNameOfProcess.Text = "Process Name";
            // 
            // textBoxNameOfUser
            // 
            this.textBoxNameOfUser.Location = new System.Drawing.Point(12, 75);
            this.textBoxNameOfUser.Name = "textBoxNameOfUser";
            this.textBoxNameOfUser.Size = new System.Drawing.Size(159, 20);
            this.textBoxNameOfUser.TabIndex = 5;
            // 
            // labelNameOfUser
            // 
            this.labelNameOfUser.AutoSize = true;
            this.labelNameOfUser.Location = new System.Drawing.Point(12, 58);
            this.labelNameOfUser.Name = "labelNameOfUser";
            this.labelNameOfUser.Size = new System.Drawing.Size(29, 13);
            this.labelNameOfUser.TabIndex = 4;
            this.labelNameOfUser.Text = "User";
            // 
            // textBoxPriorityOfProcess
            // 
            this.textBoxPriorityOfProcess.Location = new System.Drawing.Point(12, 126);
            this.textBoxPriorityOfProcess.Name = "textBoxPriorityOfProcess";
            this.textBoxPriorityOfProcess.Size = new System.Drawing.Size(159, 20);
            this.textBoxPriorityOfProcess.TabIndex = 7;
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(12, 109);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(38, 13);
            this.labelPriority.TabIndex = 6;
            this.labelPriority.Text = "Priority";
            // 
            // textBoxMemoryOfProcess
            // 
            this.textBoxMemoryOfProcess.Location = new System.Drawing.Point(210, 74);
            this.textBoxMemoryOfProcess.Name = "textBoxMemoryOfProcess";
            this.textBoxMemoryOfProcess.Size = new System.Drawing.Size(159, 20);
            this.textBoxMemoryOfProcess.TabIndex = 9;
            // 
            // labelPcRam
            // 
            this.labelPcRam.AutoSize = true;
            this.labelPcRam.Location = new System.Drawing.Point(210, 58);
            this.labelPcRam.Name = "labelPcRam";
            this.labelPcRam.Size = new System.Drawing.Size(90, 13);
            this.labelPcRam.TabIndex = 8;
            this.labelPcRam.Text = "Memory Engaged";
            // 
            // textBoxCPUOfProcess
            // 
            this.textBoxCPUOfProcess.Location = new System.Drawing.Point(210, 26);
            this.textBoxCPUOfProcess.Name = "textBoxCPUOfProcess";
            this.textBoxCPUOfProcess.Size = new System.Drawing.Size(159, 20);
            this.textBoxCPUOfProcess.TabIndex = 11;
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Location = new System.Drawing.Point(210, 9);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(63, 13);
            this.labelFrequency.TabIndex = 10;
            this.labelFrequency.Text = "CPU Usage";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(210, 125);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(320, 20);
            this.textBoxDescription.TabIndex = 13;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(210, 109);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 12;
            this.Description.Text = "Description";
            // 
            // DiscardNewProcess
            // 
            this.DiscardNewProcess.Location = new System.Drawing.Point(455, 179);
            this.DiscardNewProcess.Name = "DiscardNewProcess";
            this.DiscardNewProcess.Size = new System.Drawing.Size(75, 23);
            this.DiscardNewProcess.TabIndex = 14;
            this.DiscardNewProcess.Text = "Discard";
            this.DiscardNewProcess.UseVisualStyleBackColor = true;
            this.DiscardNewProcess.Click += new System.EventHandler(this.DiscardNewProcess_Click);
            // 
            // ApplyNewProcess
            // 
            this.ApplyNewProcess.Location = new System.Drawing.Point(370, 179);
            this.ApplyNewProcess.Name = "ApplyNewProcess";
            this.ApplyNewProcess.Size = new System.Drawing.Size(75, 23);
            this.ApplyNewProcess.TabIndex = 15;
            this.ApplyNewProcess.Text = "Apply";
            this.ApplyNewProcess.UseVisualStyleBackColor = true;
            this.ApplyNewProcess.Click += new System.EventHandler(this.ApplyNewProcess_Click);
            // 
            // AddChangeProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 217);
            this.Controls.Add(this.ApplyNewProcess);
            this.Controls.Add(this.DiscardNewProcess);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.textBoxCPUOfProcess);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.textBoxMemoryOfProcess);
            this.Controls.Add(this.labelPcRam);
            this.Controls.Add(this.textBoxPriorityOfProcess);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.textBoxNameOfUser);
            this.Controls.Add(this.labelNameOfUser);
            this.Controls.Add(this.textBoxNameOfProcess);
            this.Controls.Add(this.labelNameOfProcess);
            this.Name = "AddChangeProcess";
            this.Text = "AddChangeProcess";
            this.Load += new System.EventHandler(this.AddChangeProcess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameOfProcess;
        private System.Windows.Forms.Label labelNameOfProcess;
        private System.Windows.Forms.TextBox textBoxNameOfUser;
        private System.Windows.Forms.Label labelNameOfUser;
        private System.Windows.Forms.TextBox textBoxPriorityOfProcess;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.TextBox textBoxMemoryOfProcess;
        private System.Windows.Forms.Label labelPcRam;
        private System.Windows.Forms.TextBox textBoxCPUOfProcess;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Button DiscardNewProcess;
        private System.Windows.Forms.Button ApplyNewProcess;
    }
}