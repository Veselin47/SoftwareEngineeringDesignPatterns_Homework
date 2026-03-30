using Abstract_Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Product
{
    public class Bow : IWeapon { public void Use() => Console.WriteLine("🏹 Стреляш с дълък лък!"); }
}
