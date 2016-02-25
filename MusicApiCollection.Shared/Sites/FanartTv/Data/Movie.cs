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

using System.Collections.Generic;
using System.Runtime.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.FanartTv.Data
{
    /// <remarks />
    [DataContract]
    public class Movie
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     All possible Data
        /// </summary>
        public MovieResult Data = new MovieResult();

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred;

        /// <summary>
        ///     Create new Movie and clear the log
        /// </summary>
        public Movie()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new Movie with Result
        /// </summary>
        /// <param name="data">Result</param>
        public Movie(MovieResult data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage { get; set; } = string.Empty;

        /// <summary>
        ///     Response
        /// </summary>
        public string Response { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class MovieResult
    {
        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "tmdb_id")]
        public string TmdbId { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "imdb_id")]
        public string ImdbId { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "hdmovieclearart")]
        public List<MovieArt> Hdmovieclearart { get; set; } = new List<MovieArt>();

        /// <remarks />
        [DataMember(Name = "hdmovielogo")]
        public List<MovieArt> Hdmovielogo { get; set; } = new List<MovieArt>();

        /// <remarks />
        [DataMember(Name = "movieart")]
        public List<MovieArt> Movieart { get; set; } = new List<MovieArt>();

        /// <remarks />
        [DataMember(Name = "moviebackground")]
        public List<MovieArt> Moviebackground { get; set; } = new List<MovieArt>();

        /// <remarks />
        [DataMember(Name = "movieposter")]
        public List<MovieArt> Movieposter { get; set; } = new List<MovieArt>();

        /// <remarks />
        [DataMember(Name = "movielogo")]
        public List<MovieArt> Movielogo { get; set; } = new List<MovieArt>();

        /// <remarks />
        [DataMember(Name = "moviedisc")]
        public List<MovieDisc> Moviedisc { get; set; } = new List<MovieDisc>();

        /// <remarks />
        [DataMember(Name = "moviethumb")]
        public List<MovieArt> Moviethumb { get; set; } = new List<MovieArt>();

        /// <remarks />
        [DataMember(Name = "moviebanner")]
        public List<MovieArt> Moviebanner { get; set; } = new List<MovieArt>();
    }

    /// <remarks />
    [DataContract]
    public class MovieArt
    {
        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "url")]
        public string Url { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "lang")]
        public string Lang { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "likes")]
        public string Likes { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class MovieDisc
    {
        /// <remarks />
        [DataMember(Name = "id")]
        public string Id { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "url")]
        public string Url { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "lang")]
        public string Lang { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "likes")]
        public string Likes { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "disc")]
        public string Disc { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "disc_type")]
        public string DiscType { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class MovieLatest
    {
        private static readonly Exceptions Exceptions = Exceptions.GetInstance();

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred;

        /// <summary>
        ///     Create new MovieLatest and clear the log
        /// </summary>
        public MovieLatest()
        {
            Logging.Clear();
        }

        /// <summary>
        ///     Create new MovieLatest with Result
        /// </summary>
        /// <param name="data">Result</param>
        public MovieLatest(List<MovieLatestResult> data)
        {
            Data = data;
            ErrorMessage = Exceptions.Message;
            ErrorOccurred = Exceptions.ErrorOccurred;
            Response = Http.LastResponse;
        }

        /// <summary>
        ///     All possible Data
        /// </summary>
        public List<MovieLatestResult> Data { get; set; } = new List<MovieLatestResult>();

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage { get; set; } = string.Empty;

        /// <summary>
        ///     Response
        /// </summary>
        public string Response { get; set; } = string.Empty;
    }

    /// <remarks />
    [DataContract]
    public class MovieLatestResult
    {
        /// <remarks />
        [DataMember(Name = "tmdb_id")]
        public string TmdbId { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "imdb_id")]
        public string ImdbId { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "name")]
        public string Name { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "new_images")]
        public string NewImages { get; set; } = string.Empty;

        /// <remarks />
        [DataMember(Name = "total_images")]
        public string TotalImages { get; set; } = string.Empty;
    }
}