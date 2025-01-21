namespace Bank_Account
{
	public partial class Form1 : Form
	{
		List<BankAccount> BankAccounts = new List<BankAccount>();
		public Form1()
		{
			InitializeComponent();
		}

		private void CreateAccountBtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(OwnerTxt.Text))
			{
				MessageBox.Show("Error: Owner box may not be blank!");
				return;
			}

			BankAccount bankaccount = new BankAccount(OwnerTxt.Text);
			BankAccounts.Add(bankaccount);

			RefreshGrid();
			OwnerTxt.Text = string.Empty;
		}

		private void RefreshGrid()
		{
			BankAccountsGrid.DataSource = null;
			BankAccountsGrid.DataSource = BankAccounts;
		}

		private void DepositBtn_Click(object sender, EventArgs e)
		{
			if (BankAccountsGrid.SelectedRows.Count == 1) 
			{
				BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

			
				string message = selectedBankAccount.Deposit(AmountNum.Value);
				RefreshGrid();
				AmountNum.Value = 0;
				MessageBox.Show(message);
			}
		}

		private void WidthdrawBtn_Click(object sender, EventArgs e)
		{
			if (BankAccountsGrid.SelectedRows.Count == 1)
			{
				BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

				string message = selectedBankAccount.Withdraw(AmountNum.Value);
				RefreshGrid();
				AmountNum.Value = 0;
				MessageBox.Show(message);
			}
		}
	}
}
