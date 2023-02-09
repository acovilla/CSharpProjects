using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Transactions;
using System.IO;

namespace Mad4Road
{
    public partial class Form1 : Form
    {
        //String constant holding the password
        const string PASSWORD = "2Fast4U#";
        //Periods constants
        const int PERIOD = 12;
        const int PERIOD3 = 12*3;
        const int PERIOD5 = 12*5;
        const int PERIOD7 = 12*7;
        //Low loan interest level constants
        const decimal BELOW1 = 0.06m;
        const decimal BELOW3 = 0.065m;
        const decimal BELOW5 = 0.07m;
        const decimal BELOW7 = 0.075m;
        //Medium loan interest level constant
        const decimal MEDIUM1 = 0.08m;
        const decimal MEDIUM3 = 0.085m;
        const decimal MEDIUM5 = 0.09m;
        const decimal MEDIUM7 = 0.095m;
        //High loan interest level constants
        const decimal HIGH1 = 0.085m;
        const decimal HIGH3 = 0.0875m;
        const decimal HIGH5 = 0.091m;
        const decimal HIGH7 = 0.0925m;
        //Field decimal initializing r
        decimal rBelow1 = (BELOW1 / PERIOD);
        decimal rBelow3 = (BELOW3 / PERIOD);
        decimal rBelow5 = (BELOW5 / PERIOD);
        decimal rBelow7 = (BELOW7 / PERIOD);
        decimal rMedium1 = (MEDIUM1 / PERIOD);
        decimal rMedium3 = (MEDIUM3 / PERIOD);
        decimal rMedium5 = (MEDIUM5 / PERIOD);
        decimal rMedium7 = (MEDIUM7 / PERIOD);
        decimal rHigh1 = (HIGH1 / PERIOD);
        decimal rHigh3 = (HIGH3 / PERIOD);
        decimal rHigh5 = (HIGH5 / PERIOD);
        decimal rHigh7 = (HIGH7 / PERIOD);
        //Field Int initializing the password attempts
        int attempts = 0;
        //Field int initializing loan amount
        int loanAmount = 0;
        //Field variables of loan properties captured
        int rateIndex = 0;
        string term;
        string interest;
        decimal selectedMonthlyRepayment;
        decimal selectedTotalCost;
        decimal selectedTotalInterest;
        int termInMonths;
        DialogResult result;



        public Form1()
        {
            InitializeComponent();
        }
        //With this event handler, we locate the Log In Group Box in the same location
        //as the Log In Group Box. Also we indicate initial form size.
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(561, 505);
            logInTextBox.Focus();
            loanGroupBox.Location = logInGroupBox.Location;
        }

