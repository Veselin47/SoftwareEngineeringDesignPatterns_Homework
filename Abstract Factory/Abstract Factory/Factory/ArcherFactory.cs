using Abstract_Factory.Interface;
using Abstract_Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factory
{
    public class ArcherFactory : IHeroFactory
    {
        public IWeapon CreateWeapon() => new Bow();
        public IArmor CreateArmor() => new LeatherArmor();
        public ISkill CreateSkill() => new DoubleShot();
    }
}
