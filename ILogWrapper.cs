using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Logger
{
	public enum LogLevel
	{
		Debug = 0,
		Info,
		Warn,
		Error,
		Fatal
	}
	public interface ILogWrapper
	{
		void log(LogLevel level, Exception ex, string format, params object[] param);
		void Debug(Exception ex, string format, params object[] param);
		void Warn(Exception ex, string format, params object[] param);
		void Info(Exception ex, string format, params object[] param);
		void Fatal(Exception ex, string format, params object[] param);
		void Error(Exception ex, string format, params object[] param);
		void Debug(string format, params object[] param);
		void Warn(string format, params object[] param);
		void Info(string format, params object[] param);
		void Fatal(string format, params object[] param);
		void Error(string format, params object[] param);
		void debug(string format, params object[] param);
		void warn(string format, params object[] param);
		void info(string format, params object[] param);
		void fatal(string format, params object[] param);
		void error(string format, params object[] param);
		void debug(Exception ex, string format, params object[] param);
		void warn(Exception ex, string format, params object[] param);
		void info(Exception ex, string format, params object[] param);
		void fatal(Exception ex, string format, params object[] param);
		void error(Exception ex, string format, params object[] param);
		LogLevel Level { get; }
	}
}
