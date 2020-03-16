namespace NewerSMBWHookGenerator
{
    partial class MapfileTool
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.inputRegion = new System.Windows.Forms.ComboBox();
            this.outputRegion = new System.Windows.Forms.ComboBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(105, 37);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(144, 22);
            this.inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(105, 91);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(144, 22);
            this.outputTextBox.TabIndex = 1;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(56, 40);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(43, 17);
            this.labelInput.TabIndex = 2;
            this.labelInput.Text = "Input:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(44, 94);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(55, 17);
            this.labelOutput.TabIndex = 3;
            this.labelOutput.Text = "Output:";
            // 
            // inputRegion
            // 
            this.inputRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputRegion.FormattingEnabled = true;
            this.inputRegion.Items.AddRange(new object[] {
            "EU v1",
            "EU v2",
            "US v1",
            "US v2",
            "JP v1",
            "JP v2"});
            this.inputRegion.Location = new System.Drawing.Point(255, 36);
            this.inputRegion.Name = "inputRegion";
            this.inputRegion.Size = new System.Drawing.Size(121, 24);
            this.inputRegion.TabIndex = 4;
            // 
            // outputRegion
            // 
            this.outputRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputRegion.FormattingEnabled = true;
            this.outputRegion.Items.AddRange(new object[] {
            "EU v1",
            "EU v2",
            "US v1",
            "US v2",
            "JP v1",
            "JP v2"});
            this.outputRegion.Location = new System.Drawing.Point(255, 90);
            this.outputRegion.Name = "outputRegion";
            this.outputRegion.Size = new System.Drawing.Size(121, 24);
            this.outputRegion.TabIndex = 5;
            // 
            // convertButton
            // 
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.convertButton.Location = new System.Drawing.Point(174, 139);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // MapfileTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 192);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputRegion);
            this.Controls.Add(this.inputRegion);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MapfileTool";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Mapfile Tool";
            this.Load += new System.EventHandler(this.MapfileTool_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.ComboBox inputRegion;
        private System.Windows.Forms.ComboBox outputRegion;
        private System.Windows.Forms.Button convertButton;
    }
}