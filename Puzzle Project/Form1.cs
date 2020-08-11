using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Puzzle_Project
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LevelsForm aa = new LevelsForm();
            aa.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        SoundPlayer music2 = new SoundPlayer(@"D:\Projects\Puzzle Project\Puzzle Project\music2.wav");
         SoundPlayer aa = new SoundPlayer(@"D:\Projects\Puzzle Project\Puzzle Project\music1.wav");
        SoundPlayer music3= new SoundPlayer(@"D:\Projects\Puzzle Project\Puzzle Project\music3.wav");
        SoundPlayer music4 = new SoundPlayer(@"D:\Projects\Puzzle Project\Puzzle Project\music4.wav");

        private void Form1_Load(object sender, EventArgs e)
        {
            button9.BackColor = Properties.Settings.Default.buttonOn;
            button9.ForeColor = Properties.Settings.Default.btnOnfore;
            button10.BackColor = Properties.Settings.Default.btnofback;
            button10.ForeColor = Properties.Settings.Default.btnoffore;

            radioButton1.Checked = Properties.Settings.Default.radionbtn1;
            radioButton2.Checked = Properties.Settings.Default.radiobtn2;
            radioButton3.Checked = Properties.Settings.Default.radiobtn3;
            radioButton4.Checked = Properties.Settings.Default.radiobtn4;




        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel5.SendToBack();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            aa.PlayLooping();
            button9.BackColor=Color.White;
            button9.ForeColor = Color.Black;
            button10.BackColor = Color.Transparent;
            button10.ForeColor = Color.White;
            Properties.Settings.Default.radionbtn1 = radioButton1.Checked;
            Properties.Settings.Default.radiobtn2 = radioButton2.Checked;
            Properties.Settings.Default.radiobtn3 = radioButton3.Checked;
            Properties.Settings.Default.radiobtn4 = radioButton4.Checked;

            Properties.Settings.Default.btnOnfore = button9.ForeColor;
            Properties.Settings.Default.buttonOn = button9.BackColor;
            Properties.Settings.Default.btnoffore = button10.ForeColor;
            Properties.Settings.Default.btnofback = button10.BackColor;

            Properties.Settings.Default.Save();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.radionbtn1 = radioButton1.Checked;
            Properties.Settings.Default.radiobtn2 = radioButton2.Checked;
            Properties.Settings.Default.radiobtn3 = radioButton3.Checked;
            Properties.Settings.Default.radiobtn4 = radioButton4.Checked;

            Properties.Settings.Default.btnOnfore = button9.ForeColor;
            Properties.Settings.Default.buttonOn = button9.BackColor;
            Properties.Settings.Default.btnoffore = button10.ForeColor;
            Properties.Settings.Default.btnofback = button10.BackColor;

            Properties.Settings.Default.Save();
            MessageBox.Show("Setting Saved");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.White)
            {
                music2.PlayLooping();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.White)
            {
                aa.PlayLooping();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.White;
            button9.ForeColor = Color.Black;
            button10.BackColor = Color.Transparent; ;
            button10.ForeColor = Color.White;
            if (radioButton1.Checked == true)
            { aa.PlayLooping(); }
            else if (radioButton2.Checked == true)
            {
                music2.PlayLooping();
            }
            else if (radioButton3.Checked == true)
            {
                music3.PlayLooping();
            }
            else if (radioButton4.Checked == true)
            {
                music4.PlayLooping();
            }
            if(radioButton1.Checked==false && radioButton2.Checked==false && radioButton3.Checked==false && radioButton4.Checked==false)
            {
                MessageBox.Show("Please select music");
            }
           

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Transparent; ;
            button9.ForeColor = Color.White;
            button10.BackColor = Color.White;
            button10.ForeColor = Color.Black;
            if (radioButton1.Checked == true)
            {
                radioButton1.Checked = false;
                aa.Stop();

            }
            else if(radioButton2.Checked==true)
            {
                radioButton2.Checked = false;
                music2.Stop();
            }
            else if (radioButton3.Checked == true)
            {
                radioButton3.Checked = false;
                music3.Stop();
            }
            else if (radioButton4.Checked == true)
            {
                radioButton4.Checked = false;
                music4.Stop();
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(button9.BackColor==Color.White)
            {
                music3.PlayLooping();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(button9.BackColor==Color.White)
            {
                music4.PlayLooping();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
