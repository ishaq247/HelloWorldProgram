using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedAPI.Repository
{
    public class LogFile : WriteToRepository
    {
        private static readonly log4net.ILog logs = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public override void Write(string text)
        {
            logs.DebugFormat(text);
        }

        public void CreateLogFile()
        {
            try
            {
                string path = ConfigurationManager.AppSettings["LogFileName"];
                bool enableLog = Convert.ToBoolean(ConfigurationManager.AppSettings["EnableLog"].ToString());
                if (enableLog)
                {
                    if (!File.Exists(path))
                    {
                        File.Create(path);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
