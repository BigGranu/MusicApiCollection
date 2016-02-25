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
using MusicApiCollection.Sites.GraceNote.Data;

namespace MusicApiCollection.Sites.GraceNote
{
    /// <summary>
    ///     Search on GraceNote
    /// </summary>
    public class Search
    {
        private static readonly Logging Logging = Logging.GetInstance();
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     A single best album search returns the only one album that is the best match for your search criteria. <br />
        ///     Two modes are available for single-best matching: SINGLE_BEST and SINGLE_BEST_COVER. <br />
        ///     In general, use SINGLE_BEST to return the best album match without its cover art. <br />
        ///     To get the single best album and its cover art, use SINGLE_BEST_COVER.
        /// </summary>
        public enum Mode
        {
            /// <summary>
            ///     Returns album metadata, without cover art, based on the specified parameters (one or more of artist name, album
            ///     Title, and track Title). <br />
            ///     Unless there is no match, this query always returns only one album (known as the best match). <br />
            ///     To influence the best match selection, you can use the PREFER_XID option with SINGLE_BEST. <br />
            ///     This option favors matches that have an XID (a third-party external ID) that matches the value specified in
            ///     PREFER_XID
            /// </summary>
            SINGLE_BEST,

            /// <summary>
            ///     Returns album metadata, including cover art, based on artist, album, and track strings. <br />
            ///     Unless there is no match, this query always returns only one album (known as the best match), along with its cover
            ///     art.
            /// </summary>
            SINGLE_BEST_COVER
        }

        /// <summary>
        ///     Search a Album
        /// </summary>
        /// <param name="artist">Artist</param>
        /// <param name="albumTitle">Albumtitle</param>
        /// <param name="trackTitle">Tracktitle</param>
        /// <returns></returns>
        public static Album Album(string artist, string albumTitle, string trackTitle)
        {
            var ret = new Album();

            var le = new LogEntry("Sites.GraceNote", "Search", "Album");
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("albumTitle", albumTitle));
            le.Parameters.Add(new Para("trackTitle", trackTitle));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Xml.Deserialize<AlbumResult>(Http.Post(Commands.ALBUM_SEARCH(artist, albumTitle, trackTitle), Settings.GraceNote.ServerUrl)) ?? new AlbumResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Album(ret.Data);             
        }

        /// <summary>
        ///     Search a Album
        /// </summary>
        /// <param name="artist">Artist</param>
        /// <param name="albumTitle">Albumtitle</param>
        /// <param name="trackTitle">Tracktitle</param>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static Album Album(string artist, string albumTitle, string trackTitle, Mode mode)
        {
            var ret = new Album();

            var le = new LogEntry("Sites.GraceNote", "Search", "Album");
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("albumTitle", albumTitle));
            le.Parameters.Add(new Para("trackTitle", trackTitle));
            le.Parameters.Add(new Para("mode", mode.ToString()));
            Logging.NewLogEntry(le);

            Commands.Mode = mode.ToString();

            try
            {
                ret.Data = Xml.Deserialize<AlbumResult>(Http.Post(Commands.ALBUM_SEARCH(artist, albumTitle, trackTitle), Settings.GraceNote.ServerUrl)) ?? new AlbumResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Album(ret.Data);                
        }
    }
}