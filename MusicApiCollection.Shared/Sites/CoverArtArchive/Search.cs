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
using MusicApiCollection.Sites.CoverArtArchive.Data;

namespace MusicApiCollection.Sites.CoverArtArchive
{
    /// <summary>
    ///     Search on CoverArtArchive
    /// </summary>
    public class Search
    {
        private static readonly Logging Logging = Logging.GetInstance();
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     Covers for a Releasegroup
        /// </summary>
        /// <param name="mbid">MusicbrainzId</param>
        /// <example>
        ///     Example shows the typical use of the function
        ///     <code language="vbnet">
        /// Dim ret2 = Search.ReleaseGroup("c31a5e2b-0bf8-32e0-8aeb-ef4ba9973932")
        ///     </code>
        ///     <code language="c#">
        /// var ret2 = Search.ReleaseGroup("c31a5e2b-0bf8-32e0-8aeb-ef4ba9973932");
        ///     </code>
        /// </example>
        /// <returns>
        ///     Covers
        /// </returns>
        public static Covers ReleaseGroup(string mbid)
        {
            Logging.NewLogEntry(new LogEntry("Sites.CoverArtArchive", "Search", "ReleaseGroup", new Para("mbid", mbid)));
      
            var ret = new Covers();

            try
            {
                ret.Data = Json.Deserialize<CoversResult>(Http.Request("http://www.coverartarchive.org/release-group/" + mbid + "/")) ?? new CoversResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Covers(ret.Data);
        }

        /// <summary>
        ///     Covers for a Release
        /// </summary>
        /// <param name="mbid">MusicbrainzId</param>
        /// <example>
        ///     Example shows the typical use of the function
        ///     <code language="vbnet">
        /// Dim ret1 = Search.Release("03f9d988-8555-4cdf-afb1-a29c9487bb15")
        ///     </code>
        ///     <code language="c#">
        /// var ret1 = Search.Release("03f9d988-8555-4cdf-afb1-a29c9487bb15");
        ///     </code>
        /// </example>
        /// <returns>
        ///     Covers
        /// </returns>
        public static Covers Release(string mbid)
        {
            Logging.NewLogEntry(new LogEntry("Sites.CoverArtArchive", "Search", "Release", new Para("mbid", mbid)));

            var ret = new Covers();

            try
            {
                ret.Data = Json.Deserialize<CoversResult>(Http.Request("http://www.coverartarchive.org/release/" + mbid + "/"));
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Covers(ret.Data);
        }
    }
}
