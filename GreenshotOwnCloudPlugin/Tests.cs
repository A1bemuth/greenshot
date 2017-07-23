using System;
using System.IO;
using GreenshotOwnCloudPlugin.OwnCloudClient;
using NUnit.Framework;

namespace GreenshotOwnCloudPlugin
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Test()
		{
			var authorizer = new BasicAuthenticationProvider(new LoginPassword{Login = "kodmi", Password = "Vfnhtirf7bpujq1jlby"});
			var client = new OwnCloudClient.OwnCloudClient(new Uri("https://disk.skbkontur.ru/"), authorizer);

			var image = File.ReadAllBytes(@"C:\Users\Albem\Desktop\belka.PNG");
			var shareUri = client.UploadAndShareImage(image, "belka.png");
			Console.WriteLine(shareUri);
		}
	}
}
