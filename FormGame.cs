using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    public partial class FormGame : Form
    {
        ClassGame Class_obj = new ClassGame();
        public FormGame()
        {
            InitializeComponent();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulette.Resources.loadgif.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            img_display.Image = bmp_Object;

            //code to play soundwhen click on Load button  
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Russian_Roulette.Properties.Resources.load);
            Sound_Object.Play();

            Class_obj.load();
            button_spin.Enabled = true;
            button_load.Enabled = false;
        }

        private void button_spin_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulette.Resources.spin.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            img_display.Image = bmp_Object;

            //code to play soundwhen click on spin button  
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Russian_Roulette.Properties.Resources.Gun_Cock);
            Sound_Object.Play();

            MessageBox.Show(Class_obj.spin().ToString());

            button_spin.Enabled = false;
            button_shoot.Enabled = true;
            button_shootaway.Enabled =true;
        }

        private void button_shoot_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulette.Resources.shoot.gif");
            Bitmap bmp_Object = new Bitmap(myStream);
            img_display.Image = bmp_Object;

            //code to play soundwhen click on shoot button  
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Russian_Roulette.Properties.Resources.shoot);
            Sound_Object.Play();

            if (Class_obj.shoot() == 0)
            {
                MessageBox.Show("best of luck for next time");
            }
            else
            {
                MessageBox.Show("empty shoot");
            }
        }

        private void button_shootaway_Click(object sender, EventArgs e)

        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Russian_Roulette.Resources.shoot away.gif");                                                                    
            Bitmap bmp_Object = new Bitmap(myStream);
            img_display.Image = bmp_Object;

            //code to play soundwhen click on shootaway button  
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(Russian_Roulette.Properties.Resources.shootaway);
            Sound_Object.Play();

            if (Class_obj.chance < 2)
            {
                if (Class_obj.shoot() == 0)
                {
                    MessageBox.Show("You won the game");
                    button_shoot.Enabled = false;
                    button_shootaway.Enabled = false;
                }
                else
                {
                    Class_obj.chance++;
                    if (Class_obj.chance == 2)
                    {
                        MessageBox.Show("best of luck for next time");
                        button_shoot.Enabled = false;
                        button_shootaway.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("empty shoot");
                    }
                }
            }
        }

        private void button_playagain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {


































































        }
    }
}
