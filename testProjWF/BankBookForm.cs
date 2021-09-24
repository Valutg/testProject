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
    public partial class BankBookForm : Form
    {
        public BankBookForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        { 
            ServiceProviders serviceProviders = new ServiceProviders();
            serviceProviders = SerializatorXML.DeserialiazeFromXML<ServiceProviders>("Providers");
            List<ServiceProvider> listProviders = new List<ServiceProvider>();
            listProviders = serviceProviders.providerList;
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = listProviders;
            cbOrganization.DataSource = bindingSource1.DataSource;
            cbOrganization.DisplayMember = "Name";
            cbOrganization.ValueMember = "Name";

            Persons persons = new Persons();
            persons = SerializatorXML.DeserialiazeFromXML<Persons>("Persons");
            List<Person> listPersons = new List<Person>();
            listPersons = persons.personList;
            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = listPersons;
            cbResponsible.DataSource = bindingSource2.DataSource;     
            cbResponsible.DisplayMember = "fullName";
            cbResponsible.ValueMember = "fullName";
        }


        private void bankBookForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void Save()
        {
            BankBooks bankBooks = new BankBooks();

            for (int i = 0; i < dgvBook.Rows.Count; i++)
            {
                int id = (int)dgvBook.Rows[i].Cells[0].Value;
                ServiceProvider serviceProvider = (ServiceProvider)dgvBook.Rows[i].Cells[1].Tag;
                Person person = (Person)dgvBook.Rows[i].Cells[2].Tag;
                ServiceBalances serviceBalances = (ServiceBalances)dgvBook.Rows[i].Cells[3].Tag;

                LogChanges logChanges = (LogChanges)dgvBook.Rows[i].Cells[4].Tag;
                BankBook bankBook = new BankBook(id,  person, serviceProvider, serviceBalances,logChanges);
                bankBooks.bankBooks.Add(bankBook);

            }
            SerializatorXML.SerializeToXML<BankBooks>(bankBooks, "BankBooks");
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!isConrolsEmpty())
            {
                int newid = 0;
                ServiceProvider serviceProvider = (ServiceProvider)cbOrganization.SelectedItem;
                Person person = (Person)cbResponsible.SelectedItem;
                if (dgvBook.Rows.Count > 0)
                    newid = Convert.ToInt32(dgvBook.Rows[dgvBook.Rows.Count - 1].Cells[0].Value) + 1;
                ServiceBalances serviceBalances = new ServiceBalances();
                List<Tariff> tariffList = ((ServiceProvider)cbOrganization.SelectedItem).tariffs.tariffsList;
                for (int i = 0; i < tariffList.Count; i++)
                    serviceBalances.serviceBalances.Add(new ServiceBalance(tariffList[i].cost, tariffList[i].service, 0, 0));
                
                LogChanges logChanges = new LogChanges();
                LogChange logChange = new LogChange(DateTime.Now, DateTime.Now, serviceProvider.tariffs,getCountReside());
                logChanges.logChanges.Add(logChange);
                AddToGrid(Convert.ToInt32(tbId.Text), serviceProvider, person, serviceBalances,logChanges);
            }
        }

        private int getCountReside()
        {
            BankBooks bankBooks = new BankBooks();
            bankBooks = SerializatorXML.DeserialiazeFromXML<BankBooks>("BankBooks");
            int countReside = 0;
            int idaddress = bankBooks.bankBooks[Convert.ToInt32(tbId.Text)].responsiblePerson.livingSpace.Id;
            Persons persons = SerializatorXML.DeserialiazeFromXML<Persons>("Persons");
            var list = persons.personList;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].livingSpace.Id == idaddress)
                    countReside++;
            }
        
            return countReside;
        }
        private void AddToGrid(int id, ServiceProvider organization, Person responsible, ServiceBalances serviceBalances, LogChanges logChanges)
        {
            tbId.Text = id.ToString();
            DataTable dt;
            if (dgvBook.DataSource == null)
                dt = new DataTable();
            else
                dt = (DataTable)dgvBook.DataSource;
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Организация", typeof(string));
                dt.Columns.Add("Ответственный", typeof(string));
                dt.Columns.Add("Задолженность", typeof(string));
                dt.Columns.Add("Переплата", typeof(string));
            }

            
            

            DataRow NewRow = dt.NewRow();
            NewRow[0] = id;
            NewRow[1] = organization.Name;
            NewRow[2] = responsible.fullName;
            NewRow[3] = serviceBalances.getDebt();
            NewRow[4] = serviceBalances.getOverpay();
            
            dt.Rows.Add(NewRow);
            dgvBook.DataSource = dt;
            dgvBook.Rows[dgvBook.Rows.Count - 1].Cells[1].Tag = organization;
            dgvBook.Rows[dgvBook.Rows.Count - 1].Cells[2].Tag = responsible;
            dgvBook.Rows[dgvBook.Rows.Count - 1].Cells[3].Tag = serviceBalances;
            dgvBook.Rows[dgvBook.Rows.Count - 1].Cells[4].Tag = logChanges;

            ClearInput();
        }

        private void getSelectedRow()
        {
            try
            {
                tbId.Text = dgvBook.SelectedRows[0].Cells[0].Value.ToString();
                tbDebt.Text = ((ServiceBalances)dgvBook.SelectedRows[0].Cells[3].Tag).getDebt();
                tbOverpay.Text = ((ServiceBalances)dgvBook.SelectedRows[0].Cells[3].Tag).getOverpay();

                for (int i = 0; i < cbOrganization.Items.Count; i++)
                {
                    if (((ServiceProvider)dgvBook.SelectedRows[0].Cells[1].Tag).id == ((ServiceProvider)cbOrganization.Items[i]).id)
                        cbOrganization.SelectedItem = cbOrganization.Items[i];
                }
                for (int i = 0; i < cbResponsible.Items.Count; i++)
                {
                    if (((Person)dgvBook.SelectedRows[0].Cells[2].Tag).id == ((Person)cbResponsible.Items[i]).id)
                        cbResponsible.SelectedItem = cbResponsible.Items[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Show error occured:" + ex.Message + " - " + ex.Source);
            }
        }

        private void ClearInput()
        {
            cbOrganization.SelectedIndex = -1;
            cbResponsible.SelectedIndex = -1;
            tbId.Text = dgvBook.Rows.Count.ToString();
            tbDebt.Text = String.Empty;
            tbOverpay.Text = String.Empty;
            tbId.Text = dgvBook.Rows.Count.ToString();
        }
        private bool isConrolsEmpty()
        {
            bool empty = false;

            foreach (Control control in this.panel1.Controls)
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
        private void DeleteRecord(int id)
        {
            try
            {
                dgvBook.Rows.RemoveAt(id);
                ClearInput();
            }
            catch
            {
                MessageBox.Show("Попытка удаления несуществующей строки!");
            }
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            DeleteRecord(dgvBook.SelectedRows[0].Index);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getSelectedRow();
        }
        public void ClearRows(DataGridView dataGridView)
        {
            while (dataGridView.Rows.Count > 0)
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                    dataGridView.Rows.Remove(dataGridView.Rows[i]);
        }
        private void GetData()
        {
            ClearRows(dgvBook);
            dgvBook.Refresh();
            BankBooks bankBooks = new BankBooks();
            bankBooks = SerializatorXML.DeserialiazeFromXML<BankBooks>("BankBooks");
            for (int i = 0; i < bankBooks.bankBooks.Count; i++)
            {
                AddToGrid(bankBooks.bankBooks[i].accountNum,bankBooks.bankBooks[i].serviceProvider,bankBooks.bankBooks[i].responsiblePerson,
                    bankBooks.bankBooks[i].serviceBalances, bankBooks.bankBooks[i].logChanges);
            }

        }
        private void getDatabtn_Click(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
