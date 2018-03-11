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
        public static string a = null;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-8J6L2ID\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
            con = new SqlConnection(conString);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            
                
            string TK = txtTK.Text;
            string MK = txtTK.Text;
            string sqlKiemTra = "select *from TaiKhoan Where TenTK ='" + TK + "' and MatKhau ='" + MK + "'";
            SqlCommand cmd = new SqlCommand(sqlKiemTra,con);
            while (true)
            {
                con.Open();
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    FormChinh ChuyenForm = new FormChinh();
                    a = txtTK.Text.ToString();
                    ChuyenForm.ShowDialog();
                    con.Close();
                    break;
                }
                else
                {
                    labelThongBao.Text = "Bạn đã nhập sai thông tin, vui lòng nhập lại";
                    labelThongBao.Visible = true;
                    con.Close();
                    break;
                }
                
            }
            





        }
    }
}
