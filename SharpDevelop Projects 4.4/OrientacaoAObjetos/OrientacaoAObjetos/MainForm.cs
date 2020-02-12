/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 03/04/2019
 * Time: 20:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OrientacaoAObjetos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			Tabuleiro frmTab = new Tabuleiro(); // instancia a classe tabuleiro como frmTab. Sendo frmTab o obj que deverá ser utilizado sempre que se quiser fazer referência aos atributos e métodos dessa instância da classe
			frmTab.Parent = this; // esta linha define o atributo Parent do obj frmTab como sendo this, ou seja, o próprio MainForm
			// O conteúdo de verdade (interno) dessa variável são ponteiros (endereços) de memória onde serão armazenadas as informações do objeto.
			// frmTab guarda o endereço das informações. new Tabuleiro é a instância da classe Tabuleiro. A variável frmTab só aponta à essa nova instância.
		}
		
		
		int cont = 0;
		void Button2Click(object sender, EventArgs e)
		{	
			cont++;
			Form1 frm2 = new Form1();
			frm2.Text = "Tela" + cont.ToString();
			frm2.StartPosition = FormStartPosition.CenterScreen;
			frm2.BackColor = Color.Red;
			Button btn = new Button();
			btn.Parent = frm2;
			btn.Left = 100;
			btn.Top = 200;
			frm2.Show();
		}
	}
}
