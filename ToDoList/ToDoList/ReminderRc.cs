﻿// <auto-generated />

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ReminderRc : Reminder
    {

        public string TypeRepeat { get; set; }

        public ReminderRc()
        {
            TypeRepeat = Communicate.WriteRead("Enter type repetition");
        }

        public override void SetAddType()
        {
            TypeItem = "add-reminder-rc";
        }

        public override void ShowTask()
        {
            Console.WriteLine($"{TaskText}-{Time}-{TypeRepeat}");
        }
    }
}