using System;
using LicoesBeeCrowd.Domain.Algoritmo1930Domain;
using Xunit;
namespace LicoesBeeCrowd.Teste
{
	public class TesteAlgoritmo1930
	{

        [Fact]

        public void Contar_tomadas_com_quatro_reguas_de_energia_com_tres_tomadas_cada_as_reguas_se_interligm_resultando_em_9_tomadas_disponiveis()
        {
            //Arrenge (configuração)
            var Algoritmo1930 = new Algoritmo1930Domain();
            var regua1 = "3 3 3 3";
           
            //Act (Ação)
            var resultado = Algoritmo1930Domain.CalculaTomadas(regua1);

            //Assert (Verificação)
            Assert.Equals(9,resultado);
        }
    }
}