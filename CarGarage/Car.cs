using System;
using System.Collections.Generic;
using System.Text;

namespace CarGarage
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }
        public bool AutoBrakeActive { get; set; }

        //Methods

        public void SetMake(string make)
        {
            Make = make;
        }
        
        public void SetModel(string model)
        {
            Model = model;
        }

        public int GetSpeed()
        {
            return Speed;
        }
        
        public bool IsSpeeding()
        {
            if (Speed > 70) { return true; }
            else { return false; }
        }

        public void Accelerate()
        {
            if (Speed >= 100) { Speed += 0; }
            else if (Make == "Ferrari") { Speed += 20; }
            else { Speed += 10; }
        }

        public void Brake()
        {
            Speed -= 7;
        }
    }
}
