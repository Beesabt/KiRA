using KiRA.BusinessLogicLayer;
using System;
using System.Windows.Forms;

namespace KiRA.GUI
{
    public partial class HomePage : Form
    {
        int _togMove;
        int _mValX;
        int _mValY;
        public HomePage()
        {
            InitializeComponent();
        }

        private void MainPage_Shown(object sender, EventArgs e)
        {
            try
            {
                Home _home = new Home();
                if (_home.DefaultLoginValidation(LogInfo.UserName))
                {
                    MessageBox.Show(BusinessLogicLayer.Texts.ErrorMessages.DefaultUsernameOrPassword, BusinessLogicLayer.Texts.Captions.DefaultLoginParameters, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Hide();
            SettingsPage _settingsPage = new SettingsPage();
            _settingsPage.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            //Hide();
            //StatisticsPage _statisticsPage = new StatisticsPage();
            //_statisticsPage.Show();
        }

        private void btnWorkingHours_Click(object sender, EventArgs e)
        {
            //Hide();
            //WorkingHoursPage _workingHoursPage = new WorkingHoursPage();
            //_workingHoursPage.Show();
        }

        private void btnHolidays_Click(object sender, EventArgs e)
        {
            //Hide();
            //HolidaysPage _holidaysPage = new HolidaysPage();
            //_holidaysPage.Show();
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
