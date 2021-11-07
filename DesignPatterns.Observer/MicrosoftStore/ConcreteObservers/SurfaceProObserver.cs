using System;

namespace DesignPatterns.Observer.MicrosoftStore.ConcreteObservers
{
    public class SurfaceProObserver : IObserver
    {
        public void Update(ISubject subject)    
        {
            if ((subject as SalesSubject).State == Product.SurfacePro8 )
                Console.WriteLine($"    - As {GetType().Name} I am interested in this change." );
        }
    }
}
