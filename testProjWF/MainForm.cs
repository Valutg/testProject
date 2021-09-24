using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testProjWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


      

       

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TenantsForm tenantsForm = new TenantsForm();
            tenantsForm.Show();
        }

        private void жилплощадьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LivingSpaceForm livingSpaceForm = new LivingSpaceForm();
            livingSpaceForm.Show();
        }

        private void поставщикиУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceProviderForm serviceProviderForm = new ServiceProviderForm();
            serviceProviderForm.Show();
        }

        private void платежиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BankBookForm bankBookForm = new BankBookForm();
            bankBookForm.Show();
        }

        private void картотекаЛицевыхСчетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccrualsForm accrualsForm = new AccrualsForm();
            accrualsForm.Show();
        }
    }
}
