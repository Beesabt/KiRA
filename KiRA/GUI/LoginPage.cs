using KiRA.BusinessLogicLayer;
using System;
using System.Drawing;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;


namespace KiRA.GUI
{
    public partial class LoginPage : Form
    {
        int _togMove;
        int _mValX;
        int _mValY;
        Login _login;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbUsername.Select();
            btnLogin.Focus();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbUsername.Text))
                {
                    MessageBox.Show(lUsername.Text + BusinessLogicLayer.Texts.ErrorMessages.FieldIsEmpty, BusinessLogicLayer.Texts.Captions.EmptyRequiredField, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(tbPassword.Text))
                {
                    MessageBox.Show(lPassword.Text + BusinessLogicLayer.Texts.ErrorMessages.FieldIsEmpty, BusinessLogicLayer.Texts.Captions.EmptyRequiredField, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _login = new Login();

                if (!_login.LoginValidation(tbUsername.Text, tbPassword.Text))
                {
                    MessageBox.Show(BusinessLogicLayer.Texts.ErrorMessages.WrongUsernamePassword, BusinessLogicLayer.Texts.Captions.LoginFailed, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPassword.Text = string.Empty;
                    tbUsername.Text = string.Empty;
                    return;
                }

                HomePage _homepage = new HomePage();
                LogInfo.UserName = tbUsername.Text;
                Hide();
                _homepage.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + "\r\n\r\n" + error.GetBaseException().ToString(), error.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
        }      

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimalize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pHeader_MouseUp(object sender, MouseEventArgs e)
        {
            _togMove = 0;
        }

        private void pHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _togMove = 1;
            _mValX = e.X;
            _mValY = e.Y;
        }

        private void pHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_togMove == 1)
            {
                SetDesktopLocation(MousePosition.X - _mValX, MousePosition.Y - _mValY);
            }
        }

    }
}
