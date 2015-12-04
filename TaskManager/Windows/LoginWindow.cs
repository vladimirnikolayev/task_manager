using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Auxiliary_Files;
using TaskManager.Source;
using TaskManager.Windows;

namespace TaskManager.Windows
{
    public partial class LoginWindow : Form
    {
		public bool hasAccepted { set; get; }

        public ManagerOfTasks m_taskManager = new ManagerOfTasks();

        public LoginWindow()
        {
            InitializeComponent();

			hasAccepted = false;

            m_taskManager.successfulEnter += HandlerOfEvents.enterByPassword;
            m_taskManager.allPCsAreDeleted += HandlerOfEvents.allPcsAreDeleted;
            m_taskManager.fullCapacity += HandlerOfEvents.completedCapacity;
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            if (m_taskManager.authentification(textBoxForPassword.Text))
            {
				//MainWindow main = new MainWindow(this);
				//main.Show();
				//this.Hide();
				hasAccepted = true;
				this.Close();
            }
            else
            {
                MessageBox.Show("You have inputed a wrong sequence");
                textBoxForPassword.Clear();
            }
        }
    }
}
