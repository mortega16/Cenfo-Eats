using System;
using System.Collections.Generic;
using CenfoEats.BackEnd.Observer.Abstract;
namespace CenfoEats.BackEnd.Observer.Concreto
{
    public class OrderSubject : Subject
    {

        private List<IObserver> observers = new List<IObserver>();
        private string currentState;

        public void SetState(string newState)
        {
            currentState = newState;
            notifyObservers(newState);
        }

        public void addObserver(Abstract.IObserver observer)
        {
            observers.Add(observer);
        }

        public void notifyObservers(string newState)
        {
            foreach (var observer in observers)
            {
                observer.update(newState);
            }
        }

        public void removeObserver(Abstract.IObserver observer)
        {
            observers.Remove(observer);
        }


    }
}

