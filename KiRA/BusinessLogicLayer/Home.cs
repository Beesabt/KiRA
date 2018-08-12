using KiRA.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiRA.BusinessLogicLayer
{
    class Home
    {
        DatabaseHandler _DBHandler;

        public bool DefaultLoginValidation(string Username)
        {
            bool isSuccess = false;
            string _password = string.Empty;     
            _DBHandler = new DatabaseHandler();
            _password = _DBHandler.GetPassword(Username);
            if (LogInfo.UserName == "KiRA" || _password == "Admin") isSuccess = true;
            return isSuccess;
        }

    }
}
