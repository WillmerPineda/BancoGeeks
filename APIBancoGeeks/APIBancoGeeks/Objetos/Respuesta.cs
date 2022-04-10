using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBancoGeeks.Objetos
{
    public class Respuesta
    {
        public bool Error { get; set; }
        public string MensajeError { get; set; }
        public int Resultado { get; set; }
        public Boolean PerteneceSecuencia { get; set; }
    }
}
