using System;

namespace Singleton
{
    public sealed class Logger
    {
        private Logger()
        {
            Console.WriteLine("logger instance is created");
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
        private static readonly Lazy<Logger> obj = new Lazy<Logger>(() => new Logger());
        public static Logger Instance
        {
            get
            {
                return obj.Value;
            }
        }
    }
}

