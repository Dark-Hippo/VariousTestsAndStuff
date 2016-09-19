using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    interface IBase
    {
        int MaxHitPoints { get; }
        int Strength { get; set; }
        int Dexterity { get; set; }
        int Constitution { get; set; }
        int Wisdom { get; set; }
        int Intelligence { get; set; }
        int Charisma { get; set; }
        Statistics Stats { get; }

        int TakeDamage(int damage);
        int Heal(int points);
    }
}
