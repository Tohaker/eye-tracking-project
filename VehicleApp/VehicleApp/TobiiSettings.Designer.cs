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
            this.sliderDwellTime = new System.Windows.Forms.TrackBar();
            this.numDwellTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDwellTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDwellTime)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Dwell Time:";
            // 
            // sliderDwellTime
            // 
            this.sliderDwellTime.LargeChange = 100;
            this.sliderDwellTime.Location = new System.Drawing.Point(15, 72);
            this.sliderDwellTime.Maximum = 3000;
            this.sliderDwellTime.Name = "sliderDwellTime";
            this.sliderDwellTime.Size = new System.Drawing.Size(187, 45);
            this.sliderDwellTime.TabIndex = 2;
            this.sliderDwellTime.Value = 1500;
            this.sliderDwellTime.ValueChanged += new System.EventHandler(this.sliderDwellTime_ValueChanged);
            // 
            // numDwellTime
            // 
            this.numDwellTime.Location = new System.Drawing.Point(119, 44);
            this.numDwellTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDwellTime.Name = "numDwellTime";
            this.numDwellTime.Size = new System.Drawing.Size(58, 20);
            this.numDwellTime.TabIndex = 3;
            this.numDwellTime.ValueChanged += new System.EventHandler(this.numDwellTime_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dwell Time: Length of time to look at a\r\nbutton before it clicks.";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ms";
            // 
            // TobiiSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 308);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numDwellTime);
            this.Controls.Add(this.sliderDwellTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkUserPresent);
            this.Name = "TobiiSettings";
            this.Text = "Tobii Settings";
            ((System.ComponentModel.ISupportInitialize)(this.sliderDwellTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDwellTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUserPresent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar sliderDwellTime;
        private System.Windows.Forms.NumericUpDown numDwellTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
    }
}