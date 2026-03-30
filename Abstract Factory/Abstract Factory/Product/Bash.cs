using Abstract_Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Product
{
    public class Bash : ISkill 
    {
        public void Cast() => Console.WriteLine("💥 Умение: Силен удар с щит!"); 
    }    
    
}
