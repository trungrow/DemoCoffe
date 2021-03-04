using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCoffe
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            Form ms = null;
            switch (btn.Name)
            {
                case "btnCoffeTables":
                    ms = new Masters.TableMaster();
                    ms.Show();
                    break;
                case "btnUsers":
                    ms = new Masters.StaffMaster();
                    ms.Show();
                    break;
                case "btnLogout":
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
