/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 03/04/2019
 * Time: 21:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;

namespace OrientacaoAObjetos
{
	/// <summary>
	/// Description of Tabuleiro.
	/// </summary>
	public class Tabuleiro : Panel //a classe tabuleiro herda da classe panel
	{
		public Tabuleiro() 
		{	
			//construtor
		}
		//atributos:
		private int bonusAtaque = 0;
		
		public int BonusAtaque { get {return bonusAtaque;} set {bonusAtaque = value;} }
		
		private int bonusDefesa = 0;
		
		public int BonusDefesa { get {return bonusDefesa;} set {bonusDefesa = value;} }
		
		private Point posicao;
		
		public Point Posicao { get {return posicao;} set {posicao = value;} }
	}
}
