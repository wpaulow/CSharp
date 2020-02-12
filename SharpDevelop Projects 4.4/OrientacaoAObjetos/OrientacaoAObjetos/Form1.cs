/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 10/04/2019
 * Time: 21:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OrientacaoAObjetos
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		int cont = 0;
		void Button1Click(object sender, EventArgs e)
		{
			cont++;
			MainForm frm1 = new MainForm ();
			frm1.Text = "Tela" + cont.ToString();
			frm1.StartPosition = FormStartPosition.CenterScreen;
			
			frm1.Show(); //ShowDialog() => modal é quando só se pode fazer algo essa janela, quando fechá-la
		}
	}
}
