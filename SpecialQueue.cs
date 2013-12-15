/*
 * Created by SharpDevelop.
 * User: ekr
 * Date: 24/11/2013
 * Time: 20:21
 * 
 */
using System;
using System.Collections.Generic;

namespace Plugin
{
	/// <summary>
	/// Found on http://stackoverflow.com/questions/1594375/is-there-a-better-way-to-implement-a-remove-method-for-a-queue
	/// </summary>
	public class SpecialQueue<T>
	{
		LinkedList<T> list = new LinkedList<T>();

		public void Enqueue(T t)
		{
			list.AddLast(t);
		}

		public T Dequeue()
		{
			var result = list.First.Value;
			list.RemoveFirst();
			return result;
		}

		public T Peek()
		{
			return list.First.Value;
		}

		public bool Remove(T t)
		{
			return list.Remove(t);
		}

		public int Count { get { return list.Count; } }
	}
}
