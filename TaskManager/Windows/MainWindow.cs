using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Source;

namespace TaskManager.Windows
{
    public partial class MainWindow : Form
    {
		public MainWindow()
        {
			LoginWindow loginWindow = new LoginWindow();
			loginWindow.ShowDialog();
			if (loginWindow.hasAccepted == false)
				throw new Exception();
			else
				InitializeComponent();
        }

        /*private void fillCombobox()
        {
            foreach (var value in Program.m_interface.getValues())
            {
                comboBoxComputers.Items.Add(value.m_computerName);
            }
            comboBoxComputers.SelectedIndex = 0;
        }*/

        private void buttonChangeComputer_Click(object sender, EventArgs e)
        {
            Computer pc = new Computer();
            var addChangePCForm = new AddChangePc(pc);

            addChangePCForm.ShowDialog();

            if (addChangePCForm.m_hasChanged)
            {
                Program.m_interface.add(pc);
                comboBoxComputers.Items.Add(pc.m_computerName);
                comboBoxComputers.SelectedItem = pc.m_computerName;
            }
        }

        private void buttonAddComputer_Click(object sender, EventArgs e)
        {
            Computer pc = new Computer();
            var addChangePCForm = new AddChangePc(pc);

            addChangePCForm.ShowDialog();

            if (addChangePCForm.m_hasChanged)
            {
                Program.m_interface.add(pc);
                comboBoxComputers.Items.Add(pc.m_computerName);
                comboBoxComputers.SelectedItem = pc.m_computerName;
            }
        }

        private void buttonAddProcess_Click(object sender, EventArgs e)
        {
            Process pr = new Process();
            var addChangeProcessForm = new AddChangeProcess(pr);

            addChangeProcessForm.ShowDialog();
        }

        private void buttonChangeProcess_Click(object sender, EventArgs e)
        {
            Process pr = new Process();
            var addChangeProcessForm = new AddChangeProcess(pr);

            addChangeProcessForm.ShowDialog();
        }
	}
}
