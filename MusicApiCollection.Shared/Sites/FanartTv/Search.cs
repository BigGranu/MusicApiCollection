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
using System.Collections.Generic;
using MusicApiCollection.Events;
using MusicApiCollection.Sites.FanartTv.Data;

namespace MusicApiCollection.Sites.FanartTv
{
    /// <summary>
    ///     Search all Informations for Movie
    /// </summary>
    public class Search
    {
        private static readonly Logging Logging = Logging.GetInstance();
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     Get Images for Movie
        /// </summary>
        /// <param name="imdbTmdbId">Numeric tmdb_id or imdb_id of the movie.</param>
        /// <param name="apiKey">Users api_key</param>
        /// <param name="clientKey">Users client_key</param>
        public static Movie Movie(string imdbTmdbId, string apiKey = "", string clientKey = "")
        {
            var ret = new Movie();

            if (apiKey == "")
                apiKey = Settings.FanartTv.ApiKey;

            if (clientKey == "")
                clientKey = Settings.FanartTv.ClientKey;

            var le = new LogEntry("Sites.FanartTv", "Search", "Movie");
            le.Parameters.Add(new Para("imdbTmdbId", imdbTmdbId));
            le.Parameters.Add(new Para("apiKey", apiKey));
            le.Parameters.Add(new Para("clientKey", clientKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<MovieResult>(clientKey != ""
                    ? Http.Request(Settings.FanartTv.Server + "movies/" + imdbTmdbId + "?api_key=" + apiKey + "&client_key=" + clientKey)
                    : Http.Request(Settings.FanartTv.Server + "movies/" + imdbTmdbId + "?api_key=" + apiKey)) ?? new MovieResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Movie(ret.Data);
        }

        /// <summary>
        ///     Get images for Latest Movies
        /// </summary>
        /// <param name="apiKey">Users api_key</param>
        /// <param name="clientKey">Users client_key</param>
        public static MovieLatest LatestMovie(string apiKey = "", string clientKey = "")
        {
            var ret = new MovieLatest();

            if (apiKey == "")
                apiKey = Settings.FanartTv.ApiKey;

            if (clientKey == "")
                clientKey = Settings.FanartTv.ClientKey;

            var le = new LogEntry("Sites.FanartTv", "Search", "LatestMovie");
            le.Parameters.Add(new Para("apiKey", apiKey));
            le.Parameters.Add(new Para("clientKey", clientKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<List<MovieLatestResult>>(clientKey != ""
                    ? Http.Request(Settings.FanartTv.Server + "movies/latest?api_key=" + apiKey + "&client_key=" + clientKey)
                    : Http.Request(Settings.FanartTv.Server + "movies/latest?api_key=" + apiKey)) ?? new List<MovieLatestResult>();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new MovieLatest(ret.Data);
        }

        /// <summary>
        ///     Get images for a TvShow
        /// </summary>
        /// <param name="theTvBbId">thetvdb id for the show.</param>
        /// <param name="apiKey">Users api_key</param>
        /// <param name="clientKey">Users client_key</param>
        public static TvShow TvShow(string theTvBbId, string apiKey = "", string clientKey = "")
        {
            var ret = new TvShow();

            if (apiKey == "")
                apiKey = Settings.FanartTv.ApiKey;

            if (clientKey == "")
                clientKey = Settings.FanartTv.ClientKey;

            var le = new LogEntry("Sites.FanartTv", "Search", "TvShow");
            le.Parameters.Add(new Para("theTvBbId", theTvBbId));
            le.Parameters.Add(new Para("apiKey", apiKey));
            le.Parameters.Add(new Para("clientKey", clientKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<TvShowResult>(clientKey != ""
                    ? Http.Request(Settings.FanartTv.Server + "tv/" + theTvBbId + "?api_key=" + apiKey + "&client_key=" + clientKey)
                    : Http.Request(Settings.FanartTv.Server + "tv/" + theTvBbId + "?api_key=" + apiKey)) ?? new TvShowResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new TvShow(ret.Data);
        }

        /// <summary>
        ///     Get images for Latest Shows
        /// </summary>
        /// <param name="apiKey">Users api_key</param>
        /// <param name="clientKey">Users client_key</param>
        public static TvLatest LatestTvShow(string apiKey = "", string clientKey = "")
        {
            var ret = new TvLatest();

            if (apiKey == "")
                apiKey = Settings.FanartTv.ApiKey;

            if (clientKey == "")
                clientKey = Settings.FanartTv.ClientKey;

            var le = new LogEntry("Sites.FanartTv", "Search", "LatestTvShow");
            le.Parameters.Add(new Para("apiKey", apiKey));
            le.Parameters.Add(new Para("clientKey", clientKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<List<TvLatestResult>>(clientKey != ""
                    ? Http.Request(Settings.FanartTv.Server + "tv/latest?api_key=" + apiKey + "&client_key=" + clientKey)
                    : Http.Request(Settings.FanartTv.Server + "tv/latest?api_key=" + apiKey)) ?? new List<TvLatestResult>();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new TvLatest(ret.Data);
        }

        /// <summary>
        ///     Get Images for Album
        /// </summary>
        /// <param name="mbId">Albums musicbrainz Release-group id</param>
        /// <param name="apiKey">Users api_key</param>
        /// <param name="clientKey">Users client_key</param>
        public static Album Album(string mbId, string apiKey = "", string clientKey = "")
        {
            var ret = new Album();

            if (apiKey == "")
                apiKey = Settings.FanartTv.ApiKey;

            if (clientKey == "")
                clientKey = Settings.FanartTv.ClientKey;

            var le = new LogEntry("Sites.FanartTv", "Search", "Album");
            le.Parameters.Add(new Para("mbId", mbId));
            le.Parameters.Add(new Para("apiKey", apiKey));
            le.Parameters.Add(new Para("clientKey", clientKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<AlbumResult>(clientKey != ""
                    ? Http.Request(Settings.FanartTv.Server + "music/albums/" + mbId + "?api_key=" + apiKey + "&client_key=" + clientKey)
                    : Http.Request(Settings.FanartTv.Server + "music/albums/" + mbId + "?api_key=" + apiKey)) ?? new AlbumResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Album(ret.Data);
        }

        /// <summary>
        ///     Get Images for Artist
        /// </summary>
        /// <param name="mbId">Musicbrainz id for the artist</param>
        /// <param name="apiKey">Users api_key</param>
        /// <param name="clientKey">Users client_key</param>
        public static Artist Artist(string mbId, string apiKey = "", string clientKey = "")
        {
            var ret = new Artist();

            if (apiKey == "")
                apiKey = Settings.FanartTv.ApiKey;

            if (clientKey == "")
                clientKey = Settings.FanartTv.ClientKey;

            var le = new LogEntry("Sites.FanartTv", "Search", "Artist");
            le.Parameters.Add(new Para("mbId", mbId));
            le.Parameters.Add(new Para("apiKey", apiKey));
            le.Parameters.Add(new Para("clientKey", clientKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<ArtistResult>(clientKey != ""
                    ? Http.Request(Settings.FanartTv.Server + "music/" + mbId + "?api_key=" + apiKey + "&client_key=" + clientKey)
                    : Http.Request(Settings.FanartTv.Server + "music/" + mbId + "?api_key=" + apiKey)) ?? new ArtistResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Artist(ret.Data);
        }

        /// <summary>
        ///     Get Images for Label
        /// </summary>
        /// <param name="mbId">Musicbrainz id for the artist</param>
        /// <param name="apiKey">Users api_key</param>
        /// <param name="clientKey">Users client_key</param>
        public static Label Label(string mbId, string apiKey = "", string clientKey = "")
        {
            var ret = new Label();

            if (apiKey == "")
                apiKey = Settings.FanartTv.ApiKey;

            if (clientKey == "")
                clientKey = Settings.FanartTv.ClientKey;

            var le = new LogEntry("Sites.FanartTv", "Search", "Label");
            le.Parameters.Add(new Para("mbId", mbId));
            le.Parameters.Add(new Para("apiKey", apiKey));
            le.Parameters.Add(new Para("clientKey", clientKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<LabelResult>(clientKey != ""
                    ? Http.Request(Settings.FanartTv.Server + "music/labels/" + mbId + "?api_key=" + apiKey + "&client_key=" + clientKey)
                    : Http.Request(Settings.FanartTv.Server + "music/labels/" + mbId + "?api_key=" + apiKey)) ?? new LabelResult();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new Label(ret.Data);
        }

        /// <summary>
        ///     Get Images for Latest Artists
        /// </summary>
        /// <param name="apiKey">Users api_key</param>
        /// <param name="clientKey">Users client_key</param>
        public static ArtistLatest LatestArtist(string apiKey = "", string clientKey = "")
        {
            var ret = new ArtistLatest();

            if (apiKey == "")
                apiKey = Settings.FanartTv.ApiKey;

            if (clientKey == "")
                clientKey = Settings.FanartTv.ClientKey;

            var le = new LogEntry("Sites.FanartTv", "Search", "LatestArtist");
            le.Parameters.Add(new Para("apiKey", apiKey));
            le.Parameters.Add(new Para("clientKey", clientKey));
            Logging.NewLogEntry(le);

            try
            {
                ret.Data = Json.Deserialize<List<LatestResult>>(clientKey != ""
                    ? Http.Request(Settings.FanartTv.Server + "music/latest?api_key=" + apiKey + "&client_key=" + clientKey)
                    : Http.Request(Settings.FanartTv.Server + "music/latest?api_key=" + apiKey)) ?? new List<LatestResult>();
            }
            catch (Exception ex)
            {
                Exceptions.NewException(ex);
            }

            return new ArtistLatest(ret.Data);
        }
    }
}
