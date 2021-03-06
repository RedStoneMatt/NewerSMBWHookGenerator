﻿namespace NewerSMBWHookGenerator
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SSGroupBox = new System.Windows.Forms.GroupBox();
            this.labelTargetFunction = new System.Windows.Forms.Label();
            this.labelDDX1 = new System.Windows.Forms.Label();
            this.labelYPos = new System.Windows.Forms.Label();
            this.spritefileinfo = new System.Windows.Forms.CheckBox();
            this.SSIDDY1 = new System.Windows.Forms.TextBox();
            this.spritefileinfotarget = new System.Windows.Forms.TextBox();
            this.SSIDDY2 = new System.Windows.Forms.TextBox();
            this.labelDDY2 = new System.Windows.Forms.Label();
            this.SSIDDX2 = new System.Windows.Forms.TextBox();
            this.labelXPos = new System.Windows.Forms.Label();
            this.SSIDDX1 = new System.Windows.Forms.TextBox();
            this.labelDDX2 = new System.Windows.Forms.Label();
            this.SSIYPos = new System.Windows.Forms.TextBox();
            this.labelDDY1 = new System.Windows.Forms.Label();
            this.SSIXPos = new System.Windows.Forms.TextBox();
            this.isSSI = new System.Windows.Forms.CheckBox();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.isUniversalHook = new System.Windows.Forms.RadioButton();
            this.logs = new System.Windows.Forms.Label();
            this.isNormalHook = new System.Windows.Forms.RadioButton();
            this.Output = new System.Windows.Forms.TextBox();
            this.SIGroupBox = new System.Windows.Forms.GroupBox();
            this.SpriteName = new System.Windows.Forms.ComboBox();
            this.labelSpriteName = new System.Windows.Forms.Label();
            this.ActorNum = new System.Windows.Forms.NumericUpDown();
            this.labelSpriteNumber = new System.Windows.Forms.Label();
            this.SpriteNum = new System.Windows.Forms.NumericUpDown();
            this.labelActorNumber = new System.Windows.Forms.Label();
            this.labelActorIName = new System.Windows.Forms.Label();
            this.ActorIName = new System.Windows.Forms.ComboBox();
            this.cppfilename = new System.Windows.Forms.TextBox();
            this.labelIGCustomSpriteName = new System.Windows.Forms.Label();
            this.labelCustomSpriteName = new System.Windows.Forms.Label();
            this.labelCPPFilename = new System.Windows.Forms.Label();
            this.ingamespritename = new System.Windows.Forms.TextBox();
            this.customspritename = new System.Windows.Forms.TextBox();
            this.Generate = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.hexCalculatorToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapfileToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.getAnExampleToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.sub2AddressToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiKamekToolStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SSGroupBox.SuspendLayout();
            this.mainGroupBox.SuspendLayout();
            this.SIGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActorNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteNum)).BeginInit();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SSGroupBox
            // 
            this.SSGroupBox.Controls.Add(this.labelTargetFunction);
            this.SSGroupBox.Controls.Add(this.labelDDX1);
            this.SSGroupBox.Controls.Add(this.labelYPos);
            this.SSGroupBox.Controls.Add(this.spritefileinfo);
            this.SSGroupBox.Controls.Add(this.SSIDDY1);
            this.SSGroupBox.Controls.Add(this.spritefileinfotarget);
            this.SSGroupBox.Controls.Add(this.SSIDDY2);
            this.SSGroupBox.Controls.Add(this.labelDDY2);
            this.SSGroupBox.Controls.Add(this.SSIDDX2);
            this.SSGroupBox.Controls.Add(this.labelXPos);
            this.SSGroupBox.Controls.Add(this.SSIDDX1);
            this.SSGroupBox.Controls.Add(this.labelDDX2);
            this.SSGroupBox.Controls.Add(this.SSIYPos);
            this.SSGroupBox.Controls.Add(this.labelDDY1);
            this.SSGroupBox.Controls.Add(this.SSIXPos);
            this.SSGroupBox.Controls.Add(this.isSSI);
            this.SSGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SSGroupBox.Location = new System.Drawing.Point(461, 19);
            this.SSGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.SSGroupBox.Name = "SSGroupBox";
            this.SSGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.SSGroupBox.Size = new System.Drawing.Size(323, 295);
            this.SSGroupBox.TabIndex = 37;
            this.SSGroupBox.TabStop = false;
            this.SSGroupBox.Text = "Sprite Settings";
            // 
            // labelTargetFunction
            // 
            this.labelTargetFunction.AutoSize = true;
            this.labelTargetFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelTargetFunction.Location = new System.Drawing.Point(19, 258);
            this.labelTargetFunction.Name = "labelTargetFunction";
            this.labelTargetFunction.Size = new System.Drawing.Size(112, 17);
            this.labelTargetFunction.TabIndex = 13;
            this.labelTargetFunction.Text = "Target Function:";
            // 
            // labelDDX1
            // 
            this.labelDDX1.AutoSize = true;
            this.labelDDX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelDDX1.Location = new System.Drawing.Point(7, 117);
            this.labelDDX1.Name = "labelDDX1";
            this.labelDDX1.Size = new System.Drawing.Size(124, 17);
            this.labelDDX1.TabIndex = 27;
            this.labelDDX1.Text = "Draw Distance X1:";
            // 
            // labelYPos
            // 
            this.labelYPos.AutoSize = true;
            this.labelYPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelYPos.Location = new System.Drawing.Point(56, 87);
            this.labelYPos.Name = "labelYPos";
            this.labelYPos.Size = new System.Drawing.Size(75, 17);
            this.labelYPos.TabIndex = 25;
            this.labelYPos.Text = "Y Position:";
            // 
            // spritefileinfo
            // 
            this.spritefileinfo.AutoSize = true;
            this.spritefileinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.spritefileinfo.Location = new System.Drawing.Point(75, 229);
            this.spritefileinfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spritefileinfo.Name = "spritefileinfo";
            this.spritefileinfo.Size = new System.Drawing.Size(173, 21);
            this.spritefileinfo.TabIndex = 11;
            this.spritefileinfo.Text = "Sprite ARC File Setting";
            this.spritefileinfo.UseVisualStyleBackColor = true;
            this.spritefileinfo.CheckedChanged += new System.EventHandler(this.spritefileinfo_CheckedChanged);
            // 
            // SSIDDY1
            // 
            this.SSIDDY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SSIDDY1.Location = new System.Drawing.Point(137, 173);
            this.SSIDDY1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SSIDDY1.MaxLength = 8;
            this.SSIDDY1.Name = "SSIDDY1";
            this.SSIDDY1.ReadOnly = true;
            this.SSIDDY1.Size = new System.Drawing.Size(177, 23);
            this.SSIDDY1.TabIndex = 30;
            this.SSIDDY1.TextChanged += new System.EventHandler(this.SSIDDY1_TextChanged);
            this.SSIDDY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // spritefileinfotarget
            // 
            this.spritefileinfotarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.spritefileinfotarget.Location = new System.Drawing.Point(137, 254);
            this.spritefileinfotarget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spritefileinfotarget.Name = "spritefileinfotarget";
            this.spritefileinfotarget.ReadOnly = true;
            this.spritefileinfotarget.Size = new System.Drawing.Size(177, 23);
            this.spritefileinfotarget.TabIndex = 12;
            this.spritefileinfotarget.TextChanged += new System.EventHandler(this.spritefileinfotarget_TextChanged);
            // 
            // SSIDDY2
            // 
            this.SSIDDY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SSIDDY2.Location = new System.Drawing.Point(137, 202);
            this.SSIDDY2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SSIDDY2.MaxLength = 8;
            this.SSIDDY2.Name = "SSIDDY2";
            this.SSIDDY2.ReadOnly = true;
            this.SSIDDY2.Size = new System.Drawing.Size(177, 23);
            this.SSIDDY2.TabIndex = 32;
            this.SSIDDY2.TextChanged += new System.EventHandler(this.SSIDDY2_TextChanged);
            this.SSIDDY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // labelDDY2
            // 
            this.labelDDY2.AutoSize = true;
            this.labelDDY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelDDY2.Location = new System.Drawing.Point(7, 206);
            this.labelDDY2.Name = "labelDDY2";
            this.labelDDY2.Size = new System.Drawing.Size(124, 17);
            this.labelDDY2.TabIndex = 33;
            this.labelDDY2.Text = "Draw Distance Y2:";
            // 
            // SSIDDX2
            // 
            this.SSIDDX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SSIDDX2.Location = new System.Drawing.Point(137, 143);
            this.SSIDDX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SSIDDX2.MaxLength = 8;
            this.SSIDDX2.Name = "SSIDDX2";
            this.SSIDDX2.ReadOnly = true;
            this.SSIDDX2.Size = new System.Drawing.Size(177, 23);
            this.SSIDDX2.TabIndex = 28;
            this.SSIDDX2.TextChanged += new System.EventHandler(this.SSIDDX2_TextChanged);
            this.SSIDDX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // labelXPos
            // 
            this.labelXPos.AutoSize = true;
            this.labelXPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelXPos.Location = new System.Drawing.Point(56, 58);
            this.labelXPos.Name = "labelXPos";
            this.labelXPos.Size = new System.Drawing.Size(75, 17);
            this.labelXPos.TabIndex = 23;
            this.labelXPos.Text = "X Position:";
            // 
            // SSIDDX1
            // 
            this.SSIDDX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SSIDDX1.Location = new System.Drawing.Point(137, 113);
            this.SSIDDX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SSIDDX1.MaxLength = 8;
            this.SSIDDX1.Name = "SSIDDX1";
            this.SSIDDX1.ReadOnly = true;
            this.SSIDDX1.Size = new System.Drawing.Size(177, 23);
            this.SSIDDX1.TabIndex = 26;
            this.SSIDDX1.TextChanged += new System.EventHandler(this.SSIDDX1_TextChanged);
            this.SSIDDX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // labelDDX2
            // 
            this.labelDDX2.AutoSize = true;
            this.labelDDX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelDDX2.Location = new System.Drawing.Point(7, 147);
            this.labelDDX2.Name = "labelDDX2";
            this.labelDDX2.Size = new System.Drawing.Size(124, 17);
            this.labelDDX2.TabIndex = 29;
            this.labelDDX2.Text = "Draw Distance X2:";
            // 
            // SSIYPos
            // 
            this.SSIYPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SSIYPos.Location = new System.Drawing.Point(137, 83);
            this.SSIYPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SSIYPos.MaxLength = 8;
            this.SSIYPos.Name = "SSIYPos";
            this.SSIYPos.ReadOnly = true;
            this.SSIYPos.Size = new System.Drawing.Size(177, 23);
            this.SSIYPos.TabIndex = 24;
            this.SSIYPos.TextChanged += new System.EventHandler(this.SSIYPos_TextChanged);
            this.SSIYPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // labelDDY1
            // 
            this.labelDDY1.AutoSize = true;
            this.labelDDY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelDDY1.Location = new System.Drawing.Point(7, 177);
            this.labelDDY1.Name = "labelDDY1";
            this.labelDDY1.Size = new System.Drawing.Size(124, 17);
            this.labelDDY1.TabIndex = 31;
            this.labelDDY1.Text = "Draw Distance Y1:";
            // 
            // SSIXPos
            // 
            this.SSIXPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SSIXPos.Location = new System.Drawing.Point(137, 54);
            this.SSIXPos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SSIXPos.MaxLength = 8;
            this.SSIXPos.Name = "SSIXPos";
            this.SSIXPos.ReadOnly = true;
            this.SSIXPos.Size = new System.Drawing.Size(177, 23);
            this.SSIXPos.TabIndex = 22;
            this.SSIXPos.TextChanged += new System.EventHandler(this.SSIXPos_TextChanged);
            this.SSIXPos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexBox_KeyPress);
            // 
            // isSSI
            // 
            this.isSSI.AutoSize = true;
            this.isSSI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.isSSI.Location = new System.Drawing.Point(75, 28);
            this.isSSI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isSSI.Name = "isSSI";
            this.isSSI.Size = new System.Drawing.Size(187, 21);
            this.isSSI.TabIndex = 21;
            this.isSSI.Text = "Sprite Spawning Settings";
            this.isSSI.UseVisualStyleBackColor = true;
            this.isSSI.CheckedChanged += new System.EventHandler(this.isSSI_CheckedChanged);
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.isUniversalHook);
            this.mainGroupBox.Controls.Add(this.logs);
            this.mainGroupBox.Controls.Add(this.isNormalHook);
            this.mainGroupBox.Controls.Add(this.Output);
            this.mainGroupBox.Controls.Add(this.SIGroupBox);
            this.mainGroupBox.Controls.Add(this.Generate);
            this.mainGroupBox.Controls.Add(this.SSGroupBox);
            this.mainGroupBox.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.mainGroupBox.Location = new System.Drawing.Point(13, 32);
            this.mainGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.mainGroupBox.Size = new System.Drawing.Size(793, 793);
            this.mainGroupBox.TabIndex = 39;
            this.mainGroupBox.TabStop = false;
            // 
            // isUniversalHook
            // 
            this.isUniversalHook.AutoSize = true;
            this.isUniversalHook.Location = new System.Drawing.Point(192, 333);
            this.isUniversalHook.Name = "isUniversalHook";
            this.isUniversalHook.Size = new System.Drawing.Size(123, 23);
            this.isUniversalHook.TabIndex = 41;
            this.isUniversalHook.Text = "Universal Hook";
            this.isUniversalHook.UseVisualStyleBackColor = true;
            // 
            // logs
            // 
            this.logs.AutoSize = true;
            this.logs.Location = new System.Drawing.Point(4, 764);
            this.logs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(128, 19);
            this.logs.TabIndex = 36;
            this.logs.Text = "Waiting for Action...";
            // 
            // isNormalHook
            // 
            this.isNormalHook.AutoSize = true;
            this.isNormalHook.Checked = true;
            this.isNormalHook.Location = new System.Drawing.Point(192, 314);
            this.isNormalHook.Name = "isNormalHook";
            this.isNormalHook.Size = new System.Drawing.Size(112, 23);
            this.isNormalHook.TabIndex = 40;
            this.isNormalHook.TabStop = true;
            this.isNormalHook.Text = "Normal Hook";
            this.isNormalHook.UseVisualStyleBackColor = true;
            this.isNormalHook.CheckedChanged += new System.EventHandler(this.isNormalHook_CheckedChanged);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Output.Location = new System.Drawing.Point(7, 361);
            this.Output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(777, 392);
            this.Output.TabIndex = 2;
            // 
            // SIGroupBox
            // 
            this.SIGroupBox.Controls.Add(this.SpriteName);
            this.SIGroupBox.Controls.Add(this.labelSpriteName);
            this.SIGroupBox.Controls.Add(this.ActorNum);
            this.SIGroupBox.Controls.Add(this.labelSpriteNumber);
            this.SIGroupBox.Controls.Add(this.SpriteNum);
            this.SIGroupBox.Controls.Add(this.labelActorNumber);
            this.SIGroupBox.Controls.Add(this.labelActorIName);
            this.SIGroupBox.Controls.Add(this.ActorIName);
            this.SIGroupBox.Controls.Add(this.cppfilename);
            this.SIGroupBox.Controls.Add(this.labelIGCustomSpriteName);
            this.SIGroupBox.Controls.Add(this.labelCustomSpriteName);
            this.SIGroupBox.Controls.Add(this.labelCPPFilename);
            this.SIGroupBox.Controls.Add(this.ingamespritename);
            this.SIGroupBox.Controls.Add(this.customspritename);
            this.SIGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SIGroupBox.Location = new System.Drawing.Point(7, 57);
            this.SIGroupBox.Name = "SIGroupBox";
            this.SIGroupBox.Size = new System.Drawing.Size(447, 225);
            this.SIGroupBox.TabIndex = 39;
            this.SIGroupBox.TabStop = false;
            this.SIGroupBox.Text = "Sprite Infos";
            // 
            // SpriteName
            // 
            this.SpriteName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpriteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SpriteName.FormattingEnabled = true;
            this.SpriteName.Items.AddRange(new object[] {
            "BOOT",
            "AUTO_SELECT",
            "SELECT",
            "WORLD_MAP",
            "WORLD_9_DEMO",
            "STAGE",
            "RESTART_CRSIN",
            "CRSIN",
            "MOVIE",
            "GAMEOVER",
            "GAME_SETUP",
            "MULTI_PLAY_COURSE_SELECT",
            "CURSOR",
            "PLAYER",
            "YOSHI",
            "WM_TEST",
            "WM_TEST2",
            "BG_GM",
            "CAMERA",
            "YOSHI_FIRE",
            "Boss - Topman",
            "Boss Controller - Tower Boss",
            "Kamek",
            "Bowser Boss Battle Related",
            "Cutscene Controller - Castle Boss",
            "Cutscene Controller - Bowser Jr and Peach at Castle",
            "Cutscene Controller - Bowser Jr and Peach at Airship",
            "KOOPA_SHIP_FOR_CASTLE_DEMO",
            "KOOPA_JR_FOR_CASTLE_DEMO",
            "PEACH_FOR_CASTLE_DEMO",
            "KAMECK_FOR_CASTLE_DEMO",
            "LEMMY_FOOTHOLD",
            "LEMMY_FOOTHOLD_MAIN",
            "Castle Boss Door",
            "Castle Boss Key",
            "Ambush Level Controller",
            "AC_BATTLE_KINOPIO",
            "AC_BATTLE_ITEM: Ambush Mushroom Reward",
            "Credits Controller",
            "Wind-Riding Coins",
            "Movement Controller - \"Ac_GroupID\"",
            "Electric Line",
            "RIVER_PAIPO",
            "RIVER_ITEM",
            "RIVER_COIN",
            "RIVER_STARCOIN",
            "RIVER_LIFT",
            "RIVER_BARREL",
            "RIVER_PUKU",
            "RIVER_PAKKUN",
            "Line God",
            "Goomba",
            "Paragoomba",
            "Unused Goomba, dies upon contact, usable",
            "Koopa Troopa",
            "Koopa Paratroopa",
            "Buzzy Beetle",
            "Spiny",
            "Upside-Down Spiny",
            "EN_BLOCK",
            "EN_ITEM, Actor handling items",
            "Star Coin",
            "Line Controlled Star Coin",
            "Bolt Controlled Star Coin",
            "Event Controller - Zone Enter",
            "Event Controller - \"And\"",
            "Event Controller - \"Or\"",
            "Event Controller - \"Random\"",
            "Event Controller - Chainer (If X, do Y)",
            "Event Controller - \"If\"",
            "Event Controller - Multi-Chainer (If X, do Y THROUGH Z)",
            "EN_BKBLOCK - Breaking Block",
            "Event Controller - \"?\"",
            "Event Controller - \"P\"",
            "Event Controller - \"!\"",
            "Final Boss Controller - First Switch",
            "Final Boss Controller - Second Switch",
            "Event Controller - Brick Block \"?\"",
            "Event Controller - Brick Block \"P\"",
            "Event Controller - Brick Block \"!\"",
            "Podoboo",
            "Thwomp",
            "Big Thwomp",
            "Lakitu",
            "EN_JUGEM_COIN - Coin Lakitu",
            "EN_EATJUGEM",
            "EN_JUGEM_BODY",
            "Spike Top",
            "Spinning Firebar",
            "Spike Ball",
            "Giant Spike Ball",
            "Pipe - Piranha Plant - Up Facing",
            "Pipe - Piranha Plant - Down Facing",
            "Pipe - Piranha Plant - Right Facing",
            "Pipe - Piranha Plant - Left Facing",
            "Pipe - Venus Fire Trap - Facing Up",
            "Pipe - Venus Fire Trap - Facing Down",
            "Pipe - Venus Fire Trap - Facing Right",
            "Pipe - Venus Fire Trap - Facing Left",
            "Grounded Piranha Plant",
            "Giant Grounded Piranha Plant",
            "Grounded Venus Fire Trap",
            "Giant Grounded Venus Fire Trap",
            "Extending Piranha Plant",
            "ICEBALL - Player Iceball",
            "PL_FIREBALL - Player Fireball",
            "PAKKUN_FIREBALL - Venus Fire Traps Fireball",
            "BROS_FIREBALL - Fireball thrown by Fire Bros.",
            "BOOMERANG - Boomerang used by Boomerang Bros.",
            "Event Looper",
            "Fire Brother",
            "Boomerang Brother",
            "Hammer Brother",
            "Ice Brother",
            "Hammer Brother",
            "HAMMER - Hammer thrown by Hammer Bros.",
            "Big Sledge Brother",
            "MEGA_HAMMER - Hammer thrown by Sledge Bros.",
            "BROS_ICEBALL - Iceballs thrown by Ice Bros.",
            "Actor Spawner",
            "Timed Actor Spawner",
            "Effect - Wind Physics and Sound",
            "Special Level Events",
            "Unused Sprite - \"Tag_Water\"",
            "Auto-Scrolling Controller - Requires Rails",
            "OBJ_GRASS - The grass model that replaces the tiles in Pa1_nohara",
            "Effect - Sunlight",
            "EN_KILLER - Bullet Bill",
            "EN_SEARCH_KILLER - Heat seeking Bullet Bill",
            "EN_MAGNUM_KILLER - Banzai Bill",
            "EN_SEARCH_MAGNUM_KILLER - Heat seeking Banzai Bill",
            "Swooper",
            "Para-bomb Spawn Area",
            "Bob-omb",
            "Para-bomb",
            "Mecha-Koopas",
            "Little Mouser",
            "Boss - Thwompadomp",
            "Pipe Enemy Generator",
            "Broozer",
            "Vertical Platform Generator",
            "Amp",
            "EN_LINE_BIRIKYU - Line Controlled Amp",
            "Unused Sprite - \"En_Birikyu_Maker\"",
            "Line Controlled Fuzzy",
            "Pokey",
            "EN_SANBO_PARTS - Unused",
            "EN_SANBO_EL - Pokey parts",
            "Rotating Spike Ball on Chain [6x6",
            "Blooper",
            "Blooper with Babies",
            "Flagpole",
            "EN_GESSO_CHILD - Blooper Baby",
            "Synchronized Flame Jet Controller",
            "Synchronized Flame Jet ",
            "Continuous Flame Cannon",
            "Pulsating Flame Cannon",
            "Unused Sprite - \"En_Pukupuku_Parent\"",
            "School of Cheep-Cheeps",
            "Small Cheep Cheep",
            "Spiny Cheep-Cheep",
            "Giant Cheep-Cheep",
            "Unused Sprite - \"En_Pukucoin\"",
            "Dry Bones",
            "Giant Dry Bones",
            "EN_KARON_HEAD - Dry Bone Head",
            "Sprite Crashes Game - \"En_Reverse\"",
            "Lakitu Spawner",
            "Chain Link Flip Panel [XxY]",
            "Long Chain Link Flip Panel [XxY]",
            "Chain Link Koopa - Horizontal",
            "Chain Link Koopa - Vertical",
            "Unused Sprite - \"Bighana_Mgr\"",
            "Ending Manager",
            "Wiggler",
            "Giant Wiggler",
            "Boo",
            "Big Boo [6x6",
            "Purple Crow",
            "Spiked 3D Stake - Down",
            "Spiked 3D Stake - Up",
            "Spiked 3D Stake - Right",
            "Spiked 3D Stake - Left",
            "Gigantic Spike Pillar - Right",
            "Gigantic Spike Pillar - Left",
            "Gigantic Spike Pillars - Down",
            "Gigantic Spike Pillars - Up",
            "Medium Spike Pillar - Down",
            "Loose Arrow",
            "EN_WANWAN - Chomp",
            "Chain Chomp [XxY]",
            "Surfaced Leaping Cheep Cheep - \"En_JumpPuku\"",
            "Porcu-Puffer",
            "Porcu-Puffer Spawner",
            "Fire Snake ",
            "Boss Controller - Kamek",
            "Magic Platform",
            "Cooligan Generator",
            "Cooligan",
            "SLIP_PENGUIN2_GLASSES - Cooligan\'s Glasses",
            "Chestnut Goomba",
            "Pipe - Bubbles",
            "AWA - Bubble",
            "Fire Laser",
            "Shy Guy",
            "Unused Sprite - \"Dummy_Door\"",
            "Purple Striped Climbable Pole",
            "Horizontal Rope",
            "D-Pad Door - \"Remo_Door\"",
            "Falling Chestnut",
            "Captain Bowser",
            "View Related - Background Centering",
            "KAMECK_MAGIC - Kamek\'s heatseeking magic",
            "SINKDOKAN_UP",
            "SINKDOKAN_DOWN",
            "SINKDOKAN_LEFT",
            "SINKDOKAN_RIGHT",
            "FLYDOKAN_UP",
            "FLYDOKAN_DOWN",
            "FLYDOKAN_LEFT",
            "FLYDOKAN_RIGHT",
            "Unused Sprite - \"En_Hatena_Balloon\"",
            "\"One-Way Gate\"",
            "Flying Question Block",
            "Fire Chomp",
            "KERONPA_FIRE - Fireball spat by the Fire Chomp",
            "Special Exit Controller - [y2=n11+1]",
            "Cheep-Chomp",
            "D-Pad Door",
            "Unused Sprite - \"En_SwitchDoor\"",
            "Ghost House Door",
            "Tower Boss Door",
            "Castle Boss Door",
            "Bowser Boss Door",
            "Collision Switcher - Mini-Mario Only",
            "Midway Point Flag",
            "Border of Level Related - Left Side",
            "Border of Level Related - Right Side",
            "Border of Level Related - Left Side (2)",
            "Border of Level Related - Right Side (2)",
            "View Related - Zoom",
            "Larry Koopa",
            "Wendy Koopa",
            "Iggy Koopa",
            "Lemmy Koopa",
            "Morton Koopa",
            "Roy Koopa",
            "Ludwig von Koopa",
            "Boss Controller - Larry Koopa",
            "Boss Controller - Roy Koopa",
            "Boss Controller - Wendy Koopa",
            "Boss Controller - Iggy Koopa",
            "CASTLE_LEMMY_BALL - One of Lemmy\'s Balls.",
            "Boss Controller - Lemmy Koopa",
            "Boss Controller - Morton Koopa",
            "OBJ_LUDWIG - Ludwig von Koopa",
            "Boss Controller - Ludwig von Koopa",
            "Bowser",
            "Fake Peach in Cage",
            "Peach in Cage",
            "Bowser Fireball Spawn Area",
            "KOOPA_FIRE - Bowser\'s Fireballs",
            "LARRY_FIRE - Larry\'s Fireballs",
            "\"Gold Ring\"",
            "KOKOOPA_BALL - One of Lemmy\'s Balls.",
            "KOKOOPA_THREEWAY_BLITZ - Ludwig\'s Castle Battle ",
            "LEMMY_BALL - One of Lemmy\'s Balls.",
            "CASTLE_LEMMY_THROW_BALL - One of Lemmy\'s Balls.",
            "OBJ_IGGY_SLED - Iggy\'s Chain Chomp platform",
            "OBJ_IGGY_WANWAN - Iggy\'s Chain Chomp",
            "OBJ_MORTON - Morton Koopa",
            "OBJ_ROY - Roy Koopa",
            "OBJ_LARRY - Larry Koopa",
            "OBJ_WENDY - Wendy Koopa",
            "Final Battle Bowser Bridge",
            "Sprite Crashes Game - \"Ac_Boss_Koopa_Rubble\"",
            "Final Castle Background Effects",
            "CASTLE_LUDWIG_BLITZ - Ludwig Battle Related",
            "CASTLE_LUDWIG_BLITZ_MGR - Ludwig Battle Controler",
            "Magic Fireball Spawn Area",
            "FALL_FIRE - Some effect related to the fireballs",
            "Fireball Spawn Area",
            "FIRE_BLITZ - Fireball",
            "KOKOOPA_SEARCH_FIRE - Heatsiking Battle Ludwig Magic",
            "Urchin",
            "Mega Urchin",
            "Huckit Crab",
            "EN_KANITAMA - Huckit Rock",
            "Fishbones",
            "Clampy",
            "Giant Goomba",
            "Mega Goomba",
            "Micro Goomba",
            "Toad House - Chest",
            "Toad House - Cannon",
            "Rolling Spike Ball Generator",
            "JR_CLOWN_A - Koopa Clown Copter Battle 1",
            "JR_CLOWN_B - Koopa Clown Copter Battle 2",
            "JR_CLOWN_C - Koopa Clown Copter Battle 3",
            "Player Clown Car",
            "FLOOR_JR_A - Floor in Bowser Junior\'s first battle",
            "FLOOR_JR_B - Floor in Bowser Junior\'s second battle",
            "FLOOR_JR_C - Floor in Bowser Junior\'s third battle",
            "FLOOR_JR_C_MGR - Third Bowser Junior battle floor controller",
            "BOMB_JR_C - Gigantic third Bowser Junior Battle Bomb",
            "Boss Controller - Bowser Jr. 1st Battle",
            "Boss Controller - Bowser Jr. 2nd Battle",
            "Boss Controller - Bowser Jr. 3rd Battle",
            "JR_FIRE - Bowser Junior\'s fire",
            "JR_FLOOR_FIRE - Fire that burns on the floor during Bowser Junior battles",
            "JR_FLOOR_FIRE_MGR - Fire that burns on the floor during Bowser Junior battles con" +
                "troller",
            "JR_CLOWN_FOR_JR_C_DEMO - Pre-third Bowser Jr. battle cutscene\'s broken jr. copter" +
                ".",
            "KAMECK_FOR_AIRSHIP_DEMO",
            "PEACH_FOR_AIRSHIP_DEMO - Cutscenes",
            "KOOPA_SHIP_FOR_AIRSHIP_DEMO",
            "EN_EATCOIN - Edible Coin",
            "Bullet Bill Spawn Area",
            "Fire Chomp Spawn Area",
            "Unused Sprite - \"Ac_Waki_Pukupuku\"",
            "Unused Platform - \"Belt_Needle\"",
            "Sand Pillar",
            "Event Block",
            "Lava Geyser",
            "Bramball",
            "Bulber (Glowing Fish) Spawn Area",
            "Bulber (Glowing Fish)",
            "Foo (Cloud Blower)",
            "Boss Controller - Larry Koopa Unused",
            "Clouds",
            "Doomship Key",
            "AC_YOSHI_EGG - Yoshi Egg?",
            "EN_WATERPAIPO - Spiny egg, floats on water",
            "River Piranha Plant",
            "FOO_BALL - River Piranha Plant\'s ball",
            "MT_HANACHAN - Wiggler mountain, no code.",
            "x",
            "x",
            "EN_ROT_PAKKUN - doesn\'t spawn anything",
            "Poltergeist Item",
            "Falling Icicle",
            "Boss - Fuzzy Bear",
            "Mr Sun",
            "Old Barrel",
            "Boss - Ramboo",
            "IWAO_ROCK - No code",
            "Volcano Rock Spawn Area",
            "KAZAN_ROCK - Volcano Rock",
            "EN_CANNON_BULLET - Cannon Ball",
            "Monty Mole",
            "Rocky Wrenches",
            "CHOROPOO_SHADOW - Monty Mole digging spot",
            "Toad House - Lives Balloon Unused",
            "Toad House - Lives Balloon",
            "Jellybeam",
            "Toad House - Minigame Flip Panels",
            "Toad House Controller - Cannon Minigame",
            "MINI_GAME_GUN_BATTERY_MGR_OBJ - Cannon minigame related.",
            "Toad House Controller - Item Panel Minigame",
            "MINI_GAME_WIRE_MESH_MGR_OBJ - Item Panel minigame related",
            "Peach\'s Castle -\"Peach_Castle_Sequence_Mgr\"",
            "PEACH_CASTLE_SEQUENCE_MGR_OBJ - Hint Movie related",
            "Peach\'s Castle - Hint Movies Block",
            "Toad House - Toad",
            "Arrow Signboard",
            "Effect - Bubble Generator",
            "Effect - \"En_Bubble_Control\"",
            "Box",
            "Beta Arrow Block",
            "Boo Circle",
            "EN_ROTATION_GHOST - Boo Circle Boo",
            "Boss - Podouble",
            "EN_MADOPU - No code, deletes itself.",
            "Flying Wrench",
            "Gabon",
            "GABON_ROCK - Gabon\'s Rock",
            "MANHOLE - Rocky Wrench\' Manhole",
            "BGM_INTERLOCKING_DUMMY_BLOCK - Dancing Coin",
            "Dancing Coin Controller",
            "King Bill",
            "EN_WATER_BUBBLE_BULLET - Water Bullet Bill",
            "Yoshi Fruit/Cookie",
            "Effect - Rising Lava Particle",
            "Effect - Snow / Wind Visuals",
            "Effect - Airship Rocking",
            "Giga Goomba",
            "Invisible 1-Up - Mini-Mario Only",
            "Spin-Jump Coin (Unused)",
            "Homing Banzai Bill Generator",
            "EN_TOBIPUKU - Cheep Cheep School",
            "Cheep Cheep Spawner",
            "NEEDLE_FOR_KOOPA_JR_B - Lasers in the second Bowser Jr. fight.",
            "TOP_BG_FOR_CASTLE_LUDWIG",
            "MIDDLE_BG_FOR_CASTLE_LUDWIG",
            "BOTTOM_BG_FOR_CASTLE_LUDWIG",
            "MD_ACTOR",
            "MD_CAMERA",
            "Cloud Area",
            "UNIT_RAIL - Line guide",
            "UNIT_CHIKUWA - Related to the donut lifts.",
            "Seaweed Plant",
            "Effect - Environmental Sound Effects",
            "Coin",
            "EN_COIN_JUGEM - Lakitu\'s Coins",
            "EN_COIN_JUMP - Some type of a jumping coin",
            "Rolling Hill Controlled Coin",
            "Bolt Controlled Coin",
            "EN_COIN_WIND - Wind Controlled Coin",
            "Blue P-Switch Coin",
            "Unused Sprite - \"En_Coin_Water\"",
            "Red Coin",
            "Ambush - Toad Balloons",
            "ICE_ACTOR - Model for the frozen enemy/player",
            "Lighting - Glow Block",
            "Propeller Block",
            "ENEMY_ICE - Frozen enemy",
            "PLAYER_ICE - Frozen Player",
            "Grabbable Ice Block",
            "POW Block",
            "Barrel",
            "Rotation Controller - Swaying",
            "Rotation Controller - Spinning",
            "Unused Platform - \"En_Lift_Rotation_Full\"",
            "Rotation Controlled Crystal Block",
            "Rotation Controlled Red/Green Block",
            "Rotation Controlled Colored Box",
            "Rotation Controlled Odd-Shaped Blocks",
            "Rotation Controlled Hanging Block",
            "Rotation Controlled 4-Way Thin Bar",
            "Rotation Controlled Bar",
            "Little Mouser Despawner",
            "Rotation Controlled Dish Platform",
            "Effect and Sound Player",
            "Horizontal Moving Platform",
            "Vertical Moving Stone Block",
            "Horizontal Moving Stone Block",
            "Unused Platform - \"Ac_Lift_Object_HMove_Big\"",
            "Unused Platform - \"En_Obj_Pol\"",
            "Tower Block",
            "Stone Block - Spiked on Left",
            "Stone Block - Spikes on Right",
            "Stone Block - Spiked on Left + Right",
            "Stone Block - Spiked on Top",
            "Stone Block - Spiked on Bottom",
            "Stone Block - Spiked on Top + Bottom",
            "Enormous Block with Spikes on Side",
            "Horizontal Lava Style Moving Platform",
            "Vertical Block Platform with Light Gem",
            "Blue and Orange Spiral Platform",
            "Movement Controller - Pairing? \"En_Pair_Obj_Parent\"",
            "Movement Controlled Platform - \"En_Pair_Obj_Child\"",
            "Movement Controlled Silver-Gear Block",
            "Movement Controlled Tower Block",
            "Ice Flow Generator",
            "Rail Controlled? - Floating Ice Flow Generator",
            "ICE_ASHIBA - Water Ice Flow",
            "ICE_ASHIBA_WATER - Ice Flow Water",
            "Rail Controlled Ice Flow",
            "Vertical Moving Platform",
            "Fake Star Coin",
            "Fall-When-On Platform",
            "Tilt Controlled Girder",
            "\"4x",
            "\"Beta Rising Tilt Platform\"",
            "Rising Tilt Controlled Girder Controller",
            "Rising Tilt Controlled Girder",
            "Line Controlled Tilt Controlled Girder",
            "Cloud Trampoline",
            "Grey Trampoline Wall",
            "EN_CHIKUWA_BLOCK - Donut Lift",
            "Falling Ledge Bar",
            "Bullet Bill Launcher",
            "Banzai Bill Launcher",
            "AC_WAKILIFT_STEP - Rising wood platform?",
            "Line Controlled Moving Platform",
            "Line Controlled Platform with Bolt",
            "Palm Tree",
            "Moving Flashlight Raft",
            "Line Controlled Rotating Pink Block",
            "Rope Ladder",
            "\"Vine Swing\"",
            "Swinging Vine / Chain",
            "Message Box",
            "Manacle Ring",
            "Rotation Controlled Hanging Chain Platform",
            "One Way Moving Platform",
            "\"Swinging Hinged Platform\"",
            "4-Platform Spinner",
            "Movement Controlled Platform - \"En_Rail_Polygon\"",
            "Movement Controlled Ice Block",
            "Movement Controller - Use Rails",
            "Light Steel Platform - \"En_Rail_Poly_Child\"",
            "Freefall Ghost House Platform",
            "Teetering Stalagmite Platform",
            "Hanging Chained Falling Platform",
            "Rotating Bullet Bill Launcher",
            "Red Coin Ring",
            "Floating Barrel",
            "Portable Spring",
            "Orange \"?\"",
            "Big Breakable Brick Block",
            "Rail Controlled Icy Block Train",
            "Giant Floating Log",
            "OBJ_KAMECK - Kamek",
            "Movement Controller - Vertical Mushroom Platform with Bolt",
            "Movement Controlled Vertical Mushroom Platform",
            "Roulette Block",
            "Scale Platform",
            "AC_LIFT_SCALES_STEP - Scale Platform Platform",
            "Meteor",
            "Unused Tilt Platform - \"Ac_Lift_Boss_Remocon_Seesaw\"",
            "Tile God Event",
            "Icicle",
            "Question Block",
            "Question Block - Unused",
            "Brick Block",
            "Hidden Question Block",
            "Unused Sprite - \"Ac_Obj_Clear_Block\"",
            "Line Controlled Question Block",
            "Line Controlled Brick Block",
            "Floating Question Block",
            "Player-Block",
            "EN_BLOCK_STAFFROLL - Staff Roll Letter Block",
            "Movement Controller - \"Elastic_Kinoko_Parent\"",
            "Extending / Contracting Line Block",
            "Checkered Spring Block",
            "Jumbo Ray Spawn Area",
            "MANTA_MGR2",
            "Jumbo Ray",
            "Extending / Contracting Mushroom Platform",
            "Unused Sprite - \"En_Rotation_Block\"",
            "Rotation Controlled Coin",
            "Rotation Controlled Pipe [Buggy]",
            "Rotation Controlled Question Block",
            "Rotation Controlled Brick Block",
            "Rotating Chain Link Wheel",
            "Tilt Controlled Castle Grate",
            "Boss - Balboa Wrench",
            "Giant Ice Block [4x4]",
            "\"Icy Blocks\"",
            "Wood / Metal Crate",
            "Parabeetle",
            "Heavy Parabeetle",
            "Airship Nut Platform [2x6]",
            "Giant Buzzy Beetle",
            "Wrench",
            "Cannon",
            "Cannon - Multi-use",
            "Cannon - 4-Way [3x3",
            "Cannon - Giant 4-Way with Pipe",
            "Rotating Flame Jet Cannon",
            "Lighting - Circle",
            "Lighting - Giant Glow Block",
            "Lighting - Rotation Controlled Spotlight",
            "Mega Falling Icicle",
            "Unused Sprite - \"Ac_Water_Bubble_Parent\"",
            "Unused Sprite - \"Ac_Water_Bubble_Cannon\"",
            "Rising / Lowering Bullet Bill Cannon",
            "Muncher",
            "Lighting - Lamp",
            "Lakitu Cloud Block",
            "Moving Chain-Link",
            "Bush",
            "Bouncing Lemmy Ball",
            "Question Block with Toad (Single Player)",
            "Brick Block with Toad (Single Player)",
            "AC_FREEZER - Ice block?",
            "Metal Bar",
            "EN_ITEM_IVY - Growing vine",
            "Topman",
            "Pipe Cannon",
            "Movement Controller - \"Kinoko_Lift_Parent\"",
            "Wiggling Mushroom Platform",
            "Bolt Controller - Bolt",
            "Bolt Controlled Metal Block",
            "Bolt Controlled Airship Platform",
            "Bolt Controlled Airship Platform Wire",
            "Warp Cannon",
            "Mushroom Platform",
            "Moving Pipe Facing Up",
            "Moving Pipe Facing Down",
            "Warp Pipe - Up",
            "Warp Pipe - Up (Works Without an Entrance)",
            "Warp Pipe - Down",
            "Warp Pipe - Right",
            "Warp Pipe - Left",
            "Move-When-On Metal Platform",
            "Move-When-On Ghost House Boxes",
            "Down-When-On Platform",
            "5-Enemy-Max",
            "Line Controlled Spine Coaster",
            "Line Controlled Player-Block Platform",
            "WATER_LIFT - Unused Water Platform",
            "Crowd Clapping Controller for Coin Collection",
            "Crowd Clapping Controller for Coin Collection #2",
            "Super Guide Block",
            "FAR_BG",
            "Water",
            "Lava",
            "Poison Water",
            "Quicksand",
            "Effect - Outdoors Fog",
            "Effect - Ghost Fog",
            "Water - \"Ac_Waterall_Rail\"",
            "Message Box",
            "Unused Sprite - \"Mask\"",
            "DTEST",
            "Movement Controller - Giant Floating Bubble",
            "Movement Controller - Giant Floating Bubble Unused",
            "Rising / Falling Water",
            "Rolling Hill",
            "Rolling Hill with 1",
            "Rotating Hill with 8",
            "Caslte Metal Gear",
            "Airship Wooden Gear",
            "Giant Turtle Shell Cave",
            "EN_BOSS_KOOPA_DEMO_CAGE     ",
            "Poltergeist Stand",
            "Effect - Glare",
            "Lighting - Underwater Lamp",
            "AC_COPYRIGHT",
            "WII_STRAP",
            "WM_CS_SEQ_MNG",
            "WORLD_CAMERA",
            "WM_MAP",
            "WM_IBARA",
            "WM_ANTLION_MNG",
            "WM_CASTLE",
            "WM_TOWER",
            "WM_PEACH_CASTLE",
            "Song Block",
            "Sing Along House",
            "WM_SINKSHIP",
            "WM_SWITCH",
            "WM_START",
            "WM_KINOKO_BASE",
            "WM_KINOKO_RED",
            "WM_KINOKO_1UP",
            "Pumpkin Goomba",
            "WM_COURSE",
            "WM_STOP",
            "WM_TORIDE",
            "WM_GHOST",
            "WM_DOKAN",
            "WM_CANNON",
            "WM_KOOPASHIP",
            "WM_BOSS_BASE",
            "WM_BOSS_LARRY",
            "WM_BOSS_ROY",
            "WM_BOSS_WENDY",
            "Bone Platform",
            "WM_BOSS_LEMMY",
            "WM_BOSS_MORTON",
            "WM_BOSS_LUDWIG",
            "WM_BOSS_KAMECK",
            "Captain Bowser: Koopa Flamethrower",
            "Challenge Star",
            "Boss - Samurshai",
            "WM_PAKKUN",
            "WM_BROS",
            "WM_JUGEM",
            "WM_PLAYER",
            "WM_SUBPLAYER",
            "WM_NOTE",
            "Shy Guy Giant",
            "WM_DIRECTOR",
            "Flipblock",
            "WM_ISLAND",
            "WM_ITEM",
            "WM_CS_W3_PALM",
            "WM_SURRENDER",
            "Make Your Own Model",
            "Captain Bowser: Koopa Throw",
            "WM_PAKKUNHEAD",
            "Bridge Bowser Bomb Drop",
            "WM_SMALLCLOUD",
            "WM_KOOPAJR",
            "WM_PEACH",
            "WM_BOARD",
            "Thundercloud",
            "Palace Activator",
            "WM_SANDPILLAR",
            "WM_YOGANPILLAR",
            "WM_KINOPIO",
            "WM_DANCE_PAKKUN",
            "WM_DOKANROUTE",
            "WM_HANACHAN",
            "WM_TOGEZO",
            "WM_MANTA",
            "WM_TERESA",
            "WORLD_SELECT",
            "WORLD_SELECT_GUIDE",
            "COLLECTION_COIN_BASE",
            "COLLECTION_COIN",
            "COURSE_SELECT_MENU",
            "NUMBER_OF_PEOPLE_CHANGE",
            "STOCK_ITEM",
            "STOCK_ITEM_SHADOW",
            "EASY_PAIRING",
            "WM_2D_PLAYER",
            "EVENT_OPENING_TITLE",
            "SELECT_PLAYER",
            "MULTI_COURSE_SELECT",
            "TIME_UP",
            "COURSE_TIME_UP",
            "YES_NO_WINDOW",
            "COURSE_SELECT_MANAGER",
            "FUKIDASHI_MANAGER",
            "SMALL_SCORE_MANAGER",
            "GAMEDISPLAY",
            "OTASUKE_INFO",
            "PAUSEWINDOW",
            "RESULT",
            "POINT_RESULT_MULTI",
            "POINT_RESULT_DATE_FILE",
            "POINT_RESULT_DATE_FILE_FREE",
            "GOAL_MANAGER",
            "COURSE_CLEAR",
            "OTEHON_CLEAR",
            "INFO_WINDOW",
            "SELECT_CURSOR",
            "WARNING_MANAGER",
            "SEQUENCE_BG",
            "GAME_OVER",
            "MODE_SELECT",
            "DATE_FILE",
            "FILE_SELECT",
            "CONTINUE",
            "MINI_GAME_CANNON",
            "MINI_GAME_WIRE",
            "MODEL_PLAY_MANAGER",
            "MODEL_PLAY_BASE",
            "MODEL_PLAY_DATE",
            "MODEL_PLAY_ARROW",
            "MODEL_PLAY_GUIDE",
            "MESSAGE_WINDOW",
            "CHARACTER_CHANGE_SELECT_BASE",
            "CHARACTER_CHANGE_SELECT_CONTENTS",
            "CHARACTER_CHANGE_SELECT_ARROW",
            "CHARACTER_CHANGE_INDICATOR",
            "MULTI_COURSE_SELECT_CONTENTS",
            "COLLECTION_COIN_DATE",
            "CONTROLLER_INFORMATION",
            "DRAW_GAME",
            "STAFF_CREDIT_SCORE",
            "THE_END",
            "DEMO_MESSAGE",
            "LETTER_WINDOW",
            "NO ASSIGNED FUNCTION",
            "LASTACTOR_STAGE",
            "LASTACTOR"});
            this.SpriteName.Location = new System.Drawing.Point(26, 41);
            this.SpriteName.Margin = new System.Windows.Forms.Padding(4);
            this.SpriteName.Name = "SpriteName";
            this.SpriteName.Size = new System.Drawing.Size(380, 25);
            this.SpriteName.TabIndex = 16;
            this.SpriteName.SelectedIndexChanged += new System.EventHandler(this.SpriteName_SelectedIndexChanged);
            // 
            // labelSpriteName
            // 
            this.labelSpriteName.AutoSize = true;
            this.labelSpriteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelSpriteName.Location = new System.Drawing.Point(169, 21);
            this.labelSpriteName.Name = "labelSpriteName";
            this.labelSpriteName.Size = new System.Drawing.Size(90, 17);
            this.labelSpriteName.TabIndex = 18;
            this.labelSpriteName.Text = "Sprite Name:";
            // 
            // ActorNum
            // 
            this.ActorNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ActorNum.Location = new System.Drawing.Point(140, 92);
            this.ActorNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ActorNum.Maximum = new decimal(new int[] {
            749,
            0,
            0,
            0});
            this.ActorNum.Name = "ActorNum";
            this.ActorNum.Size = new System.Drawing.Size(120, 23);
            this.ActorNum.TabIndex = 0;
            this.ActorNum.ValueChanged += new System.EventHandler(this.ActorNum_ValueChanged);
            // 
            // labelSpriteNumber
            // 
            this.labelSpriteNumber.AutoSize = true;
            this.labelSpriteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelSpriteNumber.Location = new System.Drawing.Point(22, 73);
            this.labelSpriteNumber.Name = "labelSpriteNumber";
            this.labelSpriteNumber.Size = new System.Drawing.Size(103, 17);
            this.labelSpriteNumber.TabIndex = 20;
            this.labelSpriteNumber.Text = "Sprite Number:";
            // 
            // SpriteNum
            // 
            this.SpriteNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SpriteNum.Location = new System.Drawing.Point(14, 92);
            this.SpriteNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpriteNum.Maximum = new decimal(new int[] {
            749,
            0,
            0,
            0});
            this.SpriteNum.Name = "SpriteNum";
            this.SpriteNum.Size = new System.Drawing.Size(120, 23);
            this.SpriteNum.TabIndex = 19;
            this.SpriteNum.ValueChanged += new System.EventHandler(this.SpriteNum_ValueChanged);
            // 
            // labelActorNumber
            // 
            this.labelActorNumber.AutoSize = true;
            this.labelActorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelActorNumber.Location = new System.Drawing.Point(148, 73);
            this.labelActorNumber.Name = "labelActorNumber";
            this.labelActorNumber.Size = new System.Drawing.Size(99, 17);
            this.labelActorNumber.TabIndex = 3;
            this.labelActorNumber.Text = "Actor Number:";
            // 
            // labelActorIName
            // 
            this.labelActorIName.AutoSize = true;
            this.labelActorIName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelActorIName.Location = new System.Drawing.Point(274, 71);
            this.labelActorIName.Name = "labelActorIName";
            this.labelActorIName.Size = new System.Drawing.Size(132, 17);
            this.labelActorIName.TabIndex = 17;
            this.labelActorIName.Text = "Actor Intenal Name:";
            // 
            // ActorIName
            // 
            this.ActorIName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActorIName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ActorIName.FormattingEnabled = true;
            this.ActorIName.Items.AddRange(new object[] {
            "BOOT",
            "AUTO_SELECT",
            "SELECT",
            "WORLD_MAP",
            "WORLD__DEMO",
            "STAGE",
            "RESTART_CRSIN",
            "CRSIN",
            "MOVIE",
            "GAMEOVER",
            "GAME_SETUP",
            "MULTI_PLAY_COURSE_SELECT",
            "CURSOR",
            "PLAYER",
            "YOSHI",
            "WM_TEST",
            "WM_TEST",
            "BG_GM",
            "CAMERA",
            "YOSHI_FIRE",
            "SLOW_QUICK_TAG",
            "TORIDE_KOKOOPA_DEMO",
            "BOSS_KAMECK_DEMO",
            "BOSS_KOOPA_DEMO",
            "CASTLE_KOKOOPA_DEMO_ST",
            "CASTLE_KOKOOPA_DEMO_ND",
            "BOSS_KOOPA_JR_DEMO",
            "KOOPA_SHIP_FOR_CASTLE_DEMO",
            "KOOPA_JR_FOR_CASTLE_DEMO",
            "PEACH_FOR_CASTLE_DEMO",
            "KAMECK_FOR_CASTLE_DEMO",
            "LEMMY_FOOTHOLD",
            "LEMMY_FOOTHOLD_MAIN",
            "CASTLE_BOSS_DOOR",
            "CASTLE_BOSS_KEY",
            "AC_BATTLE_GAME",
            "AC_BATTLE_KINOPIO",
            "AC_BATTLE_ITEM",
            "AC_ENDING_MAIN",
            "AC_BLOCK_WIND_TAG",
            "AC_GROUPID",
            "KAWANAGARE",
            "RIVER_PAIPO",
            "RIVER_ITEM",
            "RIVER_COIN",
            "RIVER_STARCOIN",
            "RIVER_LIFT",
            "RIVER_BARREL",
            "RIVER_PUKU",
            "RIVER_PAKKUN",
            "RIVER_MGR",
            "EN_KURIBO",
            "EN_PATA_KURIBO",
            "EN_MAME_KURIBO",
            "EN_NOKONOKO",
            "EN_PATAPATA",
            "EN_MET",
            "EN_TOGEZO",
            "EN_SAKASA_TOGEZO",
            "EN_BLOCK",
            "EN_ITEM",
            "EN_STAR_COIN",
            "EN_STAR_COIN_LINE",
            "EN_STAR_COIN_VOLT",
            "AC_FLAGON",
            "AC_SWICHAND",
            "AC_SWICHOR",
            "AC_RANDSWICH",
            "AC_CHNGESWICH",
            "AC_IFSWICH",
            "AC_RNSWICH",
            "EN_BKBLOCK",
            "EN_HNSWICH",
            "EN_PSWICH",
            "EN_QSWICH",
            "EN_BOSS_KOOPA_SWITCH",
            "EN_BOSS_KOOPA_BIG_SWITCH",
            "EN_BLSWICH",
            "EN_BLPSWICH",
            "EN_BLQSWICH",
            "EN_BUBBLE",
            "EN_DOSUN",
            "EN_BIGDOSUN",
            "EN_JUGEM",
            "EN_JUGEM_COIN",
            "EN_EATJUGEM",
            "EN_JUGEM_BODY",
            "EN_TOGEMET",
            "EN_FIREBAR",
            "EN_TOGETEKKYU",
            "EN_BIG_TOGETEKKYU",
            "EN_UP_DOKAN_PAKKUN",
            "EN_DOWN_DOKAN_PAKKUN",
            "EN_RIGHT_DOKAN_PAKKUN",
            "EN_LEFT_DOKAN_PAKKUN",
            "EN_UP_DOKAN_FPAKKUN",
            "EN_DOWN_DOKAN_FPAKKUN",
            "EN_RIGHT_DOKAN_FPAKKUN",
            "EN_LEFT_DOKAN_FPAKKUN",
            "EN_JIMEN_PAKKUN",
            "EN_JIMEN_BIG_PAKKUN",
            "EN_JIMEN_FPAKKUN",
            "EN_JIMEN_BIG_FPAKKUN",
            "EN_WALK_PAKKUN",
            "ICEBALL",
            "PL_FIREBALL",
            "PAKKUN_FIREBALL",
            "BROS_FIREBALL",
            "BOOMERANG",
            "EN_HELPOS",
            "EN_FIREBROS",
            "EN_BOOMERANGBROS",
            "EN_HAMMERBROS",
            "EN_ICEBROS",
            "EN_LIFT_HAMMERBROS",
            "HAMMER",
            "EN_HIMANBROS",
            "MEGA_HAMMER",
            "BROS_ICEBALL",
            "EN_BOYON",
            "EN_REMOCON_TORIMOCHI",
            "TAG_WIND",
            "TAG_THUNDER",
            "TAG_WATER",
            "EN_AUTOSCR",
            "OBJ_GRASS",
            "EN_ENV",
            "EN_KILLER",
            "EN_SEARCH_KILLER",
            "EN_MAGNUM_KILLER",
            "EN_SEARCH_MAGNUM_KILLER",
            "EN_BASABASA",
            "WAKI_PARABOM",
            "EN_BOMHEI",
            "EN_PARA_BOMHEI",
            "EN_MECHA_KOOPA",
            "EN_MOUSE",
            "EN_GHOST_JUGEM",
            "DOKAN_WAKIDASHI",
            "EN_CRASHER",
            "AC_WAKILIFT",
            "EN_BIRIKYU",
            "EN_LINE_BIRIKYU",
            "EN_BIRIKYU_MAKER",
            "EN_CHOROBON",
            "EN_SANBO",
            "EN_SANBO_PARTS",
            "EN_SANBO_EL",
            "EN_GURUGURU",
            "EN_GESSO",
            "EN_BARAMAKI_GESSO",
            "EN_GOALPOLE",
            "EN_GESSO_CHILD",
            "BARNAR_MGR",
            "EN_SYNCRO_BARNAR",
            "EN_BARNAR",
            "EN_LARGE_BARNAR",
            "EN_PUKUPUKU_PARENT",
            "AC_TEAM_PUKUPUKU",
            "EN_PUKUPUKU",
            "EN_TOGEPUKU",
            "EN_MIDDLE_PUKU",
            "EN_PUKUCOIN",
            "EN_KARON",
            "EN_BIGKARON",
            "EN_KARON_HEAD",
            "EN_REVERSE",
            "EN_WAKI_JUGEM",
            "EN_WIRE_TURN",
            "EN_BIG_WIRE_TURN",
            "EN_NET_NOKONOKO_LR",
            "EN_NET_NOKONOKO_UD",
            "BIGHANA_MGR",
            "HANA_MOUNTAIN",
            "EN_HANACHAN",
            "EN_BIG_HANACHAN",
            "EN_TERESA",
            "EN_BIG_TERESA",
            "EN_CROW",
            "EN_BIGPILE_UNDER",
            "EN_BIGPILE_UPPER",
            "EN_BIGPILE_RIGHT",
            "EN_BIGPILE_LEFT",
            "EN_SUPER_BIGPILE_RIGHT",
            "EN_SUPER_BIGPILE_LEFT",
            "EN_GOKUBUTO_BIGPILE_UNDER",
            "EN_GOKUBUTO_BIGPILE_UPPER",
            "EN_MORTON_BIGPILE",
            "EN_YAJIRUSHI",
            "EN_WANWAN",
            "EN_WANWAN_PILE",
            "EN_JUMPPUKU",
            "EN_IGAPUKU",
            "EN_WAKI_IGAPUKU",
            "EN_FIRESNAKE",
            "EN_BOSS_KAMECK",
            "EN_SLIP_PENGUIN",
            "WAKI_SLIP_PENGUIN",
            "EN_SLIP_PENGUIN",
            "SLIP_PENGUIN_GLASSES",
            "EN_IGA_KURIBO",
            "EN_WATERSTREAM",
            "AWA",
            "DUMMY_DOOR_PARENT",
            "DUMMY_DOOR_CHILD",
            "DUMMY_DOOR",
            "NOBORIBOU_OBAKE",
            "UNTEI_ROPE",
            "REMO_DOOR",
            "REMO_SLIDE_DOOR",
            "BRANCH",
            "BG_CENTER",
            "KAMECK_MAGIC",
            "SINKDOKAN_UP",
            "SINKDOKAN_DOWN",
            "SINKDOKAN_LEFT",
            "SINKDOKAN_RIGHT",
            "FLYDOKAN_UP",
            "FLYDOKAN_DOWN",
            "FLYDOKAN_LEFT",
            "FLYDOKAN_RIGHT",
            "EN_HATENA_BALLOON",
            "EN_ONEWAY_GATE",
            "EN_PATABLOCK",
            "EN_KERONPA",
            "KERONPA_FIRE",
            "AC_NEXTGOTO_BLOCK",
            "EN_BAKUBAKU",
            "EN_DOOR",
            "EN_SWITCHDOOR",
            "EN_OBAKEDOOR",
            "EN_TORIDEDOOR",
            "EN_CASTLEDOOR",
            "EN_KOOPADOOR",
            "AC_REVERSEBLOCK",
            "CHUKAN_POINT",
            "EN_MAX_UE_LEFT",
            "EN_MAX_UE_RIGHT",
            "EN_MAX_UE_LEFT",
            "EN_MAX_UE_RIGHT",
            "EN_ZOOM",
            "EN_BOSS_LARRY",
            "EN_BOSS_WENDY",
            "EN_BOSS_IGGY",
            "EN_BOSS_LEMMY",
            "EN_BOSS_MORTON",
            "EN_BOSS_ROY",
            "EN_BOSS_LUDWIG",
            "EN_BOSS_CASTLE_LARRY",
            "EN_BOSS_CASTLE_ROY",
            "EN_BOSS_CASTLE_WENDY",
            "EN_BOSS_CASTLE_IGGY",
            "CASTLE_LEMMY_BALL",
            "EN_BOSS_CASTLE_LEMMY",
            "EN_BOSS_CASTLE_MORTON",
            "OBJ_LUDWIG",
            "EN_BOSS_CASTLE_LUDWIG",
            "EN_BOSS_KOOPA",
            "EN_BOSS_KOOPA_DEMO_KAMECK",
            "EN_BOSS_KOOPA_DEMO_PEACH",
            "AC_WAKI_KOOPA_FIRE",
            "KOOPA_FIRE",
            "LARRY_FIRE",
            "KOKOOPA_RING",
            "KOKOOPA_BALL",
            "KOKOOPA_THREEWAY_BLITZ",
            "LEMMY_BALL",
            "CASTLE_LEMMY_THROW_BALL",
            "OBJ_IGGY_SLED",
            "OBJ_IGGY_WANWAN",
            "OBJ_MORTON",
            "OBJ_ROY",
            "OBJ_LARRY",
            "OBJ_WENDY",
            "AC_BOSS_KOOPA_SCAFFOLD",
            "AC_BOSS_KOOPA_RUBBLE",
            "AC_BOSS_KOOPA_BG_EFFECT",
            "CASTLE_LUDWIG_BLITZ",
            "CASTLE_LUDWIG_BLITZ_MGR",
            "WAKI_KOKOOPA_FIRE",
            "FALL_FIRE",
            "WAKI_FIRE",
            "FIRE_BLITZ",
            "KOKOOPA_SEARCH_FIRE",
            "EN_UNIZOO",
            "EN_UNIRA",
            "EN_KANIBO",
            "EN_KANITAMA",
            "EN_KOPONE",
            "EN_AKOYA",
            "EN_MIDDLE_KURIBO",
            "EN_LARGE_KURIBO",
            "EN_BEANS_KURIBO",
            "AC_STRONGBOX",
            "EN_REMOCON_CANNON",
            "WAKI_TOGETEKKYU",
            "JR_CLOWN_A",
            "JR_CLOWN_B",
            "JR_CLOWN_C",
            "JR_CLOWN_FOR_PLAYER",
            "FLOOR_JR_A",
            "FLOOR_JR_B",
            "FLOOR_JR_C",
            "FLOOR_JR_C_MGR",
            "BOMB_JR_C",
            "EN_BOSS_KOOPA_JR_A",
            "EN_BOSS_KOOPA_JR_B",
            "EN_BOSS_KOOPA_JR_C",
            "JR_FIRE",
            "JR_FLOOR_FIRE",
            "JR_FLOOR_FIRE_MGR",
            "JR_CLOWN_FOR_JR_C_DEMO",
            "KAMECK_FOR_AIRSHIP_DEMO",
            "PEACH_FOR_AIRSHIP_DEMO",
            "KOOPA_SHIP_FOR_AIRSHIP_DEMO",
            "EN_EATCOIN",
            "AC_WAKI_KILLER",
            "WAKI_KERONPA",
            "AC_WAKI_PUKUPUKU",
            "BELT_NEEDLE",
            "INTERMITTENT",
            "MIST_INTERMITTENT",
            "YOGAN_INTERMITTENT",
            "EN_IBARAMUSHI",
            "WAKI_ANKOH",
            "EN_CHOCHIN_ANKOH",
            "EN_MISTMAN",
            "EN_TESTMAN",
            "EN_CLOUD",
            "AC_ITEM_KEY",
            "AC_YOSHI_EGG",
            "EN_WATERPAIPO",
            "EN_WATERPAKKUN",
            "FOO_BALL",
            "MT_HANACHAN",
            "EN_LR_STOP_UP",
            "EN_LR_STOP_DW",
            "EN_ROT_PAKKUN",
            "EN_POLTER",
            "EN_ICICLE",
            "WALLINSECT_MGR",
            "EN_WALLINSECT",
            "EN_LANDBARREL",
            "EN_IWAO",
            "IWAO_ROCK",
            "KAZAN_MGR",
            "KAZAN_ROCK",
            "EN_CANNON_BULLET",
            "EN_CHOROPU",
            "EN_MANHOLE_CHOROPU",
            "CHOROPOO_SHADOW",
            "MINI_GAME_BALLOON",
            "MINI_GAME_BALLOON_STICK",
            "EN_JELLY_FISH",
            "MINI_GAME_WIRE_MESH",
            "MINI_GAME_GUN_BATTERY_MGR",
            "MINI_GAME_GUN_BATTERY_MGR_OBJ",
            "MINI_GAME_WIRE_MESH_MGR",
            "MINI_GAME_WIRE_MESH_MGR_OBJ",
            "PEACH_CASTLE_SEQUENCE_MGR",
            "PEACH_CASTLE_SEQUENCE_MGR_OBJ",
            "PEACH_CASTLE_BLOCK",
            "MINI_GAME_KINOPIO",
            "AC_KANBAN_ARROW",
            "AC_WATER_BUBBLE",
            "EN_BUBBLE_CONTROL",
            "AC_WAKI_WOODBOX",
            "AC_AUTOSCROOL_SWICH",
            "AC_ROTATION_GHOST_PARENT",
            "EN_ROTATION_GHOST",
            "SHIP_WINDOW",
            "EN_MADOPU",
            "SPANA",
            "EN_GABON",
            "GABON_ROCK",
            "MANHOLE",
            "BGM_INTERLOCKING_DUMMY_BLOCK",
            "BGM_INTERLOCKING_DUMMY_BLOCK_MGR",
            "EN_KING_KILLER",
            "EN_WATER_BUBBLE_BULLET",
            "EN_FRUIT",
            "OBJ_SPARKS",
            "OBJ_SNOW",
            "TAG_SCROLL",
            "AC_BLOCK_GROUP",
            "AC_BLOCK_ONEUP",
            "AC_BLOCK_COIN",
            "AC_WAKI_SEARCH_MAGKILLER",
            "EN_TOBIPUKU",
            "AC_WAKI_TOBIPUKU",
            "NEEDLE_FOR_KOOPA_JR_B",
            "TOP_BG_FOR_CASTLE_LUDWIG",
            "MIDDLE_BG_FOR_CASTLE_LUDWIG",
            "BOTTOM_BG_FOR_CASTLE_LUDWIG",
            "MD_ACTOR",
            "MD_CAMERA",
            "EN_CLOUDLT",
            "UNIT_RAIL",
            "UNIT_CHIKUWA",
            "OBJ_SEAWEED",
            "TAG_ENVSOUND",
            "EN_COIN",
            "EN_COIN_JUGEM",
            "EN_COIN_JUMP",
            "EN_COIN_FLOOR",
            "EN_COIN_VOLT",
            "EN_COIN_WIND",
            "EN_BLUE_COIN",
            "EN_COIN_WATER",
            "EN_REDCOIN",
            "EN_GREENCOIN",
            "ICE_ACTOR",
            "AC_LIGHT_BLOCK",
            "AC_PROP_BLOCK",
            "ENEMY_ICE",
            "PLAYER_ICE",
            "SLIDE_BLOCK",
            "POW_BLOCK",
            "BLOCK_TARU",
            "OBJ_CENTER",
            "OBJ_CENTER",
            "EN_LIFT_ROTATION_FULL",
            "LIFT_ROTATION_FULL_CHIKA",
            "LIFT_ROTATION_FULL_KINOKO",
            "LIFT_ROTATION_FULL_COLOR",
            "CAGE_BLOCK",
            "LIFT_ZEN_HAMMER",
            "LIFT_ZEN_SUISYA",
            "LIFT_ZEN_KAITEN_KANAAMI",
            "MOUSE_HOLE",
            "KATAMUKIYUKA",
            "LIFT_TORIDE_ROLL",
            "AC_LIFT_RIDE_HMOVE",
            "AC_LIFT_OBJBG_VMOVE",
            "AC_LIFT_OBJBG_HMOVE",
            "AC_LIFT_OBJBG_HMOVE_BIG",
            "EN_OBJ_POL",
            "EN_OBJ_POL_TORIDE",
            "EN_OBJ_POL_NEEDLE_L",
            "EN_OBJ_POL_NEEDLE_R",
            "EN_OBJ_POL_NEEDLE_LR",
            "EN_OBJ_POL_NEEDLE_U",
            "EN_OBJ_POL_NEEDLE_D",
            "EN_OBJ_POL_NEEDLE_UD",
            "LIFT_ZEN_TOGE",
            "LIFT_ZEN_SHIRO_YOGAN",
            "LIFT_ZEN_KAIHEI",
            "LIFT_DOKAN",
            "EN_PAIR_OBJ_PARENT",
            "EN_PAIR_OBJ_CHILD",
            "LIFT_ZEN_SHIRO",
            "EN_PAIR_OBJ_CHILD_TORIDE",
            "WAKI_ICE_ASHIBA",
            "WAKI_ICE_ASHIBA_WATER",
            "ICE_ASHIBA",
            "ICE_ASHIBA_WATER",
            "ICE_ASHIBA_RAIL",
            "AC_LIFT_RIDE_VMOVE",
            "AC_LIFT_SEESAW",
            "AC_LIFT_FALL",
            "AC_LIFT_REMOCON_SEESAW",
            "EN_LIFT_WHEEL",
            "AC_LIFT_BALANCE",
            "AC_LIFT_REMOCON_BALANCE_CLINCH",
            "AC_LIFT_REMOCON_BALANCE",
            "AC_LIFT_REMOCON_XLINE",
            "EN_LIFT_REMOCON_TRPLN",
            "EN_TRPLN_WALL",
            "EN_CHIKUWA_BLOCK",
            "EN_CLIFF_CHIKUWA_BLOCK",
            "EN_KILLER_HOUDAI",
            "EN_MAGNUM_KILLER_HOUDAI",
            "AC_WAKILIFT_STEP",
            "AC_LINE_LIFT",
            "LINE_SPIN_LIFT",
            "PALM_TREE",
            "NICE_BOAT",
            "LINE_KINOKO_BLOCK",
            "LADDER",
            "TARZAN_TSUTA",
            "TARZAN_IVY",
            "EN_LIFT_ROTATION_HALF",
            "LIFT_HURIKO_CENTER",
            "LIFT_HURIKO",
            "AC_LIFT_RIDEMOVE",
            "EN_LIFT_BURANKO",
            "AC_LIFT_WATERWHEEL",
            "EN_RAIL_POLYGON",
            "EN_RAIL_POLY_ICE",
            "EN_RAIL_POLY_PARENT",
            "EN_RAIL_POLY_CHILD",
            "FREEFALL",
            "EN_GURA_ROCK",
            "EN_GURA_YUKA",
            "EN_KAITEN_HOUDAI",
            "EN_REDRING",
            "EN_BARREL",
            "EN_JUMPDAI",
            "EN_BIG_HNSWICH",
            "EN_BIGBLOCK",
            "EN_SNAKEBLOCK",
            "EN_MARUTA",
            "OBJ_KAMECK",
            "AC_LIFT_SPINROTATION",
            "AC_LIFT_SPINROTATION_SYNC",
            "EN_RULETBLOCK",
            "AC_LIFT_SCALES",
            "AC_LIFT_SCALES_STEP",
            "EN_TARZANROPE",
            "AC_LIFT_BOSS_REMOCON_SEESAW",
            "AC_CHENGE_BLOCK",
            "EN_FIXATION_ICICLE",
            "EN_OBJ_HATENA_BLOCK",
            "EN_OBJ_HATENAB_BLOCK",
            "EN_OBJ_RENGA_BLOCK",
            "EN_OBJ_CLEAR_BLOCK",
            "AC_OBJ_CLEAR_BLOCK",
            "EN_HATENA_BLOCK_LINE",
            "EN_RENGA_BLOCK_LINE",
            "EN_BLOCK_HATENA_WATER",
            "EN_BLOCK_SOROBAN",
            "EN_BLOCK_STAFFROLL",
            "ELASTIC_KINOKO_PARENT",
            "ELASTIC_KINOKO",
            "EN_WHITE_BLOCK",
            "MANTA_MGR",
            "MANTA_MGR",
            "MANTA",
            "AC_LIFT_SLIDE_KINOKO",
            "EN_ROTATION_BLOCK",
            "EN_COIN_ANGLE",
            "ROT_DOKAN",
            "EN_BLOCK_HATENA_ANGLE",
            "EN_BLOCK_RENGA_ANGLE",
            "AC_WIRE_CIRCLE",
            "AC_WIRE_REMOCON",
            "AC_LIFT_ICE_SPRING",
            "ICELUMP",
            "ICECUBE",
            "EN_WOODBOX",
            "EN_PATAMET",
            "EN_BIG_PATAMET",
            "NUT",
            "EN_BIG_MET",
            "EN_GAKE_NOKO",
            "AC_DOKAN_CANNON",
            "AC_SHIP_CANNON",
            "AC_ROT_CANNON",
            "AC_ROT_DOKAN_CANNON",
            "ROT_BARNAR",
            "CIRCLE_RIGHT",
            "BLOCK_LIGHT",
            "HAND_RIGHT",
            "EN_BIG_ICICLE",
            "AC_WATER_BUBBLE_PARENT",
            "AC_WATER_BUBBLE_CANNON",
            "EN_KILLER_HOUDAI_SLIDE",
            "EN_BLACK_PAKKUN",
            "TORCHILIGHT",
            "EN_BLOCK_CLOUD",
            "AC_WIRE_MOVE",
            "OBJ_FRUITTREE",
            "EN_BOUNCE_BALL",
            "EN_BLOCK_HATENA_PLAYER",
            "EN_BLOCK_RENGA_PLAYER",
            "AC_FREEZER",
            "AC_WIRE_FOOTHOLD",
            "EN_ITEM_IVY",
            "TARZAN_ROPE",
            "CANNON_PIPE",
            "KINOKO_LIFT_PARENT",
            "KINOKO_LIFT",
            "OBJ_SPIN_PARENT",
            "OBJ_SPIN_CHILD",
            "OBJ_SPIN_ASHIBA",
            "SPIN_WIRE",
            "WARP_CANNON",
            "OBJ_KINOKO",
            "ZOOM_PIPE",
            "ZOOM_PIPE_DOWN",
            "OBJ_PIPE_UP",
            "OBJ_PIPE_UP_NG",
            "OBJ_PIPE_DOWN",
            "OBJ_PIPE_RIGHT",
            "OBJ_PIPE_LEFT",
            "LIFT_DOWN_ON",
            "OBJ_MOVE_ON_GHOST",
            "LIFT_DOWN_ON_NORMAL",
            "LIFT_RIDE_OFF",
            "LINE_TRAIN",
            "REMO_LINE_LIFT",
            "WATER_LIFT",
            "AC_NICE_COIN",
            "AC_NICE_COIN_REGULAR",
            "EN_BLOCK_HELP",
            "FAR_BG",
            "AC_BG_WATER",
            "AC_BG_LAVA",
            "AC_BG_POISON",
            "AC_BG_SAND",
            "AC_BG_CLOUD",
            "AC_BG_MOYA",
            "AC_WATERALL_RAIL",
            "EN_BLUR",
            "MASK",
            "DTEST",
            "AC_WATER_MOVE",
            "AC_WATER_MOVE_REGULAR",
            "AC_WATER_XINFINITE_MOVE",
            "AC_FLOOR_GYRATION",
            "AC_FLOOR_HOLE_DOKAN",
            "AC_FLOOR_DOKAN_EIGHT",
            "AC_GEAR_GYRATION",
            "AC_SHIP_GEAR",
            "AC_BIGSHELL",
            "EN_BOSS_KOOPA_DEMO_CAGE",
            "AC_STAND",
            "AC_HOUSE_LIGHT",
            "AC_LIGHT_WATER",
            "AC_COPYRIGHT",
            "WII_STRAP",
            "WM_CS_SEQ_MNG",
            "WORLD_CAMERA",
            "WM_MAP",
            "WM_IBARA",
            "WM_ANTLION_MNG",
            "WM_CASTLE",
            "WM_TOWER",
            "WM_PEACH_CASTLE",
            "WM_KILLER",
            "WM_KILLERBULLET",
            "WM_SINKSHIP",
            "WM_SWITCH",
            "WM_START",
            "WM_KINOKO_BASE",
            "WM_KINOKO_RED",
            "WM_KINOKO_UP",
            "WM_KINOKO_STAR",
            "WM_COURSE",
            "WM_STOP",
            "WM_TORIDE",
            "WM_GHOST",
            "WM_DOKAN",
            "WM_CANNON",
            "WM_KOOPASHIP",
            "WM_BOSS_BASE",
            "WM_BOSS_LARRY",
            "WM_BOSS_ROY",
            "WM_BOSS_WENDY",
            "WM_BOSS_IGGY",
            "WM_BOSS_LEMMY",
            "WM_BOSS_MORTON",
            "WM_BOSS_LUDWIG",
            "WM_BOSS_KAMECK",
            "WM_ANTLION",
            "WM_KURIBO",
            "WM_PUKU",
            "WM_PAKKUN",
            "WM_BROS",
            "WM_JUGEM",
            "WM_PLAYER",
            "WM_SUBPLAYER",
            "WM_NOTE",
            "WM_TREASURESHIP",
            "WM_DIRECTOR",
            "WM_GRID",
            "WM_ISLAND",
            "WM_ITEM",
            "WM_CS_W_PALM",
            "WM_SURRENDER",
            "WM_KOOPA_CASTLE",
            "WM_ANCHOR",
            "WM_PAKKUNHEAD",
            "WM_CLOUD",
            "WM_SMALLCLOUD",
            "WM_KOOPAJR",
            "WM_PEACH",
            "WM_BOARD",
            "WM_BUBBLE",
            "WM_KINOBALLOON",
            "WM_SANDPILLAR",
            "WM_YOGANPILLAR",
            "WM_KINOPIO",
            "WM_DANCE_PAKKUN",
            "WM_DOKANROUTE",
            "WM_HANACHAN",
            "WM_TOGEZO",
            "WM_MANTA",
            "WM_TERESA",
            "WORLD_SELECT",
            "WORLD_SELECT_GUIDE",
            "COLLECTION_COIN_BASE",
            "COLLECTION_COIN",
            "COURSE_SELECT_MENU",
            "NUMBER_OF_PEOPLE_CHANGE",
            "STOCK_ITEM",
            "STOCK_ITEM_SHADOW",
            "EASY_PAIRING",
            "WM_D_PLAYER",
            "EVENT_OPENING_TITLE",
            "SELECT_PLAYER",
            "MULTI_COURSE_SELECT",
            "TIME_UP",
            "COURSE_TIME_UP",
            "YES_NO_WINDOW",
            "COURSE_SELECT_MANAGER",
            "FUKIDASHI_MANAGER",
            "SMALL_SCORE_MANAGER",
            "GAMEDISPLAY",
            "OTASUKE_INFO",
            "PAUSEWINDOW",
            "RESULT",
            "POINT_RESULT_MULTI",
            "POINT_RESULT_DATE_FILE",
            "POINT_RESULT_DATE_FILE_FREE",
            "GOAL_MANAGER",
            "COURSE_CLEAR",
            "OTEHON_CLEAR",
            "INFO_WINDOW",
            "SELECT_CURSOR",
            "WARNING_MANAGER",
            "SEQUENCE_BG",
            "GAME_OVER",
            "MODE_SELECT",
            "DATE_FILE",
            "FILE_SELECT",
            "CONTINUE",
            "MINI_GAME_CANNON",
            "MINI_GAME_WIRE",
            "MODEL_PLAY_MANAGER",
            "MODEL_PLAY_BASE",
            "MODEL_PLAY_DATE",
            "MODEL_PLAY_ARROW",
            "MODEL_PLAY_GUIDE",
            "MESSAGE_WINDOW",
            "CHARACTER_CHANGE_SELECT_BASE",
            "CHARACTER_CHANGE_SELECT_CONTENTS",
            "CHARACTER_CHANGE_SELECT_ARROW",
            "CHARACTER_CHANGE_INDICATOR",
            "MULTI_COURSE_SELECT_CONTENTS",
            "COLLECTION_COIN_DATE",
            "CONTROLLER_INFORMATION",
            "DRAW_GAME",
            "STAFF_CREDIT_SCORE",
            "THE_END",
            "DEMO_MESSAGE",
            "LETTER_WINDOW",
            "DUMMY_ACTOR",
            "LASTACTOR_STAGE",
            "LASTACTOR"});
            this.ActorIName.Location = new System.Drawing.Point(266, 92);
            this.ActorIName.Margin = new System.Windows.Forms.Padding(4);
            this.ActorIName.Name = "ActorIName";
            this.ActorIName.Size = new System.Drawing.Size(149, 25);
            this.ActorIName.TabIndex = 15;
            this.ActorIName.SelectedIndexChanged += new System.EventHandler(this.ActorIName_SelectedIndexChanged);
            // 
            // cppfilename
            // 
            this.cppfilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cppfilename.Location = new System.Drawing.Point(266, 124);
            this.cppfilename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cppfilename.Name = "cppfilename";
            this.cppfilename.Size = new System.Drawing.Size(149, 23);
            this.cppfilename.TabIndex = 4;
            this.cppfilename.TextChanged += new System.EventHandler(this.cppfilename_TextChanged);
            // 
            // labelIGCustomSpriteName
            // 
            this.labelIGCustomSpriteName.AutoSize = true;
            this.labelIGCustomSpriteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelIGCustomSpriteName.Location = new System.Drawing.Point(61, 185);
            this.labelIGCustomSpriteName.Name = "labelIGCustomSpriteName";
            this.labelIGCustomSpriteName.Size = new System.Drawing.Size(199, 17);
            this.labelIGCustomSpriteName.TabIndex = 9;
            this.labelIGCustomSpriteName.Text = "In-Game Custom Sprite Name:";
            this.labelIGCustomSpriteName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCustomSpriteName
            // 
            this.labelCustomSpriteName.AutoSize = true;
            this.labelCustomSpriteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelCustomSpriteName.Location = new System.Drawing.Point(119, 157);
            this.labelCustomSpriteName.Name = "labelCustomSpriteName";
            this.labelCustomSpriteName.Size = new System.Drawing.Size(141, 17);
            this.labelCustomSpriteName.TabIndex = 8;
            this.labelCustomSpriteName.Text = "Custom Sprite Name:";
            this.labelCustomSpriteName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelCPPFilename
            // 
            this.labelCPPFilename.AutoSize = true;
            this.labelCPPFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelCPPFilename.Location = new System.Drawing.Point(162, 129);
            this.labelCPPFilename.Name = "labelCPPFilename";
            this.labelCPPFilename.Size = new System.Drawing.Size(98, 17);
            this.labelCPPFilename.TabIndex = 5;
            this.labelCPPFilename.Text = "C++ Filename:";
            this.labelCPPFilename.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ingamespritename
            // 
            this.ingamespritename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ingamespritename.Location = new System.Drawing.Point(266, 181);
            this.ingamespritename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ingamespritename.Name = "ingamespritename";
            this.ingamespritename.Size = new System.Drawing.Size(149, 23);
            this.ingamespritename.TabIndex = 7;
            this.ingamespritename.TextChanged += new System.EventHandler(this.ingamespritename_TextChanged);
            // 
            // customspritename
            // 
            this.customspritename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.customspritename.Location = new System.Drawing.Point(266, 153);
            this.customspritename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customspritename.Name = "customspritename";
            this.customspritename.Size = new System.Drawing.Size(149, 23);
            this.customspritename.TabIndex = 6;
            this.customspritename.TextChanged += new System.EventHandler(this.customspritename_TextChanged);
            // 
            // Generate
            // 
            this.Generate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Generate.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(331, 318);
            this.Generate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(151, 38);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.toolsToolStrip,
            this.HelpToolstrip,
            this.aboutToolStrip});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(819, 28);
            this.mainMenuStrip.TabIndex = 41;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripItem,
            this.saveAsToolStripItem,
            this.fileToolStripSeparator,
            this.copyToolStripItem});
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(46, 24);
            this.fileToolStrip.Text = "File";
            // 
            // newToolStripItem
            // 
            this.newToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripItem.Image")));
            this.newToolStripItem.Name = "newToolStripItem";
            this.newToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripItem.Text = "New";
            this.newToolStripItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveAsToolStripItem
            // 
            this.saveAsToolStripItem.Enabled = false;
            this.saveAsToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripItem.Image")));
            this.saveAsToolStripItem.Name = "saveAsToolStripItem";
            this.saveAsToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripItem.Size = new System.Drawing.Size(224, 26);
            this.saveAsToolStripItem.Text = "Save As...";
            this.saveAsToolStripItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // fileToolStripSeparator
            // 
            this.fileToolStripSeparator.Name = "fileToolStripSeparator";
            this.fileToolStripSeparator.Size = new System.Drawing.Size(221, 6);
            // 
            // copyToolStripItem
            // 
            this.copyToolStripItem.Enabled = false;
            this.copyToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripItem.Image")));
            this.copyToolStripItem.Name = "copyToolStripItem";
            this.copyToolStripItem.ShortcutKeyDisplayString = "";
            this.copyToolStripItem.Size = new System.Drawing.Size(224, 26);
            this.copyToolStripItem.Text = "Copy to Clipboard";
            this.copyToolStripItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // toolsToolStrip
            // 
            this.toolsToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multiKamekToolStripItem,
            this.hexCalculatorToolStripItem,
            this.toolsToolStripSeparator,
            this.mapfileToolToolStripMenuItem,
            this.sub2AddressToolStripItem});
            this.toolsToolStrip.Name = "toolsToolStrip";
            this.toolsToolStrip.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStrip.Text = "Tools";
            // 
            // hexCalculatorToolStripItem
            // 
            this.hexCalculatorToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("hexCalculatorToolStripItem.Image")));
            this.hexCalculatorToolStripItem.Name = "hexCalculatorToolStripItem";
            this.hexCalculatorToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.hexCalculatorToolStripItem.Size = new System.Drawing.Size(266, 26);
            this.hexCalculatorToolStripItem.Text = "Hex Calculator";
            this.hexCalculatorToolStripItem.Click += new System.EventHandler(this.hexCalculatorToolStripMenuItem_Click);
            // 
            // mapfileToolToolStripMenuItem
            // 
            this.mapfileToolToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mapfileToolToolStripMenuItem.Image")));
            this.mapfileToolToolStripMenuItem.Name = "mapfileToolToolStripMenuItem";
            this.mapfileToolToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.mapfileToolToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.mapfileToolToolStripMenuItem.Text = "Mapfile Tool";
            this.mapfileToolToolStripMenuItem.Click += new System.EventHandler(this.mapfileToolToolStripMenuItem_Click);
            // 
            // HelpToolstrip
            // 
            this.HelpToolstrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getAnExampleToolStripItem});
            this.HelpToolstrip.Name = "HelpToolstrip";
            this.HelpToolstrip.Size = new System.Drawing.Size(55, 24);
            this.HelpToolstrip.Text = "Help";
            // 
            // getAnExampleToolStripItem
            // 
            this.getAnExampleToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("getAnExampleToolStripItem.Image")));
            this.getAnExampleToolStripItem.Name = "getAnExampleToolStripItem";
            this.getAnExampleToolStripItem.ShortcutKeyDisplayString = "Crtl+E";
            this.getAnExampleToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.getAnExampleToolStripItem.Size = new System.Drawing.Size(246, 26);
            this.getAnExampleToolStripItem.Text = "Get an example";
            this.getAnExampleToolStripItem.Click += new System.EventHandler(this.getAnExampleToolStripMenuItem_Click);
            // 
            // aboutToolStrip
            // 
            this.aboutToolStrip.Name = "aboutToolStrip";
            this.aboutToolStrip.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStrip.Text = "About";
            this.aboutToolStrip.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // sub2AddressToolStripItem
            // 
            this.sub2AddressToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("sub2AddressToolStripItem.Image")));
            this.sub2AddressToolStripItem.Name = "sub2AddressToolStripItem";
            this.sub2AddressToolStripItem.Size = new System.Drawing.Size(266, 26);
            this.sub2AddressToolStripItem.Text = "Sub2Address";
            this.sub2AddressToolStripItem.Click += new System.EventHandler(this.sub2AddressToolStripItem_Click);
            // 
            // multiKamekToolStripItem
            // 
            this.multiKamekToolStripItem.Image = ((System.Drawing.Image)(resources.GetObject("multiKamekToolStripItem.Image")));
            this.multiKamekToolStripItem.Name = "multiKamekToolStripItem";
            this.multiKamekToolStripItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.multiKamekToolStripItem.Size = new System.Drawing.Size(266, 26);
            this.multiKamekToolStripItem.Text = "MultiKamek";
            this.multiKamekToolStripItem.Click += new System.EventHandler(this.multiKamekToolStripItem_Click);
            // 
            // toolsToolStripSeparator
            // 
            this.toolsToolStripSeparator.Name = "toolsToolStripSeparator";
            this.toolsToolStripSeparator.Size = new System.Drawing.Size(263, 6);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(819, 835);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "NewerSMBW Hook Generator v1.8";
            this.Load += new System.EventHandler(this.Main_Load);
            this.SSGroupBox.ResumeLayout(false);
            this.SSGroupBox.PerformLayout();
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.SIGroupBox.ResumeLayout(false);
            this.SIGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActorNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteNum)).EndInit();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox SSGroupBox;
        private System.Windows.Forms.NumericUpDown ActorNum;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label labelActorNumber;
        private System.Windows.Forms.TextBox cppfilename;
        private System.Windows.Forms.Label labelCPPFilename;
        private System.Windows.Forms.TextBox customspritename;
        private System.Windows.Forms.TextBox ingamespritename;
        private System.Windows.Forms.Label labelCustomSpriteName;
        private System.Windows.Forms.Label labelIGCustomSpriteName;
        private System.Windows.Forms.CheckBox spritefileinfo;
        private System.Windows.Forms.TextBox spritefileinfotarget;
        private System.Windows.Forms.Label labelTargetFunction;
        private System.Windows.Forms.ComboBox ActorIName;
        private System.Windows.Forms.ComboBox SpriteName;
        private System.Windows.Forms.Label labelActorIName;
        private System.Windows.Forms.Label labelSpriteName;
        private System.Windows.Forms.Label labelSpriteNumber;
        private System.Windows.Forms.NumericUpDown SpriteNum;
        private System.Windows.Forms.Label labelXPos;
        private System.Windows.Forms.TextBox SSIXPos;
        private System.Windows.Forms.CheckBox isSSI;
        private System.Windows.Forms.Label labelYPos;
        private System.Windows.Forms.TextBox SSIYPos;
        private System.Windows.Forms.Label labelDDX2;
        private System.Windows.Forms.TextBox SSIDDX2;
        private System.Windows.Forms.Label labelDDX1;
        private System.Windows.Forms.TextBox SSIDDX1;
        private System.Windows.Forms.Label labelDDY2;
        private System.Windows.Forms.TextBox SSIDDY2;
        private System.Windows.Forms.Label labelDDY1;
        private System.Windows.Forms.TextBox SSIDDY1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label logs;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolstrip;
        private System.Windows.Forms.ToolStripMenuItem getAnExampleToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStrip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem hexCalculatorToolStripItem;
        private System.Windows.Forms.GroupBox SIGroupBox;
        private System.Windows.Forms.ToolStripMenuItem mapfileToolToolStripMenuItem;
        private System.Windows.Forms.RadioButton isUniversalHook;
        private System.Windows.Forms.RadioButton isNormalHook;
        private System.Windows.Forms.ToolStripSeparator fileToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem sub2AddressToolStripItem;
        private System.Windows.Forms.ToolStripMenuItem multiKamekToolStripItem;
        private System.Windows.Forms.ToolStripSeparator toolsToolStripSeparator;
    }
}

