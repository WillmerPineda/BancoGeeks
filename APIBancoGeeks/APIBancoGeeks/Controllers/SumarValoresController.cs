using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIBancoGeeks.Modelos;
using APIBancoGeeks.Modelos.Complejos;
using APIBancoGeeks.Objetos;
using APIBancoGeeks.Funciones;
using Microsoft.AspNetCore.Cors;

namespace APIBancoGeeks.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("GPolicy")]
    public class SumarValoresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Respuesta> Suma(int PrimerValor, int SegundoValor)
        {
            Respuesta RespuestaControlador = new Respuesta();
            ObtenerLista Fibonacci = new ObtenerLista();
            BancoGeeksContext Contexto = new BancoGeeksContext();

            try
            {
                List<int> ListaFibonacci = Fibonacci.ObtenerFibonacci();
                int Resultado = PrimerValor + SegundoValor;

                bool Secuencia = ListaFibonacci.Any(x => x == Resultado);

                ValoresSumados_Result ModeloInsertar = new ValoresSumados_Result();
                ModeloInsertar.PrimerValor = PrimerValor;
                ModeloInsertar.SegundoValor = SegundoValor;
                ModeloInsertar.Resultado = Resultado;
                ModeloInsertar.Secuencia = Secuencia;

                Contexto.ValoresSumados.Add(ModeloInsertar);
                Contexto.SaveChanges();
               

                RespuestaControlador.Resultado = Resultado;
                RespuestaControlador.PerteneceSecuencia = Secuencia;

            }
            catch (Exception ex)
            {
                RespuestaControlador.Error = true;
                RespuestaControlador.MensajeError = ex.InnerException.ToString();
            }


            return RespuestaControlador;
        }
    }
}