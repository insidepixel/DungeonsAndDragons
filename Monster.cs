using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DNDClone
{
    public class Monster : Actor
    {
        private int _level;
        private int _exp;

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int Experience
        {
            get { return _exp; }
            set { _exp = value; }
        }

        public void GenerateNewMonster(int playerLevel)
        {
            //50% mod seemed a bit harsh, especially if the player encounters a level 2 monster
            //as their very first fight, they're pretty much doomed to die
            //25% mod is a bit more realistic
            float diffMod;
            switch (Properties.Settings.Default.Difficulty)
            {
                case 1:
                    diffMod = 0.75F;
                    break;
                case 2:
                    diffMod = 1.0F;
                    break;
                case 3:
                    diffMod = 1.25F;
                    break;
                default:
                    //Difficulty has been set to an unintended value, set it back to default
                    diffMod = 1.0F;
                    break;
            }
            MessageBox.Show(diffMod.ToString());
            Random monsterStats = new Random();
            this.Level = monsterStats.Next(playerLevel-1, playerLevel+2);
            if (this.Level <= 0)
            {
                this.Level = 1;
            }
            switch (this.Level)
            {
                case 1:
                case 2:
                    this.Name = "Rat";
                    break;
                case 3:
                case 4:
                    this.Name = "Skeleton";
                    break;
                case 5:
                case 6:
                    this.Name = "Hobgoblin";
                    break;
                default:
                    this.Name = "Minotaur";
                    break;
            }
            this.MaxHealth = (int)(monsterStats.Next(this.Level * 25, this.Level * 35) * diffMod);
            this.CurrentHealth = this.MaxHealth;
            this.Experience = (int)(monsterStats.Next(this.Level * 20, this.Level * 30) * diffMod);
            this.Strength = (int)(monsterStats.Next(this.Level + 10, this.Level + 13) * diffMod);
            this.Wisdom = (int)(monsterStats.Next(this.Level + 10, this.Level + 13) * diffMod);
        }

        public void GenerateBoss(int pLevel, int pMaxHealth, int pStrength, int pWisdom)
        {
            this.Name = "Engor";
            this.Level = pLevel;
            this.Experience = 1337;
            this.MaxHealth = pMaxHealth;
            this.CurrentHealth = pMaxHealth;
            this.Strength = pStrength;
            this.Wisdom = pWisdom;
        }
    }
}