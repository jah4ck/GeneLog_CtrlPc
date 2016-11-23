using System;
using System.Diagnostics;


namespace GeneLog
{
    public class GeneLog
    {
        public static void Log(string message, int err, string codeappli)
        {
            Trace.Listeners.Add(new TextWriterTraceListener(@"C:\ProgramData\CtrlPc\LOG\Journal.log"));
            Trace.AutoFlush = true;
            string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


            if (err==1)
            {
                Trace.WriteLine(date + "     " + codeappli + "     " + "ERREUR : " + message.ToString());
            }
            else if (err==2)
            {
                 Trace.WriteLine(date + "     " + codeappli + "     " + "INFO : " + message.ToString());
            }
            

            //Trace.Listeners.Add(new EventLogTraceListener("UnzipMajPrix"));
        }
    }
}
