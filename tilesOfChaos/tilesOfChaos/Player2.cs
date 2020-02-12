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
    class Player2:PictureBox
    {
        public Player2()
        {
            Width = 50;
            Height = 50;
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;
            ImageLocation = "personagem/knightOfFlames.gif";

        }
    }
}
