namespace NewerSMBWHookGenerator
{
    partial class Sub2Address
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
            this.labelWarning = new System.Windows.Forms.Label();
            this.inputRegister = new System.Windows.Forms.ComboBox();
            this.inputHex = new System.Windows.Forms.TextBox();
            this.labelParenthesis1 = new System.Windows.Forms.Label();
            this.labelParenthesis2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.outputHex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelWarning.Location = new System.Drawing.Point(41, 22);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(712, 40);
            this.labelWarning.TabIndex = 0;
            this.labelWarning.Text = "WARNING: This tool was made because the author of this software (RedStoneMatt) ne" +
    "eded it.\r\nNobody except him is actually supposed to use it, so that tool won\'t b" +
    "e documented.";
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputRegister
            // 
            this.inputRegister.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputRegister.FormattingEnabled = true;
            this.inputRegister.Items.AddRange(new object[] {
            "r1 [_STACK_BASE_]",
            "r2 [_SDA2_BASE_]",
            "r13 [_SDA_BASE_]"});
            this.inputRegister.Location = new System.Drawing.Point(451, 124);
            this.inputRegister.Name = "inputRegister";
            this.inputRegister.Size = new System.Drawing.Size(167, 24);
            this.inputRegister.TabIndex = 5;
            // 
            // inputHex
            // 
            this.inputHex.Location = new System.Drawing.Point(300, 125);
            this.inputHex.Name = "inputHex";
            this.inputHex.Size = new System.Drawing.Size(142, 22);
            this.inputHex.TabIndex = 6;
            // 
            // labelParenthesis1
            // 
            this.labelParenthesis1.AutoSize = true;
            this.labelParenthesis1.BackColor = System.Drawing.SystemColors.Control;
            this.labelParenthesis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelParenthesis1.Location = new System.Drawing.Point(438, 121);
            this.labelParenthesis1.Name = "labelParenthesis1";
            this.labelParenthesis1.Size = new System.Drawing.Size(19, 25);
            this.labelParenthesis1.TabIndex = 7;
            this.labelParenthesis1.Text = "(";
            // 
            // labelParenthesis2
            // 
            this.labelParenthesis2.AutoSize = true;
            this.labelParenthesis2.BackColor = System.Drawing.SystemColors.Control;
            this.labelParenthesis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelParenthesis2.Location = new System.Drawing.Point(614, 121);
            this.labelParenthesis2.Name = "labelParenthesis2";
            this.labelParenthesis2.Size = new System.Drawing.Size(19, 25);
            this.labelParenthesis2.TabIndex = 8;
            this.labelParenthesis2.Text = ")";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Do";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputHex
            // 
            this.outputHex.Location = new System.Drawing.Point(397, 269);
            this.outputHex.Name = "outputHex";
            this.outputHex.Size = new System.Drawing.Size(142, 22);
            this.outputHex.TabIndex = 10;
            // 
            // Sub2Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 382);
            this.Controls.Add(this.outputHex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputRegister);
            this.Controls.Add(this.labelParenthesis2);
            this.Controls.Add(this.inputHex);
            this.Controls.Add(this.labelParenthesis1);
            this.Controls.Add(this.labelWarning);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sub2Address";
            this.ShowIcon = false;
            this.Text = "Sub2Address";
            this.Load += new System.EventHandler(this.Sub2Address_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.ComboBox inputRegister;
        private System.Windows.Forms.TextBox inputHex;
        private System.Windows.Forms.Label labelParenthesis1;
        private System.Windows.Forms.Label labelParenthesis2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox outputHex;
    }
}