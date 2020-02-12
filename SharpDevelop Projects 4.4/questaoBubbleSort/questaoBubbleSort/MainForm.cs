/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 13/03/2019
 * Time: 20:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace questaoBubbleSort
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
			string [] nome = {"Mara", "Vilma", "Danilo", "Alberto", "Liliane", "Denise", "Carla", "André", "Clarice", "Simone", "Amélia", "Mario", 
				"Beatriz", "Vinicius", "Gabriela", "Bruna", "Renato", "Patricia", "Ivan", "Julio"};
			int [] salario = {5790, 8600, 3700, 9000, 2200, 5505, 1700, 900, 6500, 10000, 8700, 2630, 7300, 959, 1200, 7200, 4500, 3840, 4507, 978};
			
			for (int j=0; j<19; j++)
				for (int i=0; i<19; i++)
				{
					string auxNome="";
					int auxSal;
					if (nome[i].CompareTo(nome[i+1])>=0)
					{
						auxNome=nome[i];
						nome[i]=nome[i+1];
						nome[i+1]=auxNome;
						
						auxSal=salario[i];
						salario[i]=salario[i+1];
						salario[i+1}=auxSal;
					}
				
				}
			listBox1.Items.Clear();
			for (int i=0; i<19; i++)
				listBox1.Items.Add(nome[i] + " " + salario [i]);}
				
		
		void Button2Click(object sender, EventArgs e)
		{
			int [] salario = {5790, 8600, 3700, 9000, 2200, 5505, 1700, 900, 6500, 10000, 8700, 2630, 7300, 959, 1200, 7200, 4500, 3840, 4507, 978};
			
			for (int j=0; j<9; j++)
				for (int i=0; i<9; i++)
				{
					int aux;
					if (salario[i] > salario [i+1])
					{
						aux=salario[i];
						salario[i]=salario[i+1];
						salario[i+1]=aux;
					}
				}
		}
	}
}
