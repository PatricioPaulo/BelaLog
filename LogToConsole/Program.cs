using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BelaLog;

namespace LogToConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;

            System.IO.StreamReader file = LogToConsoleControl.FileToRead("D:\\File.txt");
            if (file != null)
            {
                while ((line = file.ReadLine()) != null)
                {
                    string[] arrayLine = line.Split(':');
                    if (arrayLine[0] == LogType.Error.ToString())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine(line);
                    }
                    if (arrayLine[0] == LogType.Warning.ToString())
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.WriteLine(line);
                    }
                    if (arrayLine[0] == LogType.Message.ToString())
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Console.WriteLine(line);
                    }                        
                }
                file.Close();
            }
            else
            {
                System.Console.WriteLine("file doesn't exist.");
            }
            System.Console.ReadLine();
        }
    }
}
