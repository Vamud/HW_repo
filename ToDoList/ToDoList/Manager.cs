// <auto-generated />

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Logger;

namespace ToDoList
{
    public class Manager
    {
        private ICreate _creator;
        private ToDoList _list;
        private Remover _remover;
        private Demonstrator _demonstrator;
        private Updater _updater;
        private ILogger _logger;

        public Manager(ICreate creator, ILogger logger)
        {
            _creator = creator;
            _list = new ToDoList();
            _remover = new Remover();
            _demonstrator = new Demonstrator();
            _updater = new Updater();
            _logger = logger;
        }

        public void SelectCommand ()
        {
            string? command = Communicate.WriteRead("Commands: add, delete, get all, update, exit");

            switch (command)
            {
                case "add":
                    CreatTask();
                    _logger.CreateLog("Add task", "Info");
                    break;
                case "delete":
                    _remover.Delete(_list);
                    _logger.CreateLog("Delete task", "info");
                    _logger.ShowLog();
                    break;
                case "get all":
                    _demonstrator.GetAll(_list);
                    break;
                case "update":
                    _updater.Update(_list, _creator);
                    break;
                case "exit":
                    return;
            }

            SelectCommand();
        }

        public void CreatTask ()
        {
            string? addType = Communicate.WriteRead("Commands: add-item, add-reminder, add-reminder-rc");

            _list.AddTask(_creator.CreateItem(addType));
        }
    }
}
