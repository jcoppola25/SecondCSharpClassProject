using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Programmer: Jonathan Coppola
// Project: Coppola_2
// Due Date: 10/17/2016
// Description: Individual Assignment #2

namespace Coppola_2
{
    public partial class tciOrderForm : Form
    {
        // Declaring constants and other variables to be used throughout the code 
        int Total_Courses = 0;
        decimal Total_Cost = 0.00m;
        decimal cost = 0;
        const decimal In_State_Price = 49.00m;
        const decimal Out_Of_State_Price = 99.00m;
       
        public tciOrderForm()
        {
            //setting controls to the proper launch selection and setting output labels to display proper price
            InitializeComponent();
            totalNumberOutputLabel.Text = Total_Courses.ToString();
            totalCostOutputLabel.Text = Total_Cost.ToString("c");
            begginingExcelPriceLabel.Text = In_State_Price.ToString("C");
            begginingPowerPointPriceLabel.Text = In_State_Price.ToString("C");
            begginingWordPriceLabel.Text = In_State_Price.ToString("C");
            advancedExcelPriceLabel.Text = In_State_Price.ToString("C");
            advancedPowerPointPriceLabel.Text = In_State_Price.ToString("C");
            advancedWordPriceLabel.Text = In_State_Price.ToString("C");
            cost = In_State_Price;
        }

      

        private void begginingExcelCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           // declaring variables to be used in this method
            int Total_Courses = 0;
            decimal Total_Cost = 0.00m;
          
            // starting multiple if statements to calculate running totals
             if (begginingExcelCheckBox.Checked == true)
                {
                    ++Total_Courses;
                Total_Cost = Total_Cost + cost;
                
                }
                if (beginingPowerPointCheckBox.Checked == true)
                {
                    ++Total_Courses;
                Total_Cost = Total_Cost + cost;
            }
                if (beginingWordCheckBox.Checked == true)
                {
                    ++Total_Courses;
                Total_Cost = Total_Cost + cost;
            }
                if (advancedExcelCheckBox.Checked == true)
                {
                    ++Total_Courses;
                Total_Cost = Total_Cost + cost;
            }
                if (advancedPowerPointCheckBox.Checked == true)
                {
                    ++Total_Courses;
                Total_Cost = Total_Cost + cost;
            }
                if (advancedWordCheckBox.Checked == true)
                {
                    ++Total_Courses;
                Total_Cost = Total_Cost + cost;
            }

                //taking running totals and displaying them in output labels
                totalNumberOutputLabel.Text = Total_Courses.ToString();
            totalCostOutputLabel.Text = Total_Cost.ToString("c");

            }

        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            //starting if statement to show what to display depending upon which radio button is clicked
            //also setting the price to the correct type and reseting check boxs for proper calculation of total
            if (inStateRadioButton.Checked == true)
            {
                
                begginingExcelPriceLabel.Text = In_State_Price.ToString("C");
                begginingPowerPointPriceLabel.Text = In_State_Price.ToString("C");
                begginingWordPriceLabel.Text = In_State_Price.ToString("C");
                advancedExcelPriceLabel.Text = In_State_Price.ToString("C");
                advancedPowerPointPriceLabel.Text = In_State_Price.ToString("C");
                advancedWordPriceLabel.Text = In_State_Price.ToString("C");
                cost = In_State_Price;
                beginingPowerPointCheckBox.Checked = false;
                begginingExcelCheckBox.Checked = false;
                beginingWordCheckBox.Checked = false;
                advancedExcelCheckBox.Checked = false;
                advancedPowerPointCheckBox.Checked = false;
                advancedWordCheckBox.Checked = false;
                

            }

