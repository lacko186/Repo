namespace Retoxikáló
{
    partial class Számla
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
            this.Névjegy = new System.Windows.Forms.Button();
            this.sÚGÓ = new System.Windows.Forms.Button();
            this.Galéria = new System.Windows.Forms.Button();
            this.Itallap = new System.Windows.Forms.Button();
            this.Fájl = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Névjegy
            // 
            this.Névjegy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Névjegy.Location = new System.Drawing.Point(201, 0);
            this.Névjegy.Name = "Névjegy";
            this.Névjegy.Size = new System.Drawing.Size(60, 23);
            this.Névjegy.TabIndex = 11;
            this.Névjegy.Text = "Névjegy";
            this.Névjegy.UseVisualStyleBackColor = false;
            this.Névjegy.Click += new System.EventHandler(this.Névjegy_Click);
            // 
            // sÚGÓ
            // 
            this.sÚGÓ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sÚGÓ.Location = new System.Drawing.Point(151, 0);
            this.sÚGÓ.Name = "sÚGÓ";
            this.sÚGÓ.Size = new System.Drawing.Size(54, 23);
            this.sÚGÓ.TabIndex = 10;
            this.sÚGÓ.Text = "Súgó";
            this.sÚGÓ.UseVisualStyleBackColor = false;
            this.sÚGÓ.Click += new System.EventHandler(this.sÚGÓ_Click);
            // 
            // Galéria
            // 
            this.Galéria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Galéria.Location = new System.Drawing.Point(105, 0);
            this.Galéria.Name = "Galéria";
            this.Galéria.Size = new System.Drawing.Size(52, 23);
            this.Galéria.TabIndex = 9;
            this.Galéria.Text = "Galéria";
            this.Galéria.UseVisualStyleBackColor = false;
            this.Galéria.Click += new System.EventHandler(this.Galéria_Click);
            // 
            // Itallap
            // 
            this.Itallap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Itallap.Location = new System.Drawing.Point(58, 0);
            this.Itallap.Name = "Itallap";
            this.Itallap.Size = new System.Drawing.Size(52, 23);
            this.Itallap.TabIndex = 8;
            this.Itallap.Text = "Itallap";
            this.Itallap.UseVisualStyleBackColor = false;
            this.Itallap.Click += new System.EventHandler(this.Itallap_Click);
            // 
            // Fájl
            // 
            this.Fájl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Fájl.Location = new System.Drawing.Point(3, 0);
            this.Fájl.Name = "Fájl";
            this.Fájl.Size = new System.Drawing.Size(59, 23);
            this.Fájl.TabIndex = 7;
            this.Fájl.Text = "Fájl";
            this.Fájl.UseVisualStyleBackColor = false;
            this.Fájl.Click += new System.EventHandler(this.Fájl_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(84, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(599, 311);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Számol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Számla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Névjegy);
            this.Controls.Add(this.sÚGÓ);
            this.Controls.Add(this.Galéria);
            this.Controls.Add(this.Itallap);
            this.Controls.Add(this.Fájl);
            this.Name = "Számla";
            this.Text = "Számla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Névjegy;
        private System.Windows.Forms.Button sÚGÓ;
        private System.Windows.Forms.Button Galéria;
        private System.Windows.Forms.Button Itallap;
        private System.Windows.Forms.Button Fájl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
    }
}