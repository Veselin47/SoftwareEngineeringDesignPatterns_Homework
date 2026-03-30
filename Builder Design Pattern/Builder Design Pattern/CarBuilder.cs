using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    public class CarBuilder : ICarBuilder
    {
        private readonly Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }

        public ICarBuilder SetBrand(string brand)
        {
            _car.SetBrand(brand);
            return this;
        }

        public ICarBuilder SetModel(string model)
        {
            _car.SetModel(model);
            return this;
        }

        public ICarBuilder SetYear(int year)
        {
            _car.SetYear(year);
            return this;
        }

        public ICarBuilder SetColor(string color)
        {
            _car.SetColor(color);
            return this;
        }

        public ICarBuilder SetNavigation(bool hasNavigation)
        {
            _car.SetNavigation(hasNavigation);
            return this;
        }

        public Car Build()
        {
            Validate();
            return _car;
        }

        private void Validate()
        {
            if (string.IsNullOrWhiteSpace(_car.Brand))
                throw new InvalidOperationException("Brand is required");

            if (string.IsNullOrWhiteSpace(_car.Model))
                throw new InvalidOperationException("Model is required");

            if (_car.Year <= 0)
                throw new InvalidOperationException("Year must be valid");
        }
    }
}
