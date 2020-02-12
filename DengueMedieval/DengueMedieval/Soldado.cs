using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DengueMedieval
{
    class Soldado:PictureBox
    {
        public Soldado()
        {
            Width = 50;
            Height = 50;
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;
            Left = 2;
            Top = 2;
        }

        private string nome;

        public string Nome { get { return nome; } set { nome = value; } }

        private int pontosVida = 0;

        public int PontosVida { get { return pontosVida; }  set { pontosVida = value; } }

        private int equipe = 0;

        public int Equipe { get { return equipe; } set { equipe = value; } }

        private Point movimento = new Point(2, 2);

        public Point Movimento { get { return movimento; } set { movimento = value; } }

        private int pontosAtaque = 0;

        public int PontosAtaque { get { return pontosAtaque; } set { pontosAtaque = value; } }

        private int pontosDefesa = 0;

        public int PontosDefesa { get { return pontosDefesa; } set { pontosDefesa = value; } }

        private Point posicao = new Point(0, 0);

        public Point Posicao { get { return posicao; } set { posicao = value; } }
    }
}
