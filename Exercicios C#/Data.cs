/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 15/08/2018
 * Time: 21:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Data
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string dia, mês, ano;
			
			Console.WriteLine ("Dia");
			dia = (Console.ReadLine());
			
			Console.WriteLine ("Mês");
			mês = (Console.ReadLine());
			
			Console.WriteLine ("Ano");
			ano = (Console.ReadLine ());
			       
			Console.WriteLine(dia + "/" + mês + "/" + ano);
			
			Console.ReadKey ();
		}
	}
}