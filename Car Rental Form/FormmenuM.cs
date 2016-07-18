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
    public partial class FormmenuM : Form
    {
        public FormmenuM()
        {
            InitializeComponent();
        }



        private void Formmenu_Load(object sender, EventArgs e)
        {
            DateTime dddttt = new DateTime();
            dddttt = DateTime.Now;
            toolstriptime.Text = dddttt.ToShortTimeString();

            DateTime ddtt = new DateTime();
            ddtt = DateTime.Today;
            toolstripdate2.Text = ddtt.ToLongDateString();

            string myConnectionString = "Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog = CarRental; Integrated Security=true";

            SqlCommand cmd = new SqlCommand("select Position from CarRentalUsers where UserName = 'CRDU1'", new SqlConnection(myConnectionString));
            cmd.Connection.Open();
            label_position.Text = cmd.ExecuteScalar().ToString();
            cmd.Connection.Close();


        }

        private void labelsignout_Click(object sender, EventArgs e)
        {
            this.Close();

            UserLogIn222 userlogin = new UserLogIn222();
            userlogin.Show();

        }
   

        private void labelvehicles_Click(object sender, EventArgs e)
        {
            Cars vehicle = new Cars();
            vehicle.Show();
        }

        private void labelrentals_Click(object sender, EventArgs e)
        {
            RentalTrans rentals = new RentalTrans();
            rentals.Show();
        }

        private void labelcustomers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
        }

        private void usernametext_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            AddCustomer addcustomer = new AddCustomer();
            addcustomer.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddRentalTrans addrentaltrans = new AddRentalTrans();
            addrentaltrans.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddCar addcar = new AddCar();
            addcar.Show();
        }

        private void toolstriptime_Click(object sender, EventArgs e)
        {

        }

        int mousex = 0, mousey = 0;
        bool mouseDown;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mousex = MousePosition.X - 380;
                mousey = MousePosition.Y - 56;
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

        private void label4_Click(object sender, EventArgs e)
        {
            RentalInfo rentalinfo = new RentalInfo();
            rentalinfo.Show();
        }

        private void positiontext_Click(object sender, EventArgs e)
        {

        }

        private void positiontext_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Emergency incaseemergency = new Emergency();
            incaseemergency.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
