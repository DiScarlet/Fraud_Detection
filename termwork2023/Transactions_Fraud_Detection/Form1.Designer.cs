namespace Transactions_Fraud_Detection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.modelMetricsBtn = new System.Windows.Forms.Button();
            this.trainModelBtn = new System.Windows.Forms.Button();
            this.AddTransactionBtn = new System.Windows.Forms.Button();
            this.Validate = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.userTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.credit_Card_InfoDataSet = new Transactions_Fraud_Detection.Credit_Card_InfoDataSet();
            this.user_TransactionsTableAdapter = new Transactions_Fraud_Detection.Credit_Card_InfoDataSetTableAdapters.User_TransactionsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distancefromhomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distancefromlasttransactionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratiotomedianpurchasepriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeatretailerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usedchipDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usedpinnumberDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.onlineorderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fraudDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credit_Card_InfoDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // modelMetricsBtn
            // 
            this.modelMetricsBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.modelMetricsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelMetricsBtn.Location = new System.Drawing.Point(596, 7);
            this.modelMetricsBtn.Margin = new System.Windows.Forms.Padding(2);
            this.modelMetricsBtn.MaximumSize = new System.Drawing.Size(210, 40);
            this.modelMetricsBtn.MinimumSize = new System.Drawing.Size(38, 0);
            this.modelMetricsBtn.Name = "modelMetricsBtn";
            this.modelMetricsBtn.Size = new System.Drawing.Size(134, 40);
            this.modelMetricsBtn.TabIndex = 12;
            this.modelMetricsBtn.Text = "Model Metrics";
            this.modelMetricsBtn.UseVisualStyleBackColor = true;
            this.modelMetricsBtn.Click += new System.EventHandler(this.modelMetricsBtn_Click);
            // 
            // trainModelBtn
            // 
            this.trainModelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trainModelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainModelBtn.Location = new System.Drawing.Point(318, 7);
            this.trainModelBtn.Margin = new System.Windows.Forms.Padding(2);
            this.trainModelBtn.MaximumSize = new System.Drawing.Size(210, 40);
            this.trainModelBtn.MinimumSize = new System.Drawing.Size(38, 0);
            this.trainModelBtn.Name = "trainModelBtn";
            this.trainModelBtn.Size = new System.Drawing.Size(134, 40);
            this.trainModelBtn.TabIndex = 11;
            this.trainModelBtn.Text = "Train Model";
            this.trainModelBtn.UseVisualStyleBackColor = true;
            this.trainModelBtn.Click += new System.EventHandler(this.trainModelBtn_Click);
            // 
            // AddTransactionBtn
            // 
            this.AddTransactionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddTransactionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTransactionBtn.Location = new System.Drawing.Point(141, 7);
            this.AddTransactionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddTransactionBtn.MaximumSize = new System.Drawing.Size(210, 40);
            this.AddTransactionBtn.MinimumSize = new System.Drawing.Size(38, 0);
            this.AddTransactionBtn.Name = "AddTransactionBtn";
            this.AddTransactionBtn.Size = new System.Drawing.Size(134, 40);
            this.AddTransactionBtn.TabIndex = 10;
            this.AddTransactionBtn.Text = "Insert New Transaction";
            this.AddTransactionBtn.UseVisualStyleBackColor = true;
            this.AddTransactionBtn.Click += new System.EventHandler(this.AddTransactionBtn_Click);
            // 
            // Validate
            // 
            this.Validate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Validate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validate.Location = new System.Drawing.Point(457, 7);
            this.Validate.Margin = new System.Windows.Forms.Padding(2);
            this.Validate.MaximumSize = new System.Drawing.Size(210, 40);
            this.Validate.MinimumSize = new System.Drawing.Size(38, 0);
            this.Validate.Name = "Validate";
            this.Validate.Size = new System.Drawing.Size(134, 40);
            this.Validate.TabIndex = 9;
            this.Validate.Text = "Validate";
            this.Validate.UseVisualStyleBackColor = true;
            this.Validate.Click += new System.EventHandler(this.Validate_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Enabled = false;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(768, 7);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.MaximumSize = new System.Drawing.Size(210, 40);
            this.Save.MinimumSize = new System.Drawing.Size(38, 0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(134, 40);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save Changes";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(2, 7);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.MaximumSize = new System.Drawing.Size(210, 40);
            this.Delete.MinimumSize = new System.Drawing.Size(38, 0);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(134, 40);
            this.Delete.TabIndex = 7;
            this.Delete.Text = "Delete Selected Rows";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // userTransactionsBindingSource
            // 
            this.userTransactionsBindingSource.DataMember = "User_Transactions";
            this.userTransactionsBindingSource.DataSource = this.credit_Card_InfoDataSet;
            // 
            // credit_Card_InfoDataSet
            // 
            this.credit_Card_InfoDataSet.DataSetName = "Credit_Card_InfoDataSet";
            this.credit_Card_InfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_TransactionsTableAdapter
            // 
            this.user_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.AddTransactionBtn);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.modelMetricsBtn);
            this.panel1.Controls.Add(this.trainModelBtn);
            this.panel1.Controls.Add(this.Validate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 309);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 57);
            this.panel1.TabIndex = 14;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Red;
            this.panel10.Location = new System.Drawing.Point(2, 34);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(28, 28);
            this.panel10.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Legend";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Location = new System.Drawing.Point(2, 75);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(28, 28);
            this.panel8.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fraud";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(2, 115);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(28, 28);
            this.panel11.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Legitimate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "N/D";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 165);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 110);
            this.label11.TabIndex = 22;
            this.label11.Text = "Dear User,\r\nPlease use the first column to select the transaction(s) for actions." +
    " ";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label11);
            this.panel9.Controls.Add(this.label10);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(810, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(94, 309);
            this.panel9.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 309);
            this.panel2.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionsIDDataGridViewTextBoxColumn,
            this.distancefromhomeDataGridViewTextBoxColumn,
            this.distancefromlasttransactionDataGridViewTextBoxColumn,
            this.ratiotomedianpurchasepriceDataGridViewTextBoxColumn,
            this.repeatretailerDataGridViewCheckBoxColumn,
            this.usedchipDataGridViewCheckBoxColumn,
            this.usedpinnumberDataGridViewCheckBoxColumn,
            this.onlineorderDataGridViewCheckBoxColumn,
            this.fraudDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.userTransactionsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(810, 309);
            this.dataGridView1.TabIndex = 14;
            // 
            // transactionsIDDataGridViewTextBoxColumn
            // 
            this.transactionsIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transactionsIDDataGridViewTextBoxColumn.DataPropertyName = "Transactions_ID";
            this.transactionsIDDataGridViewTextBoxColumn.HeaderText = "Transactions_ID";
            this.transactionsIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionsIDDataGridViewTextBoxColumn.Name = "transactionsIDDataGridViewTextBoxColumn";
            this.transactionsIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distancefromhomeDataGridViewTextBoxColumn
            // 
            this.distancefromhomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.distancefromhomeDataGridViewTextBoxColumn.DataPropertyName = "distance_from_home";
            this.distancefromhomeDataGridViewTextBoxColumn.HeaderText = "distance_from_home";
            this.distancefromhomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.distancefromhomeDataGridViewTextBoxColumn.Name = "distancefromhomeDataGridViewTextBoxColumn";
            // 
            // distancefromlasttransactionDataGridViewTextBoxColumn
            // 
            this.distancefromlasttransactionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.distancefromlasttransactionDataGridViewTextBoxColumn.DataPropertyName = "distance_from_last_transaction";
            this.distancefromlasttransactionDataGridViewTextBoxColumn.HeaderText = "distance_from_last_transaction";
            this.distancefromlasttransactionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.distancefromlasttransactionDataGridViewTextBoxColumn.Name = "distancefromlasttransactionDataGridViewTextBoxColumn";
            // 
            // ratiotomedianpurchasepriceDataGridViewTextBoxColumn
            // 
            this.ratiotomedianpurchasepriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ratiotomedianpurchasepriceDataGridViewTextBoxColumn.DataPropertyName = "ratio_to_median_purchase_price";
            this.ratiotomedianpurchasepriceDataGridViewTextBoxColumn.HeaderText = "ratio_to_median_purchase_price";
            this.ratiotomedianpurchasepriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratiotomedianpurchasepriceDataGridViewTextBoxColumn.Name = "ratiotomedianpurchasepriceDataGridViewTextBoxColumn";
            // 
            // repeatretailerDataGridViewCheckBoxColumn
            // 
            this.repeatretailerDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.repeatretailerDataGridViewCheckBoxColumn.DataPropertyName = "repeat_retailer";
            this.repeatretailerDataGridViewCheckBoxColumn.HeaderText = "repeat_retailer";
            this.repeatretailerDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.repeatretailerDataGridViewCheckBoxColumn.Name = "repeatretailerDataGridViewCheckBoxColumn";
            // 
            // usedchipDataGridViewCheckBoxColumn
            // 
            this.usedchipDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usedchipDataGridViewCheckBoxColumn.DataPropertyName = "used_chip";
            this.usedchipDataGridViewCheckBoxColumn.HeaderText = "used_chip";
            this.usedchipDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.usedchipDataGridViewCheckBoxColumn.Name = "usedchipDataGridViewCheckBoxColumn";
            // 
            // usedpinnumberDataGridViewCheckBoxColumn
            // 
            this.usedpinnumberDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usedpinnumberDataGridViewCheckBoxColumn.DataPropertyName = "used_pin_number";
            this.usedpinnumberDataGridViewCheckBoxColumn.HeaderText = "used_pin_number";
            this.usedpinnumberDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.usedpinnumberDataGridViewCheckBoxColumn.Name = "usedpinnumberDataGridViewCheckBoxColumn";
            // 
            // onlineorderDataGridViewCheckBoxColumn
            // 
            this.onlineorderDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.onlineorderDataGridViewCheckBoxColumn.DataPropertyName = "online_order";
            this.onlineorderDataGridViewCheckBoxColumn.HeaderText = "online_order";
            this.onlineorderDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.onlineorderDataGridViewCheckBoxColumn.Name = "onlineorderDataGridViewCheckBoxColumn";
            // 
            // fraudDataGridViewCheckBoxColumn
            // 
            this.fraudDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fraudDataGridViewCheckBoxColumn.DataPropertyName = "fraud";
            this.fraudDataGridViewCheckBoxColumn.HeaderText = "fraud";
            this.fraudDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.fraudDataGridViewCheckBoxColumn.Name = "fraudDataGridViewCheckBoxColumn";
            this.fraudDataGridViewCheckBoxColumn.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "AI Card Transactions Fraud Detection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credit_Card_InfoDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button modelMetricsBtn;
        private System.Windows.Forms.Button trainModelBtn;
        private System.Windows.Forms.Button AddTransactionBtn;
        private System.Windows.Forms.Button Validate;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.ToolTip toolTip1;
        private Credit_Card_InfoDataSet credit_Card_InfoDataSet;
        private System.Windows.Forms.BindingSource userTransactionsBindingSource;
        private Credit_Card_InfoDataSetTableAdapters.User_TransactionsTableAdapter user_TransactionsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distancefromhomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distancefromlasttransactionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratiotomedianpurchasepriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn repeatretailerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usedchipDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usedpinnumberDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onlineorderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fraudDataGridViewCheckBoxColumn;
    }
}

