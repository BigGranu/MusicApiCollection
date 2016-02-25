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

namespace MusicApiCollection.Sites.GraceNote
{
    internal class Commands
    {
        /// <summary>
        ///     Options for a Query
        /// </summary>
        public enum Option
        {
            /// <summary>
            ///     For ALBUM_SEARCHES in SINGLE_BEST mode, you can influence the best match selection with the PREFER_XID option.
            ///     This option favors matches that have an XID (a third-party external ID) that matches the value specified in
            ///     PREFER_XID.
            /// </summary>
            PREFER_XID,

            /// <summary>
            ///     The COVER_SIZE option lets the client applications select an order of preference for the cover art size.
            ///     It does not limit or filter the cover sizes returned by a query, just their order.
            ///     Gracenote strongly encourages the use of the COVER_SIZE option. Specify the order as a comma-separated list in the
            ///     VALUE node.
            ///     Supported sizes are XLARGE, LARGE, SMALL, MEDIUM, and THUMBNAIL.
            ///     The Gracenote Media Recognition Service tries to obtain cover art in the first preferred size.
            ///     If this is not available, it tries for the second size, and so on. Only specify the sizes you want to be ordered.
            ///     By default, Gracenote Media Recognition Service returns images in this order: MEDIUM, LARGE, SMALL, XLARGE, and
            ///     THUMBNAIL.
            /// </summary>
            COVER_SIZE,

            /// <summary>
            ///     The FALLBACK_GENRECOVER option instructs the Gracenote Media Recognition Service to return the album's genre cover
            ///     art if the actual cover art is not available.
            ///     By default, this option is disabled. If the response returns genre cover art the URL attribute TYPE is set to
            ///     GENRE_COVERART.
            /// </summary>
            FALLBACK_GENRECOVER,

            /// <summary>
            /// </summary>
            RETURN_COVER,

            /// <summary>
            /// </summary>
            SELECT_EXTENDED,

            /// <summary>
            ///     The FALLBACK_GENRECOVER option instructs the Gracenote Media Recognition Service to return the album's genre cover
            ///     art if the actual cover art is not available.
            ///     By default, this option is disabled.
            ///     If the response returns genre cover art the URL attribute TYPE is set to GENRE_COVERART.
            /// </summary>
            SELECT_DETAIL
        }

        public static string Mode { get; set; } = "";

        public static string ALBUM_SEARCH(string artist, string albumTitle, string trackTitle)
        {
            return Queries(Query(artist, albumTitle, trackTitle));
        }

        private static string Query(string artist, string albumTitle, string trackTitle)
        {
            var query = "<QUERY CMD=\"ALBUM_SEARCH\">";

            if (Mode != "")
                query += "<MODE>" + Mode + "</MODE>";

            if (artist != null)
                query += "<TEXT TYPE=\"ARTIST\">" + artist + "</TEXT>";

            if (albumTitle != null)
                query += "<TEXT TYPE=\"ALBUM_TITLE\">" + albumTitle + "</TEXT>";

            if (trackTitle != null)
                query += "<TEXT TYPE=\"TRACK_TITLE\">" + trackTitle + "</TEXT>";

            query += "</QUERY>";

            return query;
        }

        private static string Auth()
        {
            return "<AUTH><CLIENT>" + Settings.GraceNote.ClientId + "</CLIENT><USER>" + Settings.GraceNote.UserId +
                   "</USER></AUTH>";
        }

        private static string Queries(string query)
        {
            var q = "<QUERIES><LANG>" + Settings.GraceNote.ResponseLanguage + "</LANG>";
            q += Auth();
            q += query;
            q += "</QUERIES>";

            return q;
        }
    }
}