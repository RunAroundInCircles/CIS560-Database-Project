namespace WindowsFormsApp1
{
    partial class ui_AddArmourForm
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
            this.ui_DescriptionLabel = new System.Windows.Forms.Label();
            this.ui_NameLabel = new System.Windows.Forms.Label();
            this.ui_TypeLabel = new System.Windows.Forms.Label();
            this.ui_StrengthLabel = new System.Windows.Forms.Label();
            this.ui_WeaknessLabel = new System.Windows.Forms.Label();
            this.ui_DefenseModLabel = new System.Windows.Forms.Label();
            this.ui_DefModComboBox = new System.Windows.Forms.ComboBox();
            this.ui_WeaknessComboBox = new System.Windows.Forms.ComboBox();
            this.ui_StrengthComboBox = new System.Windows.Forms.ComboBox();
            this.ui_ArmourTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ui_AddButton
            // 
            this.ui_AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_AddButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_AddButton.Location = new System.Drawing.Point(12, 402);
            this.ui_AddButton.Name = "ui_AddButton";
            this.ui_AddButton.Size = new System.Drawing.Size(760, 35);
            this.ui_AddButton.TabIndex = 21;
            this.ui_AddButton.Text = "ADD";
            this.ui_AddButton.UseVisualStyleBackColor = false;
            this.ui_AddButton.Click += new System.EventHandler(this.ui_AddButton_Click);
            // 
            // ui_DescriptionTextbox
            // 
            this.ui_DescriptionTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DescriptionTextbox.Location = new System.Drawing.Point(12, 271);
            this.ui_DescriptionTextbox.Multiline = true;
            this.ui_DescriptionTextbox.Name = "ui_DescriptionTextbox";
            this.ui_DescriptionTextbox.Size = new System.Drawing.Size(760, 125);
            this.ui_DescriptionTextbox.TabIndex = 20;
            // 
            // ui_NameTextbox
            // 
            this.ui_NameTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_NameTextbox.Location = new System.Drawing.Point(18, 55);
            this.ui_NameTextbox.Name = "ui_NameTextbox";
            this.ui_NameTextbox.Size = new System.Drawing.Size(258, 38);
            this.ui_NameTextbox.TabIndex = 19;
            // 
            // ui_DescriptionLabel
            // 
            this.ui_DescriptionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DescriptionLabel.Location = new System.Drawing.Point(6, 234);
            this.ui_DescriptionLabel.Name = "ui_DescriptionLabel";
            this.ui_DescriptionLabel.Size = new System.Drawing.Size(139, 34);
            this.ui_DescriptionLabel.TabIndex = 18;
            this.ui_DescriptionLabel.Text = "Description:";
            // 
            // ui_NameLabel
            // 
            this.ui_NameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_NameLabel.Location = new System.Drawing.Point(12, 18);
            this.ui_NameLabel.Name = "ui_NameLabel";
            this.ui_NameLabel.Size = new System.Drawing.Size(83, 34);
            this.ui_NameLabel.TabIndex = 17;
            this.ui_NameLabel.Text = "Name:";
            // 
            // ui_TypeLabel
            // 
            this.ui_TypeLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_TypeLabel.Location = new System.Drawing.Point(322, 18);
            this.ui_TypeLabel.Name = "ui_TypeLabel";
            this.ui_TypeLabel.Size = new System.Drawing.Size(73, 34);
            this.ui_TypeLabel.TabIndex = 22;
            this.ui_TypeLabel.Text = "Type:";
            // 
            // ui_StrengthLabel
            // 
            this.ui_StrengthLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_StrengthLabel.Location = new System.Drawing.Point(12, 132);
            this.ui_StrengthLabel.Name = "ui_StrengthLabel";
            this.ui_StrengthLabel.Size = new System.Drawing.Size(116, 34);
            this.ui_StrengthLabel.TabIndex = 26;
            this.ui_StrengthLabel.Text = "Strength:";
            // 
            // ui_WeaknessLabel
            // 
            this.ui_WeaknessLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_WeaknessLabel.Location = new System.Drawing.Point(322, 132);
            this.ui_WeaknessLabel.Name = "ui_WeaknessLabel";
            this.ui_WeaknessLabel.Size = new System.Drawing.Size(128, 34);
            this.ui_WeaknessLabel.TabIndex = 27;
            this.ui_WeaknessLabel.Text = "Weakness:";
            // 
            // ui_DefenseModLabel
            // 
            this.ui_DefenseModLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DefenseModLabel.Location = new System.Drawing.Point(565, 132);
            this.ui_DefenseModLabel.Name = "ui_DefenseModLabel";
            this.ui_DefenseModLabel.Size = new System.Drawing.Size(192, 34);
            this.ui_DefenseModLabel.TabIndex = 28;
            this.ui_DefenseModLabel.Text = "Defense Modifier:";
            // 
            // ui_DefModComboBox
            // 
            this.ui_DefModComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_DefModComboBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DefModComboBox.FormattingEnabled = true;
            this.ui_DefModComboBox.IntegralHeight = false;
            this.ui_DefModComboBox.Location = new System.Drawing.Point(571, 167);
            this.ui_DefModComboBox.MaxDropDownItems = 5;
            this.ui_DefModComboBox.Name = "ui_DefModComboBox";
            this.ui_DefModComboBox.Size = new System.Drawing.Size(186, 42);
            this.ui_DefModComboBox.TabIndex = 31;
            // 
            // ui_WeaknessComboBox
            // 
            this.ui_WeaknessComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_WeaknessComboBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_WeaknessComboBox.FormattingEnabled = true;
            this.ui_WeaknessComboBox.IntegralHeight = false;
            this.ui_WeaknessComboBox.Location = new System.Drawing.Point(328, 167);
            this.ui_WeaknessComboBox.MaxDropDownItems = 5;
            this.ui_WeaknessComboBox.Name = "ui_WeaknessComboBox";
            this.ui_WeaknessComboBox.Size = new System.Drawing.Size(186, 42);
            this.ui_WeaknessComboBox.TabIndex = 32;
            // 
            // ui_StrengthComboBox
            // 
            this.ui_StrengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_StrengthComboBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_StrengthComboBox.FormattingEnabled = true;
            this.ui_StrengthComboBox.IntegralHeight = false;
            this.ui_StrengthComboBox.Location = new System.Drawing.Point(18, 167);
            this.ui_StrengthComboBox.MaxDropDownItems = 5;
            this.ui_StrengthComboBox.Name = "ui_StrengthComboBox";
            this.ui_StrengthComboBox.Size = new System.Drawing.Size(186, 42);
            this.ui_StrengthComboBox.TabIndex = 33;
            // 
            // ui_ArmourTypeComboBox
            // 
            this.ui_ArmourTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_ArmourTypeComboBox.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourTypeComboBox.FormattingEnabled = true;
            this.ui_ArmourTypeComboBox.IntegralHeight = false;
            this.ui_ArmourTypeComboBox.Location = new System.Drawing.Point(328, 53);
            this.ui_ArmourTypeComboBox.MaxDropDownItems = 5;
            this.ui_ArmourTypeComboBox.Name = "ui_ArmourTypeComboBox";
            this.ui_ArmourTypeComboBox.Size = new System.Drawing.Size(186, 42);
            this.ui_ArmourTypeComboBox.TabIndex = 34;
            // 
            // ui_AddArmourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.ui_ArmourTypeComboBox);
            this.Controls.Add(this.ui_StrengthComboBox);
            this.Controls.Add(this.ui_WeaknessComboBox);
            this.Controls.Add(this.ui_DefModComboBox);
            this.Controls.Add(this.ui_DefenseModLabel);
            this.Controls.Add(this.ui_WeaknessLabel);
            this.Controls.Add(this.ui_StrengthLabel);
            this.Controls.Add(this.ui_TypeLabel);
            this.Controls.Add(this.ui_AddButton);
            this.Controls.Add(this.ui_DescriptionTextbox);
            this.Controls.Add(this.ui_NameTextbox);
            this.Controls.Add(this.ui_DescriptionLabel);
            this.Controls.Add(this.ui_NameLabel);
            this.Name = "ui_AddArmourForm";
            this.Text = "Add Armour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ui_AddButton;
        private System.Windows.Forms.TextBox ui_DescriptionTextbox;
        private System.Windows.Forms.TextBox ui_NameTextbox;
        private System.Windows.Forms.Label ui_DescriptionLabel;
        private System.Windows.Forms.Label ui_NameLabel;
        private System.Windows.Forms.Label ui_TypeLabel;
        private System.Windows.Forms.Label ui_StrengthLabel;
        private System.Windows.Forms.Label ui_WeaknessLabel;
        private System.Windows.Forms.Label ui_DefenseModLabel;
        private System.Windows.Forms.ComboBox ui_DefModComboBox;
        private System.Windows.Forms.ComboBox ui_WeaknessComboBox;
        private System.Windows.Forms.ComboBox ui_StrengthComboBox;
        private System.Windows.Forms.ComboBox ui_ArmourTypeComboBox;
    }
}