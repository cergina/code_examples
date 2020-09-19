using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    public class Subject : ISubject<bool>
    {
        #region Attributes
        // list of observers that are interested in availability of this subject
        private List<IObserver<bool>> AvailabilityObservers = new List<IObserver<bool>>();
        public string ProductName { get; private set; }
        public int ProductPrice { get; private set; }
        //this attribute is point of interest to observers
        public bool Availability { get; private set; }
        #endregion

        #region Constructor
        public Subject(string name, int price, bool availability)
        {
            ProductName = name;
            ProductPrice = price;
            Availability = availability;
        }
        #endregion

        #region Public Methods
        // tell observers the current availability status
        public void Notify()
        {
            foreach (IObserver<bool> observer in AvailabilityObservers)
            {
                observer.Update(Availability);
            }
        }

        public void Subscribe(IObserver<bool> observer)
        {
            AvailabilityObservers.Add(observer);
            Notify();
        }

        public void Unsubscribe(IObserver<bool> observer)
        {
            AvailabilityObservers.Remove(observer);
        }

        public void Set(string Name)
        {
            ProductName = Name;
        }

        public void Set(int Price)
        {
            ProductPrice = Price;
        }

        // only change of availability triggers notification
        public void Set(bool Availability)
        {
            this.Availability = Availability;
            Notify();
        }
        #endregion
    }
}
