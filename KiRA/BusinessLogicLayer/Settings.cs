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
                _actualPerson.Username = person[Texts.PersonProperties.Username].ToString();
                _actualPerson.Password = person[Texts.PersonProperties.Password].ToString();
                _actualPerson.Email = person[Texts.PersonProperties.Email].ToString();
                _actualPerson.Name = person[Texts.PersonProperties.Name].ToString();
                _actualPerson.Gender = Convert.ToBoolean(person[Texts.PersonProperties.Gender]);
                _actualPerson.RegisterNumber = Convert.ToInt32(person[Texts.PersonProperties.RegisterNumber]);
                _actualPerson.Company = person[Texts.PersonProperties.Company].ToString();
                _actualPerson.CostCenter = person[Texts.PersonProperties.CostCenter].ToString();
                _actualPerson.Position = person[Texts.PersonProperties.Position].ToString();
                _actualPerson.DateOfStart = Convert.ToDateTime(person[Texts.PersonProperties.DateOfStart]);
                _actualPerson.DateOfBirth = Convert.ToDateTime(person[Texts.PersonProperties.DateOfBirth]);
                _actualPerson.NumberOfChildren = Convert.ToInt32(person[Texts.PersonProperties.NumberOfChildren]);
                _actualPerson.NumberOfDisabledChilden = Convert.ToInt32(person[Texts.PersonProperties.NumberOfDisabledChildren]);
                _actualPerson.NumberOfNewBornBabies = Convert.ToInt32(person[Texts.PersonProperties.NumberOfNewBornBabies]);
                _actualPerson.HealthDamage = Convert.ToBoolean(person[Texts.PersonProperties.HealthDamage]);
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

