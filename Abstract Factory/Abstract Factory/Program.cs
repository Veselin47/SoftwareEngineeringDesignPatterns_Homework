using Abstract_Factory.Factory;
using Abstract_Factory.Interface;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- RPG ГЕРОЙ ГЕНЕРАТОР ---");
            Console.WriteLine("Избери клас: [1] Воин, [2] Магьосник, [3] Стрелец");

            string choice = Console.ReadLine();
            IHeroFactory factory = choice switch
            {
                "1" => new WarriorFactory(),
                "2" => new MageFactory(),
                "3" => new ArcherFactory(),
                _ => null
            };

            if (factory == null)
            {
                Console.WriteLine("Невалиден избор.");
                return;
            }

           
            IWeapon weapon = factory.CreateWeapon();
            IArmor armor = factory.CreateArmor();
            ISkill skill = factory.CreateSkill();

            Console.WriteLine("\n--- Твоят герой е готов! ---");
            armor.Equip();
            weapon.Use();
            skill.Cast();

            Console.WriteLine("\nНатисни клавиш за изход...");
            Console.ReadKey();
        }
    }
}
