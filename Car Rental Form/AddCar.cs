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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }


        private void AddCar_Load(object sender, EventArgs e)
        {


            this.combobox_yearmodel.SelectedIndex = 0;
            this.combobox_datepurchased_month.SelectedIndex = 0;
            this.combobox_datepurchased_day.SelectedIndex = 0;
            this.combobox_datepurchased_year.SelectedIndex = 0;
            this.combobox_lastcheckupdate_month.SelectedIndex = 0;
            this.combobox_lastcheckupdate_day.SelectedIndex = 0;
            this.combobox_lastcheckupdate_year.SelectedIndex = 0;
            this.combobox_condition.SelectedIndex = 0;
            this.combobox_rentaltype.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textboxcarmodel_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textboxcolor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxcarid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String carid = textbox_carbrand.Text + "_" + combobox_yearmodel.Text + "_" + textbox_carplateno.Text;
            String carbrand = textbox_carbrand.Text;
            String carplateno = textbox_carplateno.Text;
            String carmodel = textbox_carmodel.Text;
            String color = textbox_color.Text;
            String yearmodel = combobox_yearmodel.Text;
            String datepurchased = combobox_datepurchased_month.Text +"-"+ combobox_datepurchased_day.Text +"-"+ combobox_datepurchased_year.Text;
            String lastcheckupdate = combobox_lastcheckupdate_month.Text + "-" + combobox_lastcheckupdate_day.Text + "-" + combobox_lastcheckupdate_year.Text;
            String condition = combobox_condition.Text;

            String rentaltype = combobox_rentaltype.Text;
            String noofdays = textbox_noofdays.Text;
            String rentalfee = textbox_rentalfee.Text;
            String penaltyfee = textbox_penaltyfee.Text;
        
            SqlConnection con = new SqlConnection(@"Data Source=JASONLAPTOP\SQLEXPRESS;Initial Catalog = CarRental;Integrated Security=True");

            SqlCommand insert = new SqlCommand("insert into dbo.Cars(CarID, CarBrand, CarPlateNo, CarModel, Color, YearModel, DatePurchased, LastCheckupDate, Condition) values(@carid, @carbrand, @carplateno, @carmodel, @color, @yearmodel, @datepurchased, @lastcheckupdate, @condition)", con);
            insert.Parameters.AddWithValue("@carid", carid);
            insert.Parameters.AddWithValue("@carbrand", carbrand);
            insert.Parameters.AddWithValue("@carplateno", carplateno);
            insert.Parameters.AddWithValue("@carmodel", carmodel);
            insert.Parameters.AddWithValue("@color", color);
            insert.Parameters.AddWithValue("@yearmodel", yearmodel);
            insert.Parameters.AddWithValue("@datepurchased", datepurchased);
            insert.Parameters.AddWithValue("@lastcheckupdate", lastcheckupdate);
            insert.Parameters.AddWithValue("@condition",condition);


            SqlCommand insert1 = new SqlCommand("insert into dbo.Rentalinformation(CarID, RentalType, NoofDays, RentalFee, PenaltyFee) values(@carid, @rentaltype, @noofdays, @rentalfee, @penaltyfee)", con);
            insert1.Parameters.AddWithValue("@carid", carid);
            insert1.Parameters.AddWithValue("@rentaltype", rentaltype);
            insert1.Parameters.AddWithValue("@noofdays", noofdays);
            insert1.Parameters.AddWithValue("@rentalfee", rentalfee);
            insert1.Parameters.AddWithValue("@penaltyfee", penaltyfee);


            if (string.IsNullOrWhiteSpace(textbox_carbrand.Text) && string.IsNullOrWhiteSpace(textbox_carplateno.Text) && string.IsNullOrWhiteSpace(textbox_carmodel.Text))
            {
                MessageBox.Show("Car Brand, Plate Number and Year Model Can't be empty");
            }


            else
            {
                if (Convert.ToInt32(combobox_datepurchased_year.Text) >= Convert.ToInt32(combobox_yearmodel.Text))
                {
                    if (Convert.ToInt32(combobox_datepurchased_year.Text) <= Convert.ToInt32(combobox_lastcheckupdate_year.Text))
                    {
                        con.Open();
                        insert.ExecuteNonQuery();
                        insert1.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added");
                    }
                    else
                    {
                        MessageBox.Show("There's no Such thing as checking up a thing before purchasing something!");
                        con.Close();
                    }
                }

                else
                {
                    MessageBox.Show("There's no Such thing as buying something that is not yet released");
                }
            }
        }

        int mousex = 0, mousey = 0;
        bool mouseDown;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mousex = MousePosition.X - 344;
                mousey = MousePosition.Y - 37;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void textboxnoofdays_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxrentalfee_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxcolor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxnoofdays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxrentalfee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxpenaltyfee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxcarbrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}