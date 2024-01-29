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
    public partial class formAddBook : Form
    {
        IsMySQL myConnectionToMySql;
        int idWorker;
        String[][] resultAuthor, resultCategories;

        public formAddBook(IsMySQL myConnectionToMySql, int idWorker)
        {
            this.myConnectionToMySql = myConnectionToMySql;
            this.idWorker = idWorker;
            InitializeComponent();
        }

        private void formAddBook_Load(object sender, EventArgs e)
        {
            resultAuthor = myConnectionToMySql.SQLRequest("SELECT Code, Name FROM author", 2);
            foreach (String[] row in resultAuthor)
            {
                cbBookAuth.Items.Add(row[1]);
            }
            resultCategories = myConnectionToMySql.SQLRequest("SELECT Code, Name FROM categories", 2);
            foreach (String[] row in resultCategories)
            {
                cbBookCategory.Items.Add(row[1]);
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string auth = resultAuthor[Int32.Parse(cbBookAuth.SelectedIndex.ToString())][0];
            if (myConnectionToMySql.SQLStartProcedure("CALL AddBookToShelf('"+ tbBookName.Text + "', '"+ IsMySQL.formatDate(dtBookDate) + "', '"+ auth + "', '"+ resultCategories[Int32.Parse(cbBookCategory.SelectedIndex.ToString())][0] + "', '"+ idWorker + "');"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }
    }
}
