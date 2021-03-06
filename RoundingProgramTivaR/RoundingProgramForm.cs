﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva rait
 * Created on: 25-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Rounding Program
 * This program takes a users entered number and calculates the...
 * ...number to a certain decimal place.
*/

namespace RoundingProgramTivaR
{
    public partial class frmRoundingProgram : Form
    {
        

        public frmRoundingProgram()
        {
            InitializeComponent();
        }

        // Procedure: RoundDecimal
        // Input: userNumber, roundToNumber
        // Output: void
        // Description:
        private void RoundDecimal(ref double tmpuserNumber, int tmproundToNumber)
        {
            // Local variables
            double finalRounding;

            // Do calculations
            /*
            finalRounding = (Math.Pow(10, roundToNumber));
            answer = (userNumber * finalRounding + 0.5);
            answer = (Math.Truncate(answer));
            answer = (answer/ finalRounding);
            */

            // Do calculations
            finalRounding = (Math.Pow(10, tmproundToNumber));
            tmpuserNumber = (tmpuserNumber * finalRounding + 0.5);
            tmpuserNumber = (Math.Truncate(tmpuserNumber));
            tmpuserNumber = (tmpuserNumber / finalRounding);

            
        }

        private void btnRounding_Click(object sender, EventArgs e)
        {
            // Declare local variables
            double userNumber;
            int roundToNumber;

            // To get the numbers 
            userNumber = Convert.ToDouble(this.txtUserNumber.Text);
            roundToNumber = Convert.ToInt32(this.nudDecPlaces.Value);

            // Procedure to round the number
            RoundDecimal(ref userNumber, roundToNumber);

            MessageBox.Show("The rounded answer is: " + userNumber, "Rounding Program");

        }
    }
}
