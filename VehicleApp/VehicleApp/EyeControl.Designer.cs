namespace VehicleApp
{
    partial class EyeControl
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.behaviorMap1 = new EyeXFramework.Forms.BehaviorMap(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(686, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationSettingsToolStripMenuItem,
            this.connectionSettingsToolStripMenuItem,
            this.developerToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // applicationSettingsToolStripMenuItem
            // 
            this.applicationSettingsToolStripMenuItem.Name = "applicationSettingsToolStripMenuItem";
            this.applicationSettingsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.applicationSettingsToolStripMenuItem.Text = "Application Settings";
            this.applicationSettingsToolStripMenuItem.Click += new System.EventHandler(this.applicationSettingsToolStripMenuItem_Click);
            // 
            // connectionSettingsToolStripMenuItem
            // 
            this.connectionSettingsToolStripMenuItem.Name = "connectionSettingsToolStripMenuItem";
            this.connectionSettingsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.connectionSettingsToolStripMenuItem.Text = "Connection Settings";
            this.connectionSettingsToolStripMenuItem.Click += new System.EventHandler(this.connectionSettingsToolStripMenuItem_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.developerToolStripMenuItem.Text = "Developer";
            this.developerToolStripMenuItem.Click += new System.EventHandler(this.developerToolStripMenuItem_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(288, 92);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(80, 80);
            this.btnForward.TabIndex = 1;
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(288, 353);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(80, 80);
            this.btnReverse.TabIndex = 2;
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(449, 217);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(80, 80);
            this.btnRight.TabIndex = 3;
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(131, 217);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(80, 80);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(288, 217);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(80, 80);
            this.btnBrake.TabIndex = 5;
            this.btnBrake.UseVisualStyleBackColor = true;
            // 
            // EyeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 548);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "EyeControl";
            this.Text = "EyeControl";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnBrake;
        private EyeXFramework.Forms.BehaviorMap behaviorMap1;
    }
}