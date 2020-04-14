using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Weapon
    {
        //Member variables (what class has).
        //public string[] weaponArray = { "Ion blaster", "Stinger blaster", "Interceptor" };
        public double attackPower;
        public string type;

        //Conductor (Spawner-initiate-to begain -produce).

        public Weapon(string type, double attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
        }

        //Member Methods (what the class does).

        
    }
}
