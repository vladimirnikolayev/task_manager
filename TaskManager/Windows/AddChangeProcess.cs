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

namespace TaskManager.Windows
{
    public partial class AddChangeProcess : Form
    {
        public Process m_process { get; }
        public bool m_hasChanged { get; set; }

        public AddChangeProcess()
        {
            InitializeComponent();
            m_process = new Process();
            m_hasChanged = false;

            m_process.PriorityChanged += HandlerOfEvents.priorityHasChanged;
        }

        public AddChangeProcess(Process _process)
        {
            InitializeComponent();
            m_process = _process;
            m_hasChanged = false;

            m_process.PriorityChanged += HandlerOfEvents.priorityHasChanged;
        }

        private void AddChangeProcess_Load(object sender, EventArgs e)
        {
            textBoxNameOfProcess.Text = m_process.m_processName;
            textBoxNameOfUser.Text = m_process.m_user;
            textBoxPriorityOfProcess.Text = m_process.m_priority.ToString();
            textBoxCPUOfProcess.Text = m_process.m_cp.ToString();
            textBoxMemoryOfProcess.Text = m_process.m_memory.ToString();
            textBoxDescription.Text = m_process.m_description;
        }

        private void ApplyNewProcess_Click(object sender, EventArgs e)
        {
            m_process.m_processName = textBoxNameOfProcess.Text;
            m_process.m_user = textBoxNameOfUser.Text;
            m_process.m_priority = System.Convert.ToUInt32(textBoxPriorityOfProcess.Text);
            m_process.m_cp = System.Convert.ToDouble(textBoxCPUOfProcess.Text);
            m_process.m_memory = System.Convert.ToDouble(textBoxMemoryOfProcess.Text);
            m_process.m_description = textBoxDescription.Text;

            m_hasChanged = true;
        }

        private void DiscardNewProcess_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
