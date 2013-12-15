/*
 * Created by SharpDevelop.
 * User: ekr
 * Date: 08/10/2013
 * Time: 14:38
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Plugin
{
	/// <summary>
	/// Description of ITranslationItem.
	/// </summary>
	public interface ITranslationItem:IDictionary<CultureInfo, string>, INotifyPropertyChanged
	{
		string TranslateKey{get;}
		string CurrentValue{get;}
		IDictionary<CultureInfo, string> Item{get;}
		void OnPropertyChanged(string property);
	}
}
