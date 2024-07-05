namespace Retoxikáló
{
    partial class Súgó
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Súgó));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Névjegy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Galéria = new System.Windows.Forms.Button();
            this.Itallap = new System.Windows.Forms.Button();
            this.Fájl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 34);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(279, 391);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Névjegy
            // 
            this.Névjegy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Névjegy.Location = new System.Drawing.Point(199, 0);
            this.Névjegy.Name = "Névjegy";
            this.Névjegy.Size = new System.Drawing.Size(60, 23);
            this.Névjegy.TabIndex = 11;
            this.Névjegy.Text = "Névjegy";
            this.Névjegy.UseVisualStyleBackColor = false;
            this.Névjegy.Click += new System.EventHandler(this.Névjegy_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(149, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Súgó";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Galéria
            // 
            this.Galéria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Galéria.Location = new System.Drawing.Point(103, 0);
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
            this.Itallap.Location = new System.Drawing.Point(56, 0);
            this.Itallap.Name = "Itallap";
            this.Itallap.Size = new System.Drawing.Size(52, 23);
            this.Itallap.TabIndex = 8;
            this.Itallap.Text = "Itallap";
            this.Itallap.UseVisualStyleBackColor = false;
            this.Itallap.Click += new System.EventHandler(this.Itallap_Click_1);
            // 
            // Fájl
            // 
            this.Fájl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Fájl.Location = new System.Drawing.Point(1, 0);
            this.Fájl.Name = "Fájl";
            this.Fájl.Size = new System.Drawing.Size(59, 23);
            this.Fájl.TabIndex = 7;
            this.Fájl.Text = "Fájl";
            this.Fájl.UseVisualStyleBackColor = false;
            this.Fájl.Click += new System.EventHandler(this.Fájl_Click);
            // 
            // Súgó
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 460);
            this.Controls.Add(this.Névjegy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Galéria);
            this.Controls.Add(this.Itallap);
            this.Controls.Add(this.Fájl);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Súgó";
            this.Text = "Súgó";
            this.Load += new System.EventHandler(this.Súgó_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Névjegy;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Galéria;
        private System.Windows.Forms.Button Itallap;
        private System.Windows.Forms.Button Fájl;
    }
}