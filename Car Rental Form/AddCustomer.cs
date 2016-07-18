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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }


        private void textboxcustomerid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxcustomerid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxfirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxmiddleinitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxcontactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxincaselastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxincasefirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxincaserelationship_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxincasecontactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }

        private void textboxincasecontactno_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            this.combobox_dateofbirth_month.SelectedIndex = 0;
            this.combobox_dateofbirth_day.SelectedIndex = 0;
            this.combobox_dateofbirth_year.SelectedIndex = 0;
            this.combobox_typeofid.SelectedIndex = 0;
            this.combobox_licenseexpiration_month.SelectedIndex = 0;
            this.combobox_licenseexpiration_day.SelectedIndex = 0;
            this.combobox_licenseexpiration_year.SelectedIndex = 0;
        }

        int mousex = 0, mousey = 0;
        bool mouseDown;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mousex = MousePosition.X - 361;
                mousey = MousePosition.Y - 42;
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String systemgeneratedcurrentdate;
            DateTime dt = new DateTime();
            dt = DateTime.Today;
            systemgeneratedcurrentdate = dt.ToShortDateString();

            String customerid = systemgeneratedcurrentdate + "_" + textbox_lastname.Text + "_" + textbox_contactno.Text;
            String firstname = textbox_firstname.Text;
            String lastname = textbox_lastname.Text;
            String middleinitial = textbox_middleinitial.Text;
            String address = textbox_address.Text;
            String emailaddress = textbox_emailaddress.Text;
            String contactno = textbox_contactno.Text;
            String licenseno = textbox_licenseno.Text;
            String dateofbirth = combobox_dateofbirth_month.Text + "-" + combobox_dateofbirth_day.Text + "-" + combobox_dateofbirth_year.Text;
            String typeofid = combobox_typeofid.Text;
            String licenseexpiration = combobox_licenseexpiration_month.Text + "-" + combobox_licenseexpiration_day.Text + "-" + combobox_licenseexpiration_year.Text;
            String licensereleasingoffice = textbox_licensereleasingoffice.Text;

            string emlastname = textbox_incase_lastname.Text;
            string emfirstname = textbox_incase_firstname.Text;
            string emrelationship = textbox_incase_relationship.Text;
            string emcontactno = textbox_incase_contactno.Text;

            SqlConnection con = new SqlConnection(@"Data Source=JASONLAPTOP\SQLEXPRESS;Initial Catalog = CarRental;Integrated Security=True");

            SqlCommand insert = new SqlCommand("insert into dbo.Customers(CustomerID, FirstName, LastName, MiddleInitial, Address, EMailAddress, ContactNo, LicenseNo, DateofBirth, TypeofID, LicenseExpiration, LicenseReleasingOffice) values(@customerid, @firstname, @lastname, @middleinitial, @address, @emailaddress, @contactno, @licenseno, @dateofbirth, @typeofid, @licenseexpiration, @licensereleasingoffice)", con);
            insert.Parameters.AddWithValue("@customerid", customerid);
            insert.Parameters.AddWithValue("@firstname", firstname);
            insert.Parameters.AddWithValue("@lastname", lastname);
            insert.Parameters.AddWithValue("@middleinitial", middleinitial);
            insert.Parameters.AddWithValue("@address", address);
            insert.Parameters.AddWithValue("@emailaddress", emailaddress);
            insert.Parameters.AddWithValue("@contactno", contactno);
            insert.Parameters.AddWithValue("@licenseno", licenseno);
            insert.Parameters.AddWithValue("@dateofbirth", dateofbirth);
            insert.Parameters.AddWithValue("@typeofid", typeofid);
            insert.Parameters.AddWithValue("@licenseexpiration", licenseexpiration);
            insert.Parameters.AddWithValue("@licensereleasingoffice", licensereleasingoffice);

            SqlCommand insert1 = new SqlCommand("insert into dbo.InCaseofEmergency(CustomerID, LastName, FirstName, Relationship, ContactNo) values(@customerid, @lastname, @firstname, @relationship, @contactno)", con);
            insert1.Parameters.AddWithValue("@customerid", customerid);
            insert1.Parameters.AddWithValue("@lastname", emlastname);
            insert1.Parameters.AddWithValue("@firstname", emfirstname);
            insert1.Parameters.AddWithValue("@relationship", emrelationship);
            insert1.Parameters.AddWithValue("@contactno", emcontactno);

            if (string.IsNullOrWhiteSpace(textbox_firstname.Text) && string.IsNullOrWhiteSpace(textbox_lastname.Text) && string.IsNullOrWhiteSpace(textbox_contactno.Text))
            {
                MessageBox.Show("Customer's First Name or Last Name and Contact Number can't be empty");
            }

            else
            {
                try
                {
                    con.Open();
                    insert.ExecuteNonQuery();
                    insert1.ExecuteNonQuery();
                    MessageBox.Show("Successfully Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                    con.Close();
                }
            }
        }
            

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
