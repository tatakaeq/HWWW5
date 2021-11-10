using System;
using System.Linq;

namespace DzLogger
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();
        private string _logTxt = string.Empty;

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

        public void Write(string mssg)
        {
            _logTxt += $"{DateTime.Now}: {mssg}\n";
            Console.WriteLine($"{DateTime.Now}: {mssg}");
        }

        public string GetLog()
        {
            return _logTxt;
        }
    }
}