using KiRA.DataAccessLayer;

namespace KiRA.BusinessLogicLayer
{
    class Login
    {
        DatabaseHandler _DBHandler;

        public bool LoginValidation(string Username, string Password)
        {
            bool isSuccess = false;
            _DBHandler = new DatabaseHandler();
            isSuccess = _DBHandler.LoginValidationDB(Username, Password);
            if (isSuccess)
            {
                LogInfo.UserID = _DBHandler.GetUserID(Username, Password).ToString();
                LogInfo.UserName = Username;
            }
            return isSuccess;
        }

    }
}
