using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public abstract class Task
    {
        public int Id { get; set; }

        public string? TypeItem { get; set; }

        public string? TaskText { get; set; }

        public Task()
        {
            TaskText = Communicate.WriteRead("Enter the task text");
            SetAddType();
        }

        public abstract void SetAddType();

        public abstract void ShowTask();
    }
}
