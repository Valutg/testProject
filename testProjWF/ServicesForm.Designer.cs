
namespace testProjWF
{
    partial class ServicesForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSquare = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.getDatabtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvLivingSpace = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivingSpace)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название услуги:";
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
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость за единицу:";
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
            this.panel1.Location = new System.Drawing.Point(668, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 396);
            this.panel1.TabIndex = 24;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(3, 346);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(107, 42);
            this.delBtn.TabIndex = 14;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(116, 346);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(122, 42);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
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
            // getDatabtn
            // 
            this.getDatabtn.Location = new System.Drawing.Point(784, 495);
            this.getDatabtn.Name = "getDatabtn";
            this.getDatabtn.Size = new System.Drawing.Size(122, 42);
            this.getDatabtn.TabIndex = 30;
            this.getDatabtn.Text = "Получить";
            this.getDatabtn.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(915, 495);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(107, 42);
            this.saveBtn.TabIndex = 29;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(961, 27);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(58, 38);
            this.btnRight.TabIndex = 28;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(668, 27);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(58, 38);
            this.btnLeft.TabIndex = 27;
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Услуги:";
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
            this.dgvLivingSpace.Location = new System.Drawing.Point(12, 37);
            this.dgvLivingSpace.Name = "dgvLivingSpace";
            this.dgvLivingSpace.ReadOnly = true;
            this.dgvLivingSpace.RowHeadersWidth = 51;
            this.dgvLivingSpace.RowTemplate.Height = 24;
            this.dgvLivingSpace.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivingSpace.Size = new System.Drawing.Size(630, 422);
            this.dgvLivingSpace.TabIndex = 25;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.getDatabtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvLivingSpace);
            this.Name = "ServicesForm";
            this.Text = "ServicesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivingSpace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSquare;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button getDatabtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvLivingSpace;
    }
}