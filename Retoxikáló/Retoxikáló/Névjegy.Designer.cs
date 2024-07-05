namespace Retoxikáló
{
    partial class Névjegy
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
            this.Rendben = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Készült: prog2 gyakorlaton.";
            // 
            // Rendben
            // 
            this.Rendben.Location = new System.Drawing.Point(86, 129);
            this.Rendben.Name = "Rendben";
            this.Rendben.Size = new System.Drawing.Size(75, 23);
            this.Rendben.TabIndex = 18;
            this.Rendben.Text = "Rendben";
            this.Rendben.UseVisualStyleBackColor = true;
            this.Rendben.Click += new System.EventHandler(this.Rendben_Click);
            // 
            // Névjegy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 185);
            this.Controls.Add(this.Rendben);
            this.Controls.Add(this.label1);
            this.Name = "Névjegy";
            this.Text = "Információ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rendben;
    }
}