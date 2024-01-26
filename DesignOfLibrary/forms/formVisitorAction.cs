using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignOfLibrary.forms
{
    public partial class formVisitorAction : Form
    {
        int id;
        IsMySQL myConnetionToMySql;
        public formVisitorAction(IsMySQL myConnetionToMySql, int id)
        {
            this.id = id;
            this.myConnetionToMySql = myConnetionToMySql;
            InitializeComponent();
        }

        private void formVisitorAction_Load(object sender, EventArgs e)
        {
            String[][] result = myConnetionToMySql.SQLRequest("SELECT Name FROM visitor WHERE Code = "+id+";",2);
            lbNameVisitor.Text = result[0][0];
            lbDateFrom.Text = result[0][1];
            refreshList();
        }
        private void refreshList()
        {
            String search = lbNameVisitor.Text;
            String[][] result = myConnetionToMySql.SQLRequest("SELECT books.Name AS NameBook, author.Name As NameAuthor, MAX(CASE WHEN record_movement.TypeOfOperation = 0 THEN record_movement.DateTimeOperation END) AS DateIssue, MAX(CASE WHEN record_movement.TypeOfOperation = 1 THEN record_movement.DateTimeOperation END) AS DateReturn FROM record_movement INNER JOIN books ON books.Code = record_movement.Code_books INNER JOIN author ON author.Code = books.Code_Author WHERE record_movement.Code_visitor = "+id+" GROUP BY books.Name", 4);


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

            result = myConnetionToMySql.SQLRequest("SELECT * FROM ( SELECT books.Name AS NameBook, MAX(CASE WHEN record_movement.TypeOfOperation = 0 THEN record_movement.DateTimeOperation END) AS DateIssue, MAX(CASE WHEN record_movement.TypeOfOperation = 1 THEN record_movement.DateTimeOperation END) AS DateReturn FROM record_movement INNER JOIN books ON books.Code = record_movement.Code_books INNER JOIN author ON author.Code = books.Code_Author WHERE record_movement.Code_visitor = "+id+" GROUP BY books.Name) as lastOp WHERE lastOp.DateReturn Is NULL OR lastOp.DateReturn < lastOp.DateIssue", 3);

            lvCurrentBooks.Items.Clear();
            lvCurrentBooks.Columns.Clear();
            lvCurrentBooks.View = View.Details;
            lvCurrentBooks.GridLines = true;
            lvCurrentBooks.FullRowSelect = true;

            lvCurrentBooks.Columns.Add("NameBook", "Название", 200);
            lvCurrentBooks.Columns.Add("DateIssue", "Дата выдачи", 120);

            foreach (String[] row in result)
            {
                ListViewItem item = new ListViewItem(row);
                lvCurrentBooks.Items.Add(item);
            }
        }
    }
}
