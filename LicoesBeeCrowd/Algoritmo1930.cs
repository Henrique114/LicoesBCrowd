﻿using System;

namespace LicoesBeeCrowd
{

	public class Algoritmo1930 : IBaseAlgoritmo
	{
		public void Executar() 
		{
			//Dado o número de tomadas em cada régua, determine o número
			//máximo de aparelhos que podem ser conectados à energia num mesmo instante.
			//Considerando que foram compradaas 4 tomadas.

			//variavel que guarda o numeo de tomada de todas as reguas de energia.
			//ex.: 3 5 4 3.
			var reguas = Console.ReadLine();
            
			//extrair cada elemento passando para decimal e somando-os

			

			Console.WriteLine(totalTomadas);





        }

		public int TomadasDisponiveis(int t1, int t2, int t3, int t4) 
		{
			var result = t1 + t2 + t3 + t4 - 3;

			return result;

		}
	}
}