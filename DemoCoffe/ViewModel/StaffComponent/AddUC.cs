using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCoffe.ViewModel.StaffComponent
{
    public partial class AddUC : UserControl
    {
        public AddUC()
        {
            InitializeComponent();
        }
        private static AddUC _instance;
        public static AddUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddUC();
                return _instance;
            }
        }

        private void btnUpLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnDelLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
