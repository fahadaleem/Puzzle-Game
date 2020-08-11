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
    public partial class LevelOne : Form
    {
        public LevelOne()
        {
            InitializeComponent();
        }

        Bitmap[] aa = new Bitmap[9];
       Image b;

        private void LevelOne_Load(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.image_part_004;
            pictureBox2.Image = Properties.Resources.image_part_001;
            pictureBox3.Image = Properties.Resources.image_part_008;
            pictureBox4.Image = Properties.Resources.image_part_006;
            pictureBox5.Image = Properties.Resources.image_part_005;
            pictureBox6.Image = Properties.Resources.image_part_007;
            pictureBox7.Image = Properties.Resources.image_part_002;
            pictureBox8.Image = Properties.Resources.Typeform_Blog_BlackFriday_Cover_AskAwesomely;
            pictureBox9.Image = Properties.Resources.image_part_003;


            aa[0] = (Bitmap)pictureBox2.Image;
            aa[6] = (Bitmap)pictureBox8.Image;
            aa[1] = (Bitmap)pictureBox7.Image;
            aa[2] = (Bitmap)pictureBox9.Image;
            aa[3] = (Bitmap)pictureBox10.Image;
            aa[4] = (Bitmap)pictureBox7.Image;


            timer1.Start();





        }
        int count = 0;
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            //click.Play();

            count++;
            label2.Text = count.ToString();
            if (pictureBox7.Image == aa[6])
            {
                b = pictureBox10.Image;
                pictureBox10.Image = pictureBox7.Image;
                pictureBox7.Image = b;
            }
            else if (pictureBox9.Image == aa[6])
            {
                b = pictureBox10.Image;
                pictureBox10.Image = pictureBox9.Image;
                pictureBox9.Image = b;
            }
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //click.Play();

            count++;
            label2.Text = count.ToString();

            if (pictureBox5.Image == aa[6])
            {
                b = pictureBox8.Image;
                pictureBox8.Image = pictureBox5.Image;
                pictureBox5.Image = b;
            }
            else if (pictureBox9.Image == aa[6])
            {
                b = pictureBox8.Image;
                pictureBox8.Image = pictureBox9.Image;
                pictureBox9.Image = b;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //click.Play();

            count++;
            label2.Text = count.ToString();
            if (pictureBox8.Image==aa[6])
            {
                b = pictureBox5.Image;
                pictureBox5.Image = pictureBox8.Image;
                pictureBox8.Image = b;
            }
            else if(pictureBox6.Image == aa[6])
            {
                b = pictureBox5.Image;
                pictureBox5.Image = pictureBox6.Image;
                pictureBox6.Image = b;
            }
            else if (pictureBox4.Image == aa[6])
            {
                b = pictureBox5.Image;
                pictureBox5.Image = pictureBox4.Image;
                pictureBox4.Image = b;
            }
            if(pictureBox2.Image==Properties.Resources.image_part_001 && pictureBox3.Image == Properties.Resources.image_part_002 && pictureBox4.Image == Properties.Resources.image_part_003 && pictureBox5.Image == Properties.Resources.image_part_006 && pictureBox6.Image == Properties.Resources.image_part_005 && pictureBox7.Image == Properties.Resources.image_part_004 && pictureBox8.Image == Properties.Resources.Typeform_Blog_BlackFriday_Cover_AskAwesomely && pictureBox9.Image == Properties.Resources.image_part_008 && pictureBox10.Image == Properties.Resources.image_part_009)

            {
                MessageBox.Show("You cleared First Level");
                level2 aa = new level2();
                aa.Show();
                this.Close();
            }
                    }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //click.Play();

            count++;
            label2.Text = count.ToString();
            if (pictureBox5.Image == aa[6])
            {
                b = pictureBox4.Image;
                pictureBox4.Image = pictureBox5.Image;
                pictureBox5.Image = b;
            }
            else if (pictureBox3.Image == aa[6])
            {
                b = pictureBox4.Image;
                pictureBox4.Image = pictureBox3.Image;
                pictureBox3.Image = b;
            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            //click.Play();

            count++;
            label2.Text = count.ToString();
            if (pictureBox2.Image == aa[6])
            {
                b = pictureBox3.Image;
                pictureBox3.Image = pictureBox2.Image;
                pictureBox2.Image = b;
            }
            else if (pictureBox6.Image == aa[6])
            {
                b = pictureBox3.Image;
                pictureBox3.Image = pictureBox6.Image;
                pictureBox6.Image = b;
            }
            else if (pictureBox4.Image == aa[6])
            {
                b = pictureBox3.Image;
                pictureBox3.Image = pictureBox4.Image;
                pictureBox4.Image = b;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //click.Play();
            count++;
            label2.Text = count.ToString();
            if (pictureBox3.Image == aa[6])
            {
                b = pictureBox2.Image;
                pictureBox2.Image = pictureBox3.Image;
                pictureBox3.Image = b;
            }
            else if (pictureBox7.Image == aa[6])
            {
                b = pictureBox2.Image;
                pictureBox2.Image = pictureBox7.Image;
                pictureBox7.Image = b;
            }
          
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //click.Play();

            count++;
            label2.Text = count.ToString();
            if (pictureBox10.Image == aa[6])
            {
                b = pictureBox7.Image;
                pictureBox7.Image = pictureBox10.Image;
                pictureBox10.Image = b;
            }
            else if (pictureBox6.Image == aa[6])
            {
                b = pictureBox7.Image;
                pictureBox7.Image = pictureBox6.Image;
                pictureBox6.Image = b;
            }
            else if (pictureBox2.Image == aa[6])
            {
                b = pictureBox7.Image;
                pictureBox7.Image = pictureBox2.Image;
                pictureBox2.Image = b;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //click.Play();

            count++;
            label2.Text = count.ToString();
            if (pictureBox8.Image == aa[6])
            {
                b = pictureBox9.Image;
                pictureBox9.Image = pictureBox8.Image;
                pictureBox8.Image = b;
            }
            else if (pictureBox6.Image == aa[6])
            {
                b = pictureBox9.Image;
                pictureBox9.Image = pictureBox6.Image;
                pictureBox6.Image = b;
            }
            else if (pictureBox10.Image == aa[6])
            {
                b = pictureBox9.Image;
                pictureBox9.Image = pictureBox10.Image;
                pictureBox10.Image = b;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //click.Play();

            count++;
            label2.Text = count.ToString();
            if (pictureBox3.Image == aa[6])
            {
                b = pictureBox6.Image;
                pictureBox6.Image = pictureBox3.Image;
                pictureBox3.Image = b;
            }
            else if (pictureBox5.Image == aa[6])
            {
                b = pictureBox6.Image;
                pictureBox6.Image = pictureBox5.Image;
                pictureBox5.Image = b;
            }
            else if (pictureBox9.Image == aa[6])
            {
                b = pictureBox6.Image;
                pictureBox6.Image = pictureBox9.Image;
                pictureBox9.Image = b;
            }
            else if (pictureBox7.Image == aa[6])
            {
                b = pictureBox6.Image;
                pictureBox6.Image = pictureBox7.Image;
                pictureBox7.Image = b;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox10.Image = Properties.Resources.image_part_004;
            pictureBox2.Image = Properties.Resources.image_part_001;
            pictureBox3.Image = Properties.Resources.image_part_005;
            pictureBox4.Image = Properties.Resources.image_part_006;
            pictureBox5.Image = Properties.Resources.image_part_008;
            pictureBox6.Image = Properties.Resources.image_part_007;
            pictureBox7.Image = Properties.Resources.image_part_002;
            pictureBox8.Image = Properties.Resources.Typeform_Blog_BlackFriday_Cover_AskAwesomely;
            pictureBox9.Image = Properties.Resources.image_part_003;
            count = 0;
            sec = 0;
            min = 0;
            hour = 0;
            label2.Text = "00";
            label4.Text = "00";
            label5.Text = "00";
            label6.Text = "00";

            aa[6] = (Bitmap)pictureBox8.Image;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LevelsForm aa = new LevelsForm();
                aa.Show();
                this.Close();
            }
        }
        int sec = 0;
        int min = 0;
        int hour = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            label6.Text = sec.ToString();
            if(sec==60)
            {
                sec = 0;
                min++;
                label5.Text = min.ToString();
                    if(min==60)
                {
                    hour++;
                    label4.Text = hour.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void LevelOne_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void startAgainHover(object sender, EventArgs e)
        {
           
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
           
        }
    }
}
