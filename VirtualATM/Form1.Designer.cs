namespace VirtualATM
{
    partial class frmAtm
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
            btnBalance = new Button();
            btnWithdraw = new Button();
            btnWithdrawwithReceipt = new Button();
            btnDeny = new Button();
            btnConfirm = new Button();
            tbPin = new TextBox();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnClear = new Button();
            btnZero = new Button();
            btnAccept = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            rtbDisplay = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnBalance
            // 
            btnBalance.Enabled = false;
            btnBalance.FlatStyle = FlatStyle.Flat;
            btnBalance.Location = new Point(3, 9);
            btnBalance.Margin = new Padding(3, 2, 3, 2);
            btnBalance.Name = "btnBalance";
            btnBalance.Size = new Size(102, 38);
            btnBalance.TabIndex = 0;
            btnBalance.Text = "Balance";
            btnBalance.UseVisualStyleBackColor = true;
            btnBalance.Click += btnBalance_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Enabled = false;
            btnWithdraw.FlatStyle = FlatStyle.Flat;
            btnWithdraw.Location = new Point(3, 92);
            btnWithdraw.Margin = new Padding(3, 2, 3, 2);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(102, 38);
            btnWithdraw.TabIndex = 0;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnWithdrawwithReceipt
            // 
            btnWithdrawwithReceipt.Enabled = false;
            btnWithdrawwithReceipt.FlatStyle = FlatStyle.Flat;
            btnWithdrawwithReceipt.Location = new Point(3, 50);
            btnWithdrawwithReceipt.Margin = new Padding(3, 2, 3, 2);
            btnWithdrawwithReceipt.Name = "btnWithdrawwithReceipt";
            btnWithdrawwithReceipt.Size = new Size(102, 38);
            btnWithdrawwithReceipt.TabIndex = 0;
            btnWithdrawwithReceipt.Text = "Withdraw With Receipt";
            btnWithdrawwithReceipt.UseVisualStyleBackColor = true;
            btnWithdrawwithReceipt.Click += btnWithdrawwithReceipt_Click;
            // 
            // btnDeny
            // 
            btnDeny.Enabled = false;
            btnDeny.FlatStyle = FlatStyle.Flat;
            btnDeny.Location = new Point(3, 178);
            btnDeny.Margin = new Padding(3, 2, 3, 2);
            btnDeny.Name = "btnDeny";
            btnDeny.Size = new Size(102, 38);
            btnDeny.TabIndex = 0;
            btnDeny.Text = "Deny";
            btnDeny.UseVisualStyleBackColor = true;
            btnDeny.Click += btnDeny_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Enabled = false;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Location = new Point(3, 135);
            btnConfirm.Margin = new Padding(3, 2, 3, 2);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(102, 38);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Comfirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // tbPin
            // 
            tbPin.BorderStyle = BorderStyle.FixedSingle;
            tbPin.Location = new Point(26, 14);
            tbPin.Margin = new Padding(3, 2, 3, 2);
            tbPin.Name = "tbPin";
            tbPin.PlaceholderText = "Enter Account";
            tbPin.ReadOnly = true;
            tbPin.Size = new Size(241, 23);
            tbPin.TabIndex = 1;
            // 
            // btnSeven
            // 
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Location = new Point(20, 47);
            btnSeven.Margin = new Padding(3, 2, 3, 2);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(82, 22);
            btnSeven.TabIndex = 2;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Location = new Point(108, 48);
            btnEight.Margin = new Padding(3, 2, 3, 2);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(82, 22);
            btnEight.TabIndex = 2;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnNine
            // 
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Location = new Point(195, 47);
            btnNine.Margin = new Padding(3, 2, 3, 2);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(82, 22);
            btnNine.TabIndex = 2;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnFour
            // 
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Location = new Point(20, 75);
            btnFour.Margin = new Padding(3, 2, 3, 2);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(82, 22);
            btnFour.TabIndex = 2;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnFive
            // 
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Location = new Point(108, 75);
            btnFive.Margin = new Padding(3, 2, 3, 2);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(82, 22);
            btnFive.TabIndex = 2;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnSix
            // 
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Location = new Point(195, 75);
            btnSix.Margin = new Padding(3, 2, 3, 2);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(82, 22);
            btnSix.TabIndex = 2;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnOne
            // 
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Location = new Point(20, 108);
            btnOne.Margin = new Padding(3, 2, 3, 2);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(82, 22);
            btnOne.TabIndex = 2;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnTwo
            // 
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Location = new Point(108, 108);
            btnTwo.Margin = new Padding(3, 2, 3, 2);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(82, 22);
            btnTwo.TabIndex = 2;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnThree
            // 
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Location = new Point(195, 108);
            btnThree.Margin = new Padding(3, 2, 3, 2);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(82, 22);
            btnThree.TabIndex = 2;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(20, 145);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 22);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnZero
            // 
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Location = new Point(108, 145);
            btnZero.Margin = new Padding(3, 2, 3, 2);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(82, 22);
            btnZero.TabIndex = 2;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnAccept
            // 
            btnAccept.FlatStyle = FlatStyle.Flat;
            btnAccept.Location = new Point(195, 145);
            btnAccept.Margin = new Padding(3, 2, 3, 2);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(82, 22);
            btnAccept.TabIndex = 2;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAccept);
            panel1.Controls.Add(tbPin);
            panel1.Controls.Add(btnOne);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnSeven);
            panel1.Controls.Add(btnZero);
            panel1.Controls.Add(btnTwo);
            panel1.Controls.Add(btnThree);
            panel1.Controls.Add(btnFive);
            panel1.Controls.Add(btnNine);
            panel1.Controls.Add(btnEight);
            panel1.Controls.Add(btnFour);
            panel1.Controls.Add(btnSix);
            panel1.Location = new Point(379, 24);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 222);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(rtbDisplay);
            panel2.Controls.Add(btnWithdraw);
            panel2.Controls.Add(btnBalance);
            panel2.Controls.Add(btnWithdrawwithReceipt);
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(btnDeny);
            panel2.Location = new Point(30, 24);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 222);
            panel2.TabIndex = 5;
            // 
            // rtbDisplay
            // 
            rtbDisplay.BorderStyle = BorderStyle.FixedSingle;
            rtbDisplay.Location = new Point(111, 9);
            rtbDisplay.Margin = new Padding(3, 2, 3, 2);
            rtbDisplay.Name = "rtbDisplay";
            rtbDisplay.ReadOnly = true;
            rtbDisplay.ScrollBars = RichTextBoxScrollBars.None;
            rtbDisplay.Size = new Size(215, 202);
            rtbDisplay.TabIndex = 4;
            rtbDisplay.Text = "Hello, enter account to use our services.";
            rtbDisplay.TextChanged += rtbDisplay_TextChanged;
            // 
            // frmAtm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAtm";
            Text = "Atm";
            Load += frmAtm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnBalance;
        private Button btnWithdraw;
        private Button btnWithdrawwithReceipt;
        private Button btnDeny;
        private Button btnConfirm;
        private TextBox tbPin;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnClear;
        private Button btnZero;
        private Button btnAccept;
        private TextBox tbDisplay;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox rtbDisplay;
    }
}
