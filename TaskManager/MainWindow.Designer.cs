namespace sharp_laba_3
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxComputers = new System.Windows.Forms.ComboBox();
			this.buttonChangeComputer = new System.Windows.Forms.Button();
			this.buttonAddComputer = new System.Windows.Forms.Button();
			this.buttonDropComputer = new System.Windows.Forms.Button();
			this.buttonAddProcess = new System.Windows.Forms.Button();
			this.buttonDropProcess = new System.Windows.Forms.Button();
			this.buttonChangeProcess = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelProcessesCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelCp = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelRam = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(14, 47);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(786, 360);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(10, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Компьютеры";
			// 
			// comboBoxComputers
			// 
			this.comboBoxComputers.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.comboBoxComputers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.comboBoxComputers.FormattingEnabled = true;
			this.comboBoxComputers.Location = new System.Drawing.Point(123, 8);
			this.comboBoxComputers.Name = "comboBoxComputers";
			this.comboBoxComputers.Size = new System.Drawing.Size(329, 28);
			this.comboBoxComputers.TabIndex = 2;
			// 
			// buttonChangeComputer
			// 
			this.buttonChangeComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonChangeComputer.Location = new System.Drawing.Point(458, 1);
			this.buttonChangeComputer.Name = "buttonChangeComputer";
			this.buttonChangeComputer.Size = new System.Drawing.Size(110, 40);
			this.buttonChangeComputer.TabIndex = 3;
			this.buttonChangeComputer.Text = "Изменить";
			this.buttonChangeComputer.UseVisualStyleBackColor = true;
			// 
			// buttonAddComputer
			// 
			this.buttonAddComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddComputer.Location = new System.Drawing.Point(574, 1);
			this.buttonAddComputer.Name = "buttonAddComputer";
			this.buttonAddComputer.Size = new System.Drawing.Size(110, 40);
			this.buttonAddComputer.TabIndex = 4;
			this.buttonAddComputer.Text = "Добавить";
			this.buttonAddComputer.UseVisualStyleBackColor = true;
			// 
			// buttonDropComputer
			// 
			this.buttonDropComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDropComputer.Location = new System.Drawing.Point(690, 1);
			this.buttonDropComputer.Name = "buttonDropComputer";
			this.buttonDropComputer.Size = new System.Drawing.Size(110, 40);
			this.buttonDropComputer.TabIndex = 5;
			this.buttonDropComputer.Text = "Удалить";
			this.buttonDropComputer.UseVisualStyleBackColor = true;
			// 
			// buttonAddProcess
			// 
			this.buttonAddProcess.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonAddProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddProcess.Location = new System.Drawing.Point(12, 413);
			this.buttonAddProcess.Name = "buttonAddProcess";
			this.buttonAddProcess.Size = new System.Drawing.Size(159, 29);
			this.buttonAddProcess.TabIndex = 6;
			this.buttonAddProcess.Text = "Добавить процесс";
			this.buttonAddProcess.UseVisualStyleBackColor = true;
			// 
			// buttonDropProcess
			// 
			this.buttonDropProcess.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonDropProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonDropProcess.Location = new System.Drawing.Point(177, 413);
			this.buttonDropProcess.Name = "buttonDropProcess";
			this.buttonDropProcess.Size = new System.Drawing.Size(159, 29);
			this.buttonDropProcess.TabIndex = 7;
			this.buttonDropProcess.Text = "Удалить процесс";
			this.buttonDropProcess.UseVisualStyleBackColor = true;
			// 
			// buttonChangeProcess
			// 
			this.buttonChangeProcess.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.buttonChangeProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonChangeProcess.Location = new System.Drawing.Point(642, 413);
			this.buttonChangeProcess.Name = "buttonChangeProcess";
			this.buttonChangeProcess.Size = new System.Drawing.Size(159, 29);
			this.buttonChangeProcess.TabIndex = 8;
			this.buttonChangeProcess.Text = "Изменить процесс";
			this.buttonChangeProcess.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelProcessesCount,
            this.toolStripStatusLabelCp,
            this.toolStripStatusLabelRam});
			this.statusStrip1.Location = new System.Drawing.Point(0, 453);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(813, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelProcessesCount
			// 
			this.toolStripStatusLabelProcessesCount.Name = "toolStripStatusLabelProcessesCount";
			this.toolStripStatusLabelProcessesCount.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabelProcessesCount.Text = "toolStripStatusLabel1";
			// 
			// toolStripStatusLabelCp
			// 
			this.toolStripStatusLabelCp.Name = "toolStripStatusLabelCp";
			this.toolStripStatusLabelCp.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabelCp.Text = "toolStripStatusLabel2";
			// 
			// toolStripStatusLabelRam
			// 
			this.toolStripStatusLabelRam.Name = "toolStripStatusLabelRam";
			this.toolStripStatusLabelRam.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabelRam.Text = "toolStripStatusLabel3";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.ClientSize = new System.Drawing.Size(813, 475);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.buttonChangeProcess);
			this.Controls.Add(this.buttonDropProcess);
			this.Controls.Add(this.buttonAddProcess);
			this.Controls.Add(this.buttonDropComputer);
			this.Controls.Add(this.buttonAddComputer);
			this.Controls.Add(this.buttonChangeComputer);
			this.Controls.Add(this.comboBoxComputers);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainWindow";
			this.Text = "Диспетчер процессов";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxComputers;
		private System.Windows.Forms.Button buttonChangeComputer;
		private System.Windows.Forms.Button buttonAddComputer;
		private System.Windows.Forms.Button buttonDropComputer;
		private System.Windows.Forms.Button buttonAddProcess;
		private System.Windows.Forms.Button buttonDropProcess;
		private System.Windows.Forms.Button buttonChangeProcess;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelProcessesCount;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCp;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRam;
	}
}

