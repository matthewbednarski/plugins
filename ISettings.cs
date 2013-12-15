/*
 * Created by SharpDevelop.
 * User: ekr
 * Date: 01/11/2013
 * Time: 08:08
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Plugin
{
	/// <summary>
	/// Description of ISettings.
	/// </summary>
	public interface ISettings : INotifyPropertyChanged
	{
		string this[string index]{get;}
		IDictionary<string, string> Values{get;}
		Boolean HasSetting(String setting);
		void Save(string path = "");
		void Load(string path = "");
	}
}
