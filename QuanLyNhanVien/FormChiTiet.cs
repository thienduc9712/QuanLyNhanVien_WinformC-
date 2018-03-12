using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyNhanVien
{
    public partial class FormChiTiet : Form
    {
        public FormChiTiet()
        {
            InitializeComponent();
        }

        SqlConnection con;
        void Mo()
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        void Khoa()
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        void HienThiNV()
        {
             
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandText = "HienThiNV";
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dsNV = new DataSet();
                adapter.Fill(dsNV);
                dgvNhanVien.DataSource = dsNV.Tables[0];
        }
        void HienThiLuong()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = "HienThiNV";
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dsBL = new DataSet();
            adapter.Fill(dsBL);
            dgvBangLuong.DataSource = dsBL.Tables[0];

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
           
            
            string conString = @"Data Source=DESKTOP-8J6L2ID\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
            con = new SqlConnection(conString);
            con.Open();
            Mo();
            HienThiNV();
            HienThiLuong();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          //  Khoa();
            try
            {
                
                if (con.State == ConnectionState.Open)
                {
                                      

                    SqlCommand com = new SqlCommand("ThemNV",con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@_idNV", txtID.Text);
                    com.Parameters.AddWithValue("@_TenNV", txtTenNV.Text);
                    com.Parameters.AddWithValue("@_GioiTinh", txtGioiTinh.Text);
                    com.Parameters.AddWithValue("@_NgaySinh",  txtNgaySinh.Text);
                    com.Parameters.AddWithValue("@_NoiSinh", txtNoiSinh.Text);
                    com.Parameters.AddWithValue("@_NguyenQuan", txtNguyenQuan.Text);
                    com.Parameters.AddWithValue("@_HoKhauThuongChu", txtHoKhauThuongTru.Text);
                    com.Parameters.AddWithValue("@_ChoOHienNay", txtChoOHienNay.Text);
                    com.Parameters.AddWithValue("@_SDT", txtSDT.Text);
                    com.Parameters.AddWithValue("@_DanToc", txtDanToc.Text);
                    com.Parameters.AddWithValue("@_CMND", txtCMND.Text);
                    com.Parameters.AddWithValue("@_NoiCap", txtNoiCap.Text);
                    com.Parameters.AddWithValue("@_NgayCap", txtNgayCap.Text);
                    com.Parameters.AddWithValue("@_HovaTen", txtHovaTen.Text);
                    com.Parameters.AddWithValue("@_TinhTrangHonNhan", txtHonNhan.Text);
                    com.Parameters.AddWithValue("@_TrinhDoHocVan", txtTrinhDoHocVan.Text);
                    com.Parameters.AddWithValue("@_idPB", int.Parse(txtPhongBan.Text));
                    com.Parameters.AddWithValue("@_idCV", int.Parse(txtChucVu.Text));
                   
                    int item = com.ExecuteNonQuery();
                    if (item > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        HienThiNV();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi k them duoc");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khong ket noi");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Khoa();
            try
            {

                if (con.State == ConnectionState.Open)
                {


                    SqlCommand com = new SqlCommand("SuaNV", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@_idNV", txtID.Text);
                    com.Parameters.AddWithValue("@_TenNV", txtTenNV.Text);
                    com.Parameters.AddWithValue("@_GioiTinh", txtGioiTinh.Text);
                    com.Parameters.AddWithValue("@_NgaySinh", txtNgaySinh.Text);
                    com.Parameters.AddWithValue("@_NoiSinh", txtNoiSinh.Text);
                    com.Parameters.AddWithValue("@_NguyenQuan", txtNguyenQuan.Text);
                    com.Parameters.AddWithValue("@_HoKhauThuongChu", txtHoKhauThuongTru.Text);
                    com.Parameters.AddWithValue("@_ChoOHienNay", txtChoOHienNay.Text);
                    com.Parameters.AddWithValue("@_SDT", txtSDT.Text);
                    com.Parameters.AddWithValue("@_DanToc", txtDanToc.Text);
                    com.Parameters.AddWithValue("@_CMND", txtCMND.Text);
                    com.Parameters.AddWithValue("@_NoiCap", txtNoiCap.Text);
                    com.Parameters.AddWithValue("@_NgayCap", txtNgayCap.Text);
                    com.Parameters.AddWithValue("@_HovaTen", txtHovaTen.Text);
                    com.Parameters.AddWithValue("@_TinhTrangHonNhan", txtHonNhan.Text);
                    com.Parameters.AddWithValue("@_TrinhDoHocVan", txtTrinhDoHocVan.Text);
                    com.Parameters.AddWithValue("@_idPB", int.Parse(txtPhongBan.Text));
                    com.Parameters.AddWithValue("@_idCV", int.Parse(txtChucVu.Text));

                    int item = com.ExecuteNonQuery();
                    if (item > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                        HienThiNV();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi k sua duoc");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khong ket noi");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvNhanVien_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHovaTen.Text = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtGioiTinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtNgaySinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtNoiSinh.Text = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNguyenQuan.Text = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtHoKhauThuongTru.Text = dgvNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtChoOHienNay.Text = dgvNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtDanToc.Text = dgvNhanVien.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtCMND.Text = dgvNhanVien.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtNoiCap.Text = dgvNhanVien.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtNgayCap.Text = dgvNhanVien.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtHonNhan.Text = dgvNhanVien.Rows[e.RowIndex].Cells[14].Value.ToString();
            txtTrinhDoHocVan.Text = dgvNhanVien.Rows[e.RowIndex].Cells[15].Value.ToString();
            txtPhongBan.Text = dgvNhanVien.Rows[e.RowIndex].Cells[16].Value.ToString();
            txtChucVu.Text = dgvNhanVien.Rows[e.RowIndex].Cells[17].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                if (con.State == ConnectionState.Open)
                {


                    SqlCommand com = new SqlCommand("XoaNV", con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@_idNV", txtID.Text);
                    

                    int item = com.ExecuteNonQuery();
                    if (item > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        HienThiNV();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi không xóa được");
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi khong ket noi");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtThang.Text))
            {
                try
                {

                    SqlCommand command = new SqlCommand("TimBLThang", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@_Thang", "%" + txtThang.Text + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dsBL = new DataSet();
                    adapter.Fill(dsBL);
                    dgvBangLuong.DataSource = dsBL.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tháng");
            }

            
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand command = new SqlCommand("ThongKe", con);
                command.CommandType = CommandType.StoredProcedure;
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dsBL = new DataSet();
                adapter.Fill(dsBL);
                dgvBangLuong.DataSource = dsBL.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
