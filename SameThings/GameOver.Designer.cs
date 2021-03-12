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
      this.textTime = new System.Windows.Forms.Label();
      this.listView1 = new System.Windows.Forms.ListView();
      this.label3 = new System.Windows.Forms.Label();
      this.textTimer = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textPoint
      // 
      this.textPoint.AutoSize = true;
      this.textPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.textPoint.Location = new System.Drawing.Point(325, 22);
      this.textPoint.Name = "textPoint";
      this.textPoint.Size = new System.Drawing.Size(99, 108);
      this.textPoint.TabIndex = 0;
      this.textPoint.Text = "0";
      // 
      // textTime
      // 
      this.textTime.AutoSize = true;
      this.textTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textTime.ForeColor = System.Drawing.Color.Red;
      this.textTime.Location = new System.Drawing.Point(337, 126);
      this.textTime.Name = "textTime";
      this.textTime.Size = new System.Drawing.Size(31, 33);
      this.textTime.TabIndex = 1;
      this.textTime.Text = "0";
      // 
      // listView1
      // 
      this.listView1.Location = new System.Drawing.Point(105, 224);
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(574, 349);
      this.listView1.TabIndex = 2;
      this.listView1.UseCompatibleStateImageBehavior = false;
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
      // textTimer
      // 
      this.textTimer.AutoSize = true;
      this.textTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textTimer.Location = new System.Drawing.Point(261, 130);
      this.textTimer.Name = "textTimer";
      this.textTimer.Size = new System.Drawing.Size(81, 29);
      this.textTimer.TabIndex = 4;
      this.textTimer.Text = "Time: ";
      // 
      // GameOver
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.ClientSize = new System.Drawing.Size(784, 761);
      this.Controls.Add(this.textTimer);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.listView1);
      this.Controls.Add(this.textTime);
      this.Controls.Add(this.textPoint);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.Name = "GameOver";
      this.Text = "GameOver";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label textPoint;
    private System.Windows.Forms.Label textTime;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label textTimer;
  }
}