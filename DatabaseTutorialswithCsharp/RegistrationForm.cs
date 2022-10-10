using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseTutorialswithCsharp
{
    public partial class RegistrationForm : Form
    {

        
        String connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private int _stdId = 0;
        private bool _isUpdate = false;

        public int stdId
        {
            get; set;
        }

        public bool isUpdate
        {
            get; set;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (this.isUpdate)
            {
                updateRecord();
            }
            else
            {
                InsertRecord();
            }
        
        
        }
        public void updateRecord()
        {
            using (SqlConnection sqlcon = new SqlConnection(connstring))
            {
                sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand("updateStudent", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@stdId", this.stdId);
                    cmd.Parameters.AddWithValue("@stdName", name_textbox.Text.ToString());
                    cmd.Parameters.AddWithValue("@stdFname", fname_textbox.Text.ToString());
                    cmd.Parameters.AddWithValue("@isSkilledIncsharp", isSkilleInCsharp.Checked);
                    cmd.Parameters.AddWithValue("@isSkilledInjava", isSkilledInjava.Checked);
                    cmd.Parameters.AddWithValue("@isSkilledInpython", isSkilledInpython.Checked);
                    cmd.Parameters.AddWithValue("@genderid", GetRadioVlaue());
                    cmd.Parameters.AddWithValue("@dob", dobPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@admtime", admTimePicker.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@districtId", districtComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@photo", getPhoto());
                    int i = cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    if (i > 0) MessageBox.Show("Data Successfully updated...");
                }

            }

        }

        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBoxStudent.Image.Save(stream, pictureBoxStudent.Image.RawFormat);

            return stream.GetBuffer();
        }

        public void InsertRecord()
        {

            using (SqlConnection sqlcon = new SqlConnection(connstring))
            {
                sqlcon.Open();
                using (SqlCommand cmd = new SqlCommand("regStudent", sqlcon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@stdName", name_textbox.Text.ToString());
                    cmd.Parameters.AddWithValue("@stdFname", fname_textbox.Text.ToString());
                    cmd.Parameters.AddWithValue("@isSkilledIncsharp", isSkilleInCsharp.Checked);
                    cmd.Parameters.AddWithValue("@isSkilledInjava", isSkilledInjava.Checked);
                    cmd.Parameters.AddWithValue("@isSkilledInpython", isSkilledInpython.Checked);
                    cmd.Parameters.AddWithValue("@genderid", GetRadioVlaue());
                    cmd.Parameters.AddWithValue("@dob", dobPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@admtime", admTimePicker.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@districtId", districtComboBox.SelectedValue);
                    cmd.Parameters.AddWithValue("@photo", getPhoto());
                    int i = cmd.ExecuteNonQuery();
                    sqlcon.Close();
                    if (i > 0) MessageBox.Show("Data Successfully inserted..");
                }

            }
        }

        private int GetRadioVlaue()
        {
            if (male_btn.Checked) return 1;
            else return 2;
        }

        private void colse_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dobPicker_ValueChanged(object sender, EventArgs e)
        {
            dobPicker.CustomFormat = "dd/MM/yyyy";
        }

        private void dobPicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dobPicker.CustomFormat = " ";
            }
        }

        private void Time_ValueChanged(object sender, EventArgs e)
        {
            admTimePicker.CustomFormat = "HH:mm";
        }

        private void admTimePicker_MouseDown(object sender, MouseEventArgs e)
        {
            admTimePicker.CustomFormat = "HH:mm";

        }
        private DataTable populateCombo()
        {
            DataTable dt = new DataTable();
            using(SqlConnection con = new SqlConnection(connstring))
            {
                using(SqlCommand cmd = new SqlCommand("getDistricts",con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    con.Close();

                }

                
                districtComboBox.DisplayMember = "district_name";
                districtComboBox.ValueMember = "district_id";
                districtComboBox.DataSource = dt;


            }

            return dt;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            populateCombo();

            if (this.isUpdate)
            {
              DataTable stdRecord =   LoadDataforUpdate();
                DataRow row = stdRecord.Rows[0];
                name_textbox.Text = row["std_name"].ToString();
                fname_textbox.Text = row["std_fname"].ToString();
                isSkilleInCsharp.Checked = Convert.ToBoolean(row["is_skilled_incsharp"]);
                isSkilledInjava.Checked = Convert.ToBoolean(row["is_skilled_injava"]);
               isSkilledInpython.Checked = Convert.ToBoolean(row["is_skilled_inpython"]);
                male_btn.Checked = (Convert.ToInt16(row["gender_id"])==1)? true : false;
                fmale_btn.Checked = (Convert.ToInt16(row["gender_id"])==2)? true : false;
                dobPicker.Value = Convert.ToDateTime(row["dob"]).Date;
                admTimePicker.Value = Convert.ToDateTime(row["admtime"]);
                districtComboBox.SelectedValue = Convert.ToInt16(row["district_id"]);
                pictureBoxStudent.Image = GetImage((byte[])row["photo"]);
            }
        }

        private Image GetImage(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
            
        }

        private DataTable LoadDataforUpdate()
        {
            DataTable studentRecord = new DataTable();
            using(SqlConnection sqlConnection = new SqlConnection(connstring))
            {
                using(SqlCommand cmd = new SqlCommand("getStudentRecordById",sqlConnection))
                {
                    sqlConnection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@studentId", this.stdId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    studentRecord.Load(reader);

                }
            }
            return studentRecord;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudent.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
