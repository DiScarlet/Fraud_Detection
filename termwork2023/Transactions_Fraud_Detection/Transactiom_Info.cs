using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transactions_Fraud_Detection
{
    public class Transaction_Info
    {
        [LoadColumn(0)] public float distance_from_home { get; set; }
        [LoadColumn(1)] public float distance_from_last_transaction { get; set; }
        [LoadColumn(2)] public float ratio_to_median_purchase_price { get; set; }
        [LoadColumn(3)] public float repeat_retailer { get; set; }
        [LoadColumn(4)] public float used_chip { get; set; }
        [LoadColumn(5)] public float used_pin_number { get; set; }
        [LoadColumn(6)] public float online_order { get; set; }
        [LoadColumn(7), ColumnName("Label")] public float fraud { get; set; }
    }
}
