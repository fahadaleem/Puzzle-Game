using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Project
{
    public partial class LevelsForm : Form
    {
        public LevelsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LevelOne aa = new LevelOne();
            aa.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            level2 ab = new level2();
            ab.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            level3 aa = new level3();
            aa.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 aa = new Form1();
            aa.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
