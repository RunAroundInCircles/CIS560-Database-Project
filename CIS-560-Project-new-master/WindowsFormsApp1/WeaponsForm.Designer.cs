namespace WindowsFormsApp1
{
    partial class WeaponsForm
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
            this.ui_WeaponsFormNameLabel = new System.Windows.Forms.Label();
            this.ui_WeaponsFormTextbox = new System.Windows.Forms.TextBox();
            this.ui_WeaponsFormRefreshButton = new System.Windows.Forms.Button();
            this.ui_WeaponsAddButton = new System.Windows.Forms.Button();
            this.ui_WeaponFormAttackModLabel = new System.Windows.Forms.Label();
            this.ui_WeaponsFormDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ui_WeaponsFormNameLabel
            // 
            this.ui_WeaponsFormNameLabel.AutoSize = true;
            this.ui_WeaponsFormNameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_WeaponsFormNameLabel.Location = new System.Drawing.Point(6, 17);
            this.ui_WeaponsFormNameLabel.Name = "ui_WeaponsFormNameLabel";
            this.ui_WeaponsFormNameLabel.Size = new System.Drawing.Size(70, 31);
            this.ui_WeaponsFormNameLabel.TabIndex = 0;
            this.ui_WeaponsFormNameLabel.Text = "Name";
            // 
            // ui_WeaponsFormTextbox
            // 
            this.ui_WeaponsFormTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_WeaponsFormTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_WeaponsFormTextbox.Location = new System.Drawing.Point(12, 51);
            this.ui_WeaponsFormTextbox.Multiline = true;
            this.ui_WeaponsFormTextbox.Name = "ui_WeaponsFormTextbox";
            this.ui_WeaponsFormTextbox.ReadOnly = true;
            this.ui_WeaponsFormTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ui_WeaponsFormTextbox.Size = new System.Drawing.Size(1210, 397);
            this.ui_WeaponsFormTextbox.TabIndex = 1;
            this.ui_WeaponsFormTextbox.WordWrap = false;
            // 
            // ui_WeaponsFormRefreshButton
            // 
            this.ui_WeaponsFormRefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_WeaponsFormRefreshButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_WeaponsFormRefreshButton.Location = new System.Drawing.Point(12, 454);
            this.ui_WeaponsFormRefreshButton.Name = "ui_WeaponsFormRefreshButton";
            this.ui_WeaponsFormRefreshButton.Size = new System.Drawing.Size(150, 50);
            this.ui_WeaponsFormRefreshButton.TabIndex = 4;
            this.ui_WeaponsFormRefreshButton.Text = "Refresh";
            this.ui_WeaponsFormRefreshButton.UseVisualStyleBackColor = false;
            this.ui_WeaponsFormRefreshButton.Click += new System.EventHandler(this.ui_WeaponsFormRefreshButton_Click);
            // 
            // ui_WeaponsAddButton
            // 
            this.ui_WeaponsAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_WeaponsAddButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_WeaponsAddButton.Location = new System.Drawing.Point(168, 454);
            this.ui_WeaponsAddButton.Name = "ui_WeaponsAddButton";
            this.ui_WeaponsAddButton.Size = new System.Drawing.Size(150, 50);
            this.ui_WeaponsAddButton.TabIndex = 7;
            this.ui_WeaponsAddButton.Text = "ADD";
            this.ui_WeaponsAddButton.UseVisualStyleBackColor = false;
            this.ui_WeaponsAddButton.Click += new System.EventHandler(this.ui_WeaponsAddButton_Click);
            // 
            // ui_WeaponFormAttackModLabel
            // 
            this.ui_WeaponFormAttackModLabel.AutoSize = true;
            this.ui_WeaponFormAttackModLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_WeaponFormAttackModLabel.Location = new System.Drawing.Point(446, 17);
            this.ui_WeaponFormAttackModLabel.Name = "ui_WeaponFormAttackModLabel";
            this.ui_WeaponFormAttackModLabel.Size = new System.Drawing.Size(123, 31);
            this.ui_WeaponFormAttackModLabel.TabIndex = 8;
            this.ui_WeaponFormAttackModLabel.Text = "AttackMod";
            // 
            // ui_WeaponsFormDescriptionLabel
            // 
            this.ui_WeaponsFormDescriptionLabel.AutoSize = true;
            this.ui_WeaponsFormDescriptionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_WeaponsFormDescriptionLabel.Location = new System.Drawing.Point(655, 17);
            this.ui_WeaponsFormDescriptionLabel.Name = "ui_WeaponsFormDescriptionLabel";
            this.ui_WeaponsFormDescriptionLabel.Size = new System.Drawing.Size(122, 31);
            this.ui_WeaponsFormDescriptionLabel.TabIndex = 9;
            this.ui_WeaponsFormDescriptionLabel.Text = "Description";
            // 
            // WeaponsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1234, 511);
            this.Controls.Add(this.ui_WeaponsFormDescriptionLabel);
            this.Controls.Add(this.ui_WeaponFormAttackModLabel);
            this.Controls.Add(this.ui_WeaponsAddButton);
            this.Controls.Add(this.ui_WeaponsFormRefreshButton);
            this.Controls.Add(this.ui_WeaponsFormTextbox);
            this.Controls.Add(this.ui_WeaponsFormNameLabel);
            this.Name = "WeaponsForm";
            this.Text = "Weapons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ui_WeaponsFormNameLabel;
        private System.Windows.Forms.TextBox ui_WeaponsFormTextbox;
        private System.Windows.Forms.Button ui_WeaponsFormRefreshButton;
        private System.Windows.Forms.Button ui_WeaponsAddButton;
        private System.Windows.Forms.Label ui_WeaponFormAttackModLabel;
        private System.Windows.Forms.Label ui_WeaponsFormDescriptionLabel;
    }
}