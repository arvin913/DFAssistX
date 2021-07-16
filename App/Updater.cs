using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace App
{
    internal class Updater
    {
        internal static void CheckNewVersion(MainForm mainForm)
        {
            return;

        }

        private static Stream GetDownloadStreamByUrl(string url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = "DFA";
                request.Timeout = 20000;

                var response = (HttpWebResponse)request.GetResponse();
                var stream = new MemoryStream();

                response.GetResponseStream().CopyTo(stream);
                return stream;
            }
            catch (Exception ex)
            {
                Log.Ex(ex, "l-updater-error-downloading");
            }

            return null;
        }
    }
}
