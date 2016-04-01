using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceHost sh = new ServiceHost(typeof(MeteoService));

        private void Form1_Load(object sender, EventArgs e)
        {
            sh.Open();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sh != null && sh.State != CommunicationState.Closed)
                sh.Close();
        }
    }
}
