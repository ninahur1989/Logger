using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Actions
    {
        public Result Info()
        {
            return new Result(LogLevel.Info, "Start method: ", DateTime.Now);
        }

        public Result Warning()
        {
            return new Result(LogLevel.Warning, "Skipped logic in method: ", DateTime.Now);
        }

        public Result Error()
        {
            return new Result(LogLevel.Error, "I broke a logic ", DateTime.Now);
        }
    }
}
