/*
 * Created by SharpDevelop.
 * User: ekr
 * Date: 07/10/2013
 * Time: 19:42
 * 
 */
using System;
using System.Collections.Generic;

namespace Plugin
{
	/// <summary>
	/// Description of ITranslationItem.
	/// </summary>
	public interface ITranslationItems:IDictionary<string, ITranslationItem>
	{
		IDictionary<string, ITranslationItem> Items{get;}
	
	}
}
