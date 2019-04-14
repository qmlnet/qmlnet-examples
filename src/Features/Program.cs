using System;
using System.IO;
using System.Runtime.InteropServices;
using Qml.Net;
using Qml.Net.Runtimes;

namespace Features
{
    class Program
    {
        [DllImport("QmlNet")]
        internal static extern long qml_net_getVersion();

        static int Main(string[] args)
        {
            // This is need to prep Qt runtime that QmlNet.dll depends on.
            // It is required, but it is irrelvant to the issue we are experiencing.
            RuntimeManager.DiscoverOrDownloadSuitableQtRuntime();

            // The following works on netcoreapp2.2, but not on 4.7.2.
            Console.WriteLine(qml_net_getVersion());

            return 0;
        }
    }
}
