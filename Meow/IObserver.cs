using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow
{
    public interface IObserver
    {
        void LogOperation(string logText);
    }
}
