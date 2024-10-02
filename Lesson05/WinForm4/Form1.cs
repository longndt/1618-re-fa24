using System.DirectoryServices.ActiveDirectory;

namespace WinForm4
{
    public partial class FormNhaKhoa : Form
    {
        public FormNhaKhoa()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //thoát form (ứng dụng)
            ActiveForm.Close();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //tạo biến để lưu tổng tiền hóa đơn
            int total = 0;

            //lấy giá trị của textbox
            string name = txtKhachHang.Text;

            //tăng tổng tiền theo giá trị của checkbox
            if (cbMenRang.Checked)
                total += 200000;
            if (cbTayRang.Checked)
                total += 500000;

            //tăng tổng tiền theo giá trị của radio button
            if (rdTramRang.Checked)
                total += 1000000;
            else if (rdNhoRang.Checked)
                total += 100000;

            //hiển thị tổng tiền vào ô textbox tổng tiền
            txtTongTien.Text = total.ToString() + " VND";
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            //xóa ô nhập tên
            txtKhachHang.Text = "";

            //xóa ô tổng tiền
            txtTongTien.Text = "";

            //uncheck các checkbox
            cbMenRang.Checked = false;
            cbTayRang.Checked = false;

            //uncheck các radio button
            rdNhoRang.Checked = false;
            rdTramRang.Checked = false;

        }
    }
}
