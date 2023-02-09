using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_2_Regex.Homework.EventDelegate
{
    internal class SecureAgent
    {
        public event EventHandler<EventHandler> OnSecureAgent;

        EventHandler? event2;
        public void Run()
        {

            Person person = new();

            event2 += person.Function1;

            event2 += person.Function2;

            event2 += person.Function3;

            event2 += person.Function4;

            OnSecureAgent.Invoke(this, event2);

        }

    }
}
