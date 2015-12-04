using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager.Auxiliary_Files
{
    public class HandlerOfEvents
    {
        static public void priorityHasChanged()
        {
            MessageBox.Show("Current priority has been changed");
        }

        static public void numberOfProcessesChanged()
        {
            MessageBox.Show("The number of processes on chosen PC has been changed");
        }

        static public  void allPcsAreDeleted()
        {
            MessageBox.Show("All PCs has been removed");
        }

        static public void enterByPassword()
        {
            //MessageBox.Show("You succesfully entered the TaskManager");
        }

        static public  void completedCapacity()
        {
            MessageBox.Show("Current PC is full of processes");
        }
    }
}
