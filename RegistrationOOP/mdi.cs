using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistrationOOP
{
    public partial class mdi : Form
    {
        public mdi()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            register l = new register();
            l.MdiParent = this;
            l.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            appointform ap = new appointform();
            ap.MdiParent = this;
            ap.Show();
        }

        private void searchAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sapp t = new sapp();
            t.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mdi_Load(object sender, EventArgs e)
        {

        }

        private void Allpatients_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;database=project");
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from project.appointment", con);
                con.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "users");
                dataGridView1.DataSource = ds.Tables["users"];
                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void Alldocs_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;database=project");
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from project.doctors", con);
                con.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "users");
                dataGridView1.DataSource = ds.Tables["users"];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;database=project");
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from project.patient", con);
                con.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "users");
                dataGridView1.DataSource = ds.Tables["users"];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
