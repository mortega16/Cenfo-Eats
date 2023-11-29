using System;
namespace CenfoEats.BackEnd.Observer.Abstract
{
	public interface IObserver
	{
        void update(String newState);
    }
}

