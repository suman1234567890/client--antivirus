using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String serverip = "172.16.52.59";
            String serverport = "9000";
            DataSend ds = new DataSend(serverip, serverport);
            ds.sendData(@textBox1.Text);


        }
    }
}
