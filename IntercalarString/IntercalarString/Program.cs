/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 12/09/2018
 * Time: 18:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace IntercalarString
{
	class Program
	{
		public static void Main(string[] args)
		{int a, b, c, d, e, res;
			Console.WriteLine("Digite o primeiro número da conta: ");
			a = int.Parse (Console.ReadLine());
			
			Console.WriteLine("Digite o segundo número da conta: ");
			b = int.Parse (Console.ReadLine());
				
			Console.WriteLine("Digite o terceiro número da conta: ");
			c = int.Parse (Console.ReadLine());
				
			Console.WriteLine("Digite o quarto número da conta: ");
			d = int.Parse (Console.ReadLine());
			
			Console.WriteLine("Digite o quinto número da conta: ");
			e = int.Parse (Console.ReadLine());
			
			res= (a*1+b*2+c*3+d*4+e*5);
			
			string sres = res.ToString().Substring (0,1);
			Console.WriteLine("Seu digito de segurança é "+sres);	
			
			Console.ReadKey();
		}
	}
}