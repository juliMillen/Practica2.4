using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_pp2
{
    class Ticket
    {
        private int nroOrden;
        private DateTime fechaHora;

        public int NroOrden
        {
            get { return nroOrden; }
            private set { nroOrden = value; }
        }

        public DateTime FechaHora
        {
            get { return fechaHora; }
            private set { fechaHora = value; }
        }
        public virtual int VerNro()
        {
            return nroOrden;
        }

        public virtual DateTime VerFechaHora()
        {
            return fechaHora;
        }

    }
}
