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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (isValidated())
            {
                try {

                    bool isUserName, isPassword,isActive;
                    GetUserCredentials(out isUserName, out isPassword,out isActive);

                    if(isUserName && isPassword)
                    {
                        if (isActive)
                        {
                            this.Hide();
                            if (rememberCheckbox.Checked)
                            {
                                Properties.Settings.Default.userName = userNameTextBox.Text;
                                Properties.Settings.Default.Save();
                            }
                            mainform maForm = new mainform();
                            maForm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("User Disabled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        }
                    }
                    else
                    {
                        if (!isUserName)
                        {
                            MessageBox.Show("UserName is not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            userNameTextBox.Clear();
                            passwordTextBox.Clear();
                            userNameTextBox.Focus();
                        }
                        if (!isPassword)
                        {
                            MessageBox.Show("Password is not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           
                            passwordTextBox.Clear();
                            passwordTextBox.Focus();
                        }
                    }


                }catch(ApplicationException ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void GetUserCredentials(out bool isUserName, out bool isPassword,out bool isActive)
        {
            string constring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString; 
           using(SqlConnection con = new SqlConnection(constring))
            {
                using(SqlCommand cmd = new SqlCommand("getUserCredentials",con))
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@isusername", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@ispassword", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@isactive", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("@UserName", userNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);

                    cmd.ExecuteScalar();
                    isUserName = (bool)cmd.Parameters["@isusername"].Value;
                    isPassword = (bool)cmd.Parameters["@ispassword"].Value;
                    isActive = (bool)cmd.Parameters["@isactive"].Value;



                }
            }
        
        
        }

        private bool isValidated()
        {
            if(userNameTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter UserName", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                userNameTextBox.Clear();
                passwordTextBox.Clear();
                userNameTextBox.Focus();
                return false;
                    }
            if (passwordTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                passwordTextBox.Clear();
                passwordTextBox.Focus();
                return false;
            }
            return true;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            userNameTextBox.Text = Properties.Settings.Default.userName;
        }
    }
}
