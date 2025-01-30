namespace SharpLauncher
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.mcProgressBar = new System.Windows.Forms.ProgressBar();
            this.stateLabel = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.rbmMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.додатиЗбіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиЗбіркуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionBox = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accountsBox = new System.Windows.Forms.ComboBox();
            this.accountLabel = new System.Windows.Forms.Label();
            this.playButton = new FontAwesome.Sharp.IconButton();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.rbmMenu.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.progressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mcProgressBar
            // 
            this.mcProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mcProgressBar.Location = new System.Drawing.Point(6, 21);
            this.mcProgressBar.Name = "mcProgressBar";
            this.mcProgressBar.Size = new System.Drawing.Size(733, 23);
            this.mcProgressBar.TabIndex = 1;
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stateLabel.BackColor = System.Drawing.Color.Transparent;
            this.stateLabel.Location = new System.Drawing.Point(3, 5);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(699, 13);
            this.stateLabel.TabIndex = 2;
            this.stateLabel.Text = "Очікування...";
            // 
            // percentageLabel
            // 
            this.percentageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.percentageLabel.Location = new System.Drawing.Point(708, 5);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(34, 13);
            this.percentageLabel.TabIndex = 3;
            this.percentageLabel.Text = "0%";
            this.percentageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbmMenu
            // 
            this.rbmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиЗбіркуToolStripMenuItem,
            this.редагуватиЗбіркуToolStripMenuItem,
            this.видалитиToolStripMenuItem});
            this.rbmMenu.Name = "windowMenu";
            this.rbmMenu.Size = new System.Drawing.Size(172, 70);
            // 
            // додатиЗбіркуToolStripMenuItem
            // 
            this.додатиЗбіркуToolStripMenuItem.Name = "додатиЗбіркуToolStripMenuItem";
            this.додатиЗбіркуToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.додатиЗбіркуToolStripMenuItem.Text = "Додати збірку";
            // 
            // редагуватиЗбіркуToolStripMenuItem
            // 
            this.редагуватиЗбіркуToolStripMenuItem.Name = "редагуватиЗбіркуToolStripMenuItem";
            this.редагуватиЗбіркуToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.редагуватиЗбіркуToolStripMenuItem.Text = "Редагувати збірку";
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(96, 134);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(40, 13);
            this.versionLabel.TabIndex = 6;
            this.versionLabel.Text = "Версія";
            // 
            // versionBox
            // 
            this.versionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionBox.FormattingEnabled = true;
            this.versionBox.Location = new System.Drawing.Point(142, 131);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(121, 21);
            this.versionBox.TabIndex = 7;
            this.versionBox.SelectedIndexChanged += new System.EventHandler(this.versionBox_SelectedIndexChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.settingsButton);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.accountsBox);
            this.mainPanel.Controls.Add(this.accountLabel);
            this.mainPanel.Controls.Add(this.playButton);
            this.mainPanel.Controls.Add(this.versionBox);
            this.mainPanel.Controls.Add(this.versionLabel);
            this.mainPanel.Location = new System.Drawing.Point(206, 66);
            this.mainPanel.MaximumSize = new System.Drawing.Size(365, 243);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(365, 243);
            this.mainPanel.TabIndex = 8;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.MistyRose;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.settingsButton.IconColor = System.Drawing.Color.Black;
            this.settingsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsButton.IconSize = 30;
            this.settingsButton.Location = new System.Drawing.Point(224, 158);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(39, 39);
            this.settingsButton.TabIndex = 12;
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SharpLauncher.Properties.Resources.title;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 41);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // accountsBox
            // 
            this.accountsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountsBox.FormattingEnabled = true;
            this.accountsBox.Location = new System.Drawing.Point(142, 102);
            this.accountsBox.Name = "accountsBox";
            this.accountsBox.Size = new System.Drawing.Size(121, 21);
            this.accountsBox.TabIndex = 10;
            this.accountsBox.SelectedIndexChanged += new System.EventHandler(this.accountBox_SelectedIndexChanged);
            // 
            // accountLabel
            // 
            this.accountLabel.AutoSize = true;
            this.accountLabel.Location = new System.Drawing.Point(96, 105);
            this.accountLabel.Name = "accountLabel";
            this.accountLabel.Size = new System.Drawing.Size(42, 13);
            this.accountLabel.TabIndex = 9;
            this.accountLabel.Text = "Акаунт";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.LightGreen;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playButton.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.playButton.IconColor = System.Drawing.Color.Black;
            this.playButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.playButton.IconSize = 20;
            this.playButton.Location = new System.Drawing.Point(99, 158);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(119, 39);
            this.playButton.TabIndex = 8;
            this.playButton.Text = "ГРАТИ";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // progressPanel
            // 
            this.progressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressPanel.Controls.Add(this.mcProgressBar);
            this.progressPanel.Controls.Add(this.stateLabel);
            this.progressPanel.Controls.Add(this.percentageLabel);
            this.progressPanel.Location = new System.Drawing.Point(12, 379);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(745, 52);
            this.progressPanel.TabIndex = 9;
            this.progressPanel.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SharpLauncher.Properties.Resources.defaultbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 443);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.mainPanel);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(785, 482);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHARPLAUNCHER";
            this.rbmMenu.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.progressPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar mcProgressBar;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.ContextMenuStrip rbmMenu;
        private System.Windows.Forms.ToolStripMenuItem додатиЗбіркуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиЗбіркуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ComboBox versionBox;
        private System.Windows.Forms.Panel mainPanel;
        private FontAwesome.Sharp.IconButton playButton;
        private System.Windows.Forms.Label accountLabel;
        private System.Windows.Forms.ComboBox accountsBox;
        private System.Windows.Forms.Panel progressPanel;
        private FontAwesome.Sharp.IconButton settingsButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

