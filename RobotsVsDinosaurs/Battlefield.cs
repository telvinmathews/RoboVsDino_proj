using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Battlefield
    {
        //Member variables (what class has).
        public Robot robot;
        public Dinosaur dinosaur;


        //Conductor (Spawner-initiate-to begain -produce).

        //Member Methods (what the class does).
        public void ConcludeBattle(Robot robot, Dinosaur dinosaur)
        {
            if (robot.health == 0 || dinosaur.health == 0)
            {
                Console.WriteLine("Game over!");
            }
        }
    }
}
