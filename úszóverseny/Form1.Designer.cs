namespace úszóverseny
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Fájl = new System.Windows.Forms.Button();
            this.Verseny = new System.Windows.Forms.Button();
            this.Eredmény = new System.Windows.Forms.Button();
            this.Névjegy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésCrtlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezárásALTF4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fájl
            // 
            this.Fájl.Location = new System.Drawing.Point(-1, 0);
            this.Fájl.Name = "Fájl";
            this.Fájl.Size = new System.Drawing.Size(75, 23);
            this.Fájl.TabIndex = 0;
            this.Fájl.Text = "Fájl";
            this.Fájl.UseVisualStyleBackColor = true;
            this.Fájl.Click += new System.EventHandler(this.button1_Click);
            // 
            // Verseny
            // 
            this.Verseny.Location = new System.Drawing.Point(67, 0);
            this.Verseny.Name = "Verseny";
            this.Verseny.Size = new System.Drawing.Size(75, 23);
            this.Verseny.TabIndex = 1;
            this.Verseny.Text = "Verseny";
            this.Verseny.UseVisualStyleBackColor = true;
            this.Verseny.Click += new System.EventHandler(this.button2_Click);
            // 
            // Eredmény
            // 
            this.Eredmény.Location = new System.Drawing.Point(138, 0);
            this.Eredmény.Name = "Eredmény";
            this.Eredmény.Size = new System.Drawing.Size(75, 23);
            this.Eredmény.TabIndex = 2;
            this.Eredmény.Text = "Eredmény";
            this.Eredmény.UseVisualStyleBackColor = true;
            this.Eredmény.Click += new System.EventHandler(this.Eredmény_Click);
            // 
            // Névjegy
            // 
            this.Névjegy.Location = new System.Drawing.Point(203, 0);
            this.Névjegy.Name = "Névjegy";
            this.Névjegy.Size = new System.Drawing.Size(75, 23);
            this.Névjegy.TabIndex = 3;
            this.Névjegy.Text = "Névjegy";
            this.Névjegy.UseVisualStyleBackColor = true;
            this.Névjegy.Click += new System.EventHandler(this.Névjegy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-14, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(841, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitásToolStripMenuItem,
            this.mentésCrtlSToolStripMenuItem,
            this.bezárásALTF4ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 70);
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás        Crtl + M";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // mentésCrtlSToolStripMenuItem
            // 
            this.mentésCrtlSToolStripMenuItem.Name = "mentésCrtlSToolStripMenuItem";
            this.mentésCrtlSToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.mentésCrtlSToolStripMenuItem.Text = "Mentés              Crtl + S";
            this.mentésCrtlSToolStripMenuItem.Click += new System.EventHandler(this.mentésCrtlSToolStripMenuItem_Click_1);
            // 
            // bezárásALTF4ToolStripMenuItem
            // 
            this.bezárásALTF4ToolStripMenuItem.Name = "bezárásALTF4ToolStripMenuItem";
            this.bezárásALTF4ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.bezárásALTF4ToolStripMenuItem.Text = "Bezárás            ALT +  F4";
            this.bezárásALTF4ToolStripMenuItem.Click += new System.EventHandler(this.bezárásALTF4ToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Névjegy);
            this.Controls.Add(this.Eredmény);
            this.Controls.Add(this.Verseny);
            this.Controls.Add(this.Fájl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Úszóverseny";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Fájl;
        private System.Windows.Forms.Button Verseny;
        private System.Windows.Forms.Button Eredmény;
        private System.Windows.Forms.Button Névjegy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésCrtlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezárásALTF4ToolStripMenuItem;
    }
}

