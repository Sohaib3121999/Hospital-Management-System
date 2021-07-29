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
    public partial class register : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;,database=project");

        public register()
        {
            InitializeComponent();
        }
        private void register_Load(object sender, EventArgs e)
        {   
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //mdi o = new mdi();
            //o.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = DateTime.Now.ToString("yyyyHHmmss");
            txtID.Text = ID;

            

            string insert = "insert into project.patient(pid,pname,Page,address,phoneno)values(" + ID + "," + '"'+ txtname.Text.Trim()+ '"' + "," + txtage.Text.Trim() + "," + '"' + txtadd.Text.Trim() + '"' + "," + txtPhone.Text.Trim() + " )";

            MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;database=project");
            con.Open();
            MySqlCommand command = new MySqlCommand(insert, con);
            
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Save");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }

            con.Close();

            if (txtID.Text.Length == 0 || txtname.Text.Length == 0 || txtage.Text.Length == 0 || txtadd.Text.Length == 0 )
            {
                DialogResult DR = MessageBox.Show("Please fill your information", "Error", MessageBoxButtons.OK);
                if (DR == DialogResult.OK)
                {
                    txtname.Focus();

                }
            }
            this.Hide();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
        }

        private class MySqlConnection
        {
            private string v;

            public MySqlConnection(string v)
            {
                this.v = v;
            }

            internal void Open()
            {
                throw new NotImplementedException();
            }
        }
    }
}
