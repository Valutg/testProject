using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace testProjWF
{
    public partial class ServiceProviderForm : Form
    {
        BankBooks bankBooks = new BankBooks();
        public ServiceProviderForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addTariffbtn_Click(object sender, EventArgs e)
        {
            DeleteFromList();
        }
        private void AddToGrid( int id, string name, Tariffs tariffs)
        {
            tbId.Text = id.ToString();
            DataTable dt;
            if (dgvReside.DataSource == null)
                dt = new DataTable();
            else
                dt = (DataTable)dgvReside.DataSource;
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Название", typeof(string));
                dt.Columns.Add("Услуги", typeof(string));
                
            }

            DataRow NewRow = dt.NewRow();
            NewRow[0] = id;
            NewRow[1] = name;
            
            NewRow[2] = tariffs;
            

            dt.Rows.Add(NewRow);
            dgvReside.DataSource = dt;
            dgvReside.Rows[dgvReside.Rows.Count - 1].Cells[2].Tag = tariffs;
            ClearInput();

        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!isConrolsEmpty())
            {
                int newid = 0;
                if (dgvReside.Rows.Count > 0)
                    newid = Convert.ToInt32(dgvReside.Rows[dgvReside.Rows.Count - 1].Cells[0].Value) + 1;
                Tariffs tariffs = new Tariffs();
                
                for (int i = 0; i < lvTariff.Items.Count; i++)
                {
                    tariffs.tariffsList.Add((Tariff)lvTariff.Items[i].Tag);
                }
                AddToGrid(newid, tbName.Text, tariffs);
                
            }
        }
        private void ClearInput()
        {
            tbPrice.Text = String.Empty;  
            tbName.Text = String.Empty;
            cbServices.SelectedIndex = -1;
            tbId.Text = dgvReside.Rows.Count.ToString();
            
            lvTariff.Items.Clear();
        }
        private bool isConrolsEmpty()
        {
            bool empty = false;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == "")
                    {
                        empty = true;
                        MessageBox.Show("Не все поля заполнены!");
                        break;
                    }
                }
                else if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedIndex == -1)
                    {
                        empty = true;
                        MessageBox.Show("Не все поля заполнены!");
                        break;
                    }
                }
            }
            return empty;
        }

        private void tbPatronym_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void ChangeRecord(int id, string name, Tariffs tariffs)
        {
            if (!isConrolsEmpty())
            {
                try
                {
                    dgvReside.Rows[id].Cells[1].Value = name;
                    dgvReside.Rows[id].Cells[2].Value = tariffs.ToString();  
                    dgvReside.Rows[id].Cells[2].Tag = tariffs;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Show error occured:" + ex.Message + " - " + ex.Source);
                }
            }
        }
        private void SaveBankBook()
        {

            SerializatorXML.SerializeToXML<BankBooks>(bankBooks, "BankBooks");
        }
        private void LogChangeTariff(Tariffs tariffs)
        {
            var bankList = bankBooks.bankBooks;
            for (int i = 0; i < bankList.Count; i++)
            {
                if (bankList[i].serviceProvider.id == Convert.ToInt32(dgvReside.SelectedRows[0].Cells[0].Value))
                {
                    List<LogChange> logChange = bankList[i].logChanges.logChanges;
                    int lastIndex = bankList[i].logChanges.logChanges.Count - 1;
                    if (logChange[lastIndex].start == logChange[lastIndex].end)
                    {
                        logChange[lastIndex].end = DateTime.Now.AddDays(-1);
                        LogChange newlogChange = new LogChange(DateTime.Now, DateTime.Now, tariffs, logChange[lastIndex].countReside);
                        
                    }
                }
            }
            SaveBankBook();

        }
        private void editBtn_Click(object sender, EventArgs e)
        {
           
            Tariffs tariffs = new Tariffs();

            for (int i = 0; i < lvTariff.Items.Count; i++)
            {
                tariffs.tariffsList.Add((Tariff)lvTariff.Items[i].Tag);
            }
            LogChangeTariff(tariffs);
            ChangeRecord(Convert.ToInt32(tbId.Text), tbName.Text, tariffs);
        }
        private void DeleteRecord(int id)
        {
            try
            {
                dgvReside.Rows.RemoveAt(id);
                ClearInput();
                Tariffs tariffs = new Tariffs();

                for (int i = 0; i < lvTariff.Items.Count; i++)
                {
                    tariffs.tariffsList.Add((Tariff)lvTariff.Items[i].Tag);
                }
                LogChangeTariff(tariffs);
            }
            catch
            {
                MessageBox.Show("Попытка удаления несуществующей строки!");
            }

        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            DeleteRecord(dgvReside.SelectedRows[0].Index);
        }

        private void lvTariff_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbLivingSpace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ServiceProviderForm_Load(object sender, EventArgs e)
        {
            bankBooks = SerializatorXML.DeserialiazeFromXML<BankBooks>("BankBooks");
            Services services = new Services();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = services.serviceList;
            cbServices.DataSource = bindingSource1.DataSource;
            cbServices.DisplayMember = "name";
            cbServices.ValueMember = "name";
            try
            {
                GetData();
            }
            catch { }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddToList(Convert.ToDecimal(tbPrice.Text), (Service)cbServices.SelectedItem);
            
            
        }
        private void AddToList(decimal cost, Service service)
        {
            Tariff tariff = new Tariff(cost, service);
            int index = lvTariff.Items.Count;
            lvTariff.Items.Add(tariff.service.name);
            lvTariff.Items[index].Tag = tariff;
        }
        private void DeleteFromList()
        {
            for (int i = lvTariff.Items.Count - 1; i >= 0; i--)
            {
                if (lvTariff.Items[i].Selected)
                {
                    lvTariff.Items[i].Remove();
                }
            }
            
        }

        private void getSelectedRow()
        {
            try
            {
                tbId.Text = dgvReside.SelectedRows[0].Cells[0].Value.ToString();
                tbName.Text = dgvReside.SelectedRows[0].Cells[1].Value.ToString();
                Tariffs tariffs = (Tariffs)dgvReside.SelectedRows[0].Cells[2].Tag;
                
                for (int i = 0; i < tariffs.tariffsList.Count; i++) 
                {

                    ListViewItem lvi = new ListViewItem(tariffs.tariffsList[i].service.name);
                    lvi.Tag = (Tariff)tariffs.tariffsList[i];
                    lvTariff.Items.Add(lvi);
                }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Show error occured:" + ex.Message + " - " + ex.Source);
            }
        }

        private void dgvReside_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearInput();
            getSelectedRow();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ((Tariff)lvTariff.SelectedItems[0].Tag).cost = Convert.ToDecimal(tbPrice.Text);
        }

        private void lvTariff_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvTariff.SelectedItems.Count> 0)
            {
                tbPrice.Text = ((Tariff)lvTariff.SelectedItems[0].Tag).cost.ToString();
            }
        }

        private void SaveData()
        {
            ServiceProviders serviceProviders = new ServiceProviders();

            for (int i = 0; i < dgvReside.Rows.Count; i++)
            {
                int id = (int)dgvReside.Rows[i].Cells[0].Value;
                string name = (string)dgvReside.Rows[i].Cells[1].Value;
                
                Tariffs tariffs = (Tariffs)dgvReside.Rows[i].Cells[2].Tag;
                MessageBox.Show(dgvReside.Rows[i].Cells[2].Tag.ToString());
                ServiceProvider serviceProvider = new ServiceProvider(id,name,tariffs);
                serviceProviders.providerList.Add(serviceProvider);

            }
            SerializatorXML.SerializeToXML<ServiceProviders>(serviceProviders, "Providers");
            
            
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        public void ClearRows(DataGridView dataGridView)
        {
            while (dataGridView.Rows.Count > 0)
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                    dataGridView.Rows.Remove(dataGridView.Rows[i]);
        }
        private void GetData()
        {
            ClearRows(dgvReside);
            dgvReside.Refresh();
            ServiceProviders providers = new ServiceProviders();
            providers = SerializatorXML.DeserialiazeFromXML<ServiceProviders>("Providers");
            for (int i = 0; i < providers.providerList.Count; i++)
            {
                AddToGrid(providers.providerList[i].id, providers.providerList[i].Name, providers.providerList[i].tariffs);
            }

        }
        private void getDatabtn_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
