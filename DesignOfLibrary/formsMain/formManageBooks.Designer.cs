namespace DesignOfLibrary
{
    partial class formManageBooks
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
            this.lvSearch = new System.Windows.Forms.ListView();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lableFind = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAddBook = new System.Windows.Forms.Button();
            this.btDellBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSearch
            // 
            this.lvSearch.HideSelection = false;
            this.lvSearch.Location = new System.Drawing.Point(12, 123);
            this.lvSearch.Name = "lvSearch";
            this.lvSearch.Size = new System.Drawing.Size(679, 279);
            this.lvSearch.TabIndex = 12;
            this.lvSearch.UseCompatibleStateImageBehavior = false;
            this.lvSearch.SelectedIndexChanged += new System.EventHandler(this.lvSearch_SelectedIndexChanged);
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(590, 87);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(101, 30);
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Поиск";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(12, 87);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(572, 30);
            this.tbSearch.TabIndex = 10;
            // 
            // lableFind
            // 
            this.lableFind.AutoSize = true;
            this.lableFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableFind.Location = new System.Drawing.Point(12, 64);
            this.lableFind.Name = "lableFind";
            this.lableFind.Size = new System.Drawing.Size(92, 20);
            this.lableFind.TabIndex = 9;
            this.lableFind.Text = "Поиск книг";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "Управление книгами";
            // 
            // btAddBook
            // 
            this.btAddBook.Location = new System.Drawing.Point(8, 19);
            this.btAddBook.Name = "btAddBook";
            this.btAddBook.Size = new System.Drawing.Size(101, 30);
            this.btAddBook.TabIndex = 14;
            this.btAddBook.Text = "Добавить книгу";
            this.btAddBook.UseVisualStyleBackColor = true;
            this.btAddBook.Click += new System.EventHandler(this.btAddBook_Click);
            // 
            // btDellBook
            // 
            this.btDellBook.Enabled = false;
            this.btDellBook.Location = new System.Drawing.Point(8, 55);
            this.btDellBook.Name = "btDellBook";
            this.btDellBook.Size = new System.Drawing.Size(101, 30);
            this.btDellBook.TabIndex = 15;
            this.btDellBook.Text = "Списать книгу";
            this.btDellBook.UseVisualStyleBackColor = true;
            this.btDellBook.Click += new System.EventHandler(this.btDellBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAddBook);
            this.groupBox1.Controls.Add(this.btDellBook);
            this.groupBox1.Location = new System.Drawing.Point(697, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 285);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // formManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSearch);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lableFind);
            this.Name = "formManageBooks";
            this.Text = "formManageBooks";
            this.Load += new System.EventHandler(this.formManageBooks_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lableFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddBook;
        private System.Windows.Forms.Button btDellBook;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}