using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindSystem.BLL;
using NorthwindSystem.Entities;

namespace DesktopApp
{
    public partial class ViewShippers : Form
    {
        public ViewShippers()
        {
            InitializeComponent();
        }

        private void btnLookupShipper_Click(object sender, EventArgs e)
        {
            try
            {   // get data from form
                if (cboShippers.SelectedIndex <= 0)
                {
                    MessageBox.Show("Please select a shipper before clicking [lookup]");
                }
                else
                {
                    int shipperId = Convert.ToInt32(cboShippers.SelectedValue);

                    NorthwindManager mgr = new NorthwindManager();
                    Shipper data = mgr.GetShipper(shipperId);

                    // unpack the data
                    ShipperId.Text = data.ShipperID.ToString();
                    CompanyName.Text = data.CompanyName;
                    Phone.Text = data.Phone;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                Shipper item = new Shipper()
                {
                    CompanyName = CompanyName.Text,
                    Phone = Phone.Text
                };
                var mgr = new NorthwindManager();
                item.ShipperID = mgr.AddShipper(item);
                // give some feedback to the user
                // - update my combo box
                // -my combo box has the right shipper selected
                // -display the id of the added shipper
                ShipperId.Text = item.ShipperID.ToString();
            }
            catch (Exception ex)
            {
                //throw;
               // TODO:  Add logging
                MessageBox.Show(ex.Message);
            }

        }

   
        private void ClearShipper_Click(object sender, EventArgs e)
        {

        }

        private void ViewShippers_Load(object sender, EventArgs e)
        {
            // Populate the combo box  - try refactor here, select and right click on xx - gives call
            try
            {
                PopulateShippersComboBox();
            }
            catch (Exception ex)
            {
                // TODO: Log the exception
                MessageBox.Show("Error:" + ex.Message, "Error Loading Form", MessageBoxButtons.OK);
                throw;
            }

        }

        private void PopulateShippersComboBox()
        {
            NorthwindManager manager = new NorthwindManager();
            var data = manager.ListShippers();
            data.Insert(0, new Shipper() { ShipperID = -1, CompanyName = "[select a shipper]" });
            cboShippers.DataSource = data;
            cboShippers.DisplayMember = "CompanyName"; // Co Name is a property on shiper entity"
            cboShippers.ValueMember = "ShipperID"; // Shipper id is th property that repr primary key unique id
            //cboShippers.Items.Insert(0, "[select a shipper]");
            cboShippers.SelectedIndex = 0;  // first item in the combo box
        }

        private void DeleteShipper_Click(object sender, EventArgs e)
        {
            try
            {
                int tempShipper;
                if (int.TryParse(ShipperId.Text, out tempShipper))
                {
                    // do the update...this is an initializer list, constructor runs, properties of the Shipper Object get values
                    var info = new Shipper()
                    {
                        ShipperID = tempShipper,
                        CompanyName = CompanyName.Text,
                        Phone = Phone.Text
                    };
                    var mgr = new NorthwindManager();
                    mgr.DeleteShipper(info);
                    PopulateShippersComboBox();
                    cboShippers.SelectedValue = info.ShipperID;
                }
                else
                {
                    MessageBox.Show("Please look up a shipper before trying to delete.");
                }
            }
            catch (Exception ex)
            {
                // TODO:  Update logging
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateShipper_Click(object sender, EventArgs e)
        {
            try
            {
                int tempShipper;
                if (int.TryParse(ShipperId.Text, out tempShipper))
                {
                    // do the update...this is an initializer list, constructor runs, properties of the Shipper Object get values
                    var info = new Shipper()
                    {
                        ShipperID = tempShipper,
                        CompanyName = CompanyName.Text,
                        Phone = Phone.Text
                    };
                    var mgr = new NorthwindManager();
                    mgr.UpdateShipper(info);
                    PopulateShippersComboBox();
                    cboShippers.SelectedValue = info.ShipperID;
                }
                else
                {
                    MessageBox.Show("Please look up a shipper before trying to update.");
                }
            }
            catch (Exception ex)
            {
                // TODO:  Update logging
                MessageBox.Show(ex.Message);
            }
        }

     
    }
}
