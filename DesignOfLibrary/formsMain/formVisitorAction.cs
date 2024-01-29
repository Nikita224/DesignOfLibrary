using Mysqlx.Crud;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignOfLibrary.forms
{
    public partial class formVisitorAction : Form
    {
        int idVisitor;
        int CodeBook;
        int idWorker;

        IsMySQL myConnectionToMySql;
        public formVisitorAction(IsMySQL myConnectionToMySql, int idVisitor, int idWorker)
        {
            this.idVisitor = idVisitor;
            this.myConnectionToMySql = myConnectionToMySql;
            InitializeComponent();
            this.idWorker = idWorker;
        }

        private void formVisitorAction_Load(object sender, EventArgs e)
        {
            String[][] result = myConnectionToMySql.SQLRequest("SELECT Name, DATE_FORMAT(DateStart, '%Y-%m-%d') FROM visitor WHERE Code = " + idVisitor + ";",2);
            lbNameVisitor.Text = result[0][0];
            lbDateFrom.Text = result[0][1];
            refreshList();
        }
        private void refreshList()
        {
            String search = lbNameVisitor.Text;
            String[][] result = myConnectionToMySql.SQLRequest("SELECT books.Name AS NameBook, author.Name As NameAuthor, MAX(CASE WHEN record_movement.TypeOfOperation = 0 THEN record_movement.DateTimeOperation END) AS DateIssue, MAX(CASE WHEN record_movement.TypeOfOperation = 1 THEN record_movement.DateTimeOperation END) AS DateReturn FROM record_movement INNER JOIN books ON books.Code = record_movement.Code_books INNER JOIN author ON author.Code = books.Code_Author WHERE record_movement.Code_visitor = "+idVisitor+" GROUP BY books.Name", 4);


            lvLastOperations.Items.Clear();
            lvLastOperations.Columns.Clear();
            lvLastOperations.View = View.Details;
            lvLastOperations.GridLines = true;
            lvLastOperations.FullRowSelect = true;

            lvLastOperations.Columns.Add("NameBook", "Название", 320);
            lvLastOperations.Columns.Add("Author", "Автор", 200);
            lvLastOperations.Columns.Add("DateIssue", "Дата выдачи", 120);
            lvLastOperations.Columns.Add("DateReturn", "Дата возврата", 120);

            foreach (String[] row in result)
            {
                ListViewItem item = new ListViewItem(row);
                lvLastOperations.Items.Add(item);
            }

            result = myConnectionToMySql.SQLRequest("SELECT * FROM ( SELECT books.Code as CodeBook, books.Name AS NameBook, MAX(CASE WHEN record_movement.TypeOfOperation = 0 THEN record_movement.DateTimeOperation END) AS DateIssue, MAX(CASE WHEN record_movement.TypeOfOperation = 1 THEN record_movement.DateTimeOperation END) AS DateReturn FROM record_movement INNER JOIN books ON books.Code = record_movement.Code_books INNER JOIN author ON author.Code = books.Code_Author WHERE record_movement.Code_visitor = "+idVisitor+" GROUP BY books.Name) as lastOp WHERE lastOp.DateReturn Is NULL OR lastOp.DateReturn < lastOp.DateIssue", 4);

            lvCurrentBooks.Items.Clear();
            lvCurrentBooks.Columns.Clear();
            lvCurrentBooks.View = View.Details;
            lvCurrentBooks.GridLines = true;
            lvCurrentBooks.FullRowSelect = true;

            lvCurrentBooks.Columns.Add("CodeBook", "Код книги", 0);
            lvCurrentBooks.Columns.Add("NameBook", "Название", 200);
            lvCurrentBooks.Columns.Add("DateIssue", "Дата выдачи", 120);

            foreach (String[] row in result)
            {
                ListViewItem item = new ListViewItem(row);
                lvCurrentBooks.Items.Add(item);
            }
        }


        private void lvCurrentBooks_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btDellBook_Click(object sender, EventArgs e)
        {

            myConnectionToMySql.SQLInsertRequest("INSERT INTO `record_movement` (`Code_books`, `Code_selfs`, `Code_visitor`, `DateTimeOperation`, `Code_workers`, `TypeOfOperation`) VALUES('"+CodeBook+"',( SELECT rm.Code_selfs FROM `record_movement` as rm WHERE rm.Code_books = '"+CodeBook+"' AND rm.Code_visitor = '"+idVisitor+"' ORDER BY rm.DateTimeOperation DESC LIMIT 1), '"+idVisitor+"', NOW(), '"+idWorker+"', b'1')");
            btDellBook.Enabled = false;
            CodeBook = 0;
            refreshList();
        }

        private void btSearchBook_Click(object sender, EventArgs e)
        {
            using (formSearchBooks fsb = new formSearchBooks(myConnectionToMySql))
            {
                if (fsb.ShowDialog() == DialogResult.OK)
                {
                    string result = fsb.Result;
                    myConnectionToMySql.SQLInsertRequest("INSERT INTO `record_movement` (`Code_books`, `Code_selfs`, `Code_visitor`, `DateTimeOperation`, `Code_workers`, `TypeOfOperation`) VALUES('" + result + "', 3, '" + idVisitor + "', NOW(), '" + idWorker + "', b'0')");
                    refreshList();
                }
                else
                {
                    MessageBox.Show("Не удалось выбрать книгу");
                }
            }
        }
    }
}
