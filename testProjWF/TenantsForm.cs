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
    public partial class TenantsForm : Form
    {
        BankBooks bankBooks = new BankBooks();

        public TenantsForm()
        {
            InitializeComponent();
            Init();
        }

        
        private void Init()
        {
            
            
            
        }       

     
        private void AddToGrid(string lastName,string firstName, string patronym, int id, DateTime startReg, DateTime endReg, LivingSpace livingSpace)
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
                    dt.Columns.Add("Фамилия", typeof(string));
                    dt.Columns.Add("Имя", typeof(string));
                    dt.Columns.Add("Отчество", typeof(string));
                    dt.Columns.Add("Дата начала регистрации", typeof(DateTime));
                    dt.Columns.Add("Дата конца регистрации", typeof(DateTime));
                    dt.Columns.Add("Адрес", typeof(string));
                }

                DataRow NewRow = dt.NewRow();
                NewRow[0] = id;
                NewRow[1] = lastName;
                NewRow[2] = firstName;
                NewRow[3] = patronym;
                NewRow[4] = startReg;
                NewRow[5] = endReg;
                NewRow[6] = livingSpace.Address;

                dt.Rows.Add(NewRow);
                dgvReside.DataSource = dt;
                dgvReside.Rows[dgvReside.Rows.Count - 1].Cells[6].Tag = livingSpace;
                CLearInput();
            
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!isConrolsEmpty())
            {
                int newid = 0;
                if (dgvReside.Rows.Count > 0)
                    newid = Convert.ToInt32(dgvReside.Rows[dgvReside.Rows.Count - 1].Cells[0].Value) + 1;
                AddToGrid(tbLastName.Text, tbFirstName.Text, tbPatronym.Text, newid,
                    dtStartReg.Value, dtEndReg.Value,
                (LivingSpace)cbLivingSpace.SelectedItem);
                LogChangeResidents(true);
            }
        }
        private void getSelectedRow()
        {
            try
            {
                tbId.Text = dgvReside.SelectedRows[0].Cells[0].Value.ToString();
                tbLastName.Text = dgvReside.SelectedRows[0].Cells[1].Value.ToString();
                tbFirstName.Text = dgvReside.SelectedRows[0].Cells[2].Value.ToString();
                tbPatronym.Text = dgvReside.SelectedRows[0].Cells[3].Value.ToString();
                dtStartReg.Value = (DateTime)dgvReside.SelectedRows[0].Cells[4].Value;
                dtEndReg.Value = (DateTime)dgvReside.SelectedRows[0].Cells[5].Value;

                for (int i = 0; i < cbLivingSpace.Items.Count; i++)
                {
                    if (((LivingSpace)dgvReside.SelectedRows[0].Cells[6].Tag).Id == ((LivingSpace)cbLivingSpace.Items[i]).Id)
                        cbLivingSpace.SelectedItem = cbLivingSpace.Items[i];
                }
            }
            catch
            {
                MessageBox.Show(dgvReside.SelectedRows[0].Cells[1].Value.ToString());
            }
     
            
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            getSelectedRow();
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            int currentRow = 0;
            try
            {
                currentRow = dgvReside.SelectedRows[0].Index;
            }
            catch
            {

            }
            if (currentRow > 0)
            {
                for (int i = 0; i < dgvReside.Rows.Count; i++)
                    dgvReside.Rows[i].Selected = false;
                dgvReside.Rows[--currentRow].Selected = true;
                getSelectedRow();
            }
          
        }
        private void btnRight_click(object sender, EventArgs e)
        {
            int currentRow = 0;
            try
            {
                currentRow = dgvReside.SelectedRows[0].Index;
            }
            catch
            {

            }
            if (currentRow < dgvReside.RowCount - 1)
            {
                for (int i = 0; i < dgvReside.Rows.Count; i++)
                    dgvReside.Rows[i].Selected = false;
                dgvReside.Rows[++currentRow].Selected = true;
                getSelectedRow();
            }
        }
        private void DeleteRecord(int id)
        {
            try
            {
                dgvReside.Rows.RemoveAt(id);
                CLearInput();
            }
            catch
            {
                MessageBox.Show("Попытка удаления несуществующей строки!");
            }
        }
        private void SaveBankBook()
        {

            SerializatorXML.SerializeToXML<BankBooks>(bankBooks, "BankBooks");
        }
      
        private void LogChangeResidents(bool isIncerement)
        {
            var bankList = bankBooks.bankBooks;
            for (int i = 0; i < bankList.Count; i++)
            {
                List<LogChange> logChange = bankList[i].logChanges.logChanges;
                int lastIndex = bankList[i].logChanges.logChanges.Count - 1;
                if (!isIncerement)
                {

                    if (bankList[i].responsiblePerson.id == Convert.ToInt32(dgvReside.SelectedRows[0].Cells[0].Value))
                    {

                        if (logChange[lastIndex].start == logChange[lastIndex].end)
                        {
                            logChange[lastIndex].end = DateTime.Now.AddDays(-1);
                            LogChange newlogChange = new LogChange(DateTime.Now, DateTime.Now, logChange[lastIndex].tariffs, logChange[lastIndex].countReside);

                            newlogChange.countReside--;
                            bankList[i].logChanges.logChanges.Add(newlogChange);
                            SaveBankBook();
                        }
                    }
                }
                else
                {
                    if (bankList[i].responsiblePerson.id == Convert.ToInt32(tbId.Text))
                        if (logChange[lastIndex].start == logChange[lastIndex].end)
                        {
                            logChange[lastIndex].end = DateTime.Now.AddDays(-1);
                            LogChange newlogChange = new LogChange(DateTime.Now, DateTime.Now, logChange[lastIndex].tariffs, logChange[lastIndex].countReside);

                            newlogChange.countReside++;
                            bankList[i].logChanges.logChanges.Add(newlogChange);
                            SaveBankBook();
                        }

                }
            }

        }
        private void deleteBtn(object sender, EventArgs e)
        {
            LogChangeResidents(false);
            DeleteRecord(dgvReside.SelectedRows[0].Index);
                
        }
        private void ChangeRecord(string lastName, string firstName, string patronym, int id, DateTime startReg, DateTime endReg, LivingSpace livingSpace)
        {
            if (!isConrolsEmpty())
            {
                try
                {
                    dgvReside.Rows[id].Cells[1].Value = lastName;
                    dgvReside.Rows[id].Cells[2].Value = firstName;
                    dgvReside.Rows[id].Cells[3].Value = patronym;
                    dgvReside.Rows[id].Cells[4].Value = startReg;
                    dgvReside.Rows[id].Cells[5].Value = endReg;
                    dgvReside.Rows[id].Cells[6].Value = livingSpace.Address;
                    dgvReside.Rows[id].Cells[6].Tag = livingSpace;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Show error occured:" + ex.Message + " - " + ex.Source);
                }
            }
        }
        private void changeRecordBtn(object sender, EventArgs e)
        {
            ChangeRecord(tbLastName.Text, tbFirstName.Text, tbPatronym.Text, dgvReside.SelectedRows[0].Index, dtStartReg.Value, dtEndReg.Value,
                (LivingSpace)cbLivingSpace.SelectedItem);
        }
        private void CLearInput()
        {
            tbFirstName.Text = String.Empty;
            tbLastName.Text = String.Empty;
            tbPatronym.Text = String.Empty;
            dtEndReg.Value = DateTime.Now;
            dtStartReg.Value = DateTime.Now;
            cbLivingSpace.SelectedIndex = -1;
            tbId.Text = dgvReside.Rows.Count.ToString();
        }
        private void Tenants_Load(object sender, EventArgs e)
        {
            GetData();
            LivingSpaces livingSpaces = new LivingSpaces();
            livingSpaces = SerializatorXML.DeserialiazeFromXML<LivingSpaces>("LivingSpaces");
            List<LivingSpace> list = new List<LivingSpace>();

            list = livingSpaces.livingSpaces;
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = list;
            cbLivingSpace.DataSource = bindingSource1.DataSource;
            cbLivingSpace.DisplayMember = "Address";
            cbLivingSpace.ValueMember = "Address";
            bankBooks = SerializatorXML.DeserialiazeFromXML<BankBooks>("BankBooks");
        }
        private void tbId_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvReside.Rows.Count; i++)
                dgvReside.Rows[i].Selected = false;
            try
            {
                dgvReside.Rows[Convert.ToInt32(tbId.Text)].Selected = true;
                getSelectedRow();
            }
            catch
            {}
           
        }
        private void SaveData()
        {
            Persons persons = new Persons();

            for (int i = 0; i < dgvReside.Rows.Count; i++)
            {
                int id = (int)dgvReside.Rows[i].Cells[0].Value;
                string lastName = (string)dgvReside.Rows[i].Cells[1].Value;
                string firstName = (string)dgvReside.Rows[i].Cells[2].Value;
                string patronym = (string)dgvReside.Rows[i].Cells[3].Value;
                DateTime dtStart = (DateTime)dgvReside.Rows[i].Cells[4].Value;
                DateTime dtEnd = (DateTime)dgvReside.Rows[i].Cells[5].Value;
                LivingSpace livingSpace = (LivingSpace)dgvReside.Rows[i].Cells[6].Tag;

                Person person = new Person(lastName, firstName, patronym, id, dtStart, dtEnd, livingSpace);
                persons.personList.Add(person);

            }
            SerializatorXML.SerializeToXML<Persons>(persons, "Persons");
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveData();
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
                }else if (control is ComboBox)
                {
                    if (((ComboBox)control).SelectedIndex==-1)
                    {
                        empty = true;
                        MessageBox.Show("Не все поля заполнены!");
                        break;
                    }
                }
            }
            return empty;
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
            Persons persons = new Persons();
            persons = SerializatorXML.DeserialiazeFromXML<Persons>("Persons");
            for (int i = 0; i < persons.personList.Count; i++)
            {
                AddToGrid(persons.personList[i].lastName, persons.personList[i].firstName, persons.personList[i].patronym, persons.personList[i].id,
                    persons.personList[i].startReside, persons.personList[i].endReside, persons.personList[i].livingSpace);
            }

        }
        private void getData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void cbLivingSpace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
