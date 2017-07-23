using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Greenshot.IniFile;
using Greenshot.Plugin;
using GreenshotOwnCloudPlugin.Forms;
using GreenshotPlugin.Controls;
using GreenshotPlugin.Core;

namespace GreenshotOwnCloudPlugin
{
    public class OwnCloudPlugin : IGreenshotPlugin
    {
		private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(typeof(OwnCloudPlugin));

		private IGreenshotHost _host;
	    private OwnCloudPluginConfiguration _config;

	    public bool Initialize(IGreenshotHost host, PluginAttribute pluginAttribute)
	    {
		    _host = host;
		    _config = IniConfig.GetIniSection<OwnCloudPluginConfiguration>();
			var resources = new ComponentResourceManager(typeof(OwnCloudPlugin));
			var itemPluginConfig = new GreenshotToolStripMenuItem
			{
				LanguageKey = LanguageKey.configure.ToString(),
				Tag = _host,
				Image = (Image) resources.GetObject("OwnCloud")
			};
		    itemPluginConfig.Click += (sender, args) => { Configure(); };

			PluginUtils.AddToContextMenu(_host, itemPluginConfig);
		    return true;
	    }

	    public void Shutdown()
	    {
			Log.Debug("Owncloud plugin shutdown.");
	    }

	    public void Configure()
	    {
		    new SettingsForm().ShowDialog();
	    }

	    public IEnumerable<IDestination> Destinations()
	    {
		    yield return new OwnCloudDestination(_config);
	    }

	    public IEnumerable<IProcessor> Processors()
	    {
		    yield break;
	    }

	    public void Dispose()
	    {
	    }
    }
}
