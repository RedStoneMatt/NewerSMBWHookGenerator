namespace NewerSMBWHookGenerator
{
    partial class Calculator
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
            this.decInput = new System.Windows.Forms.TextBox();
            this.labelDecimalInput = new System.Windows.Forms.Label();
            this.labelHEXOutput = new System.Windows.Forms.Label();
            this.hexOutput = new System.Windows.Forms.TextBox();
            this.panelGray = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.prefixCheck = new System.Windows.Forms.RadioButton();
            this.noPrefixCheck = new System.Windows.Forms.RadioButton();
            this.panelGray.SuspendLayout();
            this.SuspendLayout();
            // 
            // decInput
            // 
            this.decInput.Location = new System.Drawing.Point(117, 12);
            this.decInput.MaxLength = 9;
            this.decInput.Name = "decInput";
            this.decInput.Size = new System.Drawing.Size(225, 26);
            this.decInput.TabIndex = 0;
            this.decInput.TextChanged += new System.EventHandler(this.decInput_TextChanged);
            // 
            // labelDecimalInput
            // 
            this.labelDecimalInput.AutoSize = true;
            this.labelDecimalInput.Location = new System.Drawing.Point(66, 15);
            this.labelDecimalInput.Name = "labelDecimalInput";
            this.labelDecimalInput.Size = new System.Drawing.Size(60, 19);
            this.labelDecimalInput.TabIndex = 1;
            this.labelDecimalInput.Text = "Decimal:";
            // 
            // labelHEXOutput
            // 
            this.labelHEXOutput.AutoSize = true;
            this.labelHEXOutput.Location = new System.Drawing.Point(38, 43);
            this.labelHEXOutput.Name = "labelHEXOutput";
            this.labelHEXOutput.Size = new System.Drawing.Size(88, 19);
            this.labelHEXOutput.TabIndex = 4;
            this.labelHEXOutput.Text = "Hexadecimal:";
            // 
            // hexOutput
            // 
            this.hexOutput.BackColor = System.Drawing.Color.White;
            this.hexOutput.Location = new System.Drawing.Point(117, 40);
            this.hexOutput.Name = "hexOutput";
            this.hexOutput.Size = new System.Drawing.Size(225, 26);
            this.hexOutput.TabIndex = 3;
            this.hexOutput.TextChanged += new System.EventHandler(this.hexOutput_TextChanged);
            // 
            // panelGray
            // 
            this.panelGray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGray.BackColor = System.Drawing.SystemColors.Control;
            this.panelGray.Controls.Add(this.closeButton);
            this.panelGray.Location = new System.Drawing.Point(-9, 104);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(375, 45);
            this.panelGray.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Location = new System.Drawing.Point(288, 11);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(64, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // prefixCheck
            // 
            this.prefixCheck.AutoSize = true;
            this.prefixCheck.Checked = true;
            this.prefixCheck.Location = new System.Drawing.Point(117, 72);
            this.prefixCheck.Name = "prefixCheck";
            this.prefixCheck.Size = new System.Drawing.Size(44, 23);
            this.prefixCheck.TabIndex = 6;
            this.prefixCheck.TabStop = true;
            this.prefixCheck.Text = "0x";
            this.prefixCheck.UseVisualStyleBackColor = true;
            this.prefixCheck.CheckedChanged += new System.EventHandler(this.decInput_TextChanged);
            // 
            // noPrefixCheck
            // 
            this.noPrefixCheck.AutoSize = true;
            this.noPrefixCheck.Location = new System.Drawing.Point(159, 72);
            this.noPrefixCheck.Name = "noPrefixCheck";
            this.noPrefixCheck.Size = new System.Drawing.Size(61, 23);
            this.noPrefixCheck.TabIndex = 7;
            this.noPrefixCheck.Text = "none";
            this.noPrefixCheck.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 147);
            this.ControlBox = false;
            this.Controls.Add(this.noPrefixCheck);
            this.Controls.Add(this.prefixCheck);
            this.Controls.Add(this.panelGray);
            this.Controls.Add(this.labelHEXOutput);
            this.Controls.Add(this.hexOutput);
            this.Controls.Add(this.labelDecimalInput);
            this.Controls.Add(this.decInput);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HEX Calculator";
            this.panelGray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox decInput;
        private System.Windows.Forms.Label labelDecimalInput;
        private System.Windows.Forms.Label labelHEXOutput;
        private System.Windows.Forms.TextBox hexOutput;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RadioButton prefixCheck;
        private System.Windows.Forms.RadioButton noPrefixCheck;
    }
}