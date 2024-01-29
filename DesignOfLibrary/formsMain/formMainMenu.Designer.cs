namespace DesignOfLibrary
{
    partial class formMainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lablePWorker = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.btAddAbonement = new System.Windows.Forms.Button();
            this.btBooks = new System.Windows.Forms.Button();
            this.btFindAbonement = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списатьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уволитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbWorker = new System.Windows.Forms.GroupBox();
            this.labelNameWorker = new System.Windows.Forms.Label();
            this.gbControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbWorker.SuspendLayout();
            this.SuspendLayout();
            // 
            // lablePWorker
            // 
            this.lablePWorker.AutoSize = true;
            this.lablePWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lablePWorker.Location = new System.Drawing.Point(6, 20);
            this.lablePWorker.Name = "lablePWorker";
            this.lablePWorker.Size = new System.Drawing.Size(331, 39);
            this.lablePWorker.TabIndex = 0;
            this.lablePWorker.Text = "Текущий работник: ";
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.btAddAbonement);
            this.gbControl.Controls.Add(this.btBooks);
            this.gbControl.Controls.Add(this.btFindAbonement);
            this.gbControl.Location = new System.Drawing.Point(12, 113);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(759, 236);
            this.gbControl.TabIndex = 1;
            this.gbControl.TabStop = false;
            // 
            // btAddAbonement
            // 
            this.btAddAbonement.Location = new System.Drawing.Point(221, 19);
            this.btAddAbonement.Name = "btAddAbonement";
            this.btAddAbonement.Size = new System.Drawing.Size(202, 57);
            this.btAddAbonement.TabIndex = 3;
            this.btAddAbonement.Text = "Добавить абонемент";
            this.btAddAbonement.UseVisualStyleBackColor = true;
            this.btAddAbonement.Click += new System.EventHandler(this.btAddAbonement_Click);
            // 
            // btBooks
            // 
            this.btBooks.Location = new System.Drawing.Point(551, 173);
            this.btBooks.Name = "btBooks";
            this.btBooks.Size = new System.Drawing.Size(202, 57);
            this.btBooks.TabIndex = 1;
            this.btBooks.Text = "Управление книгами";
            this.btBooks.UseVisualStyleBackColor = true;
            this.btBooks.Click += new System.EventHandler(this.btBooks_Click);
            // 
            // btFindAbonement
            // 
            this.btFindAbonement.Location = new System.Drawing.Point(13, 19);
            this.btFindAbonement.Name = "btFindAbonement";
            this.btFindAbonement.Size = new System.Drawing.Size(202, 57);
            this.btFindAbonement.TabIndex = 0;
            this.btFindAbonement.Text = "Найти абонемент";
            this.btFindAbonement.UseVisualStyleBackColor = true;
            this.btFindAbonement.Click += new System.EventHandler(this.btFindAbonement_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокКнигToolStripMenuItem,
            this.добавитьКнигуToolStripMenuItem,
            this.списатьКнигуToolStripMenuItem});
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // списокКнигToolStripMenuItem
            // 
            this.списокКнигToolStripMenuItem.Name = "списокКнигToolStripMenuItem";
            this.списокКнигToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.списокКнигToolStripMenuItem.Text = "Список книг";
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            this.добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            this.добавитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.добавитьКнигуToolStripMenuItem.Text = "Добавить книгу";
            // 
            // списатьКнигуToolStripMenuItem
            // 
            this.списатьКнигуToolStripMenuItem.Name = "списатьКнигуToolStripMenuItem";
            this.списатьКнигуToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.списатьКнигуToolStripMenuItem.Text = "Списать книгу";
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСотрудникаToolStripMenuItem,
            this.уволитьСотрудникаToolStripMenuItem});
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            // 
            // добавитьСотрудникаToolStripMenuItem
            // 
            this.добавитьСотрудникаToolStripMenuItem.Name = "добавитьСотрудникаToolStripMenuItem";
            this.добавитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.добавитьСотрудникаToolStripMenuItem.Text = "Добавить сотрудника";
            // 
            // уволитьСотрудникаToolStripMenuItem
            // 
            this.уволитьСотрудникаToolStripMenuItem.Name = "уволитьСотрудникаToolStripMenuItem";
            this.уволитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.уволитьСотрудникаToolStripMenuItem.Text = "Уволить сотрудника";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // gbWorker
            // 
            this.gbWorker.Controls.Add(this.labelNameWorker);
            this.gbWorker.Controls.Add(this.lablePWorker);
            this.gbWorker.Location = new System.Drawing.Point(12, 27);
            this.gbWorker.Name = "gbWorker";
            this.gbWorker.Size = new System.Drawing.Size(759, 86);
            this.gbWorker.TabIndex = 3;
            this.gbWorker.TabStop = false;
            // 
            // labelNameWorker
            // 
            this.labelNameWorker.AutoSize = true;
            this.labelNameWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameWorker.Location = new System.Drawing.Point(334, 20);
            this.labelNameWorker.Name = "labelNameWorker";
            this.labelNameWorker.Size = new System.Drawing.Size(290, 39);
            this.labelNameWorker.TabIndex = 1;
            this.labelNameWorker.Text = "labelNameWorker";
            // 
            // formMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 359);
            this.Controls.Add(this.gbWorker);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMainMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.formMainMenu_Load);
            this.gbControl.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbWorker.ResumeLayout(false);
            this.gbWorker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lablePWorker;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btAddAbonement;
        private System.Windows.Forms.Button btBooks;
        private System.Windows.Forms.Button btFindAbonement;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокКнигToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списатьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уволитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbWorker;
        private System.Windows.Forms.Label labelNameWorker;
    }
}

