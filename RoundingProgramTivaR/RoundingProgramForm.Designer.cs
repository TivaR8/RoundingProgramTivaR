namespace RoundingProgramTivaR
{
    partial class frmRoundingProgram
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
            this.lblDecimalQuestion = new System.Windows.Forms.Label();
            this.lblPlacesQuestion = new System.Windows.Forms.Label();
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.nudDecPlaces = new System.Windows.Forms.NumericUpDown();
            this.btnRounding = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecPlaces)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDecimalQuestion
            // 
            this.lblDecimalQuestion.AutoSize = true;
            this.lblDecimalQuestion.Location = new System.Drawing.Point(24, 50);
            this.lblDecimalQuestion.Name = "lblDecimalQuestion";
            this.lblDecimalQuestion.Size = new System.Drawing.Size(124, 13);
            this.lblDecimalQuestion.TabIndex = 0;
            this.lblDecimalQuestion.Text = "Enter a decimal number: ";
            // 
            // lblPlacesQuestion
            // 
            this.lblPlacesQuestion.AutoSize = true;
            this.lblPlacesQuestion.Location = new System.Drawing.Point(12, 99);
            this.lblPlacesQuestion.Name = "lblPlacesQuestion";
            this.lblPlacesQuestion.Size = new System.Drawing.Size(251, 13);
            this.lblPlacesQuestion.TabIndex = 1;
            this.lblPlacesQuestion.Text = "How many decimal places do you want to round to: ";
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Location = new System.Drawing.Point(282, 50);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(100, 20);
            this.txtUserNumber.TabIndex = 2;
            // 
            // nudDecPlaces
            // 
            this.nudDecPlaces.Location = new System.Drawing.Point(282, 99);
            this.nudDecPlaces.Name = "nudDecPlaces";
            this.nudDecPlaces.Size = new System.Drawing.Size(120, 20);
            this.nudDecPlaces.TabIndex = 3;
            // 
            // btnRounding
            // 
            this.btnRounding.Location = new System.Drawing.Point(172, 151);
            this.btnRounding.Name = "btnRounding";
            this.btnRounding.Size = new System.Drawing.Size(75, 23);
            this.btnRounding.TabIndex = 4;
            this.btnRounding.Text = "Round";
            this.btnRounding.UseVisualStyleBackColor = true;
            this.btnRounding.Click += new System.EventHandler(this.btnRounding_Click);
            // 
            // frmRoundingProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 205);
            this.Controls.Add(this.btnRounding);
            this.Controls.Add(this.nudDecPlaces);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.lblPlacesQuestion);
            this.Controls.Add(this.lblDecimalQuestion);
            this.Name = "frmRoundingProgram";
            this.Text = "Rounding Program By Tiva Rait";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecPlaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDecimalQuestion;
        private System.Windows.Forms.Label lblPlacesQuestion;
        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.NumericUpDown nudDecPlaces;
        private System.Windows.Forms.Button btnRounding;
    }
}

