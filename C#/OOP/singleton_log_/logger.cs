using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Drawing2D;

namespace singletonwin_mywork
{
       public enum loglevel
    {
        Debug,Info,Warning,Error
    }

    class Logger
    {

        private static Logger _instant;

        private Logger() { }
        public static Logger Instant
        {
            get
            {
                if (_instant == null)
                {
                    return _instant = new Logger();
                }
                else
                {
                    return _instant;
                }
            }
        }

        private loglevel minloglevel = loglevel.Debug;
        private string FIlePath = "app.log";

        public void setFilePath(string path)
        {
            this.FIlePath = path;
        }

        private void Log(loglevel level,string message)
        {
            string line = "Level:" + level + ",date:" + DateTime.Now + ",message:" + message+"\n";
            File.AppendAllText(this.FIlePath, line);
        }

        public void Debug(string message)
        {
            Log(loglevel.Debug,  message);
        }

        public void Info(string message)
        {
            Log(loglevel.Info, message);

        }
        public void Warning(string msg)
        {
            Log(loglevel.Warning, msg);
        }

        public void Error(string msg)
        {
            Log(loglevel.Error, msg);
        }
    }




}
