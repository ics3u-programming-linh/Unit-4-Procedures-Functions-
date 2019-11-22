namespace NewWalkingManLinhH
{
    partial class frmNewWalkingMan
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.picMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(269, 157);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(154, 104);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(35, 13);
            this.lblInstructions.TabIndex = 1;
            this.lblInstructions.Text = "label1";
            // 
            // picMan
            // 
            this.picMan.Image = global::NewWalkingManLinhH.Properties.Resources.walk10;
            this.picMan.Location = new System.Drawing.Point(472, 140);
            this.picMan.Name = "picMan";
            this.picMan.Size = new System.Drawing.Size(100, 50);
            this.picMan.TabIndex = 2;
            this.picMan.TabStop = false;
            // 
            // frmNewWalkingMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMan);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnStart);
            this.Name = "frmNewWalkingMan";
            this.Text = "New Walking Man";
            this.Load += new System.EventHandler(this.FrmNewWalkingMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.PictureBox picMan;
    }
}

