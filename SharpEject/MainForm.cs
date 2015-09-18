#region description
/*
 * MainForm of SharpEject app
 * Copyright (C) 2011-2015, Petros Kyladitis
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/>
 */
 #endregion
 
using System ;
using System.Collections.Generic ;
using System.Drawing ;
using System.Windows.Forms ;

namespace SharpEject{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form{
		
		TrayOperations tray ;
	
		public MainForm(){
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent() ;
			
			//add tooltips
			this.toolTip.SetToolTip(this.buttonEject, "Eject selected drive.") ;
			this.toolTip.SetToolTip(this.buttonInsert, "Load selected drive.") ;
			this.toolTip.SetToolTip(this.comboBoxDrives, "System drives list. Select a drive to operate.");
		}
		
		private void LoadDrivesList(){
			//clear comboBox from any existed item
			comboBoxDrives.Items.Clear() ;
			
			//initialize the TrayOperations object
			tray = new TrayOperations() ;
			
			//load drives data to comboBoxDrives
			for(int i=0; i<tray.Drives.GetLength(0); i++)
				comboBoxDrives.Items.Add(string.Concat(tray.Drives[i,0]," [",tray.Drives[i,1],"]")) ;
			
			//select the first drive
			comboBoxDrives.SelectedIndex = 0 ;			
		}
		
		private void EjectDriveTray(){
			//open the tray of selectet drive (drive's letter is the 1st char of the sel. item)
			try{
				tray.EjectTray(comboBoxDrives.SelectedItem.ToString().Substring(0,1)) ;
			}catch(Exception exc){ //if any exception thrown show the message
				MessageBox.Show(this, exc.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error) ;
			}			
		}
		
		private void CloseDriveTray(){
			//close the tray of selectet drive (drive's letter is the 1st char of the sel. item)
			try{
				tray.CloseTray(comboBoxDrives.SelectedItem.ToString().Substring(0,1)) ;
			}catch(Exception exc){ //if any exception thrown show the message
				MessageBox.Show(this, exc.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error) ;
			}				
		}
		
		void MainFormLoad(object sender, EventArgs e){
			LoadDrivesList() ;
		}
		
		void ButtonEjectClick(object sender, EventArgs e){
			EjectDriveTray() ;
		}
		
		void ButtonInsertClick(object sender, EventArgs e){
			CloseDriveTray() ;
		}
		
		void RefreshDrivesToolStripMenuItemClick(object sender, EventArgs e){
			LoadDrivesList() ;
		}
		
		void EjectSelectedToolStripMenuItemClick(object sender, EventArgs e){
			EjectDriveTray() ;
		}
		
		void CloseSelectedToolStripMenuItemClick(object sender, EventArgs e){
			CloseDriveTray() ;
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e){
			Application.Exit() ;
		}
		
		void AboutToolStripMenuItemClick(object sender, EventArgs e){
			MessageBox.Show(this, "SharpEject - Ver 1.0.5\nCopyright (c) 2011-2015, Petros Kyladitis  <http://www.multipetros.gr/>\n\nA tool for Eject and Load the tray of any CD/DVD-Rom drive on your computer via software.\n\nThis program is free software distributed under the GNU GPL 3, for license details see at 'license.txt' file, distributed with this program, or see at <http://www.gnu.org/licenses/>.", "About the program", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
		}
	}
}
