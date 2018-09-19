using System.Collections.Generic;
using System.Runtime.Serialization;
using MusicApiCollection.Events;

namespace MusicApiCollection.Sites.FanartTv.Data
{
    /// <remarks />
    [DataContract]
    public class MovieLatest
    {
        private static readonly Exceptions Exceptions = Exceptions.Instance;

        /// <summary>
        ///     All possible Data
        /// </summary>
        public List<MovieLatestResult> Data { get; set; }

        /// <summary>
        ///     Error Message
        /// </summary>
        public string ErrorMessage { get; set; } = Exceptions.Message;

        /// <summary>
        ///     Is an Error occurred
        /// </summary>
        public bool ErrorOccurred { get; set; } = Exceptions.ErrorOccurred;

        /// <summary>
        ///     Response
        /// </summary>
        public string Response { get; set; } = string.Empty;

        /// <summary>
        ///     Create new MovieLatest and clear the log
        /// </summary>
        public MovieLatest()
        { 
        }

        /// <summary>
        ///     Create new MovieLatest with Result
        /// </summary>
        /// <param name="data">Result</param>
        public MovieLatest(List<MovieLatestResult> data)
        {
            Data = data;
            Response = Http.LastResponse;
        }
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