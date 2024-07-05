namespace Retoxikáló
{
    partial class Galéria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Galéria));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Névjegy = new System.Windows.Forms.Button();
            this.sÚGÓ = new System.Windows.Forms.Button();
            this.Galéria_1 = new System.Windows.Forms.Button();
            this.Itallap = new System.Windows.Forms.Button();
            this.Fájl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 344);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(457, 390);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 35);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(255, 390);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 35);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Névjegy
            // 
            this.Névjegy.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Névjegy.Location = new System.Drawing.Point(198, 0);
            this.Névjegy.Name = "Névjegy";
            this.Névjegy.Size = new System.Drawing.Size(60, 23);
            this.Névjegy.TabIndex = 11;
            this.Névjegy.Text = "Névjegy";
            this.Névjegy.UseVisualStyleBackColor = false;
            this.Névjegy.Click += new System.EventHandler(this.Névjegy_Click_1);
            // 
            // sÚGÓ
            // 
            this.sÚGÓ.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sÚGÓ.Location = new System.Drawing.Point(148, 0);
            this.sÚGÓ.Name = "sÚGÓ";
            this.sÚGÓ.Size = new System.Drawing.Size(54, 23);
            this.sÚGÓ.TabIndex = 10;
            this.sÚGÓ.Text = "Súgó";
            this.sÚGÓ.UseVisualStyleBackColor = false;
            this.sÚGÓ.Click += new System.EventHandler(this.sÚGÓ_Click_1);
            // 
            // Galéria_1
            // 
            this.Galéria_1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Galéria_1.Location = new System.Drawing.Point(102, 0);
            this.Galéria_1.Name = "Galéria_1";
            this.Galéria_1.Size = new System.Drawing.Size(52, 23);
            this.Galéria_1.TabIndex = 9;
            this.Galéria_1.Text = "Galéria";
            this.Galéria_1.UseVisualStyleBackColor = false;
            this.Galéria_1.Click += new System.EventHandler(this.Galéria_1_Click_1);
            // 
            // Itallap
            // 
            this.Itallap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Itallap.Location = new System.Drawing.Point(55, 0);
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
            this.Fájl.Location = new System.Drawing.Point(0, 0);
            this.Fájl.Name = "Fájl";
            this.Fájl.Size = new System.Drawing.Size(59, 23);
            this.Fájl.TabIndex = 7;
            this.Fájl.Text = "Fájl";
            this.Fájl.UseVisualStyleBackColor = false;
            this.Fájl.Click += new System.EventHandler(this.Fájl_Click_1);
            // 
            // Galéria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Névjegy);
            this.Controls.Add(this.sÚGÓ);
            this.Controls.Add(this.Galéria_1);
            this.Controls.Add(this.Itallap);
            this.Controls.Add(this.Fájl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Galéria";
            this.Text = "Galéria";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Névjegy;
        private System.Windows.Forms.Button sÚGÓ;
        private System.Windows.Forms.Button Galéria_1;
        private System.Windows.Forms.Button Itallap;
        private System.Windows.Forms.Button Fájl;
    }
}