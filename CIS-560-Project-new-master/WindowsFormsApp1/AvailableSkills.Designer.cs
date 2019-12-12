namespace WindowsFormsApp1
{
    partial class AvailableSkills
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
            this.ui_skillsListBox = new System.Windows.Forms.ListBox();
            this.ui_SkillsFormDescriptionLabel = new System.Windows.Forms.Label();
            this.ui_SkillsFormLvlReqLabel = new System.Windows.Forms.Label();
            this.ui_SkillsFormNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ui_skillsListBox
            // 
            this.ui_skillsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_skillsListBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_skillsListBox.FormattingEnabled = true;
            this.ui_skillsListBox.HorizontalScrollbar = true;
            this.ui_skillsListBox.ItemHeight = 21;
            this.ui_skillsListBox.Location = new System.Drawing.Point(24, 54);
            this.ui_skillsListBox.Name = "ui_skillsListBox";
            this.ui_skillsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ui_skillsListBox.Size = new System.Drawing.Size(1649, 361);
            this.ui_skillsListBox.TabIndex = 0;
            // 
            // ui_SkillsFormDescriptionLabel
            // 
            this.ui_SkillsFormDescriptionLabel.AutoSize = true;
            this.ui_SkillsFormDescriptionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsFormDescriptionLabel.Location = new System.Drawing.Point(554, 9);
            this.ui_SkillsFormDescriptionLabel.Name = "ui_SkillsFormDescriptionLabel";
            this.ui_SkillsFormDescriptionLabel.Size = new System.Drawing.Size(122, 31);
            this.ui_SkillsFormDescriptionLabel.TabIndex = 11;
            this.ui_SkillsFormDescriptionLabel.Text = "Description";
            // 
            // ui_SkillsFormLvlReqLabel
            // 
            this.ui_SkillsFormLvlReqLabel.AutoSize = true;
            this.ui_SkillsFormLvlReqLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsFormLvlReqLabel.Location = new System.Drawing.Point(342, 9);
            this.ui_SkillsFormLvlReqLabel.Name = "ui_SkillsFormLvlReqLabel";
            this.ui_SkillsFormLvlReqLabel.Size = new System.Drawing.Size(108, 31);
            this.ui_SkillsFormLvlReqLabel.TabIndex = 10;
            this.ui_SkillsFormLvlReqLabel.Text = "Level Req";
            // 
            // ui_SkillsFormNameLabel
            // 
            this.ui_SkillsFormNameLabel.AutoSize = true;
            this.ui_SkillsFormNameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsFormNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ui_SkillsFormNameLabel.Name = "ui_SkillsFormNameLabel";
            this.ui_SkillsFormNameLabel.Size = new System.Drawing.Size(127, 31);
            this.ui_SkillsFormNameLabel.TabIndex = 9;
            this.ui_SkillsFormNameLabel.Text = "Skill Name";
            // 
            // AvailableSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1695, 450);
            this.Controls.Add(this.ui_SkillsFormDescriptionLabel);
            this.Controls.Add(this.ui_SkillsFormLvlReqLabel);
            this.Controls.Add(this.ui_SkillsFormNameLabel);
            this.Controls.Add(this.ui_skillsListBox);
            this.Name = "AvailableSkills";
            this.Text = "AvailableSkills";
            this.Load += new System.EventHandler(this.AvailableSkills_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ui_skillsListBox;
        private System.Windows.Forms.Label ui_SkillsFormDescriptionLabel;
        private System.Windows.Forms.Label ui_SkillsFormLvlReqLabel;
        private System.Windows.Forms.Label ui_SkillsFormNameLabel;
    }
}