using System;

namespace DNDClone
{
    public class Room
    {
        private int _monsterCount;
        private int _strPotCount;
        private int _wisPotCount;
        private int _foodPotCount;
        private int _light;
        private int _roomCount;

        public int MonsterCount
        {
            get { return _monsterCount; }
            set { _monsterCount = value; }
        }

        public int StrengthCount
        {
            get { return _strPotCount; }
            set { _strPotCount = value; }
        }

        public int WisdomCount
        {
            get { return _wisPotCount; }
            set { _wisPotCount = value; }
        }

        public int FoodCount
        {
            get { return _foodPotCount; }
            set { _foodPotCount = value; }
        }

        public int Light
        {
            get { return _light; }
            set { _light = value; }
        }

        public int RoomCount
        {
            get { return _roomCount; }
            set { _roomCount = value; }
        }

        public void MakeNextRoom()
        {
            _roomCount++;
            if (_roomCount < 12)
            {
                Random dice = new Random();
                this.MonsterCount = dice.Next(0, 4);
                this.StrengthCount = dice.Next(0, 4);
                this.WisdomCount = dice.Next(0, 4);
                this.FoodCount = dice.Next(0, 4);
                this.Light = dice.Next(5, 11);
            }
            else
            {
                this.MonsterCount = 1;
                this.StrengthCount = 0;
                this.WisdomCount = 0;
                this.FoodCount = 0;
                this.Light = 0;
            }
        }

        public string BuildFloorString()
        {
            string FloorString = "";
            Random roomText = new Random();
            switch (roomText.Next(1, 5))
            {
                case 1:
                    FloorString += ("You enter the next room. On your way in you see ");
                    break;
                case 2:
                    FloorString += ("You slowly advance through the dark corridor. As you enter the room you notice that ");
                    break;
                case 3:
                    FloorString += ("You sheepishly approach the doorway and enter the next dungeon room. You see that ");
                    break;
                case 4:
                    FloorString += ("You confidently charge through the corridor and on to your next room. You come to a halt to take in your surroundings. You are shocked to find ");
                    break;
                default:
                    FloorString += ("Hurf durf durf derp derr. Herp derf durr ");
                    break;
            }
            switch (this.Light)
            {
                case 5:
                case 6:
                    FloorString += ("the room is poorly lit. You will have a hard time searching this room. ");
                    break;
                case 7:
                case 8:
                    FloorString += ("the room is fairly well lit. It should take minimal effort to find items in this room. ");
                    break;
                case 9:
                case 10:
                    FloorString += ("you can see the entire room in perfect detail. Navigating this room will be child's play. ");
                    break;
                default:
                    FloorString += ("derf durka hurf durr derp. ");
                    break;
            }
            switch (this.MonsterCount)
            {
                case 0:
                    FloorString += ("You listen out for signs of enemies but you hear only silence.");
                    break;
                case 1:
                    FloorString += ("You hear a growl from somewhere in the room. You should prepare for a fight.");
                    break;
                case 2:
                case 3:
                    FloorString += ("You hear the sounds of multiple enemies, this may prove to be a challenge.");
                    break;
                default:
                    FloorString += ("aerthaw4sdtyfhjbr");
                    break;
            }
            return(FloorString);
        }
    }
}