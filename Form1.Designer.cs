
namespace Chapter9_RegistrationForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckBoxSwim = new System.Windows.Forms.CheckBox();
            this.ckBoxSnorkel = new System.Windows.Forms.CheckBox();
            this.ckBoxDive = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAdvanced = new System.Windows.Forms.RadioButton();
            this.radIntermediate = new System.Windows.Forms.RadioButton();
            this.radBeginner = new System.Windows.Forms.RadioButton();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 27);
            this.textBox1.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(47, 363);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(125, 27);
            this.txtResult.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Lesson";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Check all that apply";
            // 
            // ckBoxSwim
            // 
            this.ckBoxSwim.AutoSize = true;
            this.ckBoxSwim.Location = new System.Drawing.Point(47, 152);
            this.ckBoxSwim.Name = "ckBoxSwim";
            this.ckBoxSwim.Size = new System.Drawing.Size(105, 24);
            this.ckBoxSwim.TabIndex = 6;
            this.ckBoxSwim.Text = "Swim - $50";
            this.ckBoxSwim.UseVisualStyleBackColor = true;
            this.ckBoxSwim.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // ckBoxSnorkel
            // 
            this.ckBoxSnorkel.AutoSize = true;
            this.ckBoxSnorkel.Location = new System.Drawing.Point(47, 183);
            this.ckBoxSnorkel.Name = "ckBoxSnorkel";
            this.ckBoxSnorkel.Size = new System.Drawing.Size(118, 24);
            this.ckBoxSnorkel.TabIndex = 7;
            this.ckBoxSnorkel.Text = "Snorkel - $25";
            this.ckBoxSnorkel.UseVisualStyleBackColor = true;
            this.ckBoxSnorkel.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // ckBoxDive
            // 
            this.ckBoxDive.AutoSize = true;
            this.ckBoxDive.Location = new System.Drawing.Point(47, 214);
            this.ckBoxDive.Name = "ckBoxDive";
            this.ckBoxDive.Size = new System.Drawing.Size(107, 24);
            this.ckBoxDive.TabIndex = 8;
            this.ckBoxDive.Text = "Dive - $100";
            this.ckBoxDive.UseVisualStyleBackColor = true;
            this.ckBoxDive.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAdvanced);
            this.groupBox1.Controls.Add(this.radIntermediate);
            this.groupBox1.Controls.Add(this.radBeginner);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(214, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 166);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skill Level";
            // 
            // radAdvanced
            // 
            this.radAdvanced.AutoSize = true;
            this.radAdvanced.Location = new System.Drawing.Point(22, 123);
            this.radAdvanced.Name = "radAdvanced";
            this.radAdvanced.Size = new System.Drawing.Size(96, 24);
            this.radAdvanced.TabIndex = 2;
            this.radAdvanced.TabStop = true;
            this.radAdvanced.Text = "Advanced";
            this.radAdvanced.UseVisualStyleBackColor = true;
            this.radAdvanced.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // radIntermediate
            // 
            this.radIntermediate.AutoSize = true;
            this.radIntermediate.Location = new System.Drawing.Point(22, 82);
            this.radIntermediate.Name = "radIntermediate";
            this.radIntermediate.Size = new System.Drawing.Size(115, 24);
            this.radIntermediate.TabIndex = 1;
            this.radIntermediate.TabStop = true;
            this.radIntermediate.Text = "Intermediate";
            this.radIntermediate.UseVisualStyleBackColor = true;
            this.radIntermediate.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // radBeginner
            // 
            this.radBeginner.AutoSize = true;
            this.radBeginner.Location = new System.Drawing.Point(22, 41);
            this.radBeginner.Name = "radBeginner";
            this.radBeginner.Size = new System.Drawing.Size(89, 24);
            this.radBeginner.TabIndex = 0;
            this.radBeginner.TabStop = true;
            this.radBeginner.Text = "Beginner";
            this.radBeginner.UseVisualStyleBackColor = true;
            this.radBeginner.CheckedChanged += new System.EventHandler(this.ComputeCost_CheckedChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(204, 366);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(74, 20);
            this.lblMsg.TabIndex = 10;
            this.lblMsg.Text = "          xxx ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckBoxDive);
            this.Controls.Add(this.ckBoxSnorkel);
            this.Controls.Add(this.ckBoxSwim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckBoxSwim;
        private System.Windows.Forms.CheckBox ckBoxSnorkel;
        private System.Windows.Forms.CheckBox ckBoxDive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radAdvanced;
        private System.Windows.Forms.RadioButton radIntermediate;
        private System.Windows.Forms.RadioButton radBeginner;
        private System.Windows.Forms.Label lblMsg;
    }
}

