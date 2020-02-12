/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 10/04/2019
 * Time: 21:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace tabuleiroPOO
{
	/// <summary>
	/// Description of Tabuleiro.
	/// </summary>
	public class Tabuleiro:Panel
	{
		
		private int bonusAtaque = 0;
		private int bonusDefesa = 0;
	    private Point posicao;
		public int BonusAtaque { get { return bonusAtaque;  } set { bonusAtaque = value; } }
		public int BonusDefesa { get { return bonusDefesa; } set { bonusDefesa = value; } }
		public Point Posicao { get { return posicao; }  set { posicao = value; } }
	        
		public Tabuleiro()
		{
			Width = 60;
			Height = 60;
			BackColor = Color.Blue;
			BorderStyle = BorderStyle.FixedSingle;
		}
	}
}
