using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app
{
    // "sealed" means it cannot be overwritten
    public sealed class Mediator
    {
        // we will only allow one instance created
        private static readonly Mediator _Instance = new Mediator();

        // and in order to forbid creation of new instances we will make contructor do nothing
        private Mediator() { }

        // only one way to get it instantiated is to call this method
        public static Mediator GetInstance()
        {
            return _Instance;
        }

        // Instance functionality
    }
}
