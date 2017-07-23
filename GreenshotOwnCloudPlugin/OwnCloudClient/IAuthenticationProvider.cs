using System;
using System.Net;
using System.Text;

namespace GreenshotOwnCloudPlugin.OwnCloudClient
{
	internal interface IAuthenticationProvider
	{
		void SetAuthorizationOn(WebRequest request);
	}

	internal class BasicAuthenticationProvider : IAuthenticationProvider
	{
		private readonly string _login;
		private readonly string _password;

		public BasicAuthenticationProvider(LoginPassword credentials)
		{
			_login = credentials.Login;
			_password = credentials.Password;
		}

		public void SetAuthorizationOn(WebRequest request)
		{
			var authorizationHeaderValue = string.Format("Basic {0}", GetAuthorizationParameter());
			request.Headers.Set(HttpRequestHeader.Authorization, authorizationHeaderValue);
		}

		private string GetAuthorizationParameter()
		{
			var concated = string.Format("{0}:{1}", _login, _password);
			var bytes = Encoding.UTF8.GetBytes(concated);
			return Convert.ToBase64String(bytes);
		}
	}
}
