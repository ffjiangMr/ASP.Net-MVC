namespace WebApplication.Logger
{
    #region using directive

    using System;
    using System.IO;

    #endregion 

    public class FileLogger
    {
        public void LogException(Exception e)
        {
            File.WriteAllLines("C://Error//" + DateTime.Now.ToString("dd-MM-yyyy mm hh ss") + ".txt", new String[] {
                "Message:"+e.Message,
                "Stacktrace:" +e.StackTrace,
            });
        }
    }
}