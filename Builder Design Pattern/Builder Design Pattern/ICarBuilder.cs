using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Design_Pattern
{
    public interface ICarBuilder
    {
        ICarBuilder SetBrand(string brand);
        ICarBuilder SetModel(string model);
        ICarBuilder SetYear(int year);
        ICarBuilder SetColor(string color);
        ICarBuilder SetNavigation(bool hasNavigation);

        Car Build();
    }
}
