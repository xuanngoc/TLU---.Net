namespace SameThings
{
  partial class GameOver
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.textPoint = new System.Windows.Forms.Label();
      this.listHighScore = new System.Windows.Forms.ListView();
      this.label3 = new System.Windows.Forms.Label();
      this.btnPlayAgain = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textPoint
      // 
      this.textPoint.AutoSize = true;
      this.textPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.textPoint.Location = new System.Drawing.Point(331, 29);
      this.textPoint.Name = "textPoint";
      this.textPoint.Size = new System.Drawing.Size(99, 108);
      this.textPoint.TabIndex = 0;
      this.textPoint.Text = "0";
      this.textPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // listHighScore
      // 
      this.listHighScore.Location = new System.Drawing.Point(105, 224);
      this.listHighScore.Name = "listHighScore";
      this.listHighScore.Size = new System.Drawing.Size(574, 349);
      this.listHighScore.TabIndex = 2;
      this.listHighScore.UseCompatibleStateImageBehavior = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(101, 197);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(105, 24);
      this.label3.TabIndex = 3;
      this.label3.Text = "High Score";
      // 
      // btnPlayAgain
      // 
      this.btnPlayAgain.BackColor = System.Drawing.Color.White;
      this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnPlayAgain.ForeColor = System.Drawing.Color.Blue;
      this.btnPlayAgain.Location = new System.Drawing.Point(285, 645);
      this.btnPlayAgain.Name = "btnPlayAgain";
      this.btnPlayAgain.Size = new System.Drawing.Size(198, 61);
      this.btnPlayAgain.TabIndex = 4;
      this.btnPlayAgain.Text = "Play again";
      this.btnPlayAgain.UseVisualStyleBackColor = false;
      this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
      // 
      // GameOver
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.ClientSize = new System.Drawing.Size(784, 761);
      this.Controls.Add(this.btnPlayAgain);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.listHighScore);
      this.Controls.Add(this.textPoint);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Name = "GameOver";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "GameOver";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label textPoint;
    private System.Windows.Forms.ListView listHighScore;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnPlayAgain;
  }
}