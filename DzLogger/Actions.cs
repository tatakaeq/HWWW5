using System;
using System.Reflection;

namespace DzLogger
{
    public class Actions
    {
        private Logger _logger = Logger.Instance;
        public Result Meth1()
        {
            var res = new Result();
            var methodName = nameof(Meth1);
            var methodMsg = "Start method:";
            _logger.Write(Types.Info, methodName, methodMsg);
            res.Status = true;
            return res;
        }

        public Result Meth2()
        {
            var res = new Result();
            var methodName = nameof(Meth2);
            var methodMsg = "Skipped logic in method:";
            _logger.Write(Types.Warning, methodName, methodMsg);
            res.Status = true;
            return res;
        }

        public Result Meth3()
        {
            var res = new Result();
            res.ErrMessage = "I broke a logic";
            return res;
        }
    }
}