using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domashno_po_shabloni.Product;
namespace domashno_po_shabloni.Creators
{
    public class MotorcycleCreator : IVehicleCreator
    {
        public Vehicle CreateVehicle(string model, int enginePower, decimal dailyPrice)
        => new Motorcycle(model, enginePower, dailyPrice);
    }
}
