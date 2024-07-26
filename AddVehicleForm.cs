using EntityFrameworkProject.EntityFrameworkModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
    public partial class AddVehicleForm : Form
    {
        dbVlogEntities Vlog = new dbVlogEntities();
        GenelClass GC = new GenelClass();
        public AddVehicleForm()
        {
            InitializeComponent();
       
        }
        public AddVehicleForm(String customer_id, String name, String surname)
        {
            InitializeComponent();
            CustomerNameL.Text = name.Trim() + " " + surname.Trim();
            customer_idL.Text = customer_id;
        } 
        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            CustomerNameL.TextAlign = ContentAlignment.TopCenter;
        }

        private void BackToListCustomerFormB_Click(object sender, EventArgs e)
        {
            ListCustomerForm listCustomerForm = new ListCustomerForm();
            listCustomerForm.Show();
            this.Hide();
        }
        private void AddVehicleB_Click(object sender, EventArgs e)
        {
            

            Vehicle vehicle = new Vehicle();
            vehicle.vehicle_type = VehicleTypeTB.Text;
            vehicle.plate_number = PlateNumberTB.Text;
            FuelTypeCB.Text = GC.checkCombobox(FuelTypeCB.Text);
            vehicle.fuel_type = FuelTypeCB.SelectedItem.ToString();

            Customer customer = Vlog.Customer.Find(Int32.Parse(customer_idL.Text));
            vehicle.customer_id = customer.customer_id;
            Vlog.Vehicle.Add(vehicle);
            Vlog.SaveChanges();
            MessageBox.Show("New Vehicle Added to " + CustomerNameL.Text.Trim() + " Successfully");
            AddVehicleForm addVehicleForm = new AddVehicleForm();

            VehicleTypeTB.Text = "";
            PlateNumberTB.Text = "";
            FuelTypeCB.Text = "";
        }
    }
}
