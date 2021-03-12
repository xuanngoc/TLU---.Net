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
using System.Data.Common;

namespace SameThings
{
  public partial class LoginForm : Form
  {
    private string id;
    public LoginForm()
    {
      InitializeComponent();
    }

    private bool authen(string username, string password)
    {
      Console.WriteLine("Getting Connection ...");
      SqlConnection conn = DBUtils.GetDBConnection();

      try
      {
        Console.WriteLine("Openning Connection ...");
        conn.Open();
        Console.WriteLine("Connection successful!");
      }
      catch (Exception e)
      {
        Console.WriteLine("Error: " + e.Message);
      }


      SqlCommand cmd = conn.CreateCommand();
      cmd.CommandText = "SELECT * FROM USERS WHERE USERNAME = " + "'" + username + "'";

      try
      {
        DbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {

          while (reader.Read())
          {

            id = reader.GetString(0);

            string name = reader.GetString(1);
            string pw = reader.GetString(2);

            if (pw == password)
            {
              conn.Close();
              return true;
            }
            else
            {
              conn.Close();
              return false;
            }
          }
        }
      }
      catch (InvalidOperationException e)
      {
        Console.WriteLine("Error: " + e.Message);
      }
      conn.Close();
      return false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string username = inputUsername.Text;
      string password = inputPassword.Text;

      bool authenticated = authen(username, password);
      if (authenticated)
      {
        SameThings frm = new SameThings(id, username);
        frm.Show();
        this.Hide();
      }
      else
      {
        MessageBox.Show("The username or password is incorrect!");
      }
    }
  }

}
