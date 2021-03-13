namespace SameThings
{
    partial class SameThings
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
      this.textUsername = new System.Windows.Forms.Label();
      this.textCountDown = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // textPoint
      // 
      this.textPoint.AutoSize = true;
      this.textPoint.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textPoint.Location = new System.Drawing.Point(369, 12);
      this.textPoint.Name = "textPoint";
      this.textPoint.Size = new System.Drawing.Size(23, 24);
      this.textPoint.TabIndex = 0;
      this.textPoint.Text = "0";
      this.textPoint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // textUsername
      // 
      this.textUsername.AutoSize = true;
      this.textUsername.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textUsername.Location = new System.Drawing.Point(13, 10);
      this.textUsername.Name = "textUsername";
      this.textUsername.Size = new System.Drawing.Size(0, 25);
      this.textUsername.TabIndex = 1;
      // 
      // textCountDown
      // 
      this.textCountDown.AutoSize = true;
      this.textCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textCountDown.Location = new System.Drawing.Point(701, 15);
      this.textCountDown.Name = "textCountDown";
      this.textCountDown.Size = new System.Drawing.Size(18, 20);
      this.textCountDown.TabIndex = 2;
      this.textCountDown.Text = "0";
      // 
      // SameThings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
      this.ClientSize = new System.Drawing.Size(784, 761);
      this.Controls.Add(this.textCountDown);
      this.Controls.Add(this.textUsername);
      this.Controls.Add(this.textPoint);
      this.Name = "SameThings";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SameThings";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textPoint;
        private System.Windows.Forms.Label textUsername;
        private System.Windows.Forms.Label textCountDown;

    }
}