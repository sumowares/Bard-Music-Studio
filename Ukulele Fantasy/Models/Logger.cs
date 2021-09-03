using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;

namespace Ukulele_Fantasy.Models
{
    public static class Logger
    {
        public static NLog.Config.LoggingConfiguration Config;

        public static bool SetupLogger()
        {
            try
            {
                Config = new LoggingConfiguration();

                var logfile = new NLog.Targets.FileTarget("logfile") {FileName = "stdout.log"};
                Config.AddRule(LogLevel.Info, LogLevel.Fatal, logfile);
                NLog.LogManager.Configuration = Config;
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }
    }
}
