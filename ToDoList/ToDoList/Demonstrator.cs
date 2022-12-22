using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Demonstrator
    {
        public void GetAll(IGive list)
        {
            Item[] items = list.GetList();

            for(int i = 0; i < items.Length; i++)
            {
                items[i].ShowTask();
            }
            
        }
    }
}
