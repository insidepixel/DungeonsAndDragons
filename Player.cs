using System;
using System.Windows.Forms; //Needed for debug message boxes only

namespace DNDClone
{
    public class Player : Actor
    {
        private int _level;
        private int _curExp;
        private int _maxExp;
        private int _curHunger;
        private int _maxHunger;
        private int _strPotCount;
        private int _wisPotCount;
        private int _foodCount;

        public Player()
        {
            this.Name = "";
            this.Level = 1;
            this.MaxHealth = 100;
            this.CurrentHealth= 100;
            this.CurrentExp = 0;
            this.MaxExp = 100;
            this.MaxHunger = 100;
            this.CurrentHunger = 100;
            this.Strength = 10;
            this.Wisdom = 10;
            this.StrengthPots = 0;
            this.WisdomPots = 0;
        }

        public int Level
        {
            get { return _level; }
            set 
            {
                _level = value;
                //Check experience needed in case the character levels up by drinking a potion of mastery, which levels them up once and gives no xp
                if (_curExp >= _maxExp)
                {
                    _curExp -= _maxExp;
                    _maxExp = (100 + (50 * (_level - 1)));
                    //Character still has enough experience to level up again, time to restart the process
                    if (_curExp >= _maxExp)
                    {
                        _level++;
                    }
                }
                //Failsafe in case character's experience is set below 0 for some reason
                if (_curExp < 0)
                {
                    MessageBox.Show("The character's experience was set below 0 by something.");
                    _curExp = 0;
                }
                _maxExp = (100 + (50 * (_level - 1)));
                this.MaxHealth = (100 + (50 * (_level - 1)));
                this.CurrentHealth = this.MaxHealth;
            }
        }

        public int CurrentExp
        {
            get { return _curExp; }
            set 
            { 
                _curExp = value;
                if (_curExp >= _maxExp)
                {
                    this.Level++;
                }
            }
        }

        public int MaxExp
        {
            get { return _maxExp; }
            set { _maxExp = value; }
        }

        public int CurrentHunger
        {
            get { return _curHunger; }
            set 
            {
                _curHunger = value;
                if (_curHunger > _maxHunger)
                {
                    _curHunger = _maxHunger;
                }
                if (_curHunger <= 0)
                {
                    _curHunger = 0;
                    Random HealthLoss = new Random();
                    this.CurrentHealth -= HealthLoss.Next(1,3);
                }
            }
        }

        public int MaxHunger
        {
            get { return _maxHunger; }
            set { _maxHunger = value; }
        }

        public int StrengthPots
        {
            get { return _strPotCount; }
            set { _strPotCount = value; }
        }

        public int WisdomPots
        {
            get { return _wisPotCount; }
            set { _wisPotCount = value; }
        }

        public int FoodCount
        {
            get { return _foodCount; }
            set { _foodCount = value; }
        }
    }
}