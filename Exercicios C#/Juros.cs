/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 15/08/2018
 * Time: 21:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Juros
{
	class Program
	{
		public static void Main(string[] args)
		{
			float vlrAplicado;
			double txJuros, r;
			
			Console.WriteLine(" Digite o valor da taxa de juros (ex: 0,5)");
			txJuros = double.Parse(Console.ReadLine());
			Console.WriteLine(" Digite o valor aplicado ");
			vlrAplicado = float.Parse (Console.ReadLine ());
			
			r = txJuros * vlrAplicado;
			Console.WriteLine ("O valor do rendimento é " + r);
			
			Console.ReadKey ();
		}
	}
}