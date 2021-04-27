
namespace AccountsApp
{
    partial class frmAccount
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.rbtnVisa = new System.Windows.Forms.RadioButton();
            this.grbChecking = new System.Windows.Forms.GroupBox();
            this.txtWithdrawLimit = new System.Windows.Forms.TextBox();
            this.grbVisa = new System.Windows.Forms.GroupBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.Label();
            this.accNumber = new System.Windows.Forms.Label();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.grbClient = new System.Windows.Forms.GroupBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.name = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbClientInfo = new System.Windows.Forms.GroupBox();
            this.grbChecking.SuspendLayout();
            this.grbVisa.SuspendLayout();
            this.grbClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 1;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(436, 370);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(192, 55);
            this.btnCreateAccount.TabIndex = 2;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // rbtnVisa
            // 
            this.rbtnVisa.AutoSize = true;
            this.rbtnVisa.Location = new System.Drawing.Point(436, 259);
            this.rbtnVisa.Name = "rbtnVisa";
            this.rbtnVisa.Size = new System.Drawing.Size(46, 19);
            this.rbtnVisa.TabIndex = 4;
            this.rbtnVisa.TabStop = true;
            this.rbtnVisa.Text = "Visa";
            this.rbtnVisa.UseVisualStyleBackColor = true;
            this.rbtnVisa.Click += new System.EventHandler(this.rbtnVisa_Click);
            // 
            // grbChecking
            // 
            this.grbChecking.Controls.Add(this.txtWithdrawLimit);
            this.grbChecking.Location = new System.Drawing.Point(436, 183);
            this.grbChecking.Name = "grbChecking";
            this.grbChecking.Size = new System.Drawing.Size(325, 65);
            this.grbChecking.TabIndex = 5;
            this.grbChecking.TabStop = false;
            this.grbChecking.Text = "Daily Withdraw Limit";
            // 
            // txtWithdrawLimit
            // 
            this.txtWithdrawLimit.Location = new System.Drawing.Point(64, 23);
            this.txtWithdrawLimit.Name = "txtWithdrawLimit";
            this.txtWithdrawLimit.Size = new System.Drawing.Size(100, 23);
            this.txtWithdrawLimit.TabIndex = 0;
            // 
            // grbVisa
            // 
            this.grbVisa.Controls.Add(this.txtInterestRate);
            this.grbVisa.Location = new System.Drawing.Point(436, 284);
            this.grbVisa.Name = "grbVisa";
            this.grbVisa.Size = new System.Drawing.Size(325, 64);
            this.grbVisa.TabIndex = 6;
            this.grbVisa.TabStop = false;
            this.grbVisa.Text = "Interest Rate";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(64, 22);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 23);
            this.txtInterestRate.TabIndex = 0;
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Location = new System.Drawing.Point(20, 62);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(54, 15);
            this.balance.TabIndex = 7;
            this.balance.Text = "Balance: ";
            // 
            // accNumber
            // 
            this.accNumber.AutoSize = true;
            this.accNumber.Location = new System.Drawing.Point(20, 91);
            this.accNumber.Name = "accNumber";
            this.accNumber.Size = new System.Drawing.Size(105, 15);
            this.accNumber.TabIndex = 8;
            this.accNumber.Text = "Account Number: ";
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Location = new System.Drawing.Point(155, 83);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(100, 23);
            this.txtAccNumber.TabIndex = 9;
            // 
            // grbClient
            // 
            this.grbClient.Controls.Add(this.balance);
            this.grbClient.Controls.Add(this.name);
            this.grbClient.Controls.Add(this.txtName);
            this.grbClient.Controls.Add(this.txtBalance);
            this.grbClient.Controls.Add(this.txtAccNumber);
            this.grbClient.Controls.Add(this.accNumber);
            this.grbClient.Location = new System.Drawing.Point(436, 22);
            this.grbClient.Name = "grbClient";
            this.grbClient.Size = new System.Drawing.Size(325, 130);
            this.grbClient.TabIndex = 10;
            this.grbClient.TabStop = false;
            this.grbClient.Text = "Client";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(155, 54);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 23);
            this.txtBalance.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(182, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Balance: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Account Number: ";
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.Location = new System.Drawing.Point(436, 158);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(75, 19);
            this.rbtnChecking.TabIndex = 3;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.Click += new System.EventHandler(this.rbtnChequing_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(20, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 15);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(22, 39);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(79, 15);
            this.search.TabIndex = 11;
            this.search.Text = "Search Client:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(107, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(227, 23);
            this.txtSearch.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(340, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(647, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 55);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grbClientInfo
            // 
            this.grbClientInfo.Location = new System.Drawing.Point(22, 76);
            this.grbClientInfo.Name = "grbClientInfo";
            this.grbClientInfo.Size = new System.Drawing.Size(393, 349);
            this.grbClientInfo.TabIndex = 15;
            this.grbClientInfo.TabStop = false;
            this.grbClientInfo.Text = "Client Info";
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbClientInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.search);
            this.Controls.Add(this.grbVisa);
            this.Controls.Add(this.grbChecking);
            this.Controls.Add(this.rbtnVisa);
            this.Controls.Add(this.rbtnChecking);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.grbClient);
            this.Name = "frmAccount";
            this.Text = "Form1";
            this.grbChecking.ResumeLayout(false);
            this.grbChecking.PerformLayout();
            this.grbVisa.ResumeLayout(false);
            this.grbVisa.PerformLayout();
            this.grbClient.ResumeLayout(false);
            this.grbClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.RadioButton rbtnVisa;
        private System.Windows.Forms.GroupBox grbChecking;
        private System.Windows.Forms.TextBox txtWithdrawLimit;
        private System.Windows.Forms.GroupBox grbVisa;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Label accNumber;
        private System.Windows.Forms.TextBox txtAccNumber;
        private System.Windows.Forms.GroupBox grbClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grbClientInfo;
    }
}

