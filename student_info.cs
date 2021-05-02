using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_management_system
{
    public partial class student_info : Form
    {
        public student_info()
        {
            InitializeComponent();
        }

        private void student_info_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentinfoDataSet.Table_1' table. You can move, or remove it, as needed.
            this.table_1TableAdapter.Fill(this.studentinfoDataSet.Table_1);

        }
    }
}
