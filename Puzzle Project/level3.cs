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
    public partial class level3 : Form
    {
        public level3()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            if (pictureBox35.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
           
            }
            if (pictureBox42.Image == aa)
            {
                b = pictureBox35.Image;
                pictureBox35.Image = pictureBox42.Image;
                pictureBox42.Image = b;
            }
            else if (pictureBox34.Image == aa)
            {
                b = pictureBox35.Image;
                pictureBox35.Image = pictureBox34.Image;
                pictureBox34.Image = b;
            }
            else if (pictureBox49.Image == aa)
            {
                b = pictureBox35.Image;
                pictureBox35.Image = pictureBox49.Image;
                pictureBox49.Image = b;
            }
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            if (pictureBox34.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
          
            }
            if (pictureBox41.Image == aa)
            {
                b = pictureBox34.Image;
                pictureBox34.Image = pictureBox41.Image;
                pictureBox41.Image = b;
            }
            else if (pictureBox35.Image == aa)
            {
                b = pictureBox34.Image;
                pictureBox34.Image = pictureBox35.Image;
                pictureBox35.Image = b;
            }
            else if (pictureBox48.Image == aa)
            {
                b = pictureBox34.Image;
                pictureBox34.Image = pictureBox48.Image;
                pictureBox48.Image = b;
            }
            else if (pictureBox33.Image == aa)
            {
                b = pictureBox34.Image;
                pictureBox34.Image = pictureBox33.Image;
                pictureBox33.Image = b;
            }
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            if (pictureBox33.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
              
            }
            if (pictureBox40.Image == aa)
            {
                b = pictureBox33.Image;
                pictureBox33.Image = pictureBox40.Image;
                pictureBox40.Image = b;
            }
            else if (pictureBox34.Image == aa)
            {
                b = pictureBox33.Image;
                pictureBox33.Image = pictureBox34.Image;
                pictureBox34.Image = b;
            }
            else if (pictureBox47.Image == aa)
            {
                b = pictureBox33.Image;
                pictureBox33.Image = pictureBox47.Image;
                pictureBox47.Image = b;
            }
            else if (pictureBox32.Image == aa)
            {
                b = pictureBox33.Image;
                pictureBox33.Image = pictureBox32.Image;
                pictureBox32.Image = b;
            }
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            if (pictureBox32.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox39.Image == aa)
            {
                b = pictureBox32.Image;
                pictureBox32.Image = pictureBox39.Image;
                pictureBox39.Image = b;
            }
            else if (pictureBox33.Image == aa)
            {
                b = pictureBox32.Image;
                pictureBox32.Image = pictureBox33.Image;
                pictureBox33.Image = b;
            }
            else if (pictureBox46.Image == aa)
            {
                b = pictureBox32.Image;
                pictureBox32.Image = pictureBox46.Image;
                pictureBox46.Image = b;
            }
            else if (pictureBox31.Image == aa)
            {
                b = pictureBox32.Image;
                pictureBox32.Image = pictureBox31.Image;
                pictureBox31.Image = b;
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            if (pictureBox31.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox38.Image == aa)
            {
                b = pictureBox31.Image;
                pictureBox31.Image = pictureBox38.Image;
                pictureBox38.Image = b;
            }
            else if (pictureBox32.Image == aa)
            {
                b = pictureBox31.Image;
                pictureBox31.Image = pictureBox32.Image;
                pictureBox32.Image = b;
            }
            else if (pictureBox45.Image == aa)
            {
                b = pictureBox31.Image;
                pictureBox31.Image = pictureBox45.Image;
                pictureBox45.Image = b;
            }
            else if (pictureBox30.Image == aa)
            {
                b = pictureBox31.Image;
                pictureBox31.Image = pictureBox30.Image;
                pictureBox30.Image = b;
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            if (pictureBox30.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox37.Image == aa)
            {
                b = pictureBox30.Image;
                pictureBox30.Image = pictureBox37.Image;
                pictureBox37.Image = b;
            }
            else if (pictureBox31.Image == aa)
            {
                b = pictureBox30.Image;
                pictureBox30.Image = pictureBox31.Image;
                pictureBox31.Image = b;
            }
            else if (pictureBox44.Image == aa)
            {
                b = pictureBox30.Image;
                pictureBox30.Image = pictureBox44.Image;
                pictureBox44.Image = b;
            }
            else if (pictureBox29.Image == aa)
            {
                b = pictureBox30.Image;
                pictureBox30.Image = pictureBox29.Image;
                pictureBox29.Image = b;
            }
        }
        int count = 0;
        Image b;
        private void pictureBox29_Click(object sender, EventArgs e)
        {
           

            if (pictureBox29.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox36.Image == aa)
            {
                b = pictureBox29.Image;
                pictureBox29.Image = pictureBox36.Image;
                pictureBox36.Image = b;
            }
            else if (pictureBox43.Image == aa)
            {
                b = pictureBox29.Image;
                pictureBox29.Image = pictureBox43.Image;
                pictureBox43.Image = b;
            }
            else if (pictureBox30.Image == aa)
            {
                b = pictureBox29.Image;
                pictureBox29.Image = pictureBox30.Image;
                pictureBox30.Image = b;
            }
        }
        Image aa;
        ////SoundPlayer click = new SoundPlayer(@"D:\Projects\Puzzle Project\Puzzle Project\click.wav");


        private void level3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Image = Properties.Resources.img3;
            pictureBox2.Image = Properties.Resources.img5;
            pictureBox3.Image = Properties.Resources.img6;
            pictureBox4.Image = Properties.Resources.img9;
            pictureBox5.Image = Properties.Resources.img1;
            pictureBox6.Image = Properties.Resources.img2; 
            pictureBox7.Image = Properties.Resources.img7;
            pictureBox8.Image = Properties.Resources.img8;
            pictureBox9.Image = Properties.Resources.img4;
            pictureBox10.Image = Properties.Resources.image_part_014;
            pictureBox11.Image = Properties.Resources.image_part_016;
            pictureBox12.Image = Properties.Resources.image_part_018;
            pictureBox13.Image =  Properties.Resources.image_part_041;
            pictureBox14.Image = Properties.Resources.image_part_013;
            pictureBox15.Image = Properties.Resources.image_part_015;
            pictureBox16.Image = Properties.Resources.image_part_012;
            pictureBox17.Image = Properties.Resources.image_part_017;
            pictureBox18.Image = Properties.Resources.image_part_019;
            pictureBox19.Image = Properties.Resources.image_part_025;
            pictureBox20.Image = Properties.Resources.image_part_029;
            pictureBox21.Image = Properties.Resources.image_part_020;
            pictureBox22.Image = Properties.Resources.image_part_023;
            pictureBox23.Image = Properties.Resources.image_part_010;
            pictureBox24.Image = Properties.Resources.image_part_022;
            pictureBox25.Image = Properties.Resources.image_part_024;
            pictureBox26.Image = Properties.Resources.image_part_027;
            pictureBox27.Image = Properties.Resources.image_part_026;
            pictureBox28.Image = Properties.Resources.image_part_033;
            pictureBox29.Image = Properties.Resources.image_part_021;
            pictureBox30.Image = Properties.Resources.image_part_028;
            pictureBox31.Image = Properties.Resources.image_part_038;
            pictureBox32.Image = Properties.Resources.image_part_031;
            pictureBox33.Image = Properties.Resources.image_part_035;
            pictureBox34.Image = Properties.Resources.image_part_011;
            pictureBox35.Image = Properties.Resources.image_part_034;
            pictureBox36.Image = Properties.Resources.image_part_032;
            pictureBox37.Image = Properties.Resources.image_part_045;
            pictureBox38.Image = Properties.Resources.image_part_036;
            pictureBox39.Image = Properties.Resources.image_part_030;
            pictureBox40.Image = Properties.Resources.image_part_037;
            pictureBox41.Image = Properties.Resources.image_part_039;
            pictureBox42.Image = Properties.Resources.image_part_040;
            pictureBox49.Image = Properties.Resources.image_part_044;
            pictureBox44.Image = Properties.Resources.image_part_046;
            pictureBox45.Image = Properties.Resources.image_part_042;
            pictureBox46.Image = Properties.Resources.image_part_043;
            pictureBox47.Image = Properties.Resources.image_part_047;
            pictureBox48.Image = Properties.Resources.image_part_048;
            pictureBox43.Image = Properties.Resources.Typeform_Blog_BlackFriday_Cover_AskAwesomely;

            aa = pictureBox43.Image;

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (pictureBox13.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
             
            }
            if (pictureBox2.Image == aa)
            {
                b = pictureBox13.Image;
                pictureBox13.Image = pictureBox2.Image;
                pictureBox2.Image = b;
            }
            else if (pictureBox14.Image == aa)
            {
                b = pictureBox13.Image;
                pictureBox13.Image = pictureBox14.Image;
                pictureBox14.Image = b;
            }
            else if (pictureBox27.Image == aa)
            {
                b = pictureBox13.Image;
                pictureBox13.Image = pictureBox27.Image;
                pictureBox27.Image = b;
            }
            else if (pictureBox12.Image == aa)
            {
                b = pictureBox13.Image;
                pictureBox13.Image = pictureBox12.Image;
                pictureBox12.Image = b;
            }
        }
        int sec = 0;
        int min = 0;
        int hour = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            label6.Text = sec.ToString();
            if (sec == 60)
            {
                sec = 0;
                min++;
                label5.Text = min.ToString();
                if (min == 60)
                {
                    hour++;
                    label3.Text = hour.ToString();
                }
            }
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

           

            if (pictureBox36.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox15.Image == aa)
            {
                b = pictureBox36.Image;
                pictureBox36.Image = pictureBox15.Image;
                pictureBox15.Image = b;
            }
            else if (pictureBox29.Image == aa)
            {
                b = pictureBox36.Image;
                pictureBox36.Image = pictureBox29.Image;
                pictureBox29.Image = b;
            }
            else if (pictureBox37.Image == aa)
            {
                b = pictureBox36.Image;
                pictureBox36.Image = pictureBox37.Image;
                pictureBox37.Image = b;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
           

            if (pictureBox15.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox16.Image == aa)
            {
                b = pictureBox15.Image;
                pictureBox15.Image = pictureBox16.Image;
                pictureBox16.Image = b;
            }
            else if (pictureBox22.Image == aa)
            {
                b = pictureBox15.Image;
                pictureBox15.Image = pictureBox22.Image;
                pictureBox22.Image = b;
            }
            else if (pictureBox36.Image == aa)
            {
                b = pictureBox15.Image;
                pictureBox15.Image = pictureBox36.Image;
                pictureBox36.Image = b;
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            
            if (pictureBox22.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox5.Image == aa)
            {
                b = pictureBox22.Image;
                pictureBox22.Image = pictureBox5.Image;
                pictureBox5.Image = b;
            }
            else if (pictureBox23.Image == aa)
            {
                b = pictureBox22.Image;
                pictureBox22.Image = pictureBox23.Image;
                pictureBox23.Image = b;
            }
            else if (pictureBox15.Image == aa)
            {
                b = pictureBox22.Image;
                pictureBox22.Image = pictureBox15.Image;
                pictureBox15.Image = b;
            }
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            if (pictureBox43.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
              
            }
            if (pictureBox29.Image == aa)
            {
                b = pictureBox43.Image;
                pictureBox43.Image = pictureBox29.Image;
                pictureBox29.Image = b;
            }
            else if (pictureBox44.Image == aa)
            {
                b = pictureBox43.Image;
                pictureBox43.Image = pictureBox44.Image;
                pictureBox44.Image = b;
            }
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            if (pictureBox22.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            }
            if (pictureBox6.Image == aa)
            {
                b = pictureBox5.Image;
                pictureBox5.Image = pictureBox6.Image;
                pictureBox6.Image = b;
            }
            else if (pictureBox9.Image == aa)
            {
                b = pictureBox5.Image;
                pictureBox5.Image = pictureBox9.Image;
                pictureBox9.Image = b;
            }
            else if (pictureBox22.Image == aa)
            {
                b = pictureBox5.Image;
                pictureBox5.Image = pictureBox22.Image;
                pictureBox22.Image = b;
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           
            if (pictureBox6.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
             
            }
            if (pictureBox7.Image == aa)
            {
                b = pictureBox6.Image;
                pictureBox6.Image = pictureBox7.Image;
                pictureBox7.Image = b;
            }
            else if (pictureBox5.Image == aa)
            {
                b = pictureBox6.Image;
                pictureBox6.Image = pictureBox5.Image;
                pictureBox5.Image = b;
            }
          
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox6.Image == aa)
            {
                b = pictureBox7.Image;
                pictureBox7.Image = pictureBox6.Image;
                pictureBox6.Image = b;
            }
            else if (pictureBox9.Image == aa)
            {
                b = pictureBox7.Image;
                pictureBox7.Image = pictureBox9.Image;
                pictureBox9.Image = b;
            }
            else if (pictureBox8.Image == aa)
            {
                b = pictureBox7.Image;
                pictureBox7.Image = pictureBox8.Image;
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
            if (pictureBox3.Image == aa)
            {
                b = pictureBox8.Image;
                pictureBox8.Image = pictureBox3.Image;
                pictureBox3.Image = b;
            }
            else if (pictureBox10.Image == aa)
            {
                b = pictureBox8.Image;
                pictureBox8.Image = pictureBox10.Image;
                pictureBox10.Image = b;
            }
            else if (pictureBox7.Image == aa)
            {
                b = pictureBox8.Image;
                pictureBox8.Image = pictureBox7.Image;
                pictureBox7.Image = b;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox11.Image == aa)
            {
                b = pictureBox3.Image;
                pictureBox3.Image = pictureBox11.Image;
                pictureBox11.Image = b;
            }
            else if (pictureBox4.Image == aa)
            {
                b = pictureBox3.Image;
                pictureBox3.Image = pictureBox4.Image;
                pictureBox4.Image = b;
            }
            else if (pictureBox8.Image == aa)
            {
                b = pictureBox3.Image;
                pictureBox3.Image = pictureBox8.Image;
                pictureBox8.Image = b;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
             
            }
            if (pictureBox2.Image == aa)
            {
                b = pictureBox4.Image;
                pictureBox4.Image = pictureBox2.Image;
                pictureBox2.Image = b;
            }
            else if (pictureBox12.Image == aa)
            {
                b = pictureBox4.Image;
                pictureBox4.Image = pictureBox12.Image;
                pictureBox12.Image = b;
            }
            else if (pictureBox3.Image == aa)
            {
                b = pictureBox4.Image;
                pictureBox4.Image = pictureBox3.Image;
                pictureBox3.Image = b;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != aa)
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
            else if (pictureBox13.Image == aa)
            {
                b = pictureBox2.Image;
                pictureBox2.Image = pictureBox13.Image;
                pictureBox13.Image = b;
            }
            else if (pictureBox4.Image == aa)
            {
                b = pictureBox2.Image;
                pictureBox2.Image = pictureBox4.Image;
                pictureBox4.Image = b;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox7.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            
            }
            if (pictureBox2.Image == aa)
            {
                b = pictureBox1.Image;
                pictureBox1.Image = pictureBox2.Image;
                pictureBox2.Image = b;
            }
            else if (pictureBox14.Image == aa)
            {
                b = pictureBox1.Image;
                pictureBox1.Image = pictureBox14.Image;
                pictureBox14.Image = b;
            }
          
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (pictureBox14.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox1.Image == aa)
            {
                b = pictureBox14.Image;
                pictureBox14.Image = pictureBox1.Image;
                pictureBox1.Image = b;
            }
            else if (pictureBox13.Image == aa)
            {
                b = pictureBox14.Image;
                pictureBox14.Image = pictureBox13.Image;
                pictureBox13.Image = b;
            }
            else if (pictureBox28.Image == aa)
            {
                b = pictureBox14.Image;
                pictureBox14.Image = pictureBox28.Image;
                pictureBox28.Image = b;
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            if (pictureBox28.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox14.Image == aa)
            {
                b = pictureBox28.Image;
                pictureBox28.Image = pictureBox14.Image;
                pictureBox14.Image = b;
            }
            else if (pictureBox27.Image == aa)
            {
                b = pictureBox28.Image;
                pictureBox28.Image = pictureBox27.Image;
                pictureBox27.Image = b;
            }
            else if (pictureBox21.Image == aa)
            {
                b = pictureBox28.Image;
                pictureBox28.Image = pictureBox21.Image;
                pictureBox21.Image = b;
            }
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (pictureBox21.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
              
            }
            if (pictureBox28.Image == aa)
            {
                b = pictureBox21.Image;
                pictureBox21.Image = pictureBox28.Image;
                pictureBox28.Image = b;
            }
            else if (pictureBox20.Image == aa)
            {
                b = pictureBox21.Image;
                pictureBox21.Image = pictureBox20.Image;
                pictureBox20.Image = b;
            }
            else if (pictureBox42.Image == aa)
            {
                b = pictureBox21.Image;
                pictureBox21.Image = pictureBox42.Image;
                pictureBox42.Image = b;
            }
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            if (pictureBox42.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
              
            }
            if (pictureBox21.Image == aa)
            {
                b = pictureBox42.Image;
                pictureBox42.Image = pictureBox21.Image;
                pictureBox21.Image = b;
            }
            else if (pictureBox41.Image == aa)
            {
                b = pictureBox42.Image;
                pictureBox42.Image = pictureBox41.Image;
                pictureBox41.Image = b;
            }
            else if (pictureBox35.Image == aa)
            {
                b = pictureBox42.Image;
                pictureBox42.Image = pictureBox35.Image;
                pictureBox35.Image = b;
            }
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            if (pictureBox49.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
              
            }
            if (pictureBox35.Image == aa)
            {
                b = pictureBox49.Image;
                pictureBox49.Image = pictureBox35.Image;
                pictureBox35.Image = b;
            }
            else if (pictureBox48.Image == aa)
            {
                b = pictureBox49.Image;
                pictureBox49.Image = pictureBox48.Image;
                pictureBox48.Image = b;
            }
            
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (pictureBox27.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox13.Image == aa)
            {
                b = pictureBox27.Image;
                pictureBox27.Image = pictureBox13.Image;
                pictureBox13.Image = b;
            }
            else if (pictureBox28.Image == aa)
            {
                b = pictureBox27.Image;
                pictureBox27.Image = pictureBox28.Image;
                pictureBox28.Image = b;
            }
            else if (pictureBox20.Image == aa)
            {
                b = pictureBox27.Image;
                pictureBox27.Image = pictureBox20.Image;
                pictureBox20.Image = b;
            }
            else if (pictureBox26.Image == aa)
            {
                b = pictureBox27.Image;
                pictureBox27.Image = pictureBox26.Image;
                pictureBox26.Image = b;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (pictureBox20.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
         
            }
            if (pictureBox27.Image == aa)
            {
                b = pictureBox20.Image;
                pictureBox20.Image = pictureBox27.Image;
                pictureBox27.Image = b;
            }
            else if (pictureBox21.Image == aa)
            {
                b = pictureBox20.Image;
                pictureBox20.Image = pictureBox21.Image;
                pictureBox21.Image = b;
            }
            else if (pictureBox41.Image == aa)
            {
                b = pictureBox20.Image;
                pictureBox20.Image = pictureBox41.Image;
                pictureBox41.Image = b;
            }
            else if (pictureBox19.Image == aa)
            {
                b = pictureBox20.Image;
                pictureBox20.Image = pictureBox19.Image;
                pictureBox19.Image = b;
            }
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            if (pictureBox41.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
                
            }
            if (pictureBox20.Image == aa)
            {
                b = pictureBox41.Image;
                pictureBox41.Image = pictureBox20.Image;
                pictureBox20.Image = b;
            }
            else if (pictureBox42.Image == aa)
            {
                b = pictureBox41.Image;
                pictureBox41.Image = pictureBox42.Image;
                pictureBox42.Image = b;
            }
            else if (pictureBox34.Image == aa)
            {
                b = pictureBox41.Image;
                pictureBox41.Image = pictureBox34.Image;
                pictureBox34.Image = b;
            }
            else if (pictureBox40.Image == aa)
            {
                b = pictureBox41.Image;
                pictureBox41.Image = pictureBox40.Image;
                pictureBox40.Image = b;
            }
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            if (pictureBox48.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox34.Image == aa)
            {
                b = pictureBox48.Image;
                pictureBox48.Image = pictureBox34.Image;
                pictureBox34.Image = b;
            }
            else if (pictureBox49.Image == aa)
            {
                b = pictureBox48.Image;
                pictureBox48.Image = pictureBox49.Image;
                pictureBox49.Image = b;
            }
            else if (pictureBox47.Image == aa)
            {
                b = pictureBox48.Image;
                pictureBox48.Image = pictureBox47.Image;
                pictureBox47.Image = b;
            }
          
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            if (pictureBox47.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
                
            }
            if (pictureBox33.Image == aa)
            {
                b = pictureBox47.Image;
                pictureBox47.Image = pictureBox33.Image;
                pictureBox33.Image = b;
            }
            else if (pictureBox48.Image == aa)
            {
                b = pictureBox47.Image;
                pictureBox47.Image = pictureBox48.Image;
                pictureBox48.Image = b;
            }
            else if (pictureBox46.Image == aa)
            {
                b = pictureBox47.Image;
                pictureBox47.Image = pictureBox46.Image;
                pictureBox46.Image = b;
            }
           
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            if (pictureBox46.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
             
            }
            if (pictureBox32.Image == aa)
            {
                b = pictureBox46.Image;
                pictureBox46.Image = pictureBox32.Image;
                pictureBox32.Image = b;
            }
            else if (pictureBox47.Image == aa)
            {
                b = pictureBox46.Image;
                pictureBox46.Image = pictureBox47.Image;
                pictureBox47.Image = b;
            }
            else if (pictureBox45.Image == aa)
            {
                b = pictureBox46.Image;
                pictureBox46.Image = pictureBox45.Image;
                pictureBox45.Image = b;
            }
          
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            if (pictureBox45.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox31.Image == aa)
            {
                b = pictureBox45.Image;
                pictureBox45.Image = pictureBox31.Image;
                pictureBox31.Image = b;
            }
            else if (pictureBox46.Image == aa)
            {
                b = pictureBox45.Image;
                pictureBox45.Image = pictureBox46.Image;
                pictureBox46.Image = b;
            }
            else if (pictureBox44.Image == aa)
            {
                b = pictureBox45.Image;
                pictureBox45.Image = pictureBox44.Image;
                pictureBox44.Image = b;
            }
           
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            if (pictureBox44.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
             
            }
            if (pictureBox30.Image == aa)
            {
                b = pictureBox44.Image;
                pictureBox44.Image = pictureBox30.Image;
                pictureBox30.Image = b;
            }
            else if (pictureBox45.Image == aa)
            {
                b = pictureBox44.Image;
                pictureBox44.Image = pictureBox45.Image;
                pictureBox45.Image = b;
            }
            else if (pictureBox43.Image == aa)
            {
                b = pictureBox44.Image;
                pictureBox44.Image = pictureBox43.Image;
                pictureBox43.Image = b;
            }
           
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            if (pictureBox37.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
                
            }
            if (pictureBox16.Image == aa)
            {
                b = pictureBox37.Image;
                pictureBox37.Image = pictureBox16.Image;
                pictureBox16.Image = b;
            }
            else if (pictureBox38.Image == aa)
            {
                b = pictureBox37.Image;
                pictureBox37.Image = pictureBox38.Image;
                pictureBox38.Image = b;
            }
            else if (pictureBox30.Image == aa)
            {
                b = pictureBox37.Image;
                pictureBox37.Image = pictureBox30.Image;
                pictureBox30.Image = b;
            }
            else if (pictureBox36.Image == aa)
            {
                b = pictureBox37.Image;
                pictureBox37.Image = pictureBox36.Image;
                pictureBox36.Image = b;
            }
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            if (pictureBox38.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox39.Image == aa)
            {
                b = pictureBox38.Image;
                pictureBox38.Image = pictureBox39.Image;
                pictureBox39.Image = b;
            }
            else if (pictureBox17.Image == aa)
            {
                b = pictureBox38.Image;
                pictureBox38.Image = pictureBox17.Image;
                pictureBox17.Image = b;
            }
            else if (pictureBox37.Image == aa)
            {
                b = pictureBox38.Image;
                pictureBox38.Image = pictureBox37.Image;
                pictureBox37.Image = b;
            }
            else if (pictureBox31.Image == aa)
            {
                b = pictureBox38.Image;
                pictureBox38.Image = pictureBox31.Image;
                pictureBox31.Image = b;
            }
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            if (pictureBox39.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
             
            }
            if (pictureBox18.Image == aa)
            {
                b = pictureBox39.Image;
                pictureBox39.Image = pictureBox18.Image;
                pictureBox18.Image = b;
            }
            else if (pictureBox40.Image == aa)
            {
                b = pictureBox39.Image;
                pictureBox39.Image = pictureBox40.Image;
                pictureBox40.Image = b;
            }
            else if (pictureBox32.Image == aa)
            {
                b = pictureBox39.Image;
                pictureBox39.Image = pictureBox32.Image;
                pictureBox32.Image = b;
            }
            else if (pictureBox38.Image == aa)
            {
                b = pictureBox39.Image;
                pictureBox39.Image = pictureBox38.Image;
                pictureBox38.Image = b;
            }
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            if (pictureBox40.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
             ;
            }
            if (pictureBox19.Image == aa)
            {
                b = pictureBox40.Image;
                pictureBox40.Image = pictureBox19.Image;
                pictureBox19.Image = b;
            }
            else if (pictureBox41.Image == aa)
            {
                b = pictureBox40.Image;
                pictureBox40.Image = pictureBox41.Image;
                pictureBox41.Image = b;
            }
            else if (pictureBox33.Image == aa)
            {
                b = pictureBox40.Image;
                pictureBox40.Image = pictureBox33.Image;
                pictureBox33.Image = b;
            }
            else if (pictureBox39.Image == aa)
            {
                b = pictureBox40.Image;
                pictureBox40.Image = pictureBox39.Image;
                pictureBox39.Image = b;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (pictureBox19.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox20.Image == aa)
            {
                b = pictureBox19.Image;
                pictureBox19.Image = pictureBox20.Image;
                pictureBox20.Image = b;
            }
            else if (pictureBox26.Image == aa)
            {
                b = pictureBox19.Image;
                pictureBox19.Image = pictureBox26.Image;
                pictureBox26.Image = b;
            }
            else if (pictureBox40.Image == aa)
            {
                b = pictureBox19.Image;
                pictureBox19.Image = pictureBox40.Image;
                pictureBox40.Image = b;
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
            if (pictureBox25.Image == aa)
            {
                b = pictureBox18.Image;
                pictureBox18.Image = pictureBox25.Image;
                pictureBox25.Image = b;
            }
            else if (pictureBox19.Image == aa)
            {
                b = pictureBox18.Image;
                pictureBox18.Image = pictureBox19.Image;
                pictureBox19.Image = b;
            }
            else if (pictureBox39.Image == aa)
            {
                b = pictureBox18.Image;
                pictureBox18.Image = pictureBox39.Image;
                pictureBox39.Image = b;
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
            if (pictureBox24.Image == aa)
            {
                b = pictureBox17.Image;
                pictureBox17.Image = pictureBox24.Image;
                pictureBox24.Image = b;
            }
            else if (pictureBox18.Image == aa)
            {
                b = pictureBox17.Image;
                pictureBox17.Image = pictureBox18.Image;
                pictureBox18.Image = b;
            }
            else if (pictureBox38.Image == aa)
            {
                b = pictureBox17.Image;
                pictureBox17.Image = pictureBox38.Image;
                pictureBox38.Image = b;
            }
            else if (pictureBox16.Image == aa)
            {
                b = pictureBox17.Image;
                pictureBox17.Image = pictureBox16.Image;
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
            if (pictureBox23.Image == aa)
            {
                b = pictureBox16.Image;
                pictureBox16.Image = pictureBox23.Image;
                pictureBox23.Image = b;
            }
            else if (pictureBox17.Image == aa)
            {
                b = pictureBox16.Image;
                pictureBox16.Image = pictureBox17.Image;
                pictureBox17.Image = b;
            }
            else if (pictureBox37.Image == aa)
            {
                b = pictureBox16.Image;
                pictureBox16.Image = pictureBox37.Image;
                pictureBox37.Image = b;
            }
            else if (pictureBox15.Image == aa)
            {
                b = pictureBox16.Image;
                pictureBox16.Image = pictureBox15.Image;
                pictureBox15.Image = b;
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (pictureBox23.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
                
            }
            if (pictureBox9.Image == aa)
            {
                b = pictureBox23.Image;
                pictureBox23.Image = pictureBox9.Image;
                pictureBox9.Image = b;
            }
            else if (pictureBox24.Image == aa)
            {
                b = pictureBox23.Image;
                pictureBox23.Image = pictureBox24.Image;
                pictureBox24.Image = b;
            }
            else if (pictureBox16.Image == aa)
            {
                b = pictureBox23.Image;
                pictureBox23.Image = pictureBox16.Image;
                pictureBox16.Image = b;
            }
            else if (pictureBox22.Image == aa)
            {
                b = pictureBox23.Image;
                pictureBox23.Image = pictureBox22.Image;
                pictureBox22.Image = b;
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (pictureBox24.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
             
            }
            if (pictureBox10.Image == aa)
            {
                b = pictureBox24.Image;
                pictureBox24.Image = pictureBox10.Image;
                pictureBox10.Image = b;
            }
            else if (pictureBox25.Image == aa)
            {
                b = pictureBox24.Image;
                pictureBox24.Image = pictureBox25.Image;
                pictureBox25.Image = b;
            }
            else if (pictureBox17.Image == aa)
            {
                b = pictureBox24.Image;
                pictureBox24.Image = pictureBox17.Image;
                pictureBox17.Image = b;
            }
            else if (pictureBox23.Image == aa)
            {
                b = pictureBox24.Image;
                pictureBox24.Image = pictureBox23.Image;
                pictureBox23.Image = b;
            }
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (pictureBox25.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
              
            }
            if (pictureBox11.Image == aa)
            {
                b = pictureBox25.Image;
                pictureBox25.Image = pictureBox11.Image;
                pictureBox11.Image = b;
            }
            else if (pictureBox26.Image == aa)
            {
                b = pictureBox25.Image;
                pictureBox25.Image = pictureBox26.Image;
                pictureBox26.Image = b;
            }
            else if (pictureBox18.Image == aa)
            {
                b = pictureBox25.Image;
                pictureBox25.Image = pictureBox18.Image;
                pictureBox18.Image = b;
            }
            else if (pictureBox24.Image == aa)
            {
                b = pictureBox25.Image;
                pictureBox25.Image = pictureBox24.Image;
                pictureBox24.Image = b;
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (pictureBox26.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
              
            }
            if (pictureBox12.Image == aa)
            {
                b = pictureBox26.Image;
                pictureBox26.Image = pictureBox12.Image;
                pictureBox12.Image = b;
            }
            else if (pictureBox27.Image == aa)
            {
                b = pictureBox26.Image;
                pictureBox26.Image = pictureBox27.Image;
                pictureBox27.Image = b;
            }
            else if (pictureBox19.Image == aa)
            {
                b = pictureBox26.Image;
                pictureBox26.Image = pictureBox19.Image;
                pictureBox19.Image = b;
            }
            else if (pictureBox25.Image == aa)
            {
                b = pictureBox26.Image;
                pictureBox26.Image = pictureBox25.Image;
                pictureBox25.Image = b;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (pictureBox12.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
               
            }
            if (pictureBox4.Image == aa)
            {
                b = pictureBox12.Image;
                pictureBox12.Image = pictureBox4.Image;
                pictureBox4.Image = b;
            }
            else if (pictureBox13.Image == aa)
            {
                b = pictureBox12.Image;
                pictureBox12.Image = pictureBox13.Image;
                pictureBox13.Image = b;
            }
            else if (pictureBox26.Image == aa)
            {
                b = pictureBox12.Image;
                pictureBox12.Image = pictureBox26.Image;
                pictureBox26.Image = b;
            }
            else if (pictureBox11.Image == aa)
            {
                b = pictureBox12.Image;
                pictureBox12.Image = pictureBox11.Image;
                pictureBox11.Image = b;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (pictureBox11.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
            
            }
            if (pictureBox3.Image == aa)
            {
                b = pictureBox11.Image;
                pictureBox11.Image = pictureBox3.Image;
                pictureBox3.Image = b;
            }
            else if (pictureBox12.Image == aa)
            {
                b = pictureBox11.Image;
                pictureBox11.Image = pictureBox12.Image;
                pictureBox12.Image = b;
            }
            else if (pictureBox25.Image == aa)
            {
                b = pictureBox11.Image;
                pictureBox11.Image = pictureBox25.Image;
                pictureBox25.Image = b;
            }
            else if (pictureBox10.Image == aa)
            {
                b = pictureBox11.Image;
                pictureBox11.Image = pictureBox10.Image;
                pictureBox10.Image = b;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
                
            }
            if (pictureBox8.Image == aa)
            {
                b = pictureBox10.Image;
                pictureBox10.Image = pictureBox8.Image;
                pictureBox8.Image = b;
            }
            else if (pictureBox11.Image == aa)
            {
                b = pictureBox10.Image;
                pictureBox10.Image = pictureBox11.Image;
                pictureBox11.Image = b;
            }
            else if (pictureBox24.Image == aa)
            {
                b = pictureBox10.Image;
                pictureBox10.Image = pictureBox24.Image;
                pictureBox24.Image = b;
            }
            else if (pictureBox9.Image == aa)
            {
                b = pictureBox10.Image;
                pictureBox10.Image = pictureBox9.Image;
                pictureBox9.Image = b;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image != aa)
            {
                count++;
                label2.Text = count.ToString();
                
            }
            if (pictureBox7.Image == aa)
            {
                b = pictureBox9.Image;
                pictureBox9.Image = pictureBox7.Image;
                pictureBox7.Image = b;
            }
            else if (pictureBox10.Image == aa)
            {
                b = pictureBox9.Image;
                pictureBox9.Image = pictureBox10.Image;
                pictureBox10.Image = b;
            }
            else if (pictureBox23.Image == aa)
            {
                b = pictureBox9.Image;
                pictureBox9.Image = pictureBox23.Image;
                pictureBox23.Image = b;
            }
            else if (pictureBox5.Image == aa)
            {
                b = pictureBox9.Image;
                pictureBox9.Image = pictureBox5.Image;
                pictureBox5.Image = b;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Do you want to exit", "WARNING", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                LevelsForm aa = new LevelsForm();
                aa.Show();
                this.Close();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.img3;
            pictureBox2.Image = Properties.Resources.img5;
            pictureBox3.Image = Properties.Resources.img6;
            pictureBox4.Image = Properties.Resources.img9;
            pictureBox5.Image = Properties.Resources.img1;
            pictureBox6.Image = Properties.Resources.img2;
            pictureBox7.Image = Properties.Resources.img7;
            pictureBox8.Image = Properties.Resources.img8;
            pictureBox9.Image = Properties.Resources.img4;
            pictureBox10.Image = Properties.Resources.image_part_014;
            pictureBox11.Image = Properties.Resources.image_part_016;
            pictureBox12.Image = Properties.Resources.image_part_018;
            pictureBox13.Image = Properties.Resources.image_part_041;
            pictureBox14.Image = Properties.Resources.image_part_013;
            pictureBox15.Image = Properties.Resources.image_part_015;
            pictureBox16.Image = Properties.Resources.image_part_012;
            pictureBox17.Image = Properties.Resources.image_part_017;
            pictureBox18.Image = Properties.Resources.image_part_019;
            pictureBox19.Image = Properties.Resources.image_part_025;
            pictureBox20.Image = Properties.Resources.image_part_029;
            pictureBox21.Image = Properties.Resources.image_part_020;
            pictureBox22.Image = Properties.Resources.image_part_023;
            pictureBox23.Image = Properties.Resources.image_part_010;
            pictureBox24.Image = Properties.Resources.image_part_022;
            pictureBox25.Image = Properties.Resources.image_part_024;
            pictureBox26.Image = Properties.Resources.image_part_027;
            pictureBox27.Image = Properties.Resources.image_part_026;
            pictureBox28.Image = Properties.Resources.image_part_033;
            pictureBox29.Image = Properties.Resources.image_part_021;
            pictureBox30.Image = Properties.Resources.image_part_028;
            pictureBox31.Image = Properties.Resources.image_part_038;
            pictureBox32.Image = Properties.Resources.image_part_031;
            pictureBox33.Image = Properties.Resources.image_part_035;
            pictureBox34.Image = Properties.Resources.image_part_011;
            pictureBox35.Image = Properties.Resources.image_part_034;
            pictureBox36.Image = Properties.Resources.image_part_032;
            pictureBox37.Image = Properties.Resources.image_part_045;
            pictureBox38.Image = Properties.Resources.image_part_036;
            pictureBox39.Image = Properties.Resources.image_part_030;
            pictureBox40.Image = Properties.Resources.image_part_037;
            pictureBox41.Image = Properties.Resources.image_part_039;
            pictureBox42.Image = Properties.Resources.image_part_040;
            pictureBox49.Image = Properties.Resources.image_part_044;
            pictureBox44.Image = Properties.Resources.image_part_046;
            pictureBox45.Image = Properties.Resources.image_part_042;
            pictureBox46.Image = Properties.Resources.image_part_043;
            pictureBox47.Image = Properties.Resources.image_part_047;
            pictureBox48.Image = Properties.Resources.image_part_048;
            pictureBox43.Image = Properties.Resources.Typeform_Blog_BlackFriday_Cover_AskAwesomely;

            aa = pictureBox43.Image;
            label2.Text = "00";
            label6.Text = "00";
            label5.Text = "00";
            label6.Text = "00";
            sec = 0;
            min = 0;
            hour = 0;
            count = 0;
            timer1.Start();
        }
    }
}
