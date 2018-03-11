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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }
        SqlConnection con;
        int choice;
        public void HienThi()
        {
            if (choice ==1)
            {
                
                string sqlHienThi = "ShowNhanVien";
                SqlCommand cmd = new SqlCommand(sqlHienThi, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvHienThi.DataSource = dt;
                dgvHienThi.Columns[0].Visible = false;
            }
            if (choice ==2)
            {

                string sqlHienThi = "ShowPB";
                SqlCommand cmd = new SqlCommand(sqlHienThi, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvHienThi.DataSource = dt;
                dgvHienThi.Columns[0].Visible = false;
            }
            if (choice == 3)
            {
                string sqlHienThi = "ShowBCC";
                SqlCommand cmd = new SqlCommand(sqlHienThi, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvHienThi.DataSource = dt;
                dgvHienThi.Columns[0].Visible = false;
            }
            if (choice == 4)
            {
                string sqlHienThi = "ShowBL";
                SqlCommand cmd = new SqlCommand(sqlHienThi, con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvHienThi.DataSource = dt;
                dgvHienThi.Columns[0].Visible = false;
            }
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            choice = 1;
            HienThi();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conString = @"Data Source=DESKTOP-8J6L2ID\SQLEXPRESS;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
            con = new SqlConnection(conString);
            con.Open();
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choice = 2;
            HienThi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choice = 3;
            HienThi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            choice = 4;
            HienThi();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

            FormChiTiet ChuyenForm = new FormChiTiet();
            ChuyenForm.ShowDialog();
        }
    }   
    
}
