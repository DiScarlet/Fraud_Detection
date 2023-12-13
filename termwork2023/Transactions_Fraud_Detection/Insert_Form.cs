using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transactions_Fraud_Detection
{
    public partial class Insert_Form : Form
    {
        public Insert_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// button which accepts inserting new transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDataBtn_Click(object sender, EventArgs e)
        {
            Insert_Form insrtForm = new Insert_Form();
            this.DialogResult = DialogResult.OK;
        }

        public string distance_from_home
        {
            get { return textBox1.Text; }
        }
        public string distance_from_last_transaction
        {
            get { return textBox2.Text; }
        }
        public string ratio_to_median_purchase_price
        {
            get { return textBox3.Text; }
        }
        public bool repeat_retailer
        {
            get { return checkBox1.Checked; }
        }
        public bool used_chip
        {
            get { return checkBox2.Checked; }
        }
        public bool used_pin_number
        {
            get { return checkBox3.Checked; }
        }
        public bool online_order
        {
            get { return checkBox4.Checked; }
        }

        private void CloseButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
