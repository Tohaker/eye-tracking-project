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
            this.behaviorMap1 = new EyeXFramework.Forms.BehaviorMap(this.components);
            this.btnBrake = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDemoMode = new System.Windows.Forms.Label();
            this.btnExitDemo = new System.Windows.Forms.Button();
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
            // btnBrake
            // 
            this.btnBrake.BackgroundImage = global::VehicleApp.Properties.Resources.Stop;
            this.btnBrake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrake.FlatAppearance.BorderSize = 2;
            this.btnBrake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrake.Location = new System.Drawing.Point(288, 217);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(119, 119);
            this.btnBrake.TabIndex = 5;
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            this.btnBrake.MouseEnter += new System.EventHandler(this.btnBrake_MouseEnter);
            this.btnBrake.MouseLeave += new System.EventHandler(this.btnBrake_MouseLeave);
            // 
            // btnLeft
            // 
            this.btnLeft.BackgroundImage = global::VehicleApp.Properties.Resources.LeftArrow;
            this.btnLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeft.FlatAppearance.BorderSize = 2;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Location = new System.Drawing.Point(131, 217);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(119, 119);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            this.btnLeft.MouseEnter += new System.EventHandler(this.btnLeft_MouseEnter);
            this.btnLeft.MouseLeave += new System.EventHandler(this.btnLeft_MouseLeave);
            // 
            // btnRight
            // 
            this.btnRight.BackgroundImage = global::VehicleApp.Properties.Resources.RightArrow;
            this.btnRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRight.FlatAppearance.BorderSize = 2;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Location = new System.Drawing.Point(449, 217);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(119, 119);
            this.btnRight.TabIndex = 3;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            this.btnRight.MouseEnter += new System.EventHandler(this.btnRight_MouseEnter);
            this.btnRight.MouseLeave += new System.EventHandler(this.btnRight_MouseLeave);
            // 
            // btnReverse
            // 
            this.btnReverse.BackgroundImage = global::VehicleApp.Properties.Resources.BackArrow;
            this.btnReverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReverse.FlatAppearance.BorderSize = 2;
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReverse.Location = new System.Drawing.Point(288, 353);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(119, 119);
            this.btnReverse.TabIndex = 2;
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            this.btnReverse.MouseEnter += new System.EventHandler(this.btnReverse_MouseEnter);
            this.btnReverse.MouseLeave += new System.EventHandler(this.btnReverse_MouseLeave);
            // 
            // btnForward
            // 
            this.btnForward.BackgroundImage = global::VehicleApp.Properties.Resources.Arrow;
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnForward.FlatAppearance.BorderSize = 2;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Location = new System.Drawing.Point(288, 76);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(119, 119);
            this.btnForward.TabIndex = 2;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            this.btnForward.MouseEnter += new System.EventHandler(this.btnForward_MouseEnter);
            this.btnForward.MouseLeave += new System.EventHandler(this.btnForward_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 80);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instructions:\r\nLook at the button you wish to \'click\'.\r\nHold you gaze on it until" +
    " the border turns GREEN.\r\nObserve as the robot obeys your actions!";
            // 
            // lblDemoMode
            // 
            this.lblDemoMode.AutoSize = true;
            this.lblDemoMode.Location = new System.Drawing.Point(13, 28);
            this.lblDemoMode.Name = "lblDemoMode";
            this.lblDemoMode.Size = new System.Drawing.Size(35, 13);
            this.lblDemoMode.TabIndex = 7;
            this.lblDemoMode.Text = "label2";
            // 
            // btnExitDemo
            // 
            this.btnExitDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitDemo.Location = new System.Drawing.Point(16, 54);
            this.btnExitDemo.Name = "btnExitDemo";
            this.btnExitDemo.Size = new System.Drawing.Size(130, 61);
            this.btnExitDemo.TabIndex = 1;
            this.btnExitDemo.Text = "Exit Demo Mode";
            this.btnExitDemo.UseVisualStyleBackColor = true;
            this.btnExitDemo.Click += new System.EventHandler(this.btnExitDemo_Click);
            // 
            // EyeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 587);
            this.Controls.Add(this.btnExitDemo);
            this.Controls.Add(this.lblDemoMode);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDemoMode;
        private System.Windows.Forms.Button btnExitDemo;
    }
}