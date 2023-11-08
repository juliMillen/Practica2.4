using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace practica_pp2
{
    class Vehiculo
    {
        private string patente;
        private NuevoCliente dueño;

        public string Patente
        {
            get { return patente; }
            private set { patente = value; }
        }
        public Vehiculo(string patente)
        {
            this.patente = patente;
        }

        public NuevoCliente VerDueño()
        {
            if(dueño != null)
            {
                dueño = new NuevoCliente(0000000000, 1);
            }
            else
            {
                throw new Exception("error!!!");
            }
            return dueño;
        }
    }
}
