using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceContract;

namespace Client
{
    public partial class Form1 : Form
    {
        private MeteoServiceContract temperatureService;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Load temperature from Service layer
            temperatureService = new System.ServiceModel.ChannelFactory<ServiceContract.MeteoServiceContract>("meteoServiceEndpoint").CreateChannel();

            int temperature = temperatureService.GetTemperature();
            this.labelTemperature.Text = temperature.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
