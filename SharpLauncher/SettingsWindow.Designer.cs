namespace SharpLauncher
{
    partial class SettingsWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.fullScreenCheckBox = new System.Windows.Forms.CheckBox();
            this.heightBox = new System.Windows.Forms.NumericUpDown();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.portBox = new System.Windows.Forms.NumericUpDown();
            this.windowResolutionChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.connectToServerCheckBox = new System.Windows.Forms.CheckBox();
            this.openFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.memoryUpDown = new System.Windows.Forms.NumericUpDown();
            this.resetBGButton = new System.Windows.Forms.Button();
            this.quickDownloadCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bgPreview = new System.Windows.Forms.PictureBox();
            this.chooseBG = new System.Windows.Forms.OpenFileDialog();
            this.settingsTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgPreview)).BeginInit();
            this.settingsTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пам\'ять";
            // 
            // fullScreenCheckBox
            // 
            this.fullScreenCheckBox.AutoSize = true;
            this.fullScreenCheckBox.Location = new System.Drawing.Point(9, 111);
            this.fullScreenCheckBox.Name = "fullScreenCheckBox";
            this.fullScreenCheckBox.Size = new System.Drawing.Size(143, 17);
            this.fullScreenCheckBox.TabIndex = 16;
            this.fullScreenCheckBox.Text = "Повноекранний режим";
            this.fullScreenCheckBox.UseVisualStyleBackColor = true;
            this.fullScreenCheckBox.CheckedChanged += new System.EventHandler(this.fullScreenCheckBox_CheckedChanged);
            // 
            // heightBox
            // 
            this.heightBox.Enabled = false;
            this.heightBox.Location = new System.Drawing.Point(130, 151);
            this.heightBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.heightBox.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(101, 20);
            this.heightBox.TabIndex = 15;
            this.heightBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.heightBox.ValueChanged += new System.EventHandler(this.heightBox_ValueChanged);
            // 
            // widthBox
            // 
            this.widthBox.Enabled = false;
            this.widthBox.Location = new System.Drawing.Point(9, 152);
            this.widthBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.widthBox.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(103, 20);
            this.widthBox.TabIndex = 14;
            this.widthBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.widthBox.ValueChanged += new System.EventHandler(this.widthBox_ValueChanged);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(170, 85);
            this.portBox.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(61, 20);
            this.portBox.TabIndex = 13;
            this.portBox.Value = new decimal(new int[] {
            25565,
            0,
            0,
            0});
            this.portBox.ValueChanged += new System.EventHandler(this.portBox_TextChanged);
            // 
            // windowResolutionChangeCheckBox
            // 
            this.windowResolutionChangeCheckBox.AutoSize = true;
            this.windowResolutionChangeCheckBox.Location = new System.Drawing.Point(9, 134);
            this.windowResolutionChangeCheckBox.Name = "windowResolutionChangeCheckBox";
            this.windowResolutionChangeCheckBox.Size = new System.Drawing.Size(187, 17);
            this.windowResolutionChangeCheckBox.TabIndex = 10;
            this.windowResolutionChangeCheckBox.Text = "Змінити стартовий розмір вікна";
            this.windowResolutionChangeCheckBox.UseVisualStyleBackColor = true;
            this.windowResolutionChangeCheckBox.CheckedChanged += new System.EventHandler(this.windowResolutionChangeCheckBox_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "×";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(161, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // ipBox
            // 
            this.ipBox.Enabled = false;
            this.ipBox.Location = new System.Drawing.Point(9, 85);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(153, 20);
            this.ipBox.TabIndex = 5;
            this.ipBox.TextChanged += new System.EventHandler(this.ipBox_TextChanged);
            // 
            // connectToServerCheckBox
            // 
            this.connectToServerCheckBox.AutoSize = true;
            this.connectToServerCheckBox.Location = new System.Drawing.Point(9, 66);
            this.connectToServerCheckBox.Name = "connectToServerCheckBox";
            this.connectToServerCheckBox.Size = new System.Drawing.Size(216, 17);
            this.connectToServerCheckBox.TabIndex = 4;
            this.connectToServerCheckBox.Text = "Автоматично під\'єднувати до серверу";
            this.connectToServerCheckBox.UseVisualStyleBackColor = true;
            this.connectToServerCheckBox.CheckedChanged += new System.EventHandler(this.connectToServerCheckBox_CheckedChanged);
            // 
            // openFolder
            // 
            this.openFolder.Location = new System.Drawing.Point(9, 36);
            this.openFolder.Name = "openFolder";
            this.openFolder.Size = new System.Drawing.Size(222, 23);
            this.openFolder.TabIndex = 3;
            this.openFolder.Text = "Папка з версіями";
            this.openFolder.UseVisualStyleBackColor = true;
            this.openFolder.Click += new System.EventHandler(this.openFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "МБ";
            // 
            // memoryUpDown
            // 
            this.memoryUpDown.Location = new System.Drawing.Point(60, 10);
            this.memoryUpDown.Maximum = new decimal(new int[] {
            32768,
            0,
            0,
            0});
            this.memoryUpDown.Minimum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.memoryUpDown.Name = "memoryUpDown";
            this.memoryUpDown.Size = new System.Drawing.Size(62, 20);
            this.memoryUpDown.TabIndex = 1;
            this.memoryUpDown.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.memoryUpDown.ValueChanged += new System.EventHandler(this.memoryUpDown_ValueChanged);
            // 
            // resetBGButton
            // 
            this.resetBGButton.Location = new System.Drawing.Point(89, 55);
            this.resetBGButton.Name = "resetBGButton";
            this.resetBGButton.Size = new System.Drawing.Size(135, 23);
            this.resetBGButton.TabIndex = 4;
            this.resetBGButton.Text = "Скинути";
            this.resetBGButton.UseVisualStyleBackColor = true;
            this.resetBGButton.Click += new System.EventHandler(this.resetBGButton_Click);
            // 
            // quickDownloadCheckBox
            // 
            this.quickDownloadCheckBox.AutoSize = true;
            this.quickDownloadCheckBox.Checked = true;
            this.quickDownloadCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.quickDownloadCheckBox.Location = new System.Drawing.Point(9, 84);
            this.quickDownloadCheckBox.Name = "quickDownloadCheckBox";
            this.quickDownloadCheckBox.Size = new System.Drawing.Size(141, 17);
            this.quickDownloadCheckBox.TabIndex = 3;
            this.quickDownloadCheckBox.Text = "Швидке завантаження";
            this.quickDownloadCheckBox.UseVisualStyleBackColor = true;
            this.quickDownloadCheckBox.CheckedChanged += new System.EventHandler(this.quickDownloadCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фон лаунчеру";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(89, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Обрати";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bgPreview
            // 
            this.bgPreview.Location = new System.Drawing.Point(9, 28);
            this.bgPreview.Name = "bgPreview";
            this.bgPreview.Size = new System.Drawing.Size(74, 50);
            this.bgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bgPreview.TabIndex = 0;
            this.bgPreview.TabStop = false;
            // 
            // chooseBG
            // 
            this.chooseBG.Filter = "Файли зображень|*.png; *.jpg; *.jpeg; *.bmp";
            // 
            // settingsTabs
            // 
            this.settingsTabs.Controls.Add(this.tabPage1);
            this.settingsTabs.Controls.Add(this.tabPage2);
            this.settingsTabs.Location = new System.Drawing.Point(1, 1);
            this.settingsTabs.Name = "settingsTabs";
            this.settingsTabs.SelectedIndex = 0;
            this.settingsTabs.Size = new System.Drawing.Size(245, 206);
            this.settingsTabs.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fullScreenCheckBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.heightBox);
            this.tabPage1.Controls.Add(this.memoryUpDown);
            this.tabPage1.Controls.Add(this.widthBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.portBox);
            this.tabPage1.Controls.Add(this.openFolder);
            this.tabPage1.Controls.Add(this.windowResolutionChangeCheckBox);
            this.tabPage1.Controls.Add(this.connectToServerCheckBox);
            this.tabPage1.Controls.Add(this.ipBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(237, 180);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Налаштування гри";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resetBGButton);
            this.tabPage2.Controls.Add(this.bgPreview);
            this.tabPage2.Controls.Add(this.quickDownloadCheckBox);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(237, 180);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Налаштування лаунчеру";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 207);
            this.Controls.Add(this.settingsTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsWindow";
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.portBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgPreview)).EndInit();
            this.settingsTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown memoryUpDown;
        private System.Windows.Forms.Button openFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox bgPreview;
        private System.Windows.Forms.OpenFileDialog chooseBG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.CheckBox connectToServerCheckBox;
        private System.Windows.Forms.CheckBox windowResolutionChangeCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox quickDownloadCheckBox;
        private System.Windows.Forms.NumericUpDown portBox;
        private System.Windows.Forms.NumericUpDown heightBox;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.CheckBox fullScreenCheckBox;
        private System.Windows.Forms.Button resetBGButton;
        private System.Windows.Forms.TabControl settingsTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}