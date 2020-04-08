using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// basic calculator
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Clearing Methods
        /// <summary>
        /// Cleasrs the user input text.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e"> The event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //clears the test for the input box.
            this.UserInputText.Text = string.Empty;

            //focuses the user input text.
            FocusInputText();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteTextValue();

        }
        #endregion

        #region Operator Methods

        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("x");
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }


        #endregion

        #region Number Methods
        private void SevenButton_Click(object sender, EventArgs e)
        {
            //resets the text in the box to the string plus 0 inserted at cursor.
            InsertTextValue("7");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
        }

        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
        }
        #endregion

        
        #region Private Helpers
        /// <summary>
        /// Focuses the user Input text
        /// </summary>
        private void FocusInputText()
        {

            this.UserInputText.Focus();
        }

        /// <summary>
        ///resets the text in the box to the string plus 0 inserted at cursor.
        /// </summary>
        /// <param name="value"> The number inserted into calculator textbox</param>
        private void InsertTextValue(string value)
        {
            var selectionStart = this.UserInputText.SelectionStart;

            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            this.UserInputText.SelectionStart = selectionStart + value.Length;
            this.UserInputText.SelectionLength = 0;
            FocusInputText();
        }

        /// <summary>
        /// Deletes a value to the right of the selector from the text box.
        /// </summary>
        private void DeleteTextValue()
        {
            var selectionStart = this.UserInputText.SelectionStart;

            if (this.UserInputText.Text.Length >= this.UserInputText.SelectionStart + 1)
            {
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);
            }
            int cal = 5 * 7 + 12 + (6 % 7);

            this.UserInputText.SelectionStart = selectionStart;
            this.UserInputText.SelectionLength = 0;
            FocusInputText();
        }

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label.
        /// </summary>
        private void CalculateEquation()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
