/**************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************************************/

namespace TaskManager.Source
{
    public class Process
    {
//--------------------------------------------------------------------------------------

        public delegate void PriorityToChange();
        public event PriorityToChange PriorityChanged;

        public string m_processName { get; set; }
        public string m_user        { get; set; }
        public uint m_priority      { get; set; }
        public double m_cp          { get; set; }
        public double m_memory      { get; set; }
        public string m_description { get; set; }
        
//--------------------------------------------------------------------------------------

        public Process() { /*default constructor*/ }

        public Process(string _processName, string _user, uint _priority, double _cp, double _memory, string _description)
        {
            if (_processName.Length == 0)
                throw new Exception();

            if (_user.Length == 0)
                throw new Exception();

            if (_cp < 0.0)
                throw new Exception();

            if (_memory < 0.0)
                throw new Exception();

            if (_priority > 4)
                throw new Exception();

            m_processName = _processName;
            m_user        = _user;
            m_priority    = _priority;
            m_cp          = _cp;
            m_memory      = _memory;
            m_description = _description;
        }

//--------------------------------------------------------------------------------------

        public void changePriority(uint _priority)
        {
            m_priority = _priority;
            if (PriorityChanged != null)
                PriorityChanged();
        }

//--------------------------------------------------------------------------------------

        static public  Process operator ++ (Process _pr)
        {
            if (_pr.m_priority == 4)
                throw new Exception();

            ++_pr.m_priority;
            return _pr;
        }

//--------------------------------------------------------------------------------------

        static public  Process operator -- (Process _pr)
        {
            if (_pr.m_priority == 0)
                throw new Exception();

            --_pr.m_priority;
            return _pr;
        }
    }
}

/**************************************************************************************/