using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace SimpleCoroutines
{
    public class CoroutineManager : MonoBehaviour
    {
        private readonly static Dictionary<String, Coroutine> Coroutines;
        private readonly static List<String> ForegroundTasks;
        private readonly static List<Thread> Threads;
        private static bool _programClosing;

        static CoroutineManager()
        {
            Coroutines = new Dictionary<string, Coroutine>();
            new GameObject("CoroutineManager", new Type[] { typeof(CoroutineManager) });
            ForegroundTasks = new List<string>();
            Threads = new List<Thread>();
        }

        public static void Start(String id, IEnumerator block)
        {
            if (Coroutines.ContainsKey(id))
            {
                Debug.LogError("CoroutineManager: Coroutine id '"+id+"' is already in use!");
                return;
            }
            Coroutines[id] = new Coroutine(id, block);
            StartBackground(id);
        }

        public static void Cancel(String id)
        {
            if (!Coroutines.ContainsKey(id))
            {
                Debug.LogWarning("CoroutineManager: Coroutine '" + id + "' does not exist. You can not cancel none existant coroutine.");
                return;
            }
            if (Coroutines[id].IsCanceled())
            {
                Debug.LogError("CoroutineManager: Coroutine '" + id + "' already canceled. Do not override IsCanceled!");
                return;
            }
            Coroutines[id].setCanceled(true);
            Coroutines.Remove(id);
        }

        private static void StartBackground(String id)
        {
            Thread t = new Thread(() => CoroutineThread(Coroutines[id]));
            Threads.Add(t);
            t.Start();
        }

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
                    Debug.LogError("CoroutineManager: Coroutine '" + c.GetId() + "' does not exist. However the coroutine has just finshed. Please report this!");
                    return;
                }
                Coroutines.Remove(c.GetId());
            }
        }

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
                    Debug.LogError("CoroutineManager: Coroutine '" + c.GetId() + "' does not exist. However the coroutine has just finshed. Please report this!");
                    yield break;
                }
                Coroutines.Remove(c.GetId());
            }
        }

        IEnumerator Start()
        {
            while (!_programClosing)
            {
                lock (ForegroundTasks)
                {
                    foreach (String id in ForegroundTasks)
                    {
                        if (!Coroutines.ContainsKey(id))
                        {
                            Debug.LogError("CoroutineManager: Coroutine '" + id + "' does not exist. However the coroutine is trying to enter Foreground!");
                            continue;
                        }
                        StartCoroutine(CoroutineFore(Coroutines[id]));
                    }
                    ForegroundTasks.Clear();
                }
                yield return null;
            }
        }

        void OnApplicationQuit()
        {
            Debug.Log("CoroutineManager: Attempting to close coroutines...");
            _programClosing = true;
            foreach (Thread t in Threads)
            {
                t.Abort();
            }
        }

        void OnApplicationPause(bool pauseStatus)
        {
            Debug.Log("pause: " + pauseStatus);
        }
    }
}
