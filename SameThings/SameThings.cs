using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SameThings
{
  public partial class SameThings : Form
  {
    private Dictionary<string, int> symbols = new Dictionary<string, int>();


    List<List<Button>> board = new List<List<Button>>();
    private int SHOW_TIMES = 7;
    private int SIZE_OF_BOARD = 7;
    private int SIZE_BUTTON = 80;

    private Button btnPreviousTurn;
    private Button btnCurrentTurn;
    private int next = 0;
    private int point = 0;

    private System.Windows.Forms.Timer timer;
    private int counter = 60;

    private Random rand = new Random();
    private string user_id;
    public SameThings(string user_id, string username)
    {
      InitializeComponent();
      this.user_id = user_id;
      textUsername.Text = username;
      createSymbols();
      for (int i = 0; i < SIZE_OF_BOARD; i++)
      {
        List<Button> row = new List<Button>();
        for (int k = 0; k < SIZE_OF_BOARD; k++)
        {
          Button button = new Button();
          button.Location = new Point(100 + k * SIZE_BUTTON, 100 + i * SIZE_BUTTON);
          button.Click += button_Click;
          button.Height = SIZE_BUTTON;
          button.Width = SIZE_BUTTON;
          button.Text = randomSymbol();
          button.BackColor = Color.BlueViolet;
          button.Font = new Font("Tahoma", 35f, FontStyle.Regular);
          button.ForeColor = Color.BlueViolet;
          row.Add(button);
        }
        board.Add(row);
      }

      for (int i = 0; i < SIZE_OF_BOARD; i++)
      {
        for (int k = 0; k < SIZE_OF_BOARD; k++)
        {
          this.Controls.Add(board[i][k]);
        }
      }
      startCountTime();
    }

    void button_Click(object sender, EventArgs e)
    {
      Button btn = (Button)sender;
      if (sender == btnPreviousTurn)
      {
        return;
      }
      btn.BackColor = Color.Transparent;
      btn.Refresh();
      next++;
      if (next % 2 == 0)
      {
        btnCurrentTurn = btn;
        if (btnPreviousTurn.Text == btnCurrentTurn.Text)
        {
          System.Threading.Thread.Sleep(700);
          btnPreviousTurn.BackColor = Color.Tomato;
          btnPreviousTurn.Dispose();
          btnCurrentTurn.BackColor = Color.Tomato;
          btnCurrentTurn.Dispose();
          point += 10;
          textPoint.Text = point.ToString();
          if (point == SIZE_OF_BOARD * SIZE_OF_BOARD / 2 * 10)
          {
            timer.Stop();
            stopGame();
          }
        }
        else
        {
          System.Threading.Thread.Sleep(700);
          btnPreviousTurn.BackColor = Color.BlueViolet;
          btnCurrentTurn.BackColor = Color.BlueViolet;
        }
      }
      else
      {
        btnPreviousTurn = btn;
      }

    }

    private Point getLocation(Button btn)
    {
      int xLocation = btn.Location.X;
      int x = (xLocation - 100) / SIZE_BUTTON;

      int yLocation = btn.Location.Y;
      int y = (xLocation - 100) / SIZE_BUTTON;

      return new Point(x, y);
    }

    private void createSymbols()
    {
      //string[] samples = { "❤", "🔥", "☕", "🌭", "🧯", "🚒", "🎁", "🏩", "🌼", "★", "☭", "🍻" };
      string[] samples = { "❤", "🔥", "☕", "🌭", "🎁", "🌼", "★"};

      foreach (string s in samples)
      {
        symbols.Add(s, SHOW_TIMES);
      }
    }

    private string randomSymbol()
    {
      while (true)
      {
        string s = symbols.ElementAt(rand.Next(0, symbols.Count)).Key;
        if (symbols[s] > 0)
        {
          symbols[s] = symbols[s] - 1;
          return s;
        }
      }
    }

    private void doFirstStep()
    {
      int x = rand.Next(0, SIZE_OF_BOARD);
      int y = rand.Next(0, SIZE_OF_BOARD);
      btnPreviousTurn = board[x][y];
      btnPreviousTurn.BackColor = Color.Transparent;
    }

    private void startCountTime()
    {
      timer = new System.Windows.Forms.Timer();
      timer.Tick += new EventHandler(timer1_Tick);
      timer.Interval = 1000;
      timer.Start();
      textCountDown.Text = counter.ToString();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      counter--;
      if (counter == 0) 
      {
        timer.Stop();
        stopGame();
      }
      textCountDown.Text = counter.ToString();
    }

    private void stopGame()
    {
      saveScore(user_id, point);
      GameOver frm = new GameOver(point, counter);
      frm.Show();
      this.Hide();
    }

    private void saveScore(string user_id, int point)
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
      cmd.CommandText = "INSERT INTO SCORES(USER_ID, SCORE) VALUES(" + user_id + ", " + point + ")";
      cmd.ExecuteNonQuery();
      conn.Close();
    }

  }
}
