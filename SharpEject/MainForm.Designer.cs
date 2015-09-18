#region description
/*
 * MainForm Designer of SharpEject app
 * Copyright (C) 2011-2015, Petros Kyladitis
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/>
 */
 #endregion
 
namespace SharpEject{
	partial class MainForm{
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
		private void InitializeComponent(){
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.buttonEject = new System.Windows.Forms.Button();
			this.buttonInsert = new System.Windows.Forms.Button();
			this.comboBoxDrives = new System.Windows.Forms.ComboBox();
			this.menuStripMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshDrivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ejectSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.menuStripMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonEject
			// 
			this.buttonEject.Image = ((System.Drawing.Image)(resources.GetObject("buttonEject.Image")));
			this.buttonEject.Location = new System.Drawing.Point(15, 72);
			this.buttonEject.Name = "buttonEject";
			this.buttonEject.Size = new System.Drawing.Size(115, 69);
			this.buttonEject.TabIndex = 0;
			this.buttonEject.UseVisualStyleBackColor = true;
			this.buttonEject.Click += new System.EventHandler(this.ButtonEjectClick);
			// 
			// buttonInsert
			// 
			this.buttonInsert.Image = ((System.Drawing.Image)(resources.GetObject("buttonInsert.Image")));
			this.buttonInsert.Location = new System.Drawing.Point(144, 72);
			this.buttonInsert.Name = "buttonInsert";
			this.buttonInsert.Size = new System.Drawing.Size(115, 69);
			this.buttonInsert.TabIndex = 1;
			this.buttonInsert.UseVisualStyleBackColor = true;
			this.buttonInsert.Click += new System.EventHandler(this.ButtonInsertClick);
			// 
			// comboBoxDrives
			// 
			this.comboBoxDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDrives.FormattingEnabled = true;
			this.comboBoxDrives.Location = new System.Drawing.Point(15, 36);
			this.comboBoxDrives.Name = "comboBoxDrives";
			this.comboBoxDrives.Size = new System.Drawing.Size(244, 21);
			this.comboBoxDrives.TabIndex = 3;
			// 
			// menuStripMain
			// 
			this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStripMain.Location = new System.Drawing.Point(0, 0);
			this.menuStripMain.Name = "menuStripMain";
			this.menuStripMain.Size = new System.Drawing.Size(284, 24);
			this.menuStripMain.TabIndex = 4;
			this.menuStripMain.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.refreshDrivesToolStripMenuItem,
									this.ejectSelectedToolStripMenuItem,
									this.closeSelectedToolStripMenuItem,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// refreshDrivesToolStripMenuItem
			// 
			this.refreshDrivesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("refreshDrivesToolStripMenuItem.Image")));
			this.refreshDrivesToolStripMenuItem.Name = "refreshDrivesToolStripMenuItem";
			this.refreshDrivesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.refreshDrivesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.refreshDrivesToolStripMenuItem.Text = "&Refresh Drive List";
			this.refreshDrivesToolStripMenuItem.Click += new System.EventHandler(this.RefreshDrivesToolStripMenuItemClick);
			// 
			// ejectSelectedToolStripMenuItem
			// 
			this.ejectSelectedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ejectSelectedToolStripMenuItem.Image")));
			this.ejectSelectedToolStripMenuItem.Name = "ejectSelectedToolStripMenuItem";
			this.ejectSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.ejectSelectedToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.ejectSelectedToolStripMenuItem.Text = "&Eject Selected";
			this.ejectSelectedToolStripMenuItem.Click += new System.EventHandler(this.EjectSelectedToolStripMenuItemClick);
			// 
			// closeSelectedToolStripMenuItem
			// 
			this.closeSelectedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeSelectedToolStripMenuItem.Image")));
			this.closeSelectedToolStripMenuItem.Name = "closeSelectedToolStripMenuItem";
			this.closeSelectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.closeSelectedToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.closeSelectedToolStripMenuItem.Text = "&Load Selected";
			this.closeSelectedToolStripMenuItem.Click += new System.EventHandler(this.CloseSelectedToolStripMenuItemClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 163);
			this.Controls.Add(this.comboBoxDrives);
			this.Controls.Add(this.buttonInsert);
			this.Controls.Add(this.buttonEject);
			this.Controls.Add(this.menuStripMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripMain;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "SharpEject";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStripMain.ResumeLayout(false);
			this.menuStripMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeSelectedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejectSelectedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshDrivesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStripMain;
		private System.Windows.Forms.Button buttonInsert;
		private System.Windows.Forms.ComboBox comboBoxDrives;
		private System.Windows.Forms.Button buttonEject;
	}
}
