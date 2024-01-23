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
    public partial class formMainMenu : Form
    {
        IsMySQL myConnetionToMySql = new IsMySQL();
        String settings;
        public formMainMenu(String settings)
        {
            this.settings = settings;
            InitializeComponent();
        }

        private void formMainMenu_Load(object sender, EventArgs e)
        {

            myConnetionToMySql.SetSettings(settings);
           String p = myConnetionToMySql.SQLRequest("SELECT SUM(`Quatity`) FROM `Metrics`;", 1)[0][0];
        }
    }
}
