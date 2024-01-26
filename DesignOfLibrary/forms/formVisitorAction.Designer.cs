namespace DesignOfLibrary.forms
{
    partial class formVisitorAction
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
            this.lbNameVisitor = new System.Windows.Forms.Label();
            this.lbDateFrom = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvLastOperations = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btDellBook = new System.Windows.Forms.Button();
            this.btAddBook = new System.Windows.Forms.Button();
            this.lvCurrentBooks = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNameVisitor
            // 
            this.lbNameVisitor.AutoSize = true;
            this.lbNameVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbNameVisitor.Location = new System.Drawing.Point(13, 31);
            this.lbNameVisitor.Name = "lbNameVisitor";
            this.lbNameVisitor.Size = new System.Drawing.Size(149, 26);
            this.lbNameVisitor.TabIndex = 0;
            this.lbNameVisitor.Text = "lbNameVisitor";
            // 
            // lbDateFrom
            // 
            this.lbDateFrom.AutoSize = true;
            this.lbDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbDateFrom.Location = new System.Drawing.Point(13, 57);
            this.lbDateFrom.Name = "lbDateFrom";
            this.lbDateFrom.Size = new System.Drawing.Size(126, 26);
            this.lbDateFrom.TabIndex = 1;
            this.lbDateFrom.Text = "lbDateFrom";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvLastOperations);
            this.groupBox1.Location = new System.Drawing.Point(12, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 202);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Последние операции абонемента";
            // 
            // lvLastOperations
            // 
            this.lvLastOperations.HideSelection = false;
            this.lvLastOperations.Location = new System.Drawing.Point(6, 12);
            this.lvLastOperations.Name = "lvLastOperations";
            this.lvLastOperations.Size = new System.Drawing.Size(764, 184);
            this.lvLastOperations.TabIndex = 0;
            this.lvLastOperations.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btDellBook);
            this.groupBox2.Controls.Add(this.btAddBook);
            this.groupBox2.Controls.Add(this.lvCurrentBooks);
            this.groupBox2.Location = new System.Drawing.Point(313, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 225);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Книги в пользовании";
            // 
            // btDellBook
            // 
            this.btDellBook.Enabled = false;
            this.btDellBook.Location = new System.Drawing.Point(336, 195);
            this.btDellBook.Name = "btDellBook";
            this.btDellBook.Size = new System.Drawing.Size(92, 23);
            this.btDellBook.TabIndex = 5;
            this.btDellBook.Text = "Списать книгу";
            this.btDellBook.UseVisualStyleBackColor = true;
            // 
            // btAddBook
            // 
            this.btAddBook.Location = new System.Drawing.Point(336, 19);
            this.btAddBook.Name = "btAddBook";
            this.btAddBook.Size = new System.Drawing.Size(133, 23);
            this.btAddBook.TabIndex = 4;
            this.btAddBook.Text = "Выписать новую книгу";
            this.btAddBook.UseVisualStyleBackColor = true;
            // 
            // lvCurrentBooks
            // 
            this.lvCurrentBooks.HideSelection = false;
            this.lvCurrentBooks.Location = new System.Drawing.Point(6, 19);
            this.lvCurrentBooks.Name = "lvCurrentBooks";
            this.lvCurrentBooks.Size = new System.Drawing.Size(324, 199);
            this.lvCurrentBooks.TabIndex = 0;
            this.lvCurrentBooks.UseCompatibleStateImageBehavior = false;
            // 
            // formVisitorAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbDateFrom);
            this.Controls.Add(this.lbNameVisitor);
            this.Name = "formVisitorAction";
            this.Text = "formVisitorAction";
            this.Load += new System.EventHandler(this.formVisitorAction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameVisitor;
        private System.Windows.Forms.Label lbDateFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvLastOperations;
        private System.Windows.Forms.ListView lvCurrentBooks;
        private System.Windows.Forms.Button btAddBook;
        private System.Windows.Forms.Button btDellBook;
    }
}