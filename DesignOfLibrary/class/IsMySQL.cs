using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignOfLibrary
{
    public class IsMySQL
    {
        private
            String settings;


        public IsMySQL(String setting = "")
        {
            if (setting != "")
            {
                settings = setting;
            }

        }

        /// <summary>
        /// Set Settings
        /// </summary>
        /// <param name="setting">String of settings</param>
        public void SetSettings(String setting)
        {
            settings = setting;
        }

        ~IsMySQL()
        {

        }

        /// <summary>
        /// SQL request
        /// </summary>
        /// <param name="strSQL">SQL request</param>
        /// <param name="maxCout">Max of returns collums</param>
        /// <returns>String[][], where 1)[] row, 2)[] column</returns>
        public String[][] SQLRequest(String strSQL, int maxCout)
        {
            MySqlConnection myConnection;
        start:;
            //MySqlCommand myCommand = new MySqlCommand("MySQL script", myConnection);
            try
            {
                myConnection = new MySqlConnection(settings);
                myConnection.Open();
            }
            catch (Exception ex)
            {
                Console.Out.Write("SQLRequest error\n" + ex.ToString());
                goto start;
            }
            String[][] strReturn = new String[0][];
            String[][] strHelpReturn = new String[0][];
            try
            {
                MySqlCommand cmd;
                //string strSQL = "SELECT Code, Article, Manufacturer, Name, Barcode FROM SKU";
                cmd = new MySqlCommand(strSQL, myConnection);
                MySqlDataReader rdr = cmd.ExecuteReader();

                for (int i = 1; rdr.Read(); i++)
                {
                    for (int j = 1; j <= strHelpReturn.Length; j++)
                    {

                        strHelpReturn[j - 1] = new String[strReturn[j - 1].Length];
                        strHelpReturn[j - 1] = strReturn[j - 1];

                    }
                    strReturn = new String[i][];
                    for (int j = 1; j <= strHelpReturn.Length; j++)
                    {

                        strReturn[j - 1] = new String[strHelpReturn[j - 1].Length];
                        strReturn[j - 1] = strHelpReturn[j - 1];

                    }

                    strReturn[i - 1] = new String[maxCout];
                    for (int y = 0; y < maxCout; y++)
                    {
                        strReturn[i - 1][y] = rdr[y].ToString();
                    }

                    strHelpReturn = new String[i][];

                }
                myConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.Write(ex);
            }
            return strReturn;
        }

        /// <summary>
        /// Does request valide?
        /// </summary>
        /// <param name="strSQL">SQL request</param>
        /// <returns>False = Error to do this command. True = this request is valide</returns>
        public bool SQLIsNullRequest(String strSQL)
        {

            MySqlConnection myConnection = new MySqlConnection(settings);
            MySqlCommand myCommand = new MySqlCommand("MySQL script", myConnection);
            try
            {
                myConnection.Open();

                MySqlCommand cmd;
                //string strSQL = "SELECT Code, Article, Manufacturer, Name, Barcode FROM SKU";

                cmd = new MySqlCommand(strSQL, myConnection);
                MySqlDataReader rdr;
                //

                rdr = cmd.ExecuteReader();
                if (!rdr.Read())
                {
                    myConnection.Close();
                    Debug.Print("IsNull");
                    return false;
                }
            }
            catch (Exception ex)
            {
                myConnection.Close();
                Debug.Print(ex.ToString());
                return false;
            }

            myConnection.Close();
            return true;
        }

        /// <summary>
        /// SQL INSERT request
        /// </summary>
        /// <param name="strSQL">SQL request</param>
        /// <returns>True = All good. False = Cant does</returns>
        public bool SQLInsertRequest(String strSQL)
        {
            MySqlConnection myConnection = new MySqlConnection(settings);
            MySqlCommand myCommand = new MySqlCommand("MySQL script", myConnection);
            myCommand.CommandText = strSQL;
            myConnection.Open();

            new MySqlCommand(strSQL, myConnection);
            //
            try
            {
                myCommand.ExecuteNonQuery();
                myConnection.Close();
                return true;
            }
            catch (Exception ex)
            {
                myConnection.Close();
                Debug.Print("PLOHO(Insert): " + ex.ToString() + "\n\n" + strSQL);
                return false;
            }

        }
        static public String formatDate(DateTimePicker dtPicker)
        {
            return dtPicker.Value.Year.ToString() + "." + dtPicker.Value.Month.ToString() + "." + dtPicker.Value.Day.ToString();
        }
    }
}