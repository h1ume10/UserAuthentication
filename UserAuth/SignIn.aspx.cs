using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using static UserAuth.Conn;
using System.Data.SqlClient;
using System.Configuration;

namespace UserAuth
{
    public partial class WebForm2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserEmail"] != null)
                {
                    txtSignInEmail.Text = (string)Session["UserEmail"];
                }
            }
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            String email = txtSignInEmail.Text;
            String password = txtSignInPassword.Text;

            if (string.IsNullOrEmpty(email))
            {
                ShowSweetAlert("Please enter your email address");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                ShowSweetAlert("Please enter your password");
                return;
            }

            Conn connection = new Conn();

            try
            {
                using (SqlConnection conn = connection.GetConn())
                {
                    String query = "SELECT * FROM tblSignUp WHERE emailAddress = '" + email + "' AND password = '" + password + "'";
                    connection.OpenConn();
                    connection.ExecQuery(query);

                    SqlDataReader reader = connection.DataReader(query);

                    if (reader.HasRows)
                    {
                        // Success

                        while (reader.Read())
                        {
                            // process each row of data
                            email = reader["emailAddress"].ToString();
                            password = reader["password"].ToString();
                        }
                        MessageBox.Show("Welcome!", "Sign In Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                        Response.Redirect("Default.aspx", false);
                    }
                    else
                    {
                        // failed sign in
                        MessageBox.Show("User not found.", "Sign In Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                connection.CloseConn();
            }
        }

        private void ShowSweetAlert(string message)
        {
            string script = $"Swal.fire({{ title: 'Validation Error', text: '{message}', icon: 'error' }});";
            ClientScript.RegisterStartupScript(this.GetType(), "ShowSweetAlert", script, true);
        }
    }
}