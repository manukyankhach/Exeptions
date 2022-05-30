using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsAndlogs
{
    public interface ILogger
    {
        void Log(string input);
        string CreateLog(Exception ex);
    }
}
