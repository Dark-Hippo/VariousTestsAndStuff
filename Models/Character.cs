using Models.Interfaces;
using Models.Models;
using System;

namespace Models
{
    public class Character : Base, ICharacter
    {
        #region Properties

        private string _name;
        private int _hitPoints;
        private Statistics _stats;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        #endregion

        public Character(string name)
        {
            this._name = name;
        }

        public Character(string name, Statistics stats)
            :this(name)
        {
            this._stats = stats;
        }

        public Character(string name, Statistics stats, int maxHitPoints)
            :this(name, stats)
        {
            this.MaxHitPoints = maxHitPoints;
        }
    }
}
