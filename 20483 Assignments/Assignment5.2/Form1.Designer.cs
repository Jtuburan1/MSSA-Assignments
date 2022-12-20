namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtWrkNum = new System.Windows.Forms.TextBox();
            this.lblWrkNum = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtMblNum = new System.Windows.Forms.TextBox();
            this.lblMblNum = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.personVariablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new WindowsFormsApp1.DataSet1();
            this.dgFName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMblNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgWrkNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personVariablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(713, 415);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgFName,
            this.dgLName,
            this.dgMblNum,
            this.dgWrkNum,
            this.dgAddress});
            this.dataGridView1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.personVariablesBindingSource, "FirstName", true));
            this.dataGridView1.Location = new System.Drawing.Point(12, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 146);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtWrkNum);
            this.panel1.Controls.Add(this.lblWrkNum);
            this.panel1.Controls.Add(this.txtLName);
            this.panel1.Controls.Add(this.lblLName);
            this.panel1.Controls.Add(this.txtMblNum);
            this.panel1.Controls.Add(this.lblMblNum);
            this.panel1.Controls.Add(this.txtFName);
            this.panel1.Controls.Add(this.lblFName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 192);
            this.panel1.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personVariablesBindingSource, "Address", true));
            this.txtAddress.Location = new System.Drawing.Point(101, 123);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(228, 66);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // txtWrkNum
            // 
            this.txtWrkNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personVariablesBindingSource, "WorkNumber", true));
            this.txtWrkNum.Location = new System.Drawing.Point(101, 94);
            this.txtWrkNum.Name = "txtWrkNum";
            this.txtWrkNum.Size = new System.Drawing.Size(139, 20);
            this.txtWrkNum.TabIndex = 7;
            this.txtWrkNum.TextChanged += new System.EventHandler(this.txtWrkNum_TextChanged);
            // 
            // lblWrkNum
            // 
            this.lblWrkNum.AutoSize = true;
            this.lblWrkNum.Location = new System.Drawing.Point(17, 97);
            this.lblWrkNum.Name = "lblWrkNum";
            this.lblWrkNum.Size = new System.Drawing.Size(73, 13);
            this.lblWrkNum.TabIndex = 6;
            this.lblWrkNum.Text = "Work Number";
            // 
            // txtLName
            // 
            this.txtLName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personVariablesBindingSource, "LastName", true));
            this.txtLName.Location = new System.Drawing.Point(101, 42);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(139, 20);
            this.txtLName.TabIndex = 3;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(17, 45);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(58, 13);
            this.lblLName.TabIndex = 4;
            this.lblLName.Text = "Last Name";
            // 
            // txtMblNum
            // 
            this.txtMblNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personVariablesBindingSource, "MobileNumber", true));
            this.txtMblNum.Location = new System.Drawing.Point(101, 68);
            this.txtMblNum.Name = "txtMblNum";
            this.txtMblNum.Size = new System.Drawing.Size(139, 20);
            this.txtMblNum.TabIndex = 5;
            this.txtMblNum.TextChanged += new System.EventHandler(this.txtMblNum_TextChanged);
            // 
            // lblMblNum
            // 
            this.lblMblNum.AutoSize = true;
            this.lblMblNum.Location = new System.Drawing.Point(17, 71);
            this.lblMblNum.Name = "lblMblNum";
            this.lblMblNum.Size = new System.Drawing.Size(78, 13);
            this.lblMblNum.TabIndex = 2;
            this.lblMblNum.Text = "Mobile Number";
            // 
            // txtFName
            // 
            this.txtFName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personVariablesBindingSource, "FirstName", true));
            this.txtFName.Location = new System.Drawing.Point(101, 16);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(139, 20);
            this.txtFName.TabIndex = 1;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(17, 19);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(57, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(113, 221);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(489, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(29, 224);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(632, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(551, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(470, 415);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // personVariablesBindingSource
            // 
            this.personVariablesBindingSource.DataMember = "PersonVariables";
            this.personVariablesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgFName
            // 
            this.dgFName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgFName.HeaderText = "First Name";
            this.dgFName.Name = "dgFName";
            // 
            // dgLName
            // 
            this.dgLName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgLName.HeaderText = "Last Name";
            this.dgLName.Name = "dgLName";
            // 
            // dgMblNum
            // 
            this.dgMblNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgMblNum.HeaderText = "Mobile Number";
            this.dgMblNum.Name = "dgMblNum";
            // 
            // dgWrkNum
            // 
            this.dgWrkNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgWrkNum.HeaderText = "Work Number";
            this.dgWrkNum.Name = "dgWrkNum";
            // 
            // dgAddress
            // 
            this.dgAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgAddress.HeaderText = "Address";
            this.dgAddress.Name = "dgAddress";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Name = "Form1";
            this.Text = "Address Book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personVariablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtWrkNum;
        private System.Windows.Forms.Label lblWrkNum;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtMblNum;
        private System.Windows.Forms.Label lblMblNum;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.BindingSource personVariablesBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgMblNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgWrkNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
    }
}

