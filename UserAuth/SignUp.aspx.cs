using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using static UserAuth.Conn;

namespace UserAuth
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // connection class


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            String firstName = txtFirstName.Text;
            String lastName = txtLastName.Text;
            String email = txtSignUpEmail.Text;
            String password = txtSignUpPassword.Text;
            String confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(firstName))
            {
                ShowErrorSweetAlert("Please enter your first name");
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                ShowErrorSweetAlert("Please enter your last name");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                ShowErrorSweetAlert("Please enter your email address");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                ShowErrorSweetAlert("Please enter your password");
                return;
            }

            if (confirmPassword != password)
            {
                ShowErrorSweetAlert("Passwords do not match.");
            }

            Conn connection = new Conn();

            try
            {
                using (SqlConnection conn = connection.GetConn())
                {
                    String query = "INSERT INTO tblSignUp(firstName, lastName, emailAddress, password)"
                                + "VALUES('" + firstName + "', '" + lastName + "', '" + email + "', '" + password + "')";
                    connection.OpenConn();
                    connection.ExecQuery(query);
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

            Session["UserEmail"] = email;

            MessageBox.Show($"You successfully signed up!", "Sign Up Success", MessageBoxButton.OK, MessageBoxImage.Information);

            Response.Redirect("SignIn.aspx");

        }

        private void ShowErrorSweetAlert(string message)
        {
            string script = $"Swal.fire({{ title: 'Validation Error', text: '{message}', icon: 'error' }});";
            ClientScript.RegisterStartupScript(this.GetType(), "ShowSweetAlert", script, true);
        }

        private void ShowSuccessSweetAlert(string title, string message, string icon)
        {
            string script = $@"Swal.fire({{
                            title: '{title}',
                            text: '{message}',
                            icon: '{icon}',
                            showConfirmButton: false,
                            timer: 2000  // Auto close after 2 seconds
                        }});";
            ClientScript.RegisterStartupScript(this.GetType(), "SweetAlert", script, true);
        }

    }
}