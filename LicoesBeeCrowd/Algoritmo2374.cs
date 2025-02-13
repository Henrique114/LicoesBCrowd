using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicoesBeeCrowd
{
    internal class Algoritmo2374 : IBaseAlgoritmo
    {
        public void Executar() {

            //Escreva um programa que, dada a pressão desejada digitada
            //pelo motorista e a pressão do pneu lida pela bomba, indica a
            //diferença entre a pressão desejada e a pressão lida.

            //variavel que recebera e guardara a pressao desejada pelo usuario.
            int.TryParse(Console.ReadLine(), out int pressaoDesejada);

            // variavel que recebera e guardara a leitura da pressao contida no pneu.
            int.TryParse(Console.ReadLine(), out int leituraDaPressao);

            // Calculo para encontrar a diferença de pressao no pneu em relaçao da pressao desejada.
            var diferençaDePressao = pressaoDesejada - leituraDaPressao;

            Console.WriteLine(diferençaDePressao);


        }
    }
}
