using DesignOfLibrary.Properties;
using MySqlX.XDevAPI.Common;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesignOfLibrary.forms
{
    public partial class formSearchVisitor : Form
    {
        Label lb;
        IsMySQL myConnectionToMySql;
        int idWorker;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="myConnectionToMySql"></param>
        /// <param name="action">0 - vzyat; 1 - polojit; 2 - nichego</param>
        public formSearchVisitor(IsMySQL myConnectionToMySql, Label lb, int idWorker)
        {
            this.myConnectionToMySql = myConnectionToMySql;
            this.lb = lb;
            InitializeComponent();
            refreshList();
            this.idWorker = idWorker;
        }

        ~formSearchVisitor()
        {
            
        }

        private void refreshList()
        {
            String search = tbSearch.Text;
            String[][] result = myConnectionToMySql.SQLRequest("SELECT * FROM `visitor` WHERE `Name` LIKE '%" + search + "%' OR `Code` LIKE '%" + search + "%' OR `Passport` LIKE '%" + search + "%' OR `Phone` LIKE '%" + search + "%' OR `Date` LIKE '%" + search + "%' OR `Mail` LIKE '%" + search + "%' OR `Datestart` LIKE '%" + search + "%';", 8);

            lvSearch.Items.Clear();
            lvSearch.Columns.Clear();
            lvSearch.View = View.Details;
            lvSearch.GridLines = true;
            lvSearch.FullRowSelect = true;

            lvSearch.Columns.Add("Code", "№", 23);
            lvSearch.Columns.Add("Name", "ФИО", 176);
            lvSearch.Columns.Add("Passport", "Паспорт", 100);
            lvSearch.Columns.Add("Phone", "Телефон", 80);
            lvSearch.Columns.Add("none", 0);
            lvSearch.Columns.Add("Date", "Дата рождения", 100);
            lvSearch.Columns.Add("Mail", "Mail", 180);
            lvSearch.Columns.Add("Datestart", "Получил абонемент:", 100);

            foreach (String[] row in result)
            {
                ListViewItem item = new ListViewItem(row);

                DateTime dateOfBirth;
                if (DateTime.TryParse(row[5], out dateOfBirth))
                {
                    item.SubItems[5].Text = dateOfBirth.Date.ToString("dd-MM-yyyy");
                    item.SubItems[7].Text = dateOfBirth.Date.ToString("dd-MM-yyyy");
                }

                lvSearch.Items.Add(item);
            }
        }


        private void btSearch_Click(object sender, EventArgs e)
        {
            refreshList();
        }
        private void formVisitorActionThread(object p)
        {
            formVisitorAction form = new formVisitorAction(myConnectionToMySql, Int32.Parse(p.ToString()), idWorker);
            Application.Run(form);
        }

        private void lvSearch_DoubleClick(object sender, EventArgs e)
        {
            if (lvSearch.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvSearch.SelectedItems[0];

                string codeVisitor = selectedItem.SubItems[0].Text;
                string nameVisitor = selectedItem.SubItems[1].Text;
                string passportVisitor = selectedItem.SubItems[2].Text;

                
                // Display the selected values in a MessageBox
                string message = $"{nameVisitor}";

                /*lb.Invoke(new Action(() =>
                {
                    lb.Text = message;
                }));*/

                Thread tr1 = new Thread(formVisitorActionThread);
                tr1.Start(codeVisitor);

                this.Close();
               //MessageBox.Show(message, "Selected Item");
            }
        }
    }
}
