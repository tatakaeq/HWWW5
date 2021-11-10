using System;
using System.IO;

namespace DzLogger
{
    public class Starter
    {
        private int _count = 100;
        public void Run()
        {
            var acts = new Actions();
            var rnd = new Random();
            var res = new Result();
            var accptdLogStr = string.Empty;
            for (var i = 0; i < _count; i++)
            {
                var chMeth = rnd.Next(1, 4);
                res = chMeth switch
                {
                    1 => acts.Meth1(),
                    2 => acts.Meth2(),
                    _ => acts.Meth3()
                };

                if (res.Status == false)
                {
                    Logger.Instance.Write($"{Types.Error}: Action failed by a reason: {res.ErrMessage}");
                }
            }

            var logTxt = Logger.Instance.GetLog();
            File.WriteAllText("log.txt", logTxt);
        }
    }
}