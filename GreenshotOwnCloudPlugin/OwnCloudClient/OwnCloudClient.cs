using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using GreenshotPlugin.Core;

namespace GreenshotOwnCloudPlugin.OwnCloudClient
{
	internal class OwnCloudClient
	{
		private readonly Uri _ownCloudBaseUri;
		private readonly IAuthenticationProvider _authenticationProvider;

		public OwnCloudClient(Uri ownCloudBaseUri, IAuthenticationProvider authenticationProvider)
		{
			_ownCloudBaseUri = ownCloudBaseUri;
			_authenticationProvider = authenticationProvider;
		}

		public Uri UploadAndShareImage(IBinaryContainer imageContainer, string cloudFolderPath)
		{
			var cloudPathAndFilename = PostImage(imageContainer, cloudFolderPath);
			return CreateFileShareLink(cloudPathAndFilename);
		}

		public Uri UploadAndShareImage(byte[] image, string cloudLocalPathAndName)
		{
			PostImage(image, cloudLocalPathAndName);
			return CreateFileShareLink(cloudLocalPathAndName);
		}

		public void UploadImage(byte[] image, string cloudLocalPathAndName)
		{
			PostImage(image, cloudLocalPathAndName);
		}

		public void UploadImage(IBinaryContainer imageContainer, string cloudLocalPathAndName)
		{
			PostImage(imageContainer, cloudLocalPathAndName);
		}

		private void PostImage(byte[] image, string cloudLocalPathAndName)
		{
			var webDavUri = new Uri(_ownCloudBaseUri, "remote.php/webdav/");
			var imagePostUri = new Uri(webDavUri, cloudLocalPathAndName);

			var request = (HttpWebRequest) WebRequest.Create(imagePostUri);
			MakePutRequest(request, image);
		}

		private string PostImage(IBinaryContainer imageContainer, string cloudLocalPath)
		{
			var webDavUri = new Uri(_ownCloudBaseUri, "remote.php/webdav/");
			var fileNameWithPath = Path.Combine(cloudLocalPath, imageContainer.Filename);
			var imagePostUri = new Uri(webDavUri, fileNameWithPath);

			var request = (HttpWebRequest) WebRequest.Create(imagePostUri);
			MakePutRequest(request, imageContainer);
			return fileNameWithPath;
		}

		private Uri CreateFileShareLink(string filename)
		{
			var requestUri = GetShareRequestUri(filename);
			var request = (HttpWebRequest) WebRequest.Create(requestUri);
			request.Method = "POST";
			var responseStream = MakeRequest(request);
			return ExtractShareLink(responseStream);
		}

		private Uri GetShareRequestUri(string filename)
		{
			var shareApiPath = "ocs/v1.php/apps/files_sharing/api/v1/shares";
			var parameters = NetworkHelper.GenerateQueryParameters(new Dictionary<string, object>
			{
				{"path", filename},
				{"shareType", 3},
				{"permissions", 1}
			});
			var requestUri = new Uri(_ownCloudBaseUri, string.Format("{0}?{1}", shareApiPath, parameters));
			return requestUri;
		}

		private Uri ExtractShareLink(Stream responseStream)
		{
			using (var sr = new StreamReader(responseStream))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					if (line.Contains("<url>") )
					{
						var urlStartIndex = line.IndexOf("<url>") + 5;
						var closingTagIndex = line.IndexOf("</url>");
						var urlLength = (closingTagIndex > 0 ? closingTagIndex : line.Length) - urlStartIndex;

						return new Uri(line.Substring(urlStartIndex, urlLength));
					}
				}
			}
			throw new WebException("Share API response does not contain <url> element");
		}

		private void MakePutRequest(HttpWebRequest request, byte[] content)
		{
			request.Method = "PUT";
			using (var stream = request.GetRequestStream())
			{
				stream.Write(content, 0, content.Length);
			}
			MakeRequest(request);
		}

		private void MakePutRequest(HttpWebRequest request, IBinaryContainer content)
		{
			request.Method = "PUT";
			using (var stream = request.GetRequestStream())
			{
				content.WriteToStream(stream);
			}
			MakeRequest(request);
		}

		private Stream MakeRequest(HttpWebRequest request)
		{
			_authenticationProvider.SetAuthorizationOn(request);
			
			var response = (HttpWebResponse)request.GetResponse();
			return response.GetResponseStream();
		}
	}
}