            if (outOfStateRadioButton.Checked == true)
            {
                begginingExcelPriceLabel.Text = Out_Of_State_Price.ToString("C");
                begginingPowerPointPriceLabel.Text = Out_Of_State_Price.ToString("C");
                begginingWordPriceLabel.Text = Out_Of_State_Price.ToString("C");
                advancedExcelPriceLabel.Text = Out_Of_State_Price.ToString("C");
                advancedPowerPointPriceLabel.Text = Out_Of_State_Price.ToString("C");
                advancedWordPriceLabel.Text = Out_Of_State_Price.ToString("C");
                cost = Out_Of_State_Price;
                beginingPowerPointCheckBox.Checked = false;
                begginingExcelCheckBox.Checked = false;
                beginingWordCheckBox.Checked = false;
                advancedExcelCheckBox.Checked = false;
                advancedPowerPointCheckBox.Checked = false;
                advancedWordCheckBox.Checked = false;

            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //declaring variable to try to see if inputs are acceptable
            Total_Courses = int.Parse(totalNumberOutputLabel.Text);

            //starting if statements to see if the aount of courses selected is within the required range
            if (Total_Courses <1)
            {
                MessageBox.Show("You must order at least on course!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Total_Courses>=1 && Total_Courses <= 3)
            {
                //starting try catch method to be able to ensure all required information is input
                try
                {
                    string registration = yearComboBox.SelectedItem.ToString();
                    string term = "";
                    string Student_ID = studentIdMaskedTextBox.Text.ToString();
                    string First_Name = firstNameTextBox.Text.ToString();
                    string Last_Name = lastNameTextBox.Text.ToString();
                    string email = emailTextBox.Text.ToString();
                    string residenceStatus = "";
                    string Order_Total_Courses = totalNumberOutputLabel.Text;
                    string price = "";
                    string Order_Total_Cost = totalCostOutputLabel.Text;
                    string type = creditCardTypeBox.SelectedItem.ToString();
                    string C_C_Number = creditCardNumberTextBox.Text.ToString();
                    string C_C_Expiration = creditCardExpirationMaskedTextBox.Text.ToString();

                    //starting if statements to be able to display correct information
                    if (fallRadioButton.Checked == true)
                    {
                        term = "Fall";
                    }

                    if (springRadioButton.Checked == true)
                    {
                        term = "Spring";
                    }

                    if (summerRadioButton.Checked == true)
                    {
                        term = "Summer";
                    }

                    if (inStateRadioButton.Checked == true)
                    {
                        residenceStatus = "In State";
                        price = begginingExcelPriceLabel.Text;
                    }

                    if (outOfStateRadioButton.Checked == true)
                    {
                        residenceStatus = "Out of State";
                        price = begginingExcelPriceLabel.Text;
                    }

                    //message box displaying order information
                    MessageBox.Show("Registration Term: " + term + " " + registration + " \n" +
                                    "Student ID: " + Student_ID + "\n" +
                                    "Student Name: " + First_Name + "" + Last_Name + "\n" +
                                    "Email Adress: " + email + "\n" +
                                    "Residency Status: " + residenceStatus + "\n" +
                                    "Total Courses Purchased: " + Order_Total_Courses + "\n" +
                                    "Course Price: " + price + "\n" +
                                    "Total Order Price: " + Order_Total_Cost + "\n" +
                                    "Credit Card Type: " + type + "\n" +
                                    "Credit Card Number: " + C_C_Number + "\n" +
                                    "Credit Card Expiration: " + C_C_Expiration, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Please input all required data!");
                }
            }
            if(Total_Courses>3)
            {
                MessageBox.Show("You may only order three course per term!", "Input Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //reseting form to launch status
            studentIdMaskedTextBox.Clear();
            emailTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            creditCardExpirationMaskedTextBox.Clear();
            creditCardNumberTextBox.Clear();
            inStateRadioButton.Checked = true;
            begginingExcelCheckBox.Checked = false;
            beginingPowerPointCheckBox.Checked = false;
            beginingWordCheckBox.Checked = false;
            advancedExcelCheckBox.Checked = false;
            advancedPowerPointCheckBox.Checked = false;
            advancedWordCheckBox.Checked = false;
            yearComboBox.SelectedIndex = -1;
            creditCardTypeBox.SelectedIndex = -1;
            fallRadioButton.Checked = true;
            studentIdMaskedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //using yes no box to ensure user wants to quit
            //declaring variable to hold user selection
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you wish to quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // taking appropriate action based on what user selected
            if (selection==DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
    }


