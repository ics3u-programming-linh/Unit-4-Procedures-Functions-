namespace PassByReferenceLinhHo
{
    partial class frmPassByReference
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
            this.lblDecimalNum = new System.Windows.Forms.Label();
            this.lblDecimalPlaces = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnRound = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDecimalNum
            // 
            this.lblDecimalNum.AutoSize = true;
            this.lblDecimalNum.Location = new System.Drawing.Point(53, 86);
            this.lblDecimalNum.Name = "lblDecimalNum";
            this.lblDecimalNum.Size = new System.Drawing.Size(121, 13);
            this.lblDecimalNum.TabIndex = 0;
            this.lblDecimalNum.Text = "Enter a decimal number:";
            // 
            // lblDecimalPlaces
            // 
            this.lblDecimalPlaces.AutoSize = true;
            this.lblDecimalPlaces.Location = new System.Drawing.Point(53, 117);
            this.lblDecimalPlaces.Name = "lblDecimalPlaces";
            this.lblDecimalPlaces.Size = new System.Drawing.Size(251, 13);
            this.lblDecimalPlaces.TabIndex = 1;
            this.lblDecimalPlaces.Text = "How many decimal places do you want to round to?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(311, 115);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(152, 204);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(135, 37);
            this.btnRound.TabIndex = 5;
            this.btnRound.Text = "Round";
            this.btnRound.UseVisualStyleBackColor = true;
            // 
            // frmPassByReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 376);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDecimalPlaces);
            this.Controls.Add(this.lblDecimalNum);
            this.Name = "frmPassByReference";
            this.Text = "Pass By Reference by Linh Ho";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecimalNum;
        private System.Windows.Forms.Label lblDecimalPlaces;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnRound;
    }
}

