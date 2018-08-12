using System;
using System.Windows.Forms;
using KiRA.BusinessLogicLayer;
using KiRA.ValueObjects;

namespace KiRA.GUI
{
    public partial class PersonalInformation : UserControl
    {

        Settings _settings;
        Person _person;

        public PersonalInformation()
        {
            InitializeComponent();
        }

        private void tlpPersonalInformation_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                _settings = new Settings();
                _person = new Person();

                _person = _settings.GetPersonalInformation();

                lNameFromDatabase.Text = _person.Name;
                lRegisterNumberFromDatabase.Text = _person.RegisterNumber.ToString();
                lCompanyFromDatabase.Text = _person.Company;
                lCostCenterFromDatabase.Text = _person.CostCenter;
                lPositionFromDatabase.Text = _person.Position;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "\r\n\r\n" + error.GetBaseException().ToString(), error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            try
            {
             
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "\r\n\r\n" + error.GetBaseException().ToString(), error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
