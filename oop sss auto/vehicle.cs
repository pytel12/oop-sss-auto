using System;
using System.Collections.Generic;
using System.Text;

namespace oop_sss_auto
{
    public class vehicle
    {
        public string Type { get; set; }
        public string Brand { get;}
        public string Fuel { get; set; }
        public double Enginevolume { get; set; }
        public int FuelLevel { get; set; }
        public int Distance { get; set; }
        public int PneuState { get; set; }

        public vehicle(string brand)
        {
            Type = "Unknown";
            Brand = Brand;
            Fuel = "Gas";
            Enginevolume = 1000;
            FuelLevel = 100;
            Distance = 0;
            PneuState = 100;

        }


    }   
}
