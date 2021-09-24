
namespace testProjWF
{
    partial class LivingSpaceForm
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
            this.getDatabtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvLivingSpace = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSquare = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivingSpace)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // getDatabtn
            // 
            this.getDatabtn.Location = new System.Drawing.Point(784, 486);
            this.getDatabtn.Name = "getDatabtn";
            this.getDatabtn.Size = new System.Drawing.Size(122, 42);
            this.getDatabtn.TabIndex = 23;
            this.getDatabtn.Text = "Получить";
            this.getDatabtn.UseVisualStyleBackColor = true;
            this.getDatabtn.Click += new System.EventHandler(this.getDatabtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(915, 486);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 42);
            this.saveBtn.TabIndex = 22;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(961, 18);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(58, 38);
            this.btnRight.TabIndex = 21;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(668, 18);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(58, 38);
            this.btnLeft.TabIndex = 20;
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Жилая площадь:";
            // 
            // dgvLivingSpace
            // 
            this.dgvLivingSpace.AllowUserToAddRows = false;
            this.dgvLivingSpace.AllowUserToDeleteRows = false;
            this.dgvLivingSpace.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLivingSpace.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvLivingSpace.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLivingSpace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLivingSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivingSpace.Location = new System.Drawing.Point(12, 28);
            this.dgvLivingSpace.Name = "dgvLivingSpace";
            this.dgvLivingSpace.ReadOnly = true;
            this.dgvLivingSpace.RowHeadersWidth = 51;
            this.dgvLivingSpace.RowTemplate.Height = 24;
            this.dgvLivingSpace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivingSpace.Size = new System.Drawing.Size(630, 422);
            this.dgvLivingSpace.TabIndex = 18;
            this.dgvLivingSpace.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivingSpace_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.editBtn);
            this.panel1.Controls.Add(this.addBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbSquare);
            this.panel1.Controls.Add(this.tbAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(668, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 396);
            this.panel1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Id:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(22, 32);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(304, 22);
            this.tbId.TabIndex = 15;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(3, 346);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(107, 42);
            this.delBtn.TabIndex = 14;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(116, 346);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(122, 42);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Адрес";
            // 
            // tbSquare
            // 
            this.tbSquare.Location = new System.Drawing.Point(22, 122);
            this.tbSquare.Name = "tbSquare";
            this.tbSquare.Size = new System.Drawing.Size(304, 22);
            this.tbSquare.TabIndex = 4;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(22, 77);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(304, 22);
            this.tbAddress.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Площадь (кв.м.)";
            // 
            // LivingSpaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1047, 549);
            this.Controls.Add(this.getDatabtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvLivingSpace);
            this.Controls.Add(this.panel1);
            this.Name = "LivingSpaceForm";
            this.Text = "LivingSpaceForm";
            this.Load += new System.EventHandler(this.LivingSpaceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivingSpace)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDatabtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvLivingSpace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSquare;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label2;
    }
}