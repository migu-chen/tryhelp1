using System;

namespace ConsoleApp1

{
    public static class ExtendSimpleLogger
    {
        public static void LogError(this ISimpleLogger logger,String message)
        {
            var defautColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            logger.Log(message, "Error");
            Console.ForegroundColor = defautColor;
        }
        public static void LogWarning(this ISimpleLogger logger, String message)
        {
            var defautColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            logger.Log(message, "Warning");
            Console.ForegroundColor = defautColor;
        }

    }
}
