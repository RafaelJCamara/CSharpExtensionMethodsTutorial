using System;

namespace ExtensionMethods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.LogError("NullException", "Object reference was null.");
            AnotherLogger anotherLogger = new AnotherLogger();
            anotherLogger.LogError("DivisionByZero", "Can't divide by zero.");
        }
    }
    
    public interface ILogger
    {
        void Log(string message);
    }

    public static class LoggerExtensions
    {
        public static void LogError(this ILogger logger, string errorType, string message)
        {
            Console.WriteLine($"Error {errorType}: {message}");
        }
    }
    

    /*
     * Let's assume this is given in a third party library
     */
    
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logged message: {message}");
        }
    }

    public class AnotherLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logged message in another logger: {message}");
        }
    }
    
}