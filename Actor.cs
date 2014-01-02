using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DNDClone
{
    public class Actor
    {
        private string _name;
        private int _curHealth;
        private int _maxHealth;
        private int _strength;
        private int _wisdom;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int CurrentHealth
        {
            get { return _curHealth; }
            set
            {
                _curHealth = value;
                if (_curHealth > _maxHealth)
                {
                    _curHealth = _maxHealth;
                }
                if (_curHealth <= 0)
                {
                    _curHealth = 0;
                    MessageBox.Show("Something died!");
                }
            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }

        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }

        public int Wisdom
        {
            get { return _wisdom; }
            set { _wisdom = value; }
        }
    }
}
