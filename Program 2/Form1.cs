// Colin Phelps
// Program 2
// 3/10/15
// CIS199-01
// This program allows the user to input their grade and last name and the programs outputs the earliest possible registration time.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registrationTimeBtn_Click(object sender, EventArgs e)
        {

            // Constants to hold dates
            const string SENIOR_DATE = "Wednesday, April 1";
            const string JUNIOR_DATE = "Thursday, April 2";
            const string SOPHOMORE_DATE_1 = "Friday, April 3";
            const string SOPHOMORE_DATE_2 = "Monday, April 6";
            const string FRESHMAN_DATE_1 = "Tuesday, April 7";
            const string FRESHAMN_DATE_2 = "Wednesday, April 8";

            // Constants to hold times
            const string TIME_SLOT_1 = "8:30 AM";
            const string TIME_SLOT_2 = "10:00 AM";
            const string TIME_SLOT_3 = "11:30 AM";
            const string TIME_SLOT_4 = "2:00 PM";
            const string TIME_SLOT_5 = "4:00 PM";

            string date = " "; //Declare a variable to hold the registration date.
            string time = " "; //Declare a variable to hold the registration time.
            string lastName = lastNameTextBox.Text;// Declare a variable to hold entire last name
            char letter = ' '; // Declare a variable to hold the first letter of the last name

            // Extracts the first letter of the last name from the text box and puts it in upper case
            if (string.IsNullOrEmpty(lastName))
                MessageBox.Show("Please enter a valid last name");
            else
            {
                letter = lastName[0];
                if(char.IsLetter(letter))
                {
                    letter = char.ToUpper(letter);
                }
                else
                    MessageBox.Show("Please enter a valid last name");
            }

            // Assigns the correct date to the variable "date"
            if (seniorRadioBtn.Checked)
            {
                date = SENIOR_DATE;
            }
            else if (juniorRadioBtn.Checked)
            {
                date = JUNIOR_DATE;
            }
            else if (sophomoreRadioBtn.Checked)
            {
                if (letter <= 'F' || letter >= 'T')
                    date = SOPHOMORE_DATE_1;
                else
                    date = SOPHOMORE_DATE_2;
            }
            else if (freshmanRadioBtn.Checked)
            {
                if (letter <= 'F' || letter >= 'T')
                    date = FRESHMAN_DATE_1;
                else
                    date = FRESHAMN_DATE_2;
            }

            // Assigns the correct time to the variable "time"
            if (juniorRadioBtn.Checked || seniorRadioBtn.Checked)
            {
                if (letter >= 'T')
                    time = TIME_SLOT_1;
                else if (letter >= 'P')
                    time = TIME_SLOT_5;
                else if (letter >= 'J')
                    time = TIME_SLOT_4;
                else if (letter >= 'E')
                    time = TIME_SLOT_3;
                else
                    time = TIME_SLOT_2;
            }
            else if(freshmanRadioBtn.Checked || sophomoreRadioBtn.Checked)
            {
                if ((letter >= 'T' && letter <= 'V') || (letter >= 'G' && letter <= 'I'))
                    time = TIME_SLOT_1;
                else if ((letter >= 'W' && letter <= 'Z') || (letter >= 'J' && letter <= 'L'))
                    time = TIME_SLOT_2;
                else if ((letter >= 'A' && letter <= 'B') || (letter >= 'M' && letter <= 'O'))
                    time = TIME_SLOT_3;
                else if ((letter >= 'C' && letter <= 'D') || (letter >= 'P' && letter <= 'Q'))
                    time = TIME_SLOT_4;
                else if ((letter >= 'E' && letter <= 'F') || (letter >= 'R' && letter <= 'S'))
                    time = TIME_SLOT_5;
            }

            // Assigns the text for the label to a message telling the user their registration time
            if(char.IsLetter(letter))
            {
            regTimeLabel.Text = "The earliest you can register is " + date + " at " + time + ".";
            }
            else 
            MessageBox.Show("Please enter a valid last name");

       }
    }
}
