using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousTestsAndStuff
{
    class Program
    {
        static void Main()
        {

            var dave = CreateCharacter("Dave");
            var orc1 = CreateOrc();
            var goblin1 = CreateGoblin();

            Console.WriteLine($"Character: {dave.Name}\nHP: {dave.MaxHitPoints}");
            Console.WriteLine();
            Console.WriteLine($"Creature: {orc1.CreatureType}\nHP: {orc1.HitPoints}");
            Console.WriteLine();
            Console.WriteLine($"Creature: {goblin1.CreatureType}\nHP: {goblin1.HitPoints}");
            Console.WriteLine();

            orc1.TakeDamage(5);

            Console.WriteLine($"Creature: {orc1.CreatureType}\nHP: {orc1.HitPoints}");



            Console.Read();
        }
        private static Creature CreateGoblin()
        {
            var stats = new Statistics()
            {
                Strength = 10,
                Dexterity = 10,
                Constitution = 8,
                Wisdom = 5,
                Intelligence = 3,
                Charisma = 4
            };

            return new Creature(Models.Enums.CreatureType.Orc, stats);
        }

        private static Creature CreateOrc()
        {
            var stats = new Statistics()
            {
                Strength = 14,
                Dexterity = 10,
                Constitution = 12,
                Wisdom = 7,
                Intelligence = 6,
                Charisma = 5
            };

            return new Creature(Models.Enums.CreatureType.Orc, stats);
        }

        private static Character CreateCharacter(string name)
        {
            var stats = new Statistics()
            {
                Strength = 18,
                Dexterity = 14,
                Constitution = 18,
                Wisdom = 11,
                Intelligence = 10,
                Charisma = 9
            };

            return new Character(name, stats, 20);
        }
    }
}
