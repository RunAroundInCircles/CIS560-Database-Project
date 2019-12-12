namespace WindowsFormsApp1
{
    partial class ui_SkillsForm
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
            this.ui_SkillsFormNameLabel = new System.Windows.Forms.Label();
            this.ui_SkillsFormTextbox = new System.Windows.Forms.TextBox();
            this.ui_SkillsFormRefreshButton = new System.Windows.Forms.Button();
            this.ui_SkillsAddButton = new System.Windows.Forms.Button();
            this.ui_SkillsFormLvlReqLabel = new System.Windows.Forms.Label();
            this.ui_SkillsFormDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ui_SkillsFormNameLabel
            // 
            this.ui_SkillsFormNameLabel.AutoSize = true;
            this.ui_SkillsFormNameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsFormNameLabel.Location = new System.Drawing.Point(6, 17);
            this.ui_SkillsFormNameLabel.Name = "ui_SkillsFormNameLabel";
            this.ui_SkillsFormNameLabel.Size = new System.Drawing.Size(70, 31);
            this.ui_SkillsFormNameLabel.TabIndex = 0;
            this.ui_SkillsFormNameLabel.Text = "Name";
            // 
            // ui_SkillsFormTextbox
            // 
            this.ui_SkillsFormTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_SkillsFormTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsFormTextbox.Location = new System.Drawing.Point(12, 51);
            this.ui_SkillsFormTextbox.Multiline = true;
            this.ui_SkillsFormTextbox.Name = "ui_SkillsFormTextbox";
            this.ui_SkillsFormTextbox.ReadOnly = true;
            this.ui_SkillsFormTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ui_SkillsFormTextbox.Size = new System.Drawing.Size(1210, 397);
            this.ui_SkillsFormTextbox.TabIndex = 1;
            this.ui_SkillsFormTextbox.WordWrap = false;
            // 
            // ui_SkillsFormRefreshButton
            // 
            this.ui_SkillsFormRefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_SkillsFormRefreshButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsFormRefreshButton.Location = new System.Drawing.Point(12, 455);
            this.ui_SkillsFormRefreshButton.Name = "ui_SkillsFormRefreshButton";
            this.ui_SkillsFormRefreshButton.Size = new System.Drawing.Size(150, 50);
            this.ui_SkillsFormRefreshButton.TabIndex = 4;
            this.ui_SkillsFormRefreshButton.Text = "Refresh";
            this.ui_SkillsFormRefreshButton.UseVisualStyleBackColor = false;
            this.ui_SkillsFormRefreshButton.Click += new System.EventHandler(this.ui_SkillsFormRefreshButton_Click);
            // 
            // ui_SkillsAddButton
            // 
            this.ui_SkillsAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_SkillsAddButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsAddButton.Location = new System.Drawing.Point(168, 455);
            this.ui_SkillsAddButton.Name = "ui_SkillsAddButton";
            this.ui_SkillsAddButton.Size = new System.Drawing.Size(150, 50);
            this.ui_SkillsAddButton.TabIndex = 6;
            this.ui_SkillsAddButton.Text = "ADD";
            this.ui_SkillsAddButton.UseVisualStyleBackColor = false;
            this.ui_SkillsAddButton.Click += new System.EventHandler(this.ui_SkillsAddButton_Click);
            // 
            // ui_SkillsFormLvlReqLabel
            // 
            this.ui_SkillsFormLvlReqLabel.AutoSize = true;
            this.ui_SkillsFormLvlReqLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsFormLvlReqLabel.Location = new System.Drawing.Point(284, 17);
            this.ui_SkillsFormLvlReqLabel.Name = "ui_SkillsFormLvlReqLabel";
            this.ui_SkillsFormLvlReqLabel.Size = new System.Drawing.Size(108, 31);
            this.ui_SkillsFormLvlReqLabel.TabIndex = 7;
            this.ui_SkillsFormLvlReqLabel.Text = "Level Req";
            // 
            // ui_SkillsFormDescriptionLabel
            // 
            this.ui_SkillsFormDescriptionLabel.AutoSize = true;
            this.ui_SkillsFormDescriptionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsFormDescriptionLabel.Location = new System.Drawing.Point(496, 17);
            this.ui_SkillsFormDescriptionLabel.Name = "ui_SkillsFormDescriptionLabel";
            this.ui_SkillsFormDescriptionLabel.Size = new System.Drawing.Size(122, 31);
            this.ui_SkillsFormDescriptionLabel.TabIndex = 8;
            this.ui_SkillsFormDescriptionLabel.Text = "Description";
            // 
            // ui_SkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1234, 511);
            this.Controls.Add(this.ui_SkillsFormDescriptionLabel);
            this.Controls.Add(this.ui_SkillsFormLvlReqLabel);
            this.Controls.Add(this.ui_SkillsAddButton);
            this.Controls.Add(this.ui_SkillsFormRefreshButton);
            this.Controls.Add(this.ui_SkillsFormTextbox);
            this.Controls.Add(this.ui_SkillsFormNameLabel);
            this.Name = "ui_SkillsForm";
            this.Text = "Skills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ui_SkillsFormNameLabel;
        private System.Windows.Forms.TextBox ui_SkillsFormTextbox;
        private System.Windows.Forms.Button ui_SkillsFormRefreshButton;
        private System.Windows.Forms.Button ui_SkillsAddButton;
        private System.Windows.Forms.Label ui_SkillsFormLvlReqLabel;
        private System.Windows.Forms.Label ui_SkillsFormDescriptionLabel;
    }
}