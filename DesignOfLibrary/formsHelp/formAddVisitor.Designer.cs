namespace DesignOfLibrary.formsHelp
{
    partial class formAddVisitor
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
            this.lbFIO = new System.Windows.Forms.Label();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbPassport = new System.Windows.Forms.TextBox();
            this.lbPassport = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.cbM = new System.Windows.Forms.CheckBox();
            this.cbJ = new System.Windows.Forms.CheckBox();
            this.gbMale = new System.Windows.Forms.GroupBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lbMail = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbNewAbonement = new System.Windows.Forms.Label();
            this.gbMale.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFIO
            // 
            this.lbFIO.AutoSize = true;
            this.lbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFIO.Location = new System.Drawing.Point(12, 86);
            this.lbFIO.Name = "lbFIO";
            this.lbFIO.Size = new System.Drawing.Size(64, 26);
            this.lbFIO.TabIndex = 0;
            this.lbFIO.Text = "ФИО";
            // 
            // tbFIO
            // 
            this.tbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFIO.Location = new System.Drawing.Point(82, 83);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(310, 32);
            this.tbFIO.TabIndex = 1;
            // 
            // tbPassport
            // 
            this.tbPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassport.Location = new System.Drawing.Point(115, 121);
            this.tbPassport.Name = "tbPassport";
            this.tbPassport.Size = new System.Drawing.Size(277, 32);
            this.tbPassport.TabIndex = 3;
            // 
            // lbPassport
            // 
            this.lbPassport.AutoSize = true;
            this.lbPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassport.Location = new System.Drawing.Point(12, 124);
            this.lbPassport.Name = "lbPassport";
            this.lbPassport.Size = new System.Drawing.Size(97, 26);
            this.lbPassport.TabIndex = 2;
            this.lbPassport.Text = "Паспорт";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPhone.Location = new System.Drawing.Point(122, 159);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(270, 32);
            this.tbPhone.TabIndex = 5;
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPhone.Location = new System.Drawing.Point(12, 162);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(104, 26);
            this.lbPhone.TabIndex = 4;
            this.lbPhone.Text = "Телефон";
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSex.Location = new System.Drawing.Point(12, 209);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(53, 26);
            this.lbSex.TabIndex = 6;
            this.lbSex.Text = "Пол";
            // 
            // cbM
            // 
            this.cbM.AutoSize = true;
            this.cbM.Checked = true;
            this.cbM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbM.Enabled = false;
            this.cbM.Location = new System.Drawing.Point(4, 10);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(51, 17);
            this.cbM.TabIndex = 7;
            this.cbM.Text = "Муж.";
            this.cbM.UseVisualStyleBackColor = true;
            this.cbM.Click += new System.EventHandler(this.cbM_Click);
            // 
            // cbJ
            // 
            this.cbJ.AutoSize = true;
            this.cbJ.Location = new System.Drawing.Point(61, 10);
            this.cbJ.Name = "cbJ";
            this.cbJ.Size = new System.Drawing.Size(52, 17);
            this.cbJ.TabIndex = 8;
            this.cbJ.Text = "Жен.";
            this.cbJ.UseVisualStyleBackColor = true;
            this.cbJ.Click += new System.EventHandler(this.cbJ_Click);
            // 
            // gbMale
            // 
            this.gbMale.Controls.Add(this.cbJ);
            this.gbMale.Controls.Add(this.cbM);
            this.gbMale.Location = new System.Drawing.Point(93, 203);
            this.gbMale.Name = "gbMale";
            this.gbMale.Size = new System.Drawing.Size(110, 36);
            this.gbMale.TabIndex = 9;
            this.gbMale.TabStop = false;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(12, 251);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(170, 26);
            this.lbDate.TabIndex = 10;
            this.lbDate.Text = "Дата рождения";
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtPicker.Location = new System.Drawing.Point(188, 258);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(204, 20);
            this.dtPicker.TabIndex = 11;
            // 
            // tbMail
            // 
            this.tbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMail.Location = new System.Drawing.Point(92, 283);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(300, 32);
            this.tbMail.TabIndex = 13;
            // 
            // lbMail
            // 
            this.lbMail.AutoSize = true;
            this.lbMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbMail.Location = new System.Drawing.Point(12, 286);
            this.lbMail.Name = "lbMail";
            this.lbMail.Size = new System.Drawing.Size(74, 26);
            this.lbMail.TabIndex = 12;
            this.lbMail.Text = "Почта";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(69, 370);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(275, 35);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbNewAbonement
            // 
            this.lbNewAbonement.AutoSize = true;
            this.lbNewAbonement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNewAbonement.Location = new System.Drawing.Point(86, 9);
            this.lbNewAbonement.Name = "lbNewAbonement";
            this.lbNewAbonement.Size = new System.Drawing.Size(240, 31);
            this.lbNewAbonement.TabIndex = 15;
            this.lbNewAbonement.Text = "Новый абонемент";
            // 
            // formAddVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 429);
            this.Controls.Add(this.lbNewAbonement);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.lbMail);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.gbMale);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tbPassport);
            this.Controls.Add(this.lbPassport);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.lbFIO);
            this.Name = "formAddVisitor";
            this.Text = "formAddVisitor";
            this.Load += new System.EventHandler(this.formAddVisitor_Load);
            this.gbMale.ResumeLayout(false);
            this.gbMale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFIO;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.TextBox tbPassport;
        private System.Windows.Forms.Label lbPassport;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.CheckBox cbM;
        private System.Windows.Forms.CheckBox cbJ;
        private System.Windows.Forms.GroupBox gbMale;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lbMail;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbNewAbonement;
    }
}