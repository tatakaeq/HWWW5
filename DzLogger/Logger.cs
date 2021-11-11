using System;
using System.Linq;
using System.Text;

namespace DzLogger
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private StringBuilder _logTxt = new StringBuilder();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public void Write(Types type, string methodName, string methodMsg)
        {
            _logTxt.AppendLine($"{DateTime.UtcNow}: {type}: {methodMsg} {methodName}");
            Console.WriteLine($"{DateTime.UtcNow}: {type}: {methodMsg} {methodName}");
        }

        public void Write(Types type, string methodMsg)
        {
            _logTxt.AppendLine($"{DateTime.UtcNow}: {type}: {methodMsg}");
            Console.WriteLine($"{DateTime.UtcNow}: {type}: {methodMsg}");
        }

        public StringBuilder GetLog()
        {
            return _logTxt;
        }
    }
}