namespace SimpleCalculator
{
    partial class frmSimpleCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOperandOne = new System.Windows.Forms.Label();
            this.lblOperatorSymbol = new System.Windows.Forms.Label();
            this.lblOperandTwo = new System.Windows.Forms.Label();
            this.lblResultOut = new System.Windows.Forms.Label();
            this.txtOperandOne = new System.Windows.Forms.TextBox();
            this.txtOperatorSymbol = new System.Windows.Forms.TextBox();
            this.txtOperandTwo = new System.Windows.Forms.TextBox();
            this.txtResultOut = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOperandOne
            // 
            this.lblOperandOne.AutoSize = true;
            this.lblOperandOne.Location = new System.Drawing.Point(49, 39);
            this.lblOperandOne.Name = "lblOperandOne";
            this.lblOperandOne.Size = new System.Drawing.Size(65, 15);
            this.lblOperandOne.TabIndex = 0;
            this.lblOperandOne.Text = "&Operand 1:";
            // 
            // lblOperatorSymbol
            // 
            this.lblOperatorSymbol.AutoSize = true;
            this.lblOperatorSymbol.Location = new System.Drawing.Point(49, 76);
            this.lblOperatorSymbol.Name = "lblOperatorSymbol";
            this.lblOperatorSymbol.Size = new System.Drawing.Size(57, 15);
            this.lblOperatorSymbol.TabIndex = 0;
            this.lblOperatorSymbol.Text = "O&perator:";
            // 
            // lblOperandTwo
            // 
            this.lblOperandTwo.AutoSize = true;
            this.lblOperandTwo.Location = new System.Drawing.Point(49, 113);
            this.lblOperandTwo.Name = "lblOperandTwo";
            this.lblOperandTwo.Size = new System.Drawing.Size(65, 15);
            this.lblOperandTwo.TabIndex = 0;
            this.lblOperandTwo.Text = "Op&erand 2:";
            // 
            // lblResultOut
            // 
            this.lblResultOut.AutoSize = true;
            this.lblResultOut.Location = new System.Drawing.Point(49, 150);
            this.lblResultOut.Name = "lblResultOut";
            this.lblResultOut.Size = new System.Drawing.Size(42, 15);
            this.lblResultOut.TabIndex = 0;
            this.lblResultOut.Text = "Result:";
            // 
            // txtOperandOne
            // 
            this.txtOperandOne.Location = new System.Drawing.Point(135, 39);
            this.txtOperandOne.Name = "txtOperandOne";
            this.txtOperandOne.Size = new System.Drawing.Size(100, 23);
            this.txtOperandOne.TabIndex = 1;
            this.txtOperandOne.TextChanged += new System.EventHandler(this.ClearText);
            // 
            // txtOperatorSymbol
            // 
            this.txtOperatorSymbol.Location = new System.Drawing.Point(135, 76);
            this.txtOperatorSymbol.Name = "txtOperatorSymbol";
            this.txtOperatorSymbol.Size = new System.Drawing.Size(29, 23);
            this.txtOperatorSymbol.TabIndex = 2;
            this.txtOperatorSymbol.TextChanged += new System.EventHandler(this.ClearText);
            // 
            // txtOperandTwo
            // 
            this.txtOperandTwo.Location = new System.Drawing.Point(135, 113);
            this.txtOperandTwo.Name = "txtOperandTwo";
            this.txtOperandTwo.Size = new System.Drawing.Size(100, 23);
            this.txtOperandTwo.TabIndex = 3;
            this.txtOperandTwo.TextChanged += new System.EventHandler(this.ClearText);
            // 
            // txtResultOut
            // 
            this.txtResultOut.Location = new System.Drawing.Point(135, 150);
            this.txtResultOut.Name = "txtResultOut";
            this.txtResultOut.ReadOnly = true;
            this.txtResultOut.Size = new System.Drawing.Size(100, 23);
            this.txtResultOut.TabIndex = 1;
            this.txtResultOut.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(68, 208);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(85, 30);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(175, 208);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSimpleCalculator
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(291, 275);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResultOut);
            this.Controls.Add(this.txtOperandTwo);
            this.Controls.Add(this.txtOperatorSymbol);
            this.Controls.Add(this.txtOperandOne);
            this.Controls.Add(this.lblResultOut);
            this.Controls.Add(this.lblOperandTwo);
            this.Controls.Add(this.lblOperatorSymbol);
            this.Controls.Add(this.lblOperandOne);
            this.Name = "frmSimpleCalculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOperandOne;
        private Label lblOperatorSymbol;
        private Label lblOperandTwo;
        private Label lblResultOut;
        private TextBox txtOperandOne;
        private TextBox txtOperatorSymbol;
        private TextBox txtOperandTwo;
        private TextBox txtResultOut;
        private Button btnCalculate;
        private Button btnExit;
    }
}