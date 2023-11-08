using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_pp2
{
    class NuevoCliente:Ticket
    {
        private long dni;
        static int numeros;

        public long Dni
        {
            get { return dni; }
            set
            {
                if (dni < 5000000) throw new Exception("Error en el dni");
                dni = value;
            }
        }
        public NuevoCliente(long dni, int tipoVehiculo)
        {
            this.dni = dni;
            numeros++;
        }

        public override int VerNro()
        {
            return numeros;
        }
    }
}
