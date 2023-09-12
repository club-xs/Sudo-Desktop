using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsAppFW
{
    public partial class Form3 : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.Style = 0x20000;
                return createParams;
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nTopRect,
            int nBottomRect,
            int nRightRect,
            int nLeftRect,
            int nWidthEllipse,
            int nLenghtEllipse
        );

        public Form3()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, Height, Width, 0, 25, 25));
            navPnl.Height = dashboardBtn.Height;
            navPnl.Top = dashboardBtn.Top;
            navPnl.Left = dashboardBtn.Left;
            dashboardBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            navPnl.Height = dashboardBtn.Height;
            navPnl.Top = dashboardBtn.Top;
            navPnl.Left = dashboardBtn.Left;
            dashboardBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void analyticsBtn_Click(object sender, EventArgs e)
        {
            navPnl.Height = analyticsBtn.Height;
            navPnl.Top = analyticsBtn.Top;
            navPnl.Left = analyticsBtn.Left;
            analyticsBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void calendarBtn_Click(object sender, EventArgs e)
        {
            navPnl.Height = calendarBtn.Height;
            navPnl.Top = calendarBtn.Top;
            navPnl.Left = calendarBtn.Left;
            calendarBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            navPnl.Height = contactBtn.Height;
            navPnl.Top = contactBtn.Top;
            navPnl.Left = contactBtn.Left;
            contactBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            navPnl.Height = settingsBtn.Height;
            navPnl.Top = settingsBtn.Top;
            navPnl.Left = settingsBtn.Left;
            settingsBtn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void dashboardBtn_Leave(object sender, EventArgs e)
        {
            dashboardBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void analyticsBtn_Leave(object sender, EventArgs e)
        {
            analyticsBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void calendarBtn_Leave(object sender, EventArgs e)
        {
            calendarBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void contactBtn_Leave(object sender, EventArgs e)
        {
            contactBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void settingsBtn_Leave(object sender, EventArgs e)
        {
            settingsBtn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
