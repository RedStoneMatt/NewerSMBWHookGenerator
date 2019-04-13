namespace NewerSMBWHookGenerator
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
            this.ActorNum = new System.Windows.Forms.NumericUpDown();
            this.Generate = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cppfilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customspritename = new System.Windows.Forms.TextBox();
            this.ingamespritename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.example = new System.Windows.Forms.Button();
            this.spritefileinfo = new System.Windows.Forms.CheckBox();
            this.spritefileinfotarget = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ActorNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ActorNum
            // 
            this.ActorNum.Location = new System.Drawing.Point(332, 10);
            this.ActorNum.Margin = new System.Windows.Forms.Padding(2);
            this.ActorNum.Maximum = new decimal(new int[] {
            749,
            0,
            0,
            0});
            this.ActorNum.Name = "ActorNum";
            this.ActorNum.Size = new System.Drawing.Size(90, 20);
            this.ActorNum.TabIndex = 0;
            this.ActorNum.ValueChanged += new System.EventHandler(this.ActorNum_ValueChanged);
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(332, 103);
            this.Generate.Margin = new System.Windows.Forms.Padding(2);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(90, 31);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(9, 149);
            this.Output.Margin = new System.Windows.Forms.Padding(2);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(738, 330);
            this.Output.TabIndex = 2;
            this.Output.TextChanged += new System.EventHandler(this.Output_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Actor Number:";
            // 
            // cppfilename
            // 
            this.cppfilename.Location = new System.Drawing.Point(332, 33);
            this.cppfilename.Margin = new System.Windows.Forms.Padding(2);
            this.cppfilename.Name = "cppfilename";
            this.cppfilename.Size = new System.Drawing.Size(91, 20);
            this.cppfilename.TabIndex = 4;
            this.cppfilename.TextChanged += new System.EventHandler(this.cppfilename_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "C++ Filename:";
            // 
            // customspritename
            // 
            this.customspritename.Location = new System.Drawing.Point(332, 57);
            this.customspritename.Margin = new System.Windows.Forms.Padding(2);
            this.customspritename.Name = "customspritename";
            this.customspritename.Size = new System.Drawing.Size(91, 20);
            this.customspritename.TabIndex = 6;
            this.customspritename.TextChanged += new System.EventHandler(this.customspritename_TextChanged);
            // 
            // ingamespritename
            // 
            this.ingamespritename.Location = new System.Drawing.Point(332, 80);
            this.ingamespritename.Margin = new System.Windows.Forms.Padding(2);
            this.ingamespritename.Name = "ingamespritename";
            this.ingamespritename.Size = new System.Drawing.Size(91, 20);
            this.ingamespritename.TabIndex = 7;
            this.ingamespritename.TextChanged += new System.EventHandler(this.ingamespritename_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Custom Sprite Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "In-Game Custom Sprite Name:";
            // 
            // example
            // 
            this.example.Location = new System.Drawing.Point(20, 33);
            this.example.Margin = new System.Windows.Forms.Padding(2);
            this.example.Name = "example";
            this.example.Size = new System.Drawing.Size(137, 63);
            this.example.TabIndex = 10;
            this.example.Text = "You don\'t understand how does it work ?\r\nClick here to get an example!";
            this.example.UseVisualStyleBackColor = true;
            this.example.Click += new System.EventHandler(this.example_Click);
            // 
            // spritefileinfo
            // 
            this.spritefileinfo.AutoSize = true;
            this.spritefileinfo.Location = new System.Drawing.Point(552, 25);
            this.spritefileinfo.Margin = new System.Windows.Forms.Padding(2);
            this.spritefileinfo.Name = "spritefileinfo";
            this.spritefileinfo.Size = new System.Drawing.Size(87, 17);
            this.spritefileinfo.TabIndex = 11;
            this.spritefileinfo.Text = "SpriteFileInfo";
            this.spritefileinfo.UseVisualStyleBackColor = true;
            this.spritefileinfo.CheckedChanged += new System.EventHandler(this.spritefileinfo_CheckedChanged);
            // 
            // spritefileinfotarget
            // 
            this.spritefileinfotarget.Location = new System.Drawing.Point(614, 47);
            this.spritefileinfotarget.Margin = new System.Windows.Forms.Padding(2);
            this.spritefileinfotarget.Name = "spritefileinfotarget";
            this.spritefileinfotarget.ReadOnly = true;
            this.spritefileinfotarget.Size = new System.Drawing.Size(134, 20);
            this.spritefileinfotarget.TabIndex = 12;
            this.spritefileinfotarget.TextChanged += new System.EventHandler(this.spritefileinfotarget_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "SpriteFileInfo Target Function:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "NewerSMBW Hook Generator\r\nMade by RedStoneMatt";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 488);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spritefileinfotarget);
            this.Controls.Add(this.spritefileinfo);
            this.Controls.Add(this.example);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ingamespritename);
            this.Controls.Add(this.customspritename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cppfilename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.ActorNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "NewerSMBW Hook Generator";
            ((System.ComponentModel.ISupportInitialize)(this.ActorNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ActorNum;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cppfilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customspritename;
        private System.Windows.Forms.TextBox ingamespritename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button example;
        private System.Windows.Forms.CheckBox spritefileinfo;
        private System.Windows.Forms.TextBox spritefileinfotarget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

