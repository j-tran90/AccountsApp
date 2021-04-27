using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class frmAccount : Form
    {
        //private List<Account> account = new List<Account>();
        private SortedDictionary<int, Account> accounts = new SortedDictionary<int, Account>();
        public frmAccount()
        {
            InitializeComponent();
        }

        private void rbtnChequing_Click(object sender, EventArgs e)
        {
            grbVisa.Enabled = false;
            grbChecking.Enabled = true;
        }

        private void rbtnVisa_Click(object sender, EventArgs e)
        {
            grbVisa.Enabled = true;
            grbChecking.Enabled = false;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtnChecking.Checked)
                {
                    CheckingAccount newChecking = new CheckingAccount(int.Parse(txtAccNumber.Text), txtName.Text, double.Parse(txtBalance.Text), double.Parse(txtWithdrawLimit.Text));

                    accounts.Add(accounts., newChecking);
                }
                else
                {
                    VisaAccount newVisa = new VisaAccount(int.Parse(txtAccNumber.Text), txtName.Text, double.Parse(txtBalance.Text), double.Parse(txtInterestRate.Text));

                    accounts.Add(newVisa);
                }
                //clear
                txtName.Text = "";
                txtAccNumber.Text = "";
                txtBalance.Text = "";
                txtInterestRate.Text = "";
                txtWithdrawLimit.Text = "";

                //reset to Checking after clear
                rbtnChecking.Checked = true;
                rbtnVisa.Checked = false;

                MessageBox.Show($"Total number of accounts created: {accounts.Count}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Entry!");
            }
        }

        //search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int accNumber = int.Parse(txtSearch.Text);

            Account clientSearch = accounts[accNumber];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear
            txtName.Text = "";
            txtAccNumber.Text = "";
            txtBalance.Text = "";
            txtInterestRate.Text = "";
            txtWithdrawLimit.Text = "";

            //reset to Checking after clear
            rbtnChecking.Checked = true;
            rbtnVisa.Checked = false;
        }
    }
}
