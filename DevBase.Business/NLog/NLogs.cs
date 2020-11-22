using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBase.Business.NLog
{
    public class NLogs : INLog
    {
        public void Eror(string mesaj)
        {
            var logger = LogManager.GetLogger("Logger");
            logger.Log(LogLevel.Error, mesaj);
        }
    }
}
