using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public interface IGive
    {
        public Item[] GetList();
    }
}
