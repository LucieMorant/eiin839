using System;
using System.Web;
using System.Diagnostics;
using System.IO;

namespace BasicServerHTTPlistener
{
	class Mymethods
	{
		private Uri uri;

		public Mymethods(Uri uri)
		{
			this.uri = uri;
		}

		public System.Collections.Specialized.NameValueCollection getParameters()
        {
			return HttpUtility.ParseQueryString(uri.Query);
        }

		public String myMethods(System.Collections.Specialized.NameValueCollection parameters)
        {
			String response = "<HTML><BODY> Hello ";
			int paramNb = 0;
			foreach(string key in parameters.AllKeys)
            {
				string[] values = parameters.GetValues(key);
				foreach(string value in values)
                {
					if (paramNb == 0) response += " " + value;
					else response += " et " + value;
                }
				paramNb++;
            }
			response += "</BODY></HTML>";
			return response;
        }

		public String myExternalMethods(System.Collections.Specialized.NameValueCollection parameters)
        {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = @"C:\Users\Lucie\Documents\Polytech\SEMESTRE4\WebSOC\eiin839\TD2\BasicExamplesTD2\ExecTest\bin\Debug\ExecTest.exe";
                int paramNb = 0;
                foreach (string key in parameters.AllKeys)
                {
                    string[] values = parameters.GetValues(key);
                    foreach (string value in values)
                    {
                        start.Arguments += value + " ";
                    }
                    paramNb++;
                }
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                String result;

                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        result = reader.ReadToEnd();
                }
                }
            return result;
            }
        }
    }
