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
    public partial class PassEditUC : UserControl
    {
        public PassEditUC()
        {
            InitializeComponent();
        }
        private static PassEditUC _instance;
        public static PassEditUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PassEditUC();
                return _instance;
            }
        }
    }
}
