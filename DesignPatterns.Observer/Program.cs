using DesignPatterns.Observer.MicrosoftStore;
using System.Collections.Generic;
using DesignPatterns.Observer.MicrosoftStore.ConcreteObservers;
using System.Threading;

namespace DesignPatterns.Observer
{
    class Program
    {
        private static SalesSubject _salesSubject;
        private static List<IObserver> _observers;

        static void Main()
        {
            _salesSubject = new();

            InitObservers();
            AttachObservers();

            while (true)
            {
                _salesSubject.PublishNextSale();
                Thread.Sleep(4000);
            }
        }

        static void InitObservers()
        {
            _observers = new();

            _observers.Add(new MicrosoftNerdObserver());
            _observers.Add(new Laptop4Observer());
            _observers.Add(new SurfaceProObserver());
            _observers.Add(new Headphones2Observer());
        }

        static void AttachObservers()   
        {
            foreach (var observer in _observers)
                _salesSubject.Attach(observer);     
        }
    }
}
