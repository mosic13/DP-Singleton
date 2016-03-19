using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonProject
{
    public class Singleton
    {
        //static member
        private static Singleton singleInstance = null;

        public int Count { get; set; }
        public string Name { get; set; }


        //hides the default constructor
        private Singleton()
        {
            Console.WriteLine("Singleton: Initializing Instance");
        }

        public static Singleton GetInstance()
        {
            //Checks if the object is not created
            if (singleInstance == null)
                singleInstance = new Singleton();

            return singleInstance;
        }
    }
}
