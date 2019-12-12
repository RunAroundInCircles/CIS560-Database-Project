namespace WindowsFormsApp1
{
    partial class ui_ClassForm
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
            this.ui_ClassFormNameLabel = new System.Windows.Forms.Label();
            this.ui_ClassFormTextbox = new System.Windows.Forms.TextBox();
            this.ui_ClassFormRefreshButton = new System.Windows.Forms.Button();
            this.ui_AddClassButton = new System.Windows.Forms.Button();
            this.ui_ClassFormDescriptionLabel = new System.Windows.Forms.Label();
            this.ui_ClassFormDmodLabel = new System.Windows.Forms.Label();
            this.ui_ClassFormAmodLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ui_ClassFormNameLabel
            // 
            this.ui_ClassFormNameLabel.AutoSize = true;
            this.ui_ClassFormNameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassFormNameLabel.Location = new System.Drawing.Point(6, 17);
            this.ui_ClassFormNameLabel.Name = "ui_ClassFormNameLabel";
            this.ui_ClassFormNameLabel.Size = new System.Drawing.Size(70, 31);
            this.ui_ClassFormNameLabel.TabIndex = 0;
            this.ui_ClassFormNameLabel.Text = "Name";
            // 
            // ui_ClassFormTextbox
            // 
            this.ui_ClassFormTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ClassFormTextbox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassFormTextbox.Location = new System.Drawing.Point(12, 51);
            this.ui_ClassFormTextbox.Multiline = true;
            this.ui_ClassFormTextbox.Name = "ui_ClassFormTextbox";
            this.ui_ClassFormTextbox.ReadOnly = true;
            this.ui_ClassFormTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ui_ClassFormTextbox.Size = new System.Drawing.Size(1210, 397);
            this.ui_ClassFormTextbox.TabIndex = 1;
            this.ui_ClassFormTextbox.WordWrap = false;
            // 
            // ui_ClassFormRefreshButton
            // 
            this.ui_ClassFormRefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ClassFormRefreshButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassFormRefreshButton.Location = new System.Drawing.Point(12, 455);
            this.ui_ClassFormRefreshButton.Name = "ui_ClassFormRefreshButton";
            this.ui_ClassFormRefreshButton.Size = new System.Drawing.Size(150, 50);
            this.ui_ClassFormRefreshButton.TabIndex = 3;
            this.ui_ClassFormRefreshButton.Text = "Refresh";
            this.ui_ClassFormRefreshButton.UseVisualStyleBackColor = false;
            this.ui_ClassFormRefreshButton.Click += new System.EventHandler(this.ui_ClassFormRefreshButton_Click);
            // 
            // ui_AddClassButton
            // 
            this.ui_AddClassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_AddClassButton.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_AddClassButton.Location = new System.Drawing.Point(168, 455);
            this.ui_AddClassButton.Name = "ui_AddClassButton";
            this.ui_AddClassButton.Size = new System.Drawing.Size(150, 50);
            this.ui_AddClassButton.TabIndex = 4;
            this.ui_AddClassButton.Text = "ADD";
            this.ui_AddClassButton.UseVisualStyleBackColor = false;
            this.ui_AddClassButton.Click += new System.EventHandler(this.ui_AddClassButton_Click);
            // 
            // ui_ClassFormDescriptionLabel
            // 
            this.ui_ClassFormDescriptionLabel.AutoSize = true;
            this.ui_ClassFormDescriptionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassFormDescriptionLabel.Location = new System.Drawing.Point(666, 17);
            this.ui_ClassFormDescriptionLabel.Name = "ui_ClassFormDescriptionLabel";
            this.ui_ClassFormDescriptionLabel.Size = new System.Drawing.Size(122, 31);
            this.ui_ClassFormDescriptionLabel.TabIndex = 5;
            this.ui_ClassFormDescriptionLabel.Text = "Description";
            // 
            // ui_ClassFormDmodLabel
            // 
            this.ui_ClassFormDmodLabel.AutoSize = true;
            this.ui_ClassFormDmodLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassFormDmodLabel.Location = new System.Drawing.Point(462, 17);
            this.ui_ClassFormDmodLabel.Name = "ui_ClassFormDmodLabel";
            this.ui_ClassFormDmodLabel.Size = new System.Drawing.Size(123, 31);
            this.ui_ClassFormDmodLabel.TabIndex = 6;
            this.ui_ClassFormDmodLabel.Text = "DefenseMod";
            // 
            // ui_ClassFormAmodLabel
            // 
            this.ui_ClassFormAmodLabel.AutoSize = true;
            this.ui_ClassFormAmodLabel.Font = new System.Drawing.Font("Viner Hand ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassFormAmodLabel.Location = new System.Drawing.Point(286, 17);
            this.ui_ClassFormAmodLabel.Name = "ui_ClassFormAmodLabel";
            this.ui_ClassFormAmodLabel.Size = new System.Drawing.Size(123, 31);
            this.ui_ClassFormAmodLabel.TabIndex = 7;
            this.ui_ClassFormAmodLabel.Text = "AttackMod";
            // 
            // ui_ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1234, 511);
            this.Controls.Add(this.ui_ClassFormAmodLabel);
            this.Controls.Add(this.ui_ClassFormDmodLabel);
            this.Controls.Add(this.ui_ClassFormDescriptionLabel);
            this.Controls.Add(this.ui_AddClassButton);
            this.Controls.Add(this.ui_ClassFormRefreshButton);
            this.Controls.Add(this.ui_ClassFormTextbox);
            this.Controls.Add(this.ui_ClassFormNameLabel);
            this.Name = "ui_ClassForm";
            this.Text = "Classes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ui_ClassFormNameLabel;
        private System.Windows.Forms.TextBox ui_ClassFormTextbox;
        private System.Windows.Forms.Button ui_ClassFormRefreshButton;
        private System.Windows.Forms.Button ui_AddClassButton;
        private System.Windows.Forms.Label ui_ClassFormDescriptionLabel;
        private System.Windows.Forms.Label ui_ClassFormDmodLabel;
        private System.Windows.Forms.Label ui_ClassFormAmodLabel;
    }
}