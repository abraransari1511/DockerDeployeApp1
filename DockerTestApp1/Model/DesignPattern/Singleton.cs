using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace DockerTestApp1.Model.DesignPattern
{
    public class Singleton
    {
        private Singleton()
        {

        }
        public volatile static Singleton singletonObject = null;
        public static Singleton GetSingletonInstance()
        {
            object lockingObject = new object();
            if (singletonObject==null)
            {
                lock (lockingObject)
                {
                    if (singletonObject == null)
                    {
                        singletonObject = new Singleton();
                    }
                }
            }
            return singletonObject;
        }

    }
}
