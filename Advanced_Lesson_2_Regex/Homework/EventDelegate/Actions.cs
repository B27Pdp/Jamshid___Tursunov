﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3.Advanced_Lesson_2_Regex.Homework.EventDelegate
{
    internal class Actions
    {

        public static void Start()
        {
            //Person person1 = new Person("Azamat");
            //Person person2 = new Person("Abror");
            //Person person3 = new Person("Sardor");
            ////   Killer killer=new Killer();
            //SecureAgent agent = new SecureAgent();
            //agent.OnSecureAgent += person1.Targeted;
            //agent.OnSecureAgent += person2.Targeted;
            //// agent.Kill(agent,args);
            //agent.OnSecureAgent -= person2.Targeted;
            //agent.OnSecureAgent += person3.Targeted;


        ///    agent.Kill(person1.Targeted);
            SecureAgent agent= new SecureAgent();   
            Killer killer= new Killer();
            agent.OnSecureAgent += killer.Task;
            agent.Run();

        }


    }
}
