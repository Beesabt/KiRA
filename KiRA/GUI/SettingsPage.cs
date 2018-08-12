using KiRA.ValueObjects;
using System;
using System.Windows.Forms;
using System.Data;
using KiRA.BusinessLogicLayer;
using KiRA.GUI;

namespace KiRA.GUI
{
    public partial class SettingsPage : Form
    {
        int _togMove;
        int _mValX;
        int _mValY;
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            try
            {
                UCpersonalInformation.BringToFront();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnTaskManager_Click(object sender, EventArgs e)
        {
            UCtaskManager.BringToFront();            
        }

        private void btnUsername_Click(object sender, EventArgs e)
        {
           UCusernameChange.BringToFront(); 
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
           UCpasswordChange.BringToFront(); 
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Hide();
            HomePage _homePage = new HomePage();
            _homePage.Show();
        }

        private void btnPersonalInformation_Click(object sender, EventArgs e)
        {
            UCpersonalInformation.BringToFront();
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
