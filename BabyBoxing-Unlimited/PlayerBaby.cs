using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//use this example for getting classes to work and stuff!!
//https://github.com/ryannaphone/sporb/blob/master/spore/Creature.cs
namespace BabyBoxing_Unlimited
{
    public class PlayerBaby 
    {
        public int slotID;
        public int health;
        public int power;
        public int speed;
        public string name;

        public PlayerBaby()
        {
            slotID = 0;
            health = 100;
            power = 10;
            speed = 5;
            name = "Baby";
        }
    }
}
