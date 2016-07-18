using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Car_Rental_Form
{
    public partial class UserLogIn222 : Form
    {
        public UserLogIn222()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string Username = Username_textbox.Text;
            string Password = Password_textbox.Text;

            /**//**/
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog=CarRental;Integrated Security=True";
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[CarRentalUsers] WHERE UserName = @Username AND Password = @password", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cmd.Parameters.Add(new SqlParameter("@Username", Username));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));

            DataTable dt = new DataTable();
            da.Fill(dt);
            /**//**/


            if (dt.Rows.Count > 0)
            {
                /**//**/
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "Data Source=JASONLAPTOP\\SQLEXPRESS;Initial Catalog = CarRental; Integrated Security=true";
                con1.Open();

                SqlParameter Parameters = new SqlParameter();
                string query1 = "SELECT [Position] FROM [dbo].[CarRentalUsers] WHERE UserName = @Username";
                SqlCommand command1 = new SqlCommand(query1, con1);

                command1.Parameters.Add(new SqlParameter("@Username", Username));
                string position = command1.ExecuteScalar().ToString();
                SqlDataReader reader1 = command1.ExecuteReader();
                /**//**/

                if (position.Contains("Manager"))
                {
                        FormmenuM FormMenuM = new FormmenuM();
                        FormMenuM.Show();
                        this.Close();
                }

                else if (position.Contains("Clerk"))
                {
                        FormMenuC FormmenuC = new FormMenuC();
                        FormmenuC.Show();
                        this.Close();
                }
            }

            else if (Username_textbox.Text == null || Password_textbox.Text == null)
            {
                LoginFailed loginfailed = new LoginFailed();
                loginfailed.Show();
            }
            else
            {
                LoginFailed loginfailed = new LoginFailed();
                loginfailed.Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();

            Application.Exit();
        }

        private void UserLogIn222_Load(object sender, EventArgs e)
        {

        }

        int mousex = 0, mousey = 0;
        bool mouseDown;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mousex = MousePosition.X - 256;
                mousey = MousePosition.Y - 33;
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

        private void Passwordtextbox_TextChanged(object sender, EventArgs e)
        {
           Password_textbox.PasswordChar = '*';
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
