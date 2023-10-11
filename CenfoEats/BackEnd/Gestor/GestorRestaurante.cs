using CenfoEats.BackEnd.Prototipo.Prototipo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace CenfoEats.BackEnd.Gestor
{
    public class GestorRestaurante {
        private int idRestaurantePH;
        private int idRestauranteBK;
        private static List<RestaurantePrototype> listaRestaurantesPH = new List<RestaurantePrototype>();
        private static List<RestaurantePrototype> listaRestaurantesBK = new List<RestaurantePrototype>();
        private RestaurantePrototype prototipoPizzaHut;
        private RestaurantePrototype prototipoBurgerKing;

        public GestorRestaurante(int pidRestaurantePH, int pidRestauranteBK)
        {
            idRestaurantePH = pidRestaurantePH;
            idRestauranteBK = pidRestauranteBK;
            prototipoPizzaHut = new RestaurantePizzaHut(pidRestauranteBK, "Pizza Hut", "Sabana norte", "22223747");
            prototipoBurgerKing = new RestauranteBurgerKing(pidRestauranteBK, "Burger King", "Tibas", "20208742");

        }

        public void nuevoPizzaHut( string direccion, string telefono)

        {
            prototipoPizzaHut = new RestaurantePizzaHut(idRestaurantePH, "Pizza Hut", direccion, telefono);
            listaRestaurantesPH.Add(prototipoPizzaHut.Clone());
            idRestaurantePH++;


        }
        public void nuevoBurgerKing( string direccion, string telefono)
        {
            prototipoBurgerKing = new RestauranteBurgerKing(idRestauranteBK, "Burger King", direccion, telefono);
            listaRestaurantesBK.Add(prototipoBurgerKing.Clone());
            idRestauranteBK++; 
        }


        public string obtenerDatosPH(int id)
        {
            return obtenerDatosObjeto(listaRestaurantesPH[id]);
        }

        public string obtenerDatosBK(int id)
        {
            return obtenerDatosObjeto(listaRestaurantesBK[id]);
        }

        public string obtenerDatosPH()
        {
            string mensaje="";
            foreach (RestaurantePrototype mOb in listaRestaurantesPH)
            {
                mensaje += obtenerDatosObjeto(mOb);
            }

            return mensaje; 
            
        }
        public string obtenerDatosBK()
        {
            string mensaje = "";
            foreach (RestaurantePrototype mOb in listaRestaurantesBK)
            {
                mensaje += obtenerDatosObjeto(mOb)+"\n";
            }

            return mensaje;

        }


        private string obtenerDatosObjeto(RestaurantePrototype pObj)
        {
            return pObj.infoRestaurante() + "\n";
        }
    }
}
