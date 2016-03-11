using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHM
{
    public partial class FormReceipe : Form
    {
        public FormReceipe()
        {
            InitializeComponent();
            List<DataContract.Receipe> receipes = new Services.RecipeServices().getReceipes();
            foreach (var receipe in receipes)
            {
                this.bindingSource1.Add(receipe);
            }
            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.Refresh();
        }

        /*public static class Factory
        {
            public static AbstractRecipeService Instance;

            static Factory()
            {
                var assemblyName = ConfigurationManager.AppSettings["AssemblyName"];
                var className = ConfigurationManager.AppSettings["ClassName"];
                Instance = (AbstractRecipeService)Activator.CreateInstance(assemblyName, className);
            }
        }*/
    }
}
