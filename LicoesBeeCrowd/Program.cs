namespace LicoesBeeCrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero do algoritmo que deseja executar:");

            var opcaoExecucao = Console.ReadLine();
            switch (opcaoExecucao)
            {
                case "2374":
                    var algoritmo2374 = new Algoritmo2374();
                    algoritmo2374.Executar();
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
            
        }
    }
}
