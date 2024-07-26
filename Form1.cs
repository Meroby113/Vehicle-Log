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
using System.Xml.Linq;

namespace EntityFrameworkProject
{
    public partial class VehicleListForm : Form
    {
        dbVlogEntities Vlog = new dbVlogEntities();
        public VehicleListForm(String customer_id, String name, String surname)
        {
            InitializeComponent();
            CustomerNameL.Text = name.Trim() + " " + surname.Trim();
            customer_idL.Text = customer_id;
        }

        public VehicleListForm(String customer_id, String CustomerName)
        {
            InitializeComponent();
            CustomerNameL.Text = CustomerName;
            customer_idL.Text = customer_id;
        }

        private void BackToListCustomerFormB_Click(object sender, EventArgs e)
        {
            ListCustomerForm listCustomerForm = new ListCustomerForm();
            listCustomerForm.Show();
            this.Hide();
        }

        private void VehicleListForm_Load(object sender, EventArgs e)
        {
            int customer_id = Int32.Parse(customer_idL.Text);
            

            var data = from vehicle in Vlog.Vehicle
                       where vehicle.customer_id == customer_id
                       select new
                       {
                           vehicle.vehicle_id,
                           vehicle.vehicle_type,
                           vehicle.plate_number,
                           vehicle.fuel_type
                       };
            VehiclesListDGV.DataSource = data.ToList();

            VehiclesListDGV.Columns[0].Visible = false;
            VehiclesListDGV.Columns[1].HeaderText = "Vehicle Type";
            VehiclesListDGV.Columns[2].HeaderText = "Plate Number";
            VehiclesListDGV.Columns[3].HeaderText = "Fuel Type";

            DataGridViewButtonColumn AddFuelbtn = new DataGridViewButtonColumn();
            AddFuelbtn.HeaderText = "Add Fuel";
            AddFuelbtn.Text = "Add Fuel";
            AddFuelbtn.Name = "AddFuelbtn";
            AddFuelbtn.UseColumnTextForButtonValue = true;
            VehiclesListDGV.Columns.Add(AddFuelbtn);
            
            VehiclesListDGV.CellClick += new DataGridViewCellEventHandler(AddFuelbtn_CellClick);

            DataGridViewButtonColumn FuelHistorybtn = new DataGridViewButtonColumn();
            FuelHistorybtn.HeaderText = "Fuel History";
            FuelHistorybtn.Text = "Fuel History";
            FuelHistorybtn.Name = "FuelHistorybtn";
            FuelHistorybtn.UseColumnTextForButtonValue = true;
            VehiclesListDGV.Columns.Add(FuelHistorybtn);

           VehiclesListDGV.CellClick += new DataGridViewCellEventHandler(FuelHistorybtn_CellClick);

            DataGridViewButtonColumn DeleteVehiclebtn = new DataGridViewButtonColumn();
            DeleteVehiclebtn.HeaderText = "Delete Vehicle";
            DeleteVehiclebtn.Text = "Delete Vehicle";
            DeleteVehiclebtn.Name = "DeleteVehiclebtn";
            DeleteVehiclebtn.UseColumnTextForButtonValue = true;
            VehiclesListDGV.Columns.Add(DeleteVehiclebtn);

            VehiclesListDGV.CellClick += new DataGridViewCellEventHandler(DeleteVehiclebtn_CellClick);

            CustomerNameL.TextAlign = ContentAlignment.MiddleCenter;
            
        }
        private void AddFuelbtn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == VehiclesListDGV.Columns["AddFuelbtn"].Index)
            {
                int customer_id = Int32.Parse(customer_idL.Text);
                int vehicle_id = Int32.Parse(VehiclesListDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                String customerName = CustomerNameL.Text;
                String vehicleType = VehiclesListDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                FuelPurchaseForm fuelPurchaseForm = new FuelPurchaseForm(customer_id, vehicle_id, customerName, vehicleType);
                fuelPurchaseForm.Show();
                this.Hide();
            }
        }

        private void FuelHistorybtn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == VehiclesListDGV.Columns["FuelHistorybtn"].Index)
            {
                int customer_id = Int32.Parse(customer_idL.Text);
                int vehicle_id = Int32.Parse(VehiclesListDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                String customerName = CustomerNameL.Text;
                String vehicleType = VehiclesListDGV.Rows[e.RowIndex].Cells[1].Value.ToString();
                FuelHistoryForm fuelHistoryForm = new FuelHistoryForm(customer_id, vehicle_id, customerName, vehicleType);
                fuelHistoryForm.Show();
                this.Hide();
            }
        }
        private void DeleteVehiclebtn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == VehiclesListDGV.Columns["DeleteVehiclebtn"].Index)
            {
                if(MessageBox.Show("Are you sure you want to delete this vehicle?", "Delete Vehicle", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Int32.Parse(VehiclesListDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var vehicle = Vlog.Vehicle.First(v => v.vehicle_id == id);

                    Vlog.Fuel.RemoveRange(Vlog.Fuel.Where(f => f.vehicle_id == id));
                                     
                    Vlog.Vehicle.Remove(vehicle);
                    Vlog.SaveChanges();
                    MessageBox.Show("Vehicle Deleted Successfully");
                }
                VehicleListForm vehiclesListForm = new VehicleListForm(customer_idL.Text, CustomerNameL.Text);
                vehiclesListForm.Show();
                this.Hide();
            }
        }

        private void CustomerNameL_Click(object sender, EventArgs e)
        {

        }
    }
}
