namespace VehicleApp
{
    partial class WelcomeScreen
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
            this.cmbComSelect = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnAppStart = new System.Windows.Forms.Button();
            this.chkTobiiUserPresent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbComSelect
            // 
            this.cmbComSelect.FormattingEnabled = true;
            this.cmbComSelect.Location = new System.Drawing.Point(13, 13);
            this.cmbComSelect.Name = "cmbComSelect";
            this.cmbComSelect.Size = new System.Drawing.Size(92, 21);
            this.cmbComSelect.TabIndex = 0;
            this.cmbComSelect.DropDown += new System.EventHandler(this.cmbComSelect_DropDown);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(13, 41);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnAppStart
            // 
            this.btnAppStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppStart.Location = new System.Drawing.Point(132, 13);
            this.btnAppStart.Name = "btnAppStart";
            this.btnAppStart.Size = new System.Drawing.Size(81, 51);
            this.btnAppStart.TabIndex = 2;
            this.btnAppStart.Text = "Start";
            this.btnAppStart.UseVisualStyleBackColor = true;
            this.btnAppStart.Click += new System.EventHandler(this.btnAppStart_Click);
            // 
            // chkTobiiUserPresent
            // 
            this.chkTobiiUserPresent.AutoSize = true;
            this.chkTobiiUserPresent.Enabled = false;
            this.chkTobiiUserPresent.Location = new System.Drawing.Point(12, 88);
            this.chkTobiiUserPresent.Name = "chkTobiiUserPresent";
            this.chkTobiiUserPresent.Size = new System.Drawing.Size(95, 17);
            this.chkTobiiUserPresent.TabIndex = 3;
            this.chkTobiiUserPresent.Text = "User Detected";
            this.chkTobiiUserPresent.UseVisualStyleBackColor = true;
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 178);
            this.Controls.Add(this.chkTobiiUserPresent);
            this.Controls.Add(this.btnAppStart);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmbComSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WelcomeScreen";
            this.Text = "WelcomeScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbComSelect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnAppStart;
        private System.Windows.Forms.CheckBox chkTobiiUserPresent;
    }
}