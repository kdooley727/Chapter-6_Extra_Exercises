using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        //Event handler for calculate button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string operatorSymbol = (txtOperatorSymbol.Text);
            decimal operandOne = Convert.ToDecimal(txtOperandOne.Text);
            decimal operandTwo = Convert.ToDecimal(txtOperandTwo.Text);

            decimal resultout = Calculate(operandOne, operandTwo, operatorSymbol);
            txtResultOut.Text = Convert.ToString(resultout);
        }

        //calculate method
        private decimal Calculate(decimal operandOne, decimal operandTwo, string operatorSymbol)
        {
            decimal resultOut = 0;
            switch (operatorSymbol)
            {
                case "+":
                    return resultOut = operandOne + operandTwo;
                case "-":
                    return resultOut = operandOne - operandTwo;
                case "*":
                    return resultOut = operandOne * operandTwo;
                case "/":
                    return resultOut = operandOne / operandTwo;
                default:
                    return resultOut;
            }
        }
        //end of calculate method




        //Event handler for exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //start of clear method
        private void ClearText(object sender, EventArgs e)
        {
            txtResultOut.Text = "";
        }
    }
} 