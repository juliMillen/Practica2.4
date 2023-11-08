using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace practica_pp2
{
    class Agencia
    {
        public List<Ticket> listaAtendidos = new List<Ticket>();
        private Queue<NuevoCliente> nuevos = new Queue<NuevoCliente>();
        private Queue<Denuncia> denuncias = new Queue<Denuncia>();
        private List<Vehiculo> listaVehiculos = new List<Vehiculo>();


        public void AgregarTicket(Ticket turno)
        {
            listaAtendidos.Add(turno);
        }

        public void AtenderTicket(int tipo)
        {

        }

        public Vehiculo BuscarVehiculo(string patente)
        {
            Vehiculo aBuscar = new Vehiculo(patente);
            listaVehiculos.Sort();
            int orden = listaVehiculos.BinarySearch(aBuscar);

            if (orden >= 0)
            {
                aBuscar = listaVehiculos[orden];
            }
            else
            {
                aBuscar = null;
            }
            return aBuscar;
        }
    }
}
