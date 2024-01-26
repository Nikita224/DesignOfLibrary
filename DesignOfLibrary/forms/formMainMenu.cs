using DesignOfLibrary.forms;
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
    public partial class formMainMenu : Form
    {
        IsMySQL myConnetionToMySql;
        public formMainMenu(IsMySQL myConnetionToMySql)
        {
            this.myConnetionToMySql = myConnetionToMySql;
            InitializeComponent();
        }

        private void formMainMenu_Load(object sender, EventArgs e)
        {
            
            
            String p = myConnetionToMySql.SQLRequest("SELECT Name FROM `workers`", 1)[0][0];
            labelNameWorker.Text = p;
        }

        private void formFindAbonementThread()
        {
            formSearchVisitor form = new formSearchVisitor(myConnetionToMySql, this.labelNameWorker);
            Application.Run(form);
        }

        private void btFindAbonement_Click(object sender, EventArgs e)
        {
            Thread tr1 = new Thread(formFindAbonementThread);
            tr1.Start();
        }

        private void btAddAbonement_Click(object sender, EventArgs e)
        {

        }

        private void btBooks_Click(object sender, EventArgs e)
        {

        }

        private void btStatistics_Click(object sender, EventArgs e)
        {

        }
    }
}
