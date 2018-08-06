using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KiRA.DataAccessLayer
{
    class DatabaseHandler
    {
        private SQLiteConnection sqlite;

        public DatabaseHandler()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            sqlite = new SQLiteConnection(@"Data Source = |DataDirectory|\ApplicationFiles\DataBase\KiRA_Database.db; Version = 3;");
        }


        private int ExecuteScalar(string command)
        {
            int _result = 0;

            try
            {
                SQLiteCommand cmd;
                cmd = sqlite.CreateCommand();
                cmd.CommandText = command;
                sqlite.Open();
                var obj = cmd.ExecuteScalar();
                if (obj == null) { return 0; }
                _result = Convert.ToInt32(obj);
            }
            catch (SQLiteException error)
            {
                MessageBox.Show(error.Message);
                sqlite.Close();
            }
            sqlite.Close();
            return _result;
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
            int _result = 0;
            string cmd = string.Format("SELECT {0} FROM {1} WHERE {2}='{3}' AND {4}='{5}'", BusinessLogicLayer.Texts.PersonProperties.ID, BusinessLogicLayer.Texts.DataTableNames.Person,
                 BusinessLogicLayer.Texts.PersonProperties.Username, Username, BusinessLogicLayer.Texts.PersonProperties.Password, Password);
            _result = ExecuteScalar(cmd);
            return _result;
        }
        #endregion
    }
}
