﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Ejercicio_3
{
    internal class ListadoProductos
    {

        [JsonPropertyName("productos")]
        public List<Producto> Productos { get; set; }


    }
}
