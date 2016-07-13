using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontAngry
{
    public partial class SetupForm : Form
    {
        public SetupForm()
        {
            InitializeComponent();
        }

        private void pcb_PlayGame_Click(object sender, EventArgs e)
        {
            new GameForm().Show(); 
            Program.setupForm.Hide();
        }
    }
}
