using System;

namespace Singleton_Example
{
    class Program
    {
        #region EntryPoint
        static void Main(string[] args)
        {
            /* this wont work  
            Singleton x = new Singleton();*/

            Console.WriteLine("Creating A");
            Singleton a = Singleton.GetInstance;
            
            Console.WriteLine("Creating B");
            Singleton b = Singleton.GetInstance;

            Console.WriteLine($"Id of A is: {a.id}");
            Console.WriteLine($"Id of B is: {a.id}");

            Console.ReadLine();
        }
        #endregion
    }
}
