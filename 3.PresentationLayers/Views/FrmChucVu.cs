using _1.DAL.DomainClass;
using _1.DAL.IRepositoties;
using _2.BUS.IService;
using _2.BUS.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PresentationLayers.Views
{
    public partial class FrmChucVu : Form
    {
        public IChucVuService _chucVuService;
        public ChucVu _cv;

        public FrmChucVu()
        {
            InitializeComponent();
            _chucVuService = new ChucVuServivce();
            loadData();
        }
        public void loadData()
        {
            dtg_Show.ColumnCount = 4;
            dtg_Show.Columns[0].Name = "Id";
            dtg_Show.Columns[0].Visible = false;
            dtg_Show.Columns[1].Name = "Mã";
            dtg_Show.Columns[2].Name = "Tên";
            dtg_Show.Columns[3].Name = "Trạng Thái";
            dtg_Show.Rows.Clear();
            var lstChucVu = _chucVuService.getChucVusFromDB();
            foreach (var item in lstChucVu)
            {
<<<<<<< HEAD
                dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai);
=======
                dtg_Show.Rows.Add(item.Id, item.Ma, item.Ten, item.TrangThai == 1 ? "Hoạt Động" : "Không Hoạt Động" );
>>>>>>> cd5db5daf6de7279c06a2106e3c8bfbf74a7f485
            }
        }
        public void resetForm()
        {
            loadData();
            _cv = null;
            tb_ma.Text = "";
            tb_ten.Text = "";
            cb_hd.Checked = true;
            cb_khd.Checked = false;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtg_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dtg_Show.Rows[e.RowIndex];
                _cv = _chucVuService.getChucVusFromDB().FirstOrDefault(x => x.Id == Guid.Parse(r.Cells[0].Value.ToString()));
                tb_ma.Text = r.Cells[1].Value.ToString();
                tb_ten.Text = r.Cells[2].Value.ToString();
                cb_hd.Checked = _cv.TrangThai == 1;
                cb_khd.Checked = _cv.TrangThai == 0;

            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (_cv == null)
            {
                MessageBox.Show("Vui Lòng chọn mã chức vụ");
            }
            else
            {
                _chucVuService.deleteChucVu(_cv);
                MessageBox.Show("Xóa Thành Công");
                resetForm();
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Nhập Mã Chức Vụ");

            }
            else if (_cv == null)
            {
                MessageBox.Show("Chọn Chức Vụ");
            }
            else
            {
                if (_cv.Ma == tb_ma.Text || (_cv.Ma != tb_ma.Text && _chucVuService.getChucVusFromDB().FirstOrDefault(x => x.Ma == tb_ma.Text) == null))
                {
                    _cv.Ma = tb_ma.Text;
                    _cv.Ten = tb_ten.Text;
                    _cv.TrangThai = cb_hd.Checked ? 1 : 0;
                    _chucVuService.updateChucVu(_cv);
                    MessageBox.Show("Sửa chức vụ thành công");
                    resetForm();

                }
                else
                {
                    MessageBox.Show("Chức vụ đã tồn tại");
                }
            }

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (tb_ma.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã chức vụ");
            }
            else if (_chucVuService.getChucVusFromDB().Any(x => x.Ma == tb_ma.Text))
            {
                MessageBox.Show("Mã chức vụ đã tồn tại");
            }
            else
            {
                var cv = new ChucVu()
                {
<<<<<<< HEAD
                    Id = new Guid(),
                    Ma = tb_ma.Text,
                    Ten = tb_ten.Text
=======
                Id = new Guid(),
                Ma = tb_ma.Text,
                Ten = tb_ten.Text,
                TrangThai = cb_hd.Checked ? 1 : 0
>>>>>>> cd5db5daf6de7279c06a2106e3c8bfbf74a7f485
                };
                _chucVuService.addChucVu(cv);
                MessageBox.Show("Thêm mới thành công");
                resetForm();
            }
        }

        private void cb_hd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_hd_Click(object sender, EventArgs e)
        {
            if (cb_khd.Checked)
            {
                cb_khd.Checked = false;
            }
            cb_hd.Checked = true;
        }

        private void cb_khd_Click(object sender, EventArgs e)
        {
            if (cb_hd.Checked)
            {
                cb_hd.Checked=false;
            }
            cb_khd.Checked = true;
        }
    }
}
