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

namespace student_management_system
{
    public partial class student_registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FUFG7JP\SQLEXPRESS;Initial Catalog=studentinfo;Integrated Security=True");
        public student_registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Table_1 VALUES('" + textBox1.Text + "', '" + txtName.Text + "', '" + txtAddress.Text + "', '" + txtClass.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("insert data successfully");
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Table_1 SET Student_Name='" + txtName.Text + "', Address='" + txtAddress.Text + "', Class='" + txtClass.Text + "' WHERE Student_Id='" + textBox1.Text+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Data Successfully");
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Table_1 WHERE Student_Id='"+textBox1.Text+"'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted successfully");
            con.Close();

        }
    }
}
