using System;
namespace CenfoEats.BackEnd.Observer.Abstract
{
	public interface Subject
	{
        void addObserver(IObserver observer);
        void removeObserver(IObserver observer);
        void notifyObservers(String newState);
    }
}

