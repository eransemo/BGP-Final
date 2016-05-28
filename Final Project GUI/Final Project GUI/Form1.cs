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
    
    public partial class Form1 : Form
    {
        string fullPath;
        string justFileName;
        OpenFileDialog ofd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (fullPath != null)
            {
                ProcessStartInfo psi = new ProcessStartInfo("CMD");
                psi.UseShellExecute = false;
                psi.RedirectStandardOutput = true;
                psi.CreateNoWindow = true;
                psi.RedirectStandardInput = true;
                var proc = Process.Start(psi);

                proc.StandardInput.WriteLine(@"cd C:\TC\bin");
                proc.StandardInput.WriteLine("tcc " + fullPath);
                string sub = justFileName.Substring(0, justFileName.Length - 2);
                proc.StandardInput.WriteLine(sub+".exe");
                proc.StandardInput.WriteLine("exit"); 
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
                label1.BackColor = Form1.DefaultBackColor;
            else
                label1.BackColor = Color.Red;

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

        }

        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
