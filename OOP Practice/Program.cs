using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog woofy = new Dog (15, 120, 900, 0);
            woofy.RunningSpeed ();

            Dog spot = new Dog();
            spot.RunningSpeed = 25;
            spot.Run();
        }
    }
}
