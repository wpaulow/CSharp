/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 27/02/2019
 * Time: 20:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vetores2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int [] v={4,2,7,9,5,8,1,0,6,3};
			
			for (int i=0; i<10; i++)
			{
				listBox1.Items.Add(v[i]);
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			int [] v={4,2,7,9,5,8,1,0,6,3};
			
			for (int i=0; i<10; i++)
			{
				listBox2.Items.Add(v[v[i]]);
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			int [] v={4,2,7,9,5,8,1,0,6,3};
			int [] n={8,7,-5,12,-12,4,11,0,5,2};
			
			for (int i=0; i<10; i++)
			{
				listBox3.Items.Add(n[v[i]]);
			}	
		}
		
		
		
		void Button4Click(object sender, EventArgs e)
		{
			int [] v={5,1,4,9,6,7,0,2,3,8};
			int [] r={2,-4,3,4,-3,-5,-1,1,5,-2};
			        //0, 1,2,3, 4, 5, 6,7,8, 9
			        
			for (int i=0; i<10; i++)
			{
				listBox4.Items.Add(r[v[i]]);
			}		
		}
		
		
		/*colocar os nomes na ordem embaralhada que o vetor v já organizou. Ou seja, Aline, a primeira da ordem alfabética, estava em oitavo lugar na lista
		  * enquanto Alvaro ocupava índice de número 2, já que está na terceira posição desta lista embaralhada, mas vetores começam do índice 0.
		  * Ou seja, todos estes exercícios são exercícios de INDEXAÇÃO*/
		void Button5Click(object sender, EventArgs e) 
		{
			int [] v={8,2,7,0,1,3,5,9,6,4};
			string [] s={"Bruno", "Carlos", "Alvaro", "Gabriel", "Raquel", "Julia", "Pedro", "Beatriz", "Aline", "Monica"};
			        //     0,        1,        2,         3,         4,       5,       6,        7,       8,         9
			        
			for (int i=0; i<10; i++)
			{
				listBox5.Items.Add(s[v[i]]);
			}	
		}
	}
}
