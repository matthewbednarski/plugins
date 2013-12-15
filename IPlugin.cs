/*
 * Created by SharpDevelop.
 * User: ekr
 * Date: 07/10/2013
 * Time: 17:32
 * 
 */
using System;
using System.ComponentModel;
using MVVm.Core;

namespace Plugin
{
	/// <summary>
	/// Description of IPlugin.
	/// </summary>
	public interface IPlugin: INotifyPropertyChanged
	{
		Mediator Mediator{get;}
		string Name
		{
			get;
		}
		string Label
		{
			get;
		}
		string LabelKey
		{
			get;
		}
		string Location
		{
			get;
		}
		string IconUri
		{
			get;
		}
		bool Activate
		{
			get;
		}
		
	}
}
