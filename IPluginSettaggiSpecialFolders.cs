/*
 * Created by SharpDevelop.
 * User: ekr
 * Date: 19/01/2011
 * Time: 11.28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.Reflection;
using MVVm.Core;

namespace Plugin
{
	public interface IPluginSettaggiSpecialFolders:INotifyPropertyChanged
	{
		string GetNewTemporyFilePath(string suffix);
		bool IsFileTemp(string file);
		string EkrpeLoginUser { get; }
		FileInfo EkrpeLoginFile { get; }
		char[] EkrpeLoginFileContents { get; }
		DirectoryInfo EkrProgramsDir { get; }
		DirectoryInfo EkrAuthorProgramDir { get; }
		DirectoryInfo EkrSelectorProgramDir { get; }
		DirectoryInfo EkrpeAppData { get; }
		DirectoryInfo EkrUserDir { get; }
		DirectoryInfo EkrAuthorData { get; }
		DirectoryInfo EkrAuthorBackupDir { get; }
		DirectoryInfo EkrLogDir { get; }
		string EkrpeSchemaDir { get; set; }
		DirectoryInfo TempDir { get; }
	}
}
