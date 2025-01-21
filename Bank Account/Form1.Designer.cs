namespace Bank_Account
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
			label1 = new Label();
			label2 = new Label();
			OwnerTxt = new TextBox();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			CreateAccountBtn = new Button();
			WidthdrawBtn = new Button();
			DepositBtn = new Button();
			BankAccountsGrid = new DataGridView();
			AmountNum = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
			((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(17, 30);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(72, 25);
			label1.TabIndex = 0;
			label1.Text = "Owner:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(17, 226);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(83, 25);
			label2.TabIndex = 1;
			label2.Text = "Amount:";
			// 
			// OwnerTxt
			// 
			OwnerTxt.Location = new Point(128, 30);
			OwnerTxt.Name = "OwnerTxt";
			OwnerTxt.Size = new Size(286, 33);
			OwnerTxt.TabIndex = 2;
			// 
			// CreateAccountBtn
			// 
			CreateAccountBtn.Location = new Point(128, 80);
			CreateAccountBtn.Name = "CreateAccountBtn";
			CreateAccountBtn.Size = new Size(286, 39);
			CreateAccountBtn.TabIndex = 3;
			CreateAccountBtn.Text = "Create account";
			CreateAccountBtn.UseVisualStyleBackColor = true;
			CreateAccountBtn.Click += CreateAccountBtn_Click;
			// 
			// WidthdrawBtn
			// 
			WidthdrawBtn.Location = new Point(700, 220);
			WidthdrawBtn.Name = "WidthdrawBtn";
			WidthdrawBtn.Size = new Size(230, 37);
			WidthdrawBtn.TabIndex = 4;
			WidthdrawBtn.Text = "Widthdraw";
			WidthdrawBtn.UseVisualStyleBackColor = true;
			WidthdrawBtn.Click += WidthdrawBtn_Click;
			// 
			// DepositBtn
			// 
			DepositBtn.Location = new Point(475, 220);
			DepositBtn.Name = "DepositBtn";
			DepositBtn.Size = new Size(230, 37);
			DepositBtn.TabIndex = 5;
			DepositBtn.Text = "Deposit";
			DepositBtn.UseVisualStyleBackColor = true;
			DepositBtn.Click += DepositBtn_Click;
			// 
			// BankAccountsGrid
			// 
			BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			BankAccountsGrid.Location = new Point(475, 30);
			BankAccountsGrid.Name = "BankAccountsGrid";
			BankAccountsGrid.Size = new Size(455, 175);
			BankAccountsGrid.TabIndex = 6;
			// 
			// AmountNum
			// 
			AmountNum.Location = new Point(128, 224);
			AmountNum.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
			AmountNum.Name = "AmountNum";
			AmountNum.Size = new Size(286, 33);
			AmountNum.TabIndex = 7;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(942, 268);
			Controls.Add(AmountNum);
			Controls.Add(BankAccountsGrid);
			Controls.Add(DepositBtn);
			Controls.Add(WidthdrawBtn);
			Controls.Add(CreateAccountBtn);
			Controls.Add(OwnerTxt);
			Controls.Add(label2);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			Margin = new Padding(5);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
			((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox OwnerTxt;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Button CreateAccountBtn;
		private Button WidthdrawBtn;
		private Button DepositBtn;
		private DataGridView BankAccountsGrid;
		private NumericUpDown AmountNum;
	}
}
