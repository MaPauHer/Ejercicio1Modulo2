using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2.Ejercicio_2
{
    internal class Juego
    {


        [JsonPropertyName("estadistica")]
        public List<Equipo> Estadistica { get; set; }


    }
}
