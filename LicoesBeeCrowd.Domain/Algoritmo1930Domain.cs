using System;

public class Algoritmo1930Domain
{
	public int CalculaTomadas(int reguas )
    {
		var result = reguas.Split(' ')                           // Divide a string por espaço
            .Where(s => int.TryParse(s, out _))  // Filtra apenas os valores numéricos
            .Select(int.Parse)                   // Converte para inteiros
            .Sum();
        return result - 3;
    }
}
