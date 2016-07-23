using System;
using System.Collections;
using System.Collections.Generic;
using RestSharp;

namespace PGODesktop
{
	public static class Utils
	{
		public static string GetHeader(this IRestResponse response, string name){
			String value = null;
			foreach (Parameter param in response.Headers) {
				if (param.Name.ToLower () == name.ToLower()) {
					value = param.Value.ToString ();
				}
			}
			return value;
		}

		public static string GetQuerySection (this string url){
			if(url.Contains("?")){
				return url.Split ('?') [1];
			}
			return "";
		}

		//Bassed off of https://github.com/restsharp/RestSharp/blob/80c1e49f322eebd19519fd79b7dd4c497c469a6e/RestSharp/Authenticators/OAuth/Extensions/StringExtensions.cs
		public static IDictionary<string, string> ParseQueryString(this string query, bool lowercaseKeys){
			if(query == null){
				return new Dictionary<string, string>();
			}

			if(query.StartsWith("?")){
				query = query.Substring (1);
			}

			query = query.Trim ();

			if(query.Length == 0){
				return new Dictionary<string, string>();
			}

			Dictionary<string, string> data = new Dictionary<string, string> ();
			string[] parts = query.Split ('&');
			foreach (string part in parts) {
				string[] bits = part.Split ('=');
				string key = bits [0].Trim ();
				if(lowercaseKeys){
					key = key.ToLower ();
				}
				data.Add (key, bits[1].Trim());
			}
			return data;
		}



	}
}

