/*
 * Greenshot - a free and open source screenshot tool
 * Copyright (C) 2007-2011  Thomas Braun, Jens Klingen, Robin Krom
 * 
 * For more information see: http://getgreenshot.org/
 * The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
namespace GreenshotOwnCloudPlugin.Forms {
	partial class SettingsForm {
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.buttonOK = new GreenshotPlugin.Controls.GreenshotButton();
			this.buttonCancel = new GreenshotPlugin.Controls.GreenshotButton();
			this.combobox_uploadImageFormat = new GreenshotPlugin.Controls.GreenshotComboBox();
			this.label_upload_format = new GreenshotPlugin.Controls.GreenshotLabel();
			this.label_AfterUpload = new GreenshotPlugin.Controls.GreenshotLabel();
			this.checkboxAfterUploadLinkToClipBoard = new GreenshotPlugin.Controls.GreenshotCheckBox();
			this.textbox_ownCloudUri = new GreenshotPlugin.Controls.GreenshotTextBox();
			this.owncloud_uri_label = new GreenshotPlugin.Controls.GreenshotLabel();
			this.textbox_screenshotsSubfolder = new GreenshotPlugin.Controls.GreenshotTextBox();
			this.folder_label = new GreenshotPlugin.Controls.GreenshotLabel();
			this.SuspendLayout();
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.LanguageKey = "OK";
			this.buttonOK.Location = new System.Drawing.Point(253, 114);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 10;
			this.buttonOK.Text = "Ok";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.LanguageKey = "CANCEL";
			this.buttonCancel.Location = new System.Drawing.Point(334, 114);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 11;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// combobox_uploadImageFormat
			// 
			this.combobox_uploadImageFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.combobox_uploadImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combobox_uploadImageFormat.FormattingEnabled = true;
			this.combobox_uploadImageFormat.Location = new System.Drawing.Point(111, 65);
			this.combobox_uploadImageFormat.Name = "combobox_uploadImageFormat";
			this.combobox_uploadImageFormat.PropertyName = "UploadFormat";
			this.combobox_uploadImageFormat.SectionName = "OwnCloud";
			this.combobox_uploadImageFormat.Size = new System.Drawing.Size(299, 21);
			this.combobox_uploadImageFormat.TabIndex = 1;
			// 
			// label_upload_format
			// 
			this.label_upload_format.LanguageKey = "owncloud.label_upload_format";
			this.label_upload_format.Location = new System.Drawing.Point(12, 68);
			this.label_upload_format.Name = "label_upload_format";
			this.label_upload_format.Size = new System.Drawing.Size(84, 20);
			this.label_upload_format.TabIndex = 9;
			this.label_upload_format.Text = "Image format";
			// 
			// label_AfterUpload
			// 
			this.label_AfterUpload.LanguageKey = "owncloud.label_AfterUpload";
			this.label_AfterUpload.Location = new System.Drawing.Point(12, 95);
			this.label_AfterUpload.Name = "label_AfterUpload";
			this.label_AfterUpload.Size = new System.Drawing.Size(84, 21);
			this.label_AfterUpload.TabIndex = 22;
			this.label_AfterUpload.Text = "After upload";
			// 
			// checkboxAfterUploadLinkToClipBoard
			// 
			this.checkboxAfterUploadLinkToClipBoard.AutoSize = true;
			this.checkboxAfterUploadLinkToClipBoard.LanguageKey = "dropbox.label_AfterUploadLinkToClipBoard";
			this.checkboxAfterUploadLinkToClipBoard.Location = new System.Drawing.Point(111, 94);
			this.checkboxAfterUploadLinkToClipBoard.Name = "checkboxAfterUploadLinkToClipBoard";
			this.checkboxAfterUploadLinkToClipBoard.PropertyName = "AfterUploadLinkToClipBoard";
			this.checkboxAfterUploadLinkToClipBoard.SectionName = "OwnCloud";
			this.checkboxAfterUploadLinkToClipBoard.Size = new System.Drawing.Size(104, 17);
			this.checkboxAfterUploadLinkToClipBoard.TabIndex = 2;
			this.checkboxAfterUploadLinkToClipBoard.Text = "Link to clipboard";
			this.checkboxAfterUploadLinkToClipBoard.UseVisualStyleBackColor = true;
			// 
			// textbox_ownCloudUri
			// 
			this.textbox_ownCloudUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textbox_ownCloudUri.Location = new System.Drawing.Point(111, 13);
			this.textbox_ownCloudUri.Name = "textbox_ownCloudUri";
			this.textbox_ownCloudUri.PropertyName = "OwnCloudUri";
			this.textbox_ownCloudUri.SectionName = "OwnCloud";
			this.textbox_ownCloudUri.Size = new System.Drawing.Size(298, 20);
			this.textbox_ownCloudUri.TabIndex = 23;
			// 
			// owncloud_uri_label
			// 
			this.owncloud_uri_label.AutoSize = true;
			this.owncloud_uri_label.LanguageKey = "owncloud.settings_uri_label";
			this.owncloud_uri_label.Location = new System.Drawing.Point(12, 16);
			this.owncloud_uri_label.Name = "owncloud_uri_label";
			this.owncloud_uri_label.Size = new System.Drawing.Size(78, 13);
			this.owncloud_uri_label.TabIndex = 24;
			this.owncloud_uri_label.Text = "OwnCloud URI";
			// 
			// textbox_screenshotsSubfolder
			// 
			this.textbox_screenshotsSubfolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textbox_screenshotsSubfolder.Location = new System.Drawing.Point(111, 39);
			this.textbox_screenshotsSubfolder.Name = "textbox_screenshotsSubfolder";
			this.textbox_screenshotsSubfolder.PropertyName = "ScreenshotsFolder";
			this.textbox_screenshotsSubfolder.SectionName = "OwnCloud";
			this.textbox_screenshotsSubfolder.Size = new System.Drawing.Size(298, 20);
			this.textbox_screenshotsSubfolder.TabIndex = 23;
			// 
			// folder_label
			// 
			this.folder_label.AutoSize = true;
			this.folder_label.LanguageKey = "owncloud.settings_folder_name";
			this.folder_label.Location = new System.Drawing.Point(12, 42);
			this.folder_label.Name = "folder_label";
			this.folder_label.Size = new System.Drawing.Size(95, 13);
			this.folder_label.TabIndex = 24;
			this.folder_label.Text = "Screenshots folder";
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(422, 149);
			this.Controls.Add(this.folder_label);
			this.Controls.Add(this.owncloud_uri_label);
			this.Controls.Add(this.textbox_screenshotsSubfolder);
			this.Controls.Add(this.textbox_ownCloudUri);
			this.Controls.Add(this.checkboxAfterUploadLinkToClipBoard);
			this.Controls.Add(this.label_AfterUpload);
			this.Controls.Add(this.label_upload_format);
			this.Controls.Add(this.combobox_uploadImageFormat);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.LanguageKey = "owncloud.settings_title";
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingsForm";
			this.Text = "OwnCloud settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private GreenshotPlugin.Controls.GreenshotComboBox combobox_uploadImageFormat;
		private GreenshotPlugin.Controls.GreenshotLabel label_upload_format;
		private GreenshotPlugin.Controls.GreenshotButton buttonCancel;
		private GreenshotPlugin.Controls.GreenshotButton buttonOK;
		private GreenshotPlugin.Controls.GreenshotLabel label_AfterUpload;
		private GreenshotPlugin.Controls.GreenshotCheckBox checkboxAfterUploadLinkToClipBoard;
		private GreenshotPlugin.Controls.GreenshotTextBox textbox_ownCloudUri;
		private GreenshotPlugin.Controls.GreenshotLabel owncloud_uri_label;
		private GreenshotPlugin.Controls.GreenshotTextBox textbox_screenshotsSubfolder;
		private GreenshotPlugin.Controls.GreenshotLabel folder_label;
	}
}
