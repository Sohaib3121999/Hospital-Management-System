using System;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace RegistrationOOP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtuser.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("datasource=localhost;port=3306;username=root;password=7595;database=project");
                MySqlDataAdapter adp;
                DataTable table = new DataTable();

                adp = new MySqlDataAdapter("select `username`, `password` from `login` where `username`='" + txtuser.Text + "' AND 'password'='" + txtPass.Text + "'", con);
                adp.Fill(table);

                mdi m = new mdi();
                //m.MdiParent = this;
                m.Show();


            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("RegNo or Password is invalid!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        

       

      

    }
}
