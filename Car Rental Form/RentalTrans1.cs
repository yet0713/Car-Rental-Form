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
    public partial class RentalTrans1 : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        SqlConnection con = new SqlConnection("Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True");
        public RentalTrans1()
        {
            InitializeComponent();
        }

        private void RentalTrans1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            SqlConnection con = new SqlConnection("Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT [RentalNo] ,[CarID] ,[CustomerID] ,[DateBorrowed] ,[DateReturned] ,[TotalNoofDays] ,[RentalFee] ,[PenaltyFee] ,[CarCondition] FROM[dbo].[RentalTransactions]", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT [RentalNo],[CarID],[CustomerID],[DateBorrowed],[DateReturned],[TotalNoofDays],[RentalFee],[PenaltyFee],[CarCondition],[Note] FROM RentalTransactions where RentalNo LIKE '" + textbox_search.Text + "%' OR CarID LIKE '" + textbox_search.Text + "%' OR CustomerID LIKE '" + textbox_search.Text + "%'  OR DateBorrowed LIKE '" + textbox_search.Text + "%' OR DateReturned LIKE '" + textbox_search.Text + "%' OR TotalNoofDays LIKE '" + textbox_search.Text + "%' OR RentalFee LIKE '" + textbox_search.Text + "%' OR PenaltyFee LIKE '" + textbox_search.Text + "%' OR CarCondition LIKE '" + textbox_search.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label_newrentaltrans_Click(object sender, EventArgs e)
        {
            AddRentalTrans addrental = new AddRentalTrans();
            addrental.Show();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int mousex = 0, mousey = 0;
        bool mouseDown;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mousex = MousePosition.X - 480;
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
