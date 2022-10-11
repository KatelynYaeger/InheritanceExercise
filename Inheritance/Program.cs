using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal - Done
            // give this class 4 members that all Animals have in common - Done


            // Create a class Bird - Done
            // give this class 4 members that are specific to Bird - Done
            // Set this class to inherit from your Animal Class - Done

            // Create a class Reptile - done 
            // give this class 4 members that are specific to Reptile - Done
            // Set this class to inherit from your Animal Class - done



            /*Create an object of your Bird class - Done
             *  give values to your members using the object of your Bird class - Done
             *  
             * Creatively display the class member values Done 
             */

            var myBird = new Bird();
            myBird.Age = 2;
            myBird.BeakLength = 1.2;
            myBird.BirdSong = "Trill";
            myBird.CanFly = true;
            myBird.IsAlive = true;
            myBird.LandSeaAir = "Air";
            myBird.NumberofLegs = 2;
            myBird.WingColor = "blue";



            /*Create an object of your Reptile class - Done
             *  give values to your members using the object of your Reptile class - Done
             *  
             * Creatively display the class member values - Done
             */
            var mySnake = new Reptile();
            mySnake.Age = 34;
            mySnake.Habitat = "Under brush";
            mySnake.HaveLegs = false;
            mySnake.IsAlive = true;
            mySnake.LandSeaAir = "Land";
            mySnake.NumberofLegs = 0;
            mySnake.NumberOfTeeth = 2;
            mySnake.TailLength = 5;

            var myAnimals = new Animal[] { myBird, mySnake };

            foreach (var animal in myAnimals)
            {
                
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Lives on: {animal.LandSeaAir}");
                Console.WriteLine($"Has: {animal.NumberofLegs} legs");
                Console.WriteLine("");

            }
        }
    }
}
