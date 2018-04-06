namespace VehicleApp
{
    partial class DataLog
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
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.txtMessageBox = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCmd1 = new System.Windows.Forms.Button();
            this.groupCommands = new System.Windows.Forms.GroupBox();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnCmd6 = new System.Windows.Forms.Button();
            this.btnCmd7 = new System.Windows.Forms.Button();
            this.btnCmd5 = new System.Windows.Forms.Button();
            this.btnCmd4 = new System.Windows.Forms.Button();
            this.btnCmd3 = new System.Windows.Forms.Button();
            this.btnCmd2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveLog = new System.Windows.Forms.Button();
            this.groupCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbComSelect
            // 
            this.cmbComSelect.FormattingEnabled = true;
            this.cmbComSelect.Location = new System.Drawing.Point(13, 13);
            this.cmbComSelect.Name = "cmbComSelect";
            this.cmbComSelect.Size = new System.Drawing.Size(89, 21);
            this.cmbComSelect.TabIndex = 0;
            this.cmbComSelect.DropDown += new System.EventHandler(this.cmbComSelect_DropDown);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(13, 41);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // rtbConsole
            // 
            this.rtbConsole.Location = new System.Drawing.Point(185, 41);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(224, 411);
            this.rtbConsole.TabIndex = 2;
            this.rtbConsole.Text = "";
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Location = new System.Drawing.Point(185, 458);
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.Size = new System.Drawing.Size(140, 20);
            this.txtMessageBox.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(331, 456);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCmd1
            // 
            this.btnCmd1.Location = new System.Drawing.Point(6, 19);
            this.btnCmd1.Name = "btnCmd1";
            this.btnCmd1.Size = new System.Drawing.Size(75, 23);
            this.btnCmd1.TabIndex = 5;
            this.btnCmd1.Text = "Forward";
            this.btnCmd1.UseVisualStyleBackColor = true;
            this.btnCmd1.Click += new System.EventHandler(this.btnCmd1_Click);
            // 
            // groupCommands
            // 
            this.groupCommands.Controls.Add(this.numSpeed);
            this.groupCommands.Controls.Add(this.btnCmd6);
            this.groupCommands.Controls.Add(this.btnCmd7);
            this.groupCommands.Controls.Add(this.btnCmd5);
            this.groupCommands.Controls.Add(this.btnCmd4);
            this.groupCommands.Controls.Add(this.btnCmd3);
            this.groupCommands.Controls.Add(this.btnCmd2);
            this.groupCommands.Controls.Add(this.btnCmd1);
            this.groupCommands.Location = new System.Drawing.Point(13, 90);
            this.groupCommands.Name = "groupCommands";
            this.groupCommands.Size = new System.Drawing.Size(166, 224);
            this.groupCommands.TabIndex = 6;
            this.groupCommands.TabStop = false;
            this.groupCommands.Text = "Commands";
            // 
            // numSpeed
            // 
            this.numSpeed.Location = new System.Drawing.Point(87, 167);
            this.numSpeed.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(73, 20);
            this.numSpeed.TabIndex = 12;
            // 
            // btnCmd6
            // 
            this.btnCmd6.Location = new System.Drawing.Point(6, 164);
            this.btnCmd6.Name = "btnCmd6";
            this.btnCmd6.Size = new System.Drawing.Size(75, 23);
            this.btnCmd6.TabIndex = 11;
            this.btnCmd6.Text = "SetSpeed";
            this.btnCmd6.UseVisualStyleBackColor = true;
            this.btnCmd6.Click += new System.EventHandler(this.btnCmd6_Click);
            // 
            // btnCmd7
            // 
            this.btnCmd7.Location = new System.Drawing.Point(6, 193);
            this.btnCmd7.Name = "btnCmd7";
            this.btnCmd7.Size = new System.Drawing.Size(75, 23);
            this.btnCmd7.TabIndex = 10;
            this.btnCmd7.Text = "Ping";
            this.btnCmd7.UseVisualStyleBackColor = true;
            this.btnCmd7.Click += new System.EventHandler(this.btnCmd7_Click);
            // 
            // btnCmd5
            // 
            this.btnCmd5.Location = new System.Drawing.Point(6, 135);
            this.btnCmd5.Name = "btnCmd5";
            this.btnCmd5.Size = new System.Drawing.Size(75, 23);
            this.btnCmd5.TabIndex = 9;
            this.btnCmd5.Text = "Right";
            this.btnCmd5.UseVisualStyleBackColor = true;
            this.btnCmd5.Click += new System.EventHandler(this.btnCmd5_Click);
            // 
            // btnCmd4
            // 
            this.btnCmd4.Location = new System.Drawing.Point(6, 106);
            this.btnCmd4.Name = "btnCmd4";
            this.btnCmd4.Size = new System.Drawing.Size(75, 23);
            this.btnCmd4.TabIndex = 8;
            this.btnCmd4.Text = "Left";
            this.btnCmd4.UseVisualStyleBackColor = true;
            this.btnCmd4.Click += new System.EventHandler(this.btnCmd4_Click);
            // 
            // btnCmd3
            // 
            this.btnCmd3.Location = new System.Drawing.Point(6, 77);
            this.btnCmd3.Name = "btnCmd3";
            this.btnCmd3.Size = new System.Drawing.Size(75, 23);
            this.btnCmd3.TabIndex = 7;
            this.btnCmd3.Text = "Brake";
            this.btnCmd3.UseVisualStyleBackColor = true;
            this.btnCmd3.Click += new System.EventHandler(this.btnCmd3_Click);
            // 
            // btnCmd2
            // 
            this.btnCmd2.Location = new System.Drawing.Point(6, 48);
            this.btnCmd2.Name = "btnCmd2";
            this.btnCmd2.Size = new System.Drawing.Size(75, 23);
            this.btnCmd2.TabIndex = 6;
            this.btnCmd2.Text = "Reverse";
            this.btnCmd2.UseVisualStyleBackColor = true;
            this.btnCmd2.Click += new System.EventHandler(this.btnCmd2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Log";
            // 
            // btnSaveLog
            // 
            this.btnSaveLog.Location = new System.Drawing.Point(334, 8);
            this.btnSaveLog.Name = "btnSaveLog";
            this.btnSaveLog.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLog.TabIndex = 8;
            this.btnSaveLog.Text = "Save Log";
            this.btnSaveLog.UseVisualStyleBackColor = true;
            this.btnSaveLog.Click += new System.EventHandler(this.btnSaveLog_Click);
            // 
            // DataLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 489);
            this.Controls.Add(this.btnSaveLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupCommands);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessageBox);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmbComSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DataLog";
            this.Text = "Data Log";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataLog_FormClosing);
            this.groupCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbComSelect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.TextBox txtMessageBox;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCmd1;
        private System.Windows.Forms.GroupBox groupCommands;
        private System.Windows.Forms.Button btnCmd7;
        private System.Windows.Forms.Button btnCmd5;
        private System.Windows.Forms.Button btnCmd4;
        private System.Windows.Forms.Button btnCmd3;
        private System.Windows.Forms.Button btnCmd2;
        private System.Windows.Forms.Button btnCmd6;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveLog;
    }
}

