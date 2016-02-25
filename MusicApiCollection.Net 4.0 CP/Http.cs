#region Copyright (C) 2015-2016 BigGranu
/*
    Copyright (C) 2015-2016 BigGranu

    This file is part of mInfo <https://github.com/BigGranu/MusicApiCollection>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
#endregion

using System;
using System.IO;
using System.Net;
using System.Text;
using MusicApiCollection.Events;

namespace MusicApiCollection
{
    /// <summary>
    /// Http Functions
    /// </summary>
    internal class Http
    {
        public static string LastResponse { get; set; } = string.Empty;
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     Make a Webrequest
        /// </summary>
        /// <param name="url">Url</param>
        /// <returns></returns>
        public static string Request(string url)
        {
            LastResponse = string.Empty;

            try
            {
                var request = WebRequest.Create(url);
                request.Headers = new WebHeaderCollection();

                var proxy = WebRequest.GetSystemWebProxy();
                proxy.Credentials = CredentialCache.DefaultCredentials;
                request.Proxy = proxy;

                var response = request.GetResponse();
                var dataStream = response.GetResponseStream();

                if (dataStream != null)
                {
                    var reader = new StreamReader(dataStream);
                    LastResponse = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
                return string.Empty;
            }

            return LastResponse;
        }

        /// <summary>
        ///     Make a Webrequest on FreeDB with POST
        /// </summary>
        /// <param name="command">Data to Post</param>
        /// <param name="url">URL</param>
        /// <returns></returns>
        public static string Post(string command, string url)
        {
            LastResponse = string.Empty;

            try
            {
                var request = WebRequest.Create(url);
                request.Method = "POST";
                request.Timeout = Settings.Http.HttpWebRequestTimeout;

                var proxy = WebRequest.GetSystemWebProxy();
                proxy.Credentials = CredentialCache.DefaultCredentials;
                request.Proxy = proxy;

                var byteArray = Encoding.UTF8.GetBytes(command);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;

                var dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                var response = request.GetResponse();
                dataStream = response.GetResponseStream();

                if (dataStream != null)
                {
                    var reader = new StreamReader(dataStream, Encoding.Default);
                    LastResponse = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
                return string.Empty;
            }

            return LastResponse;
        }
    }
}
