using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace ProcLock.Providers
{
    public static class ProcessProvider
    {
        [Flags]
        private enum ThreadAccess : int
        {
            TERMINATE = 0x0001,
            SUSPEND_RESUME = 0x0002
        }

        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, int dwThreadId);
        [DllImport("kernel32.dll")]
        private static extern uint SuspendThread(IntPtr hThread);
        [DllImport("kernel32.dll")]
        private static extern int ResumeThread(IntPtr hThread);

        private static IntPtr Search(int id)
        {
            foreach (ProcessThread pt in Process.GetProcessById(id).Threads)
            {
                var openThd = OpenThread(ThreadAccess.SUSPEND_RESUME, false, pt.Id);

                if (openThd != IntPtr.Zero)
                    return openThd;
            }

            return IntPtr.Zero;
        }

        public static void Suspend(int id)
        {
            SuspendThread(Search(id));
        }

        public static void Resume(int id)
        {
            ResumeThread(Search(id));
        }
    }
}
