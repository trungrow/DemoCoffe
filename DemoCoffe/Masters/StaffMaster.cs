using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCoffe.Masters
{
    public partial class StaffMaster : Form
    {
        public readonly Entities.DbCoffe db = new Entities.DbCoffe();
        public StaffMaster()
        {
            InitializeComponent();
            //dgvStaff.EnableHeadersVisualStyles = false;
            dgvStaff.AutoGenerateColumns = false;
        }
        #region layout

        private void StaffMaster_Load(object sender, EventArgs e)
        {
            LoadAddUC();
            LoadDataToGrid();
        }

        private void StaffMaster_Shown(object sender, EventArgs e)
        {
        }
        private void dgvStaff_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid != null)
            {
                foreach (DataGridViewRow item in grid.Rows)
                {
                    item.HeaderCell.Value = item.Index + 1;
                }
            }
        }
        private void bgLoadData_DoWork(object sender, DoWorkEventArgs e)
        {
            bgLoadData.WorkerReportsProgress = true;
            for (int i = 0; i <= statusProcess.Maximum; i++)
            {
                bgLoadData.ReportProgress(i);
            }
        }

        private void bgLoadData_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            statusProcess.Value = e.ProgressPercentage;
        }

        private void bgLoadData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusLabel.Text = "success";
        }

        #endregion

        #region Logic



        private void dgvStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = sender as DataGridView;
            if (dgv != null && e.RowIndex >= 0)
            {
                var id = dgv.Rows[e.RowIndex].Cells[0].Value;
                var sf = db.Staffs.Find(id);
                //if (sf != null)
                //    Show(sf);
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStaff.DataSource = db.Staffs.ToList();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvStaff.DataSource = db.Staffs.ToList();
        }

        #endregion

        #region Helper


        void LoadDataToGrid()
        {

            //var sfs = db.Staffs.Select(x => new { x.StaffCode, x.StaffFullName, Gender=(x.StaffGender.Value?"Nam":"Nu"),
            //                x.StaffBrithDay.Value.ToString("dd/MM/yyyy"), x.StaffPhone, x.StaffMail, x.StaffAddress});
            var sfs = (from a in db.Staffs
                       select new
                       {
                           Id = a.StaffId,
                           Code = a.StaffCode,
                           FullName = a.StaffFullName,
                           Gender = (a.StaffGender.Value == true ? "Nam" : "Nữ"),
                           BrithDay = a.StaffBrithDay.Value,
                           Phone = a.StaffPhone,
                           Mail = a.StaffMail,
                           Image = a.StaffAvatar,
                           Address = a.StaffAddress
                       }).OrderByDescending(x=>x.Id).ToList();

            statusProcess.Maximum = sfs.Count;
            bgLoadData.RunWorkerAsync();
            dgvStaff.DataSource = sfs;
            //dgvStaff.Update();
        }


        #endregion

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAddUC();
        }

        #region Load Componet

        void LoadAddUC()
        {
            leftLayout.Controls.Clear();
            leftLayout.Controls.Add(ViewModel.StaffComponent.AddUC.Instance);
            ViewModel.StaffComponent.AddUC.Instance.Dock = DockStyle.Fill;
            ViewModel.StaffComponent.AddUC.Instance.BringToFront();
        }
        void LoadInfoEditUC()
        {
            leftLayout.Controls.Clear();
            leftLayout.Controls.Add(ViewModel.StaffComponent.InfoEditUC.Instance);
            ViewModel.StaffComponent.InfoEditUC.Instance.Dock = DockStyle.Fill;
            ViewModel.StaffComponent.InfoEditUC.Instance.BringToFront();
        }
        void LoadPassEditUC()
        {
            leftLayout.Controls.Clear();
            leftLayout.Controls.Add(ViewModel.StaffComponent.PassEditUC.Instance);
            ViewModel.StaffComponent.PassEditUC.Instance.Dock = DockStyle.Fill;
            ViewModel.StaffComponent.PassEditUC.Instance.BringToFront();
        }
        void LoadInfoShowUC()
        {
            leftLayout.Controls.Clear();
            leftLayout.Controls.Add(ViewModel.StaffComponent.InfoShowUC.Instance);
            ViewModel.StaffComponent.InfoShowUC.Instance.Dock = DockStyle.Fill;
            ViewModel.StaffComponent.InfoShowUC.Instance.BringToFront();
        }
        void LoadDeleteUC()
        {
            leftLayout.Controls.Clear();
            leftLayout.Controls.Add(ViewModel.StaffComponent.DeleteUC.Instance);
            ViewModel.StaffComponent.DeleteUC.Instance.Dock = DockStyle.Fill;
            ViewModel.StaffComponent.DeleteUC.Instance.BringToFront();
        }
        #endregion

        private void cmsView_Click(object sender, EventArgs e)
        {
            LoadInfoShowUC();
        }

        private void cmsInfoEdit_Click(object sender, EventArgs e)
        {
            LoadInfoEditUC();
        }

        private void cmsPassEdit_Click(object sender, EventArgs e)
        {
            LoadPassEditUC();
        }

        private void cmsDelete_Click(object sender, EventArgs e)
        {
            LoadDeleteUC();
        }
    }
}
