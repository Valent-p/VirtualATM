namespace VirtualATM
{
    public partial class frmAtm : Form
    {

        private List<Account> accounts;
        private Account current_account;

        private int _state = State.NONE;
        private bool hasReceipt = false;

        public frmAtm()
        {
            InitializeComponent();
        }

        private void change_state(int new_state)
        {
            this._state = new_state;

            if (_state == State.NONE)
            {
                btnConfirm.Enabled = false;
                btnDeny.Enabled = false;
                btnBalance.Enabled = false;
                btnWithdraw.Enabled = false;
                btnWithdrawwithReceipt.Enabled = false;

                tbPin.Enabled = true;
                btnAccept.Enabled = true;

                btnClear.Enabled = true;
                btnOne.Enabled = true;
                btnTwo.Enabled = true;
                btnThree.Enabled = true;
                btnFour.Enabled = true;
                btnFive.Enabled = true;
                btnSix.Enabled = true;
                btnSeven.Enabled = true;
                btnEight.Enabled = true;
                btnNine.Enabled = true;
                btnZero.Enabled = true;

                change_state(State.ENTER_ACCOUNT_NUMBER);

                return;
            }

            if (_state == State.ENTER_ACCOUNT_NUMBER)
            {
                btnConfirm.Enabled = false;
                btnDeny.Enabled = false;
                btnBalance.Enabled = false;
                btnWithdraw.Enabled = false;
                btnWithdrawwithReceipt.Enabled = false;

                return;
            }

            if (_state == State.ENTER_ACCOUNT_PIN)
            {
                btnConfirm.Enabled = false;
                btnDeny.Enabled = false;
                btnBalance.Enabled = false;
                btnWithdraw.Enabled = false;
                btnWithdrawwithReceipt.Enabled = false;

                return;
            }

            if (_state == State.CHOOSE_SERVICE)
            {
                btnConfirm.Enabled = false;
                btnDeny.Enabled = true;
                btnBalance.Enabled = true;
                btnWithdraw.Enabled = true;
                btnWithdrawwithReceipt.Enabled = true;

                tbPin.Enabled = false;
                btnAccept.Enabled = false;
                btnClear.Enabled = false;
                btnOne.Enabled = false;
                btnTwo.Enabled = false;
                btnThree.Enabled = false;
                btnFour.Enabled = false;
                btnFive.Enabled = false;
                btnSix.Enabled = false;
                btnSeven.Enabled = false;
                btnEight.Enabled = false;
                btnNine.Enabled = false;
                btnZero.Enabled = false;

                rtbDisplay.Text = "Access granted! Choose service.";

                return;
            }

            if (_state == State.WITHDRAW)
            {
                btnConfirm.Enabled = true;
                btnDeny.Enabled = true;

                tbPin.Enabled = true;
                btnAccept.Enabled = false;

                btnClear.Enabled = true;
                btnOne.Enabled = true;
                btnTwo.Enabled = true;
                btnThree.Enabled = true;
                btnFour.Enabled = true;
                btnFive.Enabled = true;
                btnSix.Enabled = true;
                btnSeven.Enabled = true;
                btnEight.Enabled = true;
                btnNine.Enabled = true;
                btnZero.Enabled = true;

                return;
            }

            if (_state == State.CHOOSE_SERVICE)
            {
                return;
            }

        }

        private void btnOne_Click(object sentbder, EventArgs e)
        {
            tbPin.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            tbPin.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            tbPin.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            tbPin.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            tbPin.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            tbPin.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            tbPin.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            tbPin.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            tbPin.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            tbPin.Text += "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbPin.Text = string.Empty;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (_state == State.ENTER_ACCOUNT_NUMBER)
            {
                handleEnterAccount();
            }
            else if (_state == State.ENTER_ACCOUNT_PIN)
            {
                handleEnterPin();
            }
        }

        private void handleEnterPin()
        {
            string acc_pin = tbPin.Text;

            bool success = current_account.Unlock(acc_pin);

            if (!success)
            {
                rtbDisplay.Text = "Sorry, you entered wrong pin. Try again.";
                return;
            }

            change_state(State.CHOOSE_SERVICE);
        }

        private void handleEnterAccount()
        {
            string acc_num = tbPin.Text;

            Account account = null;

            foreach (var acc in accounts)
            {
                if (acc.Number == acc_num)
                {
                    account = acc;
                    break;
                }
            }


            if (account == null)
            {
                rtbDisplay.Text = ($"Error: Unknow account {acc_num}. Try again.");
                return;
            }

            current_account = account;
            change_state(State.ENTER_ACCOUNT_PIN);
            tbPin.PlaceholderText = "Enter PIN";

            tbPin.Text = "";
            rtbDisplay.Text = "Welcome customer, please enter your pin.";
        }

        private void frmAtm_Load(object sender, EventArgs e)
        {
            accounts = new List<Account>();

            accounts.Add(new Account("1234", "1000", 1000.0d));
            accounts.Add(new Account("1235", "1000", 2000.0d));
            accounts.Add(new Account("1236", "1000", 3000.0d));
            accounts.Add(new Account("1237", "1000", 4000.0d));
            accounts.Add(new Account("1238", "1000", 6000.0d));

            change_state(State.ENTER_ACCOUNT_NUMBER);
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = "      BALANCE\n\n";
            rtbDisplay.AppendText($"Currency: {current_account.Balance.ToString("C0")}");

            btnConfirm.Enabled = false;

        }

        private void btnWithdrawwithReceipt_Click(object sender, EventArgs e)
        {
            btnWithdraw_Click(sender, e);

            hasReceipt = true;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            hasReceipt = false;

            tbPin.Text = "";
            tbPin.PlaceholderText = "Enter amount";
            rtbDisplay.Text = "      WITHDRAW\n\n";
            rtbDisplay.AppendText("Enter the amount to withdraw.\n");
            change_state(State.WITHDRAW);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            

            rtbDisplay.Text = "      WITHDRAW\n\n";
            rtbDisplay.AppendText($"Trying to withdraw: {tbPin.Text}\n");
            rtbDisplay.AppendText("...\n");

            double amount;

            try
            {
                amount = Double.Parse(tbPin.Text);
                tbPin.Text = "";
                tbPin.PlaceholderText = "Confirmed!";
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);

                rtbDisplay.AppendText("Error, you must enter amount\n");
                return;
            }

            bool success = current_account.Withdraw(amount);

            if (!success)
            {
                rtbDisplay.AppendText("Transaction failed.\n");
                rtbDisplay.AppendText("Insufficient funds.\n");
                rtbDisplay.AppendText($"  Your balance is {current_account.Balance.ToString("C0")}.\n");
                return;
            }

            rtbDisplay.AppendText("Transaction successful.\n");
            rtbDisplay.AppendText($"Total amount withdrawn: {amount.ToString("C0")}\n");
            rtbDisplay.AppendText($"Current balance       : {current_account.Balance.ToString("C0")}\n");

            if (hasReceipt)
            {
                rtbDisplay.AppendText("\n\nNOTE: Please, collect your receipt.");
            }
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = "Transaction Aborted! Start again";
            tbPin.Text = "";
            tbPin.PlaceholderText = "Enter account number.";
            change_state(State.NONE);
        }

        private void rtbDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
