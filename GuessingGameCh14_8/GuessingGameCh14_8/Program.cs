using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//Grade: 8
//Missing Requirements:
//As each guess is input, change the color to red or blue
//When a corect guess is entered, a messagebox should display 'Correct', the textbox should be disabled
namespace GuessingGameCh14_8
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
