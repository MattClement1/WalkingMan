namespace WalkingMan
{
    partial class frmWalkingMan
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
            this.btnWalk = new System.Windows.Forms.Button();
            this.picWalkingMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWalkingMan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWalk
            // 
            this.btnWalk.Location = new System.Drawing.Point(105, 214);
            this.btnWalk.Name = "btnWalk";
            this.btnWalk.Size = new System.Drawing.Size(75, 23);
            this.btnWalk.TabIndex = 1;
            this.btnWalk.Text = "Walk";
            this.btnWalk.UseVisualStyleBackColor = true;
            this.btnWalk.Click += new System.EventHandler(this.btnWalk_Click);
            // 
            // picWalkingMan
            // 
            this.picWalkingMan.Image = global::WalkingMan.Properties.Resources.walk1;
            this.picWalkingMan.Location = new System.Drawing.Point(120, 12);
            this.picWalkingMan.Name = "picWalkingMan";
            this.picWalkingMan.Size = new System.Drawing.Size(180, 180);
            this.picWalkingMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picWalkingMan.TabIndex = 0;
            this.picWalkingMan.TabStop = false;
            // 
            // frmWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 261);
            this.Controls.Add(this.btnWalk);
            this.Controls.Add(this.picWalkingMan);
            this.Name = "frmWalkingMan";
            this.Text = "Walking Man";
            ((System.ComponentModel.ISupportInitialize)(this.picWalkingMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWalkingMan;
        private System.Windows.Forms.Button btnWalk;
    }
}

