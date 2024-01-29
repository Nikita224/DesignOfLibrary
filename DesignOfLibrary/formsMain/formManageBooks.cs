using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignOfLibrary
{
    public partial class formManageBooks : Form
    {
        IsMySQL myConnectionToMySql;
        int idWorker, CodeBook;
        public formManageBooks(IsMySQL myConnectionToMySql, int idWorker)
        {
            InitializeComponent();
            this.myConnectionToMySql = myConnectionToMySql;
            this.idWorker = idWorker;

            refreshList();
        }

        private void refreshList()
        {
            String search = tbSearch.Text;
            String[][] result = myConnectionToMySql.SQLRequest("SELECT books.Code AS Code, books.Name AS bookName, author.Name AS authorName, DATE_FORMAT(books.Date, '%Y-%m-%d') AS Date, IFNULL(visitor.Name, '') AS Owner, IFNULL(DATE_FORMAT(rm.DateTimeOperation, '%Y-%m-%d %H:%i:%s'), '') AS DateTaken FROM books INNER JOIN author ON author.Code = books.Code_Author LEFT JOIN ( SELECT rm1.Code_books, rm1.Code_visitor, rm1.DateTimeOperation FROM record_movement rm1 WHERE rm1.TypeOfOperation = b'0' AND NOT EXISTS ( SELECT 1 FROM record_movement rm2 WHERE rm2.Code_books = rm1.Code_books AND rm2.Code_visitor = rm1.Code_visitor AND rm2.TypeOfOperation = b'1' AND rm2.DateTimeOperation > rm1.DateTimeOperation ) ) AS rm ON rm.Code_books = books.Code LEFT JOIN visitor ON rm.Code_visitor = visitor.Code WHERE books.IsDell = false AND (books.Name LIKE '%"+search+"%' OR author.Name LIKE '%"+search+"%') ORDER BY books.Code", 6);

            lvSearch.Items.Clear();
            lvSearch.Columns.Clear();
            lvSearch.View = View.Details;
            lvSearch.GridLines = true;
            lvSearch.FullRowSelect = true;

            lvSearch.Columns.Add("Code", "Code", 0);
            lvSearch.Columns.Add("bookName", "Название книги", 176);
            lvSearch.Columns.Add("authorName", "Автор", 150);
            lvSearch.Columns.Add("Date", "Дата тиража", 80);
            lvSearch.Columns.Add("рavingBook", "Владелец книги", 120);
            lvSearch.Columns.Add("DateGift", "Дата выдачи", 120);

            foreach (String[] row in result)
            {
                ListViewItem item = new ListViewItem(row);
                lvSearch.Items.Add(item);
            }
        }

        private void formManageBooks_Load(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            refreshList();
        }
        private void formAddBookThread()
        {
        }

        private void btAddBook_Click(object sender, EventArgs e)
        {

            using (formAddBook fsb = new formAddBook(myConnectionToMySql, idWorker))
            {
                if (fsb.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Отлично! Книга была добавлена");
                    refreshList();
                }
                else
                {
                    MessageBox.Show("Не удалось выбрать книгу");
                }
            }
        }

        private void btDellBook_Click(object sender, EventArgs e)
        {
            myConnectionToMySql.SQLInsertRequest("UPDATE `books` SET `IsDell`= 1 WHERE books.Code = '"+CodeBook+"'");
            btDellBook.Enabled = false;
            CodeBook = 0;
            refreshList();
        }

        private void lvSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = (ListView)sender;
            if (lv.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv.SelectedItems[0];
                CodeBook = Int32.Parse(selectedItem.SubItems[0].Text);

                btDellBook.Enabled = true;
            }
            else
            {
                btDellBook.Enabled = false;
                CodeBook = 0;
            }
        }
    }
}
