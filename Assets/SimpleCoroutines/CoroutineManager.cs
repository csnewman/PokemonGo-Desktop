// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CoroutineManager.cs" company="">
//   
// </copyright>
// <summary>
//   The coroutine manager.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace SimpleCoroutines
{
	/// <summary>
	/// The coroutine manager.
	/// </summary>
	public class CoroutineManager : MonoBehaviour
	{
		#region Static Fields and Constants

		/// <summary>
		/// The coroutines.
		/// </summary>
		private static readonly Dictionary<string, Coroutine> Coroutines;

		/// <summary>
		/// The foreground tasks.
		/// </summary>
		private static readonly List<string> ForegroundTasks;

		/// <summary>
		/// The threads.
		/// </summary>
		private static readonly List<Thread> Threads;

		/// <summary>
		/// The _program closing.
		/// </summary>
		private static bool _programClosing;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes static members of the <see cref="CoroutineManager"/> class.
		/// </summary>
		static CoroutineManager()
		{
			Coroutines = new Dictionary<string, Coroutine>();
			new GameObject("CoroutineManager", new[] { typeof(CoroutineManager) });
			ForegroundTasks = new List<string>();
			Threads = new List<Thread>();
		}

		#endregion

		#region  Methods - Public

		/// <summary>
		/// The start.
		/// </summary>
		/// <param name="id">
		/// The id.
		/// </param>
		/// <param name="block">
		/// The block.
		/// </param>
		public static void Start(string id, IEnumerator block)
		{
			if (Coroutines.ContainsKey(id))
			{
				Debug.LogError("CoroutineManager: Coroutine id '" + id + "' is already in use!");
				return;
			}

			Coroutines[id] = new Coroutine(id, block);
			StartBackground(id);
		}

		/// <summary>
		/// The cancel.
		/// </summary>
		/// <param name="id">
		/// The id.
		/// </param>
		public static void Cancel(string id)
		{
			if (!Coroutines.ContainsKey(id))
			{
				Debug.LogWarning(
					"CoroutineManager: Coroutine '" + id + "' does not exist. You can not cancel none existant coroutine.");
				return;
			}

			if (Coroutines[id].IsCanceled())
			{
				Debug.LogError("CoroutineManager: Coroutine '" + id + "' already canceled. Do not override IsCanceled!");
				return;
			}

			Coroutines[id].SetCanceled(true);
			Coroutines.Remove(id);
		}

		#endregion

		#region  Methods - Private

		/// <summary>
		/// The start background.
		/// </summary>
		/// <param name="id">
		/// The id.
		/// </param>
		private static void StartBackground(string id)
		{
			Thread t = new Thread(() => CoroutineThread(Coroutines[id]));
			Threads.Add(t);
			t.Start();
		}

		/// <summary>
		/// The coroutine thread.
		/// </summary>
		/// <param name="c">
		/// The c.
		/// </param>
		private static void CoroutineThread(Coroutine c)
		{
			while (c.GetBlock().MoveNext() && !c.IsCanceled() && !_programClosing)
			{
				object ret = c.GetBlock().Current;
				if (ret is EnterForeground)
				{
					lock (ForegroundTasks)
					{
						ForegroundTasks.Add(c.GetId());
					}

					return;
				}
				else if (ret is Cancel)
				{
					Cancel(c.GetId());
					return;
				}
			}

			if (!c.IsCanceled() && !_programClosing)
			{
				if (!Coroutines.ContainsKey(c.GetId()))
				{
					Debug.LogError(
						"CoroutineManager: Coroutine '" + c.GetId() +
						"' does not exist. However the coroutine has just finshed. Please report this!");
					return;
				}

				Coroutines.Remove(c.GetId());
			}
		}

		/// <summary>
		/// The coroutine fore.
		/// </summary>
		/// <param name="c">
		/// The c.
		/// </param>
		/// <returns>
		/// The <see cref="IEnumerator"/>.
		/// </returns>
		private static IEnumerator CoroutineFore(Coroutine c)
		{
			while (!_programClosing && c.GetBlock().MoveNext() && !c.IsCanceled())
			{
				object ret = c.GetBlock().Current;
				if (ret is EnterBackground)
				{
					StartBackground(c.GetId());
					yield break;
				}
				else if (ret is Cancel)
				{
					Cancel(c.GetId());
					yield break;
				}
				else
				{
					yield return ret;
				}
			}

			if (!c.IsCanceled() && !_programClosing)
			{
				if (!Coroutines.ContainsKey(c.GetId()))
				{
					Debug.LogError(
						"CoroutineManager: Coroutine '" + c.GetId() +
						"' does not exist. However the coroutine has just finshed. Please report this!");
					yield break;
				}

				Coroutines.Remove(c.GetId());
			}
		}

		/// <summary>
		/// The start.
		/// </summary>
		/// <returns>
		/// The <see cref="IEnumerator"/>.
		/// </returns>
		private IEnumerator Start()
		{
			while (!_programClosing)
			{
				lock (ForegroundTasks)
				{
					foreach (string id in ForegroundTasks)
					{
						if (!Coroutines.ContainsKey(id))
						{
							Debug.LogError(
								"CoroutineManager: Coroutine '" + id + "' does not exist. However the coroutine is trying to enter Foreground!");
							continue;
						}

						this.StartCoroutine(CoroutineFore(Coroutines[id]));
					}

					ForegroundTasks.Clear();
				}

				yield return null;
			}
		}

		/// <summary>
		/// The on application quit.
		/// </summary>
		private void OnApplicationQuit()
		{
			Debug.Log("CoroutineManager: Attempting to close coroutines...");
			_programClosing = true;
			foreach (Thread t in Threads)
			{
				t.Abort();
			}
		}

		/// <summary>
		/// The on application pause.
		/// </summary>
		/// <param name="pauseStatus">
		/// The pause status.
		/// </param>
		private void OnApplicationPause(bool pauseStatus)
		{
			Debug.Log("pause: " + pauseStatus);
		}

		#endregion
	}
}