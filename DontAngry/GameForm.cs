using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DontAngry.Engines;

namespace DontAngry
{
    public partial class GameForm : Form
    {
        public Engine engine = new Engine();

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void HomeStart_Click(object sender, EventArgs e)
        {
            PictureBox pcb = (PictureBox)sender;

            pcb.Image = null;
            pcb_GreenStart.Image = global::DontAngry.Properties.Resources.GreenPlayer;

            MessageBox.Show(engine.ToString());
        }

        private void pcb_DiceImage_Click(object sender, EventArgs e)
        {
            if (engine.CurrGameMode == GameMode.DropCube)
            {
                int num = engine.DropCube();

                Bitmap bmp = PickImage(num);
                pcb_DiceImage.Image = bmp;

                engine.CurrGameMode = GameMode.MovePlayer;
            }
            


        }

        private Bitmap PickImage(int number)
        {
            switch (number)
            {
                case 1:
                    return Properties.Resources.Dice1;
                case 2:
                    return Properties.Resources.Dice2;
                case 3:
                    return Properties.Resources.Dice3;
                case 4:
                    return Properties.Resources.Dice4;
                case 5:
                    return Properties.Resources.Dice5;
                case 6:
                    return Properties.Resources.Dice6;
                default:
                    return null;
            }
        }
    }
}
