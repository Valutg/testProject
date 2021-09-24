
namespace testProjWF
{
    partial class BankBookForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.delBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.getDatabtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cbOrganization = new System.Windows.Forms.ComboBox();
            this.cbResponsible = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDebt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOverpay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ответственный:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Номер лицевого счета:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(22, 32);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(304, 22);
            this.tbId.TabIndex = 15;
            this.tbId.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Лицевые счета";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBook.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(24, 35);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(630, 422);
            this.dgvBook.TabIndex = 18;
            this.dgvBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.cbOrganization);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbResponsible);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Location = new System.Drawing.Point(680, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 215);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Организация:";
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(796, 401);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(122, 42);
            this.delBtn.TabIndex = 14;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(924, 401);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(107, 42);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // getDatabtn
            // 
            this.getDatabtn.Location = new System.Drawing.Point(796, 470);
            this.getDatabtn.Name = "getDatabtn";
            this.getDatabtn.Size = new System.Drawing.Size(122, 42);
            this.getDatabtn.TabIndex = 21;
            this.getDatabtn.Text = "Получить";
            this.getDatabtn.UseVisualStyleBackColor = true;
            this.getDatabtn.Click += new System.EventHandler(this.getDatabtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(927, 470);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 42);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cbOrganization
            // 
            this.cbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrganization.FormattingEnabled = true;
            this.cbOrganization.Location = new System.Drawing.Point(22, 152);
            this.cbOrganization.Name = "cbOrganization";
            this.cbOrganization.Size = new System.Drawing.Size(304, 24);
            this.cbOrganization.TabIndex = 21;
            // 
            // cbResponsible
            // 
            this.cbResponsible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResponsible.FormattingEnabled = true;
            this.cbResponsible.Location = new System.Drawing.Point(22, 90);
            this.cbResponsible.Name = "cbResponsible";
            this.cbResponsible.Size = new System.Drawing.Size(304, 24);
            this.cbResponsible.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Задолженность:";
            this.label2.Visible = false;
            // 
            // tbDebt
            // 
            this.tbDebt.Enabled = false;
            this.tbDebt.Location = new System.Drawing.Point(702, 287);
            this.tbDebt.Name = "tbDebt";
            this.tbDebt.Size = new System.Drawing.Size(304, 22);
            this.tbDebt.TabIndex = 22;
            this.tbDebt.Text = "0";
            this.tbDebt.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Переплата:";
            this.label3.Visible = false;
            // 
            // tbOverpay
            // 
            this.tbOverpay.Enabled = false;
            this.tbOverpay.Location = new System.Drawing.Point(702, 347);
            this.tbOverpay.Name = "tbOverpay";
            this.tbOverpay.Size = new System.Drawing.Size(304, 22);
            this.tbOverpay.TabIndex = 24;
            this.tbOverpay.Text = "0";
            this.tbOverpay.Visible = false;
            // 
            // BankBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getDatabtn);
            this.Controls.Add(this.tbOverpay);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.tbDebt);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.panel1);
            this.Name = "BankBookForm";
            this.Text = "bankBookForm";
            this.Load += new System.EventHandler(this.bankBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getDatabtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox cbOrganization;
        private System.Windows.Forms.ComboBox cbResponsible;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDebt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOverpay;
    }
}