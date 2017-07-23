using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Greenshot.IniFile;
using Greenshot.Plugin;
using GreenshotOwnCloudPlugin.Forms;
using GreenshotOwnCloudPlugin.OwnCloudClient;
using GreenshotPlugin.Core;

namespace GreenshotOwnCloudPlugin
{
	internal class OwnCloudDestination : AbstractDestination
	{
		private OwnCloudPluginConfiguration _configuration;

		public OwnCloudDestination(OwnCloudPluginConfiguration configuration)
		{
			_configuration = configuration;
		}

		public override string Designation
		{
			get { return "OwnCloud"; }
		}

		public override string Description
		{
			get { return Language.GetString("owncloud", LanguageKey.upload_menu_item); }
		}

		public override Image DisplayIcon
		{
			get
			{
				var resources = new ComponentResourceManager(typeof(OwnCloudPlugin));
				return (Image) resources.GetObject("OwnCloud");
			}
		}

		public override ExportInformation ExportCapture(bool manuallyInitiated, ISurface surface, ICaptureDetails captureDetails)
		{
			if(!HasBaseUriSetting())
			{
				return new ExportInformation(Designation, Description, false);
			}

			var baseUri = new Uri(_configuration.OwnCloudUri);
			var authenticationProvider = new BasicAuthenticationProvider(GetCredentials());
			var ownCloudClient = new OwnCloudClient.OwnCloudClient(baseUri, authenticationProvider);

			var imageContainer = MakeSurfaceContainer(surface, captureDetails);
			if (_configuration.AfterUploadLinkToClipBoard)
			{
				var shareUri = ownCloudClient.UploadAndShareImage(imageContainer, _configuration.ScreenshotsFolder);
				Clipboard.SetText(shareUri.ToString());
			}
			else
			{
				ownCloudClient.UploadImage(imageContainer, _configuration.ScreenshotsFolder);
			}
			return new ExportInformation(Designation, Description, true);
		}

		private bool HasBaseUriSetting()
		{
			if (!string.IsNullOrEmpty(_configuration.OwnCloudUri))
				return true;

			var result = new SettingsForm().ShowDialog();
			_configuration = IniConfig.GetIniSection<OwnCloudPluginConfiguration>();
			return result == DialogResult.OK && !string.IsNullOrEmpty(_configuration.OwnCloudUri);
		}

		private LoginPassword GetCredentials()
		{
			var credentials = new LoginPassword();
			var dialogResult = new LoginForm(credentials).ShowDialog();

			if (dialogResult == DialogResult.Cancel)
				throw new Exception("Operation cancelled by user");
			return credentials;
		}

		private SurfaceContainer MakeSurfaceContainer(ISurface surface, ICaptureDetails captureDetails)
		{
			var outputSettings = new SurfaceOutputSettings(_configuration.UploadFormat, _configuration.UploadJpegQuality, false);
			var filename = FilenameHelper.GetFilename(_configuration.UploadFormat, captureDetails);
			var imageContainer = new SurfaceContainer(surface, outputSettings, filename);
			return imageContainer;
		}
	}
}
