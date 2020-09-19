using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class AvailabilityObserver : IObserver<bool>
    {
        // interested in this and need to keep it up to date
        public bool ProductIsAvailable { get; private set; } = false;
        public string Name { get; private set; } = null;

        public AvailabilityObserver(string Name)
        {
            this.Name = Name;
        }

        public void Update(bool dataUpdate)
        {
            Console.WriteLine($"{Name} will change it's availability of the tracked subject from {Translate(ProductIsAvailable)} to {Translate(dataUpdate)}");
            ProductIsAvailable = dataUpdate;
        }

        private string Translate(bool avail)
            => avail ? "Available" : "Not available";
    }
}
