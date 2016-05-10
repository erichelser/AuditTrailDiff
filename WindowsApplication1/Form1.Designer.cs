namespace WindowsApplication1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rundiff = new System.Windows.Forms.Button();
            this.diffprogram = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearfield = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(579, 330);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rundiff
            // 
            this.rundiff.Location = new System.Drawing.Point(474, 423);
            this.rundiff.Name = "rundiff";
            this.rundiff.Size = new System.Drawing.Size(117, 23);
            this.rundiff.TabIndex = 1;
            this.rundiff.Text = "Run Diff";
            this.rundiff.UseVisualStyleBackColor = true;
            this.rundiff.Click += new System.EventHandler(this.button1_Click);
            // 
            // diffprogram
            // 
            this.diffprogram.Location = new System.Drawing.Point(12, 25);
            this.diffprogram.Name = "diffprogram";
            this.diffprogram.Size = new System.Drawing.Size(579, 20);
            this.diffprogram.TabIndex = 2;
            this.diffprogram.Text = "C:\\Program Files\\Beyond Compare 3\\BCompare.exe";
            this.diffprogram.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Beyond Compare Location";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Audit Trail Tab Contents";
            // 
            // clearfield
            // 
            this.clearfield.Location = new System.Drawing.Point(12, 423);
            this.clearfield.Name = "clearfield";
            this.clearfield.Size = new System.Drawing.Size(117, 23);
            this.clearfield.TabIndex = 5;
            this.clearfield.Text = "Reset Field";
            this.clearfield.UseVisualStyleBackColor = true;
            this.clearfield.Click += new System.EventHandler(this.clearfield_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 458);
            this.Controls.Add(this.clearfield);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diffprogram);
            this.Controls.Add(this.rundiff);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Audit Trail Diff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button rundiff;
        private System.Windows.Forms.TextBox diffprogram;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearfield;
    }
}

