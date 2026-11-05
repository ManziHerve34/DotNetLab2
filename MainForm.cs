using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenBicycle_Click(object sender, EventArgs e)
        {
            this.Hide();
            BicycleRentalForm bicycleForm = new BicycleRentalForm();
            // When the user closes the bicycle form or clicks "← Main Menu", return to this form
            bicycleForm.FormClosed += (s, args) =>
            {
                if (!this.IsDisposed)
                {
                    this.Show();
                    this.BringToFront();
                }
            };
            bicycleForm.Show();
        }

        private void btnOpenMushroom_Click(object sender, EventArgs e)
        {
            this.Hide();
            MushroomIdentifierForm mushroomForm = new MushroomIdentifierForm();
            // When the user closes the mushroom form or clicks "← Main Menu", return to this form
            mushroomForm.FormClosed += (s, args) =>
            {
                if (!this.IsDisposed)
                {
                    this.Show();
                    this.BringToFront();
                }
            };
            mushroomForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
