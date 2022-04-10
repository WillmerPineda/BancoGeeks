using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIBancoGeeks.Modelos.Complejos
{
    public class ValoresSumados_Result
    {
        [Key]
        public int Id { get; set; }
        public int PrimerValor { get; set; }
        public int SegundoValor { get; set; }
        public int Resultado { get; set; }
        public bool Secuencia { get; set; }
    }
}
