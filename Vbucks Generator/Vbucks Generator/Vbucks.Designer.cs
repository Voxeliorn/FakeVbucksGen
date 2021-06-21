
namespace Vbucks_Generator
{
    partial class Vbucks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vbucks));
            this.Gen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Gen
            // 
            this.Gen.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Gen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Gen.Location = new System.Drawing.Point(241, 12);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(298, 49);
            this.Gen.TabIndex = 0;
            this.Gen.Text = "Generate Vbucks";
            this.Gen.UseVisualStyleBackColor = false;
            this.Gen.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(241, 88);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(298, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.White;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.text.Location = new System.Drawing.Point(278, 117);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(220, 31);
            this.text.TabIndex = 2;
            this.text.Text = "YOU DID A MISTAKE.";
            this.text.Visible = false;
            this.text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Vbucks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Gen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vbucks";
            this.Text = "Vbucks Generator";
            this.Load += new System.EventHandler(this.Vbucks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox text;
    }
}

