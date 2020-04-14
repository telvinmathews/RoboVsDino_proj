using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Robot
    {
        //Member variables (what class has).

        public string name;
        public double health;
        public double powerLevel;
        public Weapon robotWeapon;
        public double primeAttack;
        public double beeAttack;
        public double smokeAttack;



        //Conductor (Spawner-initiate-to begain -produce).

        public Robot(string name, double health, double powerLevel, Weapon robotWeapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.robotWeapon = robotWeapon;
        }

        //Member Methods (what the class does).
        //pass in robot objects.

        public void RobotAttackDino(Robot prime, Robot bee, Robot smoke, Dinosaur dino, Dinosaur barney, Dinosaur gronk, Weapon primeWeapon, Weapon smokesWeapon, Weapon bumbleBeeWeapon)
        {
            // make a variable that contains each robot attack.
            primeAttack = primeWeapon.attackPower;
            smokeAttack = smokesWeapon.attackPower;
            beeAttack = bumbleBeeWeapon.attackPower;
            // the user should be able to determine what robot attacks what dinosaur.
            //when a robot attacks i want the dinosaur it is attacking to lose health.

            //when a robot attacks i want the robot powerlevel to decrease.
        }



    }
}
