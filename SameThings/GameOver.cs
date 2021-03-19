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
  public partial class GameOver : Form
  {
    private string user_id;
    private string username;

    public GameOver(int point, int time, string user_id, string username)
    {
      InitializeComponent();

      this.user_id = user_id;
      this.username = username;

      textPoint.Text = point.ToString();
      //textTime.Text = time.ToString();
      initialListViewScore();
    }

    private void initialListViewScore()
    {
      List<ListViewItem> listItems = getTopHighScore();

      listHighScore.View = View.Details;
      listHighScore.Columns.Add("TOP").Width = 100;
      listHighScore.Columns.Add("Nick name").Width = 200;
      listHighScore.Columns.Add("Score").Width = 200;
      listHighScore.Font = new Font("Tahoma", 16f, FontStyle.Regular);
      foreach (ListViewItem item in listItems)
      {
        
        listHighScore.Items.Add(item);
      }
      //listHighScore.GridLines = true;

    }

    private List<ListViewItem> getTopHighScore()
    {
      List<ListViewItem> listItems = new List<ListViewItem>();
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
      string sql = "SELECT TOP 10 U.username, S.SCORE  FROM USERS AS U INNER JOIN SCORES AS S ON U.ID = S.USER_ID ORDER BY SCORE DESC";
      cmd.CommandText = sql;

      try
      {
        DbDataReader reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
          int top = 10;
          while (reader.Read())
          {
            string username = reader.GetString(0);
            string score = reader.GetInt32(1).ToString();

            listItems.Add(new ListViewItem(new string[] {top--.ToString() , username, score }));
          }
          conn.Close();
          return listItems;
        }
      }
      catch (InvalidOperationException e)
      {
        Console.WriteLine("Error: " + e.Message);
      }
      conn.Close();
      return null;
    }

    private void btnPlayAgain_Click(object sender, EventArgs e)
    {
      SameThings frm = new SameThings(user_id, username);
      frm.Show();
      this.Hide();
    }
  }
}
