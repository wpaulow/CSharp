/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 15/08/2018
 * Time: 19:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TesteLogico
{
	class Program
	{
		public static void Main(string[] args)
		{
			float s,x,y;
			Console.WriteLine("Digite o primeiro numero");
			x = float.Parse(Console.ReadLine());
			Console.WriteLine("Digite o segundo numero");
			y = float.Parse(Console.ReadLine());
			
			// S recebe a soma de x + y
			s = x + y;
			
			Console.WriteLine("A Soma dos " + s);
			
			// S recebe a subtracao de x -y			
			s = x - y;
			
			Console.WriteLine("Subtração " + s);
			
			// s recebe a multiplicação de x e y.
			s = x * y;
			
			Console.WriteLine ("multiplicação: " + s);
			
			s = x / y;
			
			Console.WriteLine ("divisão: " + s);
			
			
			Console.ReadKey();
		}
	}
}