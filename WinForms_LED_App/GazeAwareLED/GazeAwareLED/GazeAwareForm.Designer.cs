namespace GazeAwareLED
{
    partial class GazeAwareForm
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
            this.btnON = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.stateBox = new System.Windows.Forms.CheckBox();
            this.behaviorMap1 = new EyeXFramework.Forms.BehaviorMap(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slideFixLength = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.numFixLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideFixLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnON
            // 
            this.btnON.FlatAppearance.BorderSize = 0;
            this.btnON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnON.Location = new System.Drawing.Point(13, 13);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(259, 108);
            this.btnON.TabIndex = 0;
            this.btnON.Text = "Turn LED On";
            this.btnON.UseVisualStyleBackColor = true;
            // 
            // btnOFF
            // 
            this.btnOFF.FlatAppearance.BorderSize = 0;
            this.btnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOFF.Location = new System.Drawing.Point(12, 141);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(259, 108);
            this.btnOFF.TabIndex = 1;
            this.btnOFF.Text = "Turn LED Off";
            this.btnOFF.UseVisualStyleBackColor = true;
            // 
            // stateBox
            // 
            this.stateBox.AutoSize = true;
            this.stateBox.Enabled = false;
            this.stateBox.Location = new System.Drawing.Point(12, 19);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(75, 17);
            this.stateBox.TabIndex = 2;
            this.stateBox.Text = "LED State";
            this.stateBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numFixLength);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.slideFixLength);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbComPort);
            this.groupBox1.Controls.Add(this.stateBox);
            this.groupBox1.Location = new System.Drawing.Point(278, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 236);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // cmbComPort
            // 
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(12, 87);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(106, 21);
            this.cmbComPort.TabIndex = 3;
            this.cmbComPort.DropDown += new System.EventHandler(this.cmbComPort_DropDown);
            this.cmbComPort.SelectedIndexChanged += new System.EventHandler(this.cmbComPort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serial Port";
            // 
            // slideFixLength
            // 
            this.slideFixLength.LargeChange = 500;
            this.slideFixLength.Location = new System.Drawing.Point(12, 155);
            this.slideFixLength.Maximum = 3000;
            this.slideFixLength.Minimum = 500;
            this.slideFixLength.Name = "slideFixLength";
            this.slideFixLength.Size = new System.Drawing.Size(104, 45);
            this.slideFixLength.SmallChange = 250;
            this.slideFixLength.TabIndex = 5;
            this.slideFixLength.Value = 500;
            this.slideFixLength.ValueChanged += new System.EventHandler(this.slideFixLength_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fixation Length";
            // 
            // numFixLength
            // 
            this.numFixLength.Location = new System.Drawing.Point(15, 206);
            this.numFixLength.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numFixLength.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numFixLength.Name = "numFixLength";
            this.numFixLength.Size = new System.Drawing.Size(103, 20);
            this.numFixLength.TabIndex = 7;
            this.numFixLength.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numFixLength.ValueChanged += new System.EventHandler(this.numFixLength_ValueChanged);
            // 
            // GazeAwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnON);
            this.Name = "GazeAwareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LED Gaze Control";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slideFixLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFixLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.CheckBox stateBox;
        private EyeXFramework.Forms.BehaviorMap behaviorMap1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numFixLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar slideFixLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbComPort;
    }
}

