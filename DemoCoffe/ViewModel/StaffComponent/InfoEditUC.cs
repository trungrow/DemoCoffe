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
    public partial class InfoEditUC : UserControl
    {
        public InfoEditUC()
        {
            InitializeComponent();
        }
        private static InfoEditUC _instance;
        public static InfoEditUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new InfoEditUC();
                return _instance;
            }
        }
    }
}
