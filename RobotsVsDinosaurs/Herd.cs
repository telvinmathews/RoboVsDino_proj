using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Herd
    {
        //Member variables (what class has).

       public Dinosaur dino;
       public Dinosaur gronk;
       public Dinosaur barney;

        //Conductor (Spawner-initiate-to begain -produce).

        public Herd()
        {
            dino = new Dinosaur("T-Rex", 200, 200, 50);
            gronk = new Dinosaur("T-Rex", 110, 300, 50);
            barney = new Dinosaur("T-Rex", 400, 100, 10);
        }



        //Member Methods (what the class does).
    }
}
