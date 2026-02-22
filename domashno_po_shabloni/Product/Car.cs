using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashno_po_shabloni.Product
{
    public class Car : Vehicle
    {
        public Car(string model, int enginePower, decimal dailyPrice) : base(model, enginePower, dailyPrice)
        {
        }
    }
    
}
