using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car(int Year, string Make, string Model, string EngineNoise, string HonkNoise, bool is_Driveable = false)
        {
            
            year = Year;
            make = Make;
            model = Model;  
            engineNoise = EngineNoise;
            honkNoise = HonkNoise;
            isDriveable = is_Driveable;
            CarLot.numberOfCars++;
        }

        public int year { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string engineNoise { get; set; }
        public string honkNoise { get; set; }
        public bool isDriveable { get; set; }
        public void MakeEngineNoise()
        {
            Console.WriteLine(engineNoise);
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine(honkNoise);
        }
    }
}
