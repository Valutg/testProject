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
    public partial class AccrualsForm : Form
    {
        private BankBooks bankBooks = new BankBooks();
        public AccrualsForm()
        {
            InitializeComponent();
        }


        private void GetData()
        {
                  
            bankBooks = SerializatorXML.DeserialiazeFromXML<BankBooks>("BankBooks");

        }
        private void AccrualsForm_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void UpdateGrid()
        {
            DataTable dt;
            if (dgvBook.DataSource == null)
                dt = new DataTable();
            else
                dt = (DataTable)dgvBook.DataSource;
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("Услуга: ", typeof(string));
                dt.Columns.Add("Тариф: ", typeof(decimal));
               
            }
            List<ServiceBalance> listService = new List<ServiceBalance>();

            listService = bankBooks.bankBooks[Convert.ToInt32(tbId.Text)].serviceBalances.serviceBalances;
            DataRow NewRow = dt.NewRow();
            for (int i = 0; i < listService.Count; i++)
            {
                NewRow[0] = listService[i].service.name;
                NewRow[1] = listService[i].cost;



            }

            dt.Rows.Add(NewRow);
            dgvBook.DataSource = dt;



        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            bool empty = false;
            try
            {
                if (bankBooks.bankBooks[Convert.ToInt32(tbId.Text)] != null)
                {
                    empty = false;
                }
            }
            catch
            {
                empty = true;
            }
            if (tbId.Text != String.Empty && !empty)
            {
                UpdateGrid();

                lbProvider.Text = "Поставщик: " + bankBooks.bankBooks[Convert.ToInt32(tbId.Text)].serviceProvider.Name;
                lbAddress.Text = "Адрес: " + bankBooks.bankBooks[Convert.ToInt32(tbId.Text)].responsiblePerson.livingSpace.Address;
                lbResponsible.Text = "Ответственный: " + bankBooks.bankBooks[Convert.ToInt32(tbId.Text)].responsiblePerson.fullName;
                int countReside = 0;
                int idaddress = bankBooks.bankBooks[Convert.ToInt32(tbId.Text)].responsiblePerson.livingSpace.Id;
                Persons persons = SerializatorXML.DeserialiazeFromXML<Persons>("Persons");
                var list = persons.personList;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].livingSpace.Id == idaddress)
                        countReside++;
                }
                lbCountReside.Text = "Количество проживающих: " + countReside.ToString();



            }
        }

        private void SumUpPeriods(int id)
        {
            var listBankBooks = bankBooks.bankBooks;
            for (int i = 0; i < listBankBooks[id].serviceBalances.serviceBalances.Count; i++)
            {

                decimal overpay = bankBooks.bankBooks[id].serviceBalances.serviceBalances[i].overpay;
                decimal debt = bankBooks.bankBooks[id].serviceBalances.serviceBalances[i].debt;
                decimal sum = 0;
                for (int j = 0; j < listBankBooks[id].logChanges.logChanges.Count; j++)
                {
                    DateTime start=listBankBooks[id].logChanges.logChanges[j].start;
                    DateTime end = listBankBooks[id].logChanges.logChanges[j].end;
                    DateTime startReg = listBankBooks[id].responsiblePerson.startReside;
                    DateTime minusMonth = DateTime.Now.AddDays(-(int)DateTime.Now.Month);
                    if (start < minusMonth && startReg >= minusMonth)
                        start = minusMonth;
                    else if (start < minusMonth && startReg >= minusMonth)
                        start = startReg;
                    if (start == end)
                        end = DateTime.Now;
                    for (var d=start; end.CompareTo(d) > 0; d=d.AddDays(1.0))
                    {
                        sum += listBankBooks[id].serviceBalances.serviceBalances[i].cost * listBankBooks[id].logChanges.logChanges[j].countReside;
                    }
                }


                if (sum >= 0)
                {
                    listBankBooks[id].serviceBalances.serviceBalances[i].debt += debt - overpay + sum;
                    listBankBooks[id].serviceBalances.serviceBalances[i].overpay = 0;
                }
                else
                {
                    listBankBooks[id].serviceBalances.serviceBalances[i].overpay = overpay - debt + sum;
                    listBankBooks[id].serviceBalances.serviceBalances[i].debt = 0;
                }
            }

            SaveBankBook();
        }

        private void SaveBankBook()
        {
     
            SerializatorXML.SerializeToXML<BankBooks>(bankBooks, "BankBooks");
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            SumUpPeriods(Convert.ToInt32(tbId.Text));
            string message = "Выполнено начисление по аккаунту " + bankBooks.bankBooks[Convert.ToInt32(tbId.Text)].responsiblePerson.fullName;
            MessageBox.Show(message);
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
