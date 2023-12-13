using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;

namespace Transactions_Fraud_Detection
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsAnyChanges
        {
            get; set;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // filling dataGridView with data
            try
            {
                this.user_TransactionsTableAdapter.Fill(this.credit_Card_InfoDataSet.User_Transactions);
            }
            catch 
            {
                MessageBox.Show("Make sure that all SQL Server Services are enabled and you are using correct connection string.", "SQL Server Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // indicating the activation/deactivation of the buttons
            modelMetricsBtn.Enabled = false;
            Validate.Enabled = false;
            if (File.Exists("model.zip") == true)
            {
                Validate.Enabled = true;
            }
            Save.Enabled = false;
            IsAnyChanges = false;

            // setting colours of the transactions (rows in dataGridView)
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Transactions_Fraud_Detection.Credit_Card_InfoDataSet.User_TransactionsRow currentTransaction = credit_Card_InfoDataSet.User_Transactions[i];

                try
                {
                    bool? isFraud = currentTransaction.fraud;
                }
                catch (global::System.Data.StrongTypingException)
                {
                    continue;
                }
                SetRowColour(dataGridView1.Rows[i], currentTransaction.fraud);
            }

            // setting headers style
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

            // setting the tooplTips texts
            toolTip1.SetToolTip(this.Delete, "Delete selected transactions");
            toolTip1.SetToolTip(this.AddTransactionBtn, "Create a new transaction using your own data");

            toolTip1.SetToolTip(this.trainModelBtn, "For further operations with a model train it first");
            toolTip1.SetToolTip(this.Validate, "Check whether selected transaction fradulent or not");
            toolTip1.SetToolTip(this.modelMetricsBtn, "Take a look at your model's Accuracy, Precicion, Recall, F1 Score");

            toolTip1.SetToolTip(this.Save, "Save changes to your SQL database");

            // event of changing info in dataGridView by the user
            this.credit_Card_InfoDataSet.User_Transactions.ColumnChanged += User_Transactions_ColumnChanged;
        }

        // event handler for event of changing info in dataGridView by the user
        private void User_Transactions_ColumnChanged(object sender, DataColumnChangeEventArgs e)
        {
            IsAnyChanges = true;
            Save.Enabled = true;
        }

        /// <summary>
        /// button for deleting selected rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, EventArgs e)
        {
            int count = this.dataGridView1.SelectedRows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                }
                this.user_TransactionsTableAdapter.Update(this.credit_Card_InfoDataSet.User_Transactions);
                Save.Enabled = false;
                IsAnyChanges = false;
            }
            else
            {
                MessageBox.Show("Select at least 1 transaction to delete it", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }   

        /// <summary>
        /// button for adding custom transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTransactionBtn_Click(object sender, EventArgs e)
        {
            float distance_from_home = 0, distance_from_last_transaction = 0, ratio_to_median_purchase_price = 0;
            bool repeat_retailer = false, used_chip = false, used_pin_number = false, online_order = false;

            Insert_Form insrtForm = new Insert_Form();


            if (insrtForm.ShowDialog() == DialogResult.OK)
            {

                float.TryParse(insrtForm.distance_from_home, out distance_from_home);
                float.TryParse(insrtForm.distance_from_last_transaction, out distance_from_last_transaction);
                float.TryParse(insrtForm.ratio_to_median_purchase_price, out ratio_to_median_purchase_price);

                repeat_retailer = insrtForm.repeat_retailer;
                used_chip = insrtForm.used_chip;
                used_pin_number = insrtForm.used_pin_number;
                online_order = insrtForm.online_order;

                Credit_Card_InfoDataSet.User_TransactionsRow newRow = this.credit_Card_InfoDataSet.User_Transactions.NewUser_TransactionsRow();

                newRow.distance_from_home = distance_from_home;
                newRow.distance_from_last_transaction = distance_from_last_transaction;
                newRow.ratio_to_median_purchase_price = ratio_to_median_purchase_price;
                newRow.repeat_retailer = repeat_retailer;
                newRow.used_chip = used_chip;
                newRow.used_pin_number = used_pin_number;
                newRow.online_order = online_order;

                this.credit_Card_InfoDataSet.User_Transactions.AddUser_TransactionsRow(newRow);

                user_TransactionsTableAdapter.Update(this.credit_Card_InfoDataSet.User_Transactions);

                dataGridView1.DataSource = credit_Card_InfoDataSet.User_Transactions;
                Save.Enabled = false;
                IsAnyChanges = false;
            }
        }

        /// <summary>
        /// button for calling function of training and saving the model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trainModelBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("model.zip") == false)
            {
                TeachModel();

                Validate.Enabled = true;
            }

            else
            {
                Teach_Model teach_Model = new Teach_Model();

                if (teach_Model.ShowDialog() == DialogResult.OK)
                {
                    TeachModel();
                }

                else
                {
                    MessageBox.Show("You have cancelled the operation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// function which trains and saves the model
        /// </summary>
        public void TeachModel()
        {
            var context = new MLContext();

            // uploading data from a .csv file
            var data = context.Data.LoadFromTextFile<Transaction_Info>("card_transdata.csv", separatorChar: ',', hasHeader: true);

            // split the file with ratio of 80/20 - for training and training
            var dataSplit = context.Data.TrainTestSplit(data, testFraction: 0.2);
            var features = dataSplit.TrainSet.Schema// features - columns of parameters that we provide to the algorithm to create a model
                .Select(column => column.Name)
                .Where(name => name != "Label")// Not usiing these Label in the Scheme 
                .ToArray();

            // сreating a data processing pipeline
            var pipeline = context.Transforms.Concatenate("Features", features)
                .Append(context.Transforms.NormalizeMinMax("Features"))
                .Append(context.Transforms.Conversion.ConvertType("Label", outputKind: DataKind.Boolean));

            // defining Fast Tree learning algorithm and its parameters
            var trainer = context.BinaryClassification.Trainers.FastTree(
                labelColumnName: "Label",
                featureColumnName: "Features",
                numberOfLeaves: 100,
                numberOfTrees: 100,
                minimumExampleCountPerLeaf: 10);

            // creating a model
            var trainingPipeline = pipeline.Append(trainer);
            var model = trainingPipeline.Fit(dataSplit.TrainSet);

            //saving the model
            context.Model.Save(model, dataSplit.TrainSet.Schema, "model.zip");
        }

        /// <summary>
        /// button to view transaction metrics
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modelMetricsBtn_Click(object sender, EventArgs e)
        {
            Metrics_Form metricsForm = new Metrics_Form();

            ((Label)metricsForm.Controls["label2"]).Text = Convert.ToString(Math.Round(accuracy, 5));
            ((Label)metricsForm.Controls["label3"]).Text = Convert.ToString(Math.Round(precision, 5));
            ((Label)metricsForm.Controls["label5"]).Text = Convert.ToString(Math.Round(recall, 5));
            ((Label)metricsForm.Controls["label7"]).Text = Convert.ToString(Math.Round(F1, 5));

            metricsForm.ShowDialog();
        }

        double accuracy, precision, recall, F1;

        /// <summary>
        /// asking the user if he really wants to exit without saving changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Save.Enabled || IsAnyChanges)
            {
                Closing_Save closing_Save = new Closing_Save();

                if (closing_Save.ShowDialog() == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    MessageBox.Show("You have cancelled the operation", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        /// <summary>
        /// button for validating selected transactions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Validate_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int count = dataGridView1.SelectedRows.Count;
                bool[] bools = new bool[count];

                var context = new MLContext();
                var data = context.Data.LoadFromTextFile<Transaction_Info>("card_transdata.csv", separatorChar: ',', hasHeader: true);
                var dataSplit = context.Data.TrainTestSplit(data, testFraction: 0.2);

                DataViewSchema modelSchema;
                var model = context.Model.Load("model.zip", out modelSchema);
                for (int i = 0; i < count; i++)
                {
                    // getting transaction features
                    Transactions_Fraud_Detection.Credit_Card_InfoDataSet.User_TransactionsRow currentTransaction = credit_Card_InfoDataSet.User_Transactions[dataGridView1.SelectedRows[i].Index];
                    float distancefrom_home = currentTransaction.distance_from_home;
                    float distancefrom_last_transaction = currentTransaction.distance_from_last_transaction;
                    float ratioto_median_purchase_price = currentTransaction.ratio_to_median_purchase_price;

                    float repeatretailer, usedchip, usedpin_number, onlineorder;

                    if (Convert.ToBoolean(currentTransaction.repeat_retailer) == false) { repeatretailer = 0; }
                    else { repeatretailer = 1; }
                    if (Convert.ToBoolean(currentTransaction.used_chip) == false) { usedchip = 0; }
                    else { usedchip = 1; }
                    if (Convert.ToBoolean(currentTransaction.used_pin_number) == false) { usedpin_number = 0; }
                    else { usedpin_number = 1; }
                    if (Convert.ToBoolean(currentTransaction.online_order) == false) { onlineorder = 0; }
                    else { onlineorder = 1; }

                    var input = new Transaction_Info
                    {
                        distance_from_home = distancefrom_home,
                        distance_from_last_transaction = distancefrom_last_transaction,
                        ratio_to_median_purchase_price = ratioto_median_purchase_price,
                        repeat_retailer = repeatretailer,
                        used_chip = usedchip,
                        used_pin_number = usedpin_number,
                        online_order = onlineorder
                    };

                    // model usage on a given transaction
                    var inputView = context.Data.LoadFromEnumerable(new[] { input });
                    var prediction = model.Transform(inputView);

                    bool predictedLabel = context.Data.CreateEnumerable<CreditCardFraudPrediction>(prediction, reuseRowObject: false).First().PredictedLabel;

                    // using data on the test set and getting metrics            
                    var testData = model.Transform(dataSplit.TestSet);
                    var metrics = context.BinaryClassification.Evaluate(testData, labelColumnName: "Label", predictedLabelColumnName: "PredictedLabel");
                    accuracy = metrics.Accuracy;
                    precision = metrics.PositivePrecision;
                    recall = metrics.PositiveRecall;
                    F1 = metrics.F1Score;

                    int index = dataGridView1.SelectedRows[i].Index;
                    DataGridViewRow row = dataGridView1.Rows[index];

                    // calling the function which is setting the colour of the transaction according to the class it was assigned to
                    SetRowColour(row, predictedLabel);

                    // changing coloumn "fraud" according to the class the transaction was assigned to
                    if (predictedLabel == true)
                    {
                        currentTransaction.fraud = true;
                    }

                    else if (predictedLabel == false)
                    {
                        currentTransaction.fraud = false;
                    }
                }

                // enabling other buttons connected to the model
                modelMetricsBtn.Enabled = true;
                Save.Enabled = false;
                IsAnyChanges = false;

                // updating SQL Server with new info of the transaction
                this.user_TransactionsTableAdapter.Update(this.credit_Card_InfoDataSet.User_Transactions);
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Select at least 1 transaction to validate it", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// function which is setting the colour of the transaction according to the class it was assigned to 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="predictedLabel">variable which defines whether transaction fradulent or legitimate</param>
        private void SetRowColour(DataGridViewRow row, bool predictedLabel)
        {
            if (predictedLabel == true)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
            }

            else if (predictedLabel == false)
            {
                row.DefaultCellStyle.BackColor = Color.Green;
            }
        }

        /// <summary>
        /// button which saves all changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            this.user_TransactionsTableAdapter.Update(this.credit_Card_InfoDataSet.User_Transactions);
            MessageBox.Show("All changes were saved!");
            Save.Enabled = false;
            IsAnyChanges = false;
        }
    }

    // new class where predicted label is going to be stored
    public class CreditCardFraudPrediction
    {
        [ColumnName("PredictedLabel")]
        public bool PredictedLabel;
    }
}
