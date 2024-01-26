using DesignOfLibrary.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignOfLibrary
{
    public partial class formLogin : Form
    {
        IsMySQL myConnectionToMySql;
        String[][] result;
        int idWorker;
        public formLogin(IsMySQL myConnectionToMySql)
        {
            this.myConnectionToMySql = myConnectionToMySql;
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            result = myConnectionToMySql.SQLRequest("SELECT Code, Name FROM workers WHERE IsFair = 0", 2);

            cbWorkers.Items.Clear();
            foreach (String[] row in result)
            {
                cbWorkers.Items.Add(row[1]);
            }
            cbWorkers.SelectedIndex = 0;
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            Thread tr1 = new Thread(formMainMenuThread);
            idWorker = Int32.Parse(result[cbWorkers.SelectedIndex][0]);
            tr1.Start();
            this.Close();
        }
        private void formMainMenuThread()
        {
            formMainMenu form = new formMainMenu(myConnectionToMySql, idWorker);
            Application.Run(form);
        }
    }
}
