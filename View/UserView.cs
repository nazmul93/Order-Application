using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace View
{
    public partial class UserView : Form, IUserView
    {
        public UserView()
        {
            InitializeComponent();
        }

        UserController _controller;

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            this._controller.Save();
        }

        private void gridOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(this.gridOrders.SelectedItems.Count > 0)
            //    this._controller.Sele
        }
        public void SetController(UserController controller)
        {
            _controller = controller;
        }

        public void ClearGrid()
        {
            // Define columns in grid
            this.gridOrders.Columns.Clear();

            this.gridOrders.Columns.Add("First name", 150, HorizontalAlignment.Left);
            this.gridOrders.Columns.Add("Last Name", 150, HorizontalAlignment.Left);
            this.gridOrders.Columns.Add("Phone Name", 150, HorizontalAlignment.Left);
            this.gridOrders.Columns.Add("Email", 150, HorizontalAlignment.Left);
            this.gridOrders.Columns.Add("Address", 150, HorizontalAlignment.Left);

            // Add rows to grid
            this.gridOrders.Items.Clear();
        }

        public void AddUserToGrid(User usr)
        {
            ListViewItem parent;
            parent = this.gridOrders.Items.Add(usr.FirstName);
            parent.SubItems.Add(usr.LastName);
            parent.SubItems.Add(usr.PhoneNo);
            parent.SubItems.Add(usr.Email);
            parent.SubItems.Add(usr.Address);
        }

        public string FirstName
        {
            get { return this.textBoxFirstName.Text; }
            set { this.textBoxFirstName.Text = value; }
        }

        public string LastName
        {
            get { return this.textBoxLastName.Text; }
            set { this.textBoxLastName.Text = value; }
        }

        public string PhoneNo
        {
            get { return this.textBoxPhone.Text; }
            set { this.textBoxPhone.Text = value; }
        }

        public string Email
        {
            get { return this.textBoxEmail.Text; }
            set { this.textBoxEmail.Text = value; }
        }

        public string Address
        {
            get { return this.textBoxAddress.Text; }
            set { this.textBoxAddress.Text = value; }
        }
        
    }
}
