
namespace testProjWF
{
    partial class AccrualsForm
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
            this.lbProvider = new System.Windows.Forms.Label();
            this.lbResponsible = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbCountReside = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProvider
            // 
            this.lbProvider.AutoSize = true;
            this.lbProvider.Location = new System.Drawing.Point(19, 96);
            this.lbProvider.Name = "lbProvider";
            this.lbProvider.Size = new System.Drawing.Size(99, 17);
            this.lbProvider.TabIndex = 20;
            this.lbProvider.Text = "Организация:";
            // 
            // lbResponsible
            // 
            this.lbResponsible.AutoSize = true;
            this.lbResponsible.Location = new System.Drawing.Point(19, 70);
            this.lbResponsible.Name = "lbResponsible";
            this.lbResponsible.Size = new System.Drawing.Size(115, 17);
            this.lbResponsible.TabIndex = 18;
            this.lbResponsible.Text = "Ответственный:";
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
            this.tbId.TextChanged += new System.EventHandler(this.tbId_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Начисление";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(780, 272);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 42);
            this.addBtn.TabIndex = 20;
            this.addBtn.Text = "Начисление";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            this.dgvBook.Location = new System.Drawing.Point(12, 31);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(630, 422);
            this.dgvBook.TabIndex = 23;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.lbCountReside);
            this.panel1.Controls.Add(this.lbProvider);
            this.panel1.Controls.Add(this.lbResponsible);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Location = new System.Drawing.Point(668, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 215);
            this.panel1.TabIndex = 22;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(19, 153);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(52, 17);
            this.lbAddress.TabIndex = 22;
            this.lbAddress.Text = "Адрес:";
            // 
            // lbCountReside
            // 
            this.lbCountReside.AutoSize = true;
            this.lbCountReside.Location = new System.Drawing.Point(19, 123);
            this.lbCountReside.Name = "lbCountReside";
            this.lbCountReside.Size = new System.Drawing.Size(185, 17);
            this.lbCountReside.TabIndex = 21;
            this.lbCountReside.Text = "Количество проживающих:";
            // 
            // AccrualsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 467);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.panel1);
            this.Name = "AccrualsForm";
            this.Text = "AccrualsForm";
            this.Load += new System.EventHandler(this.AccrualsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProvider;
        private System.Windows.Forms.Label lbResponsible;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbCountReside;
    }
}