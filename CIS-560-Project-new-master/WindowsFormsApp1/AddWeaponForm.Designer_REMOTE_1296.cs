namespace WindowsFormsApp1
{
    partial class ui_AddWeaponForm
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
            this.ui_AddButton = new System.Windows.Forms.Button();
            this.ui_AttackModTextbox = new System.Windows.Forms.TextBox();
            this.ui_DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.ui_NameTextbox = new System.Windows.Forms.TextBox();
            this.ui_AttackModLabel = new System.Windows.Forms.Label();
            this.ui_DescriptionLabel = new System.Windows.Forms.Label();
            this.ui_NameLabel = new System.Windows.Forms.Label();
            this.ui_DamageTypeLabel = new System.Windows.Forms.Label();
            this.ui_DamageTypeTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ui_AddButton
            // 
            this.ui_AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_AddButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_AddButton.Location = new System.Drawing.Point(31, 492);
            this.ui_AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ui_AddButton.Name = "ui_AddButton";
            this.ui_AddButton.Size = new System.Drawing.Size(765, 43);
            this.ui_AddButton.TabIndex = 16;
            this.ui_AddButton.Text = "ADD";
            this.ui_AddButton.UseVisualStyleBackColor = false;
            this.ui_AddButton.Click += new System.EventHandler(this.ui_AddButton_Click);
            // 
            // ui_AttackModTextbox
            // 
            this.ui_AttackModTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_AttackModTextbox.Location = new System.Drawing.Point(548, 423);
            this.ui_AttackModTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ui_AttackModTextbox.Name = "ui_AttackModTextbox";
            this.ui_AttackModTextbox.Size = new System.Drawing.Size(247, 46);
            this.ui_AttackModTextbox.TabIndex = 15;
            this.ui_AttackModTextbox.TextChanged += new System.EventHandler(this.ui_AttackModTextbox_TextChanged);
            // 
            // ui_DescriptionTextbox
            // 
            this.ui_DescriptionTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DescriptionTextbox.Location = new System.Drawing.Point(31, 198);
            this.ui_DescriptionTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ui_DescriptionTextbox.Multiline = true;
            this.ui_DescriptionTextbox.Name = "ui_DescriptionTextbox";
            this.ui_DescriptionTextbox.Size = new System.Drawing.Size(765, 153);
            this.ui_DescriptionTextbox.TabIndex = 14;
            this.ui_DescriptionTextbox.TextChanged += new System.EventHandler(this.ui_DescriptionTextbox_TextChanged);
            // 
            // ui_NameTextbox
            // 
            this.ui_NameTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_NameTextbox.Location = new System.Drawing.Point(31, 65);
            this.ui_NameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ui_NameTextbox.Name = "ui_NameTextbox";
            this.ui_NameTextbox.Size = new System.Drawing.Size(343, 46);
            this.ui_NameTextbox.TabIndex = 13;
            this.ui_NameTextbox.TextChanged += new System.EventHandler(this.ui_NameTextbox_TextChanged);
            // 
            // ui_AttackModLabel
            // 
            this.ui_AttackModLabel.AutoSize = true;
            this.ui_AttackModLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_AttackModLabel.Location = new System.Drawing.Point(540, 378);
            this.ui_AttackModLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ui_AttackModLabel.Name = "ui_AttackModLabel";
            this.ui_AttackModLabel.Size = new System.Drawing.Size(246, 44);
            this.ui_AttackModLabel.TabIndex = 12;
            this.ui_AttackModLabel.Text = "Attack Modifier:";
            // 
            // ui_DescriptionLabel
            // 
            this.ui_DescriptionLabel.AutoSize = true;
            this.ui_DescriptionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DescriptionLabel.Location = new System.Drawing.Point(23, 153);
            this.ui_DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ui_DescriptionLabel.Name = "ui_DescriptionLabel";
            this.ui_DescriptionLabel.Size = new System.Drawing.Size(180, 44);
            this.ui_DescriptionLabel.TabIndex = 11;
            this.ui_DescriptionLabel.Text = "Description:";
            // 
            // ui_NameLabel
            // 
            this.ui_NameLabel.AutoSize = true;
            this.ui_NameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_NameLabel.Location = new System.Drawing.Point(23, 20);
            this.ui_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ui_NameLabel.Name = "ui_NameLabel";
            this.ui_NameLabel.Size = new System.Drawing.Size(108, 44);
            this.ui_NameLabel.TabIndex = 10;
            this.ui_NameLabel.Text = "Name:";
            // 
            // ui_DamageTypeLabel
            // 
            this.ui_DamageTypeLabel.AutoSize = true;
            this.ui_DamageTypeLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DamageTypeLabel.Location = new System.Drawing.Point(23, 378);
            this.ui_DamageTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ui_DamageTypeLabel.Name = "ui_DamageTypeLabel";
            this.ui_DamageTypeLabel.Size = new System.Drawing.Size(210, 44);
            this.ui_DamageTypeLabel.TabIndex = 17;
            this.ui_DamageTypeLabel.Text = "Damage Type:";
            // 
            // ui_DamageTypeTextbox
            // 
            this.ui_DamageTypeTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DamageTypeTextbox.Location = new System.Drawing.Point(31, 423);
            this.ui_DamageTypeTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ui_DamageTypeTextbox.Name = "ui_DamageTypeTextbox";
            this.ui_DamageTypeTextbox.Size = new System.Drawing.Size(247, 46);
            this.ui_DamageTypeTextbox.TabIndex = 18;
            this.ui_DamageTypeTextbox.TextChanged += new System.EventHandler(this.ui_DamageTypeTextbox_TextChanged);
            // 
            // ui_AddWeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(819, 555);
            this.Controls.Add(this.ui_DamageTypeTextbox);
            this.Controls.Add(this.ui_DamageTypeLabel);
            this.Controls.Add(this.ui_AddButton);
            this.Controls.Add(this.ui_AttackModTextbox);
            this.Controls.Add(this.ui_DescriptionTextbox);
            this.Controls.Add(this.ui_NameTextbox);
            this.Controls.Add(this.ui_AttackModLabel);
            this.Controls.Add(this.ui_DescriptionLabel);
            this.Controls.Add(this.ui_NameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ui_AddWeaponForm";
            this.Text = "Add Weapon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ui_AddButton;
        private System.Windows.Forms.TextBox ui_AttackModTextbox;
        private System.Windows.Forms.TextBox ui_DescriptionTextbox;
        private System.Windows.Forms.TextBox ui_NameTextbox;
        private System.Windows.Forms.Label ui_AttackModLabel;
        private System.Windows.Forms.Label ui_DescriptionLabel;
        private System.Windows.Forms.Label ui_NameLabel;
        private System.Windows.Forms.Label ui_DamageTypeLabel;
        private System.Windows.Forms.TextBox ui_DamageTypeTextbox;
    }
}