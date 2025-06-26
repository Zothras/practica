using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public class Taller : Evento
    {
        public int CapacidadMaxima = 2;

        public override string obtener_descripcion()
        {
            return $"{base.obtener_descripcion} la capacidad maxima es {CapacidadMaxima}";


        }
    }
}
 