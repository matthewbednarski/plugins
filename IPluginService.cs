/*
 * Matthew Carl Bednarski <matthew.bednarski@ekr.it>
 * 02/04/2013 - 15.35
 */

using System;
using System.Threading;

namespace Plugin
{
	/// <summary>
	/// Description of IEkrService.
	/// </summary>
	public interface IPluginService:IDisposable
	{
		String ServiceName{get;}
		Boolean IsRunning{get;}
		Boolean CanActivate{get;}
		Boolean CanStart{get;}
		ServiceState State
		{
			get;
			set;
		}
		Thread Thrd
		{
			get;
		}
				
		void Start();
		void Stop();
		void Restart();
	}
}
