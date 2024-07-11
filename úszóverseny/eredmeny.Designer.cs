namespace úszóverseny
{
    partial class eredmeny
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
            this.kiír = new System.Windows.Forms.Button();
            this.ido = new System.Windows.Forms.TextBox();
            this.ország = new System.Windows.Forms.TextBox();
            this.rajszam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.résztvevő = new System.Windows.Forms.Button();
            this.bezár = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.eredmenyrb = new System.Windows.Forms.RadioButton();
            this.nevsorrb = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kiír
            // 
            this.kiír.Location = new System.Drawing.Point(289, 370);
            this.kiír.Name = "kiír";
            this.kiír.Size = new System.Drawing.Size(75, 23);
            this.kiír.TabIndex = 53;
            this.kiír.Text = "kiír";
            this.kiír.UseVisualStyleBackColor = true;
            this.kiír.Click += new System.EventHandler(this.button1_Click);
            // 
            // ido
            // 
            this.ido.Location = new System.Drawing.Point(460, 227);
            this.ido.Name = "ido";
            this.ido.Size = new System.Drawing.Size(100, 20);
            this.ido.TabIndex = 48;
            // 
            // ország
            // 
            this.ország.Location = new System.Drawing.Point(460, 184);
            this.ország.Name = "ország";
            this.ország.Size = new System.Drawing.Size(100, 20);
            this.ország.TabIndex = 47;
            // 
            // rajszam
            // 
            this.rajszam.Location = new System.Drawing.Point(460, 138);
            this.rajszam.Name = "rajszam";
            this.rajszam.Size = new System.Drawing.Size(100, 20);
            this.rajszam.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(130, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "résztvevők";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Hosszú Katinka",
            "Jakabos Zsuzsanna",
            "Snildal Ingvild",
            "Aljand Triin",
            "Martina Granstrom"});
            this.listBox1.Location = new System.Drawing.Point(105, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(171, 212);
            this.listBox1.TabIndex = 44;
            // 
            // résztvevő
            // 
            this.résztvevő.Location = new System.Drawing.Point(125, 370);
            this.résztvevő.Name = "résztvevő";
            this.résztvevő.Size = new System.Drawing.Size(121, 23);
            this.résztvevő.TabIndex = 43;
            this.résztvevő.Text = "résztvevő országok";
            this.résztvevő.UseVisualStyleBackColor = true;
            this.résztvevő.Click += new System.EventHandler(this.résztvevő_Click);
            // 
            // bezár
            // 
            this.bezár.Location = new System.Drawing.Point(544, 370);
            this.bezár.Name = "bezár";
            this.bezár.Size = new System.Drawing.Size(75, 23);
            this.bezár.TabIndex = 42;
            this.bezár.Text = "Bezár";
            this.bezár.UseVisualStyleBackColor = true;
            this.bezár.Click += new System.EventHandler(this.bezár_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(342, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "időeredmény";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(341, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ország";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(340, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Rajtszám";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(195, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 35);
            this.label1.TabIndex = 36;
            this.label1.Text = "300 méteres gyorsúszás eredménye:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.eredmenyrb);
            this.groupBox1.Controls.Add(this.nevsorrb);
            this.groupBox1.Location = new System.Drawing.Point(436, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendezési szempontok";
            // 
            // eredmenyrb
            // 
            this.eredmenyrb.AutoSize = true;
            this.eredmenyrb.Location = new System.Drawing.Point(7, 68);
            this.eredmenyrb.Name = "eredmenyrb";
            this.eredmenyrb.Size = new System.Drawing.Size(105, 17);
            this.eredmenyrb.TabIndex = 1;
            this.eredmenyrb.TabStop = true;
            this.eredmenyrb.Text = "Eredmény szerint";
            this.eredmenyrb.UseVisualStyleBackColor = true;
            // 
            // nevsorrb
            // 
            this.nevsorrb.AutoSize = true;
            this.nevsorrb.Location = new System.Drawing.Point(7, 20);
            this.nevsorrb.Name = "nevsorrb";
            this.nevsorrb.Size = new System.Drawing.Size(92, 17);
            this.nevsorrb.TabIndex = 0;
            this.nevsorrb.TabStop = true;
            this.nevsorrb.Text = "Névsor szerint";
            this.nevsorrb.UseVisualStyleBackColor = true;
            // 
            // eredmeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kiír);
            this.Controls.Add(this.ido);
            this.Controls.Add(this.ország);
            this.Controls.Add(this.rajszam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.résztvevő);
            this.Controls.Add(this.bezár);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "eredmeny";
            this.Text = "eredmeny";
            this.Load += new System.EventHandler(this.eredmeny_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kiír;
        private System.Windows.Forms.TextBox ido;
        private System.Windows.Forms.TextBox ország;
        private System.Windows.Forms.TextBox rajszam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button résztvevő;
        private System.Windows.Forms.Button bezár;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton eredmenyrb;
        private System.Windows.Forms.RadioButton nevsorrb;
    }
}