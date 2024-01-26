using DesignOfLibrary.forms;
using DesignOfLibrary.formsHelp;
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
        IsMySQL myConnectionToMySql;
        int idWorker;
        public formMainMenu(IsMySQL myConnectionToMySql, int idWorker)
        {
            this.myConnectionToMySql = myConnectionToMySql;
            this.idWorker = idWorker;
            InitializeComponent();
        }

        private void formMainMenu_Load(object sender, EventArgs e)
        {
            
            
            String p = myConnectionToMySql.SQLRequest("SELECT Name FROM `workers`", 1)[0][0];
            labelNameWorker.Text = p;
        }

        private void formFindAbonementThread()
        {
            formSearchVisitor form = new formSearchVisitor(myConnectionToMySql, this.labelNameWorker, idWorker);
            Application.Run(form);
        }

        private void btFindAbonement_Click(object sender, EventArgs e)
        {
            Thread tr1 = new Thread(formFindAbonementThread);
            tr1.Start();
        }
        private void formAddAbonementThread()
        {
            formAddVisitor form = new formAddVisitor(myConnectionToMySql, idWorker);
            Application.Run(form);
        }

        private void btAddAbonement_Click(object sender, EventArgs e)
        {
            Thread tr1 = new Thread(formAddAbonementThread);
            tr1.Start();
        }

        private void btBooks_Click(object sender, EventArgs e)
        {

        }

        private void btStatistics_Click(object sender, EventArgs e)
        {

        }
    }
}
