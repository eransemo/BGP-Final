using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_GUI
{
    public partial class SystemAdminGUI : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        private Login log = new Login();

        public SystemAdminGUI()
        {
            InitializeComponent();
            
        }

  


        private void button1_Click_1(object sender, EventArgs e)
        {
            UsersManagment users = new UsersManagment();
            users.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TopologyManagment topo = new TopologyManagment();
            topo.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            log.Show();
        }
    }
}
