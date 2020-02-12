/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 15/08/2018
 * Time: 21:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NomeSobrenome
{
	class Program
	{
		public static void Main(string[] args)
		{
		
			string Nome,Sobrenome;
			
			Console.WriteLine("Digite o seu nome");
			Nome = (Console.ReadLine());
			Console.WriteLine("Digite o sobrenome");
			Sobrenome = (Console.ReadLine());
			
			Console.WriteLine(Sobrenome + ", " + Nome);
			Console.ReadKey();
		
		
		
		
		
		}
	}
}