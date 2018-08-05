namespace KiRA.BusinessLogicLayer
{
    public static class Texts
    {

        public static class DataTableNames
        {        
            public static string Person
            {
                get { return "Person"; }
            }
        }

        public static class PersonProperties
        {
            public static string ID
            {
                get { return "ID"; }
            }

            public static string Username
            {
                get { return "Username"; }
            }

            public static string Password
            {
                get { return "Password"; }
            }

            public static string Email
            {
                get { return "Email"; }
            }
            public static string Name
            {
                get { return "Name"; }
            }
            public static string Gender
            {
                get { return "Gender"; }
            }
            public static string RegisterNumber
            {
                get { return "RegisterNumber"; }
            }
            public static string Company
            {
                get { return "Company"; }
            }
            public static string CostCenter
            {
                get { return "CostCenter"; }
            }
            public static string Position
            {
                get { return "Position"; }
            }
            public static string DateOfStart
            {
                get { return "DateOfStart"; }
            }
            public static string DateOfBirth
            {
                get { return "DateOfBirth"; }
            }
            public static string NumberOfChildren
            {
                get { return "NumberOfChildren"; }
            }
            public static string NumberOfDisabledChildren
            {
                get { return "NumberOfDisabledChildren"; }
            }

            public static string NumberOfNewBornBabies
            {
                get { return "NumberOfNewBornBabies"; }
            }

            public static string HealthDamage
            {
                get { return "HealthDamage"; }
            }
        }
       
        public static class ErrorMessages
        {

            public static string WrongUsernamePassword
            {
                get
                {
                    if (LogInfo.Language == "HUN") { return "Nem megfelelő felhasználónév vagy jelszó."; }
                    else { return "Username or password is wrong."; }
                }
            }

            public static string FieldIsEmpty
            {
                get
                {
                    if (LogInfo.Language == "HUN") { return " mező üres."; }
                    else { return " field is empty."; }
                }
            }

        }

        public static class Captions
        {

            public static string LoginFailed
            {
                get
                {
                    if (LogInfo.Language == "HUN") { return "Bejelentkezés sikertelen"; }
                    else { return "Login failed"; }
                }
            }


            public static string EmptyRequiredField
            {
                get
                {
                    if (LogInfo.Language == "HUN") { return "Üres kötelező mező"; }
                    else { return "Empty reqired field"; }
                }
            }    
        }

        public static class Languages
        {
            public static string HUN
            {
                get { return "HUN"; }
            }

            public static string ENG
            {
                get { return "ENG"; }
            }
        }

    }
}

