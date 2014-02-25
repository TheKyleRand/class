using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date_String_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string output;

            output = dayOfTheWeekTextBox.Text + ", " +
                monthTextBox.Text + " " +
                dayOfTheMonthTextBox.Text + ", " +
                yearTextBox.Text;

            dateOutputLabel.Text = output;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfTheWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfTheMonthTextBox.Text = "";
            yearTextBox.Text = "";

            dateOutputLabel.Text = "";
        }
    }
}
