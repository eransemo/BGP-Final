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
using System.Data;

namespace Final_Project_GUI
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\erans\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Login where Username='" + textBox1.Text + "' and password ='" + textBox2.Text + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1" && textBox1.Text == "admin")
            {
                this.Hide();

                SystemAdminGUI sag = new SystemAdminGUI();
                sag.Show();
            }
            else if (dt.Rows[0][0].ToString() == "1" && textBox1.Text == "yaron")
            {
                this.Hide();

                UsersGui fog = new UsersGui();
                fog.Show();
            }
            else
            {
                MessageBox.Show("Please Check your username and password");
            }
        }


    }
}
