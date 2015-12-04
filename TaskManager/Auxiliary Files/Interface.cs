using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Source;

namespace TaskManager.Auxiliary_Files
{
    class Interface
    {
        List<Computer> m_container;

        public Interface()
        {
            m_container = new List<Computer>();
        }

        public void add (Computer _pc)
        {
            m_container.Add(_pc);
        }

        public void remove (Computer _pc)
        {
            m_container.Remove(_pc);
        }

        public Computer get (int _index)
        {
            return m_container[_index];
        }

        public Computer [] getValues ()
        {
            return m_container.ToArray();
        }
    }
}
