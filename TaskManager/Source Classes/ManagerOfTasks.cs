/**************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************************************/

namespace TaskManager.Source
{
    public class ManagerOfTasks
    {
//--------------------------------------------------------------------------------------

        public delegate void PCsToDelete();
        public event PCsToDelete allPCsAreDeleted;

        public delegate void adminToEnter();
        public event adminToEnter successfulEnter;

        public delegate void capacityToComplete();
        public event capacityToComplete fullCapacity;

        public string m_adminName { get; set; }
        public string m_password = "";

        public Dictionary<string, Computer> m_computers;
        public int PcsCount
        {
            get
            {
                return m_computers.Count;
            }
        }

//--------------------------------------------------------------------------------------

        //public ManagerOfTasks() { /*default constructor*/ }

        public ManagerOfTasks(string _adminName = "me") //TODO Singleton
        {
            if (_adminName.Length == 0)
                throw new Exception();

            m_adminName = _adminName;
            m_computers = new Dictionary<string, Computer>();
        }

//--------------------------------------------------------------------------------------

        public bool authentification (string _password)
        {
            if (successfulEnter != null && m_password == _password)
            {
                successfulEnter();
                return true;
            }
            else
                return false;
        }

//--------------------------------------------------------------------------------------

        public void addPc(Computer _pc)
        {
            if (m_computers.ContainsKey(_pc.m_computerName))
                m_computers[_pc.m_computerName] = _pc;
            else
                m_computers.Add(_pc.m_computerName, _pc);
        }

//--------------------------------------------------------------------------------------

        public void removePc (string _pcName)
        {
            m_computers.Remove(_pcName);

            if (m_computers.Count < 1 && allPCsAreDeleted != null)
                allPCsAreDeleted();
        }

//--------------------------------------------------------------------------------------

        public void addProcessInPc (string _pcName, Process _pr)
        {
            //if (m_computers[_pcName].m_frequency == 100.0 || m_computers[_pcName].m_ram == 100.0)
            //    fullCapacity();
            //else
            //    m_computers[_pcName].addProcess(_prName, _pr);
			try
			{
				m_computers[_pcName].addProcess(_pr.m_processName, _pr);
			}
			catch(Exception _e)
			{
				fullCapacity();
			}
        }

//--------------------------------------------------------------------------------------

        public void removeProcessInPc (string _pcName, string _prName)
        {
            m_computers[_pcName].removeProcess(_prName);
        }

//--------------------------------------------------------------------------------------

        public void changeProcessInPc (string _pcName, string _prName, uint _priority)
        {
            m_computers[_pcName].getProcess(_prName).changePriority(_priority);
        }

//--------------------------------------------------------------------------------------

        public void changeParametersInPc (string _pcName, double _ram, double _frequency, bool _isRiseFrequency)
        {
            m_computers[_pcName].changeRam(_ram);

            if (_isRiseFrequency == true)
                m_computers[_pcName].riseProcessor(_frequency);
            else
                m_computers[_pcName].fallProcessor(_frequency);
        } //????
    }
}

/**************************************************************************************/