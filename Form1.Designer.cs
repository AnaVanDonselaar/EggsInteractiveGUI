namespace EggsInteractiveGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEgg4 = new System.Windows.Forms.TextBox();
            this.txtEgg2 = new System.Windows.Forms.TextBox();
            this.txtEgg1 = new System.Windows.Forms.TextBox();
            this.txtEgg3 = new System.Windows.Forms.TextBox();
            this.txtEgg5 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of eggs produced by each of 5 chickens";
            // 
            // txtEgg4
            // 
            this.txtEgg4.Location = new System.Drawing.Point(168, 114);
            this.txtEgg4.Name = "txtEgg4";
            this.txtEgg4.Size = new System.Drawing.Size(43, 20);
            this.txtEgg4.TabIndex = 1;
            // 
            // txtEgg2
            // 
            this.txtEgg2.Location = new System.Drawing.Point(168, 75);
            this.txtEgg2.Name = "txtEgg2";
            this.txtEgg2.Size = new System.Drawing.Size(43, 20);
            this.txtEgg2.TabIndex = 2;
            // 
            // txtEgg1
            // 
            this.txtEgg1.Location = new System.Drawing.Point(65, 75);
            this.txtEgg1.Name = "txtEgg1";
            this.txtEgg1.Size = new System.Drawing.Size(43, 20);
            this.txtEgg1.TabIndex = 3;
            // 
            // txtEgg3
            // 
            this.txtEgg3.Location = new System.Drawing.Point(65, 114);
            this.txtEgg3.Name = "txtEgg3";
            this.txtEgg3.Size = new System.Drawing.Size(43, 20);
            this.txtEgg3.TabIndex = 4;
            // 
            // txtEgg5
            // 
            this.txtEgg5.Location = new System.Drawing.Point(120, 150);
            this.txtEgg5.Name = "txtEgg5";
            this.txtEgg5.Size = new System.Drawing.Size(43, 20);
            this.txtEgg5.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(109, 214);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Calculate";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(65, 272);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(209, 66);
            this.txtOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 514);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEgg5);
            this.Controls.Add(this.txtEgg3);
            this.Controls.Add(this.txtEgg1);
            this.Controls.Add(this.txtEgg2);
            this.Controls.Add(this.txtEgg4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Eggs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEgg4;
        private System.Windows.Forms.TextBox txtEgg2;
        private System.Windows.Forms.TextBox txtEgg1;
        private System.Windows.Forms.TextBox txtEgg3;
        private System.Windows.Forms.TextBox txtEgg5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

