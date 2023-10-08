using CenfoEats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenfoEats
{
    public class Restaurante : RestaurantePrototype
    {
        public override object Clone()
        {
            // Realiza una copia profunda del restaurante
            return new Restaurante
            {
                Nombre = this.Nombre,
                Direccion = this.Direccion,
                Telefono = this.Telefono
            };
        }
    }

}

// Otros Aspectos

// Crear instancias de prototipos de restaurantes
// RestaurantePrototype PizzahutPrototipo = new Restaurante { Nombre = "Restaurante A", Direccion = "Dirección A", Telefono = "Teléfono A" };
// RestaurantePrototype restauranteB = new Restaurante { Nombre = "Restaurante B", Direccion = "Dirección B", Telefono = "Teléfono B" };
// RestaurantePrototype PizzahutSanPedro = PizzahutPrototipo.clone();
// PizzahutSanPedro.Direcciom = "San Pedro"


// Clonar objetos de restaurantes según sea necesario
// RestaurantePrototype copiaRestauranteA = manager.ObtenerPrototipo("RestauranteA") as RestaurantePrototype;