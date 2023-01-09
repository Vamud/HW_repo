using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Remover
    {
        public void Delete(ToDoList list)
        {
            int id = Convert.ToInt32(Communicate.WriteRead("Enter id"));

            try
            {
                Item[] items = list.GetList();
                Item[] newList = new Item[items.Length - 1];

                for (int i = 0; i < id - 1; i++)
                {
                    newList[i] = items[i];
                }

                for (int i = id; i < items.Length; i++)
                {
                    newList[i - 1] = items[i];
                }

                list.SetList(newList);
            }
            catch (DeleteException)
            {
                Console.WriteLine("Incorrect Id");
                Delete(list);
            }
        }
    }
}
