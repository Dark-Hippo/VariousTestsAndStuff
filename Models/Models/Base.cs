using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Base : IBase
    {
        private int _hitPoints;
        private int _maxHitPoints;
        private Statistics _stats;

        public int MaxHitPoints
        {
            get { return _maxHitPoints; }
            protected set {
                _maxHitPoints = value;
                _hitPoints = _maxHitPoints;
            }
        }

        public int HitPoints
        {
            get { return _hitPoints; }
            protected set { _hitPoints = value; }
        }

        public int Strength
        {
            get { return _stats.Strength; }
            set { _stats.Strength = value; }
        }

        public int Dexterity
        {
            get { return _stats.Dexterity; }
            set { _stats.Dexterity = value; }
        }
        public int Constitution
        {
            get { return _stats.Constitution; }
            set { _stats.Constitution = value; }
        }
        public int Wisdom
        {
            get { return _stats.Wisdom; }
            set { _stats.Wisdom = value; }
        }
        public int Intelligence
        {
            get { return _stats.Intelligence; }
            set { _stats.Intelligence = value; }
        }
        public int Charisma
        {
            get { return _stats.Charisma; }
            set { _stats.Charisma = value; }
        }
        
        public Statistics Stats
        {
            get { return _stats; }
            private set { _stats = value; }
        }

        public int Heal(int points)
        {
            _hitPoints += points;
            return _hitPoints;
        }

        public int TakeDamage(int damage)
        {
            _hitPoints -= damage;
            return _hitPoints;
        }
    }
}
