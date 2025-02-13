namespace LicoesBeeCrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero do algoritmo que deseja executar: ");

            var opcaoExecucao = Console.ReadLine();
            switch (opcaoExecucao)
            {
                case "2374":
                    ExecutarAlgoritmo<Algoritmo2374>();
                    break;
                case "1014":
                    ExecutarAlgoritmo<Algoritmo1014>();
                    break;
                case "1019":
                    var algoritmo1019 = new Algoritmo1019();
                    algoritmo1019.Executar();
                    break;
                default:
                    Console.WriteLine("Escolha um algoritmo ja implementado. Vide Classes da solução.");
                    break;  

            }

            Console.WriteLine("Finalizado!");
            Console.ReadLine();
        }

        public static void ExecutarAlgoritmo<T>() where T : IBaseAlgoritmo, new()
        {
            var instancia = new T();
            instancia.Executar();
        }
    }
}
