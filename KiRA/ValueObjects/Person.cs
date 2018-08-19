using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiRA.ValueObjects
{
    class Person
    {
        #region Members

        private int _ID;
        private string _Password;
        private string _Email;
        private string _Name;
        private bool _Gender;
        private int _RegisterNumber;
        private string _Company;
        private string _CostCenter;
        private string _Position;
        private int _WorkingHours;
        private DateTime _DateOfStart;
        private DateTime _DateOfBirth;
        private int _NumberOfChildren;
        private int _NumberOfDisabledChildren;
        private int _NumberOfNewBornBabies;
        private bool _HealthDamage;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        public bool Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        public int RegisterNumber
        {
            get { return _RegisterNumber; }
            set { _RegisterNumber = value; }
        }

        public string Company
        {
            get { return _Company; }
            set { _Company = value; }
        }

        public string CostCenter
        {
            get { return _CostCenter; }
            set { _CostCenter = value; }
        }

        public string Position
        {
            get { return _Position; }
            set { _Position = value; }
        }

        public int WorkingHours
        {
            get { return _WorkingHours; }
            set { _WorkingHours = value; }
        }

        public DateTime DateOfStart
        {
            get { return _DateOfStart; }
            set { _DateOfStart = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }

        public int NumberOfChildren
        {
            get { return _NumberOfChildren; }
            set { _NumberOfChildren = value; }
        }

        public int NumberOfDisabledChildren
        {
            get { return _NumberOfDisabledChildren; }
            set { _NumberOfDisabledChildren = value; }
        }

        public int NumberOfNewBornBabies
        {
            get { return _NumberOfNewBornBabies; }
            set { _NumberOfNewBornBabies = value; }
        }

        public bool HealthDamage
        {
            get { return _HealthDamage; }
            set { _HealthDamage = value; }
        }


        #endregion

        /// <summary>
        /// Constructor of the People table in the Database.
        /// </summary>
        /// <param name="ID">ID of the user.</param>
        /// <param name="Password">Password of the user.</param>
        /// <param name="Email">Email address of the user.</param>
        /// <param name="Name">Name of the user.</param>
        /// <param name="Gender">Gender of the user. 0 - female, 1 - male </param>
        /// <param name="RegisterNumber">Register number of the user.</param>
        /// <param name="Company">Compay name where the user works.</param>
        /// <param name="CostCenter">Cost center of the user.</param>
        /// <param name="Position">Position of the user at his/her company.</param>
        /// <param name="WorkingHours">Hours what the employee has to takes in the office.</param>
        /// <param name="DateOfStart">First date of work.</param>
        /// <param name="DateOfBirth">Birth date of the user.</param>
        /// <param name="NumberOfChildren">Number of the user's children.</param>
        /// <param name="NumberOfDisabledChildren">Number of the user's disabled children.</param>
        /// <param name="NumberOfNewBornBabies">If the user is male then he gets extra holidays after new born babies.</param>
        /// <param name="HealthDamage">If the user has 50% health damage then he gets extra holidays.</param>
        public Person(int ID, string Password, string Email, string Name, bool Gender, int RegisterNumber, string Company,
            string CostCenter, string Position, int WorkingHours, DateTime DateOfStart, DateTime DateOfBirth,
            int NumberOfChildren, int NumberOfDisabledChildren, int NumberOfNewBornBabies, bool HealthDamage)
        {
            _ID = ID;
            _Password = Password;
            _Email = Email;
            _Name = Name;
            _Gender = Gender;
            _RegisterNumber = RegisterNumber;
            _Company = Company;
            _CostCenter = CostCenter;
            _Position = Position;
            _WorkingHours = WorkingHours;
            _DateOfStart = DateOfStart;
            _DateOfBirth = DateOfBirth;
            _NumberOfChildren = NumberOfChildren;
            _NumberOfDisabledChildren = NumberOfDisabledChildren;
            _NumberOfNewBornBabies = NumberOfNewBornBabies;
            _HealthDamage = HealthDamage;
        }

        /// <summary>
        /// Constructor of the People table in the Database without parameters.
        /// </summary>
        public Person()
        {

        }
    }
}

