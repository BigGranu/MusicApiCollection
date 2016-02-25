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
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
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
                var handler = new HttpClientHandler();
                HttpResponseMessage httpResponse;

                using (var client = new HttpClient(handler))
                {
                    var httpRequest = new HttpRequestMessage(HttpMethod.Get, url);
                    httpRequest.Headers.UserAgent.ParseAdd(Settings.Http.UserAgent);
                    httpResponse = AsyncHelper.RunSync(() => client.SendAsync(httpRequest));
                }

                LastResponse = httpResponse.Content.ReadAsStringAsync().Result;
                return LastResponse;
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
                return string.Empty;
            }
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

            var handler = new HttpClientHandler();

            try
            {
                HttpResponseMessage httpResponse;
                using (var client = new HttpClient(handler))
                {
                    var httpRequest = new HttpRequestMessage(HttpMethod.Post, url);
                    HttpContent content = new StringContent(command);
                    httpRequest.Content = content;

                    httpResponse = AsyncHelper.RunSync(() => client.SendAsync(httpRequest));
                }

                LastResponse = httpResponse.Content.ReadAsStringAsync().Result;
                return LastResponse;
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
                return string.Empty;
            }
        }

        internal static class AsyncHelper
        {
            private static readonly TaskFactory MyTaskFactory = new
              TaskFactory(CancellationToken.None,
                          TaskCreationOptions.None,
                          TaskContinuationOptions.None,
                          TaskScheduler.Default);

            public static TResult RunSync<TResult>(Func<Task<TResult>> func)
            {
                return MyTaskFactory
                  .StartNew(func)
                  .Unwrap()
                  .GetAwaiter()
                  .GetResult();
            }

            public static void RunSync(Func<Task> func)
            {
                MyTaskFactory
                  .StartNew(func)
                  .Unwrap()
                  .GetAwaiter()
                  .GetResult();
            }
        }
    }
}
