/*
 * Created by SharpDevelop.
 * User: ekr
 * Date: 14/11/2013
 * Time: 10:59
 * 
 */
using System;
using Logger;

namespace Plugin
{
	/// <summary>
	/// Description of DebugConsolLogWrapper.
	/// </summary>
	public class DebugConsolLogWrapper : ILogWrapper
	{
		public DebugConsolLogWrapper()
		{
			this._level = LogLevel.Debug;
		}
		public DebugConsolLogWrapper(LogLevel level)
		{
			this._level = level;
		}
		
		private LogLevel _level;
		public LogLevel Level {
			get {
				return _level;
			}
		}
		
		public void log(LogLevel level, Exception ex, string format, params object[] param)
		{
			switch(level)
			{
				case LogLevel.Info:
					this.Info(ex, format, param);
					break;
				case LogLevel.Debug:
					this.Debug(ex, format, param);
					break;
				case LogLevel.Error:
					this.Error(ex, format, param);
					break;
				case LogLevel.Fatal:
					this.Fatal(ex, format, param);
					break;
				case LogLevel.Warn:
					this.Warn(ex, format, param);
					break;
			}
			
		}
		public const string DEBUG = "Debug: ";
		public const string INFO = "Info: ";
		public const string WARN = "Warn: ";
		public const string ERROR = "Error: ";
		public const string FATAL = "Fatal: ";
		
		public void Debug(Exception ex, string format, params object[] param)
		{
			if(this.Level >= LogLevel.Debug)
			{
				if(ex != null)
				{
					System.Diagnostics.Debug.WriteLine(DEBUG + ex.Message);
				}
				System.Diagnostics.Debug.WriteLine(DEBUG + format, param);
			}
		}
		
		public void Warn(Exception ex, string format, params object[] param)
		{
			if(this.Level >= LogLevel.Warn)
			{
				if(ex != null)
				{
					System.Diagnostics.Debug.WriteLine(WARN + ex.Message);
				}
				System.Diagnostics.Debug.WriteLine(WARN + format, param);
			}
		}
		
		public void Info(Exception ex, string format, params object[] param)
		{
			if(this.Level >= LogLevel.Info)
			{
				if(ex != null)
				{
					System.Diagnostics.Debug.WriteLine(INFO + ex.Message);
				}
				System.Diagnostics.Debug.WriteLine(INFO + format, param);
			}
		}
		
		public void Fatal(Exception ex, string format, params object[] param)
		{
			if(this.Level >= LogLevel.Fatal)
			{
				if(ex != null)
				{
					System.Diagnostics.Debug.WriteLine(FATAL + ex.Message);
				}
				System.Diagnostics.Debug.WriteLine( FATAL + format, param);
			}
		}
		
		public void Error(Exception ex, string format, params object[] param)
		{
			if(this.Level >= LogLevel.Error)
			{
				if(ex != null)
				{
					System.Diagnostics.Debug.WriteLine(ERROR + ex.Message);
				}
				System.Diagnostics.Debug.WriteLine(ERROR + format, param);
			}
		}
		
		public void Debug(string format, params object[] param)
		{
			this.Debug(null, format, param);
		}
		
		public void Warn(string format, params object[] param)
		{
			this.Warn(null, format, param);
		}
		
		public void Info(string format, params object[] param)
		{
			this.Info(null, format, param);
		}
		
		public void Fatal(string format, params object[] param)
		{
			this.Fatal(null, format, param);
		}
		
		public void Error(string format, params object[] param)
		{
			this.Error(null, format, param);
		}
		
		public void debug(string format, params object[] param)
		{
			this.Debug(null, format, param);
		}
		
		public void warn(string format, params object[] param)
		{
			this.Warn(null, format, param);
		}
		
		public void info(string format, params object[] param)
		{
			this.Info(null, format, param);
		}
		
		public void fatal(string format, params object[] param)
		{
			this.Fatal(null, format, param);
		}
		
		public void error(string format, params object[] param)
		{
			this.Error(null, format, param);
		}
		
		public void debug(Exception ex, string format, params object[] param)
		{
			this.Debug(ex, format, param);
		}
		
		public void warn(Exception ex, string format, params object[] param)
		{
			this.Warn(ex, format, param);
		}
		
		public void info(Exception ex, string format, params object[] param)
		{
			this.Info(ex, format, param);
		}
		
		public void fatal(Exception ex, string format, params object[] param)
		{
			this.Fatal(ex, format, param);
		}
		
		public void error(Exception ex, string format, params object[] param)
		{
			this.Error(ex, format, param);
		}
	}
}
