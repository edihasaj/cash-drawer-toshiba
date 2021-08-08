using OposCashDrawer_CCO;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SirtariToshiba
{
    public partial class Sirtari : Form
    {
        private int _secureId = 0;
        private readonly OPOSCashDrawer _drawer;

        public Sirtari(int secureId = 0)
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            _secureId = secureId;
            _drawer = new OPOSCashDrawer();
        }

        public int OpenDrawer()
        {
            long cashDrawerResult = 1;

            _drawer.Open("CashDrawer");
            _drawer.ClaimDevice(200);
            _drawer.DeviceEnabled = true;

            if (_drawer.DrawerOpened)
            {
                _secureId = 1;
                return _secureId;
            }
            else if (_secureId == 0)
            {
                MessageBox.Show("Për siguri, sirtari duhet të hapet manualisht herën e parë.");

                int x = 0;
                while ((!_drawer.DrawerOpened) && x++ < 5)
                {
                    Thread.Sleep(2000);
                }

                if (!_drawer.DrawerOpened)
                {
                    cashDrawerResult = 0;
                    MessageBox.Show("Hapja e sirtarit deshtoj. Hapja manuale nuk u detektua!");
                }
                else
                {
                    _secureId = 1;
                    MessageBox.Show("Hapja manuale u detektua, tani mbyll sirtarin.");

                    int x2 = 0;
                    while ((_drawer.DrawerOpened) && x2++ < 3)
                    {
                        Thread.Sleep(2000);
                    }

                    if (_drawer.DrawerOpened)
                    {
                        cashDrawerResult = 0;
                        MessageBox.Show("Sirtari i mbyllur nuk u detektua.");
                    }
                }
            }

            if (cashDrawerResult == 1)
            {
                cashDrawerResult = _drawer.OpenDrawer();
                _secureId = 1;
            }

            _drawer.DeviceEnabled = false;
            _drawer.ReleaseDevice();
            _drawer.Close();
            Close();

            return _secureId;
        }

        private void Sirtari_Load(object sender, EventArgs e)
        {
        }

        private void openCashDrawer_Click(object sender, EventArgs e)
        {
            OpenDrawer();
        }

        private void waitCashDrawerOpen_Click(object sender, EventArgs e)
        {
            WaitForCashOrderOpen();
        }

        public void WaitForCashOrderOpen()
        {
            long cashDrawerResult = 1;

            _drawer.Open("CashDrawer");
            _drawer.ClaimDevice(200);
            _drawer.DeviceEnabled = true;

            MessageBox.Show("Duke pritur që sirtari të mbyllet...");
            cashDrawerResult = _drawer.WaitForDrawerClose(5000, 250, 500, 250);

            if (cashDrawerResult == 1)
            {
                string strOutput = "Statusi i sirtarit = %s" + _drawer.DrawerOpened.ToString();
                MessageBox.Show("Komanda për mbylljen e sirtarit u dërgua me sukses\n" + strOutput);
            }
            else
            {
                MessageBox.Show("Mbyllja e sirtarit dështoj!");
            }

            _drawer.DeviceEnabled = false;
            _drawer.ReleaseDevice();
            _drawer.Close();
        }

        private void closeCashDrawer_Click(object sender, EventArgs e)
        {
            _drawer.DeviceEnabled = false;
            _drawer.ReleaseDevice();
            _drawer.Close();
            Close();
        }

        public bool HasSecureConnection()
        {
            if (_secureId == 1)
                return true;
            return false;
        }
    }
}
