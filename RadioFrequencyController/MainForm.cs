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
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            // If the buffer is empty (after a reset), enforce that first input must be '1'
            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            // Validate the prefix before allowing input
            if (IsValidPrefix(newBuffer))
            {
                frequencyBuffer = newBuffer;
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Invalid frequency prefix! Valid ranges: 118.000 - 136.975 MHz.");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            // If the buffer is empty (after a reset), enforce that first input must be '1'
            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            // Validate the prefix before allowing input
            if (IsValidPrefix(newBuffer))
            {
                frequencyBuffer = newBuffer;
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Invalid frequency prefix! Valid ranges: 118.000 - 136.975 MHz.");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            // If the buffer is empty (after a reset), enforce that first input must be '1'
            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            // Validate the prefix before allowing input
            if (IsValidPrefix(newBuffer))
            {
                frequencyBuffer = newBuffer;
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Invalid frequency prefix! Valid ranges: 118.000 - 136.975 MHz.");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            // If the buffer is empty (after a reset), enforce that first input must be '1'
            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            // Validate the prefix before allowing input
            if (IsValidPrefix(newBuffer))
            {
                frequencyBuffer = newBuffer;
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Invalid frequency prefix! Valid ranges: 118.000 - 136.975 MHz.");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            // If the buffer is empty (after a reset), enforce that first input must be '1'
            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            // Validate the prefix before allowing input
            if (IsValidPrefix(newBuffer))
            {
                frequencyBuffer = newBuffer;
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Invalid frequency prefix! Valid ranges: 118.000 - 136.975 MHz.");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            // If the buffer is empty (after a reset), enforce that first input must be '1'
            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            // Validate the prefix before allowing input
            if (IsValidPrefix(newBuffer))
            {
                frequencyBuffer = newBuffer;
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Invalid frequency prefix! Valid ranges: 118.000 - 136.975 MHz.");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            // If the buffer is empty (after a reset), enforce that first input must be '1'
            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            // Validate the prefix before allowing input
            if (IsValidPrefix(newBuffer))
            {
                frequencyBuffer = newBuffer;
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Invalid frequency prefix! Valid ranges: 118.000 - 136.975 MHz.");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            // If the buffer is empty (after a reset), enforce that first input must be '1'
            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            // Validate the prefix before allowing input
            if (IsValidPrefix(newBuffer))
            {
                frequencyBuffer = newBuffer;
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Invalid frequency prefix! Valid ranges: 118.000 - 136.975 MHz.");
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            // If the buffer is empty (after a reset), enforce that first input must be '1'
            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            // Validate the prefix before allowing input
            if (IsValidPrefix(newBuffer))
            {
                frequencyBuffer = newBuffer;
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Invalid frequency prefix! Valid ranges: 118.000 - 136.975 MHz.");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || frequencyBuffer.Length >= 6) return; // Ensure max 6 digits

            string newBuffer = frequencyBuffer + btn.Text;

            // If the buffer is empty (after a reset), enforce that first input must be '1'
            if (frequencyBuffer.Length == 0 && btn.Text != "1")
            {
                MessageBox.Show("Frequency must start with '1' (e.g., 118-136).");
                return;
            }

            // Validate the prefix before allowing input
            if (IsValidPrefix(newBuffer))
            {
                frequencyBuffer = newBuffer;
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("Invalid frequency prefix! Valid ranges: 118.000 - 136.975 MHz.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frequencyBuffer = "";  // Clear the input completely
            lblFrequencyDisplay.Text = "118.000";  // Show a default valid frequency
        }

        private void UpdateDisplay()
        {
            // If the buffer is empty, show a default valid frequency
            if (string.IsNullOrEmpty(frequencyBuffer))
            {
                lblFrequencyDisplay.Text = "118.000";
                return;
            }

            // Ensure at least 3 digits before the decimal
            string formattedFrequency = frequencyBuffer.PadRight(6, '0');

            // Insert the decimal point automatically
            string displayFrequency = formattedFrequency.Insert(3, ".");

            lblFrequencyDisplay.Text = displayFrequency;
        }

        private bool IsValidPrefix(string input)
        {
            if (input.Length == 1)
            {
                // First digit must always be '1'
                return input == "1";
            }
            else if (input.Length == 2)
            {
                // Second digit must be 1, 2, or 3 (to allow 118-136 range)
                char secondDigit = input[1];
                return secondDigit == '1' || secondDigit == '2' || secondDigit == '3';
            }
            else if (input.Length == 3)
            {
                // Third digit depends on the second digit:
                char secondDigit = input[1];
                char thirdDigit = input[2];

                if (secondDigit == '1') return thirdDigit == '8' || thirdDigit == '9'; // 118, 119
                if (secondDigit == '2') return thirdDigit >= '0' && thirdDigit <= '9'; // 120-129
                if (secondDigit == '3') return thirdDigit >= '0' && thirdDigit <= '6'; // 130-136
            }
             
            return false;
        }
    }
}
