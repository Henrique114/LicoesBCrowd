namespace LicoesBeeCrowd
{
    internal class Algoritmo1014 : IBaseAlgoritmo
    {

        public void Executar()
        {
             Int32.TryParse(Console.ReadLine(), out Int32 distanciaPercorrida);
             float.TryParse(Console.ReadLine(), out float litrosGstos);

            var consumo = distanciaPercorrida / litrosGstos;

            Console.WriteLine($"{consumo:F3} km/l.");

        }
    }
}