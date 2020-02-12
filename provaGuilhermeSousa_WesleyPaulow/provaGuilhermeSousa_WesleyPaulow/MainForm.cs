/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 27/03/2019
 * Time: 19:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace provaGuilhermeSousa_WesleyPaulow
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
			int [] salario = {2000, 6666, 1500, 6500, 9000, 10000, 7500, 8200, 1900, 2300, 1550, 1901, 2019, 3100, 4110, 5119, 3252, 1702, 1874, 
				5840, 6200, 2400, 8500, 9999, 7751, 8110, 6180, 5220, 4012, 2828};
			
			int [] index = new int[30];
			
			for (int i=0; i<30; i++)
			{
				index[i] = i;
			}
			
			for (int j=0; j<29; j++)
				for (int i=0; i<29; i++)
				{
					int aux = 0;
                    if (salario[index[i]] > (salario[index[i+1]]))
                    {
                        aux = index[i];
                        index[i] = index[i+1];
                        index[i+1] = aux;
                    }
				}
			
			for (int i=0; i<30; i++) 
			{
				listBox1.Items.Add(salario[i]);
				listBox2.Items.Add(index[i]);
                listBox3.Items.Add(salario[index[i]]);
			}
		}
	}
}
