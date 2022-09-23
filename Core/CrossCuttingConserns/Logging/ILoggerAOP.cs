using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConserns.Logging
{
    public interface ILoggerAOP
    {
        void Log(string var, string var2);
    }
}
