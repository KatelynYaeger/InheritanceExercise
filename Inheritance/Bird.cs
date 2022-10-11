using System;
namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
        }

        public double BeakLength { get; set; }
        public string BirdSong { get; set; }
        public bool CanFly { get; set; }
        public string WingColor{ get; set; }
    }
}

