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
            this.ui_ArmourFormLabel = new System.Windows.Forms.Label();
            this.ui_ArmourFormTextbox = new System.Windows.Forms.TextBox();
            this.ui_ArmourFormRefreshButton = new System.Windows.Forms.Button();
            this.ui_ArmourAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ui_ArmourFormLabel
            // 
            this.ui_ArmourFormLabel.AutoSize = true;
            this.ui_ArmourFormLabel.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourFormLabel.Location = new System.Drawing.Point(12, 9);
            this.ui_ArmourFormLabel.Name = "ui_ArmourFormLabel";
            this.ui_ArmourFormLabel.Size = new System.Drawing.Size(108, 39);
            this.ui_ArmourFormLabel.TabIndex = 0;
            this.ui_ArmourFormLabel.Text = "Armour";
            // 
            // ui_ArmourFormTextbox
            // 
            this.ui_ArmourFormTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ArmourFormTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ArmourFormTextbox.Location = new System.Drawing.Point(12, 51);
            this.ui_ArmourFormTextbox.Multiline = true;
            this.ui_ArmourFormTextbox.Name = "ui_ArmourFormTextbox";
            this.ui_ArmourFormTextbox.Size = new System.Drawing.Size(760, 397);
            this.ui_ArmourFormTextbox.TabIndex = 1;
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
            // 
            // ui_ArmourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.ui_ArmourAddButton);
            this.Controls.Add(this.ui_ArmourFormRefreshButton);
            this.Controls.Add(this.ui_ArmourFormTextbox);
            this.Controls.Add(this.ui_ArmourFormLabel);
            this.Name = "ui_ArmourForm";
            this.Text = "Armour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ui_ArmourFormLabel;
        private System.Windows.Forms.TextBox ui_ArmourFormTextbox;
        private System.Windows.Forms.Button ui_ArmourFormRefreshButton;
        private System.Windows.Forms.Button ui_ArmourAddButton;
    }
}