namespace TaskManager.Windows
{
    partial class AddChangePc
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
            this.labelNameOfPc = new System.Windows.Forms.Label();
            this.textBoxNameOfPc = new System.Windows.Forms.TextBox();
            this.textBoxRamOfPc = new System.Windows.Forms.TextBox();
            this.labelRamOfPc = new System.Windows.Forms.Label();
            this.textBoxFrequencyOfPc = new System.Windows.Forms.TextBox();
            this.labelFrequencyOfPc = new System.Windows.Forms.Label();
            this.ApplyNewPc = new System.Windows.Forms.Button();
            this.DiscardNewPc = new System.Windows.Forms.Button();
            this.buttonAddProcessInPc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameOfPc
            // 
            this.labelNameOfPc.AutoSize = true;
            this.labelNameOfPc.Location = new System.Drawing.Point(13, 13);
            this.labelNameOfPc.Name = "labelNameOfPc";
            this.labelNameOfPc.Size = new System.Drawing.Size(35, 13);
            this.labelNameOfPc.TabIndex = 0;
            this.labelNameOfPc.Text = "Name";
            // 
            // textBoxNameOfPc
            // 
            this.textBoxNameOfPc.Location = new System.Drawing.Point(13, 30);
            this.textBoxNameOfPc.Name = "textBoxNameOfPc";
            this.textBoxNameOfPc.Size = new System.Drawing.Size(159, 20);
            this.textBoxNameOfPc.TabIndex = 1;
            // 
            // textBoxRamOfPc
            // 
            this.textBoxRamOfPc.Location = new System.Drawing.Point(178, 30);
            this.textBoxRamOfPc.Name = "textBoxRamOfPc";
            this.textBoxRamOfPc.Size = new System.Drawing.Size(159, 20);
            this.textBoxRamOfPc.TabIndex = 3;
            // 
            // labelRamOfPc
            // 
            this.labelRamOfPc.AutoSize = true;
            this.labelRamOfPc.Location = new System.Drawing.Point(175, 13);
            this.labelRamOfPc.Name = "labelRamOfPc";
            this.labelRamOfPc.Size = new System.Drawing.Size(52, 13);
            this.labelRamOfPc.TabIndex = 2;
            this.labelRamOfPc.Text = "Ram (Gb)";
            // 
            // textBoxFrequencyOfPc
            // 
            this.textBoxFrequencyOfPc.Location = new System.Drawing.Point(343, 29);
            this.textBoxFrequencyOfPc.Name = "textBoxFrequencyOfPc";
            this.textBoxFrequencyOfPc.Size = new System.Drawing.Size(160, 20);
            this.textBoxFrequencyOfPc.TabIndex = 5;
            // 
            // labelFrequencyOfPc
            // 
            this.labelFrequencyOfPc.AutoSize = true;
            this.labelFrequencyOfPc.Location = new System.Drawing.Point(340, 13);
            this.labelFrequencyOfPc.Name = "labelFrequencyOfPc";
            this.labelFrequencyOfPc.Size = new System.Drawing.Size(85, 13);
            this.labelFrequencyOfPc.TabIndex = 4;
            this.labelFrequencyOfPc.Text = "Frequency (Ghz)";
            // 
            // ApplyNewPc
            // 
            this.ApplyNewPc.Location = new System.Drawing.Point(347, 169);
            this.ApplyNewPc.Name = "ApplyNewPc";
            this.ApplyNewPc.Size = new System.Drawing.Size(75, 23);
            this.ApplyNewPc.TabIndex = 6;
            this.ApplyNewPc.Text = "Apply";
            this.ApplyNewPc.UseVisualStyleBackColor = true;
            this.ApplyNewPc.Click += new System.EventHandler(this.ApplyNewPc_Click);
            // 
            // DiscardNewPc
            // 
            this.DiscardNewPc.Location = new System.Drawing.Point(428, 169);
            this.DiscardNewPc.Name = "DiscardNewPc";
            this.DiscardNewPc.Size = new System.Drawing.Size(75, 23);
            this.DiscardNewPc.TabIndex = 7;
            this.DiscardNewPc.Text = "Discard";
            this.DiscardNewPc.UseVisualStyleBackColor = true;
            this.DiscardNewPc.Click += new System.EventHandler(this.DiscardNewPc_Click);
            // 
            // buttonAddProcessInPc
            // 
            this.buttonAddProcessInPc.Location = new System.Drawing.Point(12, 92);
            this.buttonAddProcessInPc.Name = "buttonAddProcessInPc";
            this.buttonAddProcessInPc.Size = new System.Drawing.Size(160, 45);
            this.buttonAddProcessInPc.TabIndex = 8;
            this.buttonAddProcessInPc.Text = "AddProcess";
            this.buttonAddProcessInPc.UseVisualStyleBackColor = true;
            this.buttonAddProcessInPc.Click += new System.EventHandler(this.buttonAddProcessInPc_Click);
            // 
            // AddChangePc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 213);
            this.Controls.Add(this.buttonAddProcessInPc);
            this.Controls.Add(this.DiscardNewPc);
            this.Controls.Add(this.ApplyNewPc);
            this.Controls.Add(this.textBoxFrequencyOfPc);
            this.Controls.Add(this.labelFrequencyOfPc);
            this.Controls.Add(this.textBoxRamOfPc);
            this.Controls.Add(this.labelRamOfPc);
            this.Controls.Add(this.textBoxNameOfPc);
            this.Controls.Add(this.labelNameOfPc);
            this.Name = "AddChangePc";
            this.Text = "AddChangePc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameOfPc;
        private System.Windows.Forms.TextBox textBoxNameOfPc;
        private System.Windows.Forms.TextBox textBoxRamOfPc;
        private System.Windows.Forms.Label labelRamOfPc;
        private System.Windows.Forms.TextBox textBoxFrequencyOfPc;
        private System.Windows.Forms.Label labelFrequencyOfPc;
        private System.Windows.Forms.Button ApplyNewPc;
        private System.Windows.Forms.Button DiscardNewPc;
        private System.Windows.Forms.Button buttonAddProcessInPc;
    }
}