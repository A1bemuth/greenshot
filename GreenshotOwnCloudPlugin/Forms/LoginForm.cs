using GreenshotPlugin.Controls;

namespace GreenshotOwnCloudPlugin.Forms
{
	public partial class LoginForm : GreenshotForm
	{
		private readonly LoginPassword _loginInfo;

		public LoginForm(LoginPassword loginInfo)
		{
			_loginInfo = loginInfo;
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, System.EventArgs e)
		{

		}

		private void greenshotButton1_Click(object sender, System.EventArgs e)
		{
			_loginInfo.Login = textbox_login.Text;
			_loginInfo.Password = textbox_password.Text;
		}
	}
}