        //With this event handler we close the application
        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //This method displays a warning if the password is not correct
        //and closes the application if the user introduces the password wrong 2 times
        private void passwordChecker()
        {
            attempts++;
            if (attempts < 2)
            {
                MessageBox.Show("Please, try again. You have one extra attempt", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logInTextBox.Clear();
                logInTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Your access to the application was denied. Shutting down", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        //This returning value method enables elevating to a decimal power
        private decimal decimalPow(decimal a , decimal b)
        {
            double A = (double) a;
            double B = (double) b;
            return (decimal)Math.Pow(A,B);
        }
        //This method will calculate the interest information to display on the Rate Schedule
        //for amounts of less than 40.000 
        private void interestInformationBelow(int loanAmount)
        {
           
            decimal monthlyRepayment1 = loanAmount * rBelow1 * (decimalPow(1 + rBelow1, PERIOD) / (decimalPow(1 + rBelow1, PERIOD) - 1));
            decimal monthlyRepayment3 = loanAmount * rBelow3 * (decimalPow(1 + rBelow3, PERIOD3) / (decimalPow(1 + rBelow3, PERIOD3) - 1));
            decimal monthlyRepayment5 = loanAmount * rBelow5 * (decimalPow(1 + rBelow5, PERIOD5) / (decimalPow(1 + rBelow5, PERIOD5) - 1));
            decimal monthlyRepayment7 = loanAmount * rBelow7 * (decimalPow(1 + rBelow7, PERIOD7) / (decimalPow(1 + rBelow7, PERIOD7) - 1));
            decimal totalCost1 = (monthlyRepayment1 * PERIOD);
            decimal totalCost3 = (monthlyRepayment3 * PERIOD3);
            decimal totalCost5 = (monthlyRepayment5 * PERIOD5);
            decimal totalCost7 = (monthlyRepayment7 * PERIOD7);
            decimal totalInterest1 = totalCost1 - loanAmount;
            decimal totalInterest3 = totalCost3 - loanAmount;
            decimal totalInterest5 = totalCost5 - loanAmount;
            decimal totalInterest7 = totalCost7 - loanAmount;
            rateScheduleListBox.Items.Add("6.00%  " + monthlyRepayment1.ToString("C").PadRight(15) + totalInterest1.ToString("C").PadRight(15) + totalCost1.ToString("C"));
            rateScheduleListBox.Items.Add("6.50%  " + monthlyRepayment3.ToString("C").PadRight(15) + totalInterest3.ToString("C").PadRight(15) + totalCost3.ToString("C"));
            rateScheduleListBox.Items.Add("7.00%  " + monthlyRepayment5.ToString("C").PadRight(15) + totalInterest5.ToString("C").PadRight(15) + totalCost5.ToString("C"));
            rateScheduleListBox.Items.Add("7.50%  " + monthlyRepayment7.ToString("C").PadRight(15) + totalInterest7.ToString("C").PadRight(15) + totalCost7.ToString("C"));
        }

        //This method will calculate the interest information to display on the Rate Schedule
        //for amounts between 40.000 and 80.000
        private void interestInformationMedium(int loanAmount)
        {
           
            decimal monthlyRepayment1 = loanAmount * rMedium1 * (decimalPow(1 + rMedium1, PERIOD) / (decimalPow(1 + rMedium1, PERIOD) - 1));
            decimal monthlyRepayment3 = loanAmount * rMedium3 * (decimalPow(1 + rMedium3, PERIOD3) / (decimalPow(1 + rMedium3, PERIOD3) - 1));
            decimal monthlyRepayment5 = loanAmount * rMedium5 * (decimalPow(1 + rMedium5, PERIOD5) / (decimalPow(1 + rMedium5, PERIOD5) - 1));
            decimal monthlyRepayment7 = loanAmount * rMedium7 * (decimalPow(1 + rMedium7, PERIOD7) / (decimalPow(1 + rMedium7, PERIOD7) - 1));
            decimal totalCost1 = (monthlyRepayment1 * PERIOD);
            decimal totalCost3 = (monthlyRepayment3 * PERIOD3);
            decimal totalCost5 = (monthlyRepayment5 * PERIOD5);
            decimal totalCost7 = (monthlyRepayment7 * PERIOD7);
            decimal totalInterest1 = totalCost1 - loanAmount;
            decimal totalInterest3 = totalCost3 - loanAmount;
            decimal totalInterest5 = totalCost5 - loanAmount;
            decimal totalInterest7 = totalCost7 - loanAmount;
            rateScheduleListBox.Items.Add("8.00%  " + monthlyRepayment1.ToString("C").PadRight(15) + totalInterest1.ToString("C").PadRight(15) + totalCost1.ToString("C"));
            rateScheduleListBox.Items.Add("8.50%  " + monthlyRepayment3.ToString("C").PadRight(15) + totalInterest3.ToString("C").PadRight(15) + totalCost3.ToString("C"));
            rateScheduleListBox.Items.Add("9.00%  " + monthlyRepayment5.ToString("C").PadRight(15) + totalInterest5.ToString("C").PadRight(15) + totalCost5.ToString("C"));
            rateScheduleListBox.Items.Add("9.50%  " + monthlyRepayment7.ToString("C").PadRight(15) + totalInterest7.ToString("C").PadRight(15) + totalCost7.ToString("C"));
        }

        //This method will calculate the interest information to display on the Rate Schedule
        //for amounts above 80.000
        private void interestInformationHigh(int loanAmount)
        {
     
            decimal monthlyRepayment1 = loanAmount * rHigh1 * (decimalPow(1 + rHigh1, PERIOD) / (decimalPow(1 + rHigh1, PERIOD) - 1));
            decimal monthlyRepayment3 = loanAmount * rHigh3 * (decimalPow(1 + rHigh3, PERIOD3) / (decimalPow(1 + rHigh3, PERIOD3) - 1));
            decimal monthlyRepayment5 = loanAmount * rHigh5 * (decimalPow(1 + rHigh5, PERIOD5) / (decimalPow(1 + rHigh5, PERIOD5) - 1));
            decimal monthlyRepayment7 = loanAmount * rHigh7 * (decimalPow(1 + rHigh7, PERIOD7) / (decimalPow(1 + rHigh7, PERIOD7) - 1));
            decimal totalCost1 = (monthlyRepayment1 * PERIOD);
            decimal totalCost3 = (monthlyRepayment3 * PERIOD3);
            decimal totalCost5 = (monthlyRepayment5 * PERIOD5);
            decimal totalCost7 = (monthlyRepayment7 * PERIOD7);
            decimal totalInterest1 = totalCost1 - loanAmount;
            decimal totalInterest3 = totalCost3 - loanAmount;
            decimal totalInterest5 = totalCost5 - loanAmount;
            decimal totalInterest7 = totalCost7 - loanAmount;
            rateScheduleListBox.Items.Add("8.50%  " + monthlyRepayment1.ToString("C").PadRight(15) + totalInterest1.ToString("C").PadRight(15) + totalCost1.ToString("C"));
            rateScheduleListBox.Items.Add("8.75%  " + monthlyRepayment3.ToString("C").PadRight(15) + totalInterest3.ToString("C").PadRight(15) + totalCost3.ToString("C"));
            rateScheduleListBox.Items.Add("9.10%  " + monthlyRepayment5.ToString("C").PadRight(15) + totalInterest5.ToString("C").PadRight(15) + totalCost5.ToString("C"));
            rateScheduleListBox.Items.Add("9.25%  " + monthlyRepayment7.ToString("C").PadRight(15) + totalInterest7.ToString("C").PadRight(15) + totalCost7.ToString("C"));
        }
        //This event handler concedes access to the application
        private void logInButton_Click(object sender, EventArgs e)
        {
            if (logInTextBox.Text == PASSWORD)
            {
                logInGroupBox.Visible = false;
                loanGroupBox.Visible = true;
                loanAmountTextBox.Focus();
            }
            else 
            {
                passwordChecker();
            }
            
        }
        //This returning value method Creates a random number as a transaction id 

        private string transactionId()
        {
            Random id = new Random();
            int fiveDigitNumber = id.Next(10000);
            string transactionId = fiveDigitNumber.ToString("D5");
            return transactionId;
        }
       
        //This event handler displays information in the rate schedule
        private void displayButton_Click(object sender, EventArgs e)
        {
            //Error handling introduction af a letter instead of a number
            if (int.TryParse(loanAmountTextBox.Text, out loanAmount))
            {
                //Error handling introduction a number lower than 1
                if (loanAmount > 0)
                {
                    //Change the form size from 561, 505 to 1291,802
                    this.Size = new Size(1292, 802);
                    //Visibilize the group Boxes needed to display the correct information
                    loanGroupBox.Visible = false;
                    logoPictureBox1.Visible = false;
                    rateScheduleGroupBox.Visible = true;
                    summaryGroupBox.Visible = true;
                    searchGroupBox.Visible = true;
                    //Position groupbox in the correct location
                    rateScheduleGroupBox.Location = logInGroupBox.Location;
                    //Displaying the amount borrowed on the group box
                    displayAmountToBorrowLabel.Text = loanAmount.ToString("C");
                    //Saves unique ID in a textbox
                    transactionNumberTextBox.Text = transactionId();
                    //Displaying the information for loans 
                    if (loanAmount < 40000)
                    {
                        interestInformationBelow(loanAmount);           
                    }
                    else if (loanAmount >= 40000 && loanAmount <= 80000)
                    {
                        interestInformationMedium(loanAmount);
                    }
                    else if (loanAmount > 80000)
                    {
                        interestInformationHigh(loanAmount);                      
                    }
                }
                else
                {
                    MessageBox.Show("Please, introduce a number greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please, introduce a number greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //This event handler displays the transaction id and enables client form after selecting a rate
        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (rateScheduleListBox.SelectedIndex != -1)
            {
                //Enable the client groupbox to insert clients information
                clientNameTextBox.Enabled = true;
                clientPostTextBox.Enabled = true;
                clientEmailTextBox.Enabled = true;
                clientPhoneTextBox.Enabled = true;
                submitButton.Enabled = true;
                transactionNumberTextBox.Visible = true;
                proceedButton.Enabled = false;

               
            }
            else
            {
                MessageBox.Show("Please select an option from the Rate Schedule", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //This event handler will return the user to loan amout groupbox
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.Size = new Size(561, 505);
            rateScheduleListBox.Items.Clear();
            loanGroupBox.Visible = true;
            logoPictureBox1.Visible = true;
            rateScheduleGroupBox.Visible = false;
            clientNameTextBox.Enabled = false;
            clientEmailTextBox.Enabled = false;
            clientPhoneTextBox.Enabled = false;
            clientPostTextBox.Enabled = false;
            summaryGroupBox.Visible = false;
            searchGroupBox.Visible = false;
            clientEmailTextBox.Clear();
            clientNameTextBox.Clear();
            clientPhoneTextBox.Clear();
            clientPostTextBox.Clear();
            loanAmountTextBox.Clear();
            transactionNumberTextBox.Clear();
            transactionNumberTextBox.Visible = false;
            proceedButton.Enabled = true;


        }
        //This method saves the selected term below 40000 into field variables to manipulate and display for confirmation
        private void selectedBelowInformation()
        {
           
            rateIndex = rateScheduleListBox.SelectedIndex;
            {
                rateScheduleListBox.SelectedIndex = 0;
            }
            switch (rateIndex)
            {
                case 0: term = "1 Year"; interest = "6%"; selectedMonthlyRepayment = loanAmount * rBelow1 * (decimalPow(1 + rBelow1, PERIOD) / (decimalPow(1 + rBelow1, PERIOD) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD;
                    break;
                case 1:
                    term = "3 Years"; interest = "6.50%"; selectedMonthlyRepayment = loanAmount * rBelow3 * (decimalPow(1 + rBelow3, PERIOD3) / (decimalPow(1 + rBelow3, PERIOD3) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD3); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD3;
                    break;
                case 2:
                    term = "5 Years"; interest = "7%"; selectedMonthlyRepayment = loanAmount * rBelow5 * (decimalPow(1 + rBelow5, PERIOD5) / (decimalPow(1 + rBelow5, PERIOD5) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD5); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD5;
                    break;
                case 3:
                    term = "7 Years"; interest = "7.50%"; selectedMonthlyRepayment = loanAmount * rBelow7 * (decimalPow(1 + rBelow7, PERIOD7) / (decimalPow(1 + rBelow7, PERIOD7) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD7); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD7;
                    break;
            }
            result = MessageBox.Show("Client Name: " + clientNameTextBox.Text + "\n" + "Post Code: " + clientPostTextBox.Text + "\n" + "Phone: " + clientPhoneTextBox.Text + "\n" + "Email: " + clientEmailTextBox.Text + "\n" + "\n" + "****Transaction Information****" + "\n" + "\n" + "Selected Terms: " + term + " @ " + interest + " interest" + "\n" + "ID: " + transactionNumberTextBox.Text + "\n" + "Monthly Repayment will be: " + selectedMonthlyRepayment.ToString("C") + "\n" + "Total Interest will be: " + selectedTotalInterest.ToString("C") + "\n" + "Total Cost will be: " + selectedTotalCost.ToString("C"), "Do you wish to continue with this transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            

        }

        //This method saves the selected term between 40000 and 80000 into field variables to manipulate and display for confirmation
        private void selectedMediumInformation()
        {

            rateIndex = rateScheduleListBox.SelectedIndex;
            switch (rateIndex)
            {
                case 0:
                    term = "1 Year"; interest = "8%"; selectedMonthlyRepayment = loanAmount * rMedium1 * (decimalPow(1 + rMedium1, PERIOD) / (decimalPow(1 + rMedium1, PERIOD) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD;
                    break;
                case 1:
                    term = "3 Years"; interest = "8.50%"; selectedMonthlyRepayment = loanAmount * rMedium3 * (decimalPow(1 + rMedium3, PERIOD3) / (decimalPow(1 + rMedium3, PERIOD3) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD3); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD3;
                    break;
                case 2:
                    term = "5 Years"; interest = "9%"; selectedMonthlyRepayment = loanAmount * rMedium5 * (decimalPow(1 + rMedium5, PERIOD5) / (decimalPow(1 + rMedium5, PERIOD5) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD5); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD5;
                    break;
                case 3:
                    term = "7 Years"; interest = "9.50%"; selectedMonthlyRepayment = loanAmount * rMedium7 * (decimalPow(1 + rMedium7, PERIOD7) / (decimalPow(1 + rMedium7, PERIOD7) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD7); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD7;
                    break;
            }
            result = MessageBox.Show("Client Name: " + clientNameTextBox.Text + "\n" + "Post Code: " + clientPostTextBox.Text + "\n" + "Phone: " + clientPhoneTextBox.Text + "\n" + "Email: " + clientEmailTextBox.Text + "\n" + "\n" + "****Transaction Information****" + "\n" + "\n" + "Selected Terms: " + term + " @ " + interest + " interest" + "\n" + "ID: " + transactionNumberTextBox.Text + "\n" + "Monthly Repayment will be: " + selectedMonthlyRepayment.ToString("C") + "\n" + "Total Interest will be: " + selectedTotalInterest.ToString("C") + "\n" + "Total Cost will be: " + selectedTotalCost.ToString("C"), "Do you wish to continue with this transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

        }
        //This method saves the selected term over 80000 into field variables to manipulate and display for confirmation
        private void selectedHighInformation()
        {

            rateIndex = rateScheduleListBox.SelectedIndex;
            switch (rateIndex)
            {
                case 0:
                    term = "1 Year"; interest = "8.50%"; selectedMonthlyRepayment = loanAmount * rHigh1 * (decimalPow(1 + rHigh1, PERIOD) / (decimalPow(1 + rHigh1, PERIOD) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD;
                    break;
                case 1:
                    term = "3 Years"; interest = "8.75%"; selectedMonthlyRepayment = loanAmount * rHigh3 * (decimalPow(1 + rHigh3, PERIOD3) / (decimalPow(1 + rHigh3, PERIOD3) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD3); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD3;
                    break;
                case 2:
                    term = "5 Years"; interest = "9.10%"; selectedMonthlyRepayment = loanAmount * rHigh5 * (decimalPow(1 + rHigh5, PERIOD5) / (decimalPow(1 + rHigh5, PERIOD5) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD5); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD5;
                    break;
                case 3:
                    term = "7 Years"; interest = "9.25%"; selectedMonthlyRepayment = loanAmount * rHigh7 * (decimalPow(1 + rHigh7, PERIOD7) / (decimalPow(1 + rHigh7, PERIOD7) - 1)); selectedTotalCost = (selectedMonthlyRepayment * PERIOD7); selectedTotalInterest = selectedTotalCost - loanAmount; termInMonths = PERIOD7;
                    break;
            }
            result = MessageBox.Show("Client Name: " + clientNameTextBox.Text + "\n" + "Post Code: " + clientPostTextBox.Text + "\n" + "Phone: " + clientPhoneTextBox.Text + "\n" + "Email: " + clientEmailTextBox.Text + "\n" + "\n" + "****Transaction Information****" + "\n" + "\n" + "Selected Terms: " + term + " @ " + interest + " interest" + "\n" + "ID: " + transactionNumberTextBox.Text + "\n" + "Monthly Repayment will be: " + selectedMonthlyRepayment.ToString("C") + "\n" + "Total Interest will be: " + selectedTotalInterest.ToString("C") + "\n" + "Total Cost will be: " + selectedTotalCost.ToString("C"), "Do you wish to continue with this transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

        }


        //This event handler sends the clients information and transaction to a persistent text file
        private void submitButton_Click(object sender, EventArgs e)
        {
            //Confirms if every space is filled
            if (string.IsNullOrEmpty(clientNameTextBox.Text) || string.IsNullOrEmpty(clientEmailTextBox.Text) || string.IsNullOrEmpty(clientPhoneTextBox.Text) || string.IsNullOrEmpty(clientPostTextBox.Text))
            {
                MessageBox.Show("Please, fill client's information completely", "Incomplete Client Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!clientEmailTextBox.Text.Contains("@"))
            {
                MessageBox.Show("Please, insert a valid email", "Incomplete Client Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //Writes information into the file depending on the amount. Every transaction begins with an empty line to manipulate calculations better
            else
            {
                if (loanAmount < 40000)
                {
                    selectedBelowInformation();
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            StreamWriter outputFile;
                            outputFile = File.AppendText("Transactions.txt");
                            outputFile.WriteLine(" ");
                            outputFile.WriteLine(transactionNumberTextBox.Text);
                            outputFile.WriteLine(clientEmailTextBox.Text);
                            outputFile.WriteLine(clientNameTextBox.Text);
                            outputFile.WriteLine(clientPostTextBox.Text);
                            outputFile.WriteLine(clientPhoneTextBox.Text);
                            outputFile.WriteLine(loanAmount);
                            outputFile.WriteLine(selectedMonthlyRepayment);
                            outputFile.WriteLine(selectedTotalInterest);
                            outputFile.WriteLine(selectedTotalCost);
                            outputFile.WriteLine(termInMonths);
                            outputFile.Close();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error introducing clients data into the system");
                        }
                    }
                    else
                    {
                        proceedButton.Enabled = true;

                    }

                }
                else if (loanAmount >= 40000 && loanAmount <= 80000)
                {
                    selectedMediumInformation();
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            StreamWriter outputFile;
                            outputFile = File.AppendText("Transactions.txt");
                            outputFile.WriteLine(" ");
                            outputFile.WriteLine(transactionNumberTextBox.Text);
                            outputFile.WriteLine(clientEmailTextBox.Text);
                            outputFile.WriteLine(clientNameTextBox.Text);
                            outputFile.WriteLine(clientPostTextBox.Text);
                            outputFile.WriteLine(clientPhoneTextBox.Text);
                            outputFile.WriteLine(loanAmount);
                            outputFile.WriteLine(selectedMonthlyRepayment);
                            outputFile.WriteLine(selectedTotalInterest);
                            outputFile.WriteLine(selectedTotalCost);
                            outputFile.WriteLine(termInMonths);
                            outputFile.Close();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error introducing clients data into the system");
                        }

                    }
                    else
                    {
                        proceedButton.Enabled = true;

                    }

                }
                else
                {
                    selectedHighInformation();
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            StreamWriter outputFile;
                            outputFile = File.AppendText("Transactions.txt");
                            outputFile.WriteLine(" ");
                            outputFile.WriteLine(transactionNumberTextBox.Text);
                            outputFile.WriteLine(clientEmailTextBox.Text);
                            outputFile.WriteLine(clientNameTextBox.Text);
                            outputFile.WriteLine(clientPostTextBox.Text);
                            outputFile.WriteLine(clientPhoneTextBox.Text);
                            outputFile.WriteLine(loanAmount);
                            outputFile.WriteLine(selectedMonthlyRepayment);
                            outputFile.WriteLine(selectedTotalInterest);
                            outputFile.WriteLine(selectedTotalCost);
                            outputFile.WriteLine(termInMonths);
                            outputFile.Close();

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error introducing clients data into the system","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        proceedButton.Enabled = true;

                    }

                }

            }
           
        }
        //This method displays the summary information in the listbox
        private void summaryDisplayButton_Click(object sender, EventArgs e)
        {
            summaryListBox.Items.Clear();
            totalAmountReader();
            totalInterestAccrued();
            averageAmountBorrowed();
            averageDurationLoan();
        }

        //This method reads total loans in transactions
        private void totalAmountReader()
        {     
            int amount = 0;
            int amountSum = 0;
            using (StreamReader reader = new StreamReader("Transactions.txt"))
            try
            {
                    //While the information is before the end of the text, this algorithm will search for the desired line controled
                    //by the empty line separation
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        if (line.StartsWith(" "))
                        {
                            for (int i = 0; i < 5; i++)
                            {
                               reader.ReadLine();
                            }
                            amount = int.Parse(reader.ReadLine());
                            amountSum = amountSum + amount;

                        }

                    }
                    reader.Close();
                    summaryListBox.Items.Add("Total transactions: " + amountSum.ToString("C"));


                }
                catch (Exception)
            {
                    MessageBox.Show("Error reading the transaction data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
        //This method reads total interest accured
        private void totalInterestAccrued()
        {
            decimal amount = 0m;
            decimal amountSum = 0m;
            using (StreamReader reader = new StreamReader("Transactions.txt"))
                //While the information is before the end of the text, this algorithm will search for the desired line controled
                //by the empty line separation
                try
                {

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        if (line.StartsWith(" "))
                        {
                            for (int i = 0; i < 7; i++)
                            {
                                reader.ReadLine();
                            }
                            amount = decimal.Parse(reader.ReadLine());
                            amountSum = amountSum + amount;

                        }

                    }
                    reader.Close();
                    summaryListBox.Items.Add("Total interest accrued: " + amountSum.ToString("C"));


                }
                catch (Exception)
                {
                    MessageBox.Show("Error reading the transaction data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
        //This method reads total amount borrowed and calculates average
        private void averageAmountBorrowed()
        {
            decimal amount = 0;
            decimal amountSum = 0;
            int averager = 0;
            decimal avgBorrowed = 0m;
            using (StreamReader reader = new StreamReader("Transactions.txt"))
                //While the information is before the end of the text, this algorithm will search for the desired line controled
                //by the empty line separation. Every empty line is a new transaction to facilitate calculation
                try
                {
                   
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();


                        if (line.StartsWith(" "))
                        {
                            averager++;
                            for (int i = 0; i < 5; i++)
                            {
                                reader.ReadLine();
                            }
                            amount = decimal.Parse(reader.ReadLine());
                            amountSum = amountSum + amount;
                            avgBorrowed = amountSum / averager;
                        

                        }

                    }
                    reader.Close();
                    summaryListBox.Items.Add("Average amount borrowed: " + avgBorrowed.ToString("C"));


                }
                catch (Exception)
                {
                    MessageBox.Show("Error reading the transaction data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
        //This method reads total duration of every transaction and calculates average
        private void averageDurationLoan()
        {
            decimal amount = 0;
            decimal amountSum = 0;
            int averager = 0;
            decimal avgDuration = 0m;
            using (StreamReader reader = new StreamReader("Transactions.txt"))

                //While the information is before the end of the text, this algorithm will search for the desired line controled
                //by the empty line separation. Every empty line is a new transaction to facilitate calculation
                try
                {

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();


                        if (line.StartsWith(" "))
                        {
                            averager++;
                            for (int i = 0; i < 9; i++)
                            {
                                reader.ReadLine();
                            }
                            amount = decimal.Parse(reader.ReadLine());
                            amountSum = amountSum + amount;
                            avgDuration = amountSum / averager;


                        }

                    }
                    reader.Close();
                    summaryListBox.Items.Add("Average duration of a loan: " + avgDuration.ToString());


                }
                catch (Exception)
                {
                    MessageBox.Show("Error reading the transaction data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
        //This method clears the Summary listbox
        private void summaryClearButton_Click(object sender, EventArgs e)
        {
            summaryListBox.Items.Clear();
        }

        //This method lets the user search transaction by ID
        private void searchByID()
        {
            searchListBox.Items.Clear();
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("Please, insert an ID or Email to search", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else

            {

                string clmail;
                string clname;
                string clpost;
                string clphone;
                decimal loanam;
                decimal repay;
                decimal inter;
                decimal cos;
                string ter;

                using (StreamReader reader = new StreamReader("Transactions.txt"))

                    try
                    {

                        while (!reader.EndOfStream)
                        {

                            string id = reader.ReadLine();


                            if (id.StartsWith(searchTextBox.Text))
                            {

                                clmail = reader.ReadLine();
                                clname = reader.ReadLine();
                                clpost = reader.ReadLine();
                                clphone = reader.ReadLine();
                                loanam = decimal.Parse(reader.ReadLine());
                                repay = decimal.Parse(reader.ReadLine());
                                inter = decimal.Parse(reader.ReadLine());
                                cos = decimal.Parse(reader.ReadLine());
                                ter = reader.ReadLine();

                                searchListBox.Items.Add("Transaction ID: " + id);
                                searchListBox.Items.Add("Name: " + clname);
                                searchListBox.Items.Add("Email: " + clmail);
                                searchListBox.Items.Add("Postal Code: " + clpost);
                                searchListBox.Items.Add("Phone: " + clphone);
                                searchListBox.Items.Add("Loan Amount: " + loanam.ToString("C"));
                                searchListBox.Items.Add("Monthly Repayment: " + repay.ToString("C"));
                                searchListBox.Items.Add("Interest Accrued: " + inter.ToString("C"));
                                searchListBox.Items.Add("Total Cost " + cos.ToString("C"));
                                searchListBox.Items.Add("Terms: " + ter);

                            }
                        }
                        reader.Close();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error reading the transaction data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
            }

        }
        //This method lets the user search multiple transactions by Email
        private void searchByEmail()
        {
            searchListBox.Items.Clear();
            if (searchTextBox.Text == "")
            {
                MessageBox.Show("Please, insert an ID or Email to search", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else

            {
                string id;
                string clmail;
                string clname;
                string clpost;
                string clphone;
                decimal loanam;
                decimal repay;
                decimal inter;
                decimal cos;
                string ter;

                using (StreamReader reader = new StreamReader("Transactions.txt"))

                    try
                    {

                        while (!reader.EndOfStream)
                        {
                            string blank = reader.ReadLine();
                            id = reader.ReadLine();
                            clmail = reader.ReadLine();
                            clname = reader.ReadLine();
                            clpost = reader.ReadLine();
                            clphone = reader.ReadLine();
                            loanam = decimal.Parse(reader.ReadLine());
                            repay = decimal.Parse(reader.ReadLine());
                            inter = decimal.Parse(reader.ReadLine());
                            cos = decimal.Parse(reader.ReadLine());
                            ter = reader.ReadLine();

                            if (clmail.StartsWith(searchTextBox.Text))
                            {

                                
                                searchListBox.Items.Add("Transaction ID: " + id);
                                searchListBox.Items.Add("Name: " + clname);
                                searchListBox.Items.Add("Email: " + clmail);
                                searchListBox.Items.Add("Postal Code: " + clpost);
                                searchListBox.Items.Add("Phone: " + clphone);
                                searchListBox.Items.Add("Loan Amount: " + loanam.ToString("C"));
                                searchListBox.Items.Add("Monthly Repayment: " + repay.ToString("C"));
                                searchListBox.Items.Add("Interest Accrued: " + inter.ToString("C"));
                                searchListBox.Items.Add("Total Cost " + cos.ToString("C"));
                                searchListBox.Items.Add("Terms: " + ter);
                                searchListBox.Items.Add(" ");


                            }
                        }
                        reader.Close();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error reading the transaction data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
            }

        }
        //With this event handler the user can search one transaction by ID
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Contains("@"))
            { 
                MessageBox.Show("To display multiple transactions, use the Email Search button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            { 
            searchByID();
            }


        }
        //This event handler lets the user search multiple transactions by email
        private void emailSearchButton_Click(object sender, EventArgs e)
        {
            if (!searchTextBox.Text.Contains("@"))
            {
                MessageBox.Show("To display one transactions, use the Transaction ID Search button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                searchByEmail();
            }

        }
        //This event handler clear the search list box
        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            searchListBox.Items.Clear();
        }

       
    }
}