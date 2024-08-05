using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkProject.EntityFrameworkModels;

namespace EntityFrameworkProject
{
    public partial class FuelHistoryForm : Form
    {
        dbVlogEntities Vlog = new dbVlogEntities();
        public FuelHistoryForm(int customer_id, int vehicle_id, String customerName, String vehicleType)
        {
            InitializeComponent();
            Customer_idL.Text = customer_id.ToString();
            VehicleIdL.Text = vehicle_id.ToString();
            CustomerNameL.Text = customerName;
            VehicleTypeL.Text = vehicleType;
            
            CustomerNameL.TextAlign = ContentAlignment.MiddleCenter;
        }
        private void HistoryOfFuelPurchaseForm_Load(object sender, EventArgs e)
        {
            int vehicle_id = Int32.Parse(VehicleIdL.Text);
            var data = from fuel in Vlog.Fuel
                       where fuel.vehicle_id == vehicle_id
                       select new
                       {
                           fuel.fuel_id,
                           fuel_amount = fuel.fuel_amount.ToString() + " Liters",
                           transaction_amount = fuel.transaction_amount.ToString() + " $",
                           fuel.fueling_date,
                           fuel.payment_type,
                       };
            

            FuelHistoryDGV.DataSource = data.ToList();

            FuelHistoryDGV.Columns[0].Visible = false;
            FuelHistoryDGV.Columns[1].HeaderText = "Fuel Amount";
            FuelHistoryDGV.Columns[2].HeaderText = "Transaction Amount";
            FuelHistoryDGV.Columns[3].HeaderText = "Date of Purchase";
            FuelHistoryDGV.Columns[4].HeaderText = "Payment Type";
        }
         private void BackToVehicleListFormB_Click(object sender, EventArgs e)
        {
            VehicleListForm vehicleListForm = new VehicleListForm(Customer_idL.Text, CustomerNameL.Text);
            vehicleListForm.Show();
            this.Hide();
        }
    }
}
