/**************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************************************/

namespace TaskManager.Source
{
    public class Computer
    {
//--------------------------------------------------------------------------------------

        public delegate void NumberOfProcessesToChange();
        public event NumberOfProcessesToChange nOfProcessesChanged;

        public string m_computerName { get; set; }
        public double m_ram          { get; set; }
        public double m_frequency    { get; set; }

        public Dictionary <string, Process> m_process;
        public int processesCount
        {
            get
            {
                return m_process.Count;
            }
        }

		public double usedRam
		{
			get
			{
				double used = 0;
				foreach(var value in m_process)
				{
					used += value.Value.m_memory;
				}
				return used;
			}
		}

		public double usedCPU
		{
			get
			{
				double used = 0;
				foreach (var value in m_process)
				{
					used += value.Value.m_cp;
				}
				return used;
			}
		}

		//--------------------------------------------------------------------------------------

		public Computer () { /*default constructor*/ }

        public Computer (string _computerName, double _ram, double _frequency)
        {
            if (_computerName.Length == 0)
                throw new Exception();

            if (_ram <= 0.0)
                throw new Exception();

            if (_frequency <= 0.0)
                throw new Exception();

            m_computerName   = _computerName;
            m_process        = new Dictionary <string, Process>();
            m_ram            = _ram;
            m_frequency      = _frequency;
        }

//--------------------------------------------------------------------------------------

        public void changeRam(double _ram)
        {
            if (_ram == 0.0)
                throw new Exception();

           /* if ((m_ram + _ram) > 100.0)
                throw new Exception();*/

            m_ram = _ram;
        }

//--------------------------------------------------------------------------------------

        public void riseProcessor(double _frequency)
        {
            if (_frequency <= 0.0)
                throw new Exception();

          /*  if ((m_frequency + _frequency) > 100.0)
                throw new Exception();*/

            m_frequency += _frequency;
        }

//--------------------------------------------------------------------------------------

        public void fallProcessor(double _frequency)
        {
            if (_frequency <= 0.0 || _frequency > m_frequency)
                throw new Exception();

            m_frequency -= _frequency;
        }

//--------------------------------------------------------------------------------------

        public void addProcess(string _processName, Process _pr)
        {
			if (usedCPU + _pr.m_cp > m_frequency || usedRam + _pr.m_memory > m_ram)
			{
				throw new Exception();
			}

            if (m_process.ContainsKey(_processName))
                m_process[_processName] = _pr; //TODO
            else
                m_process.Add(_processName, _pr);
                                                
            //m_frequency -= _pr.m_cp;                        // от общего количества свободной частоты и процесса 
            //m_ram -= _pr.m_memory;                          // отнимаем ту что занимает процесс

            if (nOfProcessesChanged != null)
                nOfProcessesChanged();
        }

//--------------------------------------------------------------------------------------

        public void removeProcess(string _processName)
        {
			if (!m_process.ContainsKey(_processName))
				throw new Exception();

            m_process.Remove(_processName);

            //m_frequency += m_process[_processName].m_cp;    // наоборот - увеличиваем свободную частоту и ОЗУ
            //m_ram += m_process[_processName].m_memory;      // на величину, равную освобожденному процессу

            if (nOfProcessesChanged != null)
                nOfProcessesChanged();
        }

//--------------------------------------------------------------------------------------

        public Process getProcess (string _processName)
        {
			if (!m_process.ContainsKey(_processName))
				throw new Exception();

			//Process result = null;

            //if (m_process.ContainsKey(_processName))
                //result = m_process[_processName];

            return m_process[_processName];
        }
    }
}

/**************************************************************************************/