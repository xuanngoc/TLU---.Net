namespace SameThings
{
  partial class RegisterForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnRegister = new System.Windows.Forms.Button();
      this.textUsername = new System.Windows.Forms.TextBox();
      this.textPassword = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(98, 301);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(130, 29);
      this.label1.TabIndex = 0;
      this.label1.Text = "User name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(98, 372);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(120, 29);
      this.label2.TabIndex = 1;
      this.label2.Text = "Password";
      // 
      // btnRegister
      // 
      this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.btnRegister.Location = new System.Drawing.Point(244, 486);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(334, 42);
      this.btnRegister.TabIndex = 2;
      this.btnRegister.Text = "👍 Register 👍";
      this.btnRegister.UseVisualStyleBackColor = true;
      this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
      // 
      // textUsername
      // 
      this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textUsername.Location = new System.Drawing.Point(243, 301);
      this.textUsername.Name = "textUsername";
      this.textUsername.Size = new System.Drawing.Size(334, 35);
      this.textUsername.TabIndex = 3;
      // 
      // textPassword
      // 
      this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textPassword.Location = new System.Drawing.Point(244, 372);
      this.textPassword.Name = "textPassword";
      this.textPassword.Size = new System.Drawing.Size(334, 35);
      this.textPassword.TabIndex = 4;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(326, 77);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(130, 149);
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // RegisterForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(784, 761);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.textPassword);
      this.Controls.Add(this.textUsername);
      this.Controls.Add(this.btnRegister);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "RegisterForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "RegisterForm";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.TextBox textUsername;
    private System.Windows.Forms.TextBox textPassword;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}