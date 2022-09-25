using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Klasa_Process
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("WINWORD.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("iexplore.exe");
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Process.Start("EXCEL.exe");
        }

        private void buttonStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("iexplore.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";
            Process.Start(startInfo);
        }
    }
    
}
