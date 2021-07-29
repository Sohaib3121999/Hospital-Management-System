using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
namespace RegistrationOOP
{
    public partial class appointform : Form
    {
        

        //MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;,database=project");
        public appointform()
        {
            InitializeComponent();
            Grido.Columns.Add("A", "AID");
            Grido.Columns.Add("B", "PatientName");
            Grido.Columns.Add("C", "Phone-No");
            Grido.Columns.Add("D", "DoctorName");
            Grido.Columns.Add("E", "Speciality");
            Grido.Columns.Add("F", "Day");
            Grido.Columns.Add("G", "Time");
            Grido.Columns.Add("H", "Fees");
            //Grido.Columns.Add("I", "TokenNo");
           // Grido.Columns[0].Width = 50;
            Grido.Columns[1].Width = 200;
            Grido.Columns[2].Width = 150;
            Grido.Columns[3].Width = 200;
            Grido.Columns[4].Width = 200;
            Grido.Columns[5].Width = 200;
            Grido.Columns[6].Width = 200;
            Grido.Columns[6].Width = 160;
           // int aid=0;
            //GetUser();
            GetProducts();
        }

        private void GetProducts()
        {
            AutoCompleteStringCollection Arr = new AutoCompleteStringCollection();
            StreamReader SR = new StreamReader("Doctors.txt");
            while (!SR.EndOfStream)
            {
                Arr.Add(SR.ReadLine());
            }
            SR.Close();
            did.AutoCompleteCustomSource = Arr;
            did.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            did.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            


            if (e.KeyCode == Keys.Enter)
            {
                string[] A = did.Text.Split('@');
                did.Text = A[0];
                
                //fee.Text = A[2];

               // did.Clear();
               string day=(dateTimePicker1.Value.ToString("ddddd"));
               string time= (dateTimePicker1.Value.ToString("hh:mm:ss"));
                
                

                MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;database=project");
                MySqlCommand command;
                MySqlDataReader mdr;


                con.Open();

                //string get = "select * from doctors where Name like '" + dname.Text.Trim() + "'%'";
                string get = "select * from project.doctors where did=" + int.Parse(did.Text);
                command = new MySqlCommand(get, con);

                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    dname.Text = mdr.GetString("name");
                    spec.Text = mdr.GetString("speciality");
                    fee.Text = mdr.GetInt32("fee").ToString();
                }
                else
                {
                    MessageBox.Show("no record");
                }

                con.Close();

            }
                 
        }

        private void Grido_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult DR = MessageBox.Show("Are you sure to delete Patient Info?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                int i = Grido.CurrentRow.Index;
                Grido.Rows.RemoveAt(i);
            }








        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Invoice = DateTime.Now.ToString("HHmmss");
            string day = (dateTimePicker1.Value.ToString("ddddd"));
            string time = (dateTimePicker1.Value.ToString("hh:mm:ss"));
            string insert1 = "insert into project.appointment(aid,pname,phone_no,dname,speciality,day,time)values(" + Invoice + "," + '"' + patientname.Text.Trim() + '"' + "," + phoneno.Text.Trim() + "," + '"' + dname.Text.Trim() + '"' + "," + '"'  + spec.Text.Trim() + '"'  +","+'"' + day+'"'+","+ '"'+ time +'"'+ " )";

            MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;database=project");
            con.Open();
            MySqlCommand command = new MySqlCommand(insert1, con);
            invoice.Text = Invoice;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Please note your Invoice thanks");
            }
            else
            {
                MessageBox.Show("Command Failed");
            }

            con.Close();

            Grido.Rows.Add(Invoice,patientname.Text,phoneno.Text,dname.Text,spec.Text,day);
            patientname.Text = phoneno.Text = dname.Text = spec.Text = page.Text=did.Text=null;
           
        }

        public void appointform_Load(object sender, EventArgs e)
        {
            int asda = 1;
            StreamWriter ewp = new StreamWriter("aaid.txt");
            ewp.WriteLine(asda);
            ewp.Flush();
            ewp.Close();
        }

       

        private void patientname_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
            {
                MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;database=project");
                MySqlCommand command;
                MySqlDataReader mdr;

                con.Open();

                string getPatient = "select * from project.patient where pname="+'"' + patientname.Text + '"';

                command = new MySqlCommand(getPatient, con);

                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    //patientname.Text = mdr.GetString("Pname");
                    page.Text = mdr.GetInt32("page").ToString();
                    phoneno.Text = mdr.GetInt32("phoneno").ToString();
                }
                else
                {
                    MessageBox.Show("No record");
                }


                con.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            register es = new register();
            es.Show();
        }

        private void patientname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintDocument xDoc = new PrintDocument();
            xDoc.PrintPage += new PrintPageEventHandler(xDoc_PrintPage);
            PrintPreviewDialog PPD = new PrintPreviewDialog();
            PPD.Document = xDoc;
            PPD.Show();
        }
        private void xDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font F = new Font("Arial", 12, FontStyle.Regular);
            Brush B = Brushes.Black;
            e.Graphics.DrawImage(Image.FromFile("Logo1.gif"), 155, 1);
            e.Graphics.DrawString("FullName", F, B, 100, 110);
            e.Graphics.DrawString("doctorName", F, B, 200, 110);
            e.Graphics.DrawString("Speciality", F, B, 400, 110);
            e.Graphics.DrawString("day", F, B, 600, 110);
            e.Graphics.DrawString("time", F, B, 700, 110);

            
           
            int Y = 150;
            for (int i = 0; i < Grido.Rows.Count - 1; i++)
            {
                e.Graphics.DrawString(Grido.Rows[i].Cells[1].Value.ToString(), F, B, 100, Y); //FullName
                e.Graphics.DrawString(Grido.Rows[i].Cells[3].Value.ToString(), F, B, 200, Y); //Email
                e.Graphics.DrawString(Grido.Rows[i].Cells[4].Value.ToString(), F, B, 400, Y);
                e.Graphics.DrawString(Grido.Rows[i].Cells[5].Value.ToString(), F, B, 600, Y);
                e.Graphics.DrawString(Grido.Rows[i].Cells[6].Value.ToString(), F, B, 700, Y);
                
                
                

                e.Graphics.DrawLine(Pens.Black, 10, Y, 500, Y);
                Y = Y + 30;
            }
            e.Graphics.DrawLine(Pens.Black, 10, Y + 10, 620, Y + 10);

            // e.Graphics.DrawImage(Image.FromFile("Images//100.jpg"), 100, Y+10);
            patientname.Text = null;
            dname.Text = spec.Text = null;

            Grido.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Grido.Rows.Clear();
            
            

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            //string xLine = null;
            //string[] Arr;
            //StreamReader SR = new StreamReader("allpatientdata.txt");
            //while (SR.EndOfStream != true)
            //{
            //    xLine = SR.ReadLine();
            //    Arr = xLine.Split('$');
            //    Grido.Rows.Add(Arr[0],Arr[1]);

            //}
            //SR.Close();
        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            //string[] Arr;
            //StreamReader SR = new StreamReader("allpatientdatall.txt");
            //while (!SR.EndOfStream)
            //{
            //    Arr = SR.ReadLine().Split('$');
            //    Grido.Rows.Add(Arr[0]);
            //}
            //SR.Close();

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Invoice_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
