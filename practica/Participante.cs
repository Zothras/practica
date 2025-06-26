using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public class Participante
    {
        public string Nombre { get; set;}
        public string Apellido { get; set;}

        public string obtener_nombre_completo()
        {
            return Nombre + Apellido.ToString();
        }
    }
}
