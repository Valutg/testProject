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
    public partial class LivingSpaceForm : Form
    {
        public LivingSpaceForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            ClearInput();
            
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!isConrolsEmpty())
            {
                int newid = 0;
                if (dgvLivingSpace.Rows.Count>0)
                    newid = Convert.ToInt32(dgvLivingSpace.Rows[dgvLivingSpace.Rows.Count-1].Cells[0].Value) + 1;
                AddToGrid(tbAddress.Text, Convert.ToInt32(tbSquare.Text), newid);
            }
        }
        private void ClearInput()
        {
            tbAddress.Text = String.Empty;
            tbSquare.Text = String.Empty;
            tbId.Text = dgvLivingSpace.Rows.Count.ToString();
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
            }
            return empty;
        }
        private void AddToGrid(string address, double square, int id)
        {

            tbId.Text = id.ToString();
            DataTable dt;
            if (dgvLivingSpace.DataSource == null)
                dt = new DataTable();
            else
                dt = (DataTable)dgvLivingSpace.DataSource;
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Адрес", typeof(string));
                dt.Columns.Add("Площадь (кв.м.)", typeof(double));
                
            }

            DataRow NewRow = dt.NewRow();
            NewRow[0] = id;
            NewRow[1] = address;
            NewRow[2] = square;
     

            dt.Rows.Add(NewRow);
            dgvLivingSpace.DataSource = dt;
           
            ClearInput();

        }

        private void DeleteRecord(int id)
        {
            try
            {
                dgvLivingSpace.Rows.RemoveAt(id);
                ClearInput();
            }
            catch
            {
                MessageBox.Show("Попытка удаления несуществующей строки!");
            }
        }
        private void delBtn_Click(object sender, EventArgs e)
        {
            DeleteRecord(dgvLivingSpace.SelectedRows[0].Index);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            ChangeRecord(tbAddress.Text, Convert.ToInt32(tbSquare.Text),Convert.ToInt32(tbId.Text));
        }
        private void ChangeRecord(string address, double square,  int id)
        {
            if (!isConrolsEmpty())
            {
                try
                {
                    dgvLivingSpace.Rows[id].Cells[1].Value = address;
                    dgvLivingSpace.Rows[id].Cells[2].Value = square;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Show error occured:" + ex.Message + " - " + ex.Source);
                }
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int currentRow = 0;
            try
            {
                currentRow = dgvLivingSpace.SelectedRows[0].Index;
            }
            catch
            {

            }
            if (currentRow > 0)
            {
                for (int i = 0; i < dgvLivingSpace.Rows.Count; i++)
                    dgvLivingSpace.Rows[i].Selected = false;
                dgvLivingSpace.Rows[--currentRow].Selected = true;
                getSelectedRow();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int currentRow = 0;
            try
            {
                currentRow = dgvLivingSpace.SelectedRows[0].Index;
            }
            catch
            {

            }
            if (currentRow < dgvLivingSpace.RowCount - 1)
            {
                for (int i = 0; i < dgvLivingSpace.Rows.Count; i++)
                    dgvLivingSpace.Rows[i].Selected = false;
                dgvLivingSpace.Rows[++currentRow].Selected = true;
                getSelectedRow();
            }
        }
        private void getSelectedRow()
        {
            try
            {
                tbId.Text = dgvLivingSpace.SelectedRows[0].Cells[0].Value.ToString();
                tbAddress.Text = dgvLivingSpace.SelectedRows[0].Cells[1].Value.ToString();
                tbSquare.Text = dgvLivingSpace.SelectedRows[0].Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Show error occured:" + ex.Message + " - " + ex.Source);
            }
        }

        private void dgvLivingSpace_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getSelectedRow();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        private void SaveData()
        {
            LivingSpaces livingSpaces = new LivingSpaces();

            for (int i = 0; i < dgvLivingSpace.Rows.Count; i++)
            {
                int id = (int)dgvLivingSpace.Rows[i].Cells[0].Value;
                string address = (string)dgvLivingSpace.Rows[i].Cells[1].Value;
                double square = (double)dgvLivingSpace.Rows[i].Cells[2].Value;


                LivingSpace livingSpace = new LivingSpace(id, address, square);
                livingSpaces.livingSpaces.Add(livingSpace);

            }
            SerializatorXML.SerializeToXML<LivingSpaces>(livingSpaces, "LivingSpaces");
        }
        public void ClearRows(DataGridView dataGridView)
        {
            while (dataGridView.Rows.Count > 0)
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                    dataGridView.Rows.Remove(dataGridView.Rows[i]);
        }
        private void GetData()
        {
            ClearRows(dgvLivingSpace);
            dgvLivingSpace.Refresh();
            LivingSpaces livingSpaces = new LivingSpaces();
            livingSpaces = SerializatorXML.DeserialiazeFromXML<LivingSpaces>("LivingSpaces");
            for (int i = 0; i < livingSpaces.livingSpaces.Count; i++)
            {
                AddToGrid(livingSpaces.livingSpaces[i].Address, livingSpaces.livingSpaces[i].Square, livingSpaces.livingSpaces[i].Id);
            }
        }
        private void getDatabtn_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void LivingSpaceForm_Load(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
