namespace NewerSMBWHookGenerator
{
    partial class MultiKamek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiKamek));
            this.useBetterKamek = new System.Windows.Forms.CheckBox();
            this.pythonPath = new System.Windows.Forms.TextBox();
            this.SourcePath = new System.Windows.Forms.TextBox();
            this.moveNewerASMtoNewerRes = new System.Windows.Forms.CheckBox();
            this.NewerResPath = new System.Windows.Forms.TextBox();
            this.YAMLName = new System.Windows.Forms.TextBox();
            this.devkitPPCPath = new System.Windows.Forms.TextBox();
            this.useClang = new System.Windows.Forms.CheckBox();
            this.LLVMPath = new System.Windows.Forms.TextBox();
            this.noRels = new System.Windows.Forms.CheckBox();
            this.showCMD = new System.Windows.Forms.CheckBox();
            this.keepTemp = new System.Windows.Forms.CheckBox();
            this.CompileButton = new System.Windows.Forms.Button();
            this.generatedCommand = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Example = new System.Windows.Forms.Button();
            this.commandLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveName = new System.Windows.Forms.TextBox();
            this.loadName = new System.Windows.Forms.TextBox();
            this.getFilePython = new System.Windows.Forms.Button();
            this.getSourceFolder = new System.Windows.Forms.Button();
            this.getNewerResFolder = new System.Windows.Forms.Button();
            this.getDevkitFolder = new System.Windows.Forms.Button();
            this.getLLVMFolder = new System.Windows.Forms.Button();
            this.mainSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.kamekSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.logs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // useBetterKamek
            // 
            this.useBetterKamek.AutoSize = true;
            this.useBetterKamek.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.useBetterKamek.Location = new System.Drawing.Point(655, 39);
            this.useBetterKamek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.useBetterKamek.Name = "useBetterKamek";
            this.useBetterKamek.Size = new System.Drawing.Size(18, 17);
            this.useBetterKamek.TabIndex = 0;
            this.useBetterKamek.UseVisualStyleBackColor = true;
            this.useBetterKamek.Visible = false;
            this.useBetterKamek.CheckedChanged += new System.EventHandler(this.useBetterKamek_CheckedChanged);
            // 
            // pythonPath
            // 
            this.pythonPath.ForeColor = System.Drawing.Color.Gray;
            this.pythonPath.Location = new System.Drawing.Point(655, 64);
            this.pythonPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pythonPath.Name = "pythonPath";
            this.pythonPath.Size = new System.Drawing.Size(323, 22);
            this.pythonPath.TabIndex = 1;
            this.pythonPath.Text = "C:\\Python27\\python.exe";
            this.pythonPath.TextChanged += new System.EventHandler(this.pythonPath_TextChanged);
            this.pythonPath.Enter += new System.EventHandler(this.pythonPath_Enter);
            this.pythonPath.Leave += new System.EventHandler(this.pythonPath_Leave);
            // 
            // SourcePath
            // 
            this.SourcePath.Location = new System.Drawing.Point(655, 96);
            this.SourcePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.Size = new System.Drawing.Size(323, 22);
            this.SourcePath.TabIndex = 2;
            // 
            // moveNewerASMtoNewerRes
            // 
            this.moveNewerASMtoNewerRes.AutoSize = true;
            this.moveNewerASMtoNewerRes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.moveNewerASMtoNewerRes.Location = new System.Drawing.Point(655, 128);
            this.moveNewerASMtoNewerRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.moveNewerASMtoNewerRes.Name = "moveNewerASMtoNewerRes";
            this.moveNewerASMtoNewerRes.Size = new System.Drawing.Size(18, 17);
            this.moveNewerASMtoNewerRes.TabIndex = 3;
            this.moveNewerASMtoNewerRes.UseVisualStyleBackColor = true;
            this.moveNewerASMtoNewerRes.CheckedChanged += new System.EventHandler(this.moveNewerASMtoNewerRes_CheckedChanged);
            // 
            // NewerResPath
            // 
            this.NewerResPath.Location = new System.Drawing.Point(655, 152);
            this.NewerResPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewerResPath.Name = "NewerResPath";
            this.NewerResPath.ReadOnly = true;
            this.NewerResPath.Size = new System.Drawing.Size(323, 22);
            this.NewerResPath.TabIndex = 4;
            // 
            // YAMLName
            // 
            this.YAMLName.ForeColor = System.Drawing.Color.Gray;
            this.YAMLName.Location = new System.Drawing.Point(578, 222);
            this.YAMLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YAMLName.Name = "YAMLName";
            this.YAMLName.Size = new System.Drawing.Size(323, 22);
            this.YAMLName.TabIndex = 5;
            this.YAMLName.Text = "NewerProjectKP.yaml";
            this.YAMLName.TextChanged += new System.EventHandler(this.YAMLName_TextChanged);
            this.YAMLName.Enter += new System.EventHandler(this.YAMLName_Enter);
            this.YAMLName.Leave += new System.EventHandler(this.YAMLName_Leave);
            // 
            // devkitPPCPath
            // 
            this.devkitPPCPath.ForeColor = System.Drawing.Color.Gray;
            this.devkitPPCPath.Location = new System.Drawing.Point(578, 254);
            this.devkitPPCPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devkitPPCPath.Name = "devkitPPCPath";
            this.devkitPPCPath.Size = new System.Drawing.Size(323, 22);
            this.devkitPPCPath.TabIndex = 6;
            this.devkitPPCPath.Text = "tools/devkitPPC/bin/powerpc-eabi";
            this.devkitPPCPath.TextChanged += new System.EventHandler(this.devkitPPCPath_TextChanged);
            this.devkitPPCPath.Enter += new System.EventHandler(this.devkitPPCPath_Enter);
            this.devkitPPCPath.Leave += new System.EventHandler(this.devkitPPCPath_Leave);
            // 
            // useClang
            // 
            this.useClang.AutoSize = true;
            this.useClang.Checked = true;
            this.useClang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useClang.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.useClang.Location = new System.Drawing.Point(578, 286);
            this.useClang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.useClang.Name = "useClang";
            this.useClang.Size = new System.Drawing.Size(18, 17);
            this.useClang.TabIndex = 7;
            this.useClang.UseVisualStyleBackColor = true;
            this.useClang.CheckedChanged += new System.EventHandler(this.useClang_CheckedChanged);
            // 
            // LLVMPath
            // 
            this.LLVMPath.ForeColor = System.Drawing.Color.Gray;
            this.LLVMPath.Location = new System.Drawing.Point(578, 310);
            this.LLVMPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LLVMPath.Name = "LLVMPath";
            this.LLVMPath.Size = new System.Drawing.Size(323, 22);
            this.LLVMPath.TabIndex = 8;
            this.LLVMPath.Text = "tools/NewerSMBW-LLVM/bin";
            this.LLVMPath.TextChanged += new System.EventHandler(this.LLVMPath_TextChanged);
            this.LLVMPath.Enter += new System.EventHandler(this.LLVMPath_Enter);
            this.LLVMPath.Leave += new System.EventHandler(this.LLVMPath_Leave);
            // 
            // noRels
            // 
            this.noRels.AutoSize = true;
            this.noRels.Checked = true;
            this.noRels.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noRels.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.noRels.Location = new System.Drawing.Point(578, 342);
            this.noRels.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noRels.Name = "noRels";
            this.noRels.Size = new System.Drawing.Size(18, 17);
            this.noRels.TabIndex = 9;
            this.noRels.UseVisualStyleBackColor = true;
            // 
            // showCMD
            // 
            this.showCMD.AutoSize = true;
            this.showCMD.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.showCMD.Location = new System.Drawing.Point(578, 367);
            this.showCMD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showCMD.Name = "showCMD";
            this.showCMD.Size = new System.Drawing.Size(18, 17);
            this.showCMD.TabIndex = 10;
            this.showCMD.UseVisualStyleBackColor = true;
            // 
            // keepTemp
            // 
            this.keepTemp.AutoSize = true;
            this.keepTemp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.keepTemp.Location = new System.Drawing.Point(578, 391);
            this.keepTemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.keepTemp.Name = "keepTemp";
            this.keepTemp.Size = new System.Drawing.Size(18, 17);
            this.keepTemp.TabIndex = 11;
            this.keepTemp.UseVisualStyleBackColor = true;
            // 
            // CompileButton
            // 
            this.CompileButton.Location = new System.Drawing.Point(639, 430);
            this.CompileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CompileButton.Name = "CompileButton";
            this.CompileButton.Size = new System.Drawing.Size(100, 28);
            this.CompileButton.TabIndex = 12;
            this.CompileButton.Text = "Compile";
            this.CompileButton.UseVisualStyleBackColor = true;
            this.CompileButton.Click += new System.EventHandler(this.CompileButton_Click);
            // 
            // generatedCommand
            // 
            this.generatedCommand.Location = new System.Drawing.Point(9, 482);
            this.generatedCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generatedCommand.Name = "generatedCommand";
            this.generatedCommand.ReadOnly = true;
            this.generatedCommand.Size = new System.Drawing.Size(1332, 203);
            this.generatedCommand.TabIndex = 13;
            this.generatedCommand.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Source Code Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "NewerRes Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Project YAML File:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 257);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "devkitPPC Path:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "LLVM Path:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Use BetterKamek:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 342);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "No Rels:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(493, 286);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Use Clang:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(486, 367);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Show CMD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 393);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Keep Temp Files:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(350, 129);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(289, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "Move and Rename NewerASM to NewerRes:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(557, 67);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Python Path:";
            // 
            // Example
            // 
            this.Example.Location = new System.Drawing.Point(1231, 15);
            this.Example.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Example.Name = "Example";
            this.Example.Size = new System.Drawing.Size(100, 28);
            this.Example.TabIndex = 28;
            this.Example.Text = "Example";
            this.Example.UseVisualStyleBackColor = true;
            this.Example.Click += new System.EventHandler(this.Example_Click);
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(615, 462);
            this.commandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(147, 17);
            this.commandLabel.TabIndex = 29;
            this.commandLabel.Text = "Generated Command:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(29, 34);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 30;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(29, 71);
            this.loadButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(100, 28);
            this.loadButton.TabIndex = 31;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveName
            // 
            this.saveName.Location = new System.Drawing.Point(137, 36);
            this.saveName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveName.Name = "saveName";
            this.saveName.Size = new System.Drawing.Size(112, 22);
            this.saveName.TabIndex = 32;
            // 
            // loadName
            // 
            this.loadName.Location = new System.Drawing.Point(137, 73);
            this.loadName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loadName.Name = "loadName";
            this.loadName.Size = new System.Drawing.Size(112, 22);
            this.loadName.TabIndex = 33;
            // 
            // getFilePython
            // 
            this.getFilePython.Location = new System.Drawing.Point(987, 64);
            this.getFilePython.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getFilePython.Name = "getFilePython";
            this.getFilePython.Size = new System.Drawing.Size(33, 23);
            this.getFilePython.TabIndex = 35;
            this.getFilePython.Text = "...";
            this.getFilePython.UseVisualStyleBackColor = true;
            this.getFilePython.Click += new System.EventHandler(this.getFilePython_Click);
            // 
            // getSourceFolder
            // 
            this.getSourceFolder.Location = new System.Drawing.Point(987, 96);
            this.getSourceFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getSourceFolder.Name = "getSourceFolder";
            this.getSourceFolder.Size = new System.Drawing.Size(33, 23);
            this.getSourceFolder.TabIndex = 36;
            this.getSourceFolder.Text = "...";
            this.getSourceFolder.UseVisualStyleBackColor = true;
            this.getSourceFolder.Click += new System.EventHandler(this.getSourceFolder_Click);
            // 
            // getNewerResFolder
            // 
            this.getNewerResFolder.Enabled = false;
            this.getNewerResFolder.Location = new System.Drawing.Point(987, 152);
            this.getNewerResFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getNewerResFolder.Name = "getNewerResFolder";
            this.getNewerResFolder.Size = new System.Drawing.Size(33, 23);
            this.getNewerResFolder.TabIndex = 37;
            this.getNewerResFolder.Text = "...";
            this.getNewerResFolder.UseVisualStyleBackColor = true;
            this.getNewerResFolder.Click += new System.EventHandler(this.getNewerResFolder_Click);
            // 
            // getDevkitFolder
            // 
            this.getDevkitFolder.Location = new System.Drawing.Point(910, 254);
            this.getDevkitFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getDevkitFolder.Name = "getDevkitFolder";
            this.getDevkitFolder.Size = new System.Drawing.Size(33, 23);
            this.getDevkitFolder.TabIndex = 38;
            this.getDevkitFolder.Text = "...";
            this.getDevkitFolder.UseVisualStyleBackColor = true;
            this.getDevkitFolder.Click += new System.EventHandler(this.getDevkitFolder_Click);
            // 
            // getLLVMFolder
            // 
            this.getLLVMFolder.Location = new System.Drawing.Point(910, 310);
            this.getLLVMFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getLLVMFolder.Name = "getLLVMFolder";
            this.getLLVMFolder.Size = new System.Drawing.Size(33, 23);
            this.getLLVMFolder.TabIndex = 39;
            this.getLLVMFolder.Text = "...";
            this.getLLVMFolder.UseVisualStyleBackColor = true;
            this.getLLVMFolder.Click += new System.EventHandler(this.getLLVMFolder_Click);
            // 
            // mainSettingsGroupBox
            // 
            this.mainSettingsGroupBox.Location = new System.Drawing.Point(332, 16);
            this.mainSettingsGroupBox.Name = "mainSettingsGroupBox";
            this.mainSettingsGroupBox.Size = new System.Drawing.Size(706, 175);
            this.mainSettingsGroupBox.TabIndex = 40;
            this.mainSettingsGroupBox.TabStop = false;
            this.mainSettingsGroupBox.Text = "Main Settings:";
            // 
            // kamekSettingsGroupBox
            // 
            this.kamekSettingsGroupBox.Location = new System.Drawing.Point(427, 200);
            this.kamekSettingsGroupBox.Name = "kamekSettingsGroupBox";
            this.kamekSettingsGroupBox.Size = new System.Drawing.Size(532, 222);
            this.kamekSettingsGroupBox.TabIndex = 41;
            this.kamekSettingsGroupBox.TabStop = false;
            this.kamekSettingsGroupBox.Text = "Kamek Settings:";
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Location = new System.Drawing.Point(20, 15);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(239, 93);
            this.fileGroupBox.TabIndex = 42;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "File";
            // 
            // logs
            // 
            this.logs.AutoSize = true;
            this.logs.Location = new System.Drawing.Point(6, 689);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(131, 17);
            this.logs.TabIndex = 43;
            this.logs.Text = "Waiting for Action...";
            // 
            // MultiKamek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 716);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getLLVMFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getDevkitFolder);
            this.Controls.Add(this.getNewerResFolder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.getSourceFolder);
            this.Controls.Add(this.loadName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.saveName);
            this.Controls.Add(this.getFilePython);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.NewerResPath);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.moveNewerASMtoNewerRes);
            this.Controls.Add(this.YAMLName);
            this.Controls.Add(this.SourcePath);
            this.Controls.Add(this.devkitPPCPath);
            this.Controls.Add(this.pythonPath);
            this.Controls.Add(this.useClang);
            this.Controls.Add(this.useBetterKamek);
            this.Controls.Add(this.LLVMPath);
            this.Controls.Add(this.noRels);
            this.Controls.Add(this.showCMD);
            this.Controls.Add(this.keepTemp);
            this.Controls.Add(this.CompileButton);
            this.Controls.Add(this.generatedCommand);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Example);
            this.Controls.Add(this.commandLabel);
            this.Controls.Add(this.mainSettingsGroupBox);
            this.Controls.Add(this.kamekSettingsGroupBox);
            this.Controls.Add(this.fileGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MultiKamek";
            this.Text = "MultiKamek v0.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox useBetterKamek;
        private System.Windows.Forms.TextBox pythonPath;
        private System.Windows.Forms.TextBox SourcePath;
        private System.Windows.Forms.CheckBox moveNewerASMtoNewerRes;
        private System.Windows.Forms.TextBox NewerResPath;
        private System.Windows.Forms.TextBox YAMLName;
        private System.Windows.Forms.TextBox devkitPPCPath;
        private System.Windows.Forms.CheckBox useClang;
        private System.Windows.Forms.TextBox LLVMPath;
        private System.Windows.Forms.CheckBox noRels;
        private System.Windows.Forms.CheckBox showCMD;
        private System.Windows.Forms.CheckBox keepTemp;
        private System.Windows.Forms.Button CompileButton;
        private System.Windows.Forms.RichTextBox generatedCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Example;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox saveName;
        private System.Windows.Forms.TextBox loadName;
        private System.Windows.Forms.Button getFilePython;
        private System.Windows.Forms.Button getSourceFolder;
        private System.Windows.Forms.Button getNewerResFolder;
        private System.Windows.Forms.Button getDevkitFolder;
        private System.Windows.Forms.Button getLLVMFolder;
        private System.Windows.Forms.GroupBox mainSettingsGroupBox;
        private System.Windows.Forms.GroupBox kamekSettingsGroupBox;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.Label logs;
    }
}