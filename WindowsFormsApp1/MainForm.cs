using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm(int job)
        {
            InitializeComponent();

            switch (job)
            {
                case 1:
                    FrontOffice.BringToFront();
                    break;
                case 2:
                    HouseKeeper.BringToFront();
                    break;
                case 3:
                    HouseKeeperSupervisor.BringToFront();
                    break;
                case 4:
                    Admin.BringToFront();
                    break;
            }
        }
    }
}
