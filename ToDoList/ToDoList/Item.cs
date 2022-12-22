using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Item : Task
    {
        public override void SetAddType()
        {
            TypeItem = "add-item";
        }

        public override void ShowTask()
        {
            Console.WriteLine(TaskText);
        }
    }
}
