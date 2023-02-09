namespace Mad4Road
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logInGroupBox = new System.Windows.Forms.GroupBox();
            this.exitButton1 = new System.Windows.Forms.Button();
            this.logInButton = new System.Windows.Forms.Button();
            this.logInTextBox = new System.Windows.Forms.TextBox();
            this.loanGroupBox = new System.Windows.Forms.GroupBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.loanAmountTextBox = new System.Windows.Forms.TextBox();
            this.loanAmountLabel = new System.Windows.Forms.Label();
            this.logoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.rateScheduleGroupBox = new System.Windows.Forms.GroupBox();
            this.proceedButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rateScheduleListBox = new System.Windows.Forms.ListBox();
            this.displayAmountToBorrowLabel = new System.Windows.Forms.Label();
            this.amountToBorrowLabel = new System.Windows.Forms.Label();
            this.clientDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.transactionNumberTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.clientEmailTextBox = new System.Windows.Forms.TextBox();
            this.clientPhoneTextBox = new System.Windows.Forms.TextBox();
            this.clientPostTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.summaryClearButton = new System.Windows.Forms.Button();
            this.summaryDisplayButton = new System.Windows.Forms.Button();
            this.summaryListBox = new System.Windows.Forms.ListBox();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.emailSearchButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.logInGroupBox.SuspendLayout();
            this.loanGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox1)).BeginInit();
            this.rateScheduleGroupBox.SuspendLayout();
            this.clientDetailsGroupBox.SuspendLayout();
            this.summaryGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logInGroupBox
            // 
            this.logInGroupBox.Controls.Add(this.exitButton1);
            this.logInGroupBox.Controls.Add(this.logInButton);
            this.logInGroupBox.Controls.Add(this.logInTextBox);
            this.logInGroupBox.Location = new System.Drawing.Point(91, 51);
            this.logInGroupBox.Name = "logInGroupBox";
            this.logInGroupBox.Size = new System.Drawing.Size(370, 205);
            this.logInGroupBox.TabIndex = 0;
            this.logInGroupBox.TabStop = false;
            this.logInGroupBox.Text = "LogIn";
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(54, 134);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(112, 34);
            this.exitButton1.TabIndex = 2;
            this.exitButton1.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton1, "Exit the application");
            this.exitButton1.UseVisualStyleBackColor = true;
            this.exitButton1.Click += new System.EventHandler(this.exitButton1_Click);
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(204, 134);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(112, 34);
            this.logInButton.TabIndex = 1;
            this.logInButton.Text = "&Enter";
            this.toolTip1.SetToolTip(this.logInButton, "Go to the transaction panel");
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // logInTextBox
            // 
            this.logInTextBox.Location = new System.Drawing.Point(27, 76);
            this.logInTextBox.Name = "logInTextBox";
            this.logInTextBox.PasswordChar = '*';
            this.logInTextBox.Size = new System.Drawing.Size(315, 31);
            this.logInTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.logInTextBox, "Insert Password");
            // 
            // loanGroupBox
            // 
            this.loanGroupBox.Controls.Add(this.displayButton);
            this.loanGroupBox.Controls.Add(this.loanAmountTextBox);
            this.loanGroupBox.Controls.Add(this.loanAmountLabel);
            this.loanGroupBox.Location = new System.Drawing.Point(1245, 51);
            this.loanGroupBox.Name = "loanGroupBox";
            this.loanGroupBox.Size = new System.Drawing.Size(403, 255);
            this.loanGroupBox.TabIndex = 1;
            this.loanGroupBox.TabStop = false;
            this.loanGroupBox.Text = "Mad4Road Car Loan";
            this.loanGroupBox.Visible = false;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(103, 147);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(156, 69);
            this.displayButton.TabIndex = 2;
            this.displayButton.Text = "&Display";
            this.toolTip1.SetToolTip(this.displayButton, "Display financial information");
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // loanAmountTextBox
            // 
            this.loanAmountTextBox.Location = new System.Drawing.Point(39, 104);
            this.loanAmountTextBox.Name = "loanAmountTextBox";
            this.loanAmountTextBox.Size = new System.Drawing.Size(325, 31);
            this.loanAmountTextBox.TabIndex = 1;
            // 
            // loanAmountLabel
            // 
            this.loanAmountLabel.AutoSize = true;
            this.loanAmountLabel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loanAmountLabel.Location = new System.Drawing.Point(39, 49);
            this.loanAmountLabel.Name = "loanAmountLabel";
            this.loanAmountLabel.Size = new System.Drawing.Size(325, 27);
            this.loanAmountLabel.TabIndex = 0;
            this.loanAmountLabel.Text = "Please, insert the amount to loan:\r\n";
            // 
            // logoPictureBox1
            // 
            this.logoPictureBox1.Image = global::Mad4Road.Properties.Resources.M4M_Logo;
            this.logoPictureBox1.Location = new System.Drawing.Point(135, 307);
            this.logoPictureBox1.Name = "logoPictureBox1";
            this.logoPictureBox1.Size = new System.Drawing.Size(272, 80);
            this.logoPictureBox1.TabIndex = 3;
            this.logoPictureBox1.TabStop = false;
            // 
            // rateScheduleGroupBox
            // 
            this.rateScheduleGroupBox.Controls.Add(this.proceedButton);
            this.rateScheduleGroupBox.Controls.Add(this.clearButton);
            this.rateScheduleGroupBox.Controls.Add(this.label9);
            this.rateScheduleGroupBox.Controls.Add(this.label8);
            this.rateScheduleGroupBox.Controls.Add(this.label7);
            this.rateScheduleGroupBox.Controls.Add(this.label6);
            this.rateScheduleGroupBox.Controls.Add(this.label5);
            this.rateScheduleGroupBox.Controls.Add(this.label4);
            this.rateScheduleGroupBox.Controls.Add(this.label3);
            this.rateScheduleGroupBox.Controls.Add(this.label2);
            this.rateScheduleGroupBox.Controls.Add(this.label1);
            this.rateScheduleGroupBox.Controls.Add(this.rateScheduleListBox);
            this.rateScheduleGroupBox.Controls.Add(this.displayAmountToBorrowLabel);
            this.rateScheduleGroupBox.Controls.Add(this.amountToBorrowLabel);
            this.rateScheduleGroupBox.Location = new System.Drawing.Point(1321, 397);
            this.rateScheduleGroupBox.Name = "rateScheduleGroupBox";
            this.rateScheduleGroupBox.Size = new System.Drawing.Size(556, 282);
            this.rateScheduleGroupBox.TabIndex = 4;
            this.rateScheduleGroupBox.TabStop = false;
            this.rateScheduleGroupBox.Text = "Rate Schedule";
            this.rateScheduleGroupBox.Visible = false;
            // 
            // proceedButton
            // 
            this.proceedButton.Location = new System.Drawing.Point(280, 227);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(112, 34);
            this.proceedButton.TabIndex = 16;
            this.proceedButton.Text = "&Proceed";
            this.toolTip1.SetToolTip(this.proceedButton, "Proceed with the transaction");
            this.proceedButton.UseVisualStyleBackColor = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(147, 227);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 34);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "&Go Back";
            this.toolTip1.SetToolTip(this.clearButton, "Go back to amount panel form");
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(22, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "7 Years";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(22, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "5 Years";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(22, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "3 Years";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(22, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "1 Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(431, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 44);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total\r\nCost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(324, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total\r\nInterest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(203, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 44);
            this.label3.TabIndex = 7;
            this.label3.Text = "Monthly\r\nRepayment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(129, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interest\r\nRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Term";
            // 
            // rateScheduleListBox
            // 
            this.rateScheduleListBox.FormattingEnabled = true;
            this.rateScheduleListBox.ItemHeight = 25;
            this.rateScheduleListBox.Location = new System.Drawing.Point(129, 105);
            this.rateScheduleListBox.Name = "rateScheduleListBox";
            this.rateScheduleListBox.Size = new System.Drawing.Size(421, 104);
            this.rateScheduleListBox.TabIndex = 2;
            // 
            // displayAmountToBorrowLabel
            // 
            this.displayAmountToBorrowLabel.AutoSize = true;
            this.displayAmountToBorrowLabel.Location = new System.Drawing.Point(86, 24);
            this.displayAmountToBorrowLabel.Name = "displayAmountToBorrowLabel";
            this.displayAmountToBorrowLabel.Size = new System.Drawing.Size(0, 25);
            this.displayAmountToBorrowLabel.TabIndex = 1;
            // 
            // amountToBorrowLabel
            // 
            this.amountToBorrowLabel.AutoSize = true;
            this.amountToBorrowLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountToBorrowLabel.Location = new System.Drawing.Point(3, 27);
            this.amountToBorrowLabel.Name = "amountToBorrowLabel";
            this.amountToBorrowLabel.Size = new System.Drawing.Size(81, 22);
            this.amountToBorrowLabel.TabIndex = 0;
            this.amountToBorrowLabel.Text = "Amount: ";
            // 
            // clientDetailsGroupBox
            // 
            this.clientDetailsGroupBox.Controls.Add(this.submitButton);
            this.clientDetailsGroupBox.Controls.Add(this.transactionNumberTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.label14);
            this.clientDetailsGroupBox.Controls.Add(this.clientEmailTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.clientPhoneTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.clientPostTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.clientNameTextBox);
            this.clientDetailsGroupBox.Controls.Add(this.label13);
            this.clientDetailsGroupBox.Controls.Add(this.label12);
            this.clientDetailsGroupBox.Controls.Add(this.label11);
            this.clientDetailsGroupBox.Controls.Add(this.label10);
            this.clientDetailsGroupBox.Location = new System.Drawing.Point(724, 51);
            this.clientDetailsGroupBox.Name = "clientDetailsGroupBox";
            this.clientDetailsGroupBox.Size = new System.Drawing.Size(490, 282);
            this.clientDetailsGroupBox.TabIndex = 5;
            this.clientDetailsGroupBox.TabStop = false;
            this.clientDetailsGroupBox.Text = "Client Details";
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(163, 233);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(177, 42);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "&Submit";
            this.toolTip1.SetToolTip(this.submitButton, "Sumbit client information");
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // transactionNumberTextBox
            // 
            this.transactionNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transactionNumberTextBox.Enabled = false;
            this.transactionNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transactionNumberTextBox.Location = new System.Drawing.Point(224, 30);
            this.transactionNumberTextBox.Name = "transactionNumberTextBox";
            this.transactionNumberTextBox.Size = new System.Drawing.Size(147, 24);
            this.transactionNumberTextBox.TabIndex = 9;
            this.transactionNumberTextBox.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(15, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(191, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Transaction Number:";
            // 
            // clientEmailTextBox
            // 
            this.clientEmailTextBox.Enabled = false;
            this.clientEmailTextBox.Location = new System.Drawing.Point(147, 185);
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.Size = new System.Drawing.Size(224, 31);
            this.clientEmailTextBox.TabIndex = 7;
            // 
            // clientPhoneTextBox
            // 
            this.clientPhoneTextBox.Enabled = false;
            this.clientPhoneTextBox.Location = new System.Drawing.Point(147, 147);
            this.clientPhoneTextBox.Name = "clientPhoneTextBox";
            this.clientPhoneTextBox.Size = new System.Drawing.Size(224, 31);
            this.clientPhoneTextBox.TabIndex = 6;
            // 
            // clientPostTextBox
            // 
            this.clientPostTextBox.Enabled = false;
            this.clientPostTextBox.Location = new System.Drawing.Point(147, 110);
            this.clientPostTextBox.Name = "clientPostTextBox";
            this.clientPostTextBox.Size = new System.Drawing.Size(224, 31);
            this.clientPostTextBox.TabIndex = 5;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Enabled = false;
            this.clientNameTextBox.Location = new System.Drawing.Point(147, 73);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(224, 31);
            this.clientNameTextBox.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Email:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Phone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Post Code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Name:";
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.summaryClearButton);
            this.summaryGroupBox.Controls.Add(this.summaryDisplayButton);
            this.summaryGroupBox.Controls.Add(this.summaryListBox);
            this.summaryGroupBox.Location = new System.Drawing.Point(91, 393);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(523, 313);
            this.summaryGroupBox.TabIndex = 6;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary Information";
            this.summaryGroupBox.Visible = false;
            // 
            // summaryClearButton
            // 
            this.summaryClearButton.Location = new System.Drawing.Point(44, 263);
            this.summaryClearButton.Name = "summaryClearButton";
            this.summaryClearButton.Size = new System.Drawing.Size(158, 44);
            this.summaryClearButton.TabIndex = 2;
            this.summaryClearButton.Text = "C&lear";
            this.toolTip1.SetToolTip(this.summaryClearButton, "Clear summary information");
            this.summaryClearButton.UseVisualStyleBackColor = true;
            this.summaryClearButton.Click += new System.EventHandler(this.summaryClearButton_Click);
            // 
            // summaryDisplayButton
            // 
            this.summaryDisplayButton.Location = new System.Drawing.Point(322, 263);
            this.summaryDisplayButton.Name = "summaryDisplayButton";
            this.summaryDisplayButton.Size = new System.Drawing.Size(158, 44);
            this.summaryDisplayButton.TabIndex = 1;
            this.summaryDisplayButton.Text = "Di&splay";
            this.toolTip1.SetToolTip(this.summaryDisplayButton, "Display summary information");
            this.summaryDisplayButton.UseVisualStyleBackColor = true;
            this.summaryDisplayButton.Click += new System.EventHandler(this.summaryDisplayButton_Click);
            // 
            // summaryListBox
            // 
            this.summaryListBox.FormattingEnabled = true;
            this.summaryListBox.ItemHeight = 25;
            this.summaryListBox.Location = new System.Drawing.Point(17, 50);
            this.summaryListBox.Name = "summaryListBox";
            this.summaryListBox.Size = new System.Drawing.Size(474, 179);
            this.summaryListBox.TabIndex = 0;
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.emailSearchButton);
            this.searchGroupBox.Controls.Add(this.clearSearchButton);
            this.searchGroupBox.Controls.Add(this.label15);
            this.searchGroupBox.Controls.Add(this.searchTextBox);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.searchListBox);
            this.searchGroupBox.Location = new System.Drawing.Point(704, 393);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(510, 313);
            this.searchGroupBox.TabIndex = 7;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search Panel";
            this.searchGroupBox.Visible = false;
            // 
            // emailSearchButton
            // 
            this.emailSearchButton.Location = new System.Drawing.Point(20, 223);
            this.emailSearchButton.Name = "emailSearchButton";
            this.emailSearchButton.Size = new System.Drawing.Size(160, 34);
            this.emailSearchButton.TabIndex = 13;
            this.emailSearchButton.Text = "&Email";
            this.toolTip1.SetToolTip(this.emailSearchButton, "Search by Email");
            this.emailSearchButton.UseVisualStyleBackColor = true;
            this.emailSearchButton.Click += new System.EventHandler(this.emailSearchButton_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Location = new System.Drawing.Point(20, 263);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(160, 34);
            this.clearSearchButton.TabIndex = 12;
            this.clearSearchButton.Text = "&Clear";
            this.toolTip1.SetToolTip(this.clearSearchButton, "Clear Search");
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(6, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 84);
            this.label15.TabIndex = 11;
            this.label15.Text = "For one transaction,\r\nplease insert ID.\r\nFor multiple transactions, \r\nplease inse" +
    "rt Email.";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(6, 141);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(201, 31);
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(20, 178);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(160, 34);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "&Transaction ID";
            this.toolTip1.SetToolTip(this.searchButton, "Search by transaction ID");
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.ItemHeight = 25;
            this.searchListBox.Location = new System.Drawing.Point(213, 57);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(291, 229);
            this.searchListBox.TabIndex = 8;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 759);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.clientDetailsGroupBox);
            this.Controls.Add(this.rateScheduleGroupBox);
            this.Controls.Add(this.logoPictureBox1);
            this.Controls.Add(this.loanGroupBox);
            this.Controls.Add(this.logInGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mad4Road Product";
            this.toolTip1.SetToolTip(this, "Mad4Road Product");
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logInGroupBox.ResumeLayout(false);
            this.logInGroupBox.PerformLayout();
            this.loanGroupBox.ResumeLayout(false);
            this.loanGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox1)).EndInit();
            this.rateScheduleGroupBox.ResumeLayout(false);
            this.rateScheduleGroupBox.PerformLayout();
            this.clientDetailsGroupBox.ResumeLayout(false);
            this.clientDetailsGroupBox.PerformLayout();
            this.summaryGroupBox.ResumeLayout(false);
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox logInGroupBox;
        private Button exitButton1;
        private Button logInButton;
        private TextBox logInTextBox;
        private GroupBox loanGroupBox;
        private Button displayButton;
        private TextBox loanAmountTextBox;
        private Label loanAmountLabel;
        private PictureBox logoPictureBox1;
        private GroupBox rateScheduleGroupBox;
        private Label displayAmountToBorrowLabel;
        private Label amountToBorrowLabel;
        private Button proceedButton;
        private Button clearButton;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox rateScheduleListBox;
        private GroupBox clientDetailsGroupBox;
        private TextBox transactionNumberTextBox;
        private Label label14;
        private TextBox clientEmailTextBox;
        private TextBox clientPhoneTextBox;
        private TextBox clientPostTextBox;
        private TextBox clientNameTextBox;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button submitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox summaryGroupBox;
        private Button summaryClearButton;
        private Button summaryDisplayButton;
        private ListBox summaryListBox;
        private GroupBox searchGroupBox;
        private Button searchButton;
        private ListBox searchListBox;
        private Label label15;
        private TextBox searchTextBox;
        private Button clearSearchButton;
        private Button emailSearchButton;
        private ToolTip toolTip1;
    }
}