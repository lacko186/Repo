namespace Retoxikáló
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Fájl = new System.Windows.Forms.Button();
            this.Itallap = new System.Windows.Forms.Button();
            this.Galéria = new System.Windows.Forms.Button();
            this.sÚGÓ = new System.Windows.Forms.Button();
            this.Névjegy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(842, 521);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Fájl
            // 
            this.Fájl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Fájl.Location = new System.Drawing.Point(0, -1);
            this.Fájl.Name = "Fájl";
            this.Fájl.Size = new System.Drawing.Size(59, 23);
            this.Fájl.TabIndex = 1;
            this.Fájl.Text = "Fájl";
            this.Fájl.UseVisualStyleBackColor = false;
            // 
            // Itallap
            // 
            this.Itallap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Itallap.Location = new System.Drawing.Point(55, -1);
            this.Itallap.Name = "Itallap";
            this.Itallap.Size = new System.Drawing.Size(52, 23);
            this.Itallap.TabIndex = 2;
            this.Itallap.Text = "Itallap";
            this.Itallap.UseVisualStyleBackColor = false;
            this.Itallap.Click += new System.EventHandler(this.Itallap_Click);
            // 
            // Galéria
            // 
            this.Galéria.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Galéria.Location = new System.Drawing.Point(102, -1);
            this.Galéria.Name = "Galéria";
            this.Galéria.Size = new System.Drawing.Size(52, 23);
            this.Galéria.TabIndex = 3;
            this.Galéria.Text = "Galéria";
            this.Galéria.UseVisualStyleBackColor = false;
            this.Galéria.Click += new System.EventHandler(this.Galéria_Click);
            // 
            // sÚGÓ
            // 
            this.sÚGÓ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sÚGÓ.Location = new System.Drawing.Point(148, -1);
            this.sÚGÓ.Name = "sÚGÓ";
            this.sÚGÓ.Size = new System.Drawing.Size(54, 23);
            this.sÚGÓ.TabIndex = 4;
            this.sÚGÓ.Text = "Súgó";
            this.sÚGÓ.UseVisualStyleBackColor = false;
            this.sÚGÓ.Click += new System.EventHandler(this.sÚGÓ_Click);
            // 
            // Névjegy
            // 
            this.Névjegy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Névjegy.Location = new System.Drawing.Point(198, -1);
            this.Névjegy.Name = "Névjegy";
            this.Névjegy.Size = new System.Drawing.Size(60, 23);
            this.Névjegy.TabIndex = 5;
            this.Névjegy.Text = "Névjegy";
            this.Névjegy.UseVisualStyleBackColor = false;
            this.Névjegy.Click += new System.EventHandler(this.Névjegy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Névjegy);
            this.Controls.Add(this.sÚGÓ);
            this.Controls.Add(this.Galéria);
            this.Controls.Add(this.Itallap);
            this.Controls.Add(this.Fájl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Nyertes kocsma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Fájl;
        private System.Windows.Forms.Button Itallap;
        private System.Windows.Forms.Button Galéria;
        private System.Windows.Forms.Button sÚGÓ;
        private System.Windows.Forms.Button Névjegy;
    }
}

