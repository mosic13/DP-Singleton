using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SingletonProject;

namespace Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton a = Singleton.GetInstance();
            Console.WriteLine("Singleton: {0}, Hash:{1}", a.Name == null ? "null  " : a.Name, a.GetHashCode());

            a.Name = "Monali";

            Singleton b = Singleton.GetInstance();
            Console.WriteLine("Singleton: {0}, Hash:{1}", b.Name, b.GetHashCode());

            Singleton c = Singleton.GetInstance();
            Console.WriteLine("Singleton: {0}, Hash:{1}", c.Name, c.GetHashCode());

            Singleton d = Singleton.GetInstance();
            Console.WriteLine("Singleton: {0}, Hash:{1}", d.Name, d.GetHashCode());

            a.Count = 15;
            Singleton e = Singleton.GetInstance();
            Console.WriteLine("Singleton: {0}, Hash:{1}", e.Name, e.GetHashCode());

            Console.ReadLine();
        }
    }
}
