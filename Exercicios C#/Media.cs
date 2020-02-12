/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 15/08/2018
 * Time: 20:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Media
{
	class Program
	{
		public static void Main(string[] args)
		{
			float m,n1,n2,n3,n4,n5;
			
			Console.WriteLine("Digite o primeiro numero");
			n1 =  float.Parse(Console.ReadLine());
			Console.WriteLine("Digite o segundo numero");
			n2 =  float.Parse(Console.ReadLine());
			Console.WriteLine("Digite o terceir numero");
			n3 =  float.Parse(Console.ReadLine());
			Console.WriteLine("Digite o quarto numero");
			n4 =  float.Parse(Console.ReadLine());
			Console.WriteLine("Digite o quinto numero");
			n5 =  float.Parse(Console.ReadLine());
			
			m = (n1 + n2 + n3+ n4+ n5)/5;
			Console.WriteLine("A media dos numeros é" + m);
			
			Console.ReadKey();
		}
	}
}