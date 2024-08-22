using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CScompany
{
    public partial class itemType : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public itemType()
        {
            InitializeComponent();
            conectDB();
        }
        public void conectDB()
        {
            conn.ConnectionString = "Data Source=DESKTOP-TPVJFB5;Initial Catalog=\"CS company\";Integrated Security=True;";
            conn.Open();
            cmd.Connection = conn;
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            typeCode.Clear();
            typeName.Clear();
            typeCode.Focus();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "insert into itemType values('" +typeCode.Text +"', '" +typeName.Text +"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
            }
            catch (Exception ex) {
                MessageBox.Show("ค่าซ้ำ");
            }
        }

        private void typeCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                cmd.CommandText = "select * from itemType where typeCode ='"+typeCode.Text+"'";
                SqlDataReader rs = cmd.ExecuteReader();
                if (rs.HasRows) {
                    rs.Read();
                    typeName.Text = rs.GetString(1);
                }
                rs.Close();
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.CommandText = "Update itemType set typeCode'" +typeCode.Text +"', '" +typeName.Text +"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("บันทึกข้อมูลเรียบร้อย");
            }
            catch (Exception ex) {
                MessageBox.Show("ค่าซ้ำ");
            }
        }
    }
}
