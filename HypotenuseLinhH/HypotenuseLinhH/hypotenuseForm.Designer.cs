namespace HypotenuseLinhH
{
    partial class frmHypotenuse
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
            this.lblOpposite = new System.Windows.Forms.Label();
            this.lblAdjacent = new System.Windows.Forms.Label();
            this.btnCalculateHypotenuse = new System.Windows.Forms.Button();
            this.txtOpposite = new System.Windows.Forms.TextBox();
            this.txtAdjacent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOpposite
            // 
            this.lblOpposite.AutoSize = true;
            this.lblOpposite.Location = new System.Drawing.Point(61, 69);
            this.lblOpposite.Name = "lblOpposite";
            this.lblOpposite.Size = new System.Drawing.Size(52, 13);
            this.lblOpposite.TabIndex = 0;
            this.lblOpposite.Text = "Opposite:";
            // 
            // lblAdjacent
            // 
            this.lblAdjacent.AutoSize = true;
            this.lblAdjacent.Location = new System.Drawing.Point(61, 121);
            this.lblAdjacent.Name = "lblAdjacent";
            this.lblAdjacent.Size = new System.Drawing.Size(52, 13);
            this.lblAdjacent.TabIndex = 1;
            this.lblAdjacent.Text = "Adjacent:";
            // 
            // btnCalculateHypotenuse
            // 
            this.btnCalculateHypotenuse.Location = new System.Drawing.Point(88, 187);
            this.btnCalculateHypotenuse.Name = "btnCalculateHypotenuse";
            this.btnCalculateHypotenuse.Size = new System.Drawing.Size(126, 45);
            this.btnCalculateHypotenuse.TabIndex = 3;
            this.btnCalculateHypotenuse.Text = "Calculate Hypotenuse";
            this.btnCalculateHypotenuse.UseVisualStyleBackColor = true;
            this.btnCalculateHypotenuse.Click += new System.EventHandler(this.BtnCalculateHypotenuse_Click);
            // 
            // txtOpposite
            // 
            this.txtOpposite.Location = new System.Drawing.Point(132, 66);
            this.txtOpposite.Name = "txtOpposite";
            this.txtOpposite.Size = new System.Drawing.Size(100, 20);
            this.txtOpposite.TabIndex = 4;
            // 
            // txtAdjacent
            // 
            this.txtAdjacent.Location = new System.Drawing.Point(132, 115);
            this.txtAdjacent.Name = "txtAdjacent";
            this.txtAdjacent.Size = new System.Drawing.Size(100, 20);
            this.txtAdjacent.TabIndex = 5;
            // 
            // frmHypotenuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 364);
            this.Controls.Add(this.txtAdjacent);
            this.Controls.Add(this.txtOpposite);
            this.Controls.Add(this.btnCalculateHypotenuse);
            this.Controls.Add(this.lblAdjacent);
            this.Controls.Add(this.lblOpposite);
            this.Name = "frmHypotenuse";
            this.Text = "Hypotenuse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpposite;
        private System.Windows.Forms.Label lblAdjacent;
        private System.Windows.Forms.Button btnCalculateHypotenuse;
        private System.Windows.Forms.TextBox txtOpposite;
        private System.Windows.Forms.TextBox txtAdjacent;
    }
}

