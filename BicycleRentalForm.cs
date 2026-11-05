using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2App
{
    public partial class BicycleRentalForm : Form
    {
        public BicycleRentalForm()
        {
            InitializeComponent();
        }

        private void BicycleRentalForm_Load(object sender, EventArgs e)
        {
            // Initial calculation with default values (8 to 17)
            CalculateRental();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateRental();
        }

        private void CalculateRental()
        {
            int startTime = (int)numStartTime.Value;
            int endTime = (int)numEndTime.Value;

            // Input validations matching the requirements
            if (startTime < 0 || startTime > 23)
            {
                MessageBox.Show(
                    "Invalid input. Start time must be an integer between 0 and 23.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (endTime < 1 || endTime > 24)
            {
                MessageBox.Show(
                    "Invalid input. Ending time must be an integer between 1 and 24.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (endTime <= startTime)
            {
                MessageBox.Show(
                    "Error: Ending time must be strictly greater than starting time.",
                    "Time Sequence Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            // Calculation algorithm matching original problem logic
            int totalCost = 0;
            int nightHours = 0;
            int standardHours = 0;
            int peakHours = 0;

            for (int h = startTime; h < endTime; h++)
            {
                if ((h >= 0 && h < 7) || (h >= 21 && h < 24))
                {
                    totalCost += 500;   // 500 RWF per hour for 0-7 and 21-24
                    nightHours++;
                }
                else if ((h >= 7 && h < 14) || (h >= 19 && h < 21))
                {
                    totalCost += 1000;  // 1000 RWF per hour for 7-14 and 19-21
                    standardHours++;
                }
                else if (h >= 14 && h < 19)
                {
                    totalCost += 1500;  // 1500 RWF per hour for 14-19
                    peakHours++;
                }
            }

            int totalHours = endTime - startTime;

            // Display results
            lblRentalTimeSpan.Text = $"Start Time: {startTime:D2}:00   |   End Time: {endTime:D2}:00";
            lblDuration.Text = $"Total Duration: {totalHours} hour(s)";

            lblBreakdownNight.Text = $"• Night Hours (0-7, 21-24 @ 500 RWF): {nightHours} hr(s) = {nightHours * 500:N0} RWF";
            lblBreakdownStandard.Text = $"• Standard Hours (7-14, 19-21 @ 1,000 RWF): {standardHours} hr(s) = {standardHours * 1000:N0} RWF";
            lblBreakdownPeak.Text = $"• Peak Hours (14-19 @ 1,500 RWF): {peakHours} hr(s) = {peakHours * 1500:N0} RWF";

            lblTotalCost.Text = $"{totalCost:N0} RWF";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numStartTime.Value = 8;
            numEndTime.Value = 17;
            CalculateRental();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
