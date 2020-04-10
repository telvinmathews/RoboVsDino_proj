using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Weapon primeWeapon = new Weapon(20);
            Robot autoBots = new Robot("Prime", 100, 200, primeWeapon);
        }
    }
}
