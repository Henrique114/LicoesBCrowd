using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicoesBeeCrowd
{
    internal class Algoritmo1019 : IBaseAlgoritmo
    {
        public void Executar() 
        {
            // Transfornar a duração de tempo de segundos para o formato hh:mm:ss.

            //variavel que guarda o tempo em segundos.
            Int32.TryParse(Console.ReadLine(), out Int32 tempoEmSegundos);

            //formatação do tempo em hh:mm:ss com TimeSpan
            var tempoCompleto = TimeSpan.FromSeconds(tempoEmSegundos);

            //variavwl para horas.
            var horas = tempoCompleto.Hours;

            //variavwl para minutos.
            var minutos = tempoCompleto.Minutes;

            //variavwl para segundos.
            var segundos = tempoCompleto.Seconds;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");


        }
    }
}
