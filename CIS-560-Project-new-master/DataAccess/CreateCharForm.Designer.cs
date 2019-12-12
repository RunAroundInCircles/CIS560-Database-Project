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
            this.ui_RaceSkillGroupBox = new System.Windows.Forms.GroupBox();
            this.ui_ClassSkillsGroupBox = new System.Windows.Forms.GroupBox();
            this.ui_ArmourGroupBox = new System.Windows.Forms.GroupBox();
            this.ui_WeaponsGroupBox = new System.Windows.Forms.GroupBox();
            this.ui_RaceComboBox = new System.Windows.Forms.ComboBox();
            this.ui_ClassComboBox = new System.Windows.Forms.ComboBox();
            this.ui_RaceSkillsTextbox = new System.Windows.Forms.TextBox();
            this.ui_ClassSkillsTextbox = new System.Windows.Forms.TextBox();
            this.ui_SkillsTextbox = new System.Windows.Forms.TextBox();
            this.ui_ArmourTextbox = new System.Windows.Forms.TextBox();
            this.ui_WeaponsTextbox = new System.Windows.Forms.TextBox();
            this.ui_SkillsGroupBox.SuspendLayout();
            this.ui_RaceSkillGroupBox.SuspendLayout();
            this.ui_ClassSkillsGroupBox.SuspendLayout();
            this.ui_ArmourGroupBox.SuspendLayout();
            this.ui_WeaponsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_NameTextBox
            // 
            this.ui_NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_NameTextBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_NameTextBox.Location = new System.Drawing.Point(139, 74);
            this.ui_NameTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.ui_NameTextBox.Name = "ui_NameTextBox";
            this.ui_NameTextBox.Size = new System.Drawing.Size(450, 41);
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
            this.ui_RaceLabel.Location = new System.Drawing.Point(133, 135);
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
            this.ui_ClassLabel.Location = new System.Drawing.Point(382, 135);
            this.ui_ClassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ui_ClassLabel.Name = "ui_ClassLabel";
            this.ui_ClassLabel.Size = new System.Drawing.Size(102, 34);
            this.ui_ClassLabel.TabIndex = 6;
            this.ui_ClassLabel.Text = "CLASS:";
            // 
            // ui_SkillsGroupBox
            // 
            this.ui_SkillsGroupBox.Controls.Add(this.ui_SkillsTextbox);
            this.ui_SkillsGroupBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsGroupBox.Location = new System.Drawing.Point(139, 519);
            this.ui_SkillsGroupBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_SkillsGroupBox.Name = "ui_SkillsGroupBox";
            this.ui_SkillsGroupBox.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_SkillsGroupBox.Size = new System.Drawing.Size(450, 250);
            this.ui_SkillsGroupBox.TabIndex = 10;
            this.ui_SkillsGroupBox.TabStop = false;
            this.ui_SkillsGroupBox.Text = "Skills:";
            this.ui_SkillsGroupBox.Enter += new System.EventHandler(this.ui_Skills_Enter);
            // 
            // ui_RaceSkillGroupBox
            // 
            this.ui_RaceSkillGroupBox.Controls.Add(this.ui_RaceSkillsTextbox);
            this.ui_RaceSkillGroupBox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceSkillGroupBox.Location = new System.Drawing.Point(139, 238);
            this.ui_RaceSkillGroupBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_RaceSkillGroupBox.Name = "ui_RaceSkillGroupBox";
            this.ui_RaceSkillGroupBox.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_RaceSkillGroupBox.Size = new System.Drawing.Size(201, 250);
            this.ui_RaceSkillGroupBox.TabIndex = 11;
            this.ui_RaceSkillGroupBox.TabStop = false;
            this.ui_RaceSkillGroupBox.Text = "RACE SKILLS:";
            // 
            // ui_ClassSkillsGroupBox
            // 
            this.ui_ClassSkillsGroupBox.Controls.Add(this.ui_ClassSkillsTextbox);
            this.ui_ClassSkillsGroupBox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassSkillsGroupBox.Location = new System.Drawing.Point(388, 238);
            this.ui_ClassSkillsGroupBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_ClassSkillsGroupBox.Name = "ui_ClassSkillsGroupBox";
            this.ui_ClassSkillsGroupBox.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_ClassSkillsGroupBox.Size = new System.Drawing.Size(201, 250);
            this.ui_ClassSkillsGroupBox.TabIndex = 12;
            this.ui_ClassSkillsGroupBox.TabStop = false;
            this.ui_ClassSkillsGroupBox.Text = "CLASS SKILLS:";
            // 
            // ui_ArmourGroupBox
            // 
            this.ui_ArmourGroupBox.Controls.Add(this.ui_ArmourTextbox);
            this.ui_ArmourGroupBox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourGroupBox.Location = new System.Drawing.Point(139, 811);
            this.ui_ArmourGroupBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_ArmourGroupBox.Name = "ui_ArmourGroupBox";
            this.ui_ArmourGroupBox.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_ArmourGroupBox.Size = new System.Drawing.Size(201, 250);
            this.ui_ArmourGroupBox.TabIndex = 13;
            this.ui_ArmourGroupBox.TabStop = false;
            this.ui_ArmourGroupBox.Text = "ARMOUR:";
            // 
            // ui_WeaponsGroupBox
            // 
            this.ui_WeaponsGroupBox.Controls.Add(this.ui_WeaponsTextbox);
            this.ui_WeaponsGroupBox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_WeaponsGroupBox.Location = new System.Drawing.Point(388, 811);
            this.ui_WeaponsGroupBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_WeaponsGroupBox.Name = "ui_WeaponsGroupBox";
            this.ui_WeaponsGroupBox.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_WeaponsGroupBox.Size = new System.Drawing.Size(201, 250);
            this.ui_WeaponsGroupBox.TabIndex = 14;
            this.ui_WeaponsGroupBox.TabStop = false;
            this.ui_WeaponsGroupBox.Text = "WEAPONS:";
            // 
            // ui_RaceComboBox
            // 
            this.ui_RaceComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_RaceComboBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceComboBox.FormattingEnabled = true;
            this.ui_RaceComboBox.Location = new System.Drawing.Point(139, 172);
            this.ui_RaceComboBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_RaceComboBox.Name = "ui_RaceComboBox";
            this.ui_RaceComboBox.Size = new System.Drawing.Size(201, 42);
            this.ui_RaceComboBox.TabIndex = 15;
            // 
            // ui_ClassComboBox
            // 
            this.ui_ClassComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ClassComboBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassComboBox.FormattingEnabled = true;
            this.ui_ClassComboBox.Location = new System.Drawing.Point(388, 172);
            this.ui_ClassComboBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ui_ClassComboBox.Name = "ui_ClassComboBox";
            this.ui_ClassComboBox.Size = new System.Drawing.Size(201, 42);
            this.ui_ClassComboBox.TabIndex = 16;
            // 
            // ui_RaceSkillsTextbox
            // 
            this.ui_RaceSkillsTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_RaceSkillsTextbox.Location = new System.Drawing.Point(8, 37);
            this.ui_RaceSkillsTextbox.Multiline = true;
            this.ui_RaceSkillsTextbox.Name = "ui_RaceSkillsTextbox";
            this.ui_RaceSkillsTextbox.ReadOnly = true;
            this.ui_RaceSkillsTextbox.Size = new System.Drawing.Size(186, 208);
            this.ui_RaceSkillsTextbox.TabIndex = 0;
            // 
            // ui_ClassSkillsTextbox
            // 
            this.ui_ClassSkillsTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ClassSkillsTextbox.Location = new System.Drawing.Point(8, 37);
            this.ui_ClassSkillsTextbox.Multiline = true;
            this.ui_ClassSkillsTextbox.Name = "ui_ClassSkillsTextbox";
            this.ui_ClassSkillsTextbox.ReadOnly = true;
            this.ui_ClassSkillsTextbox.Size = new System.Drawing.Size(186, 208);
            this.ui_ClassSkillsTextbox.TabIndex = 0;
            // 
            // ui_SkillsTextbox
            // 
            this.ui_SkillsTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_SkillsTextbox.Location = new System.Drawing.Point(8, 40);
            this.ui_SkillsTextbox.Multiline = true;
            this.ui_SkillsTextbox.Name = "ui_SkillsTextbox";
            this.ui_SkillsTextbox.ReadOnly = true;
            this.ui_SkillsTextbox.Size = new System.Drawing.Size(435, 205);
            this.ui_SkillsTextbox.TabIndex = 0;
            // 
            // ui_ArmourTextbox
            // 
            this.ui_ArmourTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ArmourTextbox.Location = new System.Drawing.Point(8, 37);
            this.ui_ArmourTextbox.Multiline = true;
            this.ui_ArmourTextbox.Name = "ui_ArmourTextbox";
            this.ui_ArmourTextbox.ReadOnly = true;
            this.ui_ArmourTextbox.Size = new System.Drawing.Size(186, 208);
            this.ui_ArmourTextbox.TabIndex = 0;
            // 
            // ui_WeaponsTextbox
            // 
            this.ui_WeaponsTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_WeaponsTextbox.Location = new System.Drawing.Point(8, 37);
            this.ui_WeaponsTextbox.Multiline = true;
            this.ui_WeaponsTextbox.Name = "ui_WeaponsTextbox";
            this.ui_WeaponsTextbox.ReadOnly = true;
            this.ui_WeaponsTextbox.Size = new System.Drawing.Size(186, 208);
            this.ui_WeaponsTextbox.TabIndex = 0;
            // 
            // ui_CreateCharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(733, 1211);
            this.Controls.Add(this.ui_ClassComboBox);
            this.Controls.Add(this.ui_RaceComboBox);
            this.Controls.Add(this.ui_ArmourGroupBox);
            this.Controls.Add(this.ui_WeaponsGroupBox);
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
            this.ui_SkillsGroupBox.PerformLayout();
            this.ui_RaceSkillGroupBox.ResumeLayout(false);
            this.ui_RaceSkillGroupBox.PerformLayout();
            this.ui_ClassSkillsGroupBox.ResumeLayout(false);
            this.ui_ClassSkillsGroupBox.PerformLayout();
            this.ui_ArmourGroupBox.ResumeLayout(false);
            this.ui_ArmourGroupBox.PerformLayout();
            this.ui_WeaponsGroupBox.ResumeLayout(false);
            this.ui_WeaponsGroupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox ui_ArmourGroupBox;
        private System.Windows.Forms.GroupBox ui_WeaponsGroupBox;
        private System.Windows.Forms.ComboBox ui_RaceComboBox;
        private System.Windows.Forms.ComboBox ui_ClassComboBox;
        private System.Windows.Forms.TextBox ui_SkillsTextbox;
        private System.Windows.Forms.TextBox ui_RaceSkillsTextbox;
        private System.Windows.Forms.TextBox ui_ClassSkillsTextbox;
        private System.Windows.Forms.TextBox ui_ArmourTextbox;
        private System.Windows.Forms.TextBox ui_WeaponsTextbox;
    }
}

