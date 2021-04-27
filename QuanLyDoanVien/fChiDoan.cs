using QuanLyDoanVien.BLL;
using QuanLyDoanVien.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanVien
{
    public partial class fChiDoan : Form
    {
        //tao con tro stdBLL
        private ChiDoan_BLL stdBLL = new ChiDoan_BLL();
        public fChiDoan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fChiDoan_Load(object sender, EventArgs e)
        {
            dtgChiDoan.DataSource = stdBLL.GetALL();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            string MaChiDoan = Convert.ToString(txtMCD.Text);
            if (stdBLL.CheckChiDoan(MaChiDoan))
            {
                //edit or update
                string TenChiDoan = txtTCD.Text;
                stdBLL.Edit(TenChiDoan, MaChiDoan);
            }
            else
            {
                //insert
                var cd = new ChiDoan();
                cd.TenChiDoan = txtTCD.Text;
                stdBLL.Create(cd);
            }
            dtgChiDoan.DataSource = stdBLL.GetALL();
        }

        private void btnXoaCD_Click(object sender, EventArgs e)
        {
            try
            {
                string stdID = Convert.ToString(txtMCD.Text);
                if (stdBLL.CheckChiDoan(stdID))
                {
                    stdBLL.Delete(stdID);
                }
                else
                {
                    MessageBox.Show("Không tồn tại đơn vị mà bạn muốn xóa");
                }
                dtgChiDoan.DataSource = stdBLL.GetALL();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập vào mã đơn vị");
            }
        }

        private void btnSuaCD_Click(object sender, EventArgs e)
        {
            string stdID = Convert.ToString(txtMCD.Text);
            if (stdBLL.CheckChiDoan(stdID))
            {
                string strName = txtTCD.Text;
                stdBLL.Edit(stdID, strName);
            }
            dtgChiDoan.DataSource = stdBLL.GetALL();
        }

        private void btnThoatCD_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("Bạn chắc chắn muốn thoát hệ thống ?", "Thông báo", MessageBoxButtons.YesNo);
            if (mess == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
    
}
