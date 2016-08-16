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
    public partial class TopologyManagment : Form
    {
        public TopologyManagment()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "C|*.c";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string s = ofd.SafeFileName;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        MessageBox.Show("Topology eran deleted!!");
                        break;
                    }
            }
        }
    }
}
