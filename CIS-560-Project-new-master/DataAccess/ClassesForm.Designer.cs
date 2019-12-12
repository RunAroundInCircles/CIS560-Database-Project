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
            this.ui_ClassFormLabel = new System.Windows.Forms.Label();
            this.ui_ClassFormTextbox = new System.Windows.Forms.TextBox();
            this.ui_ClassFormRefreshButton = new System.Windows.Forms.Button();
            this.ui_AddClassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ui_ClassFormLabel
            // 
            this.ui_ClassFormLabel.AutoSize = true;
            this.ui_ClassFormLabel.Font = new System.Drawing.Font("Viner Hand ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassFormLabel.Location = new System.Drawing.Point(12, 9);
            this.ui_ClassFormLabel.Name = "ui_ClassFormLabel";
            this.ui_ClassFormLabel.Size = new System.Drawing.Size(141, 39);
            this.ui_ClassFormLabel.TabIndex = 0;
            this.ui_ClassFormLabel.Text = "CLASSES";
            // 
            // ui_ClassFormTextbox
            // 
            this.ui_ClassFormTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ui_ClassFormTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_ClassFormTextbox.Location = new System.Drawing.Point(13, 52);
            this.ui_ClassFormTextbox.Multiline = true;
            this.ui_ClassFormTextbox.Name = "ui_ClassFormTextbox";
            this.ui_ClassFormTextbox.Size = new System.Drawing.Size(760, 397);
            this.ui_ClassFormTextbox.TabIndex = 1;
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
            // 
            // ui_ClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.ui_AddClassButton);
            this.Controls.Add(this.ui_ClassFormRefreshButton);
            this.Controls.Add(this.ui_ClassFormTextbox);
            this.Controls.Add(this.ui_ClassFormLabel);
            this.Name = "ui_ClassForm";
            this.Text = "Classes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ui_ClassFormLabel;
        private System.Windows.Forms.TextBox ui_ClassFormTextbox;
        private System.Windows.Forms.Button ui_ClassFormRefreshButton;
        private System.Windows.Forms.Button ui_AddClassButton;
    }
}