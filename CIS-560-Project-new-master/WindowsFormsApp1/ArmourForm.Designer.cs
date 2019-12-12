namespace WindowsFormsApp1
{
    partial class ui_ArmourForm
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
            this.ui_ArmourFormNameLabel = new System.Windows.Forms.Label();
            this.ui_ArmourFormTextbox = new System.Windows.Forms.TextBox();
            this.ui_ArmourFormRefreshButton = new System.Windows.Forms.Button();
            this.ui_ArmourAddButton = new System.Windows.Forms.Button();
            this.ui_ArmourFormDmodLabel = new System.Windows.Forms.Label();
            this.ui_ArmourFormStrengthLabel = new System.Windows.Forms.Label();
            this.ui_ArmourFormWeaknessLabel = new System.Windows.Forms.Label();
            this.ui_ArmourFormDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ui_ArmourFormNameLabel
            // 
            this.ui_ArmourFormNameLabel.AutoSize = true;
            this.ui_ArmourFormNameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourFormNameLabel.Location = new System.Drawing.Point(12, 17);
            this.ui_ArmourFormNameLabel.Name = "ui_ArmourFormNameLabel";
            this.ui_ArmourFormNameLabel.Size = new System.Drawing.Size(70, 31);
            this.ui_ArmourFormNameLabel.TabIndex = 0;
            this.ui_ArmourFormNameLabel.Text = "Name";
            // 
            // ui_ArmourFormTextbox
            // 
            this.ui_ArmourFormTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ArmourFormTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourFormTextbox.Location = new System.Drawing.Point(12, 51);
            this.ui_ArmourFormTextbox.Multiline = true;
            this.ui_ArmourFormTextbox.Name = "ui_ArmourFormTextbox";
            this.ui_ArmourFormTextbox.ReadOnly = true;
            this.ui_ArmourFormTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ui_ArmourFormTextbox.Size = new System.Drawing.Size(1210, 397);
            this.ui_ArmourFormTextbox.TabIndex = 1;
            this.ui_ArmourFormTextbox.WordWrap = false;
            // 
            // ui_ArmourFormRefreshButton
            // 
            this.ui_ArmourFormRefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ArmourFormRefreshButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourFormRefreshButton.Location = new System.Drawing.Point(12, 454);
            this.ui_ArmourFormRefreshButton.Name = "ui_ArmourFormRefreshButton";
            this.ui_ArmourFormRefreshButton.Size = new System.Drawing.Size(150, 50);
            this.ui_ArmourFormRefreshButton.TabIndex = 5;
            this.ui_ArmourFormRefreshButton.Text = "Refresh";
            this.ui_ArmourFormRefreshButton.UseVisualStyleBackColor = false;
            this.ui_ArmourFormRefreshButton.Click += new System.EventHandler(this.ui_ArmourFormRefreshButton_Click);
            // 
            // ui_ArmourAddButton
            // 
            this.ui_ArmourAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ArmourAddButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourAddButton.Location = new System.Drawing.Point(168, 454);
            this.ui_ArmourAddButton.Name = "ui_ArmourAddButton";
            this.ui_ArmourAddButton.Size = new System.Drawing.Size(150, 50);
            this.ui_ArmourAddButton.TabIndex = 8;
            this.ui_ArmourAddButton.Text = "ADD";
            this.ui_ArmourAddButton.UseVisualStyleBackColor = false;
            this.ui_ArmourAddButton.Click += new System.EventHandler(this.ui_ArmourAddButton_Click);
            // 
            // ui_ArmourFormDmodLabel
            // 
            this.ui_ArmourFormDmodLabel.AutoSize = true;
            this.ui_ArmourFormDmodLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourFormDmodLabel.Location = new System.Drawing.Point(439, 17);
            this.ui_ArmourFormDmodLabel.Name = "ui_ArmourFormDmodLabel";
            this.ui_ArmourFormDmodLabel.Size = new System.Drawing.Size(123, 31);
            this.ui_ArmourFormDmodLabel.TabIndex = 9;
            this.ui_ArmourFormDmodLabel.Text = "DefenseMod";
            // 
            // ui_ArmourFormStrengthLabel
            // 
            this.ui_ArmourFormStrengthLabel.AutoSize = true;
            this.ui_ArmourFormStrengthLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourFormStrengthLabel.Location = new System.Drawing.Point(616, 17);
            this.ui_ArmourFormStrengthLabel.Name = "ui_ArmourFormStrengthLabel";
            this.ui_ArmourFormStrengthLabel.Size = new System.Drawing.Size(102, 31);
            this.ui_ArmourFormStrengthLabel.TabIndex = 10;
            this.ui_ArmourFormStrengthLabel.Text = "Strength";
            // 
            // ui_ArmourFormWeaknessLabel
            // 
            this.ui_ArmourFormWeaknessLabel.AutoSize = true;
            this.ui_ArmourFormWeaknessLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourFormWeaknessLabel.Location = new System.Drawing.Point(775, 17);
            this.ui_ArmourFormWeaknessLabel.Name = "ui_ArmourFormWeaknessLabel";
            this.ui_ArmourFormWeaknessLabel.Size = new System.Drawing.Size(109, 31);
            this.ui_ArmourFormWeaknessLabel.TabIndex = 11;
            this.ui_ArmourFormWeaknessLabel.Text = "Weakness";
            // 
            // ui_ArmourFormDescriptionLabel
            // 
            this.ui_ArmourFormDescriptionLabel.AutoSize = true;
            this.ui_ArmourFormDescriptionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourFormDescriptionLabel.Location = new System.Drawing.Point(979, 17);
            this.ui_ArmourFormDescriptionLabel.Name = "ui_ArmourFormDescriptionLabel";
            this.ui_ArmourFormDescriptionLabel.Size = new System.Drawing.Size(122, 31);
            this.ui_ArmourFormDescriptionLabel.TabIndex = 12;
            this.ui_ArmourFormDescriptionLabel.Text = "Description";
            // 
            // ui_ArmourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1234, 511);
            this.Controls.Add(this.ui_ArmourFormDescriptionLabel);
            this.Controls.Add(this.ui_ArmourFormWeaknessLabel);
            this.Controls.Add(this.ui_ArmourFormStrengthLabel);
            this.Controls.Add(this.ui_ArmourFormDmodLabel);
            this.Controls.Add(this.ui_ArmourAddButton);
            this.Controls.Add(this.ui_ArmourFormRefreshButton);
            this.Controls.Add(this.ui_ArmourFormTextbox);
            this.Controls.Add(this.ui_ArmourFormNameLabel);
            this.Name = "ui_ArmourForm";
            this.Text = "Armour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ui_ArmourFormNameLabel;
        private System.Windows.Forms.TextBox ui_ArmourFormTextbox;
        private System.Windows.Forms.Button ui_ArmourFormRefreshButton;
        private System.Windows.Forms.Button ui_ArmourAddButton;
        private System.Windows.Forms.Label ui_ArmourFormDmodLabel;
        private System.Windows.Forms.Label ui_ArmourFormStrengthLabel;
        private System.Windows.Forms.Label ui_ArmourFormWeaknessLabel;
        private System.Windows.Forms.Label ui_ArmourFormDescriptionLabel;
    }
}