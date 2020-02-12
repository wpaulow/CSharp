/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 10/04/2019
 * Time: 21:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tabuleiroPOO
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
		int count = 0;
		void Button1Click(object sender, EventArgs e)
		{
			Label lbl = label1;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Form1 frm2 = new Form1();
			count++;
			frm2.Text = "Tela " + count;
			frm2.StartPosition = FormStartPosition.CenterScreen;
			frm2.label2.Text = "Olá Mundo";
			
			Button btn = new Button();
			btn.Parent = frm2;
			btn.Left = 200;
			btn.Top = 200;
			btn.Click += BtnClick;
			
			Button btn2 = new Button();
			btn.Parent = frm2;
			btn.Left = 200;
			btn.Top = 230;
			btn.Click += BtnClick;
			
			frm2.ShowDialog();
		}
		
		private void BtnClick(object sender, EventArgs e)
		{
			Button bt = sender as Button;
			bt.Text = "Fui Clicado";
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			for(int j = 0; j < 10; j++)
			{
                PictureBox[] quadros = new PictureBox[10]; //criando um vetor de quadros (picturebox) na horizontal

                for (int i = 0; i < 10; i++){

                    quadros[i] = new PictureBox();
					quadros[i].Parent = this; // o local onde serão criados os picturebox, o pai deles, que é o form
					quadros[i].Top = 30 + 51 * j; // quando o j valer 0, multiplicado pelo tamanho do quadro (50) + o espaço de 1 entre eles = localização do topo
					quadros[i].Left = 30 + 51 * i; // quando o i valer 0, multiplicado pelo tamanho do quadro (50) + o espaço de 1 entre eles = localização da esquerda
                    //quadros[i].BackColor = Color.Blue;
                    quadros[i].Height = 50;
                    quadros[i].Width = 50;
                    quadros[i].SizeMode = PictureBoxSizeMode.StretchImage; // tamanho da imagem que está carregando
                    quadros[i].Load("bapho(" + j.ToString() + i.ToString() + ").jpg");
                    
//                    if(j == 0)
//                    { 
//                        quadros[i].Load("bapho(" + i + ").jpg");
//                    }
//                    else if(j == 1)
//                    {
//                        quadros[i].Load("bapho(" + (i+10) + ").jpg");
//                    }
//                    else if (j == 2)
//                    {
//                        quadros[i].Load("bapho(" + (i+20) + ").jpg");
//                    }
//                    else if (j == 3)
//                    {
//                        quadros[i].Load("bapho(" + (i+30) + ").jpg");
//                    }
//                    else if (j == 4)
//                    {
//                        quadros[i].Load("bapho(" + (i+40) + ").jpg");
//                    }
//                    else if (j == 5)
//                    {
//                        quadros[i].Load("bapho(" + (i+50) + ").jpg");
//                    }
//                    else if (j == 6)
//                    {
//                        quadros[i].Load("bapho(" + (i+60) + ").jpg");
//                    }
//                    else if (j == 7)
//                    {
//                        quadros[i].Load("bapho(" + (i+70) + ").jpg");
//                    }
//                    else if (j == 8)
//                    {
//                        quadros[i].Load("bapho(" + (i+80) + ").jpg");
//                    }
//                    else if (j == 9)
//                    {
//                        quadros[i].Load("bapho(" + (i+90) + ").jpg");
//                    }
					
					/*um tabuleiro
					  * dois personagens diferentes
					  * */
       
                }
			}
		}
	}
}
