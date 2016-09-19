using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Creature : Base
    {
        private CreatureType _type;
        private Statistics stats;

        public CreatureType CreatureType
        {
            get { return _type; }
            private set { _type = value; }
        }

        public Creature()
        {
            this.MaxHitPoints = 10;
        }

        public Creature(CreatureType creatureType)
            : this()
        {
            this._type = creatureType;
        }

        public Creature(CreatureType creatureType, Statistics stats) 
            : this(creatureType)
        {
            this.stats = stats;
        }
    }
}
