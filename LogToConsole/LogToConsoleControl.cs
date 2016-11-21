using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogToConsole
{
    public class LogToConsoleControl
    {
        public static StreamReader FileToRead(string file)
        {
            if(File.Exists(file))
            {
                System.IO.StreamReader _file = new System.IO.StreamReader(file);
                return _file;
            }
            else
            {
                return null;
            }            
        }
        
    }
}
