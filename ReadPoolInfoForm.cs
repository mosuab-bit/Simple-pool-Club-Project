using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club_Project
{
    public partial class ReadPoolInfoForm : Form
    {
        public ReadPoolInfoForm()
        {
            InitializeComponent();
        }

        public delegate void DataBackEventHandler(object sender, string playerName, float hourRate);
        public event DataBackEventHandler DataBack;
        private void txtPlayerName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlayerName.Text.Trim()))
            {
                // Set the CancelEventArgs.Cancel property to true to prevent the form from being submitted
                e.Cancel = true;

                // Display an error message or set the TextBox's error provider
                errorProvider1.SetError(txtPlayerName, "Please fill in the input field.");

            }
            else
            {
                // Clear the error message
                errorProvider1.SetError(txtPlayerName, string.Empty);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // Cancel the KeyPress event to prevent the character from being entered
                e.Handled = true;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlayerName.Text.Trim()))
            {
                // Set the CancelEventArgs.Cancel property to true to prevent the form from being submitted
                e.Cancel = true;

                // Display an error message or set the TextBox's error provider
                errorProvider1.SetError(txtPlayerName, "Please fill in the input field.");

            }
            else
            {
                // Clear the error message
                errorProvider1.SetError(txtPlayerName, string.Empty);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some Field Is Empty Check on it to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string PlayerName = txtPlayerName.Text.Trim();
            float HourRate = Convert.ToInt32(txtHourRate.Text.Trim());
            DataBack?.Invoke(this, PlayerName, HourRate);
            this.Close();

        }
    }
}
