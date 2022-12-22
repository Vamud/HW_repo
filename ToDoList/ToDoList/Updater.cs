using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Updater
    {
        public void Update(ToDoList list, ICreate creator)
        {
            Item[] items = list.GetList();

            int id = Convert.ToInt32(Communicate.WriteRead("Enter id"));

            for (int i = 0; i < items.Length; i++)
            {
                if (i == id - 1)
                {
                    string type = items[i].TypeItem;
                    items[i] = creator.CreateItem(type);
                }
            }
            list.SetList(items);
        }
    }
}
