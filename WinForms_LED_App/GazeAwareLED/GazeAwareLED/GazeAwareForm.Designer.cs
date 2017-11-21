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
            this.SuspendLayout();
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(13, 13);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(259, 81);
            this.btnON.TabIndex = 0;
            this.btnON.Text = "Turn LED On";
            this.btnON.UseVisualStyleBackColor = true;
            // 
            // btnOFF
            // 
            this.btnOFF.Location = new System.Drawing.Point(12, 168);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(259, 81);
            this.btnOFF.TabIndex = 1;
            this.btnOFF.Text = "Turn LED Off";
            this.btnOFF.UseVisualStyleBackColor = true;
            // 
            // stateBox
            // 
            this.stateBox.AutoSize = true;
            this.stateBox.Enabled = false;
            this.stateBox.Location = new System.Drawing.Point(97, 124);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(75, 17);
            this.stateBox.TabIndex = 2;
            this.stateBox.Text = "LED State";
            this.stateBox.UseVisualStyleBackColor = true;
            // 
            // GazeAwareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnON);
            this.Name = "GazeAwareForm";
            this.Text = "LED Gaze Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.CheckBox stateBox;
        private EyeXFramework.Forms.BehaviorMap behaviorMap1;
    }
}

