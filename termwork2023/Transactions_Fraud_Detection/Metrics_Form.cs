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
    public partial class Metrics_Form : Form
    {
        public Metrics_Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// button for closing metrics form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
