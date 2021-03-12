namespace SameThings
{
    partial class LoginForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
      this.textUserName = new System.Windows.Forms.Label();
      this.textPassword = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.inputUsername = new System.Windows.Forms.TextBox();
      this.inputPassword = new System.Windows.Forms.TextBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // textUserName
      // 
      this.textUserName.AutoSize = true;
      this.textUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textUserName.Location = new System.Drawing.Point(141, 341);
      this.textUserName.Name = "textUserName";
      this.textUserName.Size = new System.Drawing.Size(102, 24);
      this.textUserName.TabIndex = 0;
      this.textUserName.Text = "User name";
      // 
      // textPassword
      // 
      this.textPassword.AutoSize = true;
      this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textPassword.Location = new System.Drawing.Point(141, 417);
      this.textPassword.Name = "textPassword";
      this.textPassword.Size = new System.Drawing.Size(92, 24);
      this.textPassword.TabIndex = 1;
      this.textPassword.Text = "Password";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(631, 739);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(141, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Power by Xuan Ngoc Studio";
      // 
      // inputUsername
      // 
      this.inputUsername.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputUsername.Location = new System.Drawing.Point(261, 341);
      this.inputUsername.Name = "inputUsername";
      this.inputUsername.Size = new System.Drawing.Size(301, 39);
      this.inputUsername.TabIndex = 3;
      // 
      // inputPassword
      // 
      this.inputPassword.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.inputPassword.Location = new System.Drawing.Point(261, 417);
      this.inputPassword.Name = "inputPassword";
      this.inputPassword.Size = new System.Drawing.Size(301, 39);
      this.inputPassword.TabIndex = 4;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(286, 43);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(233, 237);
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.BlueViolet;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.ForeColor = System.Drawing.SystemColors.Control;
      this.button1.Location = new System.Drawing.Point(351, 542);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(105, 38);
      this.button1.TabIndex = 6;
      this.button1.Text = "Log in";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.ClientSize = new System.Drawing.Size(784, 761);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.inputPassword);
      this.Controls.Add(this.inputUsername);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textPassword);
      this.Controls.Add(this.textUserName);
      this.Name = "LoginForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LoginForm";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textUserName;
        private System.Windows.Forms.Label textPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputUsername;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}