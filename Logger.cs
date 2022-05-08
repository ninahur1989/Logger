using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal sealed class Logger
    {
        private static Logger instance = null;
        private Logger()
        {
            Results = new List<Result>();
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        private List<Result> Results { get; set; }

        public void Addlog(Result result)
        {
            Results.Add(result);
        }

        public void Show()
        {
            foreach (Result result in Results)
            {
                string msg;
                if (result.Status == LogLevel.Error)
                {
                    msg = "Action failed by a reason: ";
                }
                else
                {
                    msg = " ";
                }

                string log = $" время: {result.DateTime} тип {result.Status} сообщение {msg}{result.Message}";
                Console.WriteLine(log);
            }
        }
    }
}
