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
using MusicApiCollection.Events;
using MusicApiCollection.Sites.AcoustID.Data;

namespace MusicApiCollection.Sites.AcoustID
{
    /// <summary>
    ///     Search on AcoustId
    /// </summary>
    public class Search
    {
        private static readonly Logging Logging = Logging.GetInstance();
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="fingerprint"></param>
        /// <param name="clientKey"></param>
        /// <returns></returns>
        public static Lookup Lookup(string duration, string fingerprint, string clientKey = "")
        {
            var ret = new Lookup();

            if (clientKey == "")
                clientKey = Settings.AcoustId.ClientKey;

            var le = new LogEntry("Sites.AcoustId", "Search", "Lookup");
            le.Parameters.Add(new Para("duration", duration));
            le.Parameters.Add(new Para("clientKey", clientKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data =
                    Json.Deserialize<LookupResult>(
                        Http.Request("http://api.acoustid.org/v2/lookup?client=" + clientKey +
                                     "&meta=recordings&recordingids&releases&releaseids&releasegroups&releasegroupids&tracks&duration=" +
                                     duration + "&fingerprint=" + fingerprint)) ?? new LookupResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Lookup(ret.Data);
        }
    }
}
