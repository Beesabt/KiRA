using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KiRA.DataAccessLayer
{
    class DatabaseHandler
    {
        private SQLiteConnection sqlite;
        string _sResult = string.Empty;
        int _iResult = 0;

        public DatabaseHandler()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            sqlite = new SQLiteConnection(@"Data Source = |DataDirectory|\ApplicationFiles\DataBase\KiRA_Database.db; Version = 3;");
        }


        private int ExecuteScalar(string command)
        {
           
            try
            {
                SQLiteCommand cmd;
                cmd = sqlite.CreateCommand();
                cmd.CommandText = command;
                sqlite.Open();
                var obj = cmd.ExecuteScalar();
                if (obj == null) { return 0; }
                _iResult = Convert.ToInt32(obj);
            }
            catch (SQLiteException error)
            {
                MessageBox.Show(error.Message);
                sqlite.Close();
            }
            sqlite.Close();
            return _iResult;
        }

        private string GetString(string command)
        {
           
            try
            {
                SQLiteCommand cmd;
                cmd = sqlite.CreateCommand();
                cmd.CommandText = command;
                sqlite.Open();
                var obj = cmd.ExecuteScalar();
                if (obj == null || string.IsNullOrEmpty(obj.ToString()))
                {
                    return string.Empty;
                }
                else
                {
                    _sResult = obj.ToString();
                }
            }
            catch (SQLiteException error)
            {
                MessageBox.Show(error.Message);
                sqlite.Close();
            }
            sqlite.Close();
            return _sResult;         
        }


        #region Login.cs

        public bool LoginValidationDB(string Username, string Password)
        {
            bool isSuccess = false;
            string cmd = string.Format("SELECT COUNT({1}) FROM {0} WHERE {1}='{2}' and {3}='{4}'", BusinessLogicLayer.Texts.DataTableNames.Person,
                BusinessLogicLayer.Texts.PersonProperties.Username, Username, BusinessLogicLayer.Texts.PersonProperties.Password, Password);
            if (ExecuteScalar(cmd) != 0) isSuccess = true;
            return isSuccess;
        }

        public int GetUserID(string Username, string Password)
        {
            string cmd = string.Format("SELECT {0} FROM {1} WHERE {2}='{3}' AND {4}='{5}'", BusinessLogicLayer.Texts.PersonProperties.ID, BusinessLogicLayer.Texts.DataTableNames.Person,
                 BusinessLogicLayer.Texts.PersonProperties.Username, Username, BusinessLogicLayer.Texts.PersonProperties.Password, Password);
            _iResult = ExecuteScalar(cmd);
            return _iResult;
        }

        #endregion

        #region Home.cs

        public string GetPassword(string Username)
        {
            string cmd = string.Format("SELECT {0} FROM {1} WHERE {2}='{3}'", BusinessLogicLayer.Texts.PersonProperties.Password, BusinessLogicLayer.Texts.DataTableNames.Person,
                 BusinessLogicLayer.Texts.PersonProperties.Username, Username);
            _sResult = GetString(cmd);
            return _sResult;
        }

        #endregion
    }
}
