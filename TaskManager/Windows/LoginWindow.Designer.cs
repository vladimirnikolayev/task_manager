namespace TaskManager.Windows
{
    partial class LoginWindow
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
            this.invatationForEnterPassword = new System.Windows.Forms.Label();
            this.textBoxForPassword = new System.Windows.Forms.TextBox();
            this.LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // invatationForEnterPassword
            // 
            this.invatationForEnterPassword.AutoSize = true;
            this.invatationForEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invatationForEnterPassword.Location = new System.Drawing.Point(12, 9);
            this.invatationForEnterPassword.Name = "invatationForEnterPassword";
            this.invatationForEnterPassword.Size = new System.Drawing.Size(158, 16);
            this.invatationForEnterPassword.TabIndex = 1;
            this.invatationForEnterPassword.Text = "Please, input a password";
            // 
            // textBoxForPassword
            // 
            this.textBoxForPassword.Location = new System.Drawing.Point(12, 40);
            this.textBoxForPassword.Name = "textBoxForPassword";
            this.textBoxForPassword.Size = new System.Drawing.Size(260, 20);
            this.textBoxForPassword.TabIndex = 2;
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(197, 87);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 3;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.textBoxForPassword);
            this.Controls.Add(this.invatationForEnterPassword);
            this.Name = "LoginWindow";
            this.Text = "LoginWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label invatationForEnterPassword;
        private System.Windows.Forms.TextBox textBoxForPassword;
        private System.Windows.Forms.Button LogIn;
    }
}