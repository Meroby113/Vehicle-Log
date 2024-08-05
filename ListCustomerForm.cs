using EntityFrameworkProject.EntityFrameworkModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EntityFrameworkProject
{
    public partial class ListCustomerForm : Form
    {
        dbVlogEntities Vlog = new dbVlogEntities();
        public ListCustomerForm()
        {
            InitializeComponent();
            LoadCustomerData();
        }
        private void LoadCustomerData()
        {
            var customers = Vlog.Customer.ToList();
            ListOfCustomerDGV.DataSource = customers;

            if(ListOfCustomerDGV.Columns["btn"] == null)
            {       
                AddButtonColumns();
            }
        }
        private void AddButtonColumns()
        {
            DataGridViewButtonColumn ApprovalStatusbtn = new DataGridViewButtonColumn();
            ApprovalStatusbtn.HeaderText = "Approval Status";
            ApprovalStatusbtn.Name = "ApprovalStatusbtn";
            ApprovalStatusbtn.UseColumnTextForButtonValue = false;
            ListOfCustomerDGV.Columns.Add(ApprovalStatusbtn);

            DataGridViewButtonColumn AddVehiclebtn = new DataGridViewButtonColumn();
            AddVehiclebtn.HeaderText = "Vehicle";
            AddVehiclebtn.Text = "Add Vehicle";
            AddVehiclebtn.Name = "btn";
            AddVehiclebtn.UseColumnTextForButtonValue = true;
            ListOfCustomerDGV.Columns.Add(AddVehiclebtn);

            DataGridViewButtonColumn VehiclesListbtn = new DataGridViewButtonColumn();
            VehiclesListbtn.HeaderText = "Vehicles List";
            VehiclesListbtn.Text = "Show Vehicles List";
            VehiclesListbtn.Name = "ShowVehiclesListbtn";
            VehiclesListbtn.UseColumnTextForButtonValue = true;
            ListOfCustomerDGV.Columns.Add(VehiclesListbtn);

            DataGridViewButtonColumn ShowBudgetbtn = new DataGridViewButtonColumn();
            ShowBudgetbtn.HeaderText = "Budget";
            ShowBudgetbtn.Text = "Show Budget";
            ShowBudgetbtn.Name = "ShowBudgetbtn";
            ShowBudgetbtn.UseColumnTextForButtonValue = true;
            ListOfCustomerDGV.Columns.Add(ShowBudgetbtn);

            DataGridViewButtonColumn DeleteCustomerbtn = new DataGridViewButtonColumn();
            DeleteCustomerbtn.HeaderText = "Delete Customer";
            DeleteCustomerbtn.Name = "DeleteCustomerbtn";
            DeleteCustomerbtn.Text = "Delete Customer";
            DeleteCustomerbtn.UseColumnTextForButtonValue = true;
            ListOfCustomerDGV.Columns.Add(DeleteCustomerbtn);

            ListOfCustomerDGV.CellClick += new DataGridViewCellEventHandler(AddVehiclebtn_CellContentClick);
            ListOfCustomerDGV.CellClick += new DataGridViewCellEventHandler(ShowBudgetbtn_CellContentClick);
            ListOfCustomerDGV.CellClick += new DataGridViewCellEventHandler(ShowVehiclesListbtn_CellContentClick);
            ListOfCustomerDGV.CellClick += new DataGridViewCellEventHandler(ApprovalStatusbtn_CellContentClick);
            ListOfCustomerDGV.CellClick += new DataGridViewCellEventHandler(DeleteCustomerbtn_CellContentClick);
            ListOfCustomerDGV.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(ListOfCustomerDGV_DataBindingComplete);
        }

        void ListOfCustomerDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            foreach (DataGridViewRow row in ListOfCustomerDGV.Rows)
            {
                Customer customer = Vlog.Customer.Find(Int32.Parse(row.Cells["customer_id"].Value.ToString()));
                string buttonText;
                if (customer.approval_status == null)
                {
                    buttonText = "Pending";
                }
                else if (!customer.approval_status.Value)
                {
                    buttonText = "Denied";
                }
                else
                {
                    buttonText = "Approved";
                }
                row.Cells["ApprovalStatusbtn"].Value = buttonText;
            }
        }
        private void ApprovalStatusbtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer customer = Vlog.Customer.Find(Int32.Parse(ListOfCustomerDGV.Rows[e.RowIndex].Cells["customer_id"].Value.ToString()));
            if ((e.ColumnIndex == ListOfCustomerDGV.Columns["ApprovalStatusbtn"].Index))
            {
                if (customer.approval_status == null)
                {
                    ListOfCustomerDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Approved";
                    customer.approval_status = true;
                    ListOfCustomerDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Green;
                }
                else if(customer.approval_status.Value)
                {
                    ListOfCustomerDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Denied";
                    customer.approval_status = false;
                    ListOfCustomerDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                }
                else
                {
                    ListOfCustomerDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "Pending";
                    customer.approval_status = null;
                    ListOfCustomerDGV.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;
                }

                Vlog.SaveChanges();
                ListOfCustomerDGV.Refresh();
            }
        }
        private void AddVehiclebtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String customer_id_str = (ListOfCustomerDGV.Rows[e.RowIndex].Cells["customer_id"].Value).ToString();
            String name = (ListOfCustomerDGV.Rows[e.RowIndex].Cells["name"].Value).ToString();
            String surname = (ListOfCustomerDGV.Rows[e.RowIndex].Cells["surname"].Value).ToString();

            Customer customer = Vlog.Customer.Find(Int32.Parse(customer_id_str));
            if (customer.approval_status == null || !(customer.approval_status.Value)) return;

            if (e.ColumnIndex == ListOfCustomerDGV.Columns["btn"].Index && e.RowIndex >= 0 )
            {
                AddVehicleForm addVehicleForm = new AddVehicleForm(customer_id_str, name, surname);
                addVehicleForm.Show();
                this.Hide();
            }
        }

        private void ShowBudgetbtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String customer_id_str = (ListOfCustomerDGV.Rows[e.RowIndex].Cells["customer_id"].Value).ToString();
            String name = (ListOfCustomerDGV.Rows[e.RowIndex].Cells["name"].Value).ToString();
            String surname = (ListOfCustomerDGV.Rows[e.RowIndex].Cells["surname"].Value).ToString();

            Customer customer = Vlog.Customer.Find(Int32.Parse(customer_id_str));
            if (customer.approval_status == null || !(customer.approval_status.Value)) return;

            if (e.ColumnIndex == ListOfCustomerDGV.Columns["ShowBudgetbtn"].Index && e.RowIndex >= 0)
            {
                BudgetForm budgetForm = new BudgetForm(customer_id_str, name, surname);
                budgetForm.Show();
                this.Hide();
            }
        }
         private void SearchTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(SearchTB.Text != "")
            {
                
                    using (var context = new dbVlogEntities())
                    {
                        var customers = context.Customer
                            .Where(c => c.name.Contains(SearchTB.Text) || c.surname.Contains(SearchTB.Text))
                            .ToList();
                        ListOfCustomerDGV.DataSource = customers;
                    }
                
            }
            else
            {   
                LoadCustomerData();
            }
        }

        private void ShowVehiclesListbtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
            String customer_id_str = (ListOfCustomerDGV.Rows[e.RowIndex].Cells["customer_id"].Value).ToString();
            String name = (ListOfCustomerDGV.Rows[e.RowIndex].Cells["name"].Value).ToString();
            String surname = (ListOfCustomerDGV.Rows[e.RowIndex].Cells["surname"].Value).ToString();

            Customer customer = Vlog.Customer.Find(Int32.Parse(customer_id_str));
            if (customer.approval_status == null || !(customer.approval_status.Value)) return;

            if (e.ColumnIndex == ListOfCustomerDGV.Columns["ShowVehiclesListbtn"].Index && e.RowIndex >= 0)
            {
                VehicleListForm vehiclesListForm = new VehicleListForm(customer_id_str, name, surname);
                vehiclesListForm.Show();
                this.Hide();
            }
        }

        private void DeleteCustomerbtn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ListOfCustomerDGV.Columns["DeleteCustomerbtn"].Index && e.RowIndex >= 0)
            {
            String customer_id_str = (ListOfCustomerDGV.Rows[e.RowIndex].Cells["customer_id"].Value).ToString();
            int id = Int32.Parse(customer_id_str);
            Customer customer = Vlog.Customer.Find(id);
            var vehicles = Vlog.Vehicle.Where(v => v.customer_id == id).ToList();

            foreach (var vehicle in vehicles)
            {
                var fuels = Vlog.Fuel.Where(f => f.vehicle_id == vehicle.vehicle_id).ToList();
                foreach (var fuel in fuels)
                {
                    Vlog.Fuel.Remove(fuel);
                }
                Vlog.Vehicle.Remove(vehicle);
            }

            Balance balance = Vlog.Balance.Where(f => f.customer_id == id).FirstOrDefault();
                
                if (balance != null)
                Vlog.Balance.Remove(balance);
                Vlog.Customer.Remove(customer);

                Vlog.SaveChanges();
                ListCustomerForm listCustomer = new ListCustomerForm();
                listCustomer.Show();
                this.Hide();
            }
            


        }
        private void BackToHomeB_Click(object sender, EventArgs e)
        {
            HomeF home = new HomeF();
            home.Show();
            this.Hide();
        }
        private void SearchTB_MouseClick(object sender, MouseEventArgs e)
        {
            if (SearchTB.Text == "Search For Customer")
            {
                SearchTB.Text = "";
                SearchTB.ForeColor = Color.Black;
            }
        }
        private void SearchTB_MouseLeave(object sender, EventArgs e)
        {
            if(SearchTB.Text == "")
            {
                SearchTB.Text = "Search For Customer";
                SearchTB.ForeColor = Color.Gray;
            }
        }

        private void BackToHomeB_Click_1(object sender, EventArgs e)
        {
            HomeF homeF = new HomeF();
            homeF.Show();
            this.Hide();
        }
    }
}
