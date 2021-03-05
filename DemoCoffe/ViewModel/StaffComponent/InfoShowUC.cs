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
    public partial class InfoShowUC : UserControl
    {
        public InfoShowUC()
        {
            InitializeComponent();
        }
        private static InfoShowUC _instance;
        public static InfoShowUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InfoShowUC();
                return _instance;
            }
        }
    }
}
