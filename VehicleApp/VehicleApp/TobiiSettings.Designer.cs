namespace VehicleApp
{
    partial class TobiiSettings
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
            this.chkUserPresent = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sliderGazeTime = new System.Windows.Forms.TrackBar();
            this.numGazeTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sliderGazeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGazeTime)).BeginInit();
            this.SuspendLayout();
            // 
            // chkUserPresent
            // 
            this.chkUserPresent.AutoSize = true;
            this.chkUserPresent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUserPresent.Location = new System.Drawing.Point(12, 12);
            this.chkUserPresent.Name = "chkUserPresent";
            this.chkUserPresent.Size = new System.Drawing.Size(93, 17);
            this.chkUserPresent.TabIndex = 0;
            this.chkUserPresent.Text = "User Present?";
            this.chkUserPresent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Gaze Time:";
            // 
            // sliderGazeTime
            // 
            this.sliderGazeTime.LargeChange = 100;
            this.sliderGazeTime.Location = new System.Drawing.Point(15, 72);
            this.sliderGazeTime.Maximum = 3000;
            this.sliderGazeTime.Name = "sliderGazeTime";
            this.sliderGazeTime.Size = new System.Drawing.Size(187, 45);
            this.sliderGazeTime.TabIndex = 2;
            this.sliderGazeTime.Value = 1500;
            this.sliderGazeTime.ValueChanged += new System.EventHandler(this.sliderGazeTime_ValueChanged);
            // 
            // numGazeTime
            // 
            this.numGazeTime.Location = new System.Drawing.Point(119, 44);
            this.numGazeTime.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numGazeTime.Name = "numGazeTime";
            this.numGazeTime.Size = new System.Drawing.Size(78, 20);
            this.numGazeTime.TabIndex = 3;
            this.numGazeTime.ValueChanged += new System.EventHandler(this.numGazeTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gaze Time: Length of time to stare at a\r\nbutton before it clicks.";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(127, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TobiiSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 308);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numGazeTime);
            this.Controls.Add(this.sliderGazeTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkUserPresent);
            this.Name = "TobiiSettings";
            this.Text = "Tobii Settings";
            ((System.ComponentModel.ISupportInitialize)(this.sliderGazeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGazeTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUserPresent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar sliderGazeTime;
        private System.Windows.Forms.NumericUpDown numGazeTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
    }
}