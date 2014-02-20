namespace PoE_Experience_Calc
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
            this.PlayerLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MonsterLevel = new System.Windows.Forms.TextBox();
            this.Calc = new System.Windows.Forms.Button();
            this.ExperienceRange = new System.Windows.Forms.RichTextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerLevel
            // 
            this.PlayerLevel.Location = new System.Drawing.Point(111, 35);
            this.PlayerLevel.Name = "PlayerLevel";
            this.PlayerLevel.Size = new System.Drawing.Size(100, 20);
            this.PlayerLevel.TabIndex = 0;
            this.PlayerLevel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Level";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monster Level";
            // 
            // MonsterLevel
            // 
            this.MonsterLevel.Location = new System.Drawing.Point(111, 73);
            this.MonsterLevel.Name = "MonsterLevel";
            this.MonsterLevel.Size = new System.Drawing.Size(100, 20);
            this.MonsterLevel.TabIndex = 1;
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(40, 122);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 2;
            this.Calc.Text = "Calculate";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // ExperienceRange
            // 
            this.ExperienceRange.BackColor = System.Drawing.Color.Silver;
            this.ExperienceRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExperienceRange.Location = new System.Drawing.Point(40, 166);
            this.ExperienceRange.Name = "ExperienceRange";
            this.ExperienceRange.Size = new System.Drawing.Size(338, 45);
            this.ExperienceRange.TabIndex = 5;
            this.ExperienceRange.TabStop = false;
            this.ExperienceRange.Text = "";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(136, 122);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Calc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(411, 223);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ExperienceRange);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.MonsterLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "PoE Experience Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlayerLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MonsterLevel;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.RichTextBox ExperienceRange;
        private System.Windows.Forms.Button Reset;
    }
}

