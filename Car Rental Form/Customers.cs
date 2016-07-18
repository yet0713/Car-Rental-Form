using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Car_Rental_Form
{
    public partial class Customers : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        SqlConnection con = new SqlConnection("Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True");
        public Customers()
        {
            InitializeComponent();
        }

        private void labelrentals_Click(object sender, EventArgs e)
        {
           AddCustomer addcustomer = new AddCustomer();
            addcustomer.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AddCustomer addcustomer = new AddCustomer();
            addcustomer.Show();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection con = new SqlConnection("Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT [CustomerID] ,[FirstName],[LastName],[MiddleInitial],[Address],[EMailAddress],[ContactNo],[LicenseNo],[DateofBirth],[TypeofID],[LicenseExpiration] ,[LicenseReleasingOffice]FROM[dbo].[Customers]", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
    }


        int mousex = 0, mousey = 0;
        bool mouseDown;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mousex = MousePosition.X - 650;
                mousey = MousePosition.Y - 43;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlCommandBuilder scb;
        private void labelrefreshtable_Click(object sender, EventArgs e)
        {
            scb = new SqlCommandBuilder(sda);
            sda.Update(dt);

            SqlConnection con = new SqlConnection("Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT [CustomerID] ,[FirstName],[LastName],[MiddleInitial],[Address],[EMailAddress],[ContactNo],[LicenseNo],[DateofBirth],[TypeofID],[LicenseExpiration] FROM[dbo].[Customers]", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT[CustomerID],[FirstName],[LastName],[MiddleInitial],[Address],[EMailAddress],[ContactNo],[LicenseNo],[DateofBirth],[TypeofID],[LicenseExpiration] FROM Customers where CustomerID LIKE '" + textbox_search.Text + "%' OR FirstName LIKE '" + textbox_search.Text + "%' OR LastName LIKE '" + textbox_search.Text + "%'  OR MiddleInitial LIKE '" + textbox_search.Text + "%' OR Address LIKE '" + textbox_search.Text + "%' OR EmailAddress LIKE '" + textbox_search.Text + "%' OR ContactNo LIKE '" + textbox_search.Text + "%' OR LicenseNo LIKE '" + textbox_search.Text + "%' OR TypeofID LIKE '" + textbox_search.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
