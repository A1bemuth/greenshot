namespace GreenshotOwnCloudPlugin.Forms
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
			this.textbox_login = new GreenshotPlugin.Controls.GreenshotTextBox();
			this.loginLabel = new GreenshotPlugin.Controls.GreenshotLabel();
			this.textbox_password = new GreenshotPlugin.Controls.GreenshotTextBox();
			this.passwordLabel = new GreenshotPlugin.Controls.GreenshotLabel();
			this.greenshotButton1 = new GreenshotPlugin.Controls.GreenshotButton();
			this.greenshotButton2 = new GreenshotPlugin.Controls.GreenshotButton();
			this.SuspendLayout();
			// 
			// textbox_login
			// 
			this.textbox_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textbox_login.Location = new System.Drawing.Point(12, 25);
			this.textbox_login.Name = "textbox_login";
			this.textbox_login.Size = new System.Drawing.Size(260, 20);
			this.textbox_login.TabIndex = 0;
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.Location = new System.Drawing.Point(12, 9);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(33, 13);
			this.loginLabel.TabIndex = 1;
			this.loginLabel.Text = "Login";
			// 
			// textbox_password
			// 
			this.textbox_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textbox_password.Location = new System.Drawing.Point(12, 68);
			this.textbox_password.Name = "textbox_password";
			this.textbox_password.PasswordChar = '*';
			this.textbox_password.Size = new System.Drawing.Size(260, 20);
			this.textbox_password.TabIndex = 0;
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 52);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(53, 13);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Password";
			// 
			// greenshotButton1
			// 
			this.greenshotButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.greenshotButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.greenshotButton1.Location = new System.Drawing.Point(116, 102);
			this.greenshotButton1.Name = "greenshotButton1";
			this.greenshotButton1.Size = new System.Drawing.Size(75, 23);
			this.greenshotButton1.TabIndex = 2;
			this.greenshotButton1.Text = "OK";
			this.greenshotButton1.UseVisualStyleBackColor = true;
			this.greenshotButton1.Click += new System.EventHandler(this.greenshotButton1_Click);
			// 
			// greenshotButton2
			// 
			this.greenshotButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.greenshotButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.greenshotButton2.Location = new System.Drawing.Point(197, 102);
			this.greenshotButton2.Name = "greenshotButton2";
			this.greenshotButton2.Size = new System.Drawing.Size(75, 23);
			this.greenshotButton2.TabIndex = 3;
			this.greenshotButton2.Text = "Cancel";
			this.greenshotButton2.UseVisualStyleBackColor = true;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 137);
			this.Controls.Add(this.greenshotButton2);
			this.Controls.Add(this.greenshotButton1);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.loginLabel);
			this.Controls.Add(this.textbox_password);
			this.Controls.Add(this.textbox_login);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.Text = "OwnCloud Login";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GreenshotPlugin.Controls.GreenshotTextBox textbox_login;
		private GreenshotPlugin.Controls.GreenshotLabel loginLabel;
		private GreenshotPlugin.Controls.GreenshotTextBox textbox_password;
		private GreenshotPlugin.Controls.GreenshotLabel passwordLabel;
		private GreenshotPlugin.Controls.GreenshotButton greenshotButton1;
		private GreenshotPlugin.Controls.GreenshotButton greenshotButton2;
	}
}