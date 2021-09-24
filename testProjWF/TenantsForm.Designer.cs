
namespace testProjWF
{
    partial class TenantsForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLivingSpace = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.dtEndReg = new System.Windows.Forms.DateTimePicker();
            this.dtStartReg = new System.Windows.Forms.DateTimePicker();
            this.tbPatronym = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvReside = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.getDatabtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReside)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(247, 346);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(107, 42);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(22, 122);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(304, 22);
            this.tbFirstName.TabIndex = 4;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Имя:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(22, 77);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(304, 22);
            this.tbLastName.TabIndex = 0;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фамилия:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.cbLivingSpace);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.lbEndDate);
            this.panel1.Controls.Add(this.lbStartDate);
            this.panel1.Controls.Add(this.dtEndReg);
            this.panel1.Controls.Add(this.dtStartReg);
            this.panel1.Controls.Add(this.tbPatronym);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(668, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 396);
            this.panel1.TabIndex = 7;
            // 
            // cbLivingSpace
            // 
            this.cbLivingSpace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLivingSpace.FormattingEnabled = true;
            this.cbLivingSpace.Location = new System.Drawing.Point(22, 216);
            this.cbLivingSpace.Name = "cbLivingSpace";
            this.cbLivingSpace.Size = new System.Drawing.Size(304, 24);
            this.cbLivingSpace.TabIndex = 19;
            this.cbLivingSpace.SelectedIndexChanged += new System.EventHandler(this.cbLivingSpace_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Жилая площадь:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Id:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(22, 32);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(304, 22);
            this.tbId.TabIndex = 15;
            this.tbId.Text = "0";
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(116, 346);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(122, 42);
            this.delBtn.TabIndex = 14;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.deleteBtn);
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(19, 286);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(176, 17);
            this.lbEndDate.TabIndex = 12;
            this.lbEndDate.Text = "Дата конца регистрации:";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(19, 241);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(185, 17);
            this.lbStartDate.TabIndex = 11;
            this.lbStartDate.Text = "Дата начала регистрации:";
            // 
            // dtEndReg
            // 
            this.dtEndReg.Location = new System.Drawing.Point(22, 306);
            this.dtEndReg.Name = "dtEndReg";
            this.dtEndReg.Size = new System.Drawing.Size(200, 22);
            this.dtEndReg.TabIndex = 10;
            // 
            // dtStartReg
            // 
            this.dtStartReg.Location = new System.Drawing.Point(22, 261);
            this.dtStartReg.Name = "dtStartReg";
            this.dtStartReg.Size = new System.Drawing.Size(200, 22);
            this.dtStartReg.TabIndex = 9;
            // 
            // tbPatronym
            // 
            this.tbPatronym.Location = new System.Drawing.Point(22, 167);
            this.tbPatronym.Name = "tbPatronym";
            this.tbPatronym.Size = new System.Drawing.Size(304, 22);
            this.tbPatronym.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество:";
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
            this.dgvReside.Location = new System.Drawing.Point(12, 52);
            this.dgvReside.Name = "dgvReside";
            this.dgvReside.ReadOnly = true;
            this.dgvReside.RowHeadersWidth = 51;
            this.dgvReside.RowTemplate.Height = 24;
            this.dgvReside.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReside.Size = new System.Drawing.Size(630, 422);
            this.dgvReside.TabIndex = 9;
            this.dgvReside.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Проживающие:";
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(668, 42);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(58, 38);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(961, 42);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(58, 38);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(915, 510);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 42);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // getDatabtn
            // 
            this.getDatabtn.Location = new System.Drawing.Point(784, 510);
            this.getDatabtn.Name = "getDatabtn";
            this.getDatabtn.Size = new System.Drawing.Size(122, 42);
            this.getDatabtn.TabIndex = 16;
            this.getDatabtn.Text = "Получить";
            this.getDatabtn.UseVisualStyleBackColor = true;
            this.getDatabtn.Click += new System.EventHandler(this.getData_Click);
            // 
            // TenantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1034, 607);
            this.Controls.Add(this.getDatabtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvReside);
            this.Controls.Add(this.panel1);
            this.Name = "TenantsForm";
            this.Text = "Регистрация жильцов";
            this.Load += new System.EventHandler(this.Tenants_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReside)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.DateTimePicker dtEndReg;
        private System.Windows.Forms.DateTimePicker dtStartReg;
        private System.Windows.Forms.TextBox tbPatronym;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvReside;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.ComboBox cbLivingSpace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button getDatabtn;
    }
}