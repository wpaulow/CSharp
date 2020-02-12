/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 14/09/2018
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LeninMovimento
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
		void MainFormLoad(object sender, EventArgs e)
		{
			lenin.Parent=fundo;
		}
		void Btn1Click(object sender, EventArgs e)
		{
			lenin.Load("lenin.gif");
			
			lenin.Left-=5;
			
			this.verExtremidade();
			
		}
		void Btn2Click(object sender, EventArgs e)
		{
			lenin.Load("lenin.gif");
			
			lenin.Left+=5;
			
			this.verExtremidade();
		}
		
		public void verExtremidade()
        {
            
            if(lenin.Left < 0)
            {
                lenin.Left = 0;
            }
           
            else if (lenin.Left > 450)
            {
                lenin.Left = 450;
            }

		}
	}
}
