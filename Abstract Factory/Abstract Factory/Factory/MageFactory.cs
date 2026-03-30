using Abstract_Factory.Interface;
using Abstract_Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factory
{
    public class MageFactory : IHeroFactory
    {
        public IWeapon CreateWeapon() => new Staff();
        public IArmor CreateArmor() => new MagicRobe();
        public ISkill CreateSkill() => new Fireball();
    }
}
