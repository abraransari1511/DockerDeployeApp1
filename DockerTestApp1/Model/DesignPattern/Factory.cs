using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerTestApp1.Model.DesignPattern
{
    interface customer
    {

    }

    class customerclassA : customer
    {
    }

    class customerclassB : customer
    {
    }

    abstract class classA
    {
        public abstract customer FactoryMethod(string type);
    }

    class classB : classA
    {
        public override customer FactoryMethod(string type)
        {
            switch (type)
            {
                case "A": return new customerclassA();
                case "B": return new customerclassB();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
