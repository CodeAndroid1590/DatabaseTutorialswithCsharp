using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseTutorialswithCsharp
{
    public partial class mainform : Form
    {
        private DataTable stdDataTable = new DataTable();
        public mainform()
        {
            InitializeComponent();
        }

       

        private void mainform_Load(object sender, EventArgs e)
        {
            LoadDatainGridview();
            
        }

        public void LoadDatainGridview()
        {
            stdDataTable.Clear();
            String connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

            using (SqlConnection sqlcon = new SqlConnection(connstring))
            {
                sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand("getStudentData", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    stdDataTable.Load(reader);


                }
            }
            
            dvgStudents.DataSource = stdDataTable;
        }

        private void nameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchByColumnName("Name", nameSearchTextBox);
        }

        private void districtSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchByColumnName("District", districtSearchTextBox);
        }
        private void SearchByColumnName(string columnName, TextBox txt)
        {
            DataView dvStudents = stdDataTable.DefaultView;
            dvStudents.RowFilter = columnName + " Like '%" + txt.Text + "%'";

        }

        private void dvgStudents_DoubleClick(object sender, EventArgs e)
        {
            int selectedRow = dvgStudents.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int stdId = Convert.ToInt16(dvgStudents.Rows[selectedRow].Cells["StudentID"].Value);

            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.stdId = stdId;
            registrationForm.isUpdate = true;
            registrationForm.ShowDialog();
            LoadDatainGridview();
        }

        private void registerNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
