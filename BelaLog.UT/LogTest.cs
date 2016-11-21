using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BelaLog;
using LogToConsole;

namespace BelaLog.UT
{
    [TestClass]
    public class LogTest
    {
        [TestMethod]
        public void Logging()
        {
            LogToFile log = new LogToFile("D:\\File.txt");
            log.WriteFile("Error Message Test", LogType.Error);
            log.WriteFile("Warning Message Test", LogType.Warning);
            log.WriteFile("Message Test", LogType.Message);
            
        }

        [TestMethod]
        public void fileReader()
        {
            string _file = "D:\\Files.txt";
            System.IO.StreamReader file = LogToConsoleControl.FileToRead(_file);
            try
            {
               Assert.IsNotNull(file);
            }
            catch (AssertFailedException ex)
            {
                throw new AssertFailedException(ex.Message);
            }
            
        }
    }
}
