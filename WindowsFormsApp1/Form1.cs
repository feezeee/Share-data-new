using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfControlLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {                       
            InitializeComponent();
           
        }
        int number_for_controls = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 userControl1 = new UserControl1();
            userControl1.ipPc = "192.168.1.1";
            userControl1.namePc = "denis";
            System.Windows.Forms.Integration.ElementHost elementHost = new System.Windows.Forms.Integration.ElementHost();
            elementHost.Tag = "elementHost" + number_for_controls;
            number_for_controls++;
            elementHost.Height = elementHost1.Height - 30;
            elementHost.Width = 120;
            elementHost.Child = userControl1;

            elementHost1.Controls.Add(elementHost);

            //cout++;
            //elementHost.Height = flowLayoutPanel1.Height - 30;

            //elementHost.Width = 120;

            //elementHost.Child = userControl1;
            //flowLayoutPanel1.Controls.Add(elementHost);
        }
    }
}
