namespace TaskManager.Windows
{
    partial class MainWindow
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
            this.comboBoxComputers = new System.Windows.Forms.ComboBox();
            this.labelComputers = new System.Windows.Forms.Label();
            this.buttonDropComputer = new System.Windows.Forms.Button();
            this.buttonAddComputer = new System.Windows.Forms.Button();
            this.buttonChangeComputer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonChangeProcess = new System.Windows.Forms.Button();
            this.buttonDropProcess = new System.Windows.Forms.Button();
            this.buttonAddProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxComputers
            // 
            this.comboBoxComputers.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBoxComputers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxComputers.FormattingEnabled = true;
            this.comboBoxComputers.Location = new System.Drawing.Point(125, 9);
            this.comboBoxComputers.Name = "comboBoxComputers";
            this.comboBoxComputers.Size = new System.Drawing.Size(329, 28);
            this.comboBoxComputers.TabIndex = 3;
            // 
            // labelComputers
            // 
            this.labelComputers.AutoSize = true;
            this.labelComputers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComputers.Location = new System.Drawing.Point(12, 9);
            this.labelComputers.Name = "labelComputers";
            this.labelComputers.Size = new System.Drawing.Size(87, 20);
            this.labelComputers.TabIndex = 4;
            this.labelComputers.Text = "Computers";
            // 
            // buttonDropComputer
            // 
            this.buttonDropComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDropComputer.Location = new System.Drawing.Point(692, 9);
            this.buttonDropComputer.Name = "buttonDropComputer";
            this.buttonDropComputer.Size = new System.Drawing.Size(110, 40);
            this.buttonDropComputer.TabIndex = 8;
            this.buttonDropComputer.Text = "Delete";
            this.buttonDropComputer.UseVisualStyleBackColor = true;
            // 
            // buttonAddComputer
            // 
            this.buttonAddComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddComputer.Location = new System.Drawing.Point(576, 9);
            this.buttonAddComputer.Name = "buttonAddComputer";
            this.buttonAddComputer.Size = new System.Drawing.Size(110, 40);
            this.buttonAddComputer.TabIndex = 7;
            this.buttonAddComputer.Text = "Add";
            this.buttonAddComputer.UseVisualStyleBackColor = true;
            this.buttonAddComputer.Click += new System.EventHandler(this.buttonAddComputer_Click);
            // 
            // buttonChangeComputer
            // 
            this.buttonChangeComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeComputer.Location = new System.Drawing.Point(460, 9);
            this.buttonChangeComputer.Name = "buttonChangeComputer";
            this.buttonChangeComputer.Size = new System.Drawing.Size(110, 40);
            this.buttonChangeComputer.TabIndex = 6;
            this.buttonChangeComputer.Text = "Change";
            this.buttonChangeComputer.UseVisualStyleBackColor = true;
            this.buttonChangeComputer.Click += new System.EventHandler(this.buttonChangeComputer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 360);
            this.dataGridView1.TabIndex = 9;
            // 
            // buttonChangeProcess
            // 
            this.buttonChangeProcess.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonChangeProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeProcess.Location = new System.Drawing.Point(643, 421);
            this.buttonChangeProcess.Name = "buttonChangeProcess";
            this.buttonChangeProcess.Size = new System.Drawing.Size(159, 29);
            this.buttonChangeProcess.TabIndex = 12;
            this.buttonChangeProcess.Text = "Change Process";
            this.buttonChangeProcess.UseVisualStyleBackColor = true;
            this.buttonChangeProcess.Click += new System.EventHandler(this.buttonChangeProcess_Click);
            // 
            // buttonDropProcess
            // 
            this.buttonDropProcess.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonDropProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDropProcess.Location = new System.Drawing.Point(181, 421);
            this.buttonDropProcess.Name = "buttonDropProcess";
            this.buttonDropProcess.Size = new System.Drawing.Size(159, 29);
            this.buttonDropProcess.TabIndex = 11;
            this.buttonDropProcess.Text = "Remove Process";
            this.buttonDropProcess.UseVisualStyleBackColor = true;
            // 
            // buttonAddProcess
            // 
            this.buttonAddProcess.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonAddProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddProcess.Location = new System.Drawing.Point(16, 421);
            this.buttonAddProcess.Name = "buttonAddProcess";
            this.buttonAddProcess.Size = new System.Drawing.Size(159, 29);
            this.buttonAddProcess.TabIndex = 10;
            this.buttonAddProcess.Text = "Add Process";
            this.buttonAddProcess.UseVisualStyleBackColor = true;
            this.buttonAddProcess.Click += new System.EventHandler(this.buttonAddProcess_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 489);
            this.Controls.Add(this.buttonChangeProcess);
            this.Controls.Add(this.buttonDropProcess);
            this.Controls.Add(this.buttonAddProcess);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDropComputer);
            this.Controls.Add(this.buttonAddComputer);
            this.Controls.Add(this.buttonChangeComputer);
            this.Controls.Add(this.labelComputers);
            this.Controls.Add(this.comboBoxComputers);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxComputers;
        private System.Windows.Forms.Label labelComputers;
        private System.Windows.Forms.Button buttonDropComputer;
        private System.Windows.Forms.Button buttonAddComputer;
        private System.Windows.Forms.Button buttonChangeComputer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonChangeProcess;
        private System.Windows.Forms.Button buttonDropProcess;
        private System.Windows.Forms.Button buttonAddProcess;
    }
}