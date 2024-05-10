﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Ejercicio_3
{
    internal class Dimension
    {

        [JsonPropertyName("alto")]
        public int Alto { get; set; }


        [JsonPropertyName("ancho")]
        public int Ancho { get; set; }


        [JsonPropertyName("profundidad")]
        public int Profundidad { get; set; }

    }
}
