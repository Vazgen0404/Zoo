using System;
using System.IO;

namespace Zoo
{
    class LogWriter
    {
        private static LogWriter _logWriter;
        private LogWriter()
        {

        }
        public static LogWriter CreateOrGetLogWriter()
        {
            if (_logWriter == null)
                _logWriter = new LogWriter();
            return _logWriter;
        }
        public void LogWrite(MyException myException)
        {
            string path = @".\" + DateTime.Now.ToString("MM.dd.yyyy") + @"\" + myException.MessageType + ".txt";
            string dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            Directory.CreateDirectory(@".\" + DateTime.Now.ToString("MM.dd.yyyy"));

            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(myException.MessageType + "\t" + dateTime + "\t" + myException.Message);
            }
        }
    }
}
