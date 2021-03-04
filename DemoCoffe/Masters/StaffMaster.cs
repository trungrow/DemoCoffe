using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        #endregion

        #region Data

        Entities.Staff Set()
        {
            Entities.Staff sf = new Entities.Staff();
            sf.StaffCode = txtCode.Text;
            sf.StaffPassword = txtPassword.Text;

            var img = new Bitmap(picAvatar.Image);
            sf.StaffAvatar = ImageToByte(img);

            sf.StaffFullName = txtFullName.Text;
            sf.StaffGender = rdMale.Checked ? true : false;
            sf.StaffBrithDay = dtpBrithDay.Value;
            sf.StaffPhone = txtPhone.Text;
            sf.StaffMail = txtEmail.Text;
            sf.StaffAddress = txtAddress.Text;

            return sf;

        }

        void Show(Entities.Staff sf)
        {
            txtId.Text = sf.StaffId + "";
            txtCode.Text = sf.StaffCode;

            txtFullName.Text = sf.StaffFullName;
            if (sf.StaffGender.Value)
                rdMale.Checked = true;
            else
                rdFemale.Checked = true;

            dtpBrithDay.Value = sf.StaffBrithDay.Value;
            txtPhone.Text = sf.StaffPhone;
            txtEmail.Text = sf.StaffMail;
            txtAddress.Text = sf.StaffAddress;
        }



        #endregion

        #region Logic

        private void btnUpLoad_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
            var block = true;
            while (block)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var size = new System.IO.FileInfo(dialog.FileName).Length;
                    if (size > 8000)
                    {
                        var info = MessageBox.Show("Hình Ảnh bạn chọn có kích cỡ quá 8KB hãy chọn hình ảnh có kích cỡ nhỏ hơn. \r Bạn Muốn chọn lại Hình Ảnh?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (info == DialogResult.Cancel)
                        {
                            dialog.FileName = "";
                            block = false;
                        }
                    }
                    else
                        block = false;
                }
                else
                    block = false;
            }

            if (!string.IsNullOrEmpty(dialog.FileName))
            {
                picAvatar.ImageLocation = dialog.FileName;
            }
        }

        private void btnDelLoad_Click(object sender, EventArgs e)
        {
            var box = new Bitmap(Properties.Resources.user);
            picAvatar.Image = box;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var sf = Set();
                db.Staffs.Add(sf);
                var check = db.SaveChanges();
                if (check > 0)
                {
                    MessageBox.Show("Thêm Thành Công! \r Bạn có muốn thêm tiếp Nhân Viên?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    LoadDataToGrid();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dgvStaff.DataSource = db.Staffs.ToList();
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
                       }).ToList();

            dgvStaff.DataSource = sfs;
            //dgvStaff.Update();
        }

        byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        Bitmap ByteToImage(byte[] blod)
        {
            if (blod == null)
                return new Bitmap(Properties.Resources.user);

            MemoryStream memoryStream = new MemoryStream();
            byte[] pdata = blod;
            memoryStream.Write(pdata, 0, Convert.ToInt32(pdata.Length));
            var bm = new Bitmap(memoryStream, false);
            memoryStream.Dispose();

            return bm;
        }


        #endregion
    }
}
