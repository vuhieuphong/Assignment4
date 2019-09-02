using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Name: Vu Hieu Phong
/// Student Number: 301049781
/// Last modified: July 20th 2019
/// Description: BMI calculator
/// Revision history: fixed the form closing event. completed the assignment.
/// </summary>
namespace Assignment4
{
    static class Program
    {
        public static StartForm startForm;
        public static BMICalculatorForm mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            startForm= new StartForm();
            mainForm = new BMICalculatorForm();
            Application.Run(startForm);
        }
    }
}
