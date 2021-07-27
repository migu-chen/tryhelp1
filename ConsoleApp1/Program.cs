using CustomExtensions;
using System;

namespace ConsoleApp1

{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string demo = "This is a demo ?";
            //demo.PrintToConsole();
            "This is a demo ?".PrintToConsole();
            ISimpleLogger logger = new SimpleLogger();
            logger.Log("Test Error", "ERror");
            logger.LogError("This is an Error !  ");
            logger.LogWarning("This is an Warning!");
            Console.WriteLine("Goodby!!");
            Console.ReadLine();
        }
    }
}

namespace ConsoleApp1
{
    public class SimpleLogger : ISimpleLogger

    {
        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }


        public void Log(string message, string messageType)
        {
            Log($"{ messageType}:{ message }");
        }
    }
}