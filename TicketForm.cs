using System;
using System.Windows.Forms;

namespace TicketApplicationSystem
{
    public partial class TicketForm : Form
    {
        private TicketCalculator ticketCalculator;

        public TicketForm()
        {
            InitializeComponent();
            ticketCalculator = new TicketCalculator();
        }

        // Button Click Event - Calculate Ticket Price
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (!ValidateInputs(out string validationError))
                {
                    MessageBox.Show(validationError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Retrieve input values
                string passengerName = txtPassengerName.Text.Trim();
                string gender = rbMale.Checked ? "Male" : "Female";
                int age = int.Parse(txtAge.Text);
                string category = cmbCategory.SelectedItem.ToString();
                double distance = double.Parse(txtDistance.Text);

                // Calculate ticket price
                double finalPrice = ticketCalculator.CalculateTicketPrice(age, gender, category, distance);

                // Display summary
                DisplayTicketSummary(passengerName, gender, age, category, distance, finalPrice);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Button Click Event - Clear Form
        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtPassengerName.Clear();
            rbMale.Checked = true;
            txtAge.Clear();
            cmbCategory.SelectedIndex = -1;
            txtDistance.Clear();

            // Reset summary display
            lblSummary.Text = "No ticket calculated yet.";
        }

        // Button Click Event - Exit Application
        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Validate user inputs
        private bool ValidateInputs(out string errorMessage)
        {
            errorMessage = string.Empty;

            // Validate passenger name
            if (string.IsNullOrWhiteSpace(txtPassengerName.Text))
            {
                errorMessage = "Please enter a passenger name.";
                return false;
            }

            // Validate age
            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                errorMessage = "Please enter an age.";
                return false;
            }

            if (!int.TryParse(txtAge.Text, out int age) || age < 0 || age > 120)
            {
                errorMessage = "Please enter a valid age (0-120).";
                return false;
            }

            // Validate category selection
            if (cmbCategory.SelectedIndex == -1)
            {
                errorMessage = "Please select a travel category.";
                return false;
            }

            // Validate distance
            if (string.IsNullOrWhiteSpace(txtDistance.Text))
            {
                errorMessage = "Please enter a distance.";
                return false;
            }

            if (!double.TryParse(txtDistance.Text, out double distance) || distance <= 0)
            {
                errorMessage = "Please enter a valid distance (greater than 0).";
                return false;
            }

            return true;
        }

        // Display ticket summary in the panel
        private void DisplayTicketSummary(string name, string gender, int age, string category, double distance, double finalPrice)
        {
            string summary = $"Passenger Name: {name}\n\n" +
                           $"Gender: {gender}\n\n" +
                           $"Age: {age} years\n\n" +
                           $"Travel Category: {category}\n\n" +
                           $"Distance: {distance} km\n\n" +
                           $"Final Ticket Price: R{finalPrice:F2}\n\n";

            if (age < 12)
            {
                summary += "(FREE - Passenger under 12 years)\n";
            }
            else if (gender == "Female")
            {
                summary += "(50% discount applied - Female passenger)\n";
            }

            lblSummary.Text = summary;
        }
    }
}
