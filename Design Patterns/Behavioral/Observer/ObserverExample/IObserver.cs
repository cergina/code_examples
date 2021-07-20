using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverExample
{
    /// <summary>
    /// 
    /// equivalent System.IObserver<T>
    /// </summary>
    public interface IObserver<T>
    {
        void Update(T data);
    }
}
