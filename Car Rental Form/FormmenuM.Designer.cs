namespace Car_Rental_Form
{
    partial class FormmenuM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormmenuM));
            this.label_vehicles = new System.Windows.Forms.Label();
            this.label_rentals = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolstriptime = new System.Windows.Forms.ToolStripLabel();
            this.toolstripdate2 = new System.Windows.Forms.ToolStripLabel();
            this.label_signout = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.Label();
            this.label_addnewvehicle = new System.Windows.Forms.Label();
            this.label_addnewrentaltrans = new System.Windows.Forms.Label();
            this.label_rentalinfo = new System.Windows.Forms.Label();
            this.label_customers = new System.Windows.Forms.Label();
            this.label_addnewcustomer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_position = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_vehicles
            // 
            this.label_vehicles.AutoSize = true;
            this.label_vehicles.BackColor = System.Drawing.Color.Transparent;
            this.label_vehicles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_vehicles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vehicles.ForeColor = System.Drawing.Color.LightGray;
            this.label_vehicles.Location = new System.Drawing.Point(49, 159);
            this.label_vehicles.Name = "label_vehicles";
            this.label_vehicles.Size = new System.Drawing.Size(63, 15);
            this.label_vehicles.TabIndex = 1;
            this.label_vehicles.Text = "Vehicles";
            this.label_vehicles.Click += new System.EventHandler(this.labelvehicles_Click);
            // 
            // label_rentals
            // 
            this.label_rentals.AutoSize = true;
            this.label_rentals.BackColor = System.Drawing.Color.Transparent;
            this.label_rentals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_rentals.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rentals.ForeColor = System.Drawing.Color.Silver;
            this.label_rentals.Location = new System.Drawing.Point(413, 71);
            this.label_rentals.Name = "label_rentals";
            this.label_rentals.Size = new System.Drawing.Size(137, 15);
            this.label_rentals.TabIndex = 2;
            this.label_rentals.Text = "Rental Transactions";
            this.label_rentals.Click += new System.EventHandler(this.labelrentals_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstriptime,
            this.toolstripdate2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 372);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(64, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolstriptime
            // 
            this.toolstriptime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolstriptime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstriptime.Name = "toolstriptime";
            this.toolstriptime.Size = new System.Drawing.Size(31, 22);
            this.toolstriptime.Text = "time";
            this.toolstriptime.Click += new System.EventHandler(this.toolstriptime_Click);
            // 
            // toolstripdate2
            // 
            this.toolstripdate2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolstripdate2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripdate2.Name = "toolstripdate2";
            this.toolstripdate2.Size = new System.Drawing.Size(30, 22);
            this.toolstripdate2.Text = "date";
            // 
            // label_signout
            // 
            this.label_signout.AutoSize = true;
            this.label_signout.BackColor = System.Drawing.Color.Transparent;
            this.label_signout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_signout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_signout.ForeColor = System.Drawing.Color.Silver;
            this.label_signout.Location = new System.Drawing.Point(696, 383);
            this.label_signout.Name = "label_signout";
            this.label_signout.Size = new System.Drawing.Size(57, 14);
            this.label_signout.TabIndex = 4;
            this.label_signout.Text = "Sign Out";
            this.label_signout.Click += new System.EventHandler(this.labelsignout_Click);
            // 
            // usernametext
            // 
            this.usernametext.AutoSize = true;
            this.usernametext.BackColor = System.Drawing.Color.Transparent;
            this.usernametext.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernametext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametext.ForeColor = System.Drawing.Color.DarkGray;
            this.usernametext.Location = new System.Drawing.Point(366, 37);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(0, 15);
            this.usernametext.TabIndex = 2;
            this.usernametext.Click += new System.EventHandler(this.usernametext_Click);
            // 
            // label_addnewvehicle
            // 
            this.label_addnewvehicle.AutoSize = true;
            this.label_addnewvehicle.BackColor = System.Drawing.Color.Transparent;
            this.label_addnewvehicle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_addnewvehicle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addnewvehicle.ForeColor = System.Drawing.Color.LightGray;
            this.label_addnewvehicle.Location = new System.Drawing.Point(25, 183);
            this.label_addnewvehicle.Name = "label_addnewvehicle";
            this.label_addnewvehicle.Size = new System.Drawing.Size(114, 15);
            this.label_addnewvehicle.TabIndex = 1;
            this.label_addnewvehicle.Text = "Add new Vehicle";
            this.label_addnewvehicle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_addnewrentaltrans
            // 
            this.label_addnewrentaltrans.AutoSize = true;
            this.label_addnewrentaltrans.BackColor = System.Drawing.Color.Transparent;
            this.label_addnewrentaltrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_addnewrentaltrans.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addnewrentaltrans.ForeColor = System.Drawing.Color.Silver;
            this.label_addnewrentaltrans.Location = new System.Drawing.Point(296, 97);
            this.label_addnewrentaltrans.Name = "label_addnewrentaltrans";
            this.label_addnewrentaltrans.Size = new System.Drawing.Size(188, 15);
            this.label_addnewrentaltrans.TabIndex = 2;
            this.label_addnewrentaltrans.Text = "Add new Rental Transaction";
            this.label_addnewrentaltrans.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_rentalinfo
            // 
            this.label_rentalinfo.AutoSize = true;
            this.label_rentalinfo.BackColor = System.Drawing.Color.Transparent;
            this.label_rentalinfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_rentalinfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rentalinfo.ForeColor = System.Drawing.Color.Silver;
            this.label_rentalinfo.Location = new System.Drawing.Point(239, 71);
            this.label_rentalinfo.Name = "label_rentalinfo";
            this.label_rentalinfo.Size = new System.Drawing.Size(127, 15);
            this.label_rentalinfo.TabIndex = 2;
            this.label_rentalinfo.Text = "Rental Information";
            this.label_rentalinfo.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_customers
            // 
            this.label_customers.AutoSize = true;
            this.label_customers.BackColor = System.Drawing.Color.Transparent;
            this.label_customers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_customers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customers.ForeColor = System.Drawing.Color.Silver;
            this.label_customers.Location = new System.Drawing.Point(612, 159);
            this.label_customers.Name = "label_customers";
            this.label_customers.Size = new System.Drawing.Size(78, 15);
            this.label_customers.TabIndex = 3;
            this.label_customers.Text = "Customers";
            this.label_customers.Click += new System.EventHandler(this.labelcustomers_Click);
            // 
            // label_addnewcustomer
            // 
            this.label_addnewcustomer.AutoSize = true;
            this.label_addnewcustomer.BackColor = System.Drawing.Color.Transparent;
            this.label_addnewcustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_addnewcustomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addnewcustomer.ForeColor = System.Drawing.Color.Silver;
            this.label_addnewcustomer.Location = new System.Drawing.Point(585, 183);
            this.label_addnewcustomer.Name = "label_addnewcustomer";
            this.label_addnewcustomer.Size = new System.Drawing.Size(129, 15);
            this.label_addnewcustomer.TabIndex = 3;
            this.label_addnewcustomer.Text = "Add new Customer";
            this.label_addnewcustomer.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 42);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.BackColor = System.Drawing.Color.Transparent;
            this.label_position.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_position.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_position.ForeColor = System.Drawing.Color.Silver;
            this.label_position.Location = new System.Drawing.Point(366, 373);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(27, 15);
            this.label_position.TabIndex = 3;
            this.label_position.Text = ".....";
            this.label_position.Click += new System.EventHandler(this.positiontext_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(594, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Emergency Table";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FormmenuM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 397);
            this.Controls.Add(this.label_rentalinfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_signout);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.label_position);
            this.Controls.Add(this.label_addnewcustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_customers);
            this.Controls.Add(this.label_addnewrentaltrans);
            this.Controls.Add(this.label_addnewvehicle);
            this.Controls.Add(this.label_rentals);
            this.Controls.Add(this.label_vehicles);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormmenuM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Formmenu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_vehicles;
        private System.Windows.Forms.Label label_rentals;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolstriptime;
        private System.Windows.Forms.ToolStripLabel toolstripdate2;
        private System.Windows.Forms.Label label_signout;
        private System.Windows.Forms.Label usernametext;
        private System.Windows.Forms.Label label_addnewvehicle;
        private System.Windows.Forms.Label label_addnewrentaltrans;
        private System.Windows.Forms.Label label_rentalinfo;
        private System.Windows.Forms.Label label_customers;
        private System.Windows.Forms.Label label_addnewcustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label1;
    }
}