using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BelaLog
{
    public class LogToFile
    {
        private string _file;

        public LogToFile()
        {
            _file = @"D:/log.txt";
        }
        public LogToFile(string file)
        {
            _file = file;
        }

        public void WriteFile(string message, LogType type)
        {
            try
            {
                using (StreamWriter wr = File.AppendText(_file))
                {
                    wr.WriteLine(type.ToString()+": "+DateTime.Now.ToString() + " - " + message);
                }
            }
            catch (Exception ex)
            {                
                throw new Exception(ex.Message);
            }   
        }
        public void WriteFile(Exception ex)
        {
            try
            {
                using (StreamWriter wr = File.AppendText(_file))
                {
                    wr.WriteLine("--------");
                    wr.WriteLine(DateTime.Now.ToString() + " - EXCEPTION");
                    wr.WriteLine("Message: " + ex.Message);
                    wr.WriteLine("Source: " + ex.Source);
                    wr.WriteLine("TargetSite: " + ex.TargetSite);
                    wr.WriteLine("StackTrace: " + ex.StackTrace);
                    wr.WriteLine("InnerException: " + ex.InnerException);
                    wr.WriteLine("--------");
                }
            }
            catch { }
        }
    }
}
