namespace TpFenetreMereFille
{
    partial class FFille
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
            this.lblChanger = new System.Windows.Forms.Label();
            this.btnChanger = new System.Windows.Forms.Button();
            this.tbChanger = new System.Windows.Forms.TextBox();
            this.btnMaMere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChanger
            // 
            this.lblChanger.AutoSize = true;
            this.lblChanger.Location = new System.Drawing.Point(3, 26);
            this.lblChanger.Name = "lblChanger";
            this.lblChanger.Size = new System.Drawing.Size(95, 13);
            this.lblChanger.TabIndex = 0;
            this.lblChanger.Text = "je change de nom:";
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(272, 19);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(103, 27);
            this.btnChanger.TabIndex = 2;
            this.btnChanger.Text = "Changer";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // tbChanger
            // 
            this.tbChanger.Location = new System.Drawing.Point(104, 23);
            this.tbChanger.Name = "tbChanger";
            this.tbChanger.Size = new System.Drawing.Size(162, 20);
            this.tbChanger.TabIndex = 3;
            // 
            // btnMaMere
            // 
            this.btnMaMere.Location = new System.Drawing.Point(119, 49);
            this.btnMaMere.Name = "btnMaMere";
            this.btnMaMere.Size = new System.Drawing.Size(121, 31);
            this.btnMaMere.TabIndex = 4;
            this.btnMaMere.Text = "Ma Mere";
            this.btnMaMere.UseVisualStyleBackColor = true;
            this.btnMaMere.Click += new System.EventHandler(this.btnMaMere_Click);
            // 
            // FFille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 89);
            this.Controls.Add(this.btnMaMere);
            this.Controls.Add(this.tbChanger);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.lblChanger);
            this.Name = "FFille";
            this.Text = "Fille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChanger;
        private System.Windows.Forms.Button btnChanger;
        private System.Windows.Forms.TextBox tbChanger;
        private System.Windows.Forms.Button btnMaMere;
    }
}