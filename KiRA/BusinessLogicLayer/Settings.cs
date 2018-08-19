using KiRA.DataAccessLayer;
using KiRA.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data;

namespace KiRA.BusinessLogicLayer
{
    class Settings
    {

        DatabaseHandler _DBHandler;
        DataTable _dataTable;
        Person _actualPerson;

        public Settings()
        {

        }

        public Person GetPersonalInformation()
        {

            _actualPerson = new Person();
            _DBHandler = new DatabaseHandler();
            _dataTable = _DBHandler.GetPersonalInformationDB();

            foreach (DataRow person in _dataTable.Rows)
            {
                #region Password
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.Password]))
                {
                    _actualPerson.Password = person[Texts.PersonProperties.Password].ToString();
                }
                else
                {
                    _actualPerson.Password = string.Empty;
                }
                #endregion
                #region Email
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.Email]))
                {
                    _actualPerson.Email = person[Texts.PersonProperties.Email].ToString();
                }
                else
                {
                    _actualPerson.Email = string.Empty;
                }
                #endregion
                #region Name
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.Name]))
                {
                    _actualPerson.Name = person[Texts.PersonProperties.Name].ToString();
                }
                else
                {
                    _actualPerson.Name = string.Empty;
                }
                #endregion
                #region Gender
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.Gender]))
                {
                    _actualPerson.Gender = Convert.ToBoolean(person[Texts.PersonProperties.Gender]);
                }
                else
                {
                    _actualPerson.Gender = true;
                }
                #endregion
                #region RegisterNumber
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.RegisterNumber]))
                {
                    _actualPerson.RegisterNumber = Convert.ToInt32(person[Texts.PersonProperties.RegisterNumber]);
                }
                else
                {
                    _actualPerson.RegisterNumber = 0;
                }
                #endregion
                #region Company
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.Company]))
                {
                    _actualPerson.Company = person[Texts.PersonProperties.Company].ToString();
                }
                else
                {
                    _actualPerson.Company = string.Empty;
                }
                #endregion
                #region CostCenter
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.CostCenter]))
                {
                    _actualPerson.CostCenter = person[Texts.PersonProperties.CostCenter].ToString();
                }
                else
                {
                    _actualPerson.CostCenter = string.Empty;
                }
                #endregion
                #region Position
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.Position]))
                {
                    _actualPerson.Position = person[Texts.PersonProperties.Position].ToString();
                }
                else
                {
                    _actualPerson.Position = string.Empty;
                }
                #endregion
                #region WorkingHours
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.WorkingHours]))
                {
                    _actualPerson.RegisterNumber = Convert.ToInt32(person[Texts.PersonProperties.WorkingHours]);
                }
                else
                {
                    _actualPerson.WorkingHours = 0;
                }
                #endregion
                #region DateOfStart
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.DateOfStart]))
                {
                    _actualPerson.DateOfStart = Convert.ToDateTime(person[Texts.PersonProperties.DateOfStart]);
                }
                else
                {
                    _actualPerson.DateOfStart = DateTime.Today;
                }
                #endregion
                #region DateOfBirth
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.DateOfBirth]))
                {
                    _actualPerson.DateOfBirth = Convert.ToDateTime(person[Texts.PersonProperties.DateOfBirth]);
                }
                else
                {
                    _actualPerson.DateOfBirth = DateTime.Today;
                }
                #endregion
                #region NumberOfChildren
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.NumberOfChildren]))
                {
                    _actualPerson.NumberOfChildren = Convert.ToInt32(person[Texts.PersonProperties.NumberOfChildren]);
                }
                else
                {
                    _actualPerson.NumberOfChildren = 0;
                }
                #endregion
                #region NumberOfDisabledChildren
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.NumberOfDisabledChildren]))
                {
                    _actualPerson.NumberOfDisabledChildren = Convert.ToInt32(person[Texts.PersonProperties.NumberOfDisabledChildren]);
                }
                else
                {
                    _actualPerson.NumberOfDisabledChildren = 0;
                }
                #endregion
                #region NumberOfNewBornBabies
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.NumberOfNewBornBabies]))
                {
                    _actualPerson.NumberOfNewBornBabies = Convert.ToInt32(person[Texts.PersonProperties.NumberOfNewBornBabies]);
                }
                else
                {
                    _actualPerson.NumberOfNewBornBabies = 0;
                }
                #endregion
                #region HealthDamage
                if (!DBNull.Value.Equals(person[Texts.PersonProperties.HealthDamage]))
                {
                    _actualPerson.HealthDamage = Convert.ToBoolean(person[Texts.PersonProperties.HealthDamage]);
                }
                else
                {
                    _actualPerson.HealthDamage = false;
                }
                #endregion
            }

            return _actualPerson;
        }


        public bool OldValueValidation(string Key, string Value)
        {
            bool isSuccess = false;
            _DBHandler = new DatabaseHandler();
            isSuccess = _DBHandler.OldValueValidationDB(Key, Value);
            return isSuccess;          
        }

        public bool SetNewValue(string Key, string OldValue, string NewValue)
        {
            int updatedRow = 0;
            bool isSuccess = false;
            _DBHandler = new DatabaseHandler();
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add(Key, NewValue);
            isSuccess = _DBHandler.SetNewValueDB(data, Key, OldValue, updatedRow);
            return isSuccess;
        }

        public bool SetNewValues(string Key, string OldValue, Dictionary<string, string> data)
        {
            int updatedRow = 0;
            bool isSuccess = false;
            _DBHandler = new DatabaseHandler();
            isSuccess = _DBHandler.SetNewValueDB(data, Key, OldValue, updatedRow);
            return isSuccess;
        }
    }

}

