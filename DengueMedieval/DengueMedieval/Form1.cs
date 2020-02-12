using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DengueMedieval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tile[,] tile = new Tile[10, 10];
        Soldado[,] soldado = new Soldado[2, 8];
        Soldado soldadoClicado = new Soldado();
        bool selecionado = false;
        int vez = 0;

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            for (int y = 0; y < 10; y++)
                for (int x = 0; x < 10; x++)
                {
                    tile[x, y] = new Tile();
                    tile[x, y].Parent = this;
                    tile[x, y].Left = 20 + x * 60;
                    tile[x, y].Top = 50 + y * 60;
                    tile[x, y].Posicao = new Point(x, y);
                    tile[x, y].Click += tileClick; 
                }
            Point mov;
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                    mov = new Point(2, 1);
                else
                    mov = new Point(1, 3);
                for (int j = 0; j < 8; j++)
                {
                    soldado[i, j] = new Soldado();
                    soldado[i, j].Load("soldier" + i.ToString() + ".gif");
                    soldado[i, j].Parent = tile[i * 9, j + 1];
                    soldado[i, j].MouseMove += soldadoMouseMove;
                    soldado[i, j].Movimento = mov;
                    soldado[i, j].Click += soldadoClick;
                    soldado[i, j].Equipe = i;
                    /*if (i == 0)
                        soldado[i, j].Load("soldier.gif");
                    else
                        soldado[i, j].Load("dengue.gif");*/
                }
            }
        }

        private void soldadoMouseMove(object sender, MouseEventArgs e)
        {
            Soldado soldier = sender as Soldado;
            Tile casa = (Tile)soldier.Parent;
            casa.FlatAppearance.BorderSize = 3;
            casa.FlatAppearance.BorderColor = Color.Blue;

        }

        private void tileClick (object sender, EventArgs e)
        {
            Tile tileClicado = sender as Tile;

            if (tileClicado.BackColor == Color.DarkGreen)
            {
                Tile tileParent = soldadoClicado.Parent as Tile;
                sombrear(tileParent.Posicao, soldadoClicado.Movimento, Color.ForestGreen);
                selecionado = false;
                soldadoClicado.Parent = tileClicado;
                //troca a vez
                if (vez == 0)
                {
                    vez = 1;
                }
                else
                {
                    vez = 0;
                }
            }
        }

        private void soldadoClick(object sender, EventArgs e)
        {
            if ((sender as Soldado).Equipe == vez)
            {
                if (selecionado)
                {
                    // desmarcar a sombra do soldado selecionado anteriormente
                    Tile tileParentAnterior = soldadoClicado.Parent as Tile;
                    sombrear(tileParentAnterior.Posicao, soldadoClicado.Movimento, Color.ForestGreen);
                }

                soldadoClicado = sender as Soldado;
                selecionado = true;

                Tile tileParent = soldadoClicado.Parent as Tile;
                sombrear(tileParent.Posicao, soldadoClicado.Movimento, Color.DarkGreen);
            }

            if (vez == 0) {
                label1.Text = "Vez das isis ";
                vez = 0;
            }else
            {
                label1.Text = "Vez das pecas ";
                vez = 1;
            }

        }

        private void sombrear(Point pos, Point movimento, Color cor)
        {
            for (int x = -movimento.X; x <= movimento.X; x++)
                for (int y = -movimento.Y; y <= movimento.Y; y++)
                {
                    try
                    {
                        tile[pos.X + x, pos.Y + y].BackColor = cor;
                    } catch (Exception e)
                    {

                    }
                }
        }

    }
}
