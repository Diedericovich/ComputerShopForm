﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerShopForm
{
    internal class Laptop : Computer
    {
        public int ScreenSize { get; set; } //in INCH
        public string ScreenType { get; set; }
        public double WeightInGrams { get; set; }

        public Laptop(string name, double price, string imagepath, string description, int stock, int ram, string mobo, string hdd, string cpu, string psu, int screensize, string screentype, double weightingrams)
           : base(name, price, imagepath, description, stock, ram, mobo, hdd, cpu, psu)
        {
            ScreenSize = screensize;
            ScreenType = screentype;
            WeightInGrams = weightingrams;
        }

        public override string ToString()
        {
            string add = $"Your laptop has a screensize of {ScreenSize} inch.\n A nice {ScreenType} and weighs only {WeightInGrams} grams.";
            return base.ToString() + add;
        }
    }
}