using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }


        SqlConnection con;
        public static string TK = null;
        public static string MK = null;
        public static int id;


        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-8J6L2ID\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
            con = new SqlConnection(conString);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TK = txtTK.Text;
            MK = txtTK.Text;
            try
            {
                string sql = "Select Count(*) From [QuanLyNhanVien].[dbo].[TaiKhoan] Where TenTK=@acc And MatKhau=@pass ";

                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@acc", TK));
                cmd.Parameters.Add(new SqlParameter("@pass", MK));
                int x = (int)cmd.ExecuteScalar();
                while (true)
                {
                    if (x == 1)
                    {//đăng nhập thành công

                        FormChinh a = new FormChinh();
                        a.ShowDialog();
                        con.Close();
                        break;

                    }
                    else
                    {
                        //đăng nhập thất bại
                        labelThongBao.Text = "Thông tin nhập sai vui lòng nhập lại";
                        txtTK.Text = "";
                        txtMK.Text = "";
                        txtTK.Focus();
                        con.Close();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
