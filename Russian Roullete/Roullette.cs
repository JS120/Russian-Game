using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roullete
{
    public partial class Roullette : Form
    {
        public Roullette()
        {
            InitializeComponent();
        }
        // class are being called over here
        gameclass russian = new gameclass();
        Random spin = new Random();
        // to give a sound to spinn button i added sound here
        SoundPlayer sound= new SoundPlayer(Russian_Roullete.Properties.Resources.spinnn);
       

       

        private void game_Load(object sender, EventArgs e)
        {

        }

        private void retry(object sender, EventArgs e)
        {
            // message box
            MessageBox.Show("Re-match");
            // to re run
            (new Roullette()).Show();
            this.Hide();
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            // sound ready to be played
            
            sound.Play();
            russian.loadchamber = spin.Next(1, 6);

            bullet_shoot.Enabled = true;

            bullet_spin.Enabled = false;

            // message box
            MessageBox.Show("Spinned");
        }

        private void load_Click(object sender, EventArgs e)
        {
            russian.Loaded = 1;
            bullet_spin.Enabled = true;
            bullet_load.Enabled = false;

            MessageBox.Show("Bullet load");
        }

        private void Shoot_Click(object sender, EventArgs e)
        {

            int win = 0;
            win = russian.Fired
                ();

            if (win == 1)
            {
               
                MessageBox.Show("You loose");

                bullet_load.Enabled = false;
                bullet_shoot.Enabled = false;
                bullet_spin.Enabled = false;





            }
            else if (win == 2)
            {

                // message box
                MessageBox.Show("Bullet Missed");

            }

        }

        private void Exit_Click(object sender, EventArgs e)
        {

            // for closing the game
            Close();
        }
    }
    }

