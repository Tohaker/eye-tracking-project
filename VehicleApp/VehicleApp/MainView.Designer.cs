namespace VehicleApp
{
    partial class MainView
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
            this.btnCmd6 = new System.Windows.Forms.Button();
            this.btnCmd5 = new System.Windows.Forms.Button();
            this.btnCmd4 = new System.Windows.Forms.Button();
            this.btnCmd3 = new System.Windows.Forms.Button();
            this.btnCmd2 = new System.Windows.Forms.Button();
            this.groupCommands.SuspendLayout();
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
            this.rtbConsole.Location = new System.Drawing.Point(108, 12);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(301, 440);
            this.rtbConsole.TabIndex = 2;
            this.rtbConsole.Text = "";
            // 
            // txtMessageBox
            // 
            this.txtMessageBox.Location = new System.Drawing.Point(108, 458);
            this.txtMessageBox.Name = "txtMessageBox";
            this.txtMessageBox.Size = new System.Drawing.Size(205, 20);
            this.txtMessageBox.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(319, 456);
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
            this.btnCmd1.Text = "Command 1";
            this.btnCmd1.UseVisualStyleBackColor = true;
            this.btnCmd1.Click += new System.EventHandler(this.btnCmd1_Click);
            // 
            // groupCommands
            // 
            this.groupCommands.Controls.Add(this.btnCmd6);
            this.groupCommands.Controls.Add(this.btnCmd5);
            this.groupCommands.Controls.Add(this.btnCmd4);
            this.groupCommands.Controls.Add(this.btnCmd3);
            this.groupCommands.Controls.Add(this.btnCmd2);
            this.groupCommands.Controls.Add(this.btnCmd1);
            this.groupCommands.Location = new System.Drawing.Point(13, 90);
            this.groupCommands.Name = "groupCommands";
            this.groupCommands.Size = new System.Drawing.Size(89, 195);
            this.groupCommands.TabIndex = 6;
            this.groupCommands.TabStop = false;
            this.groupCommands.Text = "Commands";
            // 
            // btnCmd6
            // 
            this.btnCmd6.Location = new System.Drawing.Point(6, 164);
            this.btnCmd6.Name = "btnCmd6";
            this.btnCmd6.Size = new System.Drawing.Size(75, 23);
            this.btnCmd6.TabIndex = 10;
            this.btnCmd6.Text = "Command 6";
            this.btnCmd6.UseVisualStyleBackColor = true;
            this.btnCmd6.Click += new System.EventHandler(this.btnCmd6_Click);
            // 
            // btnCmd5
            // 
            this.btnCmd5.Location = new System.Drawing.Point(6, 135);
            this.btnCmd5.Name = "btnCmd5";
            this.btnCmd5.Size = new System.Drawing.Size(75, 23);
            this.btnCmd5.TabIndex = 9;
            this.btnCmd5.Text = "Command 5";
            this.btnCmd5.UseVisualStyleBackColor = true;
            this.btnCmd5.Click += new System.EventHandler(this.btnCmd5_Click);
            // 
            // btnCmd4
            // 
            this.btnCmd4.Location = new System.Drawing.Point(6, 106);
            this.btnCmd4.Name = "btnCmd4";
            this.btnCmd4.Size = new System.Drawing.Size(75, 23);
            this.btnCmd4.TabIndex = 8;
            this.btnCmd4.Text = "Command 4";
            this.btnCmd4.UseVisualStyleBackColor = true;
            this.btnCmd4.Click += new System.EventHandler(this.btnCmd4_Click);
            // 
            // btnCmd3
            // 
            this.btnCmd3.Location = new System.Drawing.Point(6, 77);
            this.btnCmd3.Name = "btnCmd3";
            this.btnCmd3.Size = new System.Drawing.Size(75, 23);
            this.btnCmd3.TabIndex = 7;
            this.btnCmd3.Text = "Command 3";
            this.btnCmd3.UseVisualStyleBackColor = true;
            this.btnCmd3.Click += new System.EventHandler(this.btnCmd3_Click);
            // 
            // btnCmd2
            // 
            this.btnCmd2.Location = new System.Drawing.Point(6, 48);
            this.btnCmd2.Name = "btnCmd2";
            this.btnCmd2.Size = new System.Drawing.Size(75, 23);
            this.btnCmd2.TabIndex = 6;
            this.btnCmd2.Text = "Command 2";
            this.btnCmd2.UseVisualStyleBackColor = true;
            this.btnCmd2.Click += new System.EventHandler(this.btnCmd2_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 489);
            this.Controls.Add(this.groupCommands);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessageBox);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmbComSelect);
            this.Name = "MainView";
            this.Text = "Form1";
            this.groupCommands.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnCmd6;
        private System.Windows.Forms.Button btnCmd5;
        private System.Windows.Forms.Button btnCmd4;
        private System.Windows.Forms.Button btnCmd3;
        private System.Windows.Forms.Button btnCmd2;
    }
}

