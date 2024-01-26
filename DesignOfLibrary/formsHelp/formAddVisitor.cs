using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignOfLibrary.formsHelp
{
    public partial class formAddVisitor : Form
    {
        int idWorker;

        IsMySQL myConnectionToMySql;
        public formAddVisitor(IsMySQL myConnectionToMySql, int idWorker)
        {
            this.idWorker = idWorker;
            this.myConnectionToMySql = myConnectionToMySql;
            InitializeComponent();
        }

        private void formAddVisitor_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbFIO.Text != "" && tbPassport.Text != "" && tbPhone.Text != "" && dtPicker.Value != null && tbMail.Text != "")
            {
                myConnectionToMySql.SQLInsertRequest("INSERT INTO `visitor` (`Name`, `Passport`, `Phone`, `Male`, `Date`, `Mail`, `DateStart`, `Code_workers`) VALUES ('" + tbFIO.Text + "', '" + tbPassport.Text + "', '" + tbPhone.Text + "', '" + (cbM.Checked.Equals(true) ? 1 : 0) + "', '" + IsMySQL.formatDate(dtPicker) + "', '" + tbMail.Text + "', NOW(), '" + idWorker + "')");
                MessageBox.Show("Успешно!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Не все данные указаны!");
            }
        }

        private void cbM_Click(object sender, EventArgs e)
        {
            cbM.Checked = true;
            cbM.Enabled = false;
            cbJ.Checked = false;
            cbJ.Enabled = true;
        }

        private void cbJ_Click(object sender, EventArgs e)
        {
            cbM.Checked = false;
            cbM.Enabled = true;
            cbJ.Checked = true;
            cbJ.Enabled = false;
        }
    }
}
