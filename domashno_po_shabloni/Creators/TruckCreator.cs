using domashno_po_shabloni.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashno_po_shabloni.Creators
{
    public class TruckCreator : IVehicleCreator
    {
        public Vehicle CreateVehicle(string model, int enginePower, decimal dailyPrice)
            => new Truck(model, enginePower, dailyPrice);
    }
}
