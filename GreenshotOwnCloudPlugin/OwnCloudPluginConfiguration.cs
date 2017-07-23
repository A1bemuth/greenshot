using Greenshot.IniFile;
using GreenshotPlugin.Core;

namespace GreenshotOwnCloudPlugin
{
	[IniSection("OwnCloud", Description = "Greenshot Owncloud Plugin configuration")]
	public class OwnCloudPluginConfiguration : IniSection
	{
		[IniProperty("OwnCloudUri", Description = "URI of your owncloud storage")]
		public string OwnCloudUri { get; set; }

		[IniProperty("ScreenshotsFolder", Description = "Folder to place screenshots into", DefaultValue = "")]
		public string ScreenshotsFolder { get; set; }

		[IniProperty("UploadFormat", Description = "What file type to use for uploading", DefaultValue = "png")]
		public OutputFormat UploadFormat { get; set; }

		[IniProperty("AfterUploadLinkToClipBoard", Description = "After upload send Dropbox link to clipboard.", DefaultValue = "true")]
		public bool AfterUploadLinkToClipBoard { get; set; }

		[IniProperty("UploadJpegQuality", Description = "JPEG file save quality in %.", DefaultValue = "80")]
		public int UploadJpegQuality { get; set; }
	}
}
