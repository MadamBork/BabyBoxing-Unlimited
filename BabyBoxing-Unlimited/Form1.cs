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

namespace BabyBoxing_Unlimited
{
    public partial class Form1 : Form
    {
        
        //setup variables
        int gameState = 0; //0 = titlescreen
        
        //setup sounds
        SoundPlayer MenuConfirmSound = new SoundPlayer(Properties.Resources.menuConfirm);
        SoundPlayer BattleTheme1 = new SoundPlayer(Properties.Resources.push_and_shove);
        int battleTheme1Playing = 0;


        public Form1()
        {
            InitializeComponent();

            PlayerBaby[] playerBaby = new PlayerBaby[1]; //PlayerBaby[1] - makes ONE baby
            playerBaby[0] = new PlayerBaby();

            playerBaby[0].name = "TestBaby"; //writes info of playerBaby with ID 0 (NOT slotID!!!)
            debugLabel1.Text = playerBaby[0].name; //retrieves name variable of playerBaby with ID 0

        }

        

        


        private void debugLabel1_Click(object sender, EventArgs e)
        {

        }


        public void Form1_KeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (gameState)
            {
                case 0: //titlescreen

                    if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
                    {
                        //play menu sound
                        MenuConfirmSound.Play();
                        timerTitlescreenEnter.Start();

                    }

                    break;
                    
                case 1: //main menu
                    break;
            }

        }


        public void tick(object sender, EventArgs e)
        {
            switch(gameState)
            {
                case 0: //titlescreen
                    debugLabel1.Text = "Game State 0";
                    break;

                case 1: //main menu
                    debugLabel1.Text = "Game State 1";
                    
                    if (battleTheme1Playing == 0)
                    {
                        BattleTheme1.PlayLooping();
                        battleTheme1Playing = 1;
                    }
                    
                  

                    break;
            }
        }

        private void timerTitlescreenEnter_Tick(object sender, EventArgs e)
        {
            gameState = 1;
            timerTitlescreenEnter.Stop();
        }

        
    }
}
