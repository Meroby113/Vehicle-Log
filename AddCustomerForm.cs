
using EntityFrameworkProject.EntityFrameworkModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
    public partial class AddCustomerForm : Form
    {
        dbVlogEntities Vlog = new dbVlogEntities();
        GenelClass GC = new GenelClass();

        public AddCustomerForm()
        {
            InitializeComponent();

        }
        private void AddCustomerB_Click(object sender, EventArgs e)
        {
            GenderCB.Text = GC.checkCombobox(GenderCB.Text);
                Customer customer = new Customer()
            {
                name = NameTB.Text,
                surname = surnameTB.Text,
                user_id = UserIdTB.Text,
                date_of_birth = DateOfBirthDTP.Value,
                gender = GenderCB.Text,
                phone_number = PhoneNumberTB.Text,
                address = AddressTB.Text,
                add_info_abt_user = AddInofAbtUserTB.Text
            };

            Vlog.Customer.Add(customer);
            Vlog.SaveChanges();
            MessageBox.Show(NameTB.Text + " Added Successfully");
            GenelClass c = new GenelClass();
            c.ClearInputs(this.Controls);
        }
        private void BackToHomeB_Click(object sender, EventArgs e)
        {
            HomeF home = new HomeF();
            home.Show();
            this.Hide();
        }
    }
}
