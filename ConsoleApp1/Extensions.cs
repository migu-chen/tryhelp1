using System;

namespace CustomExtensions 
{
    public static class Extensions
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);// 將印字功能一道class
            Console.ReadLine(); 
        }
    }

}
