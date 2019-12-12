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
            this.ui_DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.ui_NameTextbox = new System.Windows.Forms.TextBox();
            this.ui_AttackModLabel = new System.Windows.Forms.Label();
            this.ui_DescriptionLabel = new System.Windows.Forms.Label();
            this.ui_NameLabel = new System.Windows.Forms.Label();
            this.ui_DamageTypeLabel = new System.Windows.Forms.Label();
            this.ui_DefModComboBox = new System.Windows.Forms.ComboBox();
            this.ui_DamageTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ui_AddButton
            // 
            this.ui_AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_AddButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_AddButton.Location = new System.Drawing.Point(23, 400);
            this.ui_AddButton.Name = "ui_AddButton";
            this.ui_AddButton.Size = new System.Drawing.Size(575, 35);
            this.ui_AddButton.TabIndex = 16;
            this.ui_AddButton.Text = "ADD";
            this.ui_AddButton.UseVisualStyleBackColor = false;
            this.ui_AddButton.Click += new System.EventHandler(this.ui_AddButton_Click);
            // 
            // ui_DescriptionTextbox
            // 
            this.ui_DescriptionTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DescriptionTextbox.Location = new System.Drawing.Point(23, 161);
            this.ui_DescriptionTextbox.Multiline = true;
            this.ui_DescriptionTextbox.Name = "ui_DescriptionTextbox";
            this.ui_DescriptionTextbox.Size = new System.Drawing.Size(575, 125);
            this.ui_DescriptionTextbox.TabIndex = 14;
            // 
            // ui_NameTextbox
            // 
            this.ui_NameTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_NameTextbox.Location = new System.Drawing.Point(23, 53);
            this.ui_NameTextbox.Name = "ui_NameTextbox";
            this.ui_NameTextbox.Size = new System.Drawing.Size(575, 38);
            this.ui_NameTextbox.TabIndex = 13;
            // 
            // ui_AttackModLabel
            // 
            this.ui_AttackModLabel.AutoSize = true;
            this.ui_AttackModLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_AttackModLabel.Location = new System.Drawing.Point(407, 307);
            this.ui_AttackModLabel.Name = "ui_AttackModLabel";
            this.ui_AttackModLabel.Size = new System.Drawing.Size(191, 34);
            this.ui_AttackModLabel.TabIndex = 12;
            this.ui_AttackModLabel.Text = "Attack Modifier:";
            // 
            // ui_DescriptionLabel
            // 
            this.ui_DescriptionLabel.AutoSize = true;
            this.ui_DescriptionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DescriptionLabel.Location = new System.Drawing.Point(17, 124);
            this.ui_DescriptionLabel.Name = "ui_DescriptionLabel";
            this.ui_DescriptionLabel.Size = new System.Drawing.Size(139, 34);
            this.ui_DescriptionLabel.TabIndex = 11;
            this.ui_DescriptionLabel.Text = "Description:";
            // 
            // ui_NameLabel
            // 
            this.ui_NameLabel.AutoSize = true;
            this.ui_NameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_NameLabel.Location = new System.Drawing.Point(17, 16);
            this.ui_NameLabel.Name = "ui_NameLabel";
            this.ui_NameLabel.Size = new System.Drawing.Size(83, 34);
            this.ui_NameLabel.TabIndex = 10;
            this.ui_NameLabel.Text = "Name:";
            // 
            // ui_DamageTypeLabel
            // 
            this.ui_DamageTypeLabel.AutoSize = true;
            this.ui_DamageTypeLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DamageTypeLabel.Location = new System.Drawing.Point(17, 307);
            this.ui_DamageTypeLabel.Name = "ui_DamageTypeLabel";
            this.ui_DamageTypeLabel.Size = new System.Drawing.Size(164, 34);
            this.ui_DamageTypeLabel.TabIndex = 17;
            this.ui_DamageTypeLabel.Text = "Damage Type:";
            // 
            // ui_DefModComboBox
            // 
            this.ui_DefModComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_DefModComboBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DefModComboBox.FormattingEnabled = true;
            this.ui_DefModComboBox.IntegralHeight = false;
            this.ui_DefModComboBox.Location = new System.Drawing.Point(413, 342);
            this.ui_DefModComboBox.MaxDropDownItems = 10;
            this.ui_DefModComboBox.Name = "ui_DefModComboBox";
            this.ui_DefModComboBox.Size = new System.Drawing.Size(185, 42);
            this.ui_DefModComboBox.TabIndex = 32;
            // 
            // ui_DamageTypeComboBox
            // 
            this.ui_DamageTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_DamageTypeComboBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DamageTypeComboBox.FormattingEnabled = true;
            this.ui_DamageTypeComboBox.IntegralHeight = false;
            this.ui_DamageTypeComboBox.Location = new System.Drawing.Point(23, 342);
            this.ui_DamageTypeComboBox.MaxDropDownItems = 5;
            this.ui_DamageTypeComboBox.Name = "ui_DamageTypeComboBox";
            this.ui_DamageTypeComboBox.Size = new System.Drawing.Size(186, 42);
            this.ui_DamageTypeComboBox.TabIndex = 34;
            // 
            // ui_AddWeaponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(614, 451);
            this.Controls.Add(this.ui_DamageTypeComboBox);
            this.Controls.Add(this.ui_DefModComboBox);
            this.Controls.Add(this.ui_DamageTypeLabel);
            this.Controls.Add(this.ui_AddButton);
            this.Controls.Add(this.ui_DescriptionTextbox);
            this.Controls.Add(this.ui_NameTextbox);
            this.Controls.Add(this.ui_AttackModLabel);
            this.Controls.Add(this.ui_DescriptionLabel);
            this.Controls.Add(this.ui_NameLabel);
            this.Name = "ui_AddWeaponForm";
            this.Text = "Add Weapon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ui_AddButton;
        private System.Windows.Forms.TextBox ui_DescriptionTextbox;
        private System.Windows.Forms.TextBox ui_NameTextbox;
        private System.Windows.Forms.Label ui_AttackModLabel;
        private System.Windows.Forms.Label ui_DescriptionLabel;
        private System.Windows.Forms.Label ui_NameLabel;
        private System.Windows.Forms.Label ui_DamageTypeLabel;
        private System.Windows.Forms.ComboBox ui_DefModComboBox;
        private System.Windows.Forms.ComboBox ui_DamageTypeComboBox;
    }
}