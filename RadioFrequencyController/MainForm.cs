using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.FlightSimulator.SimConnect;

namespace RadioFrequencyController
{

    public partial class MainForm : Form
    {
        private string frequencyBuffer = "";

        public MainForm()
        {
            InitializeComponent();
            btnReset_Click(null, null);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            frequencyBuffer = newBuffer;
            UpdateDisplay();
            UpdateButtonStates();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            frequencyBuffer = newBuffer;
            UpdateDisplay();
            UpdateButtonStates();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            frequencyBuffer = newBuffer;
            UpdateDisplay();
            UpdateButtonStates();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            frequencyBuffer = newBuffer;
            UpdateDisplay();
            UpdateButtonStates();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            frequencyBuffer = newBuffer;
            UpdateDisplay();
            UpdateButtonStates();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            frequencyBuffer = newBuffer;
            UpdateDisplay();
            UpdateButtonStates();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }
            frequencyBuffer = newBuffer;
            UpdateDisplay();
            UpdateButtonStates();

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            frequencyBuffer = newBuffer;
            UpdateDisplay();
            UpdateButtonStates();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            frequencyBuffer = newBuffer;
            UpdateDisplay();
            UpdateButtonStates();

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            frequencyBuffer = newBuffer;
            UpdateDisplay();
            UpdateButtonStates();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frequencyBuffer = "";  // Clear the input completely
            lblFrequencyDisplay.Text = "___.___";  // Show placeholder underscores
            UpdateButtonStates(); // Reset buttons
        }

        private void UpdateDisplay()
        {
            if (string.IsNullOrEmpty(frequencyBuffer))
            {
                lblFrequencyDisplay.Text = "___.___";  // Show underscores if empty
                return;
            }

            // Ensure at least 3 digits before the decimal
            string formattedFrequency = frequencyBuffer.PadRight(6, '_');

            // Insert the decimal point automatically after the first 3 digits
            string displayFrequency = formattedFrequency.Insert(3, ".");

            lblFrequencyDisplay.Text = displayFrequency;
        }


        private void UpdateButtonStates()
        {
            // Disable all buttons first
            btn0.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

            if (frequencyBuffer.Length == 0)
            {
                // First digit must be '1'
                btn1.Enabled = true;
            }
            else if (frequencyBuffer.Length == 1)
            {
                // Second digit can only be '2' or '3'
                if (frequencyBuffer == "1")
                {
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                }
            }
            else if (frequencyBuffer.Length == 2)
            {
                // Third digit depends on the second digit
                char secondDigit = frequencyBuffer[1];

                if (secondDigit == '1')
                {
                    // Allow 8-9 for "12x"
                    btn8.Enabled = true;
                    btn9.Enabled = true;
                }
                else if (secondDigit == '2')
                {
                    // Allow 0-9 for "12x"
                    btn0.Enabled = true;
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    btn5.Enabled = true;
                    btn6.Enabled = true;
                    btn7.Enabled = true;
                    btn8.Enabled = true;
                    btn9.Enabled = true;

                }
                else if (secondDigit == '3')
                {
                    // Allow only 0-6 for "13x"
                    btn0.Enabled = true;
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    btn5.Enabled = true;
                    btn6.Enabled = true;
                }
            }
            // can be deleted i guess or length >=3
            else if (frequencyBuffer.Length == 3)
            {
                char thirdDigit = frequencyBuffer[2];
                if (!string.IsNullOrEmpty(thirdDigit.ToString()))
                {
                    btn0.Enabled = true;
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    btn5.Enabled = true;
                    btn6.Enabled = true;
                    btn7.Enabled = true;
                    btn8.Enabled = true;
                    btn9.Enabled = true;
                }

            }
            else if (frequencyBuffer.Length == 4)
            {
                char fourthDigit = frequencyBuffer[3];
                if (!string.IsNullOrEmpty(fourthDigit.ToString()))
                {
                    btn0.Enabled = true;
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    btn4.Enabled = true;
                    btn5.Enabled = true;
                    btn6.Enabled = true;
                    btn7.Enabled = true;
                    btn8.Enabled = true;
                    btn9.Enabled = true;
                }
            }
            else if (frequencyBuffer.Length == 5)
            {
                char fifthDigit = frequencyBuffer[4];
                if (!string.IsNullOrEmpty(fifthDigit.ToString()))
                {
                    btn0.Enabled = true;
                    btn1.Enabled = false;
                    btn2.Enabled = false;
                    btn3.Enabled = false;
                    btn4.Enabled = false;
                    btn5.Enabled = true;
                    btn6.Enabled = false;
                    btn7.Enabled = false;
                    btn8.Enabled = false;
                    btn9.Enabled = false;
                }
            }
            else
            {
                // do nothing
            }
        }


        //private bool IsValidPrefix(string input)
        //{
        //    if (input.Length == 1)
        //    {
        //        // First digit must always be '1'
        //        return input == "1";
        //    }
        //    else if (input.Length == 2)
        //    {
        //        // Second digit must be 1, 2, or 3 (to allow 118-136 range)
        //        char secondDigit = input[1];
        //        return secondDigit == '1' || secondDigit == '2' || secondDigit == '3';
        //    }
        //    else if (input.Length == 3)
        //    {
        //        // Third digit depends on the second digit:
        //        char secondDigit = input[1];
        //        char thirdDigit = input[2];

        //        if (secondDigit == '1') return thirdDigit == '8' || thirdDigit == '9'; // 118, 119
        //        if (secondDigit == '2') return thirdDigit >= '0' && thirdDigit <= '9'; // 120-129
        //        if (secondDigit == '3') return thirdDigit >= '0' && thirdDigit <= '6'; // 130-136
        //    }

        //    return false;
        //}

        //private bool IsValidDecimal(string input)
        //{
        //    if (input.Length < 4) return true; // Allow typing until at least the 4th digit is entered

        //    if (input.Length == 4) // First digit after the decimal
        //    {
        //        char firstDecimalDigit = input[3];
        //        return firstDecimalDigit >= '0' && firstDecimalDigit <= '9'; // Must be 0-9
        //    }

        //    if (input.Length == 5) // Second digit after the decimal
        //    {
        //        char secondDecimalDigit = input[4];
        //        return secondDecimalDigit >= '0' && secondDecimalDigit <= '9'; // Must be 0-9
        //    }

        //    if (input.Length == 6) // Third decimal digit (final digit)
        //    {
        //        char thirdDecimalDigit = input[5];
        //        return thirdDecimalDigit == '0' || thirdDecimalDigit == '5'; // Must be 0 or 5
        //    }

        //    return true; // If all rules pass, input is valid
        //}

    }
}
