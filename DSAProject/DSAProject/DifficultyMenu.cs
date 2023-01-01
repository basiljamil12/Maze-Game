using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSAProject
{
    public partial class DifficultyMenu : Form
    {
        public DifficultyMenu()
        {
            InitializeComponent();
        }
        public void CallLabyrinth(int level)
        {

            Random rando = new Random();
            int rng = rando.Next(1, 4);
            Labyrinth gamlab = new Labyrinth(level, rng);
            gamlab.StartPosition = FormStartPosition.CenterParent;
            this.Hide();
            gamlab.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CallLabyrinth(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CallLabyrinth(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CallLabyrinth(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu manmen = new MainMenu();
            this.Hide();
            manmen.ShowDialog();
            this.Close();
        }
    }
}
