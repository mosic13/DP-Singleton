using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonProject
{
    public class Singleton
    {
        //Step 2 : static member
        private static Singleton singleInstance = null;

        public int Count { get; set; }
        public string Name { get; set; }


        //Step 1 : hides the default constructor
        private Singleton()
        {
            Console.WriteLine("Singleton: Initializing Instance");
        }

        //Step 3 : Make a static public method
        public static Singleton GetInstance()
        {
            //Step 3 : Checks if the object is not created
            if (singleInstance == null)
                singleInstance = new Singleton();

            return singleInstance;
        }
    }
}
