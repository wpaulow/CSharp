/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 13/03/2019
 * Time: 22:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vetorDeIndexacao
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
			string [] s = {"Bruno", "Carlos", "Alvaro", "Gabriel", "Raquel", "Julia", "Pedro", "Beatriz", "Aline", "Monica"};
			//int [] v = {0,1,2,3,4,5,6,7,8,9};
			int [] v = {8,0,6,9,3,1,2,5,7,4};
			
			for (int j=0; j<9; j++)
				for (int i=0; i<9; i++)
				{
					int aux = 0;
                    if (s[v[i]].CompareTo(s[v[i+1]]) >= 0)
                    {
                        aux = v[i];
                        v[i] = v[i+1];
                        v[i+1] = aux;
                    }
                    /* a primeira string a ser comparada é a v[0] que, sendo a posição equivalente ao numeral 8 no array v, se
                	 * equivale à posição 8 do vetor s, ou seja, s[8], que é a palavra Aline. Aline será comparada com o v[0+1]/v[1], que, 
                	 * no array v é o numeral 0, que servirá por sua vez de índice para o array s, equivalendo ao nome Bruno. Logo, Aline 
                	 * será comparada à Bruno. Por Aline ser menor do que Bruno, ela não troca e o vetor v permanece igual.
                	 * na segunda rodada, com i=1, v[1] = 0, s[0] = Bruno; v[2] = 6, s[6] = Pedro, Bruno também não é maior que Pedro,
                	 * logo o array v não irá se alterar.
                	 * E assim, sucessivamente...*/
				}
			
			for (int i=0; i<10; i++) 
			{
				listBox1.Items.Add(v[i]); //vetor transformado pelo ordem alfabética do for acima. o índice da ordem alfabética.
				listBox2.Items.Add(s[i]); //vetor embaralhado só sendo printado de acordo com o que está acima. sem ter sido alterado, já que não foi nele que se ordenou alfabeticamente, e sim no vetor v.
				listBox3.Items.Add(s[v[i]]); //vetor de strings printado em ordem alfabética de acordo com o que foi arrumado no vetor v.
			}
		}
	}
}
