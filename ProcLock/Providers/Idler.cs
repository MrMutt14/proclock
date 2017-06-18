using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;

using ProcLock.Models;

namespace ProcLock.Providers
{
    class Idler
    {
        [DllImport("user32.dll")]
        private static extern bool GetLastInputInfo(ref LastInputInfo lii);

        public static uint IdleTime()
        {
            LastInputInfo input = new LastInputInfo();
            input.Size = (uint)Marshal.SizeOf(input);

            GetLastInputInfo(ref input);

            return (uint)Environment.TickCount - input.Time;
        }
    }
}
