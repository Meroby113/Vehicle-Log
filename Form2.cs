using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkProject.EntityFrameworkModels;
namespace EntityFrameworkProject
{
    public partial class FuelPurchaseForm : Form
    {
        dbVlogEntities Vlog = new dbVlogEntities();
        GenelClass GC = new GenelClass();
        public FuelPurchaseForm(int customer_id, int vehicle_id, String customerName, String vehicleType)
        {
            
            InitializeComponent();
            VehicleIdL.Text = vehicle_id.ToString();
            CustomerIdL.Text = customer_id.ToString();
            CustomerNameL.Text = customerName;
            VehicleTypeL.Text = vehicleType;
            CustomerNameL.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void BackToListCustomerFormB_Click(object sender, EventArgs e)
        {
            VehicleListForm vehicleListForm = new VehicleListForm(CustomerIdL.Text, CustomerNameL.Text);
            vehicleListForm.Show();
            this.Hide();
        }

        private void PurchaseFuelB_Click(object sender, EventArgs e)
        {
            controlPayment(PaymentTypeCB.Text, TransactionAmountTB.Text);
        }

        private void FuelAmountTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void FuelAmountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            GC.justNumericAllowded(sender, e);
        }

        private void TransactionAmountTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            GC.justNumericAllowded(sender, e);
        }

        public void controlPayment(String paymentType, String transactionAmount)
        {
            var isPaymentSucceded = false;
            var customer_id =Int32.Parse(CustomerIdL.Text);
            Balance balance = (from b in Vlog.Balance
                           where b.customer_id == customer_id
                           select b).FirstOrDefault();

            if (balance == null)
            {
                var message = "This Customer do not have Balance please add balance first and then get fuel";
                MessageBoxForm messageBoxForm = new MessageBoxForm(message);
                messageBoxForm.ShowDialog();
                return;
            }

            if (paymentType == "Cash")
            {
                if (balance.cash < Decimal.Parse(transactionAmount))
                {
                    MessageBoxForm messageBoxForm = new MessageBoxForm("Cash is not enough to pay, Please chose another payment method");
                    messageBoxForm.ShowDialog();
                }
                else
                {
                    balance.cash -= Decimal.Parse(transactionAmount);
                    MessageBoxForm messageBoxForm = new MessageBoxForm("Payment is successfull");
                    messageBoxForm.ShowDialog();
                    isPaymentSucceded = true;
                }
            }
            else if (paymentType == "Credit")
            {
                if (balance.credit < Decimal.Parse(transactionAmount))
                {
                    MessageBoxForm messageBoxForm = new MessageBoxForm("Credit is not enough to pay, Please chose another payment method");
                    messageBoxForm.ShowDialog();
                }
                else
                {
                    balance.credit -= Decimal.Parse(transactionAmount);
                    MessageBoxForm messageBoxForm = new MessageBoxForm("Payment is successfull");
                    messageBoxForm.ShowDialog();
                    isPaymentSucceded = true;
                }
            }
            else
            {
                if (balance.gift_card < Decimal.Parse(transactionAmount))
                {
                    MessageBoxForm messageBoxForm = new MessageBoxForm("Gift Card is not enough to pay, Please chose another payment method");
                    messageBoxForm.ShowDialog();
                }
                else
                {
                    balance.gift_card -= Decimal.Parse(transactionAmount);
                    MessageBoxForm messageBoxForm = new MessageBoxForm("Payment is successfull");
                    messageBoxForm.ShowDialog();
                    isPaymentSucceded = true;
                }
            }
            if (isPaymentSucceded) {

                Fuel fuel = new Fuel();
                fuel.vehicle_id = Int32.Parse(VehicleIdL.Text);
                fuel.transaction_amount = Int32.Parse(TransactionAmountTB.Text);
                fuel.fuel_amount = Int32.Parse(FuelAmountTB.Text);
                fuel.fueling_date = DateOfPurchaseDTP.Value;
                PaymentTypeCB.Text = GC.checkCombobox(PaymentTypeCB.Text);
                fuel.payment_type = PaymentTypeCB.Text;
                Vlog.Fuel.Add(fuel);
                Vlog.SaveChanges();

                GC.ClearInputs(this.Controls);
            } else {
                PaymentTypeCB.Text = "";
            }
                Vlog.SaveChanges();
            }

    }
}
