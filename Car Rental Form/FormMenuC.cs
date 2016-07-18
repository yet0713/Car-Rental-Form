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
    public partial class FormMenuC : Form
    {
        public FormMenuC()
        {
            InitializeComponent();
        }

        private void toolstripdate2_Click(object sender, EventArgs e)
        {

        }

        private void toolstriptime_Click(object sender, EventArgs e)
        {

        }

        private void labelvehicles_Click(object sender, EventArgs e)
        {
            CarsC vehicle = new CarsC();
            vehicle.Show();
        }

        private void labelsignout_Click(object sender, EventArgs e)
        {
            this.Close();

            UserLogIn222 userlogin = new UserLogIn222();
            userlogin.Show();
        }

        private void FormMenuC_Load(object sender, EventArgs e)
        {

            string myConnectionString = "Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog = CarRental; Integrated Security=true";

            SqlCommand cmd = new SqlCommand("select Position from CarRentalUsers where UserName = 'CRDU2'", new SqlConnection(myConnectionString));
            cmd.Connection.Open();
            label_position.Text = cmd.ExecuteScalar().ToString();
            cmd.Connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddCar addcar = new AddCar();
            addcar.Show();
        }

        private void labelrentals_Click(object sender, EventArgs e)
        {
            RentalTrans1 rentals = new RentalTrans1();
            rentals.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddRentalTrans addrentaltrans = new AddRentalTrans();
            addrentaltrans.Show();
        }

        private void labelcustomers_Click(object sender, EventArgs e)
        {
            CustomersC customers = new CustomersC();
            customers.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AddCustomer addcustomer = new AddCustomer();
            addcustomer.Show();
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
                mousex = MousePosition.X - 370;
                mousey = MousePosition.Y - 39;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RentalInfo rentalinfo = new RentalInfo();
            rentalinfo.Show();
        }

        private void positiontext_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            EmergencyC incaseemergency = new EmergencyC();
            incaseemergency.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
