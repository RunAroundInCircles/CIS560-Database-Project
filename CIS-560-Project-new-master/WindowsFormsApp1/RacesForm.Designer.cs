namespace WindowsFormsApp1
{
    partial class ui_RaceForm
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
            this.ui_RaceFormNameLabel = new System.Windows.Forms.Label();
            this.ui_RaceFormTextbox = new System.Windows.Forms.TextBox();
            this.ui_RaceFormRefreshButton = new System.Windows.Forms.Button();
            this.ui_RaceAddButton = new System.Windows.Forms.Button();
            this.ui_RaceFormDmodLabel = new System.Windows.Forms.Label();
            this.ui_RaceFormAmodLabel = new System.Windows.Forms.Label();
            this.ui_RaceFormDescritpionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ui_RaceFormNameLabel
            // 
            this.ui_RaceFormNameLabel.AutoSize = true;
            this.ui_RaceFormNameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceFormNameLabel.Location = new System.Drawing.Point(6, 17);
            this.ui_RaceFormNameLabel.Name = "ui_RaceFormNameLabel";
            this.ui_RaceFormNameLabel.Size = new System.Drawing.Size(70, 31);
            this.ui_RaceFormNameLabel.TabIndex = 0;
            this.ui_RaceFormNameLabel.Text = "Name";
            // 
            // ui_RaceFormTextbox
            // 
            this.ui_RaceFormTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_RaceFormTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceFormTextbox.Location = new System.Drawing.Point(12, 51);
            this.ui_RaceFormTextbox.Multiline = true;
            this.ui_RaceFormTextbox.Name = "ui_RaceFormTextbox";
            this.ui_RaceFormTextbox.ReadOnly = true;
            this.ui_RaceFormTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ui_RaceFormTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ui_RaceFormTextbox.Size = new System.Drawing.Size(1210, 397);
            this.ui_RaceFormTextbox.TabIndex = 1;
            this.ui_RaceFormTextbox.WordWrap = false;
            // 
            // ui_RaceFormRefreshButton
            // 
            this.ui_RaceFormRefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_RaceFormRefreshButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceFormRefreshButton.Location = new System.Drawing.Point(12, 455);
            this.ui_RaceFormRefreshButton.Name = "ui_RaceFormRefreshButton";
            this.ui_RaceFormRefreshButton.Size = new System.Drawing.Size(150, 50);
            this.ui_RaceFormRefreshButton.TabIndex = 2;
            this.ui_RaceFormRefreshButton.Text = "Refresh";
            this.ui_RaceFormRefreshButton.UseVisualStyleBackColor = false;
            this.ui_RaceFormRefreshButton.Click += new System.EventHandler(this.ui_RaceFormRefreshButton_Click);
            // 
            // ui_RaceAddButton
            // 
            this.ui_RaceAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_RaceAddButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceAddButton.Location = new System.Drawing.Point(168, 455);
            this.ui_RaceAddButton.Name = "ui_RaceAddButton";
            this.ui_RaceAddButton.Size = new System.Drawing.Size(150, 50);
            this.ui_RaceAddButton.TabIndex = 5;
            this.ui_RaceAddButton.Text = "ADD";
            this.ui_RaceAddButton.UseVisualStyleBackColor = false;
            this.ui_RaceAddButton.Click += new System.EventHandler(this.ui_RaceAddButton_Click);
            // 
            // ui_RaceFormDmodLabel
            // 
            this.ui_RaceFormDmodLabel.AutoSize = true;
            this.ui_RaceFormDmodLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceFormDmodLabel.Location = new System.Drawing.Point(465, 17);
            this.ui_RaceFormDmodLabel.Name = "ui_RaceFormDmodLabel";
            this.ui_RaceFormDmodLabel.Size = new System.Drawing.Size(123, 31);
            this.ui_RaceFormDmodLabel.TabIndex = 6;
            this.ui_RaceFormDmodLabel.Text = "DefenseMod";
            // 
            // ui_RaceFormAmodLabel
            // 
            this.ui_RaceFormAmodLabel.AutoSize = true;
            this.ui_RaceFormAmodLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceFormAmodLabel.Location = new System.Drawing.Point(283, 17);
            this.ui_RaceFormAmodLabel.Name = "ui_RaceFormAmodLabel";
            this.ui_RaceFormAmodLabel.Size = new System.Drawing.Size(123, 31);
            this.ui_RaceFormAmodLabel.TabIndex = 7;
            this.ui_RaceFormAmodLabel.Text = "AttackMod";
            // 
            // ui_RaceFormDescritpionLabel
            // 
            this.ui_RaceFormDescritpionLabel.AutoSize = true;
            this.ui_RaceFormDescritpionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceFormDescritpionLabel.Location = new System.Drawing.Point(669, 17);
            this.ui_RaceFormDescritpionLabel.Name = "ui_RaceFormDescritpionLabel";
            this.ui_RaceFormDescritpionLabel.Size = new System.Drawing.Size(122, 31);
            this.ui_RaceFormDescritpionLabel.TabIndex = 8;
            this.ui_RaceFormDescritpionLabel.Text = "Descripiton";
            // 
            // ui_RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1234, 511);
            this.Controls.Add(this.ui_RaceFormDescritpionLabel);
            this.Controls.Add(this.ui_RaceFormAmodLabel);
            this.Controls.Add(this.ui_RaceFormDmodLabel);
            this.Controls.Add(this.ui_RaceAddButton);
            this.Controls.Add(this.ui_RaceFormRefreshButton);
            this.Controls.Add(this.ui_RaceFormTextbox);
            this.Controls.Add(this.ui_RaceFormNameLabel);
            this.Name = "ui_RaceForm";
            this.Text = "Races";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ui_RaceFormNameLabel;
        private System.Windows.Forms.TextBox ui_RaceFormTextbox;
        private System.Windows.Forms.Button ui_RaceFormRefreshButton;
        private System.Windows.Forms.Button ui_RaceAddButton;
        private System.Windows.Forms.Label ui_RaceFormDmodLabel;
        private System.Windows.Forms.Label ui_RaceFormAmodLabel;
        private System.Windows.Forms.Label ui_RaceFormDescritpionLabel;
    }
}