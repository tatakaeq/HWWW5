using System;
using System.IO;

namespace DzLogger
{
    public class Starter
    {
        private const int Count = 100;
        private Logger _logger = Logger.Instance;
        private Actions _acts = new Actions();
        public void Run()
        {
            var rnd = new Random();
            var res = new Result();
            for (var i = 0; i < Count; i++)
            {
                var chMeth = rnd.Next(1, 4);
                res = chMeth switch
                {
                    1 => _acts.Meth1(),
                    2 => _acts.Meth2(),
                    _ => _acts.Meth3()
                };

                if (!res.Status)
                {
                    _logger.Write(Types.Error, res.ErrMessage);
                }
            }

            var logTxt = Logger.Instance.GetLog();
            File.WriteAllText("log.txt", logTxt.ToString());
        }
    }
}