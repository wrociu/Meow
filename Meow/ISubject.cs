using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meow
{
    interface ISubject
    {
        List<IObserver> Observers { get; set; }

        void Register(IObserver observer);
        void Unregister(IObserver observer);

        void LogOperation(string logText);
    }
}
