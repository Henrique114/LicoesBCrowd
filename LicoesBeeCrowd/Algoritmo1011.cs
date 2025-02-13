using System;

namespace LicoesBeeCrowd
{

    public class Algoritmo1011 : IBaseAlgoritmo
    {
        public void Executar()
        {
            //Faça um programa que calcule e mostre
            //o volume de uma esfera sendo fornecido
            //o valor de seu raio (R). A fórmula para calcular
            //o volume é: (4/3) * pi * R3.
            //Considere (atribua) para pi o valor 3.14159.

            /* A saída deverá ser uma mensagem "VOLUME" conforme 
             * o exemplo fornecido abaixo, com um espaço antes e 
             * um espaço depois da igualdade. O valor deverá ser 
             * apresentado com 3 casas após o ponto.*/

            float.TryParse(Console.ReadLine(), out float raio);

            const double pi = 3.14159;

            var volumeDaEsfera = (4.0 * pi * Math.Pow(raio, 3))/3;

            Console.WriteLine($"VOLUME = {volumeDaEsfera:f3}");


        }
    }
}