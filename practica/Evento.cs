using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public class Evento
    {
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public string Ubicacion { get; set; }

        public List<Participante> Participante { get; set; } = new();

        public virtual string obtener_descripcion()

        
          {
            return $"{Nombre}, ën la fecha {Fecha}, en su ubicacion {Ubicacion}";


        }
        

        public void Inscribir_Participante(Participante participante)
        {
            Participante.Add(participante);

        
        }
    }
}
