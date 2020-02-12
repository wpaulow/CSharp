/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 15/08/2018
 * Time: 20:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace velocidade
{
	class Program
	{
		public static void Main(string[] args)
		{
			float v, d, t;
			Console.WriteLine("deslocamento");
			d = float.Parse(Console.ReadLine());
			Console.WriteLine("tempo gasto");
			t = float.Parse(Console.ReadLine());
			v = d / t;
			Console.WriteLine ("Velocidade" + v);
			
			Console.ReadKey ();
			
		}
	}
}