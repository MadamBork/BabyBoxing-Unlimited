using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabyBoxing_Unlimited
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            PlayerBaby[] playerBaby = new PlayerBaby[1]; //PlayerBaby[1] - makes ONE baby
            playerBaby[0] = new PlayerBaby();

            playerBaby[0].name = "TestBaby"; //writes info of playerBaby with ID 0 (NOT slotID!!!)
            debugLabel1.Text = playerBaby[0].name; //retrieves name variable of playerBaby with ID 0
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
