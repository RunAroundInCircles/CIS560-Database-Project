namespace WindowsFormsApp1
{
    partial class ui_CreateCharacterForm
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
            this.ui_NameTextBox = new System.Windows.Forms.TextBox();
            this.ui_NameLabel = new System.Windows.Forms.Label();
            this.ui_RaceLabel = new System.Windows.Forms.Label();
            this.ui_ClassLabel = new System.Windows.Forms.Label();
            this.ui_SkillsGroupBox = new System.Windows.Forms.GroupBox();
            this.ui_SkillsListBox = new System.Windows.Forms.ListBox();
            this.ui_RaceSkillGroupBox = new System.Windows.Forms.GroupBox();
            this.ui_RaceSkill_listBox = new System.Windows.Forms.ListBox();
            this.ui_ClassSkillsGroupBox = new System.Windows.Forms.GroupBox();
            this.ui_ClassSkill_listBox = new System.Windows.Forms.ListBox();
            this.ui_RaceComboBox = new System.Windows.Forms.ComboBox();
            this.ui_ClassComboBox = new System.Windows.Forms.ComboBox();
            this.ui_DescriptionGroupBox = new System.Windows.Forms.GroupBox();
            this.ui_DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.ui_CreateCharacterButton = new System.Windows.Forms.Button();
            this.Armour = new System.Windows.Forms.ListBox();
            this.Weapon = new System.Windows.Forms.ListBox();
            this.ui_ArmourLabel = new System.Windows.Forms.Label();
            this.ui_WeaponLabel = new System.Windows.Forms.Label();
            this.ui_Level_Label = new System.Windows.Forms.Label();
            this.ui_Level_Textbox = new System.Windows.Forms.TextBox();
            this.ui_GetAvailableSkills = new System.Windows.Forms.Button();
            this.ui_GetClasses = new System.Windows.Forms.Button();
            this.ui_DamagetypeGet = new System.Windows.Forms.Button();
            this.ui_OptimalClasses = new System.Windows.Forms.Button();
            this.ui_SkillsGroupBox.SuspendLayout();
            this.ui_RaceSkillGroupBox.SuspendLayout();
            this.ui_ClassSkillsGroupBox.SuspendLayout();
            this.ui_DescriptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_NameTextBox
            // 
            this.ui_NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_NameTextBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_NameTextBox.Location = new System.Drawing.Point(139, 74);
            this.ui_NameTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.ui_NameTextBox.Name = "ui_NameTextBox";
            this.ui_NameTextBox.Size = new System.Drawing.Size(546, 41);
            this.ui_NameTextBox.TabIndex = 0;
            // 
            // ui_NameLabel
            // 
            this.ui_NameLabel.AutoSize = true;
            this.ui_NameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_NameLabel.Location = new System.Drawing.Point(131, 25);
            this.ui_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ui_NameLabel.Name = "ui_NameLabel";
            this.ui_NameLabel.Size = new System.Drawing.Size(277, 39);
            this.ui_NameLabel.TabIndex = 1;
            this.ui_NameLabel.Text = "CHARACTER NAME:";
            // 
            // ui_RaceLabel
            // 
            this.ui_RaceLabel.AutoSize = true;
            this.ui_RaceLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceLabel.Location = new System.Drawing.Point(140, 140);
            this.ui_RaceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ui_RaceLabel.Name = "ui_RaceLabel";
            this.ui_RaceLabel.Size = new System.Drawing.Size(86, 34);
            this.ui_RaceLabel.TabIndex = 2;
            this.ui_RaceLabel.Text = "RACE:";
            // 
            // ui_ClassLabel
            // 
            this.ui_ClassLabel.AutoSize = true;
            this.ui_ClassLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassLabel.Location = new System.Drawing.Point(487, 140);
            this.ui_ClassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ui_ClassLabel.Name = "ui_ClassLabel";
            this.ui_ClassLabel.Size = new System.Drawing.Size(102, 34);
            this.ui_ClassLabel.TabIndex = 6;
            this.ui_ClassLabel.Text = "CLASS:";
            // 
            // ui_SkillsGroupBox
            // 
            this.ui_SkillsGroupBox.Controls.Add(this.ui_SkillsListBox);
            this.ui_SkillsGroupBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsGroupBox.Location = new System.Drawing.Point(139, 541);
            this.ui_SkillsGroupBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_SkillsGroupBox.Name = "ui_SkillsGroupBox";
            this.ui_SkillsGroupBox.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_SkillsGroupBox.Size = new System.Drawing.Size(539, 184);
            this.ui_SkillsGroupBox.TabIndex = 10;
            this.ui_SkillsGroupBox.TabStop = false;
            this.ui_SkillsGroupBox.Text = "Skills:";
            // 
            // ui_SkillsListBox
            // 
            this.ui_SkillsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_SkillsListBox.FormattingEnabled = true;
            this.ui_SkillsListBox.ItemHeight = 34;
            this.ui_SkillsListBox.Location = new System.Drawing.Point(7, 26);
            this.ui_SkillsListBox.Name = "ui_SkillsListBox";
            this.ui_SkillsListBox.Size = new System.Drawing.Size(532, 140);
            this.ui_SkillsListBox.TabIndex = 1;
            // 
            // ui_RaceSkillGroupBox
            // 
            this.ui_RaceSkillGroupBox.Controls.Add(this.ui_RaceSkill_listBox);
            this.ui_RaceSkillGroupBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceSkillGroupBox.Location = new System.Drawing.Point(139, 244);
            this.ui_RaceSkillGroupBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_RaceSkillGroupBox.Name = "ui_RaceSkillGroupBox";
            this.ui_RaceSkillGroupBox.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_RaceSkillGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ui_RaceSkillGroupBox.Size = new System.Drawing.Size(249, 250);
            this.ui_RaceSkillGroupBox.TabIndex = 11;
            this.ui_RaceSkillGroupBox.TabStop = false;
            this.ui_RaceSkillGroupBox.Text = "RACE SKILLS:";
            // 
            // ui_RaceSkill_listBox
            // 
            this.ui_RaceSkill_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_RaceSkill_listBox.FormattingEnabled = true;
            this.ui_RaceSkill_listBox.ItemHeight = 34;
            this.ui_RaceSkill_listBox.Location = new System.Drawing.Point(8, 40);
            this.ui_RaceSkill_listBox.Name = "ui_RaceSkill_listBox";
            this.ui_RaceSkill_listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ui_RaceSkill_listBox.Size = new System.Drawing.Size(234, 208);
            this.ui_RaceSkill_listBox.TabIndex = 0;
            // 
            // ui_ClassSkillsGroupBox
            // 
            this.ui_ClassSkillsGroupBox.Controls.Add(this.ui_ClassSkill_listBox);
            this.ui_ClassSkillsGroupBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassSkillsGroupBox.Location = new System.Drawing.Point(422, 244);
            this.ui_ClassSkillsGroupBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_ClassSkillsGroupBox.Name = "ui_ClassSkillsGroupBox";
            this.ui_ClassSkillsGroupBox.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_ClassSkillsGroupBox.Size = new System.Drawing.Size(263, 250);
            this.ui_ClassSkillsGroupBox.TabIndex = 12;
            this.ui_ClassSkillsGroupBox.TabStop = false;
            this.ui_ClassSkillsGroupBox.Text = "CLASS SKILLS:";
            // 
            // ui_ClassSkill_listBox
            // 
            this.ui_ClassSkill_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ClassSkill_listBox.FormattingEnabled = true;
            this.ui_ClassSkill_listBox.ItemHeight = 34;
            this.ui_ClassSkill_listBox.Location = new System.Drawing.Point(7, 37);
            this.ui_ClassSkill_listBox.Name = "ui_ClassSkill_listBox";
            this.ui_ClassSkill_listBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ui_ClassSkill_listBox.Size = new System.Drawing.Size(249, 208);
            this.ui_ClassSkill_listBox.TabIndex = 0;
            // 
            // ui_RaceComboBox
            // 
            this.ui_RaceComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_RaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_RaceComboBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceComboBox.FormattingEnabled = true;
            this.ui_RaceComboBox.IntegralHeight = false;
            this.ui_RaceComboBox.Location = new System.Drawing.Point(138, 176);
            this.ui_RaceComboBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_RaceComboBox.Name = "ui_RaceComboBox";
            this.ui_RaceComboBox.Size = new System.Drawing.Size(201, 42);
            this.ui_RaceComboBox.TabIndex = 15;
            this.ui_RaceComboBox.SelectedIndexChanged += new System.EventHandler(this.ui_RaceComboBox_SelectedIndexChanged);
            // 
            // ui_ClassComboBox
            // 
            this.ui_ClassComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_ClassComboBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassComboBox.FormattingEnabled = true;
            this.ui_ClassComboBox.IntegralHeight = false;
            this.ui_ClassComboBox.Location = new System.Drawing.Point(484, 176);
            this.ui_ClassComboBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_ClassComboBox.Name = "ui_ClassComboBox";
            this.ui_ClassComboBox.Size = new System.Drawing.Size(201, 42);
            this.ui_ClassComboBox.TabIndex = 16;
            this.ui_ClassComboBox.SelectedIndexChanged += new System.EventHandler(this.ui_ClassComboBox_SelectedIndexChanged);
            // 
            // ui_DescriptionGroupBox
            // 
            this.ui_DescriptionGroupBox.Controls.Add(this.ui_DescriptionTextbox);
            this.ui_DescriptionGroupBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DescriptionGroupBox.Location = new System.Drawing.Point(736, 451);
            this.ui_DescriptionGroupBox.Name = "ui_DescriptionGroupBox";
            this.ui_DescriptionGroupBox.Size = new System.Drawing.Size(556, 274);
            this.ui_DescriptionGroupBox.TabIndex = 17;
            this.ui_DescriptionGroupBox.TabStop = false;
            this.ui_DescriptionGroupBox.Text = "DESCRIPTION:";
            // 
            // ui_DescriptionTextbox
            // 
            this.ui_DescriptionTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_DescriptionTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DescriptionTextbox.Location = new System.Drawing.Point(9, 41);
            this.ui_DescriptionTextbox.Multiline = true;
            this.ui_DescriptionTextbox.Name = "ui_DescriptionTextbox";
            this.ui_DescriptionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ui_DescriptionTextbox.Size = new System.Drawing.Size(547, 215);
            this.ui_DescriptionTextbox.TabIndex = 0;
            // 
            // ui_CreateCharacterButton
            // 
            this.ui_CreateCharacterButton.AutoSize = true;
            this.ui_CreateCharacterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_CreateCharacterButton.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_CreateCharacterButton.Location = new System.Drawing.Point(745, 734);
            this.ui_CreateCharacterButton.Name = "ui_CreateCharacterButton";
            this.ui_CreateCharacterButton.Size = new System.Drawing.Size(547, 44);
            this.ui_CreateCharacterButton.TabIndex = 18;
            this.ui_CreateCharacterButton.Text = "CREATE CHARACTER";
            this.ui_CreateCharacterButton.UseVisualStyleBackColor = false;
            this.ui_CreateCharacterButton.Click += new System.EventHandler(this.ui_CreateCharacterButton_Click);
            // 
            // Armour
            // 
            this.Armour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Armour.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Armour.FormattingEnabled = true;
            this.Armour.IntegralHeight = false;
            this.Armour.ItemHeight = 26;
            this.Armour.Location = new System.Drawing.Point(736, 176);
            this.Armour.Name = "Armour";
            this.Armour.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Armour.Size = new System.Drawing.Size(248, 202);
            this.Armour.TabIndex = 19;
            // 
            // Weapon
            // 
            this.Weapon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Weapon.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weapon.FormattingEnabled = true;
            this.Weapon.IntegralHeight = false;
            this.Weapon.ItemHeight = 26;
            this.Weapon.Location = new System.Drawing.Point(1032, 176);
            this.Weapon.Name = "Weapon";
            this.Weapon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Weapon.Size = new System.Drawing.Size(249, 202);
            this.Weapon.TabIndex = 20;
            // 
            // ui_ArmourLabel
            // 
            this.ui_ArmourLabel.AutoSize = true;
            this.ui_ArmourLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourLabel.Location = new System.Drawing.Point(736, 128);
            this.ui_ArmourLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ui_ArmourLabel.Name = "ui_ArmourLabel";
            this.ui_ArmourLabel.Size = new System.Drawing.Size(118, 34);
            this.ui_ArmourLabel.TabIndex = 21;
            this.ui_ArmourLabel.Text = "ARMOUR:";
            // 
            // ui_WeaponLabel
            // 
            this.ui_WeaponLabel.AutoSize = true;
            this.ui_WeaponLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_WeaponLabel.Location = new System.Drawing.Point(1027, 128);
            this.ui_WeaponLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ui_WeaponLabel.Name = "ui_WeaponLabel";
            this.ui_WeaponLabel.Size = new System.Drawing.Size(125, 34);
            this.ui_WeaponLabel.TabIndex = 22;
            this.ui_WeaponLabel.Text = "WEAPON:";
            // 
            // ui_Level_Label
            // 
            this.ui_Level_Label.AutoSize = true;
            this.ui_Level_Label.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_Level_Label.Location = new System.Drawing.Point(736, 25);
            this.ui_Level_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ui_Level_Label.Name = "ui_Level_Label";
            this.ui_Level_Label.Size = new System.Drawing.Size(99, 34);
            this.ui_Level_Label.TabIndex = 23;
            this.ui_Level_Label.Text = "LEVEL:";
            // 
            // ui_Level_Textbox
            // 
            this.ui_Level_Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_Level_Textbox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_Level_Textbox.Location = new System.Drawing.Point(736, 74);
            this.ui_Level_Textbox.Margin = new System.Windows.Forms.Padding(8);
            this.ui_Level_Textbox.Name = "ui_Level_Textbox";
            this.ui_Level_Textbox.Size = new System.Drawing.Size(545, 41);
            this.ui_Level_Textbox.TabIndex = 24;
            // 
            // ui_GetAvailableSkills
            // 
            this.ui_GetAvailableSkills.Location = new System.Drawing.Point(273, 499);
            this.ui_GetAvailableSkills.Name = "ui_GetAvailableSkills";
            this.ui_GetAvailableSkills.Size = new System.Drawing.Size(267, 47);
            this.ui_GetAvailableSkills.TabIndex = 25;
            this.ui_GetAvailableSkills.Text = "Preview Usable Skills";
            this.ui_GetAvailableSkills.UseVisualStyleBackColor = true;
            this.ui_GetAvailableSkills.Click += new System.EventHandler(this.ui_GetAvailableSkills_Click);
            // 
            // ui_GetClasses
            // 
            this.ui_GetClasses.Location = new System.Drawing.Point(122, 730);
            this.ui_GetClasses.Name = "ui_GetClasses";
            this.ui_GetClasses.Size = new System.Drawing.Size(556, 48);
            this.ui_GetClasses.TabIndex = 26;
            this.ui_GetClasses.Text = "Get Classes / Races That Use This Skill";
            this.ui_GetClasses.UseVisualStyleBackColor = true;
            this.ui_GetClasses.Click += new System.EventHandler(this.ui_GetClasses_Click);
            // 
            // ui_DamagetypeGet
            // 
            this.ui_DamagetypeGet.Location = new System.Drawing.Point(809, 396);
            this.ui_DamagetypeGet.Name = "ui_DamagetypeGet";
            this.ui_DamagetypeGet.Size = new System.Drawing.Size(410, 49);
            this.ui_DamagetypeGet.TabIndex = 27;
            this.ui_DamagetypeGet.Text = "Get Damage Type Statistics";
            this.ui_DamagetypeGet.UseVisualStyleBackColor = true;
            this.ui_DamagetypeGet.Click += new System.EventHandler(this.ui_DamagetypeGet_Click);
            // 
            // ui_OptimalClasses
            // 
            this.ui_OptimalClasses.Location = new System.Drawing.Point(357, 152);
            this.ui_OptimalClasses.Name = "ui_OptimalClasses";
            this.ui_OptimalClasses.Size = new System.Drawing.Size(102, 87);
            this.ui_OptimalClasses.TabIndex = 28;
            this.ui_OptimalClasses.Text = "Get Classes";
            this.ui_OptimalClasses.UseVisualStyleBackColor = true;
            this.ui_OptimalClasses.Click += new System.EventHandler(this.ui_OptimalClasses_Click);
            // 
            // ui_CreateCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1374, 813);
            this.Controls.Add(this.ui_OptimalClasses);
            this.Controls.Add(this.ui_GetClasses);
            this.Controls.Add(this.ui_GetAvailableSkills);
            this.Controls.Add(this.ui_DamagetypeGet);
            this.Controls.Add(this.ui_Level_Textbox);
            this.Controls.Add(this.ui_Level_Label);
            this.Controls.Add(this.ui_WeaponLabel);
            this.Controls.Add(this.ui_ArmourLabel);
            this.Controls.Add(this.Weapon);
            this.Controls.Add(this.Armour);
            this.Controls.Add(this.ui_CreateCharacterButton);
            this.Controls.Add(this.ui_DescriptionGroupBox);
            this.Controls.Add(this.ui_ClassComboBox);
            this.Controls.Add(this.ui_RaceComboBox);
            this.Controls.Add(this.ui_ClassSkillsGroupBox);
            this.Controls.Add(this.ui_RaceSkillGroupBox);
            this.Controls.Add(this.ui_SkillsGroupBox);
            this.Controls.Add(this.ui_ClassLabel);
            this.Controls.Add(this.ui_RaceLabel);
            this.Controls.Add(this.ui_NameLabel);
            this.Controls.Add(this.ui_NameTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "ui_CreateCharacterForm";
            this.Text = "Create Character";
            this.ui_SkillsGroupBox.ResumeLayout(false);
            this.ui_RaceSkillGroupBox.ResumeLayout(false);
            this.ui_ClassSkillsGroupBox.ResumeLayout(false);
            this.ui_DescriptionGroupBox.ResumeLayout(false);
            this.ui_DescriptionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ui_NameTextBox;
        private System.Windows.Forms.Label ui_NameLabel;
        private System.Windows.Forms.Label ui_RaceLabel;
        private System.Windows.Forms.Label ui_ClassLabel;
        private System.Windows.Forms.GroupBox ui_SkillsGroupBox;
        private System.Windows.Forms.GroupBox ui_RaceSkillGroupBox;
        private System.Windows.Forms.GroupBox ui_ClassSkillsGroupBox;
        private System.Windows.Forms.ComboBox ui_RaceComboBox;
        private System.Windows.Forms.ComboBox ui_ClassComboBox;
        private System.Windows.Forms.GroupBox ui_DescriptionGroupBox;
        private System.Windows.Forms.TextBox ui_DescriptionTextbox;
        private System.Windows.Forms.Button ui_CreateCharacterButton;
        private System.Windows.Forms.ListBox Armour;
        private System.Windows.Forms.ListBox Weapon;
        private System.Windows.Forms.Label ui_ArmourLabel;
        private System.Windows.Forms.Label ui_WeaponLabel;
        private System.Windows.Forms.Label ui_Level_Label;
        private System.Windows.Forms.TextBox ui_Level_Textbox;
        private System.Windows.Forms.Button ui_GetAvailableSkills;
        private System.Windows.Forms.Button ui_GetClasses;
        private System.Windows.Forms.Button ui_DamagetypeGet;
        private System.Windows.Forms.ListBox ui_RaceSkill_listBox;
        private System.Windows.Forms.ListBox ui_ClassSkill_listBox;
        private System.Windows.Forms.Button ui_OptimalClasses;
        private System.Windows.Forms.ListBox ui_SkillsListBox;
    }
}

