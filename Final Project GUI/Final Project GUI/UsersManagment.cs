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
    public partial class UsersManagment : Form
    {
        public UsersManagment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupFormUser popup = new PopupFormUser();
            DialogResult dialogresult = popup.ShowDialog();
            
            if (dialogresult == DialogResult.OK)
            {
                MessageBox.Show("User " +popup.UsernameTextBox.Text +" added to database");
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
                DialogResult result = MessageBox.Show("Are you sure?",
                "Important Question",
                MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            MessageBox.Show("user eran deleted!!");
                            break;
                        }
                }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsersManagment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.dataDataSet.Login);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.loginTableAdapter.FillBy(this.dataDataSet.Login);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
