using QuanLyNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class formQuanLy  : Form
    {
 
        public formQuanLy()
        {
            InitializeComponent();

            //xóa nội dung label khi hiển thị form
            xoaOutput();
        }

        //Procedural programming
        public void xoaOutput()
        {
            lblHoTen.Text = "";
            lblTuoi.Text = "";
            lblDiaChi.Text = "";
            lblPhong.Text = "";
            lblChucVu.Text = "";
        }

        public void xoaInput()
        {
            txtHoTen.Text = "";
            nudTuoi.Text = "";
            txtDiaChi.Text = "";

            //nếu chọn DropDownStyle của ComboBox là DropDownList
            //thì nếu xóa value trong form cần chọn index không tồn tại (-1)
            cbbChucVu.SelectedIndex = -1;
            cbbPhong.SelectedIndex = -1;
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            //xóa toàn bộ thông tin trong form input
            xoaInput();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //B1: lấy thông tin từ form
            string hoTen = txtHoTen.Text;
            int tuoi = int.Parse(nudTuoi.Text); //convert chữ thành số
            string diaChi = txtDiaChi.Text;
            string phong = cbbPhong.Text;
            string chucVu = cbbChucVu.Text;

            //B2: tạo object nhân viên theo thông tin từ form
            //Objected Oriented Programming
            NhanVien nhanVien = new NhanVien(hoTen, tuoi, diaChi, phong, chucVu);

            //B3: add object nhân viên vào list box
            lbNhanVien.Items.Add(nhanVien);
        }

        private void lbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //B1: lấy index của nhân viên được chọn
            int index = lbNhanVien.SelectedIndex;

            //B2: kiểm tra xem index có tồn tại không (-1 là không tồn tại)
            if (index != -1)
            {
                //B2.1: gọi object nhân viên tương ứng với index của listbox
                NhanVien nhanVien = (NhanVien)lbNhanVien.Items[index];

                //B2.2: hiển thị thông tin nhân viên ra output
                lblHoTen.Text = nhanVien.HoTen;
                lblTuoi.Text = nhanVien.Tuoi.ToString();
                lblDiaChi.Text = nhanVien.DiaChi;
                lblPhong.Text = nhanVien.Phong;
                lblChucVu.Text = nhanVien.ChucVu;
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            //B1: kiểm tra xem người dùng đã chọn nhân viên chưa
            if (lbNhanVien.SelectedIndex != -1)
            {
                //B2: lấy index của nhân viên được chọn
                int index = lbNhanVien.SelectedIndex;

                //B3.1: xóa object nhân viên ra khỏi listBox
                lbNhanVien.Items.RemoveAt(index);

                //B3.2: xóa thông tin nhân viên ở output
                xoaOutput();
            } else
            {
                //hiển thị lỗi nếu người dùng chưa chọn object cần xóa
                MessageBox.Show("Bạn phải chọn nhân viên cần xóa trước");
            }
        }
    }
}
