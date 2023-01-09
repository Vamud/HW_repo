﻿// <auto-generated />

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{

    public class Reminder : Item
    {
        public TimeOnly Time { get; set; }

        public Reminder()
        {
            string[] splitTime = Communicate.WriteRead("Enter time, for example: 10:20").Split(":"); 
            Time = new TimeOnly(Convert.ToInt32(splitTime[0]), Convert.ToInt32(splitTime[0]));
        }

        public override void SetAddType()
        {
            TypeItem = "add-reminder";
        }

        public override void ShowTask()
        {
            Console.WriteLine($"{TaskText}-{Time}");
        }
    }
}