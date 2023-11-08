using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_pp2
{
    class Denuncia:Ticket
    {
        private Vehiculo dominio;
        static int numero;

        public Denuncia(Vehiculo asegurado)
        {
            dominio = asegurado;
            numero++;
        }

        public override int VerNro()
        {
            return numero;
        }
    }
}
