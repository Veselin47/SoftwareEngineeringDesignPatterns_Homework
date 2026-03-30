using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Interface
{
    public interface IHeroFactory
    {
        IWeapon CreateWeapon();
        IArmor CreateArmor();
        ISkill CreateSkill();
    }
}
