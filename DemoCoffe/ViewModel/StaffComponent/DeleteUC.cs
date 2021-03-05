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
    public partial class DeleteUC : UserControl
    {
        public DeleteUC()
        {
            InitializeComponent();
        }
        private static DeleteUC _instance;
        public static DeleteUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DeleteUC();
                return _instance;
            }
        }
    }
}
