namespace Assignment4._4
{
    partial class AccountView
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
            this.AccountInformation = new System.Windows.Forms.DataGridView();
            this.AccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckingAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SavingsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AccountInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountInformation
            // 
            this.AccountInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccountNumber,
            this.AccountName,
            this.CheckingAmount,
            this.SavingsAmount});
            this.AccountInformation.Location = new System.Drawing.Point(12, 195);
            this.AccountInformation.Name = "AccountInformation";
            this.AccountInformation.RowTemplate.Height = 25;
            this.AccountInformation.Size = new System.Drawing.Size(776, 243);
            this.AccountInformation.TabIndex = 0;
            this.AccountInformation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountInformation_CellContentClick);
            // 
            // AccountNumber
            // 
            this.AccountNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountNumber.HeaderText = "Account Number";
            this.AccountNumber.Name = "AccountNumber";
            // 
            // AccountName
            // 
            this.AccountName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccountName.HeaderText = "Account Name";
            this.AccountName.Name = "AccountName";
            // 
            // CheckingAmount
            // 
            this.CheckingAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckingAmount.HeaderText = "Checking Amount";
            this.CheckingAmount.Name = "CheckingAmount";
            // 
            // SavingsAmount
            // 
            this.SavingsAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SavingsAmount.HeaderText = "Savings Amount";
            this.SavingsAmount.Name = "SavingsAmount";
            // 
            // AccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccountInformation);
            this.Name = "AccountView";
            this.Text = "Bank Accounts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView AccountInformation;
        private DataGridViewTextBoxColumn AccountNumber;
        private DataGridViewTextBoxColumn AccountName;
        private DataGridViewTextBoxColumn CheckingAmount;
        private DataGridViewTextBoxColumn SavingsAmount;
    }
}