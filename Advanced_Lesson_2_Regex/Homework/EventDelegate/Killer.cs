using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_2_Regex.Homework.EventDelegate
{
    internal class Killer
    {
        public void Task(object sender, EventHandler eventt)
        {

            eventt.Invoke(this, new EventArgs());

        }


    }
}
