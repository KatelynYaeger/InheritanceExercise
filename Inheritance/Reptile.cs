using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }

        public string Habitat {get; set; }
        public bool HaveLegs { get; set; }
        public double TailLength { get; set; }
        public int NumberOfTeeth { get; set; }

    }
}

