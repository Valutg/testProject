
namespace testProjWF
{
    partial class ServiceProviderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbServices = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.addTariffbtn = new System.Windows.Forms.Button();
            this.deleteTariffbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lvTariff = new System.Windows.Forms.ListView();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.getDatabtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvReside = new System.Windows.Forms.DataGridView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReside)).BeginInit();
            this.SuspendLayout();
            // 
            // cbServices
            // 
            this.cbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServices.FormattingEnabled = true;
            this.cbServices.Location = new System.Drawing.Point(15, 26);
            this.cbServices.Name = "cbServices";
            this.cbServices.Size = new System.Drawing.Size(304, 24);
            this.cbServices.TabIndex = 19;
            this.cbServices.SelectedIndexChanged += new System.EventHandler(this.cbLivingSpace_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Услуги";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(679, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Название организации";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.addTariffbtn);
            this.panel1.Controls.Add(this.deleteTariffbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.lvTariff);
            this.panel1.Controls.Add(this.cbServices);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Location = new System.Drawing.Point(668, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 295);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // addTariffbtn
            // 
            this.addTariffbtn.Location = new System.Drawing.Point(239, 111);
            this.addTariffbtn.Name = "addTariffbtn";
            this.addTariffbtn.Size = new System.Drawing.Size(92, 29);
            this.addTariffbtn.TabIndex = 24;
            this.addTariffbtn.Text = "Добавить";
            this.addTariffbtn.UseVisualStyleBackColor = true;
            this.addTariffbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteTariffbtn
            // 
            this.deleteTariffbtn.Location = new System.Drawing.Point(141, 111);
            this.deleteTariffbtn.Name = "deleteTariffbtn";
            this.deleteTariffbtn.Size = new System.Drawing.Size(92, 29);
            this.deleteTariffbtn.TabIndex = 23;
            this.deleteTariffbtn.Text = "Удалить";
            this.deleteTariffbtn.UseVisualStyleBackColor = true;
            this.deleteTariffbtn.Click += new System.EventHandler(this.addTariffbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Стоимость за ед. измерения:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(142, 83);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(198, 22);
            this.tbPrice.TabIndex = 21;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // lvTariff
            // 
            this.lvTariff.HideSelection = false;
            this.lvTariff.Location = new System.Drawing.Point(14, 65);
            this.lvTariff.Name = "lvTariff";
            this.lvTariff.Size = new System.Drawing.Size(121, 167);
            this.lvTariff.TabIndex = 20;
            this.lvTariff.UseCompatibleStateImageBehavior = false;
            this.lvTariff.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvTariff_ItemSelectionChanged);
            this.lvTariff.SelectedIndexChanged += new System.EventHandler(this.lvTariff_SelectedIndexChanged);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(0, 237);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(107, 42);
            this.delBtn.TabIndex = 14;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(113, 237);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(122, 42);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(244, 237);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(107, 42);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // getDatabtn
            // 
            this.getDatabtn.Location = new System.Drawing.Point(784, 489);
            this.getDatabtn.Name = "getDatabtn";
            this.getDatabtn.Size = new System.Drawing.Size(122, 42);
            this.getDatabtn.TabIndex = 23;
            this.getDatabtn.Text = "Получить";
            this.getDatabtn.UseVisualStyleBackColor = true;
            this.getDatabtn.Click += new System.EventHandler(this.getDatabtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(915, 489);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 42);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Поставщики услуг:";
            // 
            // dgvReside
            // 
            this.dgvReside.AllowUserToAddRows = false;
            this.dgvReside.AllowUserToDeleteRows = false;
            this.dgvReside.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvReside.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvReside.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReside.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReside.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReside.Location = new System.Drawing.Point(12, 31);
            this.dgvReside.Name = "dgvReside";
            this.dgvReside.ReadOnly = true;
            this.dgvReside.RowHeadersWidth = 51;
            this.dgvReside.RowTemplate.Height = 24;
            this.dgvReside.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReside.Size = new System.Drawing.Size(630, 422);
            this.dgvReside.TabIndex = 18;
            this.dgvReside.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReside_CellClick);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(683, 121);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(325, 22);
            this.tbName.TabIndex = 8;
            this.tbName.TextChanged += new System.EventHandler(this.tbPatronym_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(679, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Id";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(683, 76);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(325, 22);
            this.tbId.TabIndex = 25;
            this.tbId.Text = "0";
            // 
            // ServiceProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.getDatabtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvReside);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Name = "ServiceProviderForm";
            this.Text = "ServiceProviderForm";
            this.Load += new System.EventHandler(this.ServiceProviderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReside)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbServices;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button getDatabtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvReside;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button deleteTariffbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ListView lvTariff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button addTariffbtn;
        private System.Windows.Forms.Button button1;
    }
}