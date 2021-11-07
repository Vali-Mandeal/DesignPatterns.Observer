using System;

namespace DesignPatterns.Observer.MicrosoftStore.ConcreteObservers
{
    public class Laptop4Observer : IObserver
    {
        public void Update(ISubject subject)    
        {
            if ((subject as SalesSubject).State == Product.Laptop4 )
                Console.WriteLine($"    - As {GetType().Name} I am interested in this change." );
        }
    }   
}
