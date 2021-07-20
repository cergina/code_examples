/* ---------------------------------------------- 
        2020_MarosCerget:github:cergina
----------------------------------------------- */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    /// <summary>
    /// Allow observer to register at the provider
    /// 
    /// If sth predefined happens => inform/notify all 
    /// registered observers by calling their methods
    /// </summary>
    public class Program
    {
        #region EntryPoint
        static void Main(string[] args)
        {
            // INITS
            var milkToTrack = new Subject("TAMI", 1, true);

            var billa = new AvailabilityObserver("Billa");
            var lidl = new AvailabilityObserver("Lidl");
            var metro = new AvailabilityObserver("METRO");


            // LOGIC
            Console.WriteLine("\n     !!Register the first shop\n");
            milkToTrack.Subscribe(billa);

            Console.WriteLine("\n     !!Change the availability of product\n");
            milkToTrack.Set(true);

            Console.WriteLine("\n     !!Register the second shop\n");
            milkToTrack.Subscribe(lidl);

            Console.WriteLine("\n     !!Change the availability of product\n");
            milkToTrack.Set(false);

            Console.WriteLine("\n     !!Register the third shop and unregister first\n");
            milkToTrack.Unsubscribe(billa);
            milkToTrack.Subscribe(metro);

            Console.WriteLine("\n     !!Change the availability of product\n");
            milkToTrack.Set(true);

            // EOP
            Console.ReadLine();
        }
        #endregion
    }
}
