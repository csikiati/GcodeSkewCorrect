namespace GcodeSkewCorrect
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonCorrect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOrigGcode = new System.Windows.Forms.TextBox();
            this.tbXY = new System.Windows.Forms.TextBox();
            this.tbZX = new System.Windows.Forms.TextBox();
            this.tbZY = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(107, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open Gcode";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonCorrect
            // 
            this.buttonCorrect.Location = new System.Drawing.Point(12, 84);
            this.buttonCorrect.Name = "buttonCorrect";
            this.buttonCorrect.Size = new System.Drawing.Size(107, 23);
            this.buttonCorrect.TabIndex = 1;
            this.buttonCorrect.Text = "Skew correction";
            this.buttonCorrect.UseVisualStyleBackColor = true;
            this.buttonCorrect.Click += new System.EventHandler(this.buttonCorrect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "delta XY°";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "delta ZY°";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "delta ZX°";
            // 
            // tbOrigGcode
            // 
            this.tbOrigGcode.Location = new System.Drawing.Point(126, 14);
            this.tbOrigGcode.Name = "tbOrigGcode";
            this.tbOrigGcode.Size = new System.Drawing.Size(542, 20);
            this.tbOrigGcode.TabIndex = 5;
            // 
            // tbXY
            // 
            this.tbXY.Location = new System.Drawing.Point(126, 49);
            this.tbXY.Name = "tbXY";
            this.tbXY.Size = new System.Drawing.Size(100, 20);
            this.tbXY.TabIndex = 6;
            this.tbXY.Text = "5";
            // 
            // tbZX
            // 
            this.tbZX.Location = new System.Drawing.Point(342, 49);
            this.tbZX.Name = "tbZX";
            this.tbZX.Size = new System.Drawing.Size(100, 20);
            this.tbZX.TabIndex = 7;
            this.tbZX.Text = "0";
            // 
            // tbZY
            // 
            this.tbZY.Location = new System.Drawing.Point(568, 49);
            this.tbZY.Name = "tbZY";
            this.tbZY.Size = new System.Drawing.Size(100, 20);
            this.tbZY.TabIndex = 8;
            this.tbZY.Text = "10";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "*.gcode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 380);
            this.Controls.Add(this.tbZY);
            this.Controls.Add(this.tbZX);
            this.Controls.Add(this.tbXY);
            this.Controls.Add(this.tbOrigGcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCorrect);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Gcode Skew Correction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonCorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOrigGcode;
        private System.Windows.Forms.TextBox tbXY;
        private System.Windows.Forms.TextBox tbZX;
        private System.Windows.Forms.TextBox tbZY;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

