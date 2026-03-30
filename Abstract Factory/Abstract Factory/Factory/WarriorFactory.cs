using Abstract_Factory.Interface;
using Abstract_Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Factory
{
    public class WarriorFactory : IHeroFactory
    {
        public IWeapon CreateWeapon() => new Sword();
        public IArmor CreateArmor() => new PlateArmor();
        public ISkill CreateSkill() => new Bash();
    }
}
