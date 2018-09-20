#region Copyright (C) 2015-2018 BigGranu
/*
    Copyright (C) 2015-2018 BigGranu

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
    /// <revisionHistory visible="true">
    ///     <revision date="2016.02.25" version="1.0.0.0" author="BigGranu" visible="true">
    ///         erste funktionierende Version
    ///     </revision>
    ///     <revision date="2018.08.14" version="2.0.0.0" author="BigGranu" visible="true">
    ///         diverse Anpassungen beim Bytehandling
    ///     </revision>
    /// </revisionHistory>
    public class Search
    {
        private static readonly Logging Logging = Logging.Instance;
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     <a href="https://musicbrainz.org/doc/Cover_Art_Archive/API#.2Frelease.2F.7Bmbid.7D.2F" target="_blank">Available Cover Art for a MusicBrainz release</a>
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
<<<<<<< HEAD
                ret.Data = Json.Deserialize<CoversResult>(Http.Request("http://coverartarchive.org/release/" + mbid + "/")) ?? new CoversResult();
=======
                ret.Data = Json.Deserialize<CoversResult>(Http.Request("https://coverartarchive.org/release-group/" + mbid + "/")) ?? new CoversResult();
>>>>>>> 531ae5a2944ce4bd4d2b58888f48805290b9bf6b
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Covers(ret.Data);
        }

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
<<<<<<< HEAD
                ret.Data = Json.Deserialize<CoversResult>(Http.Request("http://coverartarchive.org/release-group/" + mbid + "/")) ?? new CoversResult();
=======
                ret.Data = Json.Deserialize<CoversResult>(Http.Request("https://coverartarchive.org/release/" + mbid + "/")) ?? new CoversResult();
>>>>>>> 531ae5a2944ce4bd4d2b58888f48805290b9bf6b
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Covers(ret.Data);
        }
    }
}
