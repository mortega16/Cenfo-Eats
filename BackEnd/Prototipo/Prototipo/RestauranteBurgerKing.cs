using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats.BackEnd.Prototipo.Prototipo
{
    public class RestauranteBurgerKing : RestaurantePrototype

    {
        public RestauranteBurgerKing(int id, string nombre, string direccion, string telefono)
        {
            this.Id=id;
            this.Nombre =nombre;
            this.Direccion=direccion;
            this.Telefono = telefono;   
        }
        public override RestaurantePrototype Clone()
        {
            // Realiza una copia profunda del restaurante
            return new RestauranteBurgerKing
                (Id = this.Id,
                Nombre = this.Nombre,
                Direccion = this.Direccion,
                Telefono = this.Telefono); ;
        }
    }
}
