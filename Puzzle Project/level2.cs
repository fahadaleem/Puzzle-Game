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
    public partial class level2 : Form
    {
        public level2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox6.Image == aa)
            {
                b = pictureBox1.Image;
                pictureBox1.Image = pictureBox6.Image;
                pictureBox6.Image = b;
            }
            else if (pictureBox2.Image == aa)
            {
                b = pictureBox1.Image;
                pictureBox1.Image = pictureBox2.Image;
                pictureBox2.Image = b;
            }
            else if (pictureBox15.Image == aa)
            {
                b = pictureBox7.Image;
                pictureBox7.Image = pictureBox15.Image;
                pictureBox15.Image = b;
            }
        }
        Bitmap aa;

        public void level2_Load(object sender, EventArgs e)
        {
            
            pictureBox26.Image = Properties.Resources.tom_and_jerry_warner_bros;
            pictureBox1.Image = Properties.Resources.tom6;
            pictureBox2.Image = Properties.Resources.tom7;
            pictureBox3.Image = Properties.Resources.tom2;
            pictureBox4.Image = Properties.Resources.tom3;
            pictureBox5.Image = Properties.Resources.Tom001;
            pictureBox6.Image = Properties.Resources.tom9;
            pictureBox7.Image = Properties.Resources.tom11;
            pictureBox8.Image = Properties.Resources.tom4;
            pictureBox9.Image = Properties.Resources.tom5;
            pictureBox10.Image = Properties.Resources.tom12;
            pictureBox11.Image = Properties.Resources.tom8;
            pictureBox12.Image = Properties.Resources.tom10;
            pictureBox13.Image = Properties.Resources.tom17;
            pictureBox14.Image = Properties.Resources.tom19;
            pictureBox15.Image = Properties.Resources.tom13;
            pictureBox16.Image = Properties.Resources.tom18;
            pictureBox17.Image = Properties.Resources.tom15;
            pictureBox18.Image = Properties.Resources.tom14;
            pictureBox19.Image = Properties.Resources.tom20;
            pictureBox20.Image = Properties.Resources.tom21;
            pictureBox25.Image = Properties.Resources.tom16;
            pictureBox22.Image = Properties.Resources.tom24;
            pictureBox23.Image = Properties.Resources.tom22;
            pictureBox24.Image = Properties.Resources.tom23;
            pictureBox21.Image = Properties.Resources.Typeform_Blog_BlackFriday_Cover_AskAwesomely;
            timer1.Start();
            

        
            aa = (Bitmap)pictureBox21.Image;


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox3.Image == aa)
            {
                b = pictureBox4.Image;
                pictureBox4.Image = pictureBox3.Image;
                pictureBox3.Image = b;
            }
            else if (pictureBox9.Image == aa)
            {
                b = pictureBox4.Image;
                pictureBox4.Image = pictureBox9.Image;
                pictureBox9.Image = b;
            }
            else if (pictureBox2.Image == aa)
            {
                b = pictureBox4.Image;
                pictureBox4.Image = pictureBox2.Image;
                pictureBox2.Image = b;
            }
        }
        Image b;
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox21.Image == aa)
            {
                b = pictureBox11.Image;
                pictureBox11.Image = pictureBox21.Image;
                pictureBox21.Image = b;
            }
            else if (pictureBox12.Image == aa)
            {
                b = pictureBox11.Image;
                pictureBox11.Image = pictureBox12.Image;
                pictureBox12.Image = b;
            }
            else if (pictureBox15.Image == aa)
            {
                b = pictureBox11.Image;
                pictureBox11.Image = pictureBox15.Image;
                pictureBox15.Image = b;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox15.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox7.Image == aa)
            {
                b = pictureBox15.Image;
                pictureBox15.Image = pictureBox7.Image;
                pictureBox7.Image = b;
            }
            else if (pictureBox17.Image == aa)
            {
                b = pictureBox15.Image;
                pictureBox15.Image = pictureBox17.Image;
                pictureBox17.Image = b;
            }
            else if (pictureBox11.Image == aa)
            {
                b = pictureBox15.Image;
                pictureBox15.Image = pictureBox11.Image;
                pictureBox11.Image = b;
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (pictureBox21.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox11.Image == aa)
            {
                b = pictureBox21.Image;
                pictureBox21.Image = pictureBox11.Image;
                pictureBox11.Image = b;
            }
            else if (pictureBox22.Image == aa)
            {
                b = pictureBox21.Image;
                pictureBox21.Image = pictureBox22.Image;
                pictureBox22.Image = b;
            }
          
        }
        int count = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.tom6;
            pictureBox2.Image = Properties.Resources.tom7;
            pictureBox3.Image = Properties.Resources.tom2;
            pictureBox4.Image = Properties.Resources.tom3;
            pictureBox5.Image = Properties.Resources.Tom001;
            pictureBox6.Image = Properties.Resources.tom9;
            pictureBox7.Image = Properties.Resources.tom11;
            pictureBox8.Image = Properties.Resources.tom4;
            pictureBox9.Image = Properties.Resources.tom5;
            pictureBox10.Image = Properties.Resources.tom12;
            pictureBox11.Image = Properties.Resources.tom8;
            pictureBox12.Image = Properties.Resources.tom10;
            pictureBox13.Image = Properties.Resources.tom17;
            pictureBox14.Image = Properties.Resources.tom19;
            pictureBox15.Image = Properties.Resources.tom13;
            pictureBox16.Image = Properties.Resources.tom18;
            pictureBox17.Image = Properties.Resources.tom15;
            pictureBox18.Image = Properties.Resources.tom14;
            pictureBox19.Image = Properties.Resources.tom20;
            pictureBox20.Image = Properties.Resources.tom21;
            pictureBox25.Image = Properties.Resources.tom16;
            pictureBox22.Image = Properties.Resources.tom24;
            pictureBox23.Image = Properties.Resources.tom22;
            pictureBox24.Image = Properties.Resources.tom23;
            pictureBox21.Image = Properties.Resources.Typeform_Blog_BlackFriday_Cover_AskAwesomely;
            aa = (Bitmap)pictureBox21.Image;

            count = 0;
            sec = 0;
            min = 0;
            hour = 0;

            label2.Text = "00";
            label3.Text = "00";
            label4.Text = "00";
            label5.Text = "00";

        }
        int sec = 0;
        int min = 0;
        int hour = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            label5.Text = sec.ToString();

            if(sec==60)
            {
                sec = 0;
                min++;
                label4.Text = min.ToString();

                if(min==60)
                {
                    hour++;
                    label3.Text = hour.ToString();
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "WARNING", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LevelsForm aa = new LevelsForm();
                aa.Show();
                this.Close();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox5.Image == aa)
            {
                b = pictureBox7.Image;
                pictureBox7.Image = pictureBox5.Image;
                pictureBox5.Image = b;
            }
            else if (pictureBox8.Image == aa)
            {
                b = pictureBox7.Image;
                pictureBox7.Image = pictureBox8.Image;
                pictureBox8.Image = b;
            }
            else if (pictureBox15.Image == aa)
            {
                b = pictureBox7.Image;
                pictureBox7.Image = pictureBox15.Image;
                pictureBox15.Image = b;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox3.Image == aa)
            {
                b = pictureBox5.Image;
                pictureBox5.Image = pictureBox3.Image;
                pictureBox3.Image = b;
            }
            else if (pictureBox7.Image == aa)
            {
                b = pictureBox5.Image;
                pictureBox5.Image = pictureBox7.Image;
                pictureBox7.Image = b;
            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != aa )
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox5.Image == aa)
            {
                b = pictureBox3.Image;
                pictureBox3.Image = pictureBox5.Image;
                pictureBox5.Image = b;
            }
            else if (pictureBox8.Image == aa)
            {
                b = pictureBox3.Image;
                pictureBox3.Image = pictureBox8.Image;
                pictureBox8.Image = b;
            }
            else if (pictureBox4.Image == aa)
            {
                b = pictureBox3.Image;
                pictureBox3.Image = pictureBox4.Image;
                pictureBox4.Image = b;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox1.Image == aa)
            {
                b = pictureBox2.Image;
                pictureBox2.Image = pictureBox1.Image;
                pictureBox1.Image = b;
            }
            else if (pictureBox10.Image == aa)
            {
                b = pictureBox2.Image;
                pictureBox2.Image = pictureBox10.Image;
                pictureBox10.Image = b;
            }
            else if (pictureBox4.Image == aa)
            {
                b = pictureBox2.Image;
                pictureBox2.Image = pictureBox4.Image;
                pictureBox4.Image = b;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox1.Image == aa)
            {
                b = pictureBox6.Image;
                pictureBox6.Image = pictureBox1.Image;
                pictureBox1.Image = b;
            }
            else if (pictureBox20.Image == aa)
            {
                b = pictureBox6.Image;
                pictureBox6.Image = pictureBox20.Image;
                pictureBox20.Image = b;
            }
            else if (pictureBox10.Image == aa)
            {
                b = pictureBox6.Image;
                pictureBox6.Image = pictureBox10.Image;
                pictureBox10.Image = b;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (pictureBox20.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox6.Image == aa)
            {
                b = pictureBox20.Image;
                pictureBox20.Image = pictureBox6.Image;
                pictureBox6.Image = b;
            }
            else if (pictureBox19.Image == aa)
            {
                b = pictureBox20.Image;
                pictureBox20.Image = pictureBox19.Image;
                pictureBox19.Image = b;
            }
            else if (pictureBox16.Image == aa)
            {
                b = pictureBox20.Image;
                pictureBox20.Image = pictureBox16.Image;
                pictureBox16.Image = b;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (pictureBox16.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox20.Image == aa)
            {
                b = pictureBox16.Image;
                pictureBox16.Image = pictureBox20.Image;
                pictureBox20.Image = b;
            }
            else if (pictureBox14.Image == aa)
            {
                b = pictureBox16.Image;
                pictureBox16.Image = pictureBox14.Image;
                pictureBox14.Image = b;
            }
            else if (pictureBox25.Image == aa)
            {
                b = pictureBox16.Image;
                pictureBox16.Image = pictureBox25.Image;
                pictureBox25.Image = b;
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (pictureBox25.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox16.Image == aa)
            {
                b = pictureBox25.Image;
                pictureBox25.Image = pictureBox16.Image;
                pictureBox16.Image = b;
            }
            else if (pictureBox24.Image == aa)
            {
                b = pictureBox25.Image;
                pictureBox25.Image = pictureBox24.Image;
                pictureBox24.Image = b;
            }
           
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (pictureBox24.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox23.Image == aa)
            {
                b = pictureBox24.Image;
                pictureBox24.Image = pictureBox23.Image;
                pictureBox23.Image = b;
            }
            else if (pictureBox14.Image == aa)
            {
                b = pictureBox24.Image;
                pictureBox24.Image = pictureBox14.Image;
                pictureBox14.Image = b;
            }
            else if (pictureBox25.Image == aa)
            {
                b = pictureBox24.Image;
                pictureBox24.Image = pictureBox25.Image;
                pictureBox25.Image = b;
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (pictureBox23.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox13.Image == aa)
            {
                b = pictureBox23.Image;
                pictureBox23.Image = pictureBox13.Image;
                pictureBox13.Image = b;
            }
            else if (pictureBox24.Image == aa)
            {
                b = pictureBox23.Image;
                pictureBox23.Image = pictureBox24.Image;
                pictureBox24.Image = b;
            }
            else if (pictureBox22.Image == aa)
            {
                b = pictureBox23.Image;
                pictureBox23.Image = pictureBox22.Image;
                pictureBox22.Image = b;
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (pictureBox22.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox21.Image == aa)
            {
                b = pictureBox22.Image;
                pictureBox22.Image = pictureBox21.Image;
                pictureBox21.Image = b;
            }
            else if (pictureBox12.Image == aa)
            {
                b = pictureBox22.Image;
                pictureBox22.Image = pictureBox12.Image;
                pictureBox12.Image = b;
            }
            else if (pictureBox23.Image == aa)
            {
                b = pictureBox22.Image;
                pictureBox22.Image = pictureBox23.Image;
                pictureBox23.Image = b;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox11.Image == aa)
            {
                b = pictureBox12.Image;
                pictureBox12.Image = pictureBox11.Image;
                pictureBox11.Image = b;
            }
            else if (pictureBox13.Image == aa)
            {
                b = pictureBox12.Image;
                pictureBox12.Image = pictureBox13.Image;
                pictureBox13.Image = b;
            }
            else if (pictureBox22.Image == aa)
            {
                b = pictureBox12.Image;
                pictureBox12.Image = pictureBox22.Image;
                pictureBox22.Image = b;
            }
            else if (pictureBox17.Image == aa)
            {
                b = pictureBox12.Image;
                pictureBox12.Image = pictureBox17.Image;
                pictureBox17.Image = b;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox18.Image == aa)
            {
                b = pictureBox13.Image;
                pictureBox13.Image = pictureBox18.Image;
                pictureBox18.Image = b;
            }
            else if (pictureBox14.Image == aa)
            {
                b = pictureBox13.Image;
                pictureBox13.Image = pictureBox14.Image;
                pictureBox14.Image = b;
            }
            else if (pictureBox23.Image == aa)
            {
                b = pictureBox13.Image;
                pictureBox13.Image = pictureBox23.Image;
                pictureBox23.Image = b;
            }
            else if (pictureBox12.Image == aa)
            {
                b = pictureBox13.Image;
                pictureBox13.Image = pictureBox12.Image;
                pictureBox12.Image = b;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox14.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox16.Image == aa)
            {
                b = pictureBox14.Image;
                pictureBox14.Image = pictureBox16.Image;
                pictureBox16.Image = b;
            }
            else if (pictureBox13.Image == aa)
            {
                b = pictureBox14.Image;
                pictureBox14.Image = pictureBox13.Image;
                pictureBox13.Image = b;
            }
            else if (pictureBox19.Image == aa)
            {
                b = pictureBox14.Image;
                pictureBox14.Image = pictureBox19.Image;
                pictureBox19.Image = b;
            }
            else if (pictureBox24.Image == aa)
            {
                b = pictureBox14.Image;
                pictureBox14.Image = pictureBox24.Image;
                pictureBox24.Image = b;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (pictureBox19.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox10.Image == aa)
            {
                b = pictureBox19.Image;
                pictureBox19.Image = pictureBox10.Image;
                pictureBox10.Image = b;
            }
            else if (pictureBox20.Image == aa)
            {
                b = pictureBox19.Image;
                pictureBox19.Image = pictureBox20.Image;
                pictureBox20.Image = b;
            }
            else if (pictureBox14.Image == aa)
            {
                b = pictureBox19.Image;
                pictureBox19.Image = pictureBox14.Image;
                pictureBox14.Image = b;
            }
            else if (pictureBox18.Image == aa)
            {
                b = pictureBox19.Image;
                pictureBox19.Image = pictureBox18.Image;
                pictureBox18.Image = b;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (pictureBox18.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox9.Image == aa)
            {
                b = pictureBox18.Image;
                pictureBox18.Image = pictureBox9.Image;
                pictureBox9.Image = b;
            }
            else if (pictureBox13.Image == aa)
            {
                b = pictureBox18.Image;
                pictureBox18.Image = pictureBox13.Image;
                pictureBox13.Image = b;
            }
            else if (pictureBox19.Image == aa)
            {
                b = pictureBox18.Image;
                pictureBox18.Image = pictureBox19.Image;
                pictureBox19.Image = b;
            }
            else if (pictureBox17.Image == aa)
            {
                b = pictureBox18.Image;
                pictureBox18.Image = pictureBox17.Image;
                pictureBox17.Image = b;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox15.Image == aa)
            {
                b = pictureBox17.Image;
                pictureBox17.Image = pictureBox15.Image;
                pictureBox15.Image = b;
            }
            else if (pictureBox12.Image == aa)
            {
                b = pictureBox17.Image;
                pictureBox17.Image = pictureBox12.Image;
                pictureBox12.Image = b;
            }
            else if (pictureBox18.Image == aa)
            {
                b = pictureBox17.Image;
                pictureBox17.Image = pictureBox18.Image;
                pictureBox18.Image = b;
            }
            else if (pictureBox8.Image == aa)
            {
                b = pictureBox17.Image;
                pictureBox17.Image = pictureBox8.Image;
                pictureBox8.Image = b;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox6.Image == aa)
            {
                b = pictureBox10.Image;
                pictureBox10.Image = pictureBox6.Image;
                pictureBox6.Image = b;
            }
            else if (pictureBox19.Image == aa)
            {
                b = pictureBox10.Image;
                pictureBox10.Image = pictureBox19.Image;
                pictureBox19.Image = b;
            }
            else if (pictureBox9.Image == aa)
            {
                b = pictureBox10.Image;
                pictureBox10.Image = pictureBox9.Image;
                pictureBox9.Image = b;
            }
            else if (pictureBox2.Image == aa)
            {
                b = pictureBox10.Image;
                pictureBox10.Image = pictureBox2.Image;
                pictureBox2.Image = b;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox4.Image == aa)
            {
                b = pictureBox9.Image;
                pictureBox9.Image = pictureBox4.Image;
                pictureBox4.Image = b;
            }
            else if (pictureBox10.Image == aa)
            {
                b = pictureBox9.Image;
                pictureBox9.Image = pictureBox10.Image;
                pictureBox10.Image = b;
            }
            else if (pictureBox18.Image == aa)
            {
                b = pictureBox9.Image;
                pictureBox9.Image = pictureBox18.Image;
                pictureBox18.Image = b;
            }
            else if (pictureBox8.Image == aa)
            {
                b = pictureBox9.Image;
                pictureBox9.Image = pictureBox8.Image;
                pictureBox8.Image = b;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox17.Image == aa)
            {
                b = pictureBox8.Image;
                pictureBox8.Image = pictureBox17.Image;
                pictureBox17.Image = b;
            }
            else if (pictureBox7.Image == aa)
            {
                b = pictureBox8.Image;
                pictureBox8.Image = pictureBox7.Image;
                pictureBox7.Image = b;
            }
            else if (pictureBox3.Image == aa)
            {
                b = pictureBox8.Image;
                pictureBox8.Image = pictureBox3.Image;
                pictureBox3.Image = b;
            }
            else if (pictureBox9.Image == aa)
            {
                b = pictureBox8.Image;
                pictureBox8.Image = pictureBox9.Image;
                pictureBox9.Image = b;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
