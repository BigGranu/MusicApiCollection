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
using System.Collections.Generic;
using MusicApiCollection.Events;
using MusicApiCollection.Sites.Discogs.Data;

namespace MusicApiCollection.Sites.Discogs
{
    /// <summary>
    ///     Search on Discogs
    /// </summary>
    public class Search
    {
        private static readonly Logging Logging = Logging.Instance;
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     Searchtype
        /// </summary>
        public enum Type
        {
            /// <summary>
            ///     Search a Release
            /// </summary>
            RELEASE,

            /// <summary>
            ///     Search a Master
            /// </summary>
            MASTER,

            /// <summary>
            ///     Search a Artist
            /// </summary>
            ARTIST,

            /// <summary>
            ///     Search a Label
            /// </summary>
            LABEL,

            /// <summary>
            ///     Search Nothing
            /// </summary>
            NULL
        }

        /// <summary>
        ///     The Release resource represents a particular physical or digital object released by one or more Artists.
        /// </summary>
        /// <param name="id">The Release ID</param>
        /// <param name="key">User Key</param>
        /// <param name="secretKey">User Secret Key</param>
        /// <returns></returns>
        public static Release Release(string id, string key = "", string secretKey = "")
        {
            var ret = new Release();

            if (key == "")
                key = Settings.Discogs.Key;

            if (secretKey == "")
                secretKey = Settings.Discogs.SecretKey;

            var le = new LogEntry("Sites.Discogs", "Search", "Release");
            le.Parameters.Add(new Para("id", id));
            le.Parameters.Add(new Para("key", key));
            le.Parameters.Add(new Para("secretKey", secretKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data =
                    Json.Deserialize<ReleaseResult>(
                        Http.Request("https://api.discogs.com/releases/" + id + "?key=" + key + "&secret=" + secretKey)) ??
                    new ReleaseResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Release(ret.Data);
        }

        /// <summary>
        ///     The Master resource represents a set of similar Releases. Masters (also known as “master releases”) have a “main
        ///     Release” which is often the chronologically earliest.
        /// </summary>
        /// <param name="id">The Master ID</param>
        /// <param name="key">User Key</param>
        /// <param name="secretKey">User Secret Key</param>
        /// <returns></returns>
        public static MasterRelease MasterRelease(string id, string key = "", string secretKey = "")
        {
            var ret = new MasterRelease();

            if (key == "")
                key = Settings.Discogs.Key;

            if (secretKey == "")
                secretKey = Settings.Discogs.SecretKey;

            var le = new LogEntry("Sites.Discogs", "Search", "MasterRelease");
            le.Parameters.Add(new Para("id", id));
            le.Parameters.Add(new Para("key", key));
            le.Parameters.Add(new Para("secretKey", secretKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data =
                    Json.Deserialize<MasterReleaseResult>(
                        Http.Request("https://api.discogs.com/masters/" + id + "?key=" + key + "&secret=" + secretKey)) ??
                    new MasterReleaseResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new MasterRelease(ret.Data);
        }

        /// <summary>
        ///     Retrieves a list of all Releases that are versions of this master. Accepts Pagination parameters.
        /// </summary>
        /// <param name="id">The Master ID</param>
        /// <param name="key">User Key</param>
        /// <param name="secretKey">User Secret Key</param>
        /// <param name="page">The page you want to request</param>
        /// <param name="perPage">The number of items per page</param>
        /// <returns></returns>
        public static MasterReleaseVersion MasterReleaseVersion(string id, string key = "", string secretKey = "", string page = "", string perPage = "")
        {
            var ret = new MasterReleaseVersion();

            var p = "";

            if (page != "")
                p += "&page=" + page;

            if (perPage != "")
                p += "&per_page=" + page;

            if (key == "")
                key = Settings.Discogs.Key;

            if (secretKey == "")
                secretKey = Settings.Discogs.SecretKey;

            var le = new LogEntry("Sites.Discogs", "Search", "MasterReleaseVersion");
            le.Parameters.Add(new Para("id", id));
            le.Parameters.Add(new Para("key", key));
            le.Parameters.Add(new Para("secretKey", secretKey));
            le.Parameters.Add(new Para("page", page));
            le.Parameters.Add(new Para("perPage", perPage));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data =
                    Json.Deserialize<MasterReleaseVersionResult>(
                        Http.Request("https://api.discogs.com/masters/" + id + "/versions?key=" + key + "&secret=" +
                                     secretKey + p)) ?? new MasterReleaseVersionResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new MasterReleaseVersion(ret.Data);
        }

        /// <summary>
        ///     The Artist resource represents a person in the Discogs database who contributed to a Release in some capacity.
        /// </summary>
        /// <param name="id">The Artist ID</param>
        /// <param name="key">User Key</param>
        /// <param name="secretKey">User Secret Key</param>
        /// <returns></returns>
        public static Artist Artist(string id, string key = "", string secretKey = "")
        {
            var ret = new Artist();

            if (key == "")
                key = Settings.Discogs.Key;

            if (secretKey == "")
                secretKey = Settings.Discogs.SecretKey;

            var le = new LogEntry("Sites.Discogs", "Search", "Artist");
            le.Parameters.Add(new Para("id", id));
            le.Parameters.Add(new Para("key", key));
            le.Parameters.Add(new Para("secretKey", secretKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data =
                    Json.Deserialize<ArtistResult>(
                        Http.Request("https://api.discogs.com/artists/" + id + "?key=" + key + "&secret=" + secretKey)) ??
                    new ArtistResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Artist(ret.Data);
        }

        /// <summary>
        ///     Returns a list of Releases and Masters associated with the Artist.
        /// </summary>
        /// <param name="id">The Artist ID</param>
        /// <param name="key">User Key</param>
        /// <param name="secretKey">User Secret Key</param>
        /// <param name="page">The page you want to request</param>
        /// <param name="perPage">The number of items per page</param>
        /// <returns></returns>
        public static ArtistRelease ArtistRelease(string id, string key = "", string secretKey = "", string page = "", string perPage = "")
        {
            var p = "";

            if (page != "")
                p += "&page=" + page;

            if (perPage != "")
                p += "&per_page=" + page;

            var ret = new ArtistRelease();

            if (key == "")
                key = Settings.Discogs.Key;

            if (secretKey == "")
                secretKey = Settings.Discogs.SecretKey;

            var le = new LogEntry("Sites.Discogs", "Search", "ArtistRelease");
            le.Parameters.Add(new Para("id", id));
            le.Parameters.Add(new Para("key", key));
            le.Parameters.Add(new Para("secretKey", secretKey));
            le.Parameters.Add(new Para("page", page));
            le.Parameters.Add(new Para("perPage", perPage));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data =
                    Json.Deserialize<ArtistReleaseResult>(
                        Http.Request("https://api.discogs.com/artists/" + id + "/releases?key=" + key + "&secret=" +
                                     secretKey + p)) ?? new ArtistReleaseResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new ArtistRelease(ret.Data);
        }

        /// <summary>
        ///     The Label resource represents a label, company, recording studio, location, or other entity involved with Artists
        ///     and Releases. Labels were recently expanded in scope to include things that aren’t labels – the name is an artifact
        ///     of this history.
        /// </summary>
        /// <param name="id">The Label ID</param>
        /// <param name="key">User Key</param>
        /// <param name="secretKey">User Secret Key</param>
        /// <returns></returns>
        public static Label Label(string id, string key = "", string secretKey = "")
        {
            var ret = new Label();

            if (key == "")
                key = Settings.Discogs.Key;

            if (secretKey == "")
                secretKey = Settings.Discogs.SecretKey;

            var le = new LogEntry("Sites.Discogs", "Search", "Label");
            le.Parameters.Add(new Para("id", id));
            le.Parameters.Add(new Para("key", key));
            le.Parameters.Add(new Para("secretKey", secretKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data =
                    Json.Deserialize<LabelResult>(
                        Http.Request("https://api.discogs.com/labels/" + id + "?key=" + key + "&secret=" + secretKey)) ??
                    new LabelResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Label(ret.Data);
        }

        /// <summary>
        ///     Returns a list of Releases associated with the label.
        /// </summary>
        /// <param name="id">The Label ID</param>
        /// <param name="key">User Key</param>
        /// <param name="secretKey">User Secret Key</param>
        /// <param name="page">The page you want to request</param>
        /// <param name="perPage">The number of items per page</param>
        /// <returns></returns>
        public static AllLabelReleases AllLabelReleases(string id, string key = "", string secretKey = "", string page = "", string perPage = "")
        {
            var p = "";

            if (page != "")
                p += "&page=" + page;

            if (perPage != "")
                p += "&per_page=" + page;

            var ret = new AllLabelReleases();

            if (key == "")
                key = Settings.Discogs.Key;

            if (secretKey == "")
                secretKey = Settings.Discogs.SecretKey;

            var le = new LogEntry("Sites.Discogs", "Search", "AllLabelReleases");
            le.Parameters.Add(new Para("id", id));
            le.Parameters.Add(new Para("key", key));
            le.Parameters.Add(new Para("secretKey", secretKey));
            le.Parameters.Add(new Para("page", page));
            le.Parameters.Add(new Para("perPage", perPage));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data =
                    Json.Deserialize<AllLabelReleasesResult>(
                        Http.Request("https://api.discogs.com/labels/" + id + "/releases?key=" + key + "&secret=" +
                                     secretKey + p)) ?? new AllLabelReleasesResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new AllLabelReleases(ret.Data);
        }

        /// <summary>
        ///     Issue a search query to the database.
        /// </summary>
        /// <param name="query">Your search query</param>
        /// <param name="type">One of Release, master, artist, label</param>
        /// <param name="key">User Key</param>
        /// <param name="secretKey">User Secret Key</param>
        /// <param name="page">The page you want to request</param>
        /// <param name="perPage">The number of items per page</param>
        /// <returns></returns>
        public static Query Query(Type type, string query, string key = "",
            string secretKey = "", string page = "", string perPage = "")
        {
            var ret = new Query();

            if (key == "")
                key = Settings.Discogs.Key;

            if (secretKey == "")
                secretKey = Settings.Discogs.SecretKey;

            var le = new LogEntry("Sites.Discogs", "Search", "Query");
            le.Parameters.Add(new Para("type", type.ToString()));
            le.Parameters.Add(new Para("q", query));
            le.Parameters.Add(new Para("key", key));
            le.Parameters.Add(new Para("secretKey", secretKey));
            le.Parameters.Add(new Para("page", page));
            le.Parameters.Add(new Para("perPage", perPage));
            Logging.NewLogEntry(le);

            var search = SearchToString(le.Parameters);

            try
            {
                ret.Data =
                    Json.Deserialize<QueryResult>(
                        Http.Request("https://api.discogs.com/database/search?" + search + "&key=" + key + "&secret=" +
                                     secretKey)) ?? new QueryResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Query(ret.Data);
        }

        /// <summary>
        ///     Issue a search query to the database.
        /// </summary>
        /// <param name="title">Search by combined “Artist Name - Release Title” Title field.</param>
        /// <param name="releaseTitle">Search Release titles.</param>
        /// <param name="credit">Search Release credits.</param>
        /// <param name="artist">Search artist names.</param>
        /// <param name="anv">Search artist ANV.</param>
        /// <param name="label">Search label names.</param>
        /// <param name="genre">Search genres.</param>
        /// <param name="style">Search styles.</param>
        /// <param name="country">Search Release country.</param>
        /// <param name="year">Search Release year.</param>
        /// <param name="format">Search formats.</param>
        /// <param name="catno">Search catalog number.</param>
        /// <param name="barcode">Search barcodes.</param>
        /// <param name="track">Search track titles.</param>
        /// <param name="submitter">Search submitter username.</param>
        /// <param name="contributor">Search contributor usernames.</param>
        /// <param name="key">User Key</param>
        /// <param name="secretKey">User Secret Key</param>
        /// <param name="page">The page you want to request</param>
        /// <param name="perPage">The number of items per page</param>
        /// <returns></returns>
        public static Query Query(string title = "", string releaseTitle = "",
            string credit = "", string artist = "", string anv = "", string label = "", string genre = "",
            string style = "", string country = "", string year = "", string format = "", string catno = "",
            string barcode = "", string track = "", string submitter = "", string contributor = "", string key = "",
            string secretKey = "", string page = "", string perPage = "")
        {
            var ret = new Query();

            if (key == "")
                key = Settings.Discogs.Key;

            if (secretKey == "")
                secretKey = Settings.Discogs.SecretKey;

            var le = new LogEntry("Sites.Discogs", "Search", "Query");
            le.Parameters.Add(new Para("title", title));
            le.Parameters.Add(new Para("releaseTitle", releaseTitle));
            le.Parameters.Add(new Para("credit", credit));
            le.Parameters.Add(new Para("artist", artist));
            le.Parameters.Add(new Para("anv", anv));
            le.Parameters.Add(new Para("label", label));
            le.Parameters.Add(new Para("genre", genre));
            le.Parameters.Add(new Para("style", style));
            le.Parameters.Add(new Para("country", country));
            le.Parameters.Add(new Para("year", year));
            le.Parameters.Add(new Para("format", format));
            le.Parameters.Add(new Para("catno", catno));
            le.Parameters.Add(new Para("barcode", barcode));
            le.Parameters.Add(new Para("track", track));
            le.Parameters.Add(new Para("submitter", submitter));
            le.Parameters.Add(new Para("contributor", contributor));
            le.Parameters.Add(new Para("key", key));
            le.Parameters.Add(new Para("secretKey", secretKey));
            le.Parameters.Add(new Para("page", page));
            le.Parameters.Add(new Para("perPage", perPage));
            Logging.NewLogEntry(le);

            var search = SearchToString(le.Parameters);

            try
            {
                ret.Data =
                    Json.Deserialize<QueryResult>(
                        Http.Request("https://api.discogs.com/database/search?" + search + "&key=" + key + "&secret=" +
                                     secretKey)) ?? new QueryResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Query(ret.Data);
        }

        private static string SearchToString(List<Para> args)
        {
            var le = new LogEntry("Sites.Discogs", "Search", "SearchToString");
            foreach (var a in args)
                le.Parameters.Add(new Para(a.Name, a.Value));

            Logging.NewLogEntry(le);

            var result = string.Empty;

            for (var i = 0; i < args.Count; i++)
            {
                if (args[i].Value == "" || args[i].Value == "Null" || args[i].Name == "key" || args[i].Name == "secretKey") continue;

                if (i == 0)
                {
                    result += "q=" + args[i].Value + "&";
                }
                else
                {
                    result += args[i].Name.ToLower() + "=" + args[i].Value.ToLower() + "&";
                }
            }

            return result.LastIndexOf("&", StringComparison.Ordinal) > 0
                ? result.Substring(0, result.LastIndexOf("&", StringComparison.Ordinal))
                : result;
        }
    }
}