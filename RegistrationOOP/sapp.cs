using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistrationOOP
{
    public partial class sapp : Form
    {
        public sapp()
        {
            InitializeComponent();
            GetDataa();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void GetDataa()
        {
            AutoCompleteStringCollection Arr = new AutoCompleteStringCollection();
            StreamReader SR = new StreamReader("allpatientdata.txt");
            while (!SR.EndOfStream)
            {
                Arr.Add(SR.ReadLine());
            }
            SR.Close();
            sss.AutoCompleteCustomSource = Arr;
            sss.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            sss.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void sss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                /*string[] L = sss.Text.Split('$');

                label2.Text = L[0];
                label3.Text = L[1];
                label4.Text = L[2];
                label5.Text = L[3];
                label6.Text = L[4];
                label7.Text = L[5];*/
                MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;database=project");
                MySqlCommand command;
                MySqlDataReader mdr;


                con.Open();

                //string get = "select * from doctors where Name like '" + dname.Text.Trim() + "'%'";
                string get = "select * from project.appointment where aid=" + int.Parse(sss.Text);
                command = new MySqlCommand(get, con);

                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    name.Text = mdr.GetString("pname");
                    phone.Text = mdr.GetInt32("phone_no").ToString();
                    dname.Text = mdr.GetString("dname");
                    spec.Text = mdr.GetString("speciality");
                    day.Text = mdr.GetString("day");
                    time.Text = mdr.GetString("time");
                }
                else
                {
                    MessageBox.Show("no record against invoice"+" "+"#"+ sss.Text);
                    sss.Text = null;
                }

                con.Close();

            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            
             
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;database=project");

            string deleteQuery = "Delete from project.appointment where aid=" + sss.Text;
            con.Open();
            MySqlCommand command = new MySqlCommand(deleteQuery, con);

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Appointment deleted");
                name.Text = dname.Text = phone.Text = spec.Text = day.Text = time.Text = null;
            }
            else
            {
                MessageBox.Show("Appointment already deleted");
            }

            con.Close();
        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            

            MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;database=project");

            if (upname.Text.Length != 0)
            {
                string updateQuery = "update project.appointment set pname='" + this.upname.Text + "',phone_no='" + int.Parse(this.phoneno.Text) + "',dname='" + this.doctorname.Text + "',speciality='" + this.specia.Text + "',day='" + this.dayup.Text + "' where aid='" + int.Parse(this.sss.Text) + "';";
                con.Open();
                MySqlCommand command = new MySqlCommand(updateQuery, con);
                //testt1.Text = updateQuery;
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Appointment updated successfully");
                }
                else
                {
                    MessageBox.Show("not updated");
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("please Click Get button to retrive Data");
                button2.Focus();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            upname.Text = name.Text;
            phoneno.Text = phone.Text;
            doctorname.Text = dname.Text;
            specia.Text = spec.Text;
            dayup.Text = day.Text;

            name.Text = phone.Text = dname.Text = spec.Text = day.Text = null;
            upname.Focus();
        }
    }


    }

