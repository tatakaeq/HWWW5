using System;
using System.Reflection;

namespace DzLogger
{
    public class Actions
    {
        private Result _res = new Result();
        public Result Meth1()
        {
            var methodName = MethodBase.GetCurrentMethod()?.Name;
            Logger.Instance.Write($"{Types.Info}: Start method: {methodName}");
            _res.Status = true;
            return _res;
        }

        public Result Meth2()
        {
            var methodName = MethodBase.GetCurrentMethod()?.Name;
            Logger.Instance.Write($"{Types.Warning}: Skipped logic in method: {methodName}");
            _res.Status = true;
            return _res;
        }

        public Result Meth3()
        {
            _res.Status = false;
            _res.ErrMessage = "I broke a logic";
            return _res;
        }
    }
}