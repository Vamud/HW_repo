using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public interface ICreate
    {
        public Item CreateItem(string type);
    }
}
