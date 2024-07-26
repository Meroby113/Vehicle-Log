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
    public partial class HomeF : Form
    {
        public HomeF()
        {
            InitializeComponent();
        }
        private void HomeF_Load(object sender, EventArgs e)
        {

        }
        private void HomePagePB_Click(object sender, EventArgs e)
        {

        }

        private void ListCustomerB_Click(object sender, EventArgs e)
        {
            ListCustomerForm listCustomer = new ListCustomerForm();
            listCustomer.Show();
            this.Hide();
        }

        private void AddCustomerB_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomer = new AddCustomerForm();
            addCustomer.Show();
            this.Hide();
        }
    }
}
