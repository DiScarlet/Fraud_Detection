using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.IO;
using static System.Console;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
using CsvHelper;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace termwork2023
{
    public partial class CSV_SQL : Form
    {
        public CSV_SQL()
        {
            InitializeComponent();
            button2.Enabled = false;
        }

        string sqlServerName = "";
        
        /// <summary>
        /// button for choosing file to upload from and SQL Server Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                button2.Enabled = true;
            }
        }

        // new class which contains all properties of the Transaction
        public class Card_Transaction
        {
            public double distance_from_home;
            public double distance_from_last_transaction;
            public double ratio_to_median_purchase_price;
            public bool repeat_retailer;
            public bool used_chip;
            public bool used_pin_number;
            public bool online_order;
            //public bool fraud;
        }

        /// <summary>
        /// uploding selected file to SQL Server Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection($"Initial Catalog = Credit_Card_Info; Integrated Security = SSPI;");
            sc.Open();
            SqlCommand insert;

            var reader = new StreamReader(openFileDialog1.FileName);
            var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            // read CSV file
            reader = new StreamReader(openFileDialog1.FileName);
            csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<dynamic>();


            // output
            foreach (var r in records)
            {
                Card_Transaction row = new Card_Transaction();
                string t;
                double d;

                t = r.distance_from_home;
                t = t.Replace('.', CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);

                if (Double.TryParse(t, out d))
                {
                    row.distance_from_home = d;
                }

                t = r.distance_from_last_transaction;
                t = t.Replace('.', CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);
                if (Double.TryParse(t, out d))
                {
                    row.distance_from_last_transaction = d;
                }

                t = r.ratio_to_median_purchase_price;
                t = t.Replace('.', CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);
                if (Double.TryParse(t, out d))
                {
                    row.ratio_to_median_purchase_price = d;
                }

                t = r.repeat_retailer;
                t = t.Replace('.', CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);
                if (Double.TryParse(t, out d))
                {
                    if (d > 0.1)
                        row.repeat_retailer = true;
                    else
                        row.repeat_retailer = false;
                }


                t = r.used_chip;
                t = t.Replace('.', CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);
                if (Double.TryParse(t, out d))
                {
                    if (d > 0.1)
                        row.used_chip = true;
                    else
                        row.used_chip = false;
                }

                t = r.used_pin_number;
                t = t.Replace('.', CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);
                if (Double.TryParse(t, out d))
                {
                    if (d > 0.1)
                        row.used_pin_number = true;
                    else
                        row.used_pin_number = false;
                }

                t = r.online_order;
                t = t.Replace('.', CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator[0]);
                if (Double.TryParse(t, out d))
                {
                    if (d > 0.1)
                        row.online_order = true;
                    else
                        row.online_order = false;
                }

                t = $"insert into dbo.User_Transactions values ('{r.distance_from_home}'," +
                    $"'{r.distance_from_last_transaction}'," +
                    $"'{r.ratio_to_median_purchase_price}', " +
                    $"'{row.repeat_retailer}'," +
                    $"'{row.used_chip}'," +
                    $"'{row.used_pin_number}'," +
                    $"'{row.online_order}',"+ 
                    $"'')";
                insert = new SqlCommand(t, sc);
                insert.ExecuteNonQuery();
            }
            SqlCommand update = new SqlCommand();
            SetNullForFraud(sc, update);

            reader.Close();
            sc.Close();

            MessageBox.Show("Operation completed.");
        }

        void SetNullForFraud(SqlConnection sc, SqlCommand update)
        {
            string command = $"UPDATE Credit_Card_Info.dbo.User_Transactions " +
                $"SET fraud = NULL ";
            update.Connection = sc;
            update.CommandText = command;
            update.ExecuteNonQuery();
        }
    }
}

    

