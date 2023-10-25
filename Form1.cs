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
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public SqlConnection connect;
        string a = "Data Source = A209PC41;Initial Catalog = siem;Integrated Security = true";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                connect = new SqlConnection(a);
                connect.Open();
                string InsertString = "insert into siem values('08','Siba');";
                SqlCommand cmd = new SqlCommand(InsertString,connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thanh cong");
            }
            catch(Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new SqlConnection(a);
                connect.Open();
                string UpdateString = "update siem set ID = '09' where ID = '7'";
                SqlCommand cmd = new SqlCommand(UpdateString, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new SqlConnection(a);
                connect.Open();
                string DeleteString = "delete siem where ID = '09';";
                SqlCommand cmd = new SqlCommand(DeleteString, connect);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai");
            }
        }
        
    }
}
