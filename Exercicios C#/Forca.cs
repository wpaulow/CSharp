/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 15/08/2018
 * Time: 20:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Força
{
	class Program
	{
		public static void Main(string[] args)
		{
			float f, m, a;
			Console.WriteLine ("Digite a massa do objeto");
			m = float.Parse (Console.ReadLine ());
			
			Console.WriteLine ("Digite a aceleração do objeto");
			a = float.Parse (Console.ReadLine ());
			
			f = m * a;
			Console.WriteLine ("A força de um objeto de massa " + m + " e aceleração " + a + " é de " + f);
			
			Console.ReadKey ();
		}
	}
}