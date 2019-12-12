namespace WindowsFormsApp1
{
    partial class ui_AddRaceForm
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
            this.ui_NameLabel = new System.Windows.Forms.Label();
            this.ui_DescriptionLabel = new System.Windows.Forms.Label();
            this.ui_AttackModLabel = new System.Windows.Forms.Label();
            this.ui_DefenseModLabel = new System.Windows.Forms.Label();
            this.ui_NameTextbox = new System.Windows.Forms.TextBox();
            this.ui_DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.ui_DefenseModTextbox = new System.Windows.Forms.TextBox();
            this.ui_AttackModTextbox = new System.Windows.Forms.TextBox();
            this.ui_AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ui_NameLabel
            // 
            this.ui_NameLabel.AutoSize = true;
            this.ui_NameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_NameLabel.Location = new System.Drawing.Point(12, 20);
            this.ui_NameLabel.Name = "ui_NameLabel";
            this.ui_NameLabel.Size = new System.Drawing.Size(83, 34);
            this.ui_NameLabel.TabIndex = 0;
            this.ui_NameLabel.Text = "Name:";
            // 
            // ui_DescriptionLabel
            // 
            this.ui_DescriptionLabel.AutoSize = true;
            this.ui_DescriptionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DescriptionLabel.Location = new System.Drawing.Point(12, 128);
            this.ui_DescriptionLabel.Name = "ui_DescriptionLabel";
            this.ui_DescriptionLabel.Size = new System.Drawing.Size(139, 34);
            this.ui_DescriptionLabel.TabIndex = 1;
            this.ui_DescriptionLabel.Text = "Description:";
            // 
            // ui_AttackModLabel
            // 
            this.ui_AttackModLabel.AutoSize = true;
            this.ui_AttackModLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_AttackModLabel.Location = new System.Drawing.Point(12, 311);
            this.ui_AttackModLabel.Name = "ui_AttackModLabel";
            this.ui_AttackModLabel.Size = new System.Drawing.Size(191, 34);
            this.ui_AttackModLabel.TabIndex = 2;
            this.ui_AttackModLabel.Text = "Attack Modifier:";
            // 
            // ui_DefenseModLabel
            // 
            this.ui_DefenseModLabel.AutoSize = true;
            this.ui_DefenseModLabel.Font = new System.Drawing.Font("Viner Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DefenseModLabel.Location = new System.Drawing.Point(400, 311);
            this.ui_DefenseModLabel.Name = "ui_DefenseModLabel";
            this.ui_DefenseModLabel.Size = new System.Drawing.Size(192, 34);
            this.ui_DefenseModLabel.TabIndex = 3;
            this.ui_DefenseModLabel.Text = "Defense Modifier:";
            // 
            // ui_NameTextbox
            // 
            this.ui_NameTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_NameTextbox.Location = new System.Drawing.Point(18, 57);
            this.ui_NameTextbox.Name = "ui_NameTextbox";
            this.ui_NameTextbox.Size = new System.Drawing.Size(258, 38);
            this.ui_NameTextbox.TabIndex = 4;
            // 
            // ui_DescriptionTextbox
            // 
            this.ui_DescriptionTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DescriptionTextbox.Location = new System.Drawing.Point(18, 165);
            this.ui_DescriptionTextbox.Multiline = true;
            this.ui_DescriptionTextbox.Name = "ui_DescriptionTextbox";
            this.ui_DescriptionTextbox.Size = new System.Drawing.Size(575, 125);
            this.ui_DescriptionTextbox.TabIndex = 5;
            // 
            // ui_DefenseModTextbox
            // 
            this.ui_DefenseModTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_DefenseModTextbox.Location = new System.Drawing.Point(406, 348);
            this.ui_DefenseModTextbox.Name = "ui_DefenseModTextbox";
            this.ui_DefenseModTextbox.Size = new System.Drawing.Size(186, 38);
            this.ui_DefenseModTextbox.TabIndex = 7;
            // 
            // ui_AttackModTextbox
            // 
            this.ui_AttackModTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_AttackModTextbox.Location = new System.Drawing.Point(18, 348);
            this.ui_AttackModTextbox.Name = "ui_AttackModTextbox";
            this.ui_AttackModTextbox.Size = new System.Drawing.Size(186, 38);
            this.ui_AttackModTextbox.TabIndex = 8;
            // 
            // ui_AddButton
            // 
            this.ui_AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_AddButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_AddButton.Location = new System.Drawing.Point(18, 404);
            this.ui_AddButton.Name = "ui_AddButton";
            this.ui_AddButton.Size = new System.Drawing.Size(574, 35);
            this.ui_AddButton.TabIndex = 9;
            this.ui_AddButton.Text = "ADD";
            this.ui_AddButton.UseVisualStyleBackColor = false;
            // 
            // ui_AddRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(614, 451);
            this.Controls.Add(this.ui_AddButton);
            this.Controls.Add(this.ui_AttackModTextbox);
            this.Controls.Add(this.ui_DefenseModTextbox);
            this.Controls.Add(this.ui_DescriptionTextbox);
            this.Controls.Add(this.ui_NameTextbox);
            this.Controls.Add(this.ui_DefenseModLabel);
            this.Controls.Add(this.ui_AttackModLabel);
            this.Controls.Add(this.ui_DescriptionLabel);
            this.Controls.Add(this.ui_NameLabel);
            this.Name = "ui_AddRaceForm";
            this.Text = "Add Race";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ui_NameLabel;
        private System.Windows.Forms.Label ui_DescriptionLabel;
        private System.Windows.Forms.Label ui_AttackModLabel;
        private System.Windows.Forms.Label ui_DefenseModLabel;
        private System.Windows.Forms.TextBox ui_NameTextbox;
        private System.Windows.Forms.TextBox ui_DescriptionTextbox;
        private System.Windows.Forms.TextBox ui_DefenseModTextbox;
        private System.Windows.Forms.TextBox ui_AttackModTextbox;
        private System.Windows.Forms.Button ui_AddButton;
    }
}