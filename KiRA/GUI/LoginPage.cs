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
        bool _bTogMove;
        int _iValX;
        int _iValY;
        Login _login;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbEmail.Select();
            btnLogin.Focus();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbEmail.Text))
                {
                    MessageBox.Show(lEmail.Text.Trim(':') + BusinessLogicLayer.Texts.ErrorMessages.FieldIsEmpty, BusinessLogicLayer.Texts.Captions.EmptyRequiredField, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(tbPassword.Text))
                {
                    MessageBox.Show(lPassword.Text.Trim(':') + BusinessLogicLayer.Texts.ErrorMessages.FieldIsEmpty, BusinessLogicLayer.Texts.Captions.EmptyRequiredField, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _login = new Login();

                if (!_login.LoginValidation(tbEmail.Text, tbPassword.Text))
                {
                    MessageBox.Show(BusinessLogicLayer.Texts.ErrorMessages.WrongEmailPassword, BusinessLogicLayer.Texts.Captions.LoginFailed, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbPassword.Text = string.Empty;
                    tbEmail.Text = string.Empty;
                    return;
                }

                HomePage _homepage = new HomePage();
                LogInfo.Email = tbEmail.Text;
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
            _bTogMove = false;
        }

        private void pHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _bTogMove = true;
            _iValX = e.X;
            _iValY = e.Y;
        }

        private void pHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_bTogMove)
            {
                SetDesktopLocation(MousePosition.X - _iValX, MousePosition.Y - _iValY);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle borderRectangle = new Rectangle(0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            e.Graphics.DrawRectangle(Pens.Black, borderRectangle);
            base.OnPaint(e);
        }

    }
}
