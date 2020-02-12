using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DengueMedieval
{
    public class Tile : Button
    {
        public Tile()
        {
            Height = 60;
            Width = 60;
            BackColor = Color.ForestGreen;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.DarkGray;
            FlatAppearance.MouseOverBackColor = Color.LightGreen;
            FlatAppearance.MouseDownBackColor = Color.LawnGreen;
            BackgroundImageLayout = ImageLayout.Stretch;
            MouseMove += tileMouseMove;
            MouseLeave += tileMouseLeave;
        }

        private void tileMouseMove(object sender, MouseEventArgs e)
        {
            FlatAppearance.BorderSize = 3;
            FlatAppearance.BorderColor = Color.Blue;
        }

        private void tileMouseLeave(object sender, EventArgs e)
        {
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.DarkGray;
        }

        private string nome;

        public string Nome { get { return nome; } set { nome = value; } }

        private int bonusVida = 0;

        public int BonusVida { get { return bonusVida; } set { bonusVida = value; } }

        private int penalidade = 0;

        public int Penalidade { get { return penalidade; } set { penalidade = value; } }
        
        private int bonusAtaque = 0;

        public int BonusAtaque { get { return bonusAtaque; } set { bonusAtaque = value; } }

        private int bonusDefesa = 0;

        public int BonusDefesa { get { return bonusDefesa; } set { bonusDefesa = value; } }

        private Point posicao = new Point(0, 0);

        public Point Posicao { get { return posicao; } set { posicao = value; } }

    }
}
