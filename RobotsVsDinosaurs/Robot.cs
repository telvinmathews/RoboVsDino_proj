﻿using System;
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
        public Weapon type;


        //Conductor (Spawner-initiate-to begain -produce).
        
        public Robot(string name, double health, double powerLevel, Weapon type)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.type = type;
        }

        //Member Methods (what the class does).
    }
}
