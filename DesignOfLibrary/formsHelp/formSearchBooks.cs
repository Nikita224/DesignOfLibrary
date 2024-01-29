using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignOfLibrary
{
    public partial class formSearchBooks : Form
    {
        IsMySQL myConnectionToMySql;

        public formSearchBooks(IsMySQL myConnectionToMySql)
        {
            this.myConnectionToMySql = myConnectionToMySql;
            InitializeComponent();
            refreshList();
        }

        public string Result { get; set; }

        private void refreshList()
        {
            String search = tbSearch.Text;
            String[][] result = myConnectionToMySql.SQLRequest("SELECT books.Code as Code, books.Name as bookName, author.Name as authorName, DATE_FORMAT(books.Date, '%Y-%m-%d') as Date FROM books INNER JOIN author ON author.Code = books.Code_Author WHERE books.IsDell LIKE true AND (books.Name LIKE '%" + search + "%' OR author.Name LIKE '%" + search + "%')", 4);

            lvSearch.Items.Clear();
            lvSearch.Columns.Clear();
            lvSearch.View = View.Details;
            lvSearch.GridLines = true;
            lvSearch.FullRowSelect = true;

            lvSearch.Columns.Add("Code", "Code", 0);
            lvSearch.Columns.Add("bookName", "Название книги", 176);
            lvSearch.Columns.Add("authorName", "Автор", 150);
            lvSearch.Columns.Add("Date", "Дата тиража", 100);

            foreach (String[] row in result)
            {
                ListViewItem item = new ListViewItem(row);
                lvSearch.Items.Add(item);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            refreshList();
        }

        private void lvSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = lvSearch.SelectedItems[0];
            this.Result = selectedItem.SubItems[0].Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
