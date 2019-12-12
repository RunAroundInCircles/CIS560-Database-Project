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
            this.ui_RaceFormLabel = new System.Windows.Forms.Label();
            this.ui_RaceFormTextbox = new System.Windows.Forms.TextBox();
            this.ui_RaceFormRefreshButton = new System.Windows.Forms.Button();
            this.ui_RaceAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ui_RaceFormLabel
            // 
            this.ui_RaceFormLabel.AutoSize = true;
            this.ui_RaceFormLabel.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceFormLabel.Location = new System.Drawing.Point(12, 9);
            this.ui_RaceFormLabel.Name = "ui_RaceFormLabel";
            this.ui_RaceFormLabel.Size = new System.Drawing.Size(107, 39);
            this.ui_RaceFormLabel.TabIndex = 0;
            this.ui_RaceFormLabel.Text = "RACES";
            // 
            // ui_RaceFormTextbox
            // 
            this.ui_RaceFormTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_RaceFormTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_RaceFormTextbox.Location = new System.Drawing.Point(12, 51);
            this.ui_RaceFormTextbox.Multiline = true;
            this.ui_RaceFormTextbox.Name = "ui_RaceFormTextbox";
            this.ui_RaceFormTextbox.Size = new System.Drawing.Size(760, 397);
            this.ui_RaceFormTextbox.TabIndex = 1;
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
            // 
            // ui_RaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.ui_RaceAddButton);
            this.Controls.Add(this.ui_RaceFormRefreshButton);
            this.Controls.Add(this.ui_RaceFormTextbox);
            this.Controls.Add(this.ui_RaceFormLabel);
            this.Name = "ui_RaceForm";
            this.Text = "Races";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ui_RaceFormLabel;
        private System.Windows.Forms.TextBox ui_RaceFormTextbox;
        private System.Windows.Forms.Button ui_RaceFormRefreshButton;
        private System.Windows.Forms.Button ui_RaceAddButton;
    }
}