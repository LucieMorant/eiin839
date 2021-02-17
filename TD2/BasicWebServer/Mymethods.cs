using System;
using System.Web;

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
	}
}
