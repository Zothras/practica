﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public class Conferencia:Evento
    {
        public string Principal { get; set; }

        public override string obtener_descripcion()
        {
            return $"{base.obtener_descripcion()} tema principal: {Principal}";
        }
    }
}
