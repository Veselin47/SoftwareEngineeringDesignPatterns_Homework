using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domashno_po_shabloni.Extensions;

namespace domashno_po_shabloni.Product
{
    public abstract class Vehicle
    {
        private const int MinPower = 35;
        private const int MaxPower = 2000;
        private const decimal MinPrice = 50;
        private const decimal MaxPrice = 10000;

        private string model;
        private int enginePower;
        private decimal dailyprice;

        protected Vehicle(string model, int enginePower, decimal dailyprice)
        {
            Model = model;
            EnginePower = enginePower;
            DailyPrice = dailyprice;
        }
        public string Model
        {
            get => model;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"The {GetType().Name.SplitPascalCaseString()}'s model cannot be empty!");
                }
                model = value;
            }
        }


            public int EnginePower
        {
            get => enginePower;
            set
            {
                if (value < MinPower || value > MaxPower)
                {
                    throw new ArgumentException($"Engine power must be between {MinPower} and {MaxPower} hp!");
                }
                enginePower = value;
            }
        }

        public decimal DailyPrice
            {
                get => dailyprice;
                set
                {
                    if (value < MinPrice || value > MaxPrice)
                    {
                        throw new ArgumentException($"The {GetType().Name.SplitPascalCaseString()}'s daily price must be between {MinPrice} and {MaxPrice}!");
                    }
                    dailyprice = value;
            }
        } 
        public override string ToString()
        {
            return $"Vehicle Type: {GetType().Name.SplitPascalCaseString()} | Model: {Model} | Power: {EnginePower}hp | Price: {DailyPrice:C}/day";
        }
    }
}

