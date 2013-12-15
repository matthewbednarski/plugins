/*
 * Matthew Carl Bednarski <matthew.bednarski@ekr.it>
 * 09/05/2013 - 14.11
 */

using System;

namespace Logger
{
	/// <summary>
	/// Description of ILog.
	/// </summary>
	public interface ILog
	{
		LogLevel Level{get;}
		void Debug(String s, params Object[] format);
		void Debug(Exception ex, String s, params Object[] format);
		void Info(String s, params Object[] format);
		void Info(Exception ex, String s, params Object[] format);
		void Error(String s, params Object[] format);
		void Error(Exception ex, String s, params Object[] format);
		void Fatal(String s, params Object[] format);
		void Fatal(Exception ex, String s, params Object[] format);
		void Warn(String s, params Object[] format);
		void Warn(Exception ex, String s, params Object[] format);
	}
}
