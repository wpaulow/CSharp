using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tilesOfChaos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cenario[,] tiles = new Cenario[10, 10];
        Player1 death = new Player1();
        Player2 knight = new Player2();
        int p1 = 5, p2 = 5;
        int cont = 0;


        PictureBox firstPicture = new PictureBox();
        PictureBox lastPicture = new PictureBox();

        bool clicado = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i<10;i++)
                for (int j = 0; j < 10; j++)
                {
                    tiles[i, j] = new Cenario();
                    tiles[i, j].Parent = this;
                    tiles[i, j].Left = 30 + 50 * j;
                    tiles[i, j].Top = 30 + 50 * i;
                    tiles[i, j].Click += troca;

                    tiles[i, j].Load("tiles/cenario_"+(++cont).ToString().PadLeft(3,'0')+".jpg");

                }

            death.Parent = tiles[p1, p2];
            knight.Parent = tiles[p1, 6];
       
        }
        private void troca(object sender, EventArgs e)
        {
            PictureBox tl = sender as PictureBox;
            if (clicado)
            {
                lastPicture.Image = tl.Image;
                tl.ImageLocation = primeiroClique.ImageLocation;
                
                clicado = false;
            }
            else
            {
                primeiroClique.ImageLocation = tl.ImageLocation;
                lastPicture = tl;
                clicado = true;
            }
            //tiles[8, 8].ImageLocation = tl.ImageLocation;

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;

            if (l.Equals('d') && p2 < 9)
            {
                death.Parent = tiles[p1, p2 + 1];
                p2++;

            }

            if (l.Equals('a') && p2 >= 1)
            {
                death.Parent = tiles[p1, p2 - 1];
                p2--;

            }
            if (l.Equals('w') && p1 >= 1)
            {
                death.Parent = tiles[p1 - 1, p2];
                p1--;

            }
            if (l.Equals('s') && p1 < 9)
            {
                death.Parent = tiles[p1 + 1, p2];
                p1++;

            }
        }
    }
}
