using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBancoGeeks.Funciones
{
    public class ObtenerLista
    {
        public List<int> ObtenerFibonacci()
        {
            List<int> ListaRetornar = new List<int>();

            int a = 0;
            int b = 1;
            int auxiliar = 0;
            for (int i = 0; i < 100; i++)
            {
                auxiliar = a;
                a = b;
                b = auxiliar + a;
                ListaRetornar.Add(a);
            }

            return ListaRetornar;

        }
    }
}
