// <auto-generated />
namespace Work_with_class
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logs = new Logger();
            Console.WriteLine("Enter the log type: Error, Info, Warning or All");
            logs.LogLevel = Console.ReadLine();

            Starter.Run(logs);

            logs.PrintLog();
        }
    }
}