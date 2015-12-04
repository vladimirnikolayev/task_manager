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
    public partial class AddChangePc : Form
    {
        public Computer m_Pc { get; }
        public bool m_hasChanged { get; set; }

        public AddChangePc()
        {
            InitializeComponent();
            m_Pc = new Computer();
            m_hasChanged = false;

            m_Pc.nOfProcessesChanged += HandlerOfEvents.numberOfProcessesChanged;
        }

        public AddChangePc(Computer _Pc)
        {
            InitializeComponent();
            m_Pc = _Pc;
            m_hasChanged = false;

            m_Pc.nOfProcessesChanged += HandlerOfEvents.numberOfProcessesChanged;
        }

        private void AddChangePc_Load(object sender, EventArgs e)
        {
            textBoxNameOfPc.Text = m_Pc.m_computerName;
            textBoxRamOfPc.Text = m_Pc.m_ram.ToString();
            textBoxFrequencyOfPc.Text = m_Pc.m_frequency.ToString();
        }

        private void buttonAddProcessInPc_Click(object sender, EventArgs e)
        {
            Process pr = new Process();
            var addChangeProcessForm = new AddChangeProcess(pr);

            addChangeProcessForm.ShowDialog();

            if (addChangeProcessForm.m_hasChanged)
            {
                this.m_Pc.m_process.Add(pr.m_processName, pr);
            }
        }

        private void ApplyNewPc_Click(object sender, EventArgs e)
        {
            m_Pc.m_computerName = textBoxNameOfPc.Text;
            m_Pc.m_ram = System.Convert.ToDouble(textBoxRamOfPc.Text);
            m_Pc.m_frequency = System.Convert.ToDouble(textBoxFrequencyOfPc.Text);

            m_hasChanged = true;
        }

        private void DiscardNewPc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
