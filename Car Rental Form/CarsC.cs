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
    public partial class CarsC : Form
    {
        SqlDataAdapter sda;
        DataTable dt;

        SqlConnection con = new SqlConnection("Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True");
        public CarsC()
        {
            InitializeComponent();
        }

        private void CarsC_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            sda = new SqlDataAdapter("SELECT [CarID], [CarBrand], [CarPlateNo], [Color], [YearModel], [DatePurchased], [LastCheckupDate], [Condition] FROM[dbo].Cars", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_addnewvehicle_Click(object sender, EventArgs e)
        {
            AddCar addcar = new AddCar();
            addcar.Show();
        }

        private void textbox_search_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT [CarID], [CarBrand], [CarPlateNo], [Color], [YearModel], [DatePurchased], [LastCheckupDate], [Condition] FROM Cars where CarID LIKE '" + textbox_search.Text + "%' OR CarBrand LIKE '" + textbox_search.Text + "%' OR CarPlateNo LIKE '" + textbox_search.Text + "%'  OR Color LIKE '" + textbox_search.Text + "%' OR YearModel LIKE '" + textbox_search.Text + "%' OR Condition LIKE '" + textbox_search.Text + "%' ", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
