using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;

namespace IHM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var service = Factory.Instance;
            RecipesGridView.DataSource = service.GetRecipes();
        }
    }

    public static class Factory
    {
        public static AbstractRecipeService Instance;
        static Factory()
        {
            var assemblyName = ConfigurationManager.AppSettings["AssemblyName"];
            var className = ConfigurationManager.AppSettings["ClassName"];
            Instance = (AbstractRecipeService)Activator.CreateInstance(assemblyName, className).Unwrap();
        }

    }
}
