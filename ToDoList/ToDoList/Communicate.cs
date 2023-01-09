using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
     static class Communicate
    {
        public static string WriteRead(string massage)
        {
            Console.WriteLine(massage);
            string? text = Console.ReadLine();
            return text;
        }

    }
}
