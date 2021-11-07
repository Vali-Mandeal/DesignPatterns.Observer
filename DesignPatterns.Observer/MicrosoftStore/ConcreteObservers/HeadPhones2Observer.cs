using System;

namespace DesignPatterns.Observer.MicrosoftStore.ConcreteObservers
{
    public class Headphones2Observer : IObserver
    {
        public void Update(ISubject subject)    
        {
            if ((subject as SalesSubject).State == Product.Headphones2 )
                Console.WriteLine($"    - As {GetType().Name} I am interested in this change." );
        }
    }
}   
