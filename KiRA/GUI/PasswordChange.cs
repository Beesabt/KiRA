using System;
using System.Windows.Forms;
using KiRA.BusinessLogicLayer;

namespace KiRA.GUI
{
    public partial class PasswordChange : UserControl
    {
        Settings _settings;

        public PasswordChange()
        {
            InitializeComponent();
        }

        private void btnPasswordChange_Click(object sender, EventArgs e)
        {
            try
            {
                _settings = new Settings();

                if (!_settings.OldValueValidation(Texts.PersonProperties.Password, tbOldPassword.Text))
                {
                    MessageBox.Show(Texts.ErrorMessages.WrongOldPassword, Texts.Captions.WrongOldValue, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbOldPassword.Text = string.Empty;
                    return;
                }

                if (string.IsNullOrEmpty(tbNewPassword.Text.Trim()))
                {
                    MessageBox.Show(lNewPassword.Text + Texts.ErrorMessages.FieldIsEmpty, Texts.Captions.EmptyRequiredField, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(tbNewPasswordAgain.Text.Trim()))
                {
                    MessageBox.Show(lNewPasswordAgain.Text + Texts.ErrorMessages.FieldIsEmpty, Texts.Captions.EmptyRequiredField, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tbNewPassword.Text == tbNewPasswordAgain.Text)
                {
                    MessageBox.Show(Texts.ErrorMessages.NewPasswordsMismatched, Texts.Captions.MissmatchadPasswords, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbNewPasswordAgain.Text = string.Empty;
                    return;
                }

                _settings.SetNewValue(Texts.PersonProperties.Password, tbOldPassword.Text, tbNewPassword.Text);
                MessageBox.Show(Texts.InformationMessages.PasswordChanged, Texts.Captions.SuccessfulChange, MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbOldPassword.Text = string.Empty;
                tbNewPassword.Text = string.Empty;
                tbNewPasswordAgain.Text = string.Empty;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "\r\n\r\n" + error.GetBaseException().ToString(), error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
    }
}
