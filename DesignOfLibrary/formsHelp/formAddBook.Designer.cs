namespace DesignOfLibrary
{
    partial class formAddBook
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
            this.lbNewAbonement = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.lbFIO = new System.Windows.Forms.Label();
            this.dtBookDate = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBookAuth = new System.Windows.Forms.ComboBox();
            this.cbBookCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNewAbonement
            // 
            this.lbNewAbonement.AutoSize = true;
            this.lbNewAbonement.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbNewAbonement.Location = new System.Drawing.Point(94, 9);
            this.lbNewAbonement.Name = "lbNewAbonement";
            this.lbNewAbonement.Size = new System.Drawing.Size(169, 31);
            this.lbNewAbonement.TabIndex = 23;
            this.lbNewAbonement.Text = "Новая книга";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(120, 413);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(115, 35);
            this.btAdd.TabIndex = 22;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbBookName
            // 
            this.tbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbBookName.Location = new System.Drawing.Point(17, 107);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(320, 32);
            this.tbBookName.TabIndex = 17;
            // 
            // lbFIO
            // 
            this.lbFIO.AutoSize = true;
            this.lbFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbFIO.Location = new System.Drawing.Point(12, 78);
            this.lbFIO.Name = "lbFIO";
            this.lbFIO.Size = new System.Drawing.Size(172, 26);
            this.lbFIO.TabIndex = 16;
            this.lbFIO.Text = "Название книги";
            // 
            // dtBookDate
            // 
            this.dtBookDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtBookDate.Location = new System.Drawing.Point(17, 348);
            this.dtBookDate.Name = "dtBookDate";
            this.dtBookDate.Size = new System.Drawing.Size(204, 20);
            this.dtBookDate.TabIndex = 25;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(12, 319);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(143, 26);
            this.lbDate.TabIndex = 24;
            this.lbDate.Text = "Дата тиража";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 26;
            this.label1.Text = "Автор";
            // 
            // cbBookAuth
            // 
            this.cbBookAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBookAuth.FormattingEnabled = true;
            this.cbBookAuth.Location = new System.Drawing.Point(17, 183);
            this.cbBookAuth.Name = "cbBookAuth";
            this.cbBookAuth.Size = new System.Drawing.Size(320, 33);
            this.cbBookAuth.TabIndex = 27;
            // 
            // cbBookCategory
            // 
            this.cbBookCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbBookCategory.FormattingEnabled = true;
            this.cbBookCategory.Location = new System.Drawing.Point(17, 262);
            this.cbBookCategory.Name = "cbBookCategory";
            this.cbBookCategory.Size = new System.Drawing.Size(320, 33);
            this.cbBookCategory.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 28;
            this.label2.Text = "Категория";
            // 
            // formAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 488);
            this.Controls.Add(this.cbBookCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBookAuth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtBookDate);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbNewAbonement);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.lbFIO);
            this.Name = "formAddBook";
            this.Text = "formAddBook";
            this.Load += new System.EventHandler(this.formAddBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNewAbonement;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label lbFIO;
        private System.Windows.Forms.DateTimePicker dtBookDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBookAuth;
        private System.Windows.Forms.ComboBox cbBookCategory;
        private System.Windows.Forms.Label label2;
    }
}