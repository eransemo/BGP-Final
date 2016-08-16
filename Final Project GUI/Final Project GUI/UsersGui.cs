using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_GUI
{
    
    public partial class UsersGui : Form
    {
        private Login log = new Login();
        string fullPath;
        string justFileName;
        OpenFileDialog ofd = new OpenFileDialog();
        public UsersGui()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (fullPath != null)
            {
                String sub = justFileName.Substring(0, justFileName.Length - 2);
                String strCmdtxt = "/c cd tcc && tcc " + fullPath + " && " + sub + ".exe && exit";
                ProcessStartInfo psi = new ProcessStartInfo("CMD", strCmdtxt);

                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.CreateNoWindow = true;
                var proc = Process.Start(psi);

                String b = proc.StandardOutput.ReadToEnd();
                textBox1.Text = b;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.BackColor == Color.Red)
                label1.BackColor = UsersGui.DefaultBackColor;
            else
                label1.BackColor = Color.Red;

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            log.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ofd.Filter = "C|*.c";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilenameTextBox.Text = ofd.FileName;
                this.fullPath = ofd.FileName;
                this.justFileName = ofd.SafeFileName;
            }
            else
                this.fullPath = null;
        }
    }
}
