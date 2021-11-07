using System;

namespace DesignPatterns.Observer.MicrosoftStore.ConcreteObservers
{   
    public class MicrosoftNerdObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if (Enum.IsDefined(typeof(Product), (subject as SalesSubject).State))
                Console.WriteLine($"    - As {GetType().Name} I am interested in this change.");
        }
    }
}

