using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Dinosaur
    {
        //Member variables (what class has).

        public string type;
        public double health;
        public double energy;
        public double attackPower;


        //Conductor (Spawner-initiate-to begain -produce).

        public Dinosaur(string type, double health, double energy, double attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        //Member Methods (what the class does).

        public void DinoAttackRobot(Robot robot, Dinosaur dinosaur)
        {
            robot.health -= dinosaur.attackPower;
            dinosaur.energy -= dinosaur.attackPower;
        }
    }
}
