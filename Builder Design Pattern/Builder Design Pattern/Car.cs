using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    public class Car
    {
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public bool HasNavigation { get; private set; }

        internal Car() { }

        internal void SetBrand(string brand) => Brand = brand;
        internal void SetModel(string model) => Model = model;
        internal void SetYear(int year) => Year = year;
        internal void SetColor(string color) => Color = color;
        internal void SetNavigation(bool hasNavigation) => HasNavigation = hasNavigation;
    }
}
