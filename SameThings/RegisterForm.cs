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

namespace SameThings
{
  public partial class RegisterForm : Form
  {
    public RegisterForm()
    {
      InitializeComponent();
    }

    private void saveUser(string username, string password)
    {
      SqlConnection conn = DBUtils.GetDBConnection();

      try
      {
        conn.Open();
      }
      catch (Exception e)
      {
        Console.WriteLine("Error: " + e.Message);
      }


      SqlCommand cmd = conn.CreateCommand();
      cmd.CommandText = "INSERT INTO USERS(USERNAME, PASSWORD) VALUES (\'" + username + "\', \'" + password + "\'" + ")";
      cmd.ExecuteNonQuery();
      conn.Close();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
      saveUser(textUsername.Text, textPassword.Text);

      DialogResult rs = MessageBox.Show("Register success", "Register", MessageBoxButtons.OK);
      if (rs == DialogResult.OK)
      {
        LoginForm frm = new LoginForm();
        frm.Show();
        this.Hide();
      }
    }
  }
}
