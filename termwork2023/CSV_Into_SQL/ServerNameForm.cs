using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace termwork2023
{
    public partial class ServerNameForm : Form
    {
        public ServerNameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// button for filling in user's SQl Server name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public string serverName
        {
            get { return textBox1.Text; }
        }
    }
}
