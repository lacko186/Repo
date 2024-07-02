namespace uszoverseny
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.győztes = new System.Windows.Forms.Button();
            this.bezár = new System.Windows.Forms.Button();
            this.beolvas = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rajszam = new System.Windows.Forms.TextBox();
            this.ország = new System.Windows.Forms.TextBox();
            this.ido = new System.Windows.Forms.TextBox();
            this.kor = new System.Windows.Forms.TextBox();
            this.gyöztestb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(237, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "200m-es pillangó úszás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(468, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rajtszám";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(469, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ország";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(467, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "időeredmény";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(472, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "életkor";
            // 
            // győztes
            // 
            this.győztes.Location = new System.Drawing.Point(454, 318);
            this.győztes.Name = "győztes";
            this.győztes.Size = new System.Drawing.Size(75, 23);
            this.győztes.TabIndex = 5;
            this.győztes.Text = "Győztes";
            this.győztes.UseVisualStyleBackColor = true;
            this.győztes.Click += new System.EventHandler(this.győztes_Click);
            // 
            // bezár
            // 
            this.bezár.Location = new System.Drawing.Point(588, 388);
            this.bezár.Name = "bezár";
            this.bezár.Size = new System.Drawing.Size(75, 23);
            this.bezár.TabIndex = 6;
            this.bezár.Text = "Bezár";
            this.bezár.UseVisualStyleBackColor = true;
            this.bezár.Click += new System.EventHandler(this.bezár_Click);
            // 
            // beolvas
            // 
            this.beolvas.Location = new System.Drawing.Point(107, 350);
            this.beolvas.Name = "beolvas";
            this.beolvas.Size = new System.Drawing.Size(90, 23);
            this.beolvas.TabIndex = 7;
            this.beolvas.Text = "Adatok beolvasása";
            this.beolvas.UseVisualStyleBackColor = true;
            this.beolvas.Click += new System.EventHandler(this.beolvas_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(107, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 212);
            this.listBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(132, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "résztvevők";
            // 
            // rajszam
            // 
            this.rajszam.Location = new System.Drawing.Point(588, 104);
            this.rajszam.Name = "rajszam";
            this.rajszam.Size = new System.Drawing.Size(100, 20);
            this.rajszam.TabIndex = 10;
            // 
            // ország
            // 
            this.ország.Location = new System.Drawing.Point(585, 150);
            this.ország.Name = "ország";
            this.ország.Size = new System.Drawing.Size(100, 20);
            this.ország.TabIndex = 11;
            // 
            // ido
            // 
            this.ido.Location = new System.Drawing.Point(585, 201);
            this.ido.Name = "ido";
            this.ido.Size = new System.Drawing.Size(100, 20);
            this.ido.TabIndex = 12;
            // 
            // kor
            // 
            this.kor.Location = new System.Drawing.Point(585, 246);
            this.kor.Name = "kor";
            this.kor.Size = new System.Drawing.Size(100, 20);
            this.kor.TabIndex = 13;
            // 
            // gyöztestb
            // 
            this.gyöztestb.Enabled = false;
            this.gyöztestb.Location = new System.Drawing.Point(551, 318);
            this.gyöztestb.Multiline = true;
            this.gyöztestb.Name = "gyöztestb";
            this.gyöztestb.Size = new System.Drawing.Size(147, 53);
            this.gyöztestb.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(467, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Neve:";
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(588, 64);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(100, 20);
            this.nev.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "fájlba írás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gyöztestb);
            this.Controls.Add(this.kor);
            this.Controls.Add(this.ido);
            this.Controls.Add(this.ország);
            this.Controls.Add(this.rajszam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.beolvas);
            this.Controls.Add(this.bezár);
            this.Controls.Add(this.győztes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "uszoverseny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button győztes;
        private System.Windows.Forms.Button bezár;
        private System.Windows.Forms.Button beolvas;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rajszam;
        private System.Windows.Forms.TextBox ország;
        private System.Windows.Forms.TextBox ido;
        private System.Windows.Forms.TextBox kor;
        private System.Windows.Forms.TextBox gyöztestb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.Button button1;
    }
}

