using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice {



    class Dog

    {
        //Declare Fields 
        //private int hairlength;
        //private int height;
        //private int speed;
        //private int weight;

        //private bool Run = true;
        //private bool Bark = true;
        //private bool potty = true;
        //private bool cuddle = true;



        //public Dog()
        //{
        //    //default constructor 
        //}
        //public Dog(int hair, int speed, int height, int weight)

        //{
             //
        //    this.hairlength = hair;
        //    this.height = height;
        //    this.speed = speed;
        //    this.weight = weight;
        //}
        //public void Runs()
        //{
        //    if (Run)
        //    {
        //        Run = false;

        //    }

        //    Console.WriteLine("this dog is easy to catch");
        //}
        //public void Barks() {
        //    if (Bark)
        //    {
        //        Bark = false;
        //    }
        //    Console.WriteLine("This dog is silent"); }
        //public void potties() {
        //    if (potty)
        //    {
        //        potty = true;
        //    }
        //    Console.WriteLine("Clean it up"); }

        //public void cuddles()
        //{
        //    if (cuddle)

        //        cuddle = false;

        //    Console.WriteLine("Do not cuddle");

            public int Hairlength
        {

            get { return this.Hairlength; }
            set { this.Hairlength = value; }
        }

        public int Height
            {
            get { return this.Height; }
            set { this.Height = value; }
            

            }
        public int RunningSpeed
        {
            get { return this.RunningSpeed; } 
            set { this.RunningSpeed = value; }

        }
        public int weight
        {
            get { return this.weight; }
            set { this.weight = value; }

        }
        class Dog
        {
            //Declare Fields
            private int hairLength;
            private int height;
            private int runningSpeed;
            private int weight;


            //Declare Properties

            public int HairLength
            {
                get { return this.hairLength; }
                set { this.hairLength = value; }
            }

            public int Height
            {
                get { return this.height; }
                set { this.height = value; }
            }

            public int RunningSpeed
            {
                get { return this.runningSpeed; }
                set { this.runningSpeed = value; }
            }

            public int Weight
            {
                get { return this.weight; }
                set { this.weight = value; }
            }

            public string Name { get; set; }

            //Declare constructors

            public Dog()
            {
                //default const
            }

            public Dog(int runningSpeed, int weight, int height, int hairLength)
            {
                this.runningSpeed = runningSpeed;
                this.weight = weight;
                this.height = height;
                this.hairLength = hairLength;
            }

            public void Run()
            {
                Console.WriteLine("Your dog can run {0} miles per hour", runningSpeed);
            }

            public void FavFood(string[] food)
            {

                Console.WriteLine("{0} favorite foods are: ", Name);
                for (int i = 0; i < food.Length; i++)
                {
                    Console.WriteLine(food[i]);
                }

            }
        }

    }




}
        
       

}



