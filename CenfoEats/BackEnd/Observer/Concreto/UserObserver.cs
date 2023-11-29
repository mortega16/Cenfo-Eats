using System;
using CenfoEats.BackEnd.Observer.Abstract;
namespace CenfoEats.BackEnd.Observer.Concreto
{
    public class UserObserver : IObserver
    {
        private string username;

        public UserObserver(string username)
        {
            this.username = username;
        }

        public void update(string newState)
        {
            Console.WriteLine($"Usuario {username}: El estado del pedido ha cambiado a {newState}");
        }
    }
}

