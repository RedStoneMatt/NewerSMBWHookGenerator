using System.Windows.Forms;

namespace NewerSMBWHookGenerator
{
    partial class AboutBox1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox1));
            this.panelGray = new System.Windows.Forms.Panel();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.githubIcon = new System.Windows.Forms.PictureBox();
            this.youtubeIcon = new System.Windows.Forms.PictureBox();
            this.youtubeLink = new System.Windows.Forms.LinkLabel();
            this.closeButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.panelGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.githubIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtubeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGray
            // 
            this.panelGray.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGray.BackColor = System.Drawing.SystemColors.Control;
            this.panelGray.Controls.Add(this.closeButton);
            this.panelGray.Controls.Add(this.githubLink);
            this.panelGray.Controls.Add(this.githubIcon);
            this.panelGray.Controls.Add(this.youtubeIcon);
            this.panelGray.Controls.Add(this.youtubeLink);
            this.panelGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panelGray.Location = new System.Drawing.Point(-4, 318);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(517, 59);
            this.panelGray.TabIndex = 1;
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.BackColor = System.Drawing.SystemColors.Control;
            this.githubLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.githubLink.Location = new System.Drawing.Point(34, 11);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(90, 17);
            this.githubLink.TabIndex = 7;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "Source Code";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // githubIcon
            // 
            this.githubIcon.BackColor = System.Drawing.SystemColors.Control;
            this.githubIcon.Image = ((System.Drawing.Image)(resources.GetObject("githubIcon.Image")));
            this.githubIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("githubIcon.InitialImage")));
            this.githubIcon.Location = new System.Drawing.Point(14, 7);
            this.githubIcon.Name = "githubIcon";
            this.githubIcon.Size = new System.Drawing.Size(20, 20);
            this.githubIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.githubIcon.TabIndex = 8;
            this.githubIcon.TabStop = false;
            // 
            // youtubeIcon
            // 
            this.youtubeIcon.BackColor = System.Drawing.SystemColors.Control;
            this.youtubeIcon.Image = ((System.Drawing.Image)(resources.GetObject("youtubeIcon.Image")));
            this.youtubeIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("youtubeIcon.InitialImage")));
            this.youtubeIcon.Location = new System.Drawing.Point(130, 7);
            this.youtubeIcon.Name = "youtubeIcon";
            this.youtubeIcon.Size = new System.Drawing.Size(20, 20);
            this.youtubeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.youtubeIcon.TabIndex = 10;
            this.youtubeIcon.TabStop = false;
            this.youtubeIcon.Click += new System.EventHandler(this.youtubeIcon_Click);
            // 
            // youtubeLink
            // 
            this.youtubeLink.AutoSize = true;
            this.youtubeLink.BackColor = System.Drawing.SystemColors.Control;
            this.youtubeLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.youtubeLink.Location = new System.Drawing.Point(150, 11);
            this.youtubeLink.Name = "youtubeLink";
            this.youtubeLink.Size = new System.Drawing.Size(66, 17);
            this.youtubeLink.TabIndex = 9;
            this.youtubeLink.TabStop = true;
            this.youtubeLink.Text = "YouTube";
            this.youtubeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.youtubeLink_LinkClicked);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.closeButton.Location = new System.Drawing.Point(420, 7);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(63, 25);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.Window;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.InitialImage = ((System.Drawing.Image)(resources.GetObject("logo.InitialImage")));
            this.logo.Location = new System.Drawing.Point(13, 15);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(117, 117);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelTitle.Location = new System.Drawing.Point(133, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(240, 22);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "NewerSMBWHookGenerator";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.labelVersion.Location = new System.Drawing.Point(134, 41);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(72, 16);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "version 1.6";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelDetails.Location = new System.Drawing.Point(13, 156);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(173, 34);
            this.labelDetails.TabIndex = 3;
            this.labelDetails.Text = "Main Code: RedStoneMatt\r\nAdditional Code: jah";
            // 
            // AboutBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(492, 354);
            this.ControlBox = false;
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panelGray);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.panelGray.ResumeLayout(false);
            this.panelGray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.githubIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.youtubeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private Panel panelGray;
        private Label labelTitle;
        private Label labelVersion;
        private Label labelDetails;
        private Button closeButton;
        private LinkLabel githubLink;
        private PictureBox githubIcon;
        private PictureBox youtubeIcon;
        private LinkLabel youtubeLink;
    }
}
