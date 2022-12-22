﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace ToDoList.Logger
{
    public class ConsoleLogger : ILogger
    {
        private Result[] _logs;
        private Actions _actions;

        public string Format { get; set; }

        public ConsoleLogger(Actions actions, string format)
        {
            _actions = actions;
            Format = format;
        }

        public void CreateLog(string messege, string LogLevel)
        {
            switch (LogLevel)
            {
                case "Info":
                    AddLog(_actions.CreateInfo(messege));
                    break;

                case "Error":
                    AddLog(_actions.CreateError(messege));
                    break;
            }
        }

        public void AddLog(Result log)
        {
            if (_logs == null)
            {
                _logs = new Result[1] { log };
            }
            else
            {
                Array.Resize(ref _logs, _logs.Length + 1);
                _logs[_logs.Length - 1] = log;
            }
        }

        public void ShowLog()
        {
            if (Format == "json")
            {
                var json = JsonSerializer.Serialize(_logs);
                Console.Write(json);
            }
            else if (Format == "xml")
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Result[]));
                string xml;

                using var str = new StringWriter();
                using var writer = new XmlTextWriter(str);

                xmlSerializer.Serialize(writer, _logs);
                xml = str.ToString();
                Console.WriteLine(xml);
            }
        }
    }
}
