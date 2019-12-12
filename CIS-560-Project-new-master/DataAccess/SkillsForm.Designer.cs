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
            this.ui_SkillsFormLabel = new System.Windows.Forms.Label();
            this.ui_ClassFormTextbox = new System.Windows.Forms.TextBox();
            this.ui_SkillsFormRefreshButton = new System.Windows.Forms.Button();
            this.ui_SkillsAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ui_SkillsFormLabel
            // 
            this.ui_SkillsFormLabel.AutoSize = true;
            this.ui_SkillsFormLabel.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_SkillsFormLabel.Location = new System.Drawing.Point(12, 9);
            this.ui_SkillsFormLabel.Name = "ui_SkillsFormLabel";
            this.ui_SkillsFormLabel.Size = new System.Drawing.Size(119, 39);
            this.ui_SkillsFormLabel.TabIndex = 0;
            this.ui_SkillsFormLabel.Text = "SKILLS";
            // 
            // ui_ClassFormTextbox
            // 
            this.ui_ClassFormTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ClassFormTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassFormTextbox.Location = new System.Drawing.Point(12, 51);
            this.ui_ClassFormTextbox.Multiline = true;
            this.ui_ClassFormTextbox.Name = "ui_ClassFormTextbox";
            this.ui_ClassFormTextbox.Size = new System.Drawing.Size(760, 397);
            this.ui_ClassFormTextbox.TabIndex = 1;
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
            // 
            // ui_SkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.ui_SkillsAddButton);
            this.Controls.Add(this.ui_SkillsFormRefreshButton);
            this.Controls.Add(this.ui_ClassFormTextbox);
            this.Controls.Add(this.ui_SkillsFormLabel);
            this.Name = "ui_SkillsForm";
            this.Text = "Skills";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ui_SkillsFormLabel;
        private System.Windows.Forms.TextBox ui_ClassFormTextbox;
        private System.Windows.Forms.Button ui_SkillsFormRefreshButton;
        private System.Windows.Forms.Button ui_SkillsAddButton;
    }
}