using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// Name: Vu Hieu Phong
/// Student Number: 301049781
/// Last modified: July 18th 2019
/// Description: BMI calculator
/// Revision history: Finalized the program
namespace Assignment4
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.mainForm.Show();
            this.Hide();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}
