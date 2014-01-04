using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DNDClone
{
    public partial class Form1 : Form
    {
        public Player p = new Player();
        public Room r = new Room();
        public Monster m = new Monster();
        string stripDefaultText = "Welcome to DND!";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxPlayer.Parent = pictureBoxUIBack;
            pictureBoxPlayer.Location =
            new Point(
                pictureBoxPlayer.Location.X
                - pictureBoxUIBack.Location.X,
                pictureBoxPlayer.Location.Y
                - pictureBoxUIBack.Location.Y);
            pictureBoxMonster.Parent = pictureBoxUIBack;
            pictureBoxMonster.Location =
            new Point(
                pictureBoxMonster.Location.X
                - pictureBoxUIBack.Location.X,
                pictureBoxMonster.Location.Y
                - pictureBoxUIBack.Location.Y);
        }

        private void displayStats()
        {
            string pInfo1 = "";
            string pInfo2 = "";
            string mInfo = "";
            pInfo1 += (p.Name);
            pInfo1 += ("\nLevel: " + p.Level);
            pInfo1 += ("\nXP: " + p.CurrentExp + "/" + p.MaxExp);
            pInfo1 += ("\nHealth: " + p.CurrentHealth + "/" + p.MaxHealth);
            pInfo1 += ("\nStrength: " + p.Strength);
            pInfo1 += ("\nWisdom: " + p.Wisdom);
            pInfo2 += ("Hunger: " + p.CurrentHunger + "/" + p.MaxHunger);
            pInfo2 += ("\nStr Pots: " + p.StrengthPots);
            pInfo2 += ("\nWis Pots: " + p.WisdomPots);
            pInfo2 += ("\nFood: " + p.FoodCount + "\n\n\n");
            labelCharStats1.Text = pInfo1;
            labelCharStats2.Text = pInfo2;
            if (m.CurrentHealth > 0)
            {
                mInfo += (m.Name);
                mInfo += ("\nLevel: " + m.Level);
                mInfo += ("\nXP: " + m.Experience);
                mInfo += ("\nHealth: " + m.CurrentHealth + "/" + m.MaxHealth);
                mInfo += ("\nStrength: " + m.Strength);
                mInfo += ("\nWisdom: " + m.Wisdom);
            }
            else
            {
                mInfo = "";
            }
            labelMonsterInfo.Text = mInfo;
            //Best place to toggle the generate monster button as display stats is called very often.
            //The generate monster button will never be available if the player is in combat.
            //It will also only be available if there is actually a monster to fight in the room.
            if (r.MonsterCount > 0)
            {
                buttonGenerateMonster.Enabled = !buttonAttack.Enabled;
            }
            else
            {
                buttonGenerateMonster.Enabled = false;
            }
            labelFloorDebug.Text = ("INFO:\nMonsters: " + r.MonsterCount + "\nStrength Potions: " + r.StrengthCount + "\nWisdom Potions: " + r.WisdomCount + "\nFood Count: " + r.FoodCount + "\nLight Value: " + r.Light + "\nRoom Count: " + r.RoomCount);
            labelCharStats2.Location = new Point(labelCharStats1.Location.X + labelCharStats1.Size.Width, labelCharStats2.Location.Y);
        }

        #region Monster Generation
        private void buttonGenerateMonster_Click(object sender, EventArgs e)
        {
            if (r.MonsterCount > 0)
            {
                m.GenerateNewMonster(p.Level);
                ToggleButtons(false);
            }
            displayStats();
        }

        private void buttonTest_MouseEnter(object sender, EventArgs e)
        {
            statusLabel.Text = "Generates a new monster";
        }

        private void buttonTest_MouseLeave(object sender, EventArgs e)
        {
            statusLabel.Text = stripDefaultText;
        }
        #endregion

        #region ToolStripMenu
        private void toolStripNewGame_Click(object sender, EventArgs e)
        {
            SaveGame();
            //Disable movement buttons to prevent unintended input
            ToggleButtons(false);
            //Reset the player's stats before the a name is given to it, otherwise new name will be blank
            p = new Player();
            Form2 dialog = new Form2();
            //Setting form's start position so it always appears relative to Form 1
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.Location = new Point(
    (this.Location.X + dialog.Width + 20) - (dialog.Width),
    (this.Location.Y + dialog.Height + 20) - (dialog.Height));
            dialog.ShowDialog();
            p.Name = dialog.getText();
            dialog.Dispose();
            ToggleButtons(true);
            toolStripSaveGame.Enabled = true;
            r.RoomCount = 0;
            NewRoom();
            displayStats();
        }

        private void toolStripSaveGame_Click(object sender, EventArgs e)
        {
            SaveGame();
        }

        private void toolStripLoadGame_Click(object sender, EventArgs e)
        {
            //Character currently exists if name is longer than 0 characters
            if (p.Name.Length > 0)
            {
                //Ask player if they'd like to save
                DialogResult result = MessageBox.Show("Would you like to save your current character\nbefore loading another?", "Save?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    SaveGame();
                }
            }
            //Create a new open file dialog menu
            OpenFileDialog fd = new OpenFileDialog();
            //Save files are saved with extension dnd
            fd.Filter = "DND Saves (.dnd)|*.dnd";
            //Set title for the window
            fd.Title = "Select your save file to open.";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                //Read and load character settings
                //Needs proper checking for data once deserialized
                string path = fd.FileName;
                using (StreamReader sr = new StreamReader(path))
                {
                    //Character block
                    string charData = sr.ReadLine();
                    string[] charInput = charData.Split('|');
                    p.Name = charInput[0];
                    p.Level = int.Parse(charInput[1]);
                    p.MaxHealth = int.Parse(charInput[3]);
                    p.CurrentHealth = int.Parse(charInput[2]);
                    p.MaxExp = int.Parse(charInput[5]);
                    p.CurrentExp = int.Parse(charInput[4]);
                    p.CurrentHunger = int.Parse(charInput[6]);
                    p.MaxHunger = int.Parse(charInput[7]);
                    p.Strength = int.Parse(charInput[8]);
                    p.Wisdom = int.Parse(charInput[9]);
                    p.StrengthPots = int.Parse(charInput[10]);
                    p.WisdomPots = int.Parse(charInput[11]);
                    p.FoodCount = int.Parse(charInput[12]);
                    //Monster block
                    string monData = sr.ReadLine();
                    if (monData != "0")
                    {
                        string[] monInput = monData.Split('|');
                        m.Name = monInput[0];
                        m.Level = int.Parse(monInput[1]);
                        m.MaxHealth = int.Parse(monInput[3]);
                        m.CurrentHealth = int.Parse(monInput[2]);
                        m.Experience = int.Parse(monInput[4]);
                        m.Strength = int.Parse(monInput[5]);
                        m.Wisdom = int.Parse(monInput[6]);
                    }
                    //Room block
                    string roomData = sr.ReadLine();
                    string[] roomInput = roomData.Split('|');
                    r.MonsterCount = int.Parse(roomInput[0]);
                    r.StrengthCount = int.Parse(roomInput[1]);
                    r.WisdomCount = int.Parse(roomInput[2]);
                    r.FoodCount = int.Parse(roomInput[3]);
                    r.Light = int.Parse(roomInput[4]);
                    r.RoomCount = int.Parse(roomInput[5]);
                }
                displayStats();
                toolStripSaveGame.Enabled = true;
                ToggleButtons(m.CurrentHealth <= 0);
            }
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            if (p.Name.Length > 0)
            {
                DialogResult save = MessageBox.Show("Would you like to save before you exit?", "Save before quitting?", MessageBoxButtons.YesNo);
                if (save == DialogResult.Yes)
                {
                    SaveGame();
                }
            }
            Application.Exit();
        }

        private void toolStripHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Start a new game by clicking the new game\nbutton under the Game toolstrip.","How to start");
        }

        private void toolStripOptions_Click(object sender, EventArgs e)
        {
            Form3 optionsForm = new Form3();
            optionsForm.StartPosition = FormStartPosition.Manual;
            optionsForm.Location = new Point(
    (this.Location.X + optionsForm.Width + 20) - (optionsForm.Width),
    (this.Location.Y + optionsForm.Height + 20) - (optionsForm.Height));
            optionsForm.Show();
        }
        #endregion

        #region MovementButtons
        private void btnNorth_Click(object sender, EventArgs e)
        {
            NewRoom();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            NewRoom();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            NewRoom();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            NewRoom();
        }

        private void NewRoom()
        {
            r.MakeNextRoom();
            labelFloorText.Text = r.BuildFloorString();
            if (r.RoomCount == 12)
            {
                ToggleButtons(false);
                m.GenerateBoss(p.Level, p.MaxHealth, p.Strength, p.Wisdom);
            }
            displayStats();
        }
        #endregion

        #region PotionButtons
        private void buttonStrPot_Click(object sender, EventArgs e)
        {
            if (p.StrengthPots > 0)
            {
                p.StrengthPots--;
                p.Strength++;
                displayStats();
            }
        }

        private void buttonWisPot_Click(object sender, EventArgs e)
        {
            if (p.WisdomPots > 0)
            {
                p.WisdomPots--;
                p.Wisdom++;
                displayStats();
            }
        }

        private void buttonEatFood_Click(object sender, EventArgs e)
        {
            if (p.FoodCount > 0)
            {
                p.FoodCount--;
                p.CurrentHunger += 15;
                p.CurrentHealth += (p.MaxHealth / 10);
                displayStats();
            }
        }
        #endregion

        public void ToggleButtons(bool toggle)
        {
            buttonNorth.Enabled = toggle;
            buttonEast.Enabled = toggle;
            buttonSouth.Enabled = toggle;
            buttonWest.Enabled = toggle;
            buttonSearch.Enabled = toggle;
            buttonGenerateMonster.Enabled = toggle;
            buttonEatFood.Enabled = toggle;
            buttonStrPot.Enabled = toggle;
            buttonWisPot.Enabled = toggle;
            buttonGenerateMonster.Enabled = toggle;
            //We don't want them to be able to move on if they're in combat and we don't want
            //them to be able to attack nothing, so the attack button is set to the opposite
            //of the rest of the buttons
            buttonAttack.Enabled = !toggle;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Random SearchRoll = new Random();
            p.CurrentHunger -= SearchRoll.Next(1, 4);
            int pot = SearchRoll.Next(1, 4);
            int searchValue = ((p.Wisdom * r.Light) / 2);
            if (searchValue > 100)
            {
                searchValue = 100;
            }
            int chance = SearchRoll.Next(1,101);
            MessageBox.Show("Player has value " + searchValue + " and the roll was " + chance);
            if (searchValue >= chance)
            {
                switch (pot)
                {
                    case 1:
                        if(r.StrengthCount > 0)
                        {
                            r.StrengthCount--;
                            p.StrengthPots++;
                        }
                        else if (r.WisdomCount > 0)
                        {
                            r.WisdomCount--;
                            p.WisdomPots++;
                        }
                        else if (r.FoodCount > 0)
                        {
                            r.FoodCount--;
                            p.FoodCount++;
                        }
                        break;
                    case 2:
                        if (r.WisdomCount > 0)
                        {
                            r.WisdomCount--;
                            p.WisdomPots++;
                        }
                        else if(r.StrengthCount > 0)
                        {
                            r.StrengthCount--;
                            p.StrengthPots++;
                        }
                        else if (r.FoodCount > 0)
                        {
                            r.FoodCount--;
                            p.FoodCount++;
                        }
                        break;
                    case 3:
                        if (r.FoodCount > 0)
                        {
                            r.FoodCount--;
                            p.FoodCount++;
                        }
                        else if (r.WisdomCount > 0)
                        {
                            r.WisdomCount--;
                            p.WisdomPots++;
                        }
                        else if (r.StrengthCount > 0)
                        {
                            r.StrengthCount--;
                            p.StrengthPots++;
                        }
                        break;
                    default:
                        MessageBox.Show("An unexpected result for potion was generated.");
                        break;
                }
                MessageBox.Show("Result of the roll was " + pot);
            }
            displayStats();
        }

        #region Saving
        private void SaveGame()
        {
            //Will probably replace with XML serialization later
            //For now basic StreamWriter will do
            string path = Environment.CurrentDirectory + @"\" + p.Name + ".dnd";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(p.Name + "|" + p.Level + "|" + p.CurrentHealth + "|" + p.MaxHealth + "|" + p.CurrentExp + "|" + p.MaxExp + "|" + p.CurrentHunger + "|" + p.MaxHunger + "|" + p.Strength + "|" + p.Wisdom + "|" + p.StrengthPots + "|" + p.WisdomPots + "|" + p.FoodCount);
                if (m.CurrentHealth > 0)
                {
                    sw.WriteLine(m.Name + "|" + m.Level + "|" + m.CurrentHealth + "|" + m.MaxHealth + "|" + m.Experience + "|" + m.Strength + "|" + m.Wisdom);
                }
                else
                {
                    sw.WriteLine("0");
                }
                sw.WriteLine(r.MonsterCount + "|" + r.StrengthCount + "|" + r.WisdomCount + "|" + r.FoodCount + "|" + r.Light + "|" + r.RoomCount);
            }
        }
        #endregion

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            Random CombatDice = new Random();
            int playerCBValue = p.Level + p.Strength;
            int monsterCBValue = m.Level + m.Strength;
            if (p.Level >= m.Level)
            {
                m.CurrentHealth -= CombatDice.Next(playerCBValue - 2, playerCBValue + 7);
                if (m.CurrentHealth > 0)
                {
                    p.CurrentHealth -= CombatDice.Next(monsterCBValue - 6, monsterCBValue + 2);
                    if (p.CurrentHealth <= 0)
                    {
                        labelFloorText.Text = "You were slain in your quest to defeat Engor, your hero has died. Start again by selecting New Game.";
                        ToggleButtons(false);
                        buttonAttack.Enabled = false;
                        toolStripSaveGame.Enabled = false;
                        string path = Environment.CurrentDirectory + @"\" + p.Name + ".dnd";
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                    }
                }
                else
                {
                    p.CurrentExp += m.Experience;
                    r.MonsterCount--;
                    ToggleButtons(true);
                    if (r.RoomCount == 12)
                    {
                        //Player has won the game, congratulate them
                        FinishGame();
                    }
                }
            }
            else
            {
                p.CurrentHealth -= CombatDice.Next(monsterCBValue - 6, monsterCBValue + 2);
                if (p.CurrentHealth > 0)
                {
                    m.CurrentHealth -= CombatDice.Next(playerCBValue - 2, playerCBValue + 7);
                    if (m.CurrentHealth <= 0)
                    {
                        p.CurrentExp += m.Experience;
                        r.MonsterCount--;
                        ToggleButtons(true);
                        if (r.RoomCount == 12)
                        {
                            //Player has won the game, congratulate them
                            FinishGame();
                        }
                    }
                }
                else
                {
                    labelFloorText.Text = "You were slain in your quest to defeat Engor, your hero has died. Start again by selecting New Game.";
                    ToggleButtons(false);
                    buttonAttack.Enabled = false;
                    toolStripSaveGame.Enabled = false;
                    string path = Environment.CurrentDirectory + @"\" + p.Name + ".dnd";
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
            }
            displayStats();
        }

        void FinishGame()
        {
            ToggleButtons(false);
            buttonAttack.Enabled = false;
            labelFloorText.Text = "Congratulations, you killed the boss!";
            this.toolStripSaveGame.Enabled = false;
            string path = Environment.CurrentDirectory + @"\" + p.Name + ".dnd";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}