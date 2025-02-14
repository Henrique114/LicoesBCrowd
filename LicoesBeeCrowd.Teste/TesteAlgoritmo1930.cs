using System;
namespace TesteLicoesBeeCrowd
{
	public class TesteAlgoritmo1930
	{

        [Fact]
        public void Contar_tomadas_com_quatro_reguas_de_energia_com_tres_tomadas_cada_as_reguas_se_interligm_resultando_em_9_tomadas_disponiveis()
        {
            var regua1 = 3;
            var regua2 = 3;
            var regua3 = 3;
            var regua4 = 3;

            var resultado = Algoritmo1930.TomadasDisoniveis(regua1, regua2, regua3, regua4);
        }
    }
}