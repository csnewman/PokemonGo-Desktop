// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Error22" file="Utils.cs">
//   Copyright (c) 2016 Error22 All Rights Reserved. 
//   See License.txt for License Information.
// </copyright>
// <summary>
//   The utils.
// </summary>
// 
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Google.Protobuf;
using POGOProtos.Networking.Requests;
using RestSharp;

namespace PGODesktop
{
	/// <summary>
	/// The utils.
	/// </summary>
	public static class Utils
	{
		#region  Methods - Public

		/// <summary>
		/// The get header.
		/// </summary>
		/// <param name="response">
		/// The response.
		/// </param>
		/// <param name="name">
		/// The name.
		/// </param>
		/// <returns>
		/// The <see cref="string"/>.
		/// </returns>
		public static string GetHeader(this IRestResponse response, string name)
		{
			string value = null;
			foreach (Parameter param in response.Headers)
			{
				if (param.Name.ToLower() == name.ToLower())
				{
					value = param.Value.ToString();
				}
			}

			return value;
		}

		/// <summary>
		/// The get query section.
		/// </summary>
		/// <param name="url">
		/// The url.
		/// </param>
		/// <returns>
		/// The <see cref="string"/>.
		/// </returns>
		public static string GetQuerySection(this string url)
		{
			if (url.Contains("?"))
			{
				return url.Split('?')[1];
			}

			return string.Empty;
		}

		/// Bassed off of https://github.com/restsharp/RestSharp/blob/80c1e49f322eebd19519fd79b7dd4c497c469a6e/RestSharp/Authenticators/OAuth/Extensions/StringExtensions.cs
		/// <summary>
		/// The parse query string.
		/// </summary>
		/// <param name="query">
		/// The query.
		/// </param>
		/// <param name="lowercaseKeys">
		/// The lowercase keys.
		/// </param>
		/// <returns>
		/// The <see cref="IDictionary"/>.
		/// </returns>
		public static IDictionary<string, string> ParseQueryString(this string query, bool lowercaseKeys)
		{
			if (query == null)
			{
				return new Dictionary<string, string>();
			}

			if (query.StartsWith("?"))
			{
				query = query.Substring(1);
			}

			query = query.Trim();

			if (query.Length == 0)
			{
				return new Dictionary<string, string>();
			}

			Dictionary<string, string> data = new Dictionary<string, string>();
			string[] parts = query.Split('&');
			foreach (string part in parts)
			{
				string[] bits = part.Split('=');
				string key = bits[0].Trim();
				if (lowercaseKeys)
				{
					key = key.ToLower();
				}

				data.Add(key, bits[1].Trim());
			}

			return data;
		}

		/// <summary>
		/// The next u long.
		/// </summary>
		/// <param name="random">
		/// The random.
		/// </param>
		/// <returns>
		/// The <see cref="ulong"/>.
		/// </returns>
		public static ulong NextULong(this Random random)
		{
			byte[] bytes = new byte[8];
			random.NextBytes(bytes);
			return BitConverter.ToUInt64(bytes, 0);
		}

		/// <summary>
		/// The float to u long.
		/// </summary>
		/// <param name="value">
		/// The value.
		/// </param>
		/// <returns>
		/// The <see cref="ulong"/>.
		/// </returns>
		public static ulong FloatToULong(double value)
		{
			return BitConverter.ToUInt64(BitConverter.GetBytes(value), 0);
		}

		/// <summary>
		/// The create request.
		/// </summary>
		/// <param name="type">
		/// The type.
		/// </param>
		/// <param name="message">
		/// The message.
		/// </param>
		/// <returns>
		/// The <see cref="Request"/>.
		/// </returns>
		public static Request CreateRequest(RequestType type, IMessage message)
		{
			return new Request() { RequestType = type, RequestMessage = message.ToByteString() };
		}

		#endregion
	}
}