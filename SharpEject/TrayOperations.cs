#region description
/*
 * TrayOperations class
 * Copyright (C) 2011-2015, Petros Kyladitis
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/>
 */
 #endregion

using System ;
using System.Collections ;
using System.Management ;
using System.Runtime.InteropServices ; //call unmanaged winmm.dll methods
using System.Text ; //need StringBuilder class for mciSendString method construction

namespace SharpEject{
	/// <summary>
	/// Detect all cd drives, provide info about them (letter and name) and methods to eject & close tray
	/// </summary>
	public class TrayOperations{

		// Using mciSendString method of old winmm.dll to open & close tray
		[DllImport("winmm.dll")]
		static extern Int32 mciSendString(String command, StringBuilder buffer, Int32 bufferSize, IntPtr hwndCallback);
		
		//2d array to store drives data [leter,name]
		private string[,] drives ;

		//class constructor, search system for cd drives and store their info at initialized array
		public TrayOperations(){
			//using WMI to find system optical drives info
			ManagementObjectSearcher cdDriveSearch = new ManagementObjectSearcher("Select * from Win32_CDROMDrive") ;
			
			//founded drives, to initialize the array lenght
			int drivesCounter = cdDriveSearch.Get().Count ;
			drives = new string[drivesCounter, 2] ;
			
			//for every founded drive, store letter and info to the array, beggining 
			//from the last array pos, because of reversed founded drive collection
			foreach(var item in cdDriveSearch.Get()){
				--drivesCounter ;
				drives[drivesCounter,0] = (string)item["Drive"] ;
				drives[drivesCounter,1] = (string)item["Name"] ;
			}
		}
		
		//Property to access drives array
		public string[,] Drives{
			get{ return this.drives ; }
		}
		
		//Check if a driveletter exist
		//using of StartWith comparator method, to include the case of X or X:
		private bool DriveExist(string driveLetter){
			for(int i=0; i<drives.Length; i++){
				if(drives[i,0].StartsWith(driveLetter))
					return true ;
			}
			return false ;
		}

		//Eject the Tray of passed driveLetter, making call to winmm.dll mciSendString method
		//if driveLetter not an exist cd drive, throws an exception
		public void EjectTray(string driveLetter){
			if(!DriveExist(driveLetter))
				throw new Exception(string.Concat("CD-Drive ",driveLetter," not available.")) ;

			driveLetter = driveLetter.Substring(0,1) ; //save only the letter for use in mciSendString construnt
			
			mciSendString(string.Concat("open ",driveLetter,": type CDAudio alias drive",driveLetter), null, 0, IntPtr.Zero);
			mciSendString(string.Concat("set drive",driveLetter," door open"), null, 0, IntPtr.Zero);			
		}

		//Close the Tray of passed driveLetter, making call to winmm.dll mciSendString method
		//if driveLetter not an exist cd drive, throws an exception
		public void CloseTray(string driveLetter){
			if(!DriveExist(driveLetter))
				throw new Exception(string.Concat("CD-Drive ",driveLetter," not available.")) ;
			
			driveLetter = driveLetter.Substring(0,1) ; //save only the letter for use in mciSendString construnt
			
			mciSendString(string.Concat("open ",driveLetter,": type CDAudio alias drive",driveLetter), null, 0, IntPtr.Zero);
			mciSendString(string.Concat("set drive",driveLetter," door closed"), null, 0, IntPtr.Zero);
		}		
	}
}
