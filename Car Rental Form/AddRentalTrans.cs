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
    public partial class AddRentalTrans : Form
    {
        public AddRentalTrans()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textboxcarid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxcarid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textboxcustomerid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxcustomerid_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textboxtotalnoofdays_KeyPress(object sender, KeyPressEventArgs e)
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

        private void AddRental_Load(object sender, EventArgs e)
        {
            this.combobox_dateborrowed_month.SelectedIndex = 0;
            this.combobox_dateborrowed_day.SelectedIndex = 0;
            this.combobox_dateborrowed_year.SelectedIndex = 0;
            this.combobox_datereturned_month.SelectedIndex = 0;
            this.combobox_datereturned_day.SelectedIndex = 0;
            this.combobox_datereturned_year.SelectedIndex = 0;
            this.combobox_carcondition.SelectedIndex = 0;
            this.combobox_penalty.SelectedIndex = 0;
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
                mousex = MousePosition.X - 175;
                mousey = MousePosition.Y - 36;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String rentalno = textbox_carid.Text + "_" + textbox_customerid.Text;
            String carid = textbox_carid.Text;
            String customerid = textbox_customerid.Text;
            String dateborrowed = combobox_dateborrowed_month.Text + "-" + combobox_dateborrowed_day.Text + "-" + combobox_dateborrowed_year.Text;
            String datereturned = combobox_datereturned_month.Text + "-" + combobox_datereturned_day.Text + "-" + combobox_datereturned_year.Text;
            String totalnoofdays = textbox_totalnoofdays.Text;
            String rentalfee = textbox_rentalfee.Text;
            String penaltyfee = combobox_penalty.Text;
            String carcondition = combobox_carcondition.Text;
            String note = textbox_note.Text;

            SqlConnection con = new SqlConnection(@"Data Source=JASONLAPTOP\SQLEXPRESS;Initial Catalog = CarRental;Integrated Security=True");

            SqlCommand insert = new SqlCommand("insert into dbo.RentalTransactionS(RentalNo, CarID, CustomerID, DateBorrowed, DateReturned, TotalnoofDays, RentalFee, PenaltyFee, CarCondition, Note) values(@rentalno, @carid, @customerid, @dateborrowed, @datereturned, @totalnoofdays, @rentalfee, @penaltyfee, @carcondition, @note)", con);
            insert.Parameters.AddWithValue("@rentalno", rentalno);
            insert.Parameters.AddWithValue("@carid", carid);
            insert.Parameters.AddWithValue("@customerid", customerid);
            insert.Parameters.AddWithValue("@dateborrowed", dateborrowed);
            insert.Parameters.AddWithValue("@datereturned", datereturned);
            insert.Parameters.AddWithValue("@totalnoofdays", totalnoofdays);
            insert.Parameters.AddWithValue("@rentalfee", rentalfee);
            insert.Parameters.AddWithValue("@penaltyfee", penaltyfee);
            insert.Parameters.AddWithValue("@carcondition", carcondition);

            if (string.IsNullOrWhiteSpace(textbox_carid.Text) && string.IsNullOrWhiteSpace(textbox_customerid.Text) && string.IsNullOrWhiteSpace(combobox_dateborrowed_month.Text) && string.IsNullOrWhiteSpace(combobox_dateborrowed_day.Text) && string.IsNullOrWhiteSpace(combobox_dateborrowed_year.Text) && string.IsNullOrWhiteSpace(combobox_datereturned_month.Text) && string.IsNullOrWhiteSpace(combobox_datereturned_day.Text) && string.IsNullOrWhiteSpace(combobox_datereturned_year.Text) && string.IsNullOrWhiteSpace(textbox_totalnoofdays.Text) && string.IsNullOrWhiteSpace(textbox_rentalfee.Text) && string.IsNullOrWhiteSpace(combobox_penalty.Text) && string.IsNullOrWhiteSpace(combobox_carcondition.Text))
            {
                MessageBox.Show("All fields can't be empty");
            }

            else
            {
                try
                {
                    con.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                    con.Close();
                }
            }
        }

        private void comboboxdatereturnedyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
    }

