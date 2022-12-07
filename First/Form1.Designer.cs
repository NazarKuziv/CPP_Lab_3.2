namespace First
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Standard_rB = new System.Windows.Forms.RadioButton();
            this.Red_rB = new System.Windows.Forms.RadioButton();
            this.Yellow_rB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_cBox = new System.Windows.Forms.CheckBox();
            this.Label_cBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Yellow_rB);
            this.groupBox1.Controls.Add(this.Red_rB);
            this.groupBox1.Controls.Add(this.Standard_rB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(323, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Label Color";
            // 
            // Standard_rB
            // 
            this.Standard_rB.AutoSize = true;
            this.Standard_rB.Checked = true;
            this.Standard_rB.Location = new System.Drawing.Point(7, 42);
            this.Standard_rB.Name = "Standard_rB";
            this.Standard_rB.Size = new System.Drawing.Size(93, 24);
            this.Standard_rB.TabIndex = 0;
            this.Standard_rB.TabStop = true;
            this.Standard_rB.Text = "Standard";
            this.Standard_rB.UseVisualStyleBackColor = true;
            this.Standard_rB.CheckedChanged += new System.EventHandler(this.Standard_rB_CheckedChanged);
            // 
            // Red_rB
            // 
            this.Red_rB.AutoSize = true;
            this.Red_rB.Location = new System.Drawing.Point(7, 72);
            this.Red_rB.Name = "Red_rB";
            this.Red_rB.Size = new System.Drawing.Size(57, 24);
            this.Red_rB.TabIndex = 1;
            this.Red_rB.TabStop = true;
            this.Red_rB.Text = "Red";
            this.Red_rB.UseVisualStyleBackColor = true;
            this.Red_rB.CheckedChanged += new System.EventHandler(this.Red_rB_CheckedChanged);
            // 
            // Yellow_rB
            // 
            this.Yellow_rB.AutoSize = true;
            this.Yellow_rB.Location = new System.Drawing.Point(7, 102);
            this.Yellow_rB.Name = "Yellow_rB";
            this.Yellow_rB.Size = new System.Drawing.Size(73, 24);
            this.Yellow_rB.TabIndex = 2;
            this.Yellow_rB.TabStop = true;
            this.Yellow_rB.Text = "Yellow";
            this.Yellow_rB.UseVisualStyleBackColor = true;
            this.Yellow_rB.CheckedChanged += new System.EventHandler(this.Yellow_rB_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Label_cBox);
            this.panel1.Controls.Add(this.Button_cBox);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(36, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // Button_cBox
            // 
            this.Button_cBox.AutoSize = true;
            this.Button_cBox.Location = new System.Drawing.Point(23, 19);
            this.Button_cBox.Name = "Button_cBox";
            this.Button_cBox.Size = new System.Drawing.Size(164, 24);
            this.Button_cBox.TabIndex = 0;
            this.Button_cBox.Text = "Button is not visible";
            this.Button_cBox.UseVisualStyleBackColor = true;
            this.Button_cBox.CheckedChanged += new System.EventHandler(this.Button_cBox_CheckedChanged);
            // 
            // Label_cBox
            // 
            this.Label_cBox.AutoSize = true;
            this.Label_cBox.Checked = true;
            this.Label_cBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Label_cBox.Location = new System.Drawing.Point(23, 59);
            this.Label_cBox.Name = "Label_cBox";
            this.Label_cBox.Size = new System.Drawing.Size(128, 24);
            this.Label_cBox.TabIndex = 1;
            this.Label_cBox.Text = "Label is visible";
            this.Label_cBox.UseVisualStyleBackColor = true;
            this.Label_cBox.CheckedChanged += new System.EventHandler(this.Label_cBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "First";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Yellow_rB;
        private System.Windows.Forms.RadioButton Red_rB;
        private System.Windows.Forms.RadioButton Standard_rB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Label_cBox;
        private System.Windows.Forms.CheckBox Button_cBox;
    }
}

