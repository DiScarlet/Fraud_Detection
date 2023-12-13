using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using Transactions_Fraud_Detection;
using static Transactions_Fraud_Detection.Form1;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestFraudDetection
    {
        /// <summary>
        /// unit test for checking logic of classification of fradulent transactions
        /// </summary>
        [TestMethod]
        public void TestFraudTransaction()
        {
            var context = new MLContext();

            DataViewSchema modelSchema;
            var model = context.Model.Load("model.zip", out modelSchema);

            var input = new Transaction_Info // new instance of Transaction_Info - creation of fradulent transaction
            {
                distance_from_home = 3804,
                distance_from_last_transaction = 2623,
                ratio_to_median_purchase_price = 435,
                repeat_retailer = 0,
                used_chip = 0,
                used_pin_number = 0,
                online_order = 1
            };

            var inputView = context.Data.LoadFromEnumerable(new[] { input });
            var prediction = model.Transform(inputView);

            bool predictedLabel = context.Data.CreateEnumerable<CreditCardFraudPrediction>(prediction, reuseRowObject: false).First().PredictedLabel;
            Assert.IsTrue(predictedLabel, "Fraudulent transaction was detected as legitimate.");
        }

        /// <summary>
        /// unit test for checking logic of classification of legitimate transactions
        /// </summary>
        [TestMethod]
        public void TestLegitimateTransaction()
        {
            var context = new MLContext();

            DataViewSchema modelSchema;
            var model = context.Model.Load("model.zip", out modelSchema);

            var input = new Transaction_Info // new instance of Transaction_Info - creation of legitimate transaction
            {
                distance_from_home = 5,
                distance_from_last_transaction = 8,
                ratio_to_median_purchase_price = 7,
                repeat_retailer = 1,
                used_chip = 1,
                used_pin_number = 1,
                online_order = 0
            };

            var inputView = context.Data.LoadFromEnumerable(new[] { input });
            var prediction = model.Transform(inputView);

            bool predictedLabel = context.Data.CreateEnumerable<CreditCardFraudPrediction>(prediction, reuseRowObject: false).First().PredictedLabel;
            Assert.IsTrue(!predictedLabel, "Legitimate transaction was detected as fradulent.");
        }
    }
}
