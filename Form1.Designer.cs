namespace DNDClone
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelFloorText = new System.Windows.Forms.Label();
            this.labelCharStats1 = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonLoadGame = new System.Windows.Forms.Button();
            this.buttonGenerateMonster = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripGame = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSaveGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLoadGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOptions = new System.Windows.Forms.ToolStripButton();
            this.buttonNorth = new System.Windows.Forms.Button();
            this.buttonWest = new System.Windows.Forms.Button();
            this.buttonSouth = new System.Windows.Forms.Button();
            this.buttonEast = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonStrPot = new System.Windows.Forms.Button();
            this.buttonWisPot = new System.Windows.Forms.Button();
            this.labelMonsterInfo = new System.Windows.Forms.Label();
            this.buttonEatFood = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.pictureBoxDungeonPic = new System.Windows.Forms.PictureBox();
            this.pictureBoxUIBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.labelCharStats2 = new System.Windows.Forms.Label();
            this.pictureBoxMonster = new System.Windows.Forms.PictureBox();
            this.labelFloorDebug = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDungeonPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUIBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFloorText
            // 
            this.labelFloorText.BackColor = System.Drawing.Color.Black;
            this.labelFloorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFloorText.ForeColor = System.Drawing.Color.White;
            this.labelFloorText.Location = new System.Drawing.Point(0, 25);
            this.labelFloorText.Name = "labelFloorText";
            this.labelFloorText.Size = new System.Drawing.Size(462, 400);
            this.labelFloorText.TabIndex = 0;
            // 
            // labelCharStats1
            // 
            this.labelCharStats1.AutoSize = true;
            this.labelCharStats1.BackColor = System.Drawing.Color.Transparent;
            this.labelCharStats1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharStats1.Location = new System.Drawing.Point(110, 445);
            this.labelCharStats1.Name = "labelCharStats1";
            this.labelCharStats1.Size = new System.Drawing.Size(0, 20);
            this.labelCharStats1.TabIndex = 1;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(0, 0);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGame.TabIndex = 7;
            // 
            // buttonLoadGame
            // 
            this.buttonLoadGame.Location = new System.Drawing.Point(0, 0);
            this.buttonLoadGame.Name = "buttonLoadGame";
            this.buttonLoadGame.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadGame.TabIndex = 6;
            // 
            // buttonGenerateMonster
            // 
            this.buttonGenerateMonster.Location = new System.Drawing.Point(604, 476);
            this.buttonGenerateMonster.Name = "buttonGenerateMonster";
            this.buttonGenerateMonster.Size = new System.Drawing.Size(100, 25);
            this.buttonGenerateMonster.TabIndex = 4;
            this.buttonGenerateMonster.Text = "Fight Monster";
            this.buttonGenerateMonster.UseVisualStyleBackColor = true;
            this.buttonGenerateMonster.Click += new System.EventHandler(this.buttonGenerateMonster_Click);
            this.buttonGenerateMonster.MouseEnter += new System.EventHandler(this.buttonTest_MouseEnter);
            this.buttonGenerateMonster.MouseLeave += new System.EventHandler(this.buttonTest_MouseLeave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGame,
            this.toolStripOptions});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1050, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripGame
            // 
            this.toolStripGame.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewGame,
            this.toolStripSaveGame,
            this.toolStripLoadGame,
            this.toolStripHelp,
            this.toolStripExit});
            this.toolStripGame.Image = ((System.Drawing.Image)(resources.GetObject("toolStripGame.Image")));
            this.toolStripGame.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripGame.Name = "toolStripGame";
            this.toolStripGame.Size = new System.Drawing.Size(51, 22);
            this.toolStripGame.Text = "Game";
            // 
            // toolStripNewGame
            // 
            this.toolStripNewGame.Name = "toolStripNewGame";
            this.toolStripNewGame.Size = new System.Drawing.Size(134, 22);
            this.toolStripNewGame.Text = "New Game";
            this.toolStripNewGame.Click += new System.EventHandler(this.toolStripNewGame_Click);
            // 
            // toolStripSaveGame
            // 
            this.toolStripSaveGame.Enabled = false;
            this.toolStripSaveGame.Name = "toolStripSaveGame";
            this.toolStripSaveGame.Size = new System.Drawing.Size(134, 22);
            this.toolStripSaveGame.Text = "Save Game";
            this.toolStripSaveGame.Click += new System.EventHandler(this.toolStripSaveGame_Click);
            // 
            // toolStripLoadGame
            // 
            this.toolStripLoadGame.Name = "toolStripLoadGame";
            this.toolStripLoadGame.Size = new System.Drawing.Size(134, 22);
            this.toolStripLoadGame.Text = "Load Game";
            this.toolStripLoadGame.Click += new System.EventHandler(this.toolStripLoadGame_Click);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(134, 22);
            this.toolStripHelp.Text = "Help";
            this.toolStripHelp.Click += new System.EventHandler(this.toolStripHelp_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(134, 22);
            this.toolStripExit.Text = "Exit";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // toolStripOptions
            // 
            this.toolStripOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOptions.Image")));
            this.toolStripOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOptions.Name = "toolStripOptions";
            this.toolStripOptions.Size = new System.Drawing.Size(53, 22);
            this.toolStripOptions.Text = "Options";
            this.toolStripOptions.Click += new System.EventHandler(this.toolStripOptions_Click);
            // 
            // buttonNorth
            // 
            this.buttonNorth.Enabled = false;
            this.buttonNorth.Location = new System.Drawing.Point(420, 448);
            this.buttonNorth.Name = "buttonNorth";
            this.buttonNorth.Size = new System.Drawing.Size(30, 40);
            this.buttonNorth.TabIndex = 8;
            this.buttonNorth.Text = "N";
            this.buttonNorth.UseVisualStyleBackColor = true;
            this.buttonNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // buttonWest
            // 
            this.buttonWest.Enabled = false;
            this.buttonWest.Location = new System.Drawing.Point(380, 488);
            this.buttonWest.Name = "buttonWest";
            this.buttonWest.Size = new System.Drawing.Size(40, 30);
            this.buttonWest.TabIndex = 9;
            this.buttonWest.Text = "W";
            this.buttonWest.UseVisualStyleBackColor = true;
            this.buttonWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // buttonSouth
            // 
            this.buttonSouth.Enabled = false;
            this.buttonSouth.Location = new System.Drawing.Point(420, 518);
            this.buttonSouth.Name = "buttonSouth";
            this.buttonSouth.Size = new System.Drawing.Size(30, 40);
            this.buttonSouth.TabIndex = 10;
            this.buttonSouth.Text = "S";
            this.buttonSouth.UseVisualStyleBackColor = true;
            this.buttonSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // buttonEast
            // 
            this.buttonEast.Enabled = false;
            this.buttonEast.Location = new System.Drawing.Point(450, 488);
            this.buttonEast.Name = "buttonEast";
            this.buttonEast.Size = new System.Drawing.Size(40, 30);
            this.buttonEast.TabIndex = 11;
            this.buttonEast.Text = "E";
            this.buttonEast.UseVisualStyleBackColor = true;
            this.buttonEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(498, 445);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 25);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Search Room";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonStrPot
            // 
            this.buttonStrPot.Location = new System.Drawing.Point(498, 476);
            this.buttonStrPot.Name = "buttonStrPot";
            this.buttonStrPot.Size = new System.Drawing.Size(100, 25);
            this.buttonStrPot.TabIndex = 14;
            this.buttonStrPot.Text = "Drink Str Pot";
            this.buttonStrPot.UseVisualStyleBackColor = true;
            this.buttonStrPot.Click += new System.EventHandler(this.buttonStrPot_Click);
            // 
            // buttonWisPot
            // 
            this.buttonWisPot.Location = new System.Drawing.Point(498, 509);
            this.buttonWisPot.Name = "buttonWisPot";
            this.buttonWisPot.Size = new System.Drawing.Size(100, 25);
            this.buttonWisPot.TabIndex = 15;
            this.buttonWisPot.Text = "Drink Wis Pot";
            this.buttonWisPot.UseVisualStyleBackColor = true;
            this.buttonWisPot.Click += new System.EventHandler(this.buttonWisPot_Click);
            // 
            // labelMonsterInfo
            // 
            this.labelMonsterInfo.AutoSize = true;
            this.labelMonsterInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelMonsterInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonsterInfo.Location = new System.Drawing.Point(744, 440);
            this.labelMonsterInfo.Name = "labelMonsterInfo";
            this.labelMonsterInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelMonsterInfo.Size = new System.Drawing.Size(0, 20);
            this.labelMonsterInfo.TabIndex = 16;
            // 
            // buttonEatFood
            // 
            this.buttonEatFood.Location = new System.Drawing.Point(498, 540);
            this.buttonEatFood.Name = "buttonEatFood";
            this.buttonEatFood.Size = new System.Drawing.Size(100, 25);
            this.buttonEatFood.TabIndex = 17;
            this.buttonEatFood.Text = "Eat Food";
            this.buttonEatFood.UseVisualStyleBackColor = true;
            this.buttonEatFood.Click += new System.EventHandler(this.buttonEatFood_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1050, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = false;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(500, 17);
            this.statusLabel.Text = "Welcome to DND!";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabel.ToolTipText = "dd";
            // 
            // buttonAttack
            // 
            this.buttonAttack.Enabled = false;
            this.buttonAttack.Location = new System.Drawing.Point(604, 507);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(100, 25);
            this.buttonAttack.TabIndex = 19;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // pictureBoxDungeonPic
            // 
            this.pictureBoxDungeonPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDungeonPic.BackgroundImage")));
            this.pictureBoxDungeonPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDungeonPic.Location = new System.Drawing.Point(462, 25);
            this.pictureBoxDungeonPic.Name = "pictureBoxDungeonPic";
            this.pictureBoxDungeonPic.Size = new System.Drawing.Size(588, 400);
            this.pictureBoxDungeonPic.TabIndex = 20;
            this.pictureBoxDungeonPic.TabStop = false;
            // 
            // pictureBoxUIBack
            // 
            this.pictureBoxUIBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUIBack.BackgroundImage")));
            this.pictureBoxUIBack.Location = new System.Drawing.Point(0, 424);
            this.pictureBoxUIBack.Name = "pictureBoxUIBack";
            this.pictureBoxUIBack.Size = new System.Drawing.Size(1050, 166);
            this.pictureBoxUIBack.TabIndex = 21;
            this.pictureBoxUIBack.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayer.BackgroundImage")));
            this.pictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(0, 428);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(121, 162);
            this.pictureBoxPlayer.TabIndex = 22;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // labelCharStats2
            // 
            this.labelCharStats2.AutoSize = true;
            this.labelCharStats2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCharStats2.Location = new System.Drawing.Point(233, 445);
            this.labelCharStats2.Name = "labelCharStats2";
            this.labelCharStats2.Size = new System.Drawing.Size(0, 20);
            this.labelCharStats2.TabIndex = 23;
            // 
            // pictureBoxMonster
            // 
            this.pictureBoxMonster.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMonster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMonster.Location = new System.Drawing.Point(891, 428);
            this.pictureBoxMonster.Name = "pictureBoxMonster";
            this.pictureBoxMonster.Size = new System.Drawing.Size(159, 162);
            this.pictureBoxMonster.TabIndex = 24;
            this.pictureBoxMonster.TabStop = false;
            // 
            // labelFloorDebug
            // 
            this.labelFloorDebug.AutoSize = true;
            this.labelFloorDebug.BackColor = System.Drawing.Color.Transparent;
            this.labelFloorDebug.Location = new System.Drawing.Point(441, 25);
            this.labelFloorDebug.Name = "labelFloorDebug";
            this.labelFloorDebug.Size = new System.Drawing.Size(91, 13);
            this.labelFloorDebug.TabIndex = 13;
            this.labelFloorDebug.Text = "Debug Room Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1050, 612);
            this.Controls.Add(this.pictureBoxMonster);
            this.Controls.Add(this.labelCharStats2);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonEatFood);
            this.Controls.Add(this.labelMonsterInfo);
            this.Controls.Add(this.buttonWisPot);
            this.Controls.Add(this.buttonStrPot);
            this.Controls.Add(this.labelFloorDebug);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonEast);
            this.Controls.Add(this.buttonSouth);
            this.Controls.Add(this.buttonWest);
            this.Controls.Add(this.buttonNorth);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonGenerateMonster);
            this.Controls.Add(this.buttonLoadGame);
            this.Controls.Add(this.buttonNewGame);
            this.Controls.Add(this.labelCharStats1);
            this.Controls.Add(this.labelFloorText);
            this.Controls.Add(this.pictureBoxDungeonPic);
            this.Controls.Add(this.pictureBoxUIBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDungeonPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUIBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMonster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFloorText;
        private System.Windows.Forms.Label labelCharStats1;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonLoadGame;
        private System.Windows.Forms.Button buttonGenerateMonster;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripNewGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripLoadGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripSaveGame;
        public System.Windows.Forms.Button buttonNorth;
        public System.Windows.Forms.Button buttonWest;
        public System.Windows.Forms.Button buttonSouth;
        public System.Windows.Forms.Button buttonEast;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonStrPot;
        private System.Windows.Forms.Button buttonWisPot;
        private System.Windows.Forms.Label labelMonsterInfo;
        private System.Windows.Forms.Button buttonEatFood;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripButton toolStripOptions;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.PictureBox pictureBoxDungeonPic;
        private System.Windows.Forms.PictureBox pictureBoxUIBack;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.Label labelCharStats2;
        private System.Windows.Forms.PictureBox pictureBoxMonster;
        private System.Windows.Forms.Label labelFloorDebug;
    }
}

