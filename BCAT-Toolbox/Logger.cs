using System;
using System.IO;

namespace BcatToolbox
{
    public class Logger
    {
        public static string p_out = Utils.output + Path.DirectorySeparatorChar + "log.txt";
        public enum LogLevel
        {
            Info,
            Warning,
            Error,
            Debug
        }

        public static void Info(string message, LogLevel Info)
        {
            LogExists();

            var time = DateTime.Now.ToString("[HH:mm:ss]");
            var l = time + " " + "(Info):" + " " + message;

            using StreamWriter sw = new StreamWriter(p_out, true);
            sw.WriteLine(l);
        }

        public static void Warning(string message, LogLevel Warning)
        {
            LogExists();

            var time = DateTime.Now.ToString("[HH:mm:ss]");
            var l = time + " " + "(Warning):" + " " + message;
            using StreamWriter sw = new StreamWriter(p_out, true);
            sw.WriteLine(l);
        }

        public static void Error(string message, LogLevel Error)
        {
            LogExists();

            var time = DateTime.Now.ToString("[HH:mm:ss]");
            var l = time + " " + "(Error):" + " " + message;
            using StreamWriter sw = new StreamWriter(p_out, true);
            sw.WriteLine(l);
        }

        public static void Debug(string message, LogLevel Debug)
        {
            LogExists();

            var time = DateTime.Now.ToString("[HH:mm:ss]");
            var l = time + " " + "(Debug):" + " " + message;
            using StreamWriter sw = new StreamWriter(p_out, true);
            sw.WriteLine(l);
        }

        public static void DateAndCheck()
        {
            LogExists();

            var time = DateTime.Now.ToString("dd/MM/yyyy") + "\n";
            var l = "Current Day: " + time;
            var text = File.ReadAllText(p_out);

            if (!text.Contains(l))
            {
                using StreamWriter sw = new StreamWriter(p_out, true);
                sw.WriteLine(l);
            }
        }

        private static void LogExists()
        {
            if (!File.Exists(p_out))
            {
                File.Create(p_out);
            }
        }
    }
}