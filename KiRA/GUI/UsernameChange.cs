using System;
using System.Windows.Forms;
using KiRA.BusinessLogicLayer;

namespace KiRA.GUI
{
    public partial class UsernameChange : UserControl
    {
        Settings _settings;

        public UsernameChange()
        {
            InitializeComponent();
        }

        private void btnUNameChange_Click(object sender, EventArgs e)
        {
            try
            {
                _settings = new Settings();

                if (_settings.OldValueValidation(Texts.PersonProperties.Username, tbOldUsername.Text))
                {
                    MessageBox.Show(Texts.ErrorMessages.WrongOldUsername, Texts.Captions.WrongOldValue, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbOldUsername.Text = string.Empty;
                    return;
                }

                if (tbNewUsername.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(lNewUsername.Text + Texts.ErrorMessages.FieldIsEmpty, Texts.Captions.EmptyRequiredField, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbNewUsernameAgain.Text.Trim() == string.Empty)
                {
                    MessageBox.Show(lNewUsernameAgain.Text + Texts.ErrorMessages.FieldIsEmpty, Texts.Captions.EmptyRequiredField, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbNewUsername.Text == tbNewUsernameAgain.Text)
                {
                    MessageBox.Show(Texts.ErrorMessages.NewUsernamesMismatched, Texts.Captions.MissmatchadUsernames, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNewUsernameAgain.Text = string.Empty;
                    return;
                }

                _settings.SetNewValue(Texts.PersonProperties.Username, tbOldUsername.Text, tbNewUsername.Text);
                MessageBox.Show(Texts.InformationMessages.PasswordChanged, Texts.Captions.SuccessfulChange, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogInfo.UserName = tbNewUsername.Text;
                tbOldUsername.Text = string.Empty;
                tbNewUsername.Text = string.Empty;
                tbNewUsernameAgain.Text = string.Empty;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "\r\n\r\n" + error.GetBaseException().ToString(), error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
