using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsAndlogs
{
    public class Logger : ILogger
    {
        public string CreateLog(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("----------------------------");
            stringBuilder.AppendLine(ex.Data.ToString());
            stringBuilder.AppendLine(ex.Message);
            stringBuilder.AppendLine(ex.Source);
            return stringBuilder.ToString();
        }

        public void Log(string input)
        {
            var path = Directory.GetCurrentDirectory();
            path = Path.Combine(new string[] { path, "Logs" });
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path = Path.Combine(new string[] { path, "logs.txt" });
            if (!File.Exists(path))
                File.CreateText(path);
            File.AppendAllText(path, input);
        }
    }
}
