using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {
        //Member variables (what class has).
        public Weapon primeWeapon;
        public Weapon bumbleBeeWeapon;
        public Weapon smokesWeapon;
        public Robot autoBot1;
        public Robot autoBot2;
        public Robot autoBot3;

        //Conductor (Spawner-initiate-to begain -produce).
        public Fleet()
        {
            primeWeapon = new Weapon("Ion blaster", 40);
            bumbleBeeWeapon = new Weapon("stinger", 30);
            smokesWeapon = new Weapon("smoke", 70);
            autoBot1 = new Robot("Prime", 200, 100, primeWeapon);
            autoBot2 = new Robot("Smoke", 170, 100, smokesWeapon);
            autoBot3 = new Robot("Bee", 160, 100, bumbleBeeWeapon);
        }

        //Member Methods (what the class does).
    }
}
