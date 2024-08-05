using EntityFrameworkProject.EntityFrameworkModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
    public partial class BudgetForm : Form
    {
        dbVlogEntities Vlog = new dbVlogEntities();
        GenelClass GC = new GenelClass();
        public BudgetForm(String customer_id, String name, String surname)
        {
            InitializeComponent();
            CustomerNameL.Text = name.Trim() + " " + surname.Trim();
            Customer_idL.Text = customer_id;
            

        }

        private void BudgetForm_Load(object sender, EventArgs e)
        {
            CustomerNameL.TextAlign = ContentAlignment.MiddleCenter;
            Customer customer = Vlog.Customer.Find(Int32.Parse(Customer_idL.Text));
            Console.WriteLine(customer.balance_id);

            if(customer.balance_id == null) {
                CredirL.Visible = false;
                CreditTB.Visible = false;
                CashL.Visible = false;
                CashTB.Visible = false;
                GiftCardL.Visible = false;
                GiftCardTB.Visible = false;
                UpdateBudgetB.Visible = false;

                NoBudgetL.Text = CustomerNameL.Text + " Customer does not have any budget yet !\r\nPlease click \"Add Budget\" button to add new budget..";
                NoBudgetL.Visible = true;
                AddBudgetB.Visible = true;
            } else
            {

                Balance balance = Vlog.Balance.Find(customer.balance_id);
                CreditTB.Text = balance.credit.ToString();
                CashTB.Text = balance.cash.ToString();
                GiftCardTB.Text = balance.gift_card.ToString();
            }
        }

        private void BackToListCustomerFormB_Click(object sender, EventArgs e)
        {
            ListCustomerForm listCustomerForm = new ListCustomerForm();
            listCustomerForm.Show();
            this.Hide();
        }

        private void AddBudgetB_Click(object sender, EventArgs e)
        {
            
            CredirL.Visible = true;
            CreditTB.Visible = true;
            CashL.Visible = true;
            CashTB.Visible = true;
            GiftCardL.Visible = true;
            GiftCardTB.Visible = true;
            UpdateBudgetB.Visible = true;
            NoBudgetL.Visible = false;
            AddBudgetB.Visible = false;
            
            
        }

        private void UpdateBudgetB_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.gift_card = Decimal.Parse(GiftCardTB.Text);
            balance.credit = Decimal.Parse(CreditTB.Text);
            balance.cash = Decimal.Parse(CashTB.Text);

            Customer customer = Vlog.Customer.Find(Int32.Parse(Customer_idL.Text));
            customer.balance_id = balance.balance_id;
            balance.customer_id = Int32.Parse(Customer_idL.Text);

            Vlog.Balance.Add(balance);
            Vlog.SaveChanges();
            MessageBox.Show("New Budget Added to " + CustomerNameL.Text.Trim() + " Successfully");
        }

        private void GiftCardTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            GC.justNumericAllowded(sender, e);
        }

        private void CreditTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            GC.justNumericAllowded(sender, e);
        }

        private void CashTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            GC.justNumericAllowded(sender, e);
        }
    }
}
