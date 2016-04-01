using ServiceContracts;
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
using DataContrats;

namespace Client
{
    public partial class Form1 : Form, IMeteoServiceCBC
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void PushData(List<MeteoData> lst)
        {
            dataGridView1.DataSource = lst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factory = new ChannelFactory<IMeteoService>("MyEP");

            var instance = factory.CreateChannel();

            MessageBox.Show(instance.GetTemperature("Toulouse").ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factory = new ChannelFactory<IMeteoService>("MyEP");

            var instance = factory.CreateChannel();

            dataGridView1.DataSource  = instance.GetTemperatures();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var factory = new DuplexChannelFactory<IMeteoService>(this, "MyEP");

            var instance = factory.CreateChannel();

            instance.AskTemperatures();

        }
    }
}
